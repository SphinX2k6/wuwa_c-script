using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016AF RID: 5807
	public enum ChallengeState
	{
		// Token: 0x0400C585 RID: 50565
		[OriginalName("Running")]
		Running,
		// Token: 0x0400C586 RID: 50566
		[OriginalName("WaitTakeReward")]
		WaitTakeReward,
		// Token: 0x0400C587 RID: 50567
		[OriginalName("Finish")]
		Finish
	}
}
