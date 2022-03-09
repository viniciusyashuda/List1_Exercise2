using System;

namespace List1_Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int value, result;

            Console.Write("Enter a number between 1 and 9: ");
            value = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if((value > 0) & (value < 10))
            {

                for(int i = 0; i <= 10; i++)
                {

                    result = value * i;
                    Console.WriteLine("{0} * {1} = {2}", value,i,result);

                }
                
            }
            else
            {

                Console.WriteLine("Please, enter a valid number");

            }

            Console.ReadKey();

        }
    }
}
