using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200156B RID: 5483
	public enum RacingBetsDangoActionType
	{
		// Token: 0x0400A661 RID: 42593
		[OriginalName("Move")]
		Move,
		// Token: 0x0400A662 RID: 42594
		[OriginalName("Skill")]
		Skill,
		// Token: 0x0400A663 RID: 42595
		[OriginalName("Dice")]
		Dice,
		// Token: 0x0400A664 RID: 42596
		[OriginalName("ChangeHigh")]
		ChangeHigh,
		// Token: 0x0400A665 RID: 42597
		[OriginalName("DangoTransmit")]
		DangoTransmit,
		// Token: 0x0400A666 RID: 42598
		[OriginalName("Organ")]
		Organ,
		// Token: 0x0400A667 RID: 42599
		[OriginalName("DangoBlackHoleTransmit")]
		DangoBlackHoleTransmit
	}
}
