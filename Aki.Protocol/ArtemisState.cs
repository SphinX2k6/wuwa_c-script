using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015C8 RID: 5576
	public enum ArtemisState
	{
		// Token: 0x0400A9F7 RID: 43511
		[OriginalName("ArtemisLocked")]
		ArtemisLocked,
		// Token: 0x0400A9F8 RID: 43512
		[OriginalName("ArtemisUnlock")]
		ArtemisUnlock,
		// Token: 0x0400A9F9 RID: 43513
		[OriginalName("ArtemisFixed")]
		ArtemisFixed,
		// Token: 0x0400A9FA RID: 43514
		[OriginalName("ArtemisRewarded")]
		ArtemisRewarded
	}
}
