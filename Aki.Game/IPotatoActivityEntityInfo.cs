using System;
using System.Runtime.CompilerServices;

// Token: 0x02000368 RID: 872
[NullableContext(2)]
public interface IPotatoActivityEntityInfo : IPotatoCombatInfo, IPotatoConfigInfo
{
	// Token: 0x17000719 RID: 1817
	// (get) Token: 0x06003081 RID: 12417
	// (set) Token: 0x06003082 RID: 12418
	int ConfigId { get; set; }

	// Token: 0x1700071A RID: 1818
	// (get) Token: 0x06003083 RID: 12419
	// (set) Token: 0x06003084 RID: 12420
	EPotatoMonsterDeathType DeathType { get; set; }

	// Token: 0x1700071B RID: 1819
	// (get) Token: 0x06003085 RID: 12421
	// (set) Token: 0x06003086 RID: 12422
	int BuffRadius { get; set; }

	// Token: 0x1700071C RID: 1820
	// (get) Token: 0x06003087 RID: 12423
	// (set) Token: 0x06003088 RID: 12424
	int[] BuffIds { get; set; }

	// Token: 0x1700071D RID: 1821
	// (get) Token: 0x06003089 RID: 12425
	// (set) Token: 0x0600308A RID: 12426
	int[] SpawnIds { get; set; }

	// Token: 0x1700071E RID: 1822
	// (get) Token: 0x0600308B RID: 12427
	// (set) Token: 0x0600308C RID: 12428
	int PolluteRadius { get; set; }

	// Token: 0x1700071F RID: 1823
	// (get) Token: 0x0600308D RID: 12429
	// (set) Token: 0x0600308E RID: 12430
	int IncId { get; set; }

	// Token: 0x17000720 RID: 1824
	// (get) Token: 0x0600308F RID: 12431
	// (set) Token: 0x06003090 RID: 12432
	int SpawnConfigId { get; set; }

	// Token: 0x17000721 RID: 1825
	// (get) Token: 0x06003091 RID: 12433
	// (set) Token: 0x06003092 RID: 12434
	int SpawnConfigGroupIndex { get; set; }
}
