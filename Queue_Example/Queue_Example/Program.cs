using System;
using System.Collections.Generic;


namespace Queue_Example
{
    public class QueueExample
    {
        public static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            names.Enqueue("Bob");
            names.Enqueue("John");
            names.Enqueue("Adam");
            names.Enqueue("Jim");
            names.Enqueue("Danny");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " +names.Peek());
            Console.WriteLine("Dequeue: " + names.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " + names.Peek());
        }
    }
}
