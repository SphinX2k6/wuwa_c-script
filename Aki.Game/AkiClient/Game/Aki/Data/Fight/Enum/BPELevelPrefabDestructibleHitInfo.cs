using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Fight.Enum
{
	// Token: 0x0200321A RID: 12826
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Enum/BPELevelPrefabDestructibleHitInfo.BPELevelPrefabDestructibleHitInfo")]
	public enum BPELevelPrefabDestructibleHitInfo : byte
	{
		// Token: 0x040112F1 RID: 70385
		子弹_受击点和地面受击速度_,
		// Token: 0x040112F2 RID: 70386
		和实体Range组件Overlap的Actor的位置,
		// Token: 0x040112F3 RID: 70387
		和实体Range组件Overlap的Actor的位置和Actor的速度_前提有速度_,
		// Token: 0x040112F4 RID: 70388
		和实体Range组件Overlap的Actor的位置和Actor的速度_曲线_,
		// Token: 0x040112F5 RID: 70389
		BPELevelPrefabDestructibleHitInfo_MAX
	}
}
