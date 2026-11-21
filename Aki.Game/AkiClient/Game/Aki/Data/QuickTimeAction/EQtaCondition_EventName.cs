using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003177 RID: 12663
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/EQtaCondition_EventName.EQtaCondition_EventName")]
	public enum EQtaCondition_EventName : byte
	{
		// Token: 0x04010B50 RID: 68432
		角色死亡,
		// Token: 0x04010B51 RID: 68433
		当前技能结束,
		// Token: 0x04010B52 RID: 68434
		相机模式变更,
		// Token: 0x04010B53 RID: 68435
		EQtaCondition_MAX
	}
}
