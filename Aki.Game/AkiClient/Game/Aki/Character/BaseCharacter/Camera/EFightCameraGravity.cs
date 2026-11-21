using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033CE RID: 13262
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraGravity.EFightCameraGravity")]
	public enum EFightCameraGravity : byte
	{
		// Token: 0x0401276D RID: 75629
		None,
		// Token: 0x0401276E RID: 75630
		开启过渡到指定重力方向,
		// Token: 0x0401276F RID: 75631
		过渡角速度,
		// Token: 0x04012770 RID: 75632
		EFightCameraGravity_MAX
	}
}
