using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200331F RID: 13087
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EPokerStateType.EPokerStateType")]
	public enum EPokerStateType : byte
	{
		// Token: 0x04012108 RID: 73992
		Idel,
		// Token: 0x04012109 RID: 73993
		BeChosenCardStrong,
		// Token: 0x0401210A RID: 73994
		BeChosenCardWeak,
		// Token: 0x0401210B RID: 73995
		BeDrawnCardHappy,
		// Token: 0x0401210C RID: 73996
		BeDrawnCardSad,
		// Token: 0x0401210D RID: 73997
		DrawCardNormal,
		// Token: 0x0401210E RID: 73998
		DrawCardThinking,
		// Token: 0x0401210F RID: 73999
		GetCardHappy,
		// Token: 0x04012110 RID: 74000
		GetCardSad,
		// Token: 0x04012111 RID: 74001
		Win,
		// Token: 0x04012112 RID: 74002
		Lose,
		// Token: 0x04012113 RID: 74003
		IdelPerformance,
		// Token: 0x04012114 RID: 74004
		EPokerStateType_MAX
	}
}
