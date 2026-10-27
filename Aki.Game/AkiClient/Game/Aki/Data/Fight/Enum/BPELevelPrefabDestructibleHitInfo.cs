using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Fight.Enum
{
	// Token: 0x02003F7D RID: 16253
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Enum/BPELevelPrefabDestructibleHitInfo.BPELevelPrefabDestructibleHitInfo")]
	public enum BPELevelPrefabDestructibleHitInfo : byte
	{
		// Token: 0x0401544E RID: 87118
		子弹_受击点和地面受击速度_,
		// Token: 0x0401544F RID: 87119
		和实体Range组件Overlap的Actor的位置,
		// Token: 0x04015450 RID: 87120
		和实体Range组件Overlap的Actor的位置和Actor的速度_前提有速度_,
		// Token: 0x04015451 RID: 87121
		和实体Range组件Overlap的Actor的位置和Actor的速度_曲线_,
		// Token: 0x04015452 RID: 87122
		BPELevelPrefabDestructibleHitInfo_MAX
	}
}
