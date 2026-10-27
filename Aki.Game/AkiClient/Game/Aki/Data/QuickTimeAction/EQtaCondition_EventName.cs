using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003EA9 RID: 16041
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/EQtaCondition_EventName.EQtaCondition_EventName")]
	public enum EQtaCondition_EventName : byte
	{
		// Token: 0x04014B24 RID: 84772
		角色死亡,
		// Token: 0x04014B25 RID: 84773
		当前技能结束,
		// Token: 0x04014B26 RID: 84774
		相机模式变更,
		// Token: 0x04014B27 RID: 84775
		EQtaCondition_MAX
	}
}
