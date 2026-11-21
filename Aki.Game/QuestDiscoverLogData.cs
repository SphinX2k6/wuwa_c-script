using System;
using System.Runtime.CompilerServices;

// Token: 0x020015A3 RID: 5539
[NullableContext(1)]
[Nullable(0)]
public class QuestDiscoverLogData : PlayerCommonLogData
{
	// Token: 0x170014A3 RID: 5283
	// (get) Token: 0x0600DD15 RID: 56597 RVA: 0x00416FDD File Offset: 0x004151DD
	// (set) Token: 0x0600DD16 RID: 56598 RVA: 0x00416FE5 File Offset: 0x004151E5
	public override string event_id { get; set; } = "1007";

	// Token: 0x04007C41 RID: 31809
	public int i_quest_id;

	// Token: 0x04007C42 RID: 31810
	public int i_quest_type;

	// Token: 0x04007C43 RID: 31811
	public int i_icon_distance;

	// Token: 0x04007C44 RID: 31812
	public int i_area_id;

	// Token: 0x04007C45 RID: 31813
	public int i_father_area_id;

	// Token: 0x04007C46 RID: 31814
	public float f_pos_x;

	// Token: 0x04007C47 RID: 31815
	public float f_pos_y;

	// Token: 0x04007C48 RID: 31816
	public float f_pos_z;
}
