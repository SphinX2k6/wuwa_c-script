using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043B0 RID: 17328
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraGravity.EFightCameraGravity")]
	public enum EFightCameraGravity : byte
	{
		// Token: 0x04017BFA RID: 97274
		None,
		// Token: 0x04017BFB RID: 97275
		开启过渡到指定重力方向,
		// Token: 0x04017BFC RID: 97276
		过渡角速度,
		// Token: 0x04017BFD RID: 97277
		EFightCameraGravity_MAX
	}
}
