using System;
using System.Runtime.Versioning;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005E7 RID: 1511
	public enum PosixSignal
	{
		// Token: 0x040012B8 RID: 4792
		SIGHUP = -1,
		// Token: 0x040012B9 RID: 4793
		SIGINT = -2,
		// Token: 0x040012BA RID: 4794
		SIGQUIT = -3,
		// Token: 0x040012BB RID: 4795
		SIGTERM = -4,
		// Token: 0x040012BC RID: 4796
		[UnsupportedOSPlatform("windows")]
		SIGCHLD = -5,
		// Token: 0x040012BD RID: 4797
		[UnsupportedOSPlatform("windows")]
		SIGCONT = -6,
		// Token: 0x040012BE RID: 4798
		[UnsupportedOSPlatform("windows")]
		SIGWINCH = -7,
		// Token: 0x040012BF RID: 4799
		[UnsupportedOSPlatform("windows")]
		SIGTTIN = -8,
		// Token: 0x040012C0 RID: 4800
		[UnsupportedOSPlatform("windows")]
		SIGTTOU = -9,
		// Token: 0x040012C1 RID: 4801
		[UnsupportedOSPlatform("windows")]
		SIGTSTP = -10
	}
}
