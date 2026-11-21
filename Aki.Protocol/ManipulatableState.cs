using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016C9 RID: 5833
	public enum ManipulatableState
	{
		// Token: 0x0400C616 RID: 50710
		[OriginalName("ManipulatableStateNone")]
		None,
		// Token: 0x0400C617 RID: 50711
		[OriginalName("ManipulatableStateReset")]
		Reset,
		// Token: 0x0400C618 RID: 50712
		[OriginalName("ManipulatableStateBeChanting")]
		BeChanting,
		// Token: 0x0400C619 RID: 50713
		[OriginalName("ManipulatableStateBeDrawing")]
		BeDrawing,
		// Token: 0x0400C61A RID: 50714
		[OriginalName("ManipulatableStateBeHolding")]
		BeHolding,
		// Token: 0x0400C61B RID: 50715
		[OriginalName("ManipulatableStateBePrecasting")]
		BePrecasting,
		// Token: 0x0400C61C RID: 50716
		[OriginalName("ManipulatableStateBeCastingToTarget")]
		BeCastingToTarget,
		// Token: 0x0400C61D RID: 50717
		[OriginalName("ManipulatableStateBeCastingToOutlet")]
		BeCastingToOutlet,
		// Token: 0x0400C61E RID: 50718
		[OriginalName("ManipulatableStateBeCastingProjectile")]
		BeCastingProjectile,
		// Token: 0x0400C61F RID: 50719
		[OriginalName("ManipulatableStateBeCastingFree")]
		BeCastingFree,
		// Token: 0x0400C620 RID: 50720
		[OriginalName("ManipulatableStateMatchingOutlet")]
		MatchingOutlet,
		// Token: 0x0400C621 RID: 50721
		[OriginalName("ManipulatableStateBeDropping")]
		BeDropping,
		// Token: 0x0400C622 RID: 50722
		[OriginalName("ManipulatableStateBeAdsorbed")]
		BeAdsorbed
	}
}
