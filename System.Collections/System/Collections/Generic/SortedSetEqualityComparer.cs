using System;
using System.Diagnostics.CodeAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x02000042 RID: 66
	internal sealed class SortedSetEqualityComparer<T> : IEqualityComparer<SortedSet<T>>
	{
		// Token: 0x06000319 RID: 793 RVA: 0x0000BF4B File Offset: 0x0000A14B
		public SortedSetEqualityComparer(IEqualityComparer<T> memberEqualityComparer) : this(null, memberEqualityComparer)
		{
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000BF55 File Offset: 0x0000A155
		private SortedSetEqualityComparer(IComparer<T> comparer, IEqualityComparer<T> memberEqualityComparer)
		{
			this._comparer = (comparer ?? Comparer<T>.Default);
			this._memberEqualityComparer = (memberEqualityComparer ?? EqualityComparer<T>.Default);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000BF7D File Offset: 0x0000A17D
		public bool Equals(SortedSet<T> x, SortedSet<T> y)
		{
			return SortedSet<T>.SortedSetEquals(x, y, this._comparer);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000BF8C File Offset: 0x0000A18C
		public int GetHashCode(SortedSet<T> obj)
		{
			int num = 0;
			if (obj != null)
			{
				foreach (T t in obj)
				{
					if (t != null)
					{
						num ^= (this._memberEqualityComparer.GetHashCode(t) & int.MaxValue);
					}
				}
			}
			return num;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000BFF8 File Offset: 0x0000A1F8
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			SortedSetEqualityComparer<T> sortedSetEqualityComparer = obj as SortedSetEqualityComparer<T>;
			return sortedSetEqualityComparer != null && this._comparer == sortedSetEqualityComparer._comparer;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000C01F File Offset: 0x0000A21F
		public override int GetHashCode()
		{
			return this._comparer.GetHashCode() ^ this._memberEqualityComparer.GetHashCode();
		}

		// Token: 0x0400009E RID: 158
		private readonly IComparer<T> _comparer;

		// Token: 0x0400009F RID: 159
		private readonly IEqualityComparer<T> _memberEqualityComparer;
	}
}
