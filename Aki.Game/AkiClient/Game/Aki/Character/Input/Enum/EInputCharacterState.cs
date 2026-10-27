using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Input.Enum
{
	// Token: 0x02004261 RID: 16993
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Input/Enum/EInputCharacterState.EInputCharacterState")]
	public enum EInputCharacterState : byte
	{
		// Token: 0x04017032 RID: 94258
		None,
		// Token: 0x04017033 RID: 94259
		InGround,
		// Token: 0x04017034 RID: 94260
		InGroundArm,
		// Token: 0x04017035 RID: 94261
		InAir,
		// Token: 0x04017036 RID: 94262
		InWater,
		// Token: 0x04017037 RID: 94263
		InClimbing,
		// Token: 0x04017038 RID: 94264
		InControllState,
		// Token: 0x04017039 RID: 94265
		InControllSelect,
		// Token: 0x0401703A RID: 94266
		InThrowState,
		// Token: 0x0401703B RID: 94267
		EInputCharacterState_MAX
	}
}
