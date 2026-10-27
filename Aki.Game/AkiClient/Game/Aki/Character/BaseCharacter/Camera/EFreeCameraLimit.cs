using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043BD RID: 17341
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFreeCameraLimit.EFreeCameraLimit")]
	public enum EFreeCameraLimit : byte
	{
		// Token: 0x04017C70 RID: 97392
		None,
		// Token: 0x04017C71 RID: 97393
		世界X轴偏移上界,
		// Token: 0x04017C72 RID: 97394
		世界X轴偏移下界,
		// Token: 0x04017C73 RID: 97395
		世界Y轴偏移上界,
		// Token: 0x04017C74 RID: 97396
		世界Y轴偏移下界,
		// Token: 0x04017C75 RID: 97397
		世界Z轴偏移上界,
		// Token: 0x04017C76 RID: 97398
		世界Z轴偏移下界,
		// Token: 0x04017C77 RID: 97399
		最小FOV,
		// Token: 0x04017C78 RID: 97400
		最大FOV,
		// Token: 0x04017C79 RID: 97401
		Yaw限制Min,
		// Token: 0x04017C7A RID: 97402
		Yaw限制Max,
		// Token: 0x04017C7B RID: 97403
		Pitch限制Min,
		// Token: 0x04017C7C RID: 97404
		Pitch限制Max,
		// Token: 0x04017C7D RID: 97405
		EFreeCameraLimit_MAX
	}
}
