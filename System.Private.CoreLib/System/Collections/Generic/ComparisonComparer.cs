using System;

namespace System.Collections.Generic
{
	// Token: 0x020009A9 RID: 2473
	internal sealed class ComparisonComparer<T> : Comparer<T>
	{
		// Token: 0x06009209 RID: 37385 RVA: 0x0016AFDE File Offset: 0x001691DE
		public ComparisonComparer(Comparison<T> comparison)
		{
			this._comparison = comparison;
		}

		// Token: 0x0600920A RID: 37386 RVA: 0x0016AFED File Offset: 0x001691ED
		public override int Compare(T x, T y)
		{
			return this._comparison(x, y);
		}

		// Token: 0x0400225F RID: 8799
		private readonly Comparison<T> _comparison;
	}
}
