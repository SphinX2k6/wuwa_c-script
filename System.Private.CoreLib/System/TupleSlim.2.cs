using System;

namespace System
{
	// Token: 0x020001E0 RID: 480
	internal sealed class TupleSlim<T1, T2, T3>
	{
		// Token: 0x0600245B RID: 9307 RVA: 0x0006FAAB File Offset: 0x0006DCAB
		public TupleSlim(T1 item1, T2 item2, T3 item3)
		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
		}

		// Token: 0x040006C7 RID: 1735
		public readonly T1 Item1;

		// Token: 0x040006C8 RID: 1736
		public readonly T2 Item2;

		// Token: 0x040006C9 RID: 1737
		public readonly T3 Item3;
	}
}
