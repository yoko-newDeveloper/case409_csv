﻿namespace Case409_csv.model
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class NameAttribute : Attribute
    {
        public string DisplayName { get; }

        public NameAttribute(string displayName)
        {
            DisplayName = displayName;
        }
    }
}
