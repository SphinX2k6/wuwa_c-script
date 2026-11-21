using System;

namespace System.Threading
{
	// Token: 0x020003FD RID: 1021
	public struct NativeOverlapped
	{
		// Token: 0x04000D8F RID: 3471
		public IntPtr InternalLow;

		// Token: 0x04000D90 RID: 3472
		public IntPtr InternalHigh;

		// Token: 0x04000D91 RID: 3473
		public int OffsetLow;

		// Token: 0x04000D92 RID: 3474
		public int OffsetHigh;

		// Token: 0x04000D93 RID: 3475
		public IntPtr EventHandle;
	}
}
