using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043A9 RID: 17321
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraAdjust.EFightCameraAdjust")]
	public enum EFightCameraAdjust : byte
	{
		// Token: 0x04017AF8 RID: 97016
		None,
		// Token: 0x04017AF9 RID: 97017
		摄像机最小Pitch_目标比角色矮_,
		// Token: 0x04017AFA RID: 97018
		摄像机最大Pitch_目标比角色矮_,
		// Token: 0x04017AFB RID: 97019
		摄像机最小Pitch_目标比角色高_,
		// Token: 0x04017AFC RID: 97020
		摄像机最大Pitch_目标比角色高_,
		// Token: 0x04017AFD RID: 97021
		近距离范围,
		// Token: 0x04017AFE RID: 97022
		近距离修正最小角度,
		// Token: 0x04017AFF RID: 97023
		近距离修正最大角度,
		// Token: 0x04017B00 RID: 97024
		远距离修正最小角度,
		// Token: 0x04017B01 RID: 97025
		远距离修正最大角度,
		// Token: 0x04017B02 RID: 97026
		检测屏幕内MinX,
		// Token: 0x04017B03 RID: 97027
		检测屏幕内MaxX,
		// Token: 0x04017B04 RID: 97028
		检测屏幕内MinY,
		// Token: 0x04017B05 RID: 97029
		检测屏幕内MaxY,
		// Token: 0x04017B06 RID: 97030
		技能修正过渡时间,
		// Token: 0x04017B07 RID: 97031
		EFightCameraAdjust_MAX
	}
}
