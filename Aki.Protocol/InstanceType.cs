using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001647 RID: 5703
	public enum InstanceType
	{
		// Token: 0x0400C0E3 RID: 49379
		[OriginalName("NoneInstance")]
		NoneInstance,
		// Token: 0x0400C0E4 RID: 49380
		[OriginalName("BigWorldInstance")]
		BigWorldInstance,
		// Token: 0x0400C0E5 RID: 49381
		[OriginalName("NormalInstance")]
		NormalInstance,
		// Token: 0x0400C0E6 RID: 49382
		[OriginalName("MirrorInstance")]
		MirrorInstance,
		// Token: 0x0400C0E7 RID: 49383
		[OriginalName("TowerChallengeInstance")]
		TowerChallengeInstance,
		// Token: 0x0400C0E8 RID: 49384
		[OriginalName("CycleTowerChallenge")]
		CycleTowerChallenge,
		// Token: 0x0400C0E9 RID: 49385
		[OriginalName("QuestRecall")]
		QuestRecall
	}
}
