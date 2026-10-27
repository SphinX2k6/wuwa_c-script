using System;
using System.Runtime.CompilerServices;

// Token: 0x0200215F RID: 8543
[NullableContext(1)]
[Nullable(0)]
public class PhantomDiscardPlanShareReport : PlayerCommonLogData
{
	// Token: 0x17001501 RID: 5377
	// (get) Token: 0x06010A51 RID: 68177 RVA: 0x0040C20A File Offset: 0x0040A40A
	// (set) Token: 0x06010A52 RID: 68178 RVA: 0x0040C212 File Offset: 0x0040A412
	public override string event_id { get; set; } = "1847";

	// Token: 0x04007E1E RID: 32286
	public int i_type;

	// Token: 0x04007E1F RID: 32287
	public string s_my_code = "";

	// Token: 0x04007E20 RID: 32288
	public string s_others_code = "";
}
