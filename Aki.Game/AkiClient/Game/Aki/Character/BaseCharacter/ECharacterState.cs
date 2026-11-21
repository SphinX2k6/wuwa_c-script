using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032FB RID: 13051
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECharacterState.ECharacterState")]
	public enum ECharacterState : byte
	{
		// Token: 0x04011FFF RID: 73727
		None,
		// Token: 0x04012000 RID: 73728
		休眠,
		// Token: 0x04012001 RID: 73729
		出生,
		// Token: 0x04012002 RID: 73730
		其他,
		// Token: 0x04012003 RID: 73731
		ECharacterState_MAX
	}
}
