using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043B1 RID: 17329
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraGuide.EFightCameraGuide")]
	public enum EFightCameraGuide : byte
	{
		// Token: 0x04017BFF RID: 97279
		None,
		// Token: 0x04017C00 RID: 97280
		修正角度Min,
		// Token: 0x04017C01 RID: 97281
		修正角度Max,
		// Token: 0x04017C02 RID: 97282
		额外臂长系数_目标水平距离_,
		// Token: 0x04017C03 RID: 97283
		额外臂长系数_目标高度差_,
		// Token: 0x04017C04 RID: 97284
		额外臂长限制,
		// Token: 0x04017C05 RID: 97285
		额外臂水平偏移系数_目标水平距离_,
		// Token: 0x04017C06 RID: 97286
		额外臂水平偏移上限,
		// Token: 0x04017C07 RID: 97287
		额外臂垂直偏移系数_目标高度差_,
		// Token: 0x04017C08 RID: 97288
		额外臂垂直偏移上限,
		// Token: 0x04017C09 RID: 97289
		InRangeMin,
		// Token: 0x04017C0A RID: 97290
		InRangeMax,
		// Token: 0x04017C0B RID: 97291
		OutRangeMin,
		// Token: 0x04017C0C RID: 97292
		OutRangeMax,
		// Token: 0x04017C0D RID: 97293
		CameraPitchMin,
		// Token: 0x04017C0E RID: 97294
		CameraPitchMax,
		// Token: 0x04017C0F RID: 97295
		CameraPitchOffset,
		// Token: 0x04017C10 RID: 97296
		NearerRange,
		// Token: 0x04017C11 RID: 97297
		EFightCameraGuide_MAX
	}
}
