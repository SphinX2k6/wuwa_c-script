using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043AF RID: 17327
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraFocus.EFightCameraFocus")]
	public enum EFightCameraFocus : byte
	{
		// Token: 0x04017BCE RID: 97230
		None,
		// Token: 0x04017BCF RID: 97231
		臂旋转Yaw过渡最小速度,
		// Token: 0x04017BD0 RID: 97232
		臂旋转Yaw过渡最大速度,
		// Token: 0x04017BD1 RID: 97233
		臂旋转Yaw过渡与目标Yaw角度最大差值,
		// Token: 0x04017BD2 RID: 97234
		强锁定_启动左右对峙,
		// Token: 0x04017BD3 RID: 97235
		强锁定_左右对峙_交换角度,
		// Token: 0x04017BD4 RID: 97236
		强锁定_左右对峙_交换冷却,
		// Token: 0x04017BD5 RID: 97237
		软锁定_镜头偏角最小值,
		// Token: 0x04017BD6 RID: 97238
		软锁定_镜头偏角最大值,
		// Token: 0x04017BD7 RID: 97239
		软锁定_锁定时相机臂偏移Y,
		// Token: 0x04017BD8 RID: 97240
		强锁定_锁定时相机臂偏移Y,
		// Token: 0x04017BD9 RID: 97241
		强锁定_输入灵敏度Yaw,
		// Token: 0x04017BDA RID: 97242
		强锁定_输入灵敏度Pitch,
		// Token: 0x04017BDB RID: 97243
		强锁定_输入灵敏度Yaw_手柄,
		// Token: 0x04017BDC RID: 97244
		强锁定_输入灵敏度Pitch_手柄,
		// Token: 0x04017BDD RID: 97245
		强锁定_切换目标_输入衰减律,
		// Token: 0x04017BDE RID: 97246
		强锁定_切换目标_角度系数,
		// Token: 0x04017BDF RID: 97247
		强锁定_切换目标_距离系数,
		// Token: 0x04017BE0 RID: 97248
		强锁定_镜头偏角最小值,
		// Token: 0x04017BE1 RID: 97249
		强锁定_镜头偏角最大值,
		// Token: 0x04017BE2 RID: 97250
		强锁定_镜头俯仰角最小值,
		// Token: 0x04017BE3 RID: 97251
		强锁定_镜头俯仰角最大值,
		// Token: 0x04017BE4 RID: 97252
		软锁定_镜头Yaw输入解锁速度,
		// Token: 0x04017BE5 RID: 97253
		软锁定_镜头Pitch输入解锁速度,
		// Token: 0x04017BE6 RID: 97254
		软锁定_输入灵敏度Yaw,
		// Token: 0x04017BE7 RID: 97255
		软锁定_输入灵敏度Pitch,
		// Token: 0x04017BE8 RID: 97256
		软锁定_输入灵敏度Yaw_手柄,
		// Token: 0x04017BE9 RID: 97257
		软锁定_输入灵敏度Pitch_手柄,
		// Token: 0x04017BEA RID: 97258
		臂旋转过渡速度最小系数_目标距离_,
		// Token: 0x04017BEB RID: 97259
		臂旋转过渡速度最大系数_目标距离_,
		// Token: 0x04017BEC RID: 97260
		臂旋转过渡速度最大距离_目标距离_,
		// Token: 0x04017BED RID: 97261
		臂旋转过渡速度最小距离_目标距离_,
		// Token: 0x04017BEE RID: 97262
		强锁定_切换目标_启动速度,
		// Token: 0x04017BEF RID: 97263
		强锁定_切换目标_启动速度_手柄,
		// Token: 0x04017BF0 RID: 97264
		臂旋转Pitch过渡最小速度,
		// Token: 0x04017BF1 RID: 97265
		臂旋转Pitch过渡最大速度,
		// Token: 0x04017BF2 RID: 97266
		臂旋转Pitch过渡与目标Pitch角度最大差值,
		// Token: 0x04017BF3 RID: 97267
		软锁定_镜头输入缓冲时间,
		// Token: 0x04017BF4 RID: 97268
		软锁定_镜头Yaw输入启动速度,
		// Token: 0x04017BF5 RID: 97269
		软锁定_镜头Pitch输入启动速度,
		// Token: 0x04017BF6 RID: 97270
		强锁定_左右对峙_启动距离阈值,
		// Token: 0x04017BF7 RID: 97271
		强锁定_左右对峙_锁定方向,
		// Token: 0x04017BF8 RID: 97272
		EFightCameraFocus_MAX
	}
}
