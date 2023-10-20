using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Initialize the dictionary with an initial capacity if known
        Dictionary<string, int> wordCounts = new Dictionary<string, int>(capacity: 100);

        // Sample list of words
        List<string> words = new List<string> 
        {
            "apple", "banana", "apple", "cherry", "banana", "apple"
        };

        // Populate the dictionary with word counts
        foreach (string word in words)
        {
            // Check if the key (word) exists in the dictionary
            if (wordCounts.ContainsKey(word))
            {
                // Key exists, increment the count
                wordCounts[word]++;
            }
            else
            {
                // Key doesn't exist, add it with a count of 1
                wordCounts[word] = 1;
            }
        }

        // Print word counts
        foreach (var kvp in wordCounts)
        {
            Console.WriteLine($"Word: {kvp.Key}, Count: {kvp.Value}");
        }

        // Check for the existence of a specific word
        string wordToCheck = "banana";
        if (wordCounts.ContainsKey(wordToCheck))
        {
            Console.WriteLine($"{wordToCheck} exists with a count of {wordCounts[wordToCheck]}");
        }
        else
        {
            Console.WriteLine($"{wordToCheck} does not exist in the dictionary.");
        }
    }
}
