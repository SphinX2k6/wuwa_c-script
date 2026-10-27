using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043AB RID: 17323
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraClimb.EFightCameraClimb")]
	public enum EFightCameraClimb : byte
	{
		// Token: 0x04017B23 RID: 97059
		None,
		// Token: 0x04017B24 RID: 97060
		退出攀爬淡出时间,
		// Token: 0x04017B25 RID: 97061
		无操作等待时间,
		// Token: 0x04017B26 RID: 97062
		持续移动进入修正时间,
		// Token: 0x04017B27 RID: 97063
		镜头角度插值速度,
		// Token: 0x04017B28 RID: 97064
		角色移动基准速度,
		// Token: 0x04017B29 RID: 97065
		进入攀爬增加臂长,
		// Token: 0x04017B2A RID: 97066
		进入攀爬修正时间,
		// Token: 0x04017B2B RID: 97067
		进入攀爬淡出系数,
		// Token: 0x04017B2C RID: 97068
		攀爬基准臂长,
		// Token: 0x04017B2D RID: 97069
		臂长插值速度,
		// Token: 0x04017B2E RID: 97070
		镜头预期朝向与角色移动方向夹角,
		// Token: 0x04017B2F RID: 97071
		镜头预期朝向俯视角压缩倍率,
		// Token: 0x04017B30 RID: 97072
		镜头预期朝向仰视角压缩倍率,
		// Token: 0x04017B31 RID: 97073
		镜头预期朝向和角色面朝方向夹角合法范围,
		// Token: 0x04017B32 RID: 97074
		输入粘滞时间,
		// Token: 0x04017B33 RID: 97075
		登顶镜头插值速度,
		// Token: 0x04017B34 RID: 97076
		登顶镜头预期Pitch,
		// Token: 0x04017B35 RID: 97077
		大跨度输入角度阈值,
		// Token: 0x04017B36 RID: 97078
		大跨度输入角度延迟响应时间,
		// Token: 0x04017B37 RID: 97079
		停止输入延迟响应时间,
		// Token: 0x04017B38 RID: 97080
		EFightCameraClimb_MAX
	}
}
