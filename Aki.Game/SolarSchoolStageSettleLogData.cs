using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001664 RID: 5732
[NullableContext(1)]
[Nullable(0)]
public class SolarSchoolStageSettleLogData : SolarSchoolLogData
{
	// Token: 0x17001555 RID: 5461
	// (get) Token: 0x0600DF3D RID: 57149 RVA: 0x00418FFD File Offset: 0x004171FD
	// (set) Token: 0x0600DF3E RID: 57150 RVA: 0x00419005 File Offset: 0x00417205
	public override string event_id { get; set; } = "2104";

	// Token: 0x0400802A RID: 32810
	public int i_activity_type;

	// Token: 0x0400802B RID: 32811
	public int i_type;

	// Token: 0x0400802C RID: 32812
	public string s_tag = "";

	// Token: 0x0400802D RID: 32813
	public string s_roles = "";

	// Token: 0x0400802E RID: 32814
	public SolarSchoolAttrInfoLogData o_attr_info = new SolarSchoolAttrInfoLogData();

	// Token: 0x0400802F RID: 32815
	public int i_count;

	// Token: 0x04008030 RID: 32816
	public List<SolarSchoolExamResultLogData> o_exam_result = new List<SolarSchoolExamResultLogData>();
}
