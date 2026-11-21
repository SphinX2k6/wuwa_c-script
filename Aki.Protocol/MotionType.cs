using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200168B RID: 5771
	public enum MotionType
	{
		// Token: 0x0400C4D5 RID: 50389
		[OriginalName("Spurt")]
		Spurt,
		// Token: 0x0400C4D6 RID: 50390
		[OriginalName("Pullback")]
		Pullback,
		// Token: 0x0400C4D7 RID: 50391
		[OriginalName("BeLand")]
		BeLand,
		// Token: 0x0400C4D8 RID: 50392
		[OriginalName("MotionJump")]
		MotionJump,
		// Token: 0x0400C4D9 RID: 50393
		[OriginalName("AirSprint")]
		AirSprint,
		// Token: 0x0400C4DA RID: 50394
		[OriginalName("BackFlip")]
		BackFlip,
		// Token: 0x0400C4DB RID: 50395
		[OriginalName("StepAcross")]
		StepAcross,
		// Token: 0x0400C4DC RID: 50396
		[OriginalName("ClimbTop")]
		ClimbTop,
		// Token: 0x0400C4DD RID: 50397
		[OriginalName("LimitDodge")]
		LimitDodge,
		// Token: 0x0400C4DE RID: 50398
		[OriginalName("CounterAttack")]
		CounterAttack
	}
}
