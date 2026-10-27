using System;
using System.Runtime.CompilerServices;

// Token: 0x02003002 RID: 12290
[NullableContext(1)]
public interface ITriggerConfig
{
	// Token: 0x170023C1 RID: 9153
	// (get) Token: 0x0601A08A RID: 106634
	// (set) Token: 0x0601A08B RID: 106635
	string Type { get; set; }

	// Token: 0x170023C2 RID: 9154
	// (get) Token: 0x0601A08C RID: 106636
	// (set) Token: 0x0601A08D RID: 106637
	string[] Preset { get; set; }

	// Token: 0x170023C3 RID: 9155
	// (get) Token: 0x0601A08E RID: 106638
	// (set) Token: 0x0601A08F RID: 106639
	string Params { get; set; }

	// Token: 0x170023C4 RID: 9156
	// (get) Token: 0x0601A090 RID: 106640
	// (set) Token: 0x0601A091 RID: 106641
	string Formula { get; set; }

	// Token: 0x170023C5 RID: 9157
	// (get) Token: 0x0601A092 RID: 106642
	// (set) Token: 0x0601A093 RID: 106643
	EExecuteType ExecuteType { get; set; }
}
