using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043B3 RID: 17331
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraInput.EFightCameraInput")]
	public enum EFightCameraInput : byte
	{
		// Token: 0x04017C16 RID: 97302
		None,
		// Token: 0x04017C17 RID: 97303
		滚轮轴影响臂长系数,
		// Token: 0x04017C18 RID: 97304
		镜头输入缓冲系数最小值,
		// Token: 0x04017C19 RID: 97305
		镜头输入缓冲系数最大值,
		// Token: 0x04017C1A RID: 97306
		镜头输入缓冲系数输入极值,
		// Token: 0x04017C1B RID: 97307
		镜头输入速率Min,
		// Token: 0x04017C1C RID: 97308
		镜头输入速率Max,
		// Token: 0x04017C1D RID: 97309
		镜头Yaw灵敏度系数最小值,
		// Token: 0x04017C1E RID: 97310
		镜头Yaw灵敏度系数最大值,
		// Token: 0x04017C1F RID: 97311
		镜头Yaw灵敏度系数输入极值,
		// Token: 0x04017C20 RID: 97312
		镜头Pitch灵敏度系数最小值,
		// Token: 0x04017C21 RID: 97313
		镜头Pitch灵敏度系数最大值,
		// Token: 0x04017C22 RID: 97314
		镜头Pitch灵敏度系数输入极值,
		// Token: 0x04017C23 RID: 97315
		倍化手柄输入倍率,
		// Token: 0x04017C24 RID: 97316
		辅助瞄准中心速度,
		// Token: 0x04017C25 RID: 97317
		辅助瞄准边缘速度,
		// Token: 0x04017C26 RID: 97318
		辅助瞄准最远距离,
		// Token: 0x04017C27 RID: 97319
		辅助瞄准阻尼系数,
		// Token: 0x04017C28 RID: 97320
		进入瞄准模式时长,
		// Token: 0x04017C29 RID: 97321
		进入瞄准模式速度初始值,
		// Token: 0x04017C2A RID: 97322
		进入瞄准模式速度结束值,
		// Token: 0x04017C2B RID: 97323
		镜头输入缓冲系数最小值_手柄_,
		// Token: 0x04017C2C RID: 97324
		镜头输入缓冲系数最大值_手柄_,
		// Token: 0x04017C2D RID: 97325
		镜头输入缓冲系数输入极值_手柄_,
		// Token: 0x04017C2E RID: 97326
		滚轮轴影响臂长系数_手柄,
		// Token: 0x04017C2F RID: 97327
		特定镜头Yaw灵敏度,
		// Token: 0x04017C30 RID: 97328
		特定镜头Pitch灵敏度,
		// Token: 0x04017C31 RID: 97329
		特定瞄准镜头Yaw灵敏度,
		// Token: 0x04017C32 RID: 97330
		特定瞄准镜头Pitch灵敏度,
		// Token: 0x04017C33 RID: 97331
		EFightCameraInput_MAX
	}
}
