using System;
using System.Runtime.CompilerServices;

// Token: 0x02000EB3 RID: 3763
[NullableContext(2)]
public interface IPotatoActivityEntityInfo : IPotatoCombatInfo, IPotatoConfigInfo
{
	// Token: 0x170006F5 RID: 1781
	// (get) Token: 0x06005CEA RID: 23786
	// (set) Token: 0x06005CEB RID: 23787
	int ConfigId { get; set; }

	// Token: 0x170006F6 RID: 1782
	// (get) Token: 0x06005CEC RID: 23788
	// (set) Token: 0x06005CED RID: 23789
	EPotatoMonsterDeathType DeathType { get; set; }

	// Token: 0x170006F7 RID: 1783
	// (get) Token: 0x06005CEE RID: 23790
	// (set) Token: 0x06005CEF RID: 23791
	int BuffRadius { get; set; }

	// Token: 0x170006F8 RID: 1784
	// (get) Token: 0x06005CF0 RID: 23792
	// (set) Token: 0x06005CF1 RID: 23793
	int[] BuffIds { get; set; }

	// Token: 0x170006F9 RID: 1785
	// (get) Token: 0x06005CF2 RID: 23794
	// (set) Token: 0x06005CF3 RID: 23795
	int[] SpawnIds { get; set; }

	// Token: 0x170006FA RID: 1786
	// (get) Token: 0x06005CF4 RID: 23796
	// (set) Token: 0x06005CF5 RID: 23797
	int PolluteRadius { get; set; }

	// Token: 0x170006FB RID: 1787
	// (get) Token: 0x06005CF6 RID: 23798
	// (set) Token: 0x06005CF7 RID: 23799
	int IncId { get; set; }

	// Token: 0x170006FC RID: 1788
	// (get) Token: 0x06005CF8 RID: 23800
	// (set) Token: 0x06005CF9 RID: 23801
	int SpawnConfigId { get; set; }

	// Token: 0x170006FD RID: 1789
	// (get) Token: 0x06005CFA RID: 23802
	// (set) Token: 0x06005CFB RID: 23803
	int SpawnConfigGroupIndex { get; set; }
}
