using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033C9 RID: 13257
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraClimb.EFightCameraClimb")]
	public enum EFightCameraClimb : byte
	{
		// Token: 0x04012695 RID: 75413
		None,
		// Token: 0x04012696 RID: 75414
		退出攀爬淡出时间,
		// Token: 0x04012697 RID: 75415
		无操作等待时间,
		// Token: 0x04012698 RID: 75416
		持续移动进入修正时间,
		// Token: 0x04012699 RID: 75417
		镜头角度插值速度,
		// Token: 0x0401269A RID: 75418
		角色移动基准速度,
		// Token: 0x0401269B RID: 75419
		进入攀爬增加臂长,
		// Token: 0x0401269C RID: 75420
		进入攀爬修正时间,
		// Token: 0x0401269D RID: 75421
		进入攀爬淡出系数,
		// Token: 0x0401269E RID: 75422
		攀爬基准臂长,
		// Token: 0x0401269F RID: 75423
		臂长插值速度,
		// Token: 0x040126A0 RID: 75424
		镜头预期朝向与角色移动方向夹角,
		// Token: 0x040126A1 RID: 75425
		镜头预期朝向俯视角压缩倍率,
		// Token: 0x040126A2 RID: 75426
		镜头预期朝向仰视角压缩倍率,
		// Token: 0x040126A3 RID: 75427
		镜头预期朝向和角色面朝方向夹角合法范围,
		// Token: 0x040126A4 RID: 75428
		输入粘滞时间,
		// Token: 0x040126A5 RID: 75429
		登顶镜头插值速度,
		// Token: 0x040126A6 RID: 75430
		登顶镜头预期Pitch,
		// Token: 0x040126A7 RID: 75431
		大跨度输入角度阈值,
		// Token: 0x040126A8 RID: 75432
		大跨度输入角度延迟响应时间,
		// Token: 0x040126A9 RID: 75433
		停止输入延迟响应时间,
		// Token: 0x040126AA RID: 75434
		EFightCameraClimb_MAX
	}
}
