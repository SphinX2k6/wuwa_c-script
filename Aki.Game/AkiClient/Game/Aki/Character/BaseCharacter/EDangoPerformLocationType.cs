using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200330A RID: 13066
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EDangoPerformLocationType.EDangoPerformLocationType")]
	public enum EDangoPerformLocationType : byte
	{
		// Token: 0x0401207A RID: 73850
		跟随团子骨骼,
		// Token: 0x0401207B RID: 73851
		当前底座位置,
		// Token: 0x0401207C RID: 73852
		当前团子位置,
		// Token: 0x0401207D RID: 73853
		EDangoPerformLocationType_MAX
	}
}
