using System;

namespace System.Threading
{
	// Token: 0x02000401 RID: 1025
	internal sealed class ReaderWriterCount
	{
		// Token: 0x04000D9D RID: 3485
		public long lockID;

		// Token: 0x04000D9E RID: 3486
		public int readercount;

		// Token: 0x04000D9F RID: 3487
		public int writercount;

		// Token: 0x04000DA0 RID: 3488
		public int upgradecount;

		// Token: 0x04000DA1 RID: 3489
		public ReaderWriterCount next;
	}
}
