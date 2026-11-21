using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033D6 RID: 13270
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraVehicle.EFightCameraVehicle")]
	public enum EFightCameraVehicle : byte
	{
		// Token: 0x040127CB RID: 75723
		None,
		// Token: 0x040127CC RID: 75724
		相机目标以载具为中心,
		// Token: 0x040127CD RID: 75725
		相机挂载到载具上,
		// Token: 0x040127CE RID: 75726
		EFightCameraVehicle_MAX
	}
}
