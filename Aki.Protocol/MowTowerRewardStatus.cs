using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001542 RID: 5442
	public enum MowTowerRewardStatus
	{
		// Token: 0x0400A559 RID: 42329
		[OriginalName("CanNoReward")]
		CanNoReward,
		// Token: 0x0400A55A RID: 42330
		[OriginalName("CanReward")]
		CanReward,
		// Token: 0x0400A55B RID: 42331
		[OriginalName("Rewarded")]
		Rewarded
	}
}
