using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the area of the vineyard (square meters): ");
            double vineyardArea = double.Parse(Console.ReadLine());            
            Console.Write("Please enter the resulting weight grapes per square meter (kilograms): ");
            double kgGrapes = double.Parse(Console.ReadLine());
            Console.Write("Please enter the price of one bottle (dollars): ");
            double bottlePrice = double.Parse(Console.ReadLine());
            Console.Write("Please enter the number of workers: ");
            int numberWorkers = int.Parse(Console.ReadLine());

            double totalKgGrape = (vineyardArea * kgGrapes) * 0.4;
            totalKgGrape = Math.Round(totalKgGrape, 2);
            double litersWine = totalKgGrape / 2.5;
            litersWine = Math.Round(litersWine, 2);
            double bottlesWine = litersWine / 1.5;
            bottlesWine = Math.Round(bottlesWine, 0);
            double totalMoney = bottlesWine * bottlePrice;
            totalMoney = Math.Round(totalMoney, 2);
            

            while (numberWorkers < 5)
            {
                Console.WriteLine("Workers are too few. We need to add more.", numberWorkers, numberWorkers++);
            }

            if (bottlesWine <= 100)
            {
                Console.WriteLine($"Forty percent of the all amount of grapes are: {totalKgGrape} kilograms");
                Console.WriteLine($"Total liters of wine are: {litersWine}");
                Console.WriteLine($"{bottlesWine} bottles are not enough for selling"); 
                Console.WriteLine("Workers will not get paid");
            }
            else
            {
                Console.WriteLine($"Forty percent of the total amount of grapes are: {totalKgGrape} kilograms");
                Console.WriteLine($"Total liters of wine are: {litersWine}");
                Console.WriteLine($"{bottlesWine} bottles are enough for selling");
                Console.WriteLine($"Total money from bottle sales are: {totalMoney} dollars");

                double workersSalary = totalMoney / numberWorkers;

                if (workersSalary > 1000)
                {
                    double moneyLeft = totalMoney - (numberWorkers * 1000);

                    Console.WriteLine($"Number of workers are: {numberWorkers}");
                    Console.WriteLine($"Each worker recived the maximum salary of 1000 dollars. " +
                        $"Money left in amount {moneyLeft} are donated for good cause.");
                }
                else
                {
                    Console.WriteLine($"Each worker recived {workersSalary} dolars.");
                }

            }            

            Console.ReadKey();
       
        }
    }
}
