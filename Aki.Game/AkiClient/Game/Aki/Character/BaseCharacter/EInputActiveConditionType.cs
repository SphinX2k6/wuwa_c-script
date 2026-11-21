using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003314 RID: 13076
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EInputActiveConditionType.EInputActiveConditionType")]
	public enum EInputActiveConditionType : byte
	{
		// Token: 0x040120C8 RID: 73928
		施法者标签检测,
		// Token: 0x040120C9 RID: 73929
		施法者属性检测,
		// Token: 0x040120CA RID: 73930
		EInputActiveConditionType_MAX
	}
}
