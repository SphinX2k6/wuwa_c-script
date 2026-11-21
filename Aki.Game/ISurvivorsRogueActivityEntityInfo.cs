using System;
using System.Runtime.CompilerServices;

// Token: 0x0200037B RID: 891
[NullableContext(2)]
public interface ISurvivorsRogueActivityEntityInfo : ISurvivorsRogueCombatInfo, ISurvivorsRogueConfigInfo
{
	// Token: 0x17000748 RID: 1864
	// (get) Token: 0x0600315E RID: 12638
	// (set) Token: 0x0600315F RID: 12639
	int ConfigId { get; set; }

	// Token: 0x17000749 RID: 1865
	// (get) Token: 0x06003160 RID: 12640
	// (set) Token: 0x06003161 RID: 12641
	ESurvivorsRogueMonsterDeathType DeathType { get; set; }

	// Token: 0x1700074A RID: 1866
	// (get) Token: 0x06003162 RID: 12642
	// (set) Token: 0x06003163 RID: 12643
	int BuffRadius { get; set; }

	// Token: 0x1700074B RID: 1867
	// (get) Token: 0x06003164 RID: 12644
	// (set) Token: 0x06003165 RID: 12645
	int[] BuffIds { get; set; }

	// Token: 0x1700074C RID: 1868
	// (get) Token: 0x06003166 RID: 12646
	// (set) Token: 0x06003167 RID: 12647
	int[] SpawnIds { get; set; }

	// Token: 0x1700074D RID: 1869
	// (get) Token: 0x06003168 RID: 12648
	// (set) Token: 0x06003169 RID: 12649
	int PolluteRadius { get; set; }
}
