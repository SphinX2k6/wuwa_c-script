using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003309 RID: 13065
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EDangoActionTargetType.EDangoActionTargetType")]
	public enum EDangoActionTargetType : byte
	{
		// Token: 0x04012076 RID: 73846
		自身团子,
		// Token: 0x04012077 RID: 73847
		自身与堆叠上方团子,
		// Token: 0x04012078 RID: 73848
		EDangoActionTargetType_MAX
	}
}
