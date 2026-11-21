using System;
using System.Runtime.CompilerServices;

// Token: 0x02001623 RID: 5667
[NullableContext(1)]
[Nullable(0)]
public class ExploreEntityLogEvent : PlayerCommonLogData
{
	// Token: 0x1700151E RID: 5406
	// (get) Token: 0x0600DE8E RID: 56974 RVA: 0x0041865E File Offset: 0x0041685E
	// (set) Token: 0x0600DE8F RID: 56975 RVA: 0x00418666 File Offset: 0x00416866
	public override string event_id { get; set; } = "1172";

	// Token: 0x04007EBF RID: 32447
	public int i_config_id;

	// Token: 0x04007EC0 RID: 32448
	public int i_type;

	// Token: 0x04007EC1 RID: 32449
	public int interaction;

	// Token: 0x04007EC2 RID: 32450
	public int i_status;

	// Token: 0x04007EC3 RID: 32451
	public int i_result;

	// Token: 0x04007EC4 RID: 32452
	public float f_pos_x;

	// Token: 0x04007EC5 RID: 32453
	public float f_pos_y;

	// Token: 0x04007EC6 RID: 32454
	public float f_pos_z;

	// Token: 0x04007EC7 RID: 32455
	public int i_area_id;

	// Token: 0x04007EC8 RID: 32456
	public int i_father_area_id;
}
