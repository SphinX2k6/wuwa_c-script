using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043AD RID: 17325
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraDialogue.EFightCameraDialogue")]
	public enum EFightCameraDialogue : byte
	{
		// Token: 0x04017BB4 RID: 97204
		None,
		// Token: 0x04017BB5 RID: 97205
		淡入系数,
		// Token: 0x04017BB6 RID: 97206
		淡入时间,
		// Token: 0x04017BB7 RID: 97207
		淡出速率,
		// Token: 0x04017BB8 RID: 97208
		检查旋转角度,
		// Token: 0x04017BB9 RID: 97209
		检查最小俯仰角,
		// Token: 0x04017BBA RID: 97210
		检查最大俯仰角,
		// Token: 0x04017BBB RID: 97211
		调整旋转角度,
		// Token: 0x04017BBC RID: 97212
		调整最小俯仰角,
		// Token: 0x04017BBD RID: 97213
		调整最大俯仰角,
		// Token: 0x04017BBE RID: 97214
		中心点偏移比例,
		// Token: 0x04017BBF RID: 97215
		中心点最大偏移距离,
		// Token: 0x04017BC0 RID: 97216
		对话镜头臂长,
		// Token: 0x04017BC1 RID: 97217
		EFightCameraDialogue_MAX
	}
}
