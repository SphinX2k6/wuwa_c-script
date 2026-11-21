using System;
using System.Runtime.CompilerServices;

// Token: 0x02001646 RID: 5702
[NullableContext(1)]
[Nullable(0)]
public class RoleLangCustomSettingEvent : PlayerCommonLogData
{
	// Token: 0x1700153E RID: 5438
	// (get) Token: 0x0600DEF1 RID: 57073 RVA: 0x00418BB0 File Offset: 0x00416DB0
	// (set) Token: 0x0600DEF2 RID: 57074 RVA: 0x00418BB8 File Offset: 0x00416DB8
	public override string event_id { get; set; } = "1927";

	// Token: 0x04007F71 RID: 32625
	public int i_language;

	// Token: 0x04007F72 RID: 32626
	public int i_cover;

	// Token: 0x04007F73 RID: 32627
	public int i_way;
}
