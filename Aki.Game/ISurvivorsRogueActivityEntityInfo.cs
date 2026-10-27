using System;
using System.Runtime.CompilerServices;

// Token: 0x02000EC6 RID: 3782
[NullableContext(2)]
public interface ISurvivorsRogueActivityEntityInfo : ISurvivorsRogueCombatInfo, ISurvivorsRogueConfigInfo
{
	// Token: 0x17000724 RID: 1828
	// (get) Token: 0x06005DC7 RID: 24007
	// (set) Token: 0x06005DC8 RID: 24008
	int ConfigId { get; set; }

	// Token: 0x17000725 RID: 1829
	// (get) Token: 0x06005DC9 RID: 24009
	// (set) Token: 0x06005DCA RID: 24010
	ESurvivorsRogueMonsterDeathType DeathType { get; set; }

	// Token: 0x17000726 RID: 1830
	// (get) Token: 0x06005DCB RID: 24011
	// (set) Token: 0x06005DCC RID: 24012
	int BuffRadius { get; set; }

	// Token: 0x17000727 RID: 1831
	// (get) Token: 0x06005DCD RID: 24013
	// (set) Token: 0x06005DCE RID: 24014
	int[] BuffIds { get; set; }

	// Token: 0x17000728 RID: 1832
	// (get) Token: 0x06005DCF RID: 24015
	// (set) Token: 0x06005DD0 RID: 24016
	int[] SpawnIds { get; set; }

	// Token: 0x17000729 RID: 1833
	// (get) Token: 0x06005DD1 RID: 24017
	// (set) Token: 0x06005DD2 RID: 24018
	int PolluteRadius { get; set; }
}
