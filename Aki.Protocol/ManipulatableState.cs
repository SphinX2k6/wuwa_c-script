using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001653 RID: 5715
	public enum ManipulatableState
	{
		// Token: 0x0400C10F RID: 49423
		[OriginalName("ManipulatableStateNone")]
		None,
		// Token: 0x0400C110 RID: 49424
		[OriginalName("ManipulatableStateReset")]
		Reset,
		// Token: 0x0400C111 RID: 49425
		[OriginalName("ManipulatableStateBeChanting")]
		BeChanting,
		// Token: 0x0400C112 RID: 49426
		[OriginalName("ManipulatableStateBeDrawing")]
		BeDrawing,
		// Token: 0x0400C113 RID: 49427
		[OriginalName("ManipulatableStateBeHolding")]
		BeHolding,
		// Token: 0x0400C114 RID: 49428
		[OriginalName("ManipulatableStateBePrecasting")]
		BePrecasting,
		// Token: 0x0400C115 RID: 49429
		[OriginalName("ManipulatableStateBeCastingToTarget")]
		BeCastingToTarget,
		// Token: 0x0400C116 RID: 49430
		[OriginalName("ManipulatableStateBeCastingToOutlet")]
		BeCastingToOutlet,
		// Token: 0x0400C117 RID: 49431
		[OriginalName("ManipulatableStateBeCastingProjectile")]
		BeCastingProjectile,
		// Token: 0x0400C118 RID: 49432
		[OriginalName("ManipulatableStateBeCastingFree")]
		BeCastingFree,
		// Token: 0x0400C119 RID: 49433
		[OriginalName("ManipulatableStateMatchingOutlet")]
		MatchingOutlet,
		// Token: 0x0400C11A RID: 49434
		[OriginalName("ManipulatableStateBeDropping")]
		BeDropping,
		// Token: 0x0400C11B RID: 49435
		[OriginalName("ManipulatableStateBeAdsorbed")]
		BeAdsorbed
	}
}
