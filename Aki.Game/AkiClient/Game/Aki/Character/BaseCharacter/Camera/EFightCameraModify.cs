using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043B4 RID: 17332
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraModify.EFightCameraModify")]
	public enum EFightCameraModify : byte
	{
		// Token: 0x04017C35 RID: 97333
		None,
		// Token: 0x04017C36 RID: 97334
		臂长还原过渡速度,
		// Token: 0x04017C37 RID: 97335
		臂偏移还原过渡速度,
		// Token: 0x04017C38 RID: 97336
		旋转还原过渡速度,
		// Token: 0x04017C39 RID: 97337
		Fov还原过渡速度,
		// Token: 0x04017C3A RID: 97338
		臂偏移原点还原过渡速度,
		// Token: 0x04017C3B RID: 97339
		EFightCameraModify_MAX
	}
}
