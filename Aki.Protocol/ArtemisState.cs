using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001552 RID: 5458
	public enum ArtemisState
	{
		// Token: 0x0400A599 RID: 42393
		[OriginalName("ArtemisLocked")]
		ArtemisLocked,
		// Token: 0x0400A59A RID: 42394
		[OriginalName("ArtemisUnlock")]
		ArtemisUnlock,
		// Token: 0x0400A59B RID: 42395
		[OriginalName("ArtemisFixed")]
		ArtemisFixed,
		// Token: 0x0400A59C RID: 42396
		[OriginalName("ArtemisRewarded")]
		ArtemisRewarded
	}
}
