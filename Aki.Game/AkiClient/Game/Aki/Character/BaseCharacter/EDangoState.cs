using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042B3 RID: 17075
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EDangoState.EDangoState")]
	public enum EDangoState : byte
	{
		// Token: 0x04017396 RID: 95126
		Stand,
		// Token: 0x04017397 RID: 95127
		ActionPerform,
		// Token: 0x04017398 RID: 95128
		MoveJump,
		// Token: 0x04017399 RID: 95129
		EDangoState_MAX
	}
}
