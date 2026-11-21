using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015E1 RID: 5601
	public enum RacingBetsDangoActionType
	{
		// Token: 0x0400AAEE RID: 43758
		[OriginalName("Move")]
		Move,
		// Token: 0x0400AAEF RID: 43759
		[OriginalName("Skill")]
		Skill,
		// Token: 0x0400AAF0 RID: 43760
		[OriginalName("Dice")]
		Dice,
		// Token: 0x0400AAF1 RID: 43761
		[OriginalName("ChangeHigh")]
		ChangeHigh,
		// Token: 0x0400AAF2 RID: 43762
		[OriginalName("DangoTransmit")]
		DangoTransmit,
		// Token: 0x0400AAF3 RID: 43763
		[OriginalName("Organ")]
		Organ,
		// Token: 0x0400AAF4 RID: 43764
		[OriginalName("DangoBlackHoleTransmit")]
		DangoBlackHoleTransmit
	}
}
