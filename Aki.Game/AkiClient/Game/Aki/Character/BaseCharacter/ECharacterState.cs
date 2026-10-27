using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042A0 RID: 17056
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECharacterState.ECharacterState")]
	public enum ECharacterState : byte
	{
		// Token: 0x04017301 RID: 94977
		None,
		// Token: 0x04017302 RID: 94978
		休眠,
		// Token: 0x04017303 RID: 94979
		出生,
		// Token: 0x04017304 RID: 94980
		其他,
		// Token: 0x04017305 RID: 94981
		ECharacterState_MAX
	}
}
