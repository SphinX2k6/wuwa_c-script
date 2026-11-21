using System;

namespace System.Threading.Tasks
{
	// Token: 0x020004BB RID: 1211
	[Flags]
	public enum TaskCreationOptions
	{
		// Token: 0x0400105C RID: 4188
		None = 0,
		// Token: 0x0400105D RID: 4189
		PreferFairness = 1,
		// Token: 0x0400105E RID: 4190
		LongRunning = 2,
		// Token: 0x0400105F RID: 4191
		AttachedToParent = 4,
		// Token: 0x04001060 RID: 4192
		DenyChildAttach = 8,
		// Token: 0x04001061 RID: 4193
		HideScheduler = 16,
		// Token: 0x04001062 RID: 4194
		RunContinuationsAsynchronously = 64
	}
}
