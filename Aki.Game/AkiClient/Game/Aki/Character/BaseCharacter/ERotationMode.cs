using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042CC RID: 17100
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ERotationMode.ERotationMode")]
	public enum ERotationMode : byte
	{
		// Token: 0x0401743E RID: 95294
		VelocityDirection,
		// Token: 0x0401743F RID: 95295
		LookingDirection,
		// Token: 0x04017440 RID: 95296
		Aiming,
		// Token: 0x04017441 RID: 95297
		ERotationMode_MAX
	}
}
