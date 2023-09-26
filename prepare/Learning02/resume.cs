using System;

    //Object = resume
    //Responsibilities:  name, list of jobs
    //Behaviors: name then newline and each job on new line

    public class Resume
    {
        public string _name;
        public List<Job> _jobs = new List<Job>();

        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");

            foreach (Job job in _jobs)
            {
                // This calls the Display method on each job
                job.Display();
            }
        }
    }