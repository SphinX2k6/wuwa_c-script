using System;
using System.Runtime.CompilerServices;

// Token: 0x020015B3 RID: 5555
[NullableContext(1)]
[Nullable(0)]
public class ExploreToolGeneralUseLogData : UnitLogData
{
	// Token: 0x170014B1 RID: 5297
	// (get) Token: 0x0600DD44 RID: 56644 RVA: 0x004173CE File Offset: 0x004155CE
	// (set) Token: 0x0600DD45 RID: 56645 RVA: 0x004173D6 File Offset: 0x004155D6
	public override string event_id { get; set; } = "";

	// Token: 0x04007CE7 RID: 31975
	public int i_father_area_id;

	// Token: 0x04007CE8 RID: 31976
	public int i_area_id;

	// Token: 0x04007CE9 RID: 31977
	public float f_pos_x;

	// Token: 0x04007CEA RID: 31978
	public float f_pos_y;

	// Token: 0x04007CEB RID: 31979
	public float f_pos_z;

	// Token: 0x04007CEC RID: 31980
	public int i_skill_id;

	// Token: 0x04007CED RID: 31981
	public int i_entity_configId;
}
