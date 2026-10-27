using System;
using System.Runtime.CompilerServices;

// Token: 0x020020D7 RID: 8407
[NullableContext(1)]
[Nullable(0)]
public class ExploreToolItemUseLogData : PlayerCommonLogData
{
	// Token: 0x1700147F RID: 5247
	// (get) Token: 0x060108C5 RID: 67781 RVA: 0x0040AC0A File Offset: 0x00408E0A
	// (set) Token: 0x060108C6 RID: 67782 RVA: 0x0040AC12 File Offset: 0x00408E12
	public override string event_id { get; set; } = "1015";

	// Token: 0x04007BC5 RID: 31685
	public int i_father_area_id;

	// Token: 0x04007BC6 RID: 31686
	public int i_area_id;

	// Token: 0x04007BC7 RID: 31687
	public float f_pos_x;

	// Token: 0x04007BC8 RID: 31688
	public float f_pos_y;

	// Token: 0x04007BC9 RID: 31689
	public float f_pos_z;

	// Token: 0x04007BCA RID: 31690
	public int i_item_id;
}
