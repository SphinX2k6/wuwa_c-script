using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015E5 RID: 5605
	public enum BossRushRewardClaimStatus
	{
		// Token: 0x0400AB18 RID: 43800
		[OriginalName("Incomplete")]
		Incomplete,
		// Token: 0x0400AB19 RID: 43801
		[OriginalName("Claimable")]
		Claimable,
		// Token: 0x0400AB1A RID: 43802
		[OriginalName("Claimed")]
		Claimed
	}
}
