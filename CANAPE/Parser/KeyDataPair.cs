//    CANAPE Network Testing Tool
//    Copyright (C) 2014 Context Information Security
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <http://www.gnu.org/licenses/>.


namespace CANAPE.Parser
{
    /// <summary>
    /// This is a special type for use in arrays which allows you to specify the name of the item
    /// </summary>
    /// <typeparam name="T">The type to hold as a value</typeparam>
    public sealed class KeyDataPair<T>
    {
        /// <summary>
        /// Name of the pair
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Value of the pair
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of the pair</param>
        /// <param name="value">Value of the pair</param>
        public KeyDataPair(string name, T value)
        {
            Name = name;
            Value = value;
        }
    }
}
