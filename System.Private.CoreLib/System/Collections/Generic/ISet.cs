using System;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009D5 RID: 2517
	[NullableContext(1)]
	public interface ISet<[Nullable(2)] T> : ICollection<!0>, IEnumerable<!0>, IEnumerable
	{
		// Token: 0x06009341 RID: 37697
		bool Add(T item);

		// Token: 0x06009342 RID: 37698
		void UnionWith(IEnumerable<T> other);

		// Token: 0x06009343 RID: 37699
		void IntersectWith(IEnumerable<T> other);

		// Token: 0x06009344 RID: 37700
		void ExceptWith(IEnumerable<T> other);

		// Token: 0x06009345 RID: 37701
		void SymmetricExceptWith(IEnumerable<T> other);

		// Token: 0x06009346 RID: 37702
		bool IsSubsetOf(IEnumerable<T> other);

		// Token: 0x06009347 RID: 37703
		bool IsSupersetOf(IEnumerable<T> other);

		// Token: 0x06009348 RID: 37704
		bool IsProperSupersetOf(IEnumerable<T> other);

		// Token: 0x06009349 RID: 37705
		bool IsProperSubsetOf(IEnumerable<T> other);

		// Token: 0x0600934A RID: 37706
		bool Overlaps(IEnumerable<T> other);

		// Token: 0x0600934B RID: 37707
		bool SetEquals(IEnumerable<T> other);
	}
}
