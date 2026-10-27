using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001618 RID: 5656
	public enum MotionType
	{
		// Token: 0x0400BFDB RID: 49115
		[OriginalName("Spurt")]
		Spurt,
		// Token: 0x0400BFDC RID: 49116
		[OriginalName("Pullback")]
		Pullback,
		// Token: 0x0400BFDD RID: 49117
		[OriginalName("BeLand")]
		BeLand,
		// Token: 0x0400BFDE RID: 49118
		[OriginalName("MotionJump")]
		MotionJump,
		// Token: 0x0400BFDF RID: 49119
		[OriginalName("AirSprint")]
		AirSprint,
		// Token: 0x0400BFE0 RID: 49120
		[OriginalName("BackFlip")]
		BackFlip,
		// Token: 0x0400BFE1 RID: 49121
		[OriginalName("StepAcross")]
		StepAcross,
		// Token: 0x0400BFE2 RID: 49122
		[OriginalName("ClimbTop")]
		ClimbTop,
		// Token: 0x0400BFE3 RID: 49123
		[OriginalName("LimitDodge")]
		LimitDodge,
		// Token: 0x0400BFE4 RID: 49124
		[OriginalName("CounterAttack")]
		CounterAttack
	}
}
