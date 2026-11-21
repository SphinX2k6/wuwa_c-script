using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015B8 RID: 5560
	public enum MowTowerRewardStatus
	{
		// Token: 0x0400A9B7 RID: 43447
		[OriginalName("CanNoReward")]
		CanNoReward,
		// Token: 0x0400A9B8 RID: 43448
		[OriginalName("CanReward")]
		CanReward,
		// Token: 0x0400A9B9 RID: 43449
		[OriginalName("Rewarded")]
		Rewarded
	}
}
