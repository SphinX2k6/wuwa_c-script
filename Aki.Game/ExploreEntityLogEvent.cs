using System;
using System.Runtime.CompilerServices;

// Token: 0x0200214B RID: 8523
[NullableContext(1)]
[Nullable(0)]
public class ExploreEntityLogEvent : PlayerCommonLogData
{
	// Token: 0x170014F0 RID: 5360
	// (get) Token: 0x06010A1B RID: 68123 RVA: 0x0040BF16 File Offset: 0x0040A116
	// (set) Token: 0x06010A1C RID: 68124 RVA: 0x0040BF1E File Offset: 0x0040A11E
	public override string event_id { get; set; } = "1172";

	// Token: 0x04007DAF RID: 32175
	public int i_config_id;

	// Token: 0x04007DB0 RID: 32176
	public int i_type;

	// Token: 0x04007DB1 RID: 32177
	public int interaction;

	// Token: 0x04007DB2 RID: 32178
	public int i_status;

	// Token: 0x04007DB3 RID: 32179
	public int i_result;

	// Token: 0x04007DB4 RID: 32180
	public float f_pos_x;

	// Token: 0x04007DB5 RID: 32181
	public float f_pos_y;

	// Token: 0x04007DB6 RID: 32182
	public float f_pos_z;

	// Token: 0x04007DB7 RID: 32183
	public int i_area_id;

	// Token: 0x04007DB8 RID: 32184
	public int i_father_area_id;
}
