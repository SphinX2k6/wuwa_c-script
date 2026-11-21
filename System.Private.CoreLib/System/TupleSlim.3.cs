using System;

namespace System
{
	// Token: 0x020001E1 RID: 481
	internal sealed class TupleSlim<T1, T2, T3, T4>
	{
		// Token: 0x0600245C RID: 9308 RVA: 0x0006FAC8 File Offset: 0x0006DCC8
		public TupleSlim(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
		}

		// Token: 0x040006CA RID: 1738
		public readonly T1 Item1;

		// Token: 0x040006CB RID: 1739
		public readonly T2 Item2;

		// Token: 0x040006CC RID: 1740
		public readonly T3 Item3;

		// Token: 0x040006CD RID: 1741
		public readonly T4 Item4;
	}
}
