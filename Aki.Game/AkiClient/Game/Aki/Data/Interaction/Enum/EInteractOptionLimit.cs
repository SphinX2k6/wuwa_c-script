using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Interaction.Enum
{
	// Token: 0x02003F21 RID: 16161
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Interaction/Enum/EInteractOptionLimit.EInteractOptionLimit")]
	public enum EInteractOptionLimit : byte
	{
		// Token: 0x0401500C RID: 86028
		None,
		// Token: 0x0401500D RID: 86029
		Multiple,
		// Token: 0x0401500E RID: 86030
		DurationMultiple,
		// Token: 0x0401500F RID: 86031
		EInteractOptionLimit_MAX
	}
}
