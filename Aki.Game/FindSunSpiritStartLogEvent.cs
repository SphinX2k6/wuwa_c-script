using System;
using System.Runtime.CompilerServices;

// Token: 0x02001624 RID: 5668
[NullableContext(1)]
[Nullable(0)]
public class FindSunSpiritStartLogEvent : PlayerCommonLogData
{
	// Token: 0x1700151F RID: 5407
	// (get) Token: 0x0600DE91 RID: 56977 RVA: 0x00418682 File Offset: 0x00416882
	// (set) Token: 0x0600DE92 RID: 56978 RVA: 0x0041868A File Offset: 0x0041688A
	public override string event_id { get; set; } = "1819";

	// Token: 0x04007ECA RID: 32458
	public int i_config_id;

	// Token: 0x04007ECB RID: 32459
	public int i_id;

	// Token: 0x04007ECC RID: 32460
	public string s_type_name = "";

	// Token: 0x04007ECD RID: 32461
	public int i_paint_count;
}
