using System;
using System.Runtime.CompilerServices;

// Token: 0x02001625 RID: 5669
[NullableContext(1)]
[Nullable(0)]
public class FindSunSpiritFinishLogEvent : PlayerCommonLogData
{
	// Token: 0x17001520 RID: 5408
	// (get) Token: 0x0600DE94 RID: 56980 RVA: 0x004186B1 File Offset: 0x004168B1
	// (set) Token: 0x0600DE95 RID: 56981 RVA: 0x004186B9 File Offset: 0x004168B9
	public override string event_id { get; set; } = "1820";

	// Token: 0x04007ECF RID: 32463
	public int i_config_id;

	// Token: 0x04007ED0 RID: 32464
	public int i_id;

	// Token: 0x04007ED1 RID: 32465
	public string s_type_name = "";

	// Token: 0x04007ED2 RID: 32466
	public int i_paint_count;

	// Token: 0x04007ED3 RID: 32467
	public int i_count;
}
