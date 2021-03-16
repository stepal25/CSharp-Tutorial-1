using System;

namespace CSharp_Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello World";

            Console.WriteLine(greeting);

            double price = 1.99;
            Console.WriteLine("Price " + price);

            int myAge = 15;
            Console.WriteLine("My Age: " + myAge);
            
            if ((myAge < 20) && (myAge > 12))
            {
                Console.WriteLine("You are a teenager");
                Console.WriteLine("And you should be in school.");
            }
            else
            {
                if (myAge >= 20)
                {
                    Console.WriteLine("Please go get a job.");
                }
                else
                {
                    Console.WriteLine("Please do your chores.");
                }
            }
        }
    }
}
