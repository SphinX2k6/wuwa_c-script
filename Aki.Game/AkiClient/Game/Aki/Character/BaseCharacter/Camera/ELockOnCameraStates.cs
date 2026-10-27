using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043BE RID: 17342
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/ELockOnCameraStates.ELockOnCameraStates")]
	public enum ELockOnCameraStates : byte
	{
		// Token: 0x04017C7F RID: 97407
		None,
		// Token: 0x04017C80 RID: 97408
		EnableRotation,
		// Token: 0x04017C81 RID: 97409
		DisableRotation,
		// Token: 0x04017C82 RID: 97410
		ELockOnCameraStates_MAX
	}
}
