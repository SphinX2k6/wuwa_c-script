using System;

namespace CSharpScript.Launcher.NetworkDetection
{
	// Token: 0x020001BB RID: 443
	public enum ESendState
	{
		// Token: 0x040007C1 RID: 1985
		ESS_None,
		// Token: 0x040007C2 RID: 1986
		ESS_Compressing,
		// Token: 0x040007C3 RID: 1987
		ESS_Sending,
		// Token: 0x040007C4 RID: 1988
		ESS_Interrupted,
		// Token: 0x040007C5 RID: 1989
		ESS_Fail,
		// Token: 0x040007C6 RID: 1990
		ESS_Done
	}
}
