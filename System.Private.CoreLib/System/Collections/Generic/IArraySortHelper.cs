using System;

namespace System.Collections.Generic
{
	// Token: 0x0200099B RID: 2459
	internal interface IArraySortHelper<TKey>
	{
		// Token: 0x060091A1 RID: 37281
		void Sort(Span<TKey> keys, IComparer<TKey> comparer);

		// Token: 0x060091A2 RID: 37282
		int BinarySearch(TKey[] keys, int index, int length, TKey value, IComparer<TKey> comparer);
	}
}
