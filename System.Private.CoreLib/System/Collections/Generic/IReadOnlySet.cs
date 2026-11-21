using System;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009D6 RID: 2518
	[NullableContext(1)]
	public interface IReadOnlySet<[Nullable(2)] T> : IReadOnlyCollection<T>, IEnumerable<!0>, IEnumerable
	{
		// Token: 0x0600934C RID: 37708
		bool Contains(T item);

		// Token: 0x0600934D RID: 37709
		bool IsProperSubsetOf(IEnumerable<T> other);

		// Token: 0x0600934E RID: 37710
		bool IsProperSupersetOf(IEnumerable<T> other);

		// Token: 0x0600934F RID: 37711
		bool IsSubsetOf(IEnumerable<T> other);

		// Token: 0x06009350 RID: 37712
		bool IsSupersetOf(IEnumerable<T> other);

		// Token: 0x06009351 RID: 37713
		bool Overlaps(IEnumerable<T> other);

		// Token: 0x06009352 RID: 37714
		bool SetEquals(IEnumerable<T> other);
	}
}
