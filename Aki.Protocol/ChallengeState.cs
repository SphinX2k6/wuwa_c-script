using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001638 RID: 5688
	public enum ChallengeState
	{
		// Token: 0x0400C07A RID: 49274
		[OriginalName("Running")]
		Running,
		// Token: 0x0400C07B RID: 49275
		[OriginalName("WaitTakeReward")]
		WaitTakeReward,
		// Token: 0x0400C07C RID: 49276
		[OriginalName("Finish")]
		Finish
	}
}
