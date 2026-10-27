using System;

namespace CSharpScript.Launcher.NetworkDetection
{
	// Token: 0x020001A9 RID: 425
	public enum EIcmpResponseStatus
	{
		// Token: 0x04000757 RID: 1879
		Success,
		// Token: 0x04000758 RID: 1880
		Timeout,
		// Token: 0x04000759 RID: 1881
		Unreachable,
		// Token: 0x0400075A RID: 1882
		Unresolvable,
		// Token: 0x0400075B RID: 1883
		InternalError,
		// Token: 0x0400075C RID: 1884
		NotImplemented
	}
}
