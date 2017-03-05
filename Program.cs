using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var name = "Mariana";
            
            string initiallyNull;
            initiallyNull = "No longer null!";

            string emptyString1 = "";
            string emptyString2 = String.Empty;

            string friends = "abcdefghijklmnopqrstuvwxyz";

            Console.WriteLine($"emptyString1 is currently empty. Let's add some friends from the alphabet: {emptyString1+friends}. Ahh, how lovely to no longer be lonely, right {name}?");

            Console.WriteLine($"Let's bump up the volume: {friends.ToUpper()}");

            foreach (char letter in name) {
                Console.Write(letter + " ");
            }

        }
    }
}
