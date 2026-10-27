using System;
using System.Runtime.CompilerServices;

// Token: 0x0200214C RID: 8524
[NullableContext(1)]
[Nullable(0)]
public class FindSunSpiritStartLogEvent : PlayerCommonLogData
{
	// Token: 0x170014F1 RID: 5361
	// (get) Token: 0x06010A1E RID: 68126 RVA: 0x0040BF3A File Offset: 0x0040A13A
	// (set) Token: 0x06010A1F RID: 68127 RVA: 0x0040BF42 File Offset: 0x0040A142
	public override string event_id { get; set; } = "1819";

	// Token: 0x04007DBA RID: 32186
	public int i_config_id;

	// Token: 0x04007DBB RID: 32187
	public int i_id;

	// Token: 0x04007DBC RID: 32188
	public string s_type_name = "";

	// Token: 0x04007DBD RID: 32189
	public int i_paint_count;
}
