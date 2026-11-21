using System;
using System.Diagnostics.CodeAnalysis;

namespace System.Collections.Generic
{
	// Token: 0x020009C1 RID: 2497
	internal sealed class HashSetEqualityComparer<T> : IEqualityComparer<HashSet<T>>
	{
		// Token: 0x0600930C RID: 37644 RVA: 0x0016F260 File Offset: 0x0016D460
		public bool Equals(HashSet<T> x, HashSet<T> y)
		{
			if (x == y)
			{
				return true;
			}
			if (x == null || y == null)
			{
				return false;
			}
			EqualityComparer<T> @default = EqualityComparer<T>.Default;
			if (HashSet<T>.EqualityComparersAreEqual(x, y))
			{
				return x.Count == y.Count && y.IsSubsetOfHashSetWithSameComparer(x);
			}
			foreach (T x2 in y)
			{
				bool flag = false;
				foreach (T y2 in x)
				{
					if (@default.Equals(x2, y2))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600930D RID: 37645 RVA: 0x0016F334 File Offset: 0x0016D534
		public int GetHashCode(HashSet<T> obj)
		{
			int num = 0;
			if (obj != null)
			{
				foreach (T t in obj)
				{
					if (t != null)
					{
						num ^= t.GetHashCode();
					}
				}
			}
			return num;
		}

		// Token: 0x0600930E RID: 37646 RVA: 0x0016F39C File Offset: 0x0016D59C
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj is HashSetEqualityComparer<T>;
		}

		// Token: 0x0600930F RID: 37647 RVA: 0x0009FEF2 File Offset: 0x0009E0F2
		public override int GetHashCode()
		{
			return EqualityComparer<T>.Default.GetHashCode();
		}
	}
}
