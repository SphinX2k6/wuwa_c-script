using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200156F RID: 5487
	public enum BossRushRewardClaimStatus
	{
		// Token: 0x0400A68B RID: 42635
		[OriginalName("Incomplete")]
		Incomplete,
		// Token: 0x0400A68C RID: 42636
		[OriginalName("Claimable")]
		Claimable,
		// Token: 0x0400A68D RID: 42637
		[OriginalName("Claimed")]
		Claimed
	}
}
