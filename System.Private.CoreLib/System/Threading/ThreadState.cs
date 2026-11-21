using System;

namespace System.Threading
{
	// Token: 0x0200043D RID: 1085
	[Flags]
	public enum ThreadState
	{
		// Token: 0x04000E63 RID: 3683
		Running = 0,
		// Token: 0x04000E64 RID: 3684
		StopRequested = 1,
		// Token: 0x04000E65 RID: 3685
		SuspendRequested = 2,
		// Token: 0x04000E66 RID: 3686
		Background = 4,
		// Token: 0x04000E67 RID: 3687
		Unstarted = 8,
		// Token: 0x04000E68 RID: 3688
		Stopped = 16,
		// Token: 0x04000E69 RID: 3689
		WaitSleepJoin = 32,
		// Token: 0x04000E6A RID: 3690
		Suspended = 64,
		// Token: 0x04000E6B RID: 3691
		AbortRequested = 128,
		// Token: 0x04000E6C RID: 3692
		Aborted = 256
	}
}
