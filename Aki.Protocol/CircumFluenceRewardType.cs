using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015F0 RID: 5616
	public enum CircumFluenceRewardType
	{
		// Token: 0x0400AB3F RID: 43839
		[OriginalName("TaskReward")]
		TaskReward,
		// Token: 0x0400AB40 RID: 43840
		[OriginalName("SignReward")]
		SignReward = 2,
		// Token: 0x0400AB41 RID: 43841
		[OriginalName("ScoreReward")]
		ScoreReward
	}
}
