using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043BA RID: 17338
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraVehicle.EFightCameraVehicle")]
	public enum EFightCameraVehicle : byte
	{
		// Token: 0x04017C60 RID: 97376
		None,
		// Token: 0x04017C61 RID: 97377
		相机目标以载具为中心,
		// Token: 0x04017C62 RID: 97378
		相机挂载到载具上,
		// Token: 0x04017C63 RID: 97379
		EFightCameraVehicle_MAX
	}
}
