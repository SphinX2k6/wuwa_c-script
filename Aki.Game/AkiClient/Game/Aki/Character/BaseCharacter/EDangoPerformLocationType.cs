using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042B1 RID: 17073
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EDangoPerformLocationType.EDangoPerformLocationType")]
	public enum EDangoPerformLocationType : byte
	{
		// Token: 0x04017389 RID: 95113
		跟随团子骨骼,
		// Token: 0x0401738A RID: 95114
		当前底座位置,
		// Token: 0x0401738B RID: 95115
		当前团子位置,
		// Token: 0x0401738C RID: 95116
		EDangoPerformLocationType_MAX
	}
}
