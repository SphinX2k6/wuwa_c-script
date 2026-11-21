using System;

namespace System
{
	// Token: 0x020001DF RID: 479
	internal sealed class TupleSlim<T1, T2>
	{
		// Token: 0x0600245A RID: 9306 RVA: 0x0006FA95 File Offset: 0x0006DC95
		public TupleSlim(T1 item1, T2 item2)
		{
			this.Item1 = item1;
			this.Item2 = item2;
		}

		// Token: 0x040006C5 RID: 1733
		public readonly T1 Item1;

		// Token: 0x040006C6 RID: 1734
		public readonly T2 Item2;
	}
}
