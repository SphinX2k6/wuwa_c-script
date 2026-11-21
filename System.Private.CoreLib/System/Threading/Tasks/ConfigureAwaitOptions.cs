using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000499 RID: 1177
	[Flags]
	public enum ConfigureAwaitOptions
	{
		// Token: 0x04000FD1 RID: 4049
		None = 0,
		// Token: 0x04000FD2 RID: 4050
		ContinueOnCapturedContext = 1,
		// Token: 0x04000FD3 RID: 4051
		SuppressThrowing = 2,
		// Token: 0x04000FD4 RID: 4052
		ForceYielding = 4
	}
}
