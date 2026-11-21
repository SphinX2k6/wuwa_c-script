using System;

namespace System.Collections.Generic
{
	// Token: 0x0200099E RID: 2462
	internal interface IArraySortHelper<TKey, TValue>
	{
		// Token: 0x060091C0 RID: 37312
		void Sort(Span<TKey> keys, Span<TValue> values, IComparer<TKey> comparer);
	}
}
