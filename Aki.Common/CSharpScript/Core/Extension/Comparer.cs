using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Extension
{
	// Token: 0x02000017 RID: 23
	public class Comparer
	{
		// Token: 0x02000058 RID: 88
		public class DescendingComparer<T> : IComparer<T> where T : IComparable<T>
		{
			// Token: 0x06000259 RID: 601 RVA: 0x0001124F File Offset: 0x0000F44F
			[NullableContext(2)]
			public int Compare(T x, T y)
			{
				return Comparer<T>.Default.Compare(y, x);
			}
		}
	}
}
