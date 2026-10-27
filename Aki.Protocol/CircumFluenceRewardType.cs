using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200157A RID: 5498
	public enum CircumFluenceRewardType
	{
		// Token: 0x0400A6B2 RID: 42674
		[OriginalName("TaskReward")]
		TaskReward,
		// Token: 0x0400A6B3 RID: 42675
		[OriginalName("SignReward")]
		SignReward = 2,
		// Token: 0x0400A6B4 RID: 42676
		[OriginalName("ScoreReward")]
		ScoreReward
	}
}
