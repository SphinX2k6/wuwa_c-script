using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Fight.Enum
{
	// Token: 0x02003F7B RID: 16251
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Enum/BPEEnableFollowShooter.BPEEnableFollowShooter")]
	public enum BPEEnableFollowShooter : byte
	{
		// Token: 0x04015445 RID: 87109
		AutoDetectedFreezeWater,
		// Token: 0x04015446 RID: 87110
		GameAbility,
		// Token: 0x04015447 RID: 87111
		AutoDetectedGamePartitionObject,
		// Token: 0x04015448 RID: 87112
		BPEEnableFollowShooter_MAX
	}
}
