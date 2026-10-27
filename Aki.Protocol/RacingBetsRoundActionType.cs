using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200156D RID: 5485
	public enum RacingBetsRoundActionType
	{
		// Token: 0x0400A66C RID: 42604
		[OriginalName("MatchStart")]
		MatchStart,
		// Token: 0x0400A66D RID: 42605
		[OriginalName("RoundStart")]
		RoundStart,
		// Token: 0x0400A66E RID: 42606
		[OriginalName("MatchRoundDice")]
		MatchRoundDice = 3,
		// Token: 0x0400A66F RID: 42607
		[OriginalName("DangoRoundStart")]
		DangoRoundStart = 2,
		// Token: 0x0400A670 RID: 42608
		[OriginalName("DangoMove")]
		DangoMove = 4,
		// Token: 0x0400A671 RID: 42609
		[OriginalName("DangoSkill")]
		DangoSkill,
		// Token: 0x0400A672 RID: 42610
		[OriginalName("DangoChangeHigh")]
		DangoChangeHigh,
		// Token: 0x0400A673 RID: 42611
		[OriginalName("CameraMove")]
		CameraMove,
		// Token: 0x0400A674 RID: 42612
		[OriginalName("Destination")]
		Destination,
		// Token: 0x0400A675 RID: 42613
		[OriginalName("UpdateRank")]
		UpdateRank,
		// Token: 0x0400A676 RID: 42614
		[OriginalName("Transmit")]
		Transmit,
		// Token: 0x0400A677 RID: 42615
		[OriginalName("OrganEffect")]
		OrganEffect,
		// Token: 0x0400A678 RID: 42616
		[OriginalName("BlackHoleTransmit")]
		BlackHoleTransmit
	}
}
