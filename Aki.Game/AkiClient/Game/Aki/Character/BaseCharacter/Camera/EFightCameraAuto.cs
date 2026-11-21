using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033C8 RID: 13256
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraAuto.EFightCameraAuto")]
	public enum EFightCameraAuto : byte
	{
		// Token: 0x0401267B RID: 75387
		None,
		// Token: 0x0401267C RID: 75388
		目标比角色更靠近镜头时额外臂长,
		// Token: 0x0401267D RID: 75389
		额外臂长最小增量_目标距离_,
		// Token: 0x0401267E RID: 75390
		额外臂长最大增量_目标距离_,
		// Token: 0x0401267F RID: 75391
		额外臂长最大距离_目标距离_,
		// Token: 0x04012680 RID: 75392
		额外臂长最小增量_目标高度_,
		// Token: 0x04012681 RID: 75393
		角色屏幕高度参考,
		// Token: 0x04012682 RID: 75394
		额外臂垂直偏移系数_角色屏幕高度与参考值差_,
		// Token: 0x04012683 RID: 75395
		额外臂长最大增量_目标高度_,
		// Token: 0x04012684 RID: 75396
		额外臂长最大距离_目标高度_,
		// Token: 0x04012685 RID: 75397
		额外臂水平偏移最小偏移_目标距离_,
		// Token: 0x04012686 RID: 75398
		臂长过渡速度,
		// Token: 0x04012687 RID: 75399
		臂偏移过渡速度,
		// Token: 0x04012688 RID: 75400
		检测屏幕内MinX_外_,
		// Token: 0x04012689 RID: 75401
		检测屏幕内MaxX_外_,
		// Token: 0x0401268A RID: 75402
		检测屏幕内MinY_外_,
		// Token: 0x0401268B RID: 75403
		检测屏幕内MaxY_外_,
		// Token: 0x0401268C RID: 75404
		额外臂水平偏移最大偏移_目标距离_,
		// Token: 0x0401268D RID: 75405
		额外臂水平偏移最大距离_目标距离_,
		// Token: 0x0401268E RID: 75406
		额外臂垂直偏移最小偏移_目标高度差_,
		// Token: 0x0401268F RID: 75407
		额外臂垂直偏移最大偏移_目标高度差_,
		// Token: 0x04012690 RID: 75408
		额外臂垂直偏移与目标最大高度差_目标高度差_,
		// Token: 0x04012691 RID: 75409
		额外臂垂直偏移速度,
		// Token: 0x04012692 RID: 75410
		额外臂垂直偏移与目标最小高度差_目标高度差_,
		// Token: 0x04012693 RID: 75411
		EFightCameraAuto_MAX
	}
}
