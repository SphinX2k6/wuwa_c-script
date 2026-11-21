using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016BE RID: 5822
	public enum InstanceType
	{
		// Token: 0x0400C5EE RID: 50670
		[OriginalName("NoneInstance")]
		NoneInstance,
		// Token: 0x0400C5EF RID: 50671
		[OriginalName("BigWorldInstance")]
		BigWorldInstance,
		// Token: 0x0400C5F0 RID: 50672
		[OriginalName("NormalInstance")]
		NormalInstance,
		// Token: 0x0400C5F1 RID: 50673
		[OriginalName("MirrorInstance")]
		MirrorInstance,
		// Token: 0x0400C5F2 RID: 50674
		[OriginalName("TowerChallengeInstance")]
		TowerChallengeInstance,
		// Token: 0x0400C5F3 RID: 50675
		[OriginalName("CycleTowerChallenge")]
		CycleTowerChallenge,
		// Token: 0x0400C5F4 RID: 50676
		[OriginalName("QuestRecall")]
		QuestRecall
	}
}
