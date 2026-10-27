using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042BD RID: 17085
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EInputActiveConditionType.EInputActiveConditionType")]
	public enum EInputActiveConditionType : byte
	{
		// Token: 0x040173E5 RID: 95205
		施法者标签检测,
		// Token: 0x040173E6 RID: 95206
		施法者属性检测,
		// Token: 0x040173E7 RID: 95207
		EInputActiveConditionType_MAX
	}
}
