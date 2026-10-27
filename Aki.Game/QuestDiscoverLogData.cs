using System;
using System.Runtime.CompilerServices;

// Token: 0x020020CC RID: 8396
[NullableContext(1)]
[Nullable(0)]
public class QuestDiscoverLogData : PlayerCommonLogData
{
	// Token: 0x17001476 RID: 5238
	// (get) Token: 0x060108A5 RID: 67749 RVA: 0x0040A8D5 File Offset: 0x00408AD5
	// (set) Token: 0x060108A6 RID: 67750 RVA: 0x0040A8DD File Offset: 0x00408ADD
	public override string event_id { get; set; } = "1007";

	// Token: 0x04007B43 RID: 31555
	public int i_quest_id;

	// Token: 0x04007B44 RID: 31556
	public int i_quest_type;

	// Token: 0x04007B45 RID: 31557
	public int i_icon_distance;

	// Token: 0x04007B46 RID: 31558
	public int i_area_id;

	// Token: 0x04007B47 RID: 31559
	public int i_father_area_id;

	// Token: 0x04007B48 RID: 31560
	public float f_pos_x;

	// Token: 0x04007B49 RID: 31561
	public float f_pos_y;

	// Token: 0x04007B4A RID: 31562
	public float f_pos_z;
}
