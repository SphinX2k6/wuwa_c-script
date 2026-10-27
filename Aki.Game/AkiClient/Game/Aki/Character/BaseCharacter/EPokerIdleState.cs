using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042C8 RID: 17096
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EPokerIdleState.EPokerIdleState")]
	public enum EPokerIdleState : byte
	{
		// Token: 0x04017421 RID: 95265
		Normal,
		// Token: 0x04017422 RID: 95266
		Disadvantage,
		// Token: 0x04017423 RID: 95267
		Advantage,
		// Token: 0x04017424 RID: 95268
		EPokerIdleState_MAX
	}
}
