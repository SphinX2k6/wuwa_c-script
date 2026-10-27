using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042B0 RID: 17072
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EDangoActionTargetType.EDangoActionTargetType")]
	public enum EDangoActionTargetType : byte
	{
		// Token: 0x04017385 RID: 95109
		自身团子,
		// Token: 0x04017386 RID: 95110
		自身与堆叠上方团子,
		// Token: 0x04017387 RID: 95111
		EDangoActionTargetType_MAX
	}
}
