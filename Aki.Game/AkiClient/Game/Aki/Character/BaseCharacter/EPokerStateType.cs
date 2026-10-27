using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042C9 RID: 17097
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EPokerStateType.EPokerStateType")]
	public enum EPokerStateType : byte
	{
		// Token: 0x04017426 RID: 95270
		Idel,
		// Token: 0x04017427 RID: 95271
		BeChosenCardStrong,
		// Token: 0x04017428 RID: 95272
		BeChosenCardWeak,
		// Token: 0x04017429 RID: 95273
		BeDrawnCardHappy,
		// Token: 0x0401742A RID: 95274
		BeDrawnCardSad,
		// Token: 0x0401742B RID: 95275
		DrawCardNormal,
		// Token: 0x0401742C RID: 95276
		DrawCardThinking,
		// Token: 0x0401742D RID: 95277
		GetCardHappy,
		// Token: 0x0401742E RID: 95278
		GetCardSad,
		// Token: 0x0401742F RID: 95279
		Win,
		// Token: 0x04017430 RID: 95280
		Lose,
		// Token: 0x04017431 RID: 95281
		IdelPerformance,
		// Token: 0x04017432 RID: 95282
		EPokerStateType_MAX
	}
}
