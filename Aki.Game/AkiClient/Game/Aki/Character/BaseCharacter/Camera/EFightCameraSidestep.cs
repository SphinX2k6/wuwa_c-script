using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043B5 RID: 17333
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraSidestep.EFightCameraSidestep")]
	public enum EFightCameraSidestep : byte
	{
		// Token: 0x04017C3D RID: 97341
		None,
		// Token: 0x04017C3E RID: 97342
		旋转角速度插值速率,
		// Token: 0x04017C3F RID: 97343
		俯仰角插值速率,
		// Token: 0x04017C40 RID: 97344
		相机俯角偏移,
		// Token: 0x04017C41 RID: 97345
		最大俯角,
		// Token: 0x04017C42 RID: 97346
		最大仰角,
		// Token: 0x04017C43 RID: 97347
		俯仰修正时间阈值,
		// Token: 0x04017C44 RID: 97348
		俯仰角加速度,
		// Token: 0x04017C45 RID: 97349
		自动偏转最大角速度,
		// Token: 0x04017C46 RID: 97350
		移动输入恢复臂长目标值下限,
		// Token: 0x04017C47 RID: 97351
		移动输入恢复臂长目标值上限,
		// Token: 0x04017C48 RID: 97352
		移动输入恢复臂长最小速度,
		// Token: 0x04017C49 RID: 97353
		移动输入恢复臂长最大速度,
		// Token: 0x04017C4A RID: 97354
		移动输入恢复臂长与目标臂长最大差值,
		// Token: 0x04017C4B RID: 97355
		EFightCameraSidestep_MAX
	}
}
