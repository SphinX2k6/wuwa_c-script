using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Fight.Enum
{
	// Token: 0x02003218 RID: 12824
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Enum/BPEEnableFollowShooter.BPEEnableFollowShooter")]
	public enum BPEEnableFollowShooter : byte
	{
		// Token: 0x040112E8 RID: 70376
		AutoDetectedFreezeWater,
		// Token: 0x040112E9 RID: 70377
		GameAbility,
		// Token: 0x040112EA RID: 70378
		AutoDetectedGamePartitionObject,
		// Token: 0x040112EB RID: 70379
		BPEEnableFollowShooter_MAX
	}
}
