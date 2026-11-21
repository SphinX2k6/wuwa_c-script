using System;
using System.Runtime.CompilerServices;

// Token: 0x020015AE RID: 5550
[NullableContext(1)]
[Nullable(0)]
public class ExploreToolItemUseLogData : PlayerCommonLogData
{
	// Token: 0x170014AC RID: 5292
	// (get) Token: 0x0600DD35 RID: 56629 RVA: 0x0041731A File Offset: 0x0041551A
	// (set) Token: 0x0600DD36 RID: 56630 RVA: 0x00417322 File Offset: 0x00415522
	public override string event_id { get; set; } = "1015";

	// Token: 0x04007CC4 RID: 31940
	public int i_father_area_id;

	// Token: 0x04007CC5 RID: 31941
	public int i_area_id;

	// Token: 0x04007CC6 RID: 31942
	public float f_pos_x;

	// Token: 0x04007CC7 RID: 31943
	public float f_pos_y;

	// Token: 0x04007CC8 RID: 31944
	public float f_pos_z;

	// Token: 0x04007CC9 RID: 31945
	public int i_item_id;
}
