using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200169E RID: 5790
	public enum StarRewardState
	{
		// Token: 0x0400C538 RID: 50488
		[OriginalName("RiskHarvestCanNoReward")]
		RiskHarvestCanNoReward,
		// Token: 0x0400C539 RID: 50489
		[OriginalName("RiskHarvestCanReward")]
		RiskHarvestCanReward,
		// Token: 0x0400C53A RID: 50490
		[OriginalName("RiskHarvestRewarded")]
		RiskHarvestRewarded
	}
}
