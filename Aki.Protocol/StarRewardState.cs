using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200162B RID: 5675
	public enum StarRewardState
	{
		// Token: 0x0400C03E RID: 49214
		[OriginalName("RiskHarvestCanNoReward")]
		RiskHarvestCanNoReward,
		// Token: 0x0400C03F RID: 49215
		[OriginalName("RiskHarvestCanReward")]
		RiskHarvestCanReward,
		// Token: 0x0400C040 RID: 49216
		[OriginalName("RiskHarvestRewarded")]
		RiskHarvestRewarded
	}
}
