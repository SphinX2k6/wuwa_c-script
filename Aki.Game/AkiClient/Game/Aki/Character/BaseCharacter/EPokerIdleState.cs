using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200331E RID: 13086
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EPokerIdleState.EPokerIdleState")]
	public enum EPokerIdleState : byte
	{
		// Token: 0x04012103 RID: 73987
		Normal,
		// Token: 0x04012104 RID: 73988
		Disadvantage,
		// Token: 0x04012105 RID: 73989
		Advantage,
		// Token: 0x04012106 RID: 73990
		EPokerIdleState_MAX
	}
}
