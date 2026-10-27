using System;
using System.Runtime.CompilerServices;

// Token: 0x0200214D RID: 8525
[NullableContext(1)]
[Nullable(0)]
public class FindSunSpiritFinishLogEvent : PlayerCommonLogData
{
	// Token: 0x170014F2 RID: 5362
	// (get) Token: 0x06010A21 RID: 68129 RVA: 0x0040BF69 File Offset: 0x0040A169
	// (set) Token: 0x06010A22 RID: 68130 RVA: 0x0040BF71 File Offset: 0x0040A171
	public override string event_id { get; set; } = "1820";

	// Token: 0x04007DBF RID: 32191
	public int i_config_id;

	// Token: 0x04007DC0 RID: 32192
	public int i_id;

	// Token: 0x04007DC1 RID: 32193
	public string s_type_name = "";

	// Token: 0x04007DC2 RID: 32194
	public int i_paint_count;

	// Token: 0x04007DC3 RID: 32195
	public int i_count;
}
