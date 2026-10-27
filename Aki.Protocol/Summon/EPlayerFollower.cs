using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Summon
{
	// Token: 0x0200167D RID: 5757
	public enum EPlayerFollower
	{
		// Token: 0x0400C1F9 RID: 49657
		[OriginalName("EPlayerFollowerDefault")]
		Default,
		// Token: 0x0400C1FA RID: 49658
		[OriginalName("EPlayerFollowerExploreSkill")]
		ExploreSkill,
		// Token: 0x0400C1FB RID: 49659
		[OriginalName("EPlayerFollowerAuxiliary")]
		Auxiliary,
		// Token: 0x0400C1FC RID: 49660
		[OriginalName("EPlayerFollowerSpecialItem")]
		SpecialItem,
		// Token: 0x0400C1FD RID: 49661
		[OriginalName("EPlayerFollowerMotor")]
		Motor,
		// Token: 0x0400C1FE RID: 49662
		[OriginalName("EPlayerFollowerMax")]
		Max
	}
}
