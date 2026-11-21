using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Summon
{
	// Token: 0x020016F9 RID: 5881
	public enum EPlayerFollower
	{
		// Token: 0x0400C725 RID: 50981
		[OriginalName("EPlayerFollowerDefault")]
		Default,
		// Token: 0x0400C726 RID: 50982
		[OriginalName("EPlayerFollowerExploreSkill")]
		ExploreSkill,
		// Token: 0x0400C727 RID: 50983
		[OriginalName("EPlayerFollowerAuxiliary")]
		Auxiliary,
		// Token: 0x0400C728 RID: 50984
		[OriginalName("EPlayerFollowerSpecialItem")]
		SpecialItem,
		// Token: 0x0400C729 RID: 50985
		[OriginalName("EPlayerFollowerMotor")]
		Motor,
		// Token: 0x0400C72A RID: 50986
		[OriginalName("EPlayerFollowerMax")]
		Max
	}
}
