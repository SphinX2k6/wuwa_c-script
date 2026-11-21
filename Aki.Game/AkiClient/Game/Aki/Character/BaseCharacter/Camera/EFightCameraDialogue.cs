using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033CB RID: 13259
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraDialogue.EFightCameraDialogue")]
	public enum EFightCameraDialogue : byte
	{
		// Token: 0x04012727 RID: 75559
		None,
		// Token: 0x04012728 RID: 75560
		淡入系数,
		// Token: 0x04012729 RID: 75561
		淡入时间,
		// Token: 0x0401272A RID: 75562
		淡出速率,
		// Token: 0x0401272B RID: 75563
		检查旋转角度,
		// Token: 0x0401272C RID: 75564
		检查最小俯仰角,
		// Token: 0x0401272D RID: 75565
		检查最大俯仰角,
		// Token: 0x0401272E RID: 75566
		调整旋转角度,
		// Token: 0x0401272F RID: 75567
		调整最小俯仰角,
		// Token: 0x04012730 RID: 75568
		调整最大俯仰角,
		// Token: 0x04012731 RID: 75569
		中心点偏移比例,
		// Token: 0x04012732 RID: 75570
		中心点最大偏移距离,
		// Token: 0x04012733 RID: 75571
		对话镜头臂长,
		// Token: 0x04012734 RID: 75572
		EFightCameraDialogue_MAX
	}
}
