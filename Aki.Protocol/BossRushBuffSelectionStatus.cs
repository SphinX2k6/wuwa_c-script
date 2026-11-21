using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015E6 RID: 5606
	public enum BossRushBuffSelectionStatus
	{
		// Token: 0x0400AB1C RID: 43804
		[OriginalName("BuffEmpty")]
		BuffEmpty,
		// Token: 0x0400AB1D RID: 43805
		[OriginalName("BuffSelected")]
		BuffSelected,
		// Token: 0x0400AB1E RID: 43806
		[OriginalName("BuffLocked")]
		BuffLocked,
		// Token: 0x0400AB1F RID: 43807
		[OriginalName("BuffInactive")]
		BuffInactive
	}
}
