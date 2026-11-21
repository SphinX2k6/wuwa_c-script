using System;
using System.Runtime.CompilerServices;

// Token: 0x0200163D RID: 5693
[NullableContext(1)]
[Nullable(0)]
public class GolemHackingStartEvent : PlayerCommonLogData
{
	// Token: 0x17001535 RID: 5429
	// (get) Token: 0x0600DED6 RID: 57046 RVA: 0x00418A56 File Offset: 0x00416C56
	// (set) Token: 0x0600DED7 RID: 57047 RVA: 0x00418A5E File Offset: 0x00416C5E
	public override string event_id { get; set; } = "1921";

	// Token: 0x04007F4D RID: 32589
	public int i_id;

	// Token: 0x04007F4E RID: 32590
	public int i_type;

	// Token: 0x04007F4F RID: 32591
	public int i_first_pass;

	// Token: 0x04007F50 RID: 32592
	public string s_trace_id = "";
}
