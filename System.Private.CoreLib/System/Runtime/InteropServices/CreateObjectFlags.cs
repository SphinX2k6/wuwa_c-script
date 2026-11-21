using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005BD RID: 1469
	[Flags]
	public enum CreateObjectFlags
	{
		// Token: 0x04001273 RID: 4723
		None = 0,
		// Token: 0x04001274 RID: 4724
		TrackerObject = 1,
		// Token: 0x04001275 RID: 4725
		UniqueInstance = 2,
		// Token: 0x04001276 RID: 4726
		Aggregation = 4,
		// Token: 0x04001277 RID: 4727
		Unwrap = 8
	}
}
