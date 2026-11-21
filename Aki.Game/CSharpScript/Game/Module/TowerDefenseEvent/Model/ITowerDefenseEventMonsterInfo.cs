using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02003AB4 RID: 15028
	[NullableContext(2)]
	public interface ITowerDefenseEventMonsterInfo : ITowerDefenseEventCombatInfo, ITowerDefenseEventConfigInfo
	{
		// Token: 0x17004EC1 RID: 20161
		// (get) Token: 0x06026999 RID: 158105
		// (set) Token: 0x0602699A RID: 158106
		ETowerDefenseEventMonsterDeathType DeathType { get; set; }

		// Token: 0x17004EC2 RID: 20162
		// (get) Token: 0x0602699B RID: 158107
		// (set) Token: 0x0602699C RID: 158108
		int BuffRadius { get; set; }

		// Token: 0x17004EC3 RID: 20163
		// (get) Token: 0x0602699D RID: 158109
		// (set) Token: 0x0602699E RID: 158110
		List<int> BuffIds { get; set; }

		// Token: 0x17004EC4 RID: 20164
		// (get) Token: 0x0602699F RID: 158111
		// (set) Token: 0x060269A0 RID: 158112
		List<int> SpawnIds { get; set; }

		// Token: 0x17004EC5 RID: 20165
		// (get) Token: 0x060269A1 RID: 158113
		// (set) Token: 0x060269A2 RID: 158114
		int PolluteRadius { get; set; }
	}
}
