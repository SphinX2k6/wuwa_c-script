using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003EAA RID: 16042
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/EQtaPromptType.EQtaPromptType")]
	public enum EQtaPromptType : byte
	{
		// Token: 0x04014B29 RID: 84777
		Qta开始,
		// Token: 0x04014B2A RID: 84778
		进入有效范围提示,
		// Token: 0x04014B2B RID: 84779
		离开有效范围提示,
		// Token: 0x04014B2C RID: 84780
		按下提示,
		// Token: 0x04014B2D RID: 84781
		抬起提示,
		// Token: 0x04014B2E RID: 84782
		操作有效提示,
		// Token: 0x04014B2F RID: 84783
		操作无效提示,
		// Token: 0x04014B30 RID: 84784
		结果成功提示,
		// Token: 0x04014B31 RID: 84785
		结果失败提示,
		// Token: 0x04014B32 RID: 84786
		EQtaPromptType_MAX
	}
}
