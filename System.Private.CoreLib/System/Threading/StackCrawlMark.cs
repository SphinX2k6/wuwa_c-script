using System;

namespace System.Threading
{
	// Token: 0x020003E3 RID: 995
	internal enum StackCrawlMark
	{
		// Token: 0x04000D57 RID: 3415
		LookForMe,
		// Token: 0x04000D58 RID: 3416
		LookForMyCaller,
		// Token: 0x04000D59 RID: 3417
		LookForMyCallersCaller,
		// Token: 0x04000D5A RID: 3418
		LookForThread
	}
}
