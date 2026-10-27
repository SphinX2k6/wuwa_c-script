using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02004B0C RID: 19212
	[NullableContext(2)]
	public interface ITowerDefenseEventMonsterInfo : ITowerDefenseEventCombatInfo, ITowerDefenseEventConfigInfo
	{
		// Token: 0x17007B14 RID: 31508
		// (get) Token: 0x06031C09 RID: 203785
		// (set) Token: 0x06031C0A RID: 203786
		ETowerDefenseEventMonsterDeathType DeathType { get; set; }

		// Token: 0x17007B15 RID: 31509
		// (get) Token: 0x06031C0B RID: 203787
		// (set) Token: 0x06031C0C RID: 203788
		int BuffRadius { get; set; }

		// Token: 0x17007B16 RID: 31510
		// (get) Token: 0x06031C0D RID: 203789
		// (set) Token: 0x06031C0E RID: 203790
		List<int> BuffIds { get; set; }

		// Token: 0x17007B17 RID: 31511
		// (get) Token: 0x06031C0F RID: 203791
		// (set) Token: 0x06031C10 RID: 203792
		List<int> SpawnIds { get; set; }

		// Token: 0x17007B18 RID: 31512
		// (get) Token: 0x06031C11 RID: 203793
		// (set) Token: 0x06031C12 RID: 203794
		int PolluteRadius { get; set; }
	}
}
