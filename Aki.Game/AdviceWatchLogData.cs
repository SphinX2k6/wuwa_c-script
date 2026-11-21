using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020015A4 RID: 5540
[NullableContext(1)]
[Nullable(0)]
public class AdviceWatchLogData : PlayerCommonLogData
{
	// Token: 0x170014A4 RID: 5284
	// (get) Token: 0x0600DD18 RID: 56600 RVA: 0x00417001 File Offset: 0x00415201
	// (set) Token: 0x0600DD19 RID: 56601 RVA: 0x00417009 File Offset: 0x00415209
	public override string event_id { get; set; } = "1008";

	// Token: 0x04007C4A RID: 31818
	public string l_advice_id = " ";

	// Token: 0x04007C4B RID: 31819
	public List<LogAdviceData> o_content;

	// Token: 0x04007C4C RID: 31820
	public int i_creator_id;

	// Token: 0x04007C4D RID: 31821
	public float f_pos_x;

	// Token: 0x04007C4E RID: 31822
	public float f_pos_y;

	// Token: 0x04007C4F RID: 31823
	public float f_pos_z;

	// Token: 0x04007C50 RID: 31824
	public int i_area_id;

	// Token: 0x04007C51 RID: 31825
	public int i_father_area_id;

	// Token: 0x04007C52 RID: 31826
	public int i_expression;

	// Token: 0x04007C53 RID: 31827
	public int i_motion;
}
