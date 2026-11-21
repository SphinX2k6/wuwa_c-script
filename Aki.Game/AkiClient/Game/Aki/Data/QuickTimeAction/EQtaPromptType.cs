using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003178 RID: 12664
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/EQtaPromptType.EQtaPromptType")]
	public enum EQtaPromptType : byte
	{
		// Token: 0x04010B55 RID: 68437
		Qta开始,
		// Token: 0x04010B56 RID: 68438
		进入有效范围提示,
		// Token: 0x04010B57 RID: 68439
		离开有效范围提示,
		// Token: 0x04010B58 RID: 68440
		按下提示,
		// Token: 0x04010B59 RID: 68441
		抬起提示,
		// Token: 0x04010B5A RID: 68442
		操作有效提示,
		// Token: 0x04010B5B RID: 68443
		操作无效提示,
		// Token: 0x04010B5C RID: 68444
		结果成功提示,
		// Token: 0x04010B5D RID: 68445
		结果失败提示,
		// Token: 0x04010B5E RID: 68446
		EQtaPromptType_MAX
	}
}
