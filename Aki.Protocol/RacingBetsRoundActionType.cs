using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015E3 RID: 5603
	public enum RacingBetsRoundActionType
	{
		// Token: 0x0400AAF9 RID: 43769
		[OriginalName("MatchStart")]
		MatchStart,
		// Token: 0x0400AAFA RID: 43770
		[OriginalName("RoundStart")]
		RoundStart,
		// Token: 0x0400AAFB RID: 43771
		[OriginalName("MatchRoundDice")]
		MatchRoundDice = 3,
		// Token: 0x0400AAFC RID: 43772
		[OriginalName("DangoRoundStart")]
		DangoRoundStart = 2,
		// Token: 0x0400AAFD RID: 43773
		[OriginalName("DangoMove")]
		DangoMove = 4,
		// Token: 0x0400AAFE RID: 43774
		[OriginalName("DangoSkill")]
		DangoSkill,
		// Token: 0x0400AAFF RID: 43775
		[OriginalName("DangoChangeHigh")]
		DangoChangeHigh,
		// Token: 0x0400AB00 RID: 43776
		[OriginalName("CameraMove")]
		CameraMove,
		// Token: 0x0400AB01 RID: 43777
		[OriginalName("Destination")]
		Destination,
		// Token: 0x0400AB02 RID: 43778
		[OriginalName("UpdateRank")]
		UpdateRank,
		// Token: 0x0400AB03 RID: 43779
		[OriginalName("Transmit")]
		Transmit,
		// Token: 0x0400AB04 RID: 43780
		[OriginalName("OrganEffect")]
		OrganEffect,
		// Token: 0x0400AB05 RID: 43781
		[OriginalName("BlackHoleTransmit")]
		BlackHoleTransmit
	}
}
