using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020020CD RID: 8397
[NullableContext(1)]
[Nullable(0)]
public class AdviceWatchLogData : PlayerCommonLogData
{
	// Token: 0x17001477 RID: 5239
	// (get) Token: 0x060108A8 RID: 67752 RVA: 0x0040A8F9 File Offset: 0x00408AF9
	// (set) Token: 0x060108A9 RID: 67753 RVA: 0x0040A901 File Offset: 0x00408B01
	public override string event_id { get; set; } = "1008";

	// Token: 0x04007B4C RID: 31564
	public string l_advice_id = " ";

	// Token: 0x04007B4D RID: 31565
	public List<LogAdviceData> o_content;

	// Token: 0x04007B4E RID: 31566
	public int i_creator_id;

	// Token: 0x04007B4F RID: 31567
	public float f_pos_x;

	// Token: 0x04007B50 RID: 31568
	public float f_pos_y;

	// Token: 0x04007B51 RID: 31569
	public float f_pos_z;

	// Token: 0x04007B52 RID: 31570
	public int i_area_id;

	// Token: 0x04007B53 RID: 31571
	public int i_father_area_id;

	// Token: 0x04007B54 RID: 31572
	public int i_expression;

	// Token: 0x04007B55 RID: 31573
	public int i_motion;
}
