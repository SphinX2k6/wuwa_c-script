using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200330C RID: 13068
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EDangoState.EDangoState")]
	public enum EDangoState : byte
	{
		// Token: 0x04012087 RID: 73863
		Stand,
		// Token: 0x04012088 RID: 73864
		ActionPerform,
		// Token: 0x04012089 RID: 73865
		MoveJump,
		// Token: 0x0401208A RID: 73866
		EDangoState_MAX
	}
}
