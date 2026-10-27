using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Extension
{
	// Token: 0x02000016 RID: 22
	public class Comparer
	{
		// Token: 0x02000036 RID: 54
		public class DescendingComparer<T> : IComparer<T> where T : IComparable<T>
		{
			// Token: 0x0600011D RID: 285 RVA: 0x0000B63F File Offset: 0x0000983F
			[NullableContext(2)]
			public int Compare(T x, T y)
			{
				return Comparer<T>.Default.Compare(y, x);
			}
		}
	}
}
