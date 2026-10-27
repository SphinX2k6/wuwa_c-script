using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043B8 RID: 17336
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraSplineMove.EFightCameraSplineMove")]
	public enum EFightCameraSplineMove : byte
	{
		// Token: 0x04017C53 RID: 97363
		摄像机臂长,
		// Token: 0x04017C54 RID: 97364
		摄像机偏移,
		// Token: 0x04017C55 RID: 97365
		Fov,
		// Token: 0x04017C56 RID: 97366
		观察角度,
		// Token: 0x04017C57 RID: 97367
		EFightCameraSplineMove_MAX
	}
}
