using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043B6 RID: 17334
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraSocketOverrideType.EFightCameraSocketOverrideType")]
	public enum EFightCameraSocketOverrideType : byte
	{
		// Token: 0x04017C4D RID: 97357
		骨骼有效才覆盖,
		// Token: 0x04017C4E RID: 97358
		骨骼无条件覆盖,
		// Token: 0x04017C4F RID: 97359
		EFightCameraSocketOverrideType_MAX
	}
}
