using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003175 RID: 12661
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/EQtaConditionType.EQtaConditionType")]
	public enum EQtaConditionType : byte
	{
		// Token: 0x04010B45 RID: 68421
		检查输入,
		// Token: 0x04010B46 RID: 68422
		检查Tag,
		// Token: 0x04010B47 RID: 68423
		事件变化,
		// Token: 0x04010B48 RID: 68424
		EQtaConditionType_MAX
	}
}
