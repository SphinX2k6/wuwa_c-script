using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003EA7 RID: 16039
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/EQtaConditionType.EQtaConditionType")]
	public enum EQtaConditionType : byte
	{
		// Token: 0x04014B19 RID: 84761
		检查输入,
		// Token: 0x04014B1A RID: 84762
		检查Tag,
		// Token: 0x04014B1B RID: 84763
		事件变化,
		// Token: 0x04014B1C RID: 84764
		EQtaConditionType_MAX
	}
}
