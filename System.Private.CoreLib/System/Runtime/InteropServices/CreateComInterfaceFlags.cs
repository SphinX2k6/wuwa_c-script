using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005BC RID: 1468
	[Flags]
	public enum CreateComInterfaceFlags
	{
		// Token: 0x0400126F RID: 4719
		None = 0,
		// Token: 0x04001270 RID: 4720
		CallerDefinedIUnknown = 1,
		// Token: 0x04001271 RID: 4721
		TrackerSupport = 2
	}
}
