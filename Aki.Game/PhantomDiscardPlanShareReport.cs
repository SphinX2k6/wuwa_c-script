using System;
using System.Runtime.CompilerServices;

// Token: 0x02001637 RID: 5687
[NullableContext(1)]
[Nullable(0)]
public class PhantomDiscardPlanShareReport : PlayerCommonLogData
{
	// Token: 0x1700152F RID: 5423
	// (get) Token: 0x0600DEC4 RID: 57028 RVA: 0x00418952 File Offset: 0x00416B52
	// (set) Token: 0x0600DEC5 RID: 57029 RVA: 0x0041895A File Offset: 0x00416B5A
	public override string event_id { get; set; } = "1847";

	// Token: 0x04007F2E RID: 32558
	public int i_type;

	// Token: 0x04007F2F RID: 32559
	public string s_my_code = "";

	// Token: 0x04007F30 RID: 32560
	public string s_others_code = "";
}
