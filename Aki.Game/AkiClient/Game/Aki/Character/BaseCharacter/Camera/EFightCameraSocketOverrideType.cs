using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033D4 RID: 13268
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraSocketOverrideType.EFightCameraSocketOverrideType")]
	public enum EFightCameraSocketOverrideType : byte
	{
		// Token: 0x040127C0 RID: 75712
		骨骼有效才覆盖,
		// Token: 0x040127C1 RID: 75713
		骨骼无条件覆盖,
		// Token: 0x040127C2 RID: 75714
		EFightCameraSocketOverrideType_MAX
	}
}
