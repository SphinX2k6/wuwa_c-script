using System;

namespace CSharpScript.Launcher.NetworkDetection
{
	// Token: 0x020001B7 RID: 439
	public enum ESendState
	{
		// Token: 0x04000784 RID: 1924
		ESS_None,
		// Token: 0x04000785 RID: 1925
		ESS_Compressing,
		// Token: 0x04000786 RID: 1926
		ESS_Sending,
		// Token: 0x04000787 RID: 1927
		ESS_Interrupted,
		// Token: 0x04000788 RID: 1928
		ESS_Fail,
		// Token: 0x04000789 RID: 1929
		ESS_Done
	}
}
