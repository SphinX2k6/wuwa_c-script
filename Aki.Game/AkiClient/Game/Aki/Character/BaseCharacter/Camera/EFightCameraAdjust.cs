using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033C7 RID: 13255
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraAdjust.EFightCameraAdjust")]
	public enum EFightCameraAdjust : byte
	{
		// Token: 0x0401266A RID: 75370
		None,
		// Token: 0x0401266B RID: 75371
		摄像机最小Pitch_目标比角色矮_,
		// Token: 0x0401266C RID: 75372
		摄像机最大Pitch_目标比角色矮_,
		// Token: 0x0401266D RID: 75373
		摄像机最小Pitch_目标比角色高_,
		// Token: 0x0401266E RID: 75374
		摄像机最大Pitch_目标比角色高_,
		// Token: 0x0401266F RID: 75375
		近距离范围,
		// Token: 0x04012670 RID: 75376
		近距离修正最小角度,
		// Token: 0x04012671 RID: 75377
		近距离修正最大角度,
		// Token: 0x04012672 RID: 75378
		远距离修正最小角度,
		// Token: 0x04012673 RID: 75379
		远距离修正最大角度,
		// Token: 0x04012674 RID: 75380
		检测屏幕内MinX,
		// Token: 0x04012675 RID: 75381
		检测屏幕内MaxX,
		// Token: 0x04012676 RID: 75382
		检测屏幕内MinY,
		// Token: 0x04012677 RID: 75383
		检测屏幕内MaxY,
		// Token: 0x04012678 RID: 75384
		技能修正过渡时间,
		// Token: 0x04012679 RID: 75385
		EFightCameraAdjust_MAX
	}
}
