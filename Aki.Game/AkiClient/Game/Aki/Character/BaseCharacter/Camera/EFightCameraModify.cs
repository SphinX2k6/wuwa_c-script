using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033D2 RID: 13266
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraModify.EFightCameraModify")]
	public enum EFightCameraModify : byte
	{
		// Token: 0x040127A8 RID: 75688
		None,
		// Token: 0x040127A9 RID: 75689
		臂长还原过渡速度,
		// Token: 0x040127AA RID: 75690
		臂偏移还原过渡速度,
		// Token: 0x040127AB RID: 75691
		旋转还原过渡速度,
		// Token: 0x040127AC RID: 75692
		Fov还原过渡速度,
		// Token: 0x040127AD RID: 75693
		臂偏移原点还原过渡速度,
		// Token: 0x040127AE RID: 75694
		EFightCameraModify_MAX
	}
}
