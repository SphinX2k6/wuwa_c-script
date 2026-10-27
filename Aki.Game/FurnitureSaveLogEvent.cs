using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002153 RID: 8531
[NullableContext(1)]
[Nullable(0)]
public class FurnitureSaveLogEvent : PlayerCommonLogData
{
	// Token: 0x170014F6 RID: 5366
	// (get) Token: 0x06010A2F RID: 68143 RVA: 0x0040C055 File Offset: 0x0040A255
	// (set) Token: 0x06010A30 RID: 68144 RVA: 0x0040C05D File Offset: 0x0040A25D
	public override string event_id { get; set; } = "1836";

	// Token: 0x04007DEC RID: 32236
	public int i_area_id;

	// Token: 0x04007DED RID: 32237
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<FurniturePlaceLogData> o_old_place;

	// Token: 0x04007DEE RID: 32238
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<FurniturePlaceLogData> o_new_place;

	// Token: 0x04007DEF RID: 32239
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<FurniturePlaceDiffLogData> o_diff;

	// Token: 0x04007DF0 RID: 32240
	public int i_old_atmosphere;

	// Token: 0x04007DF1 RID: 32241
	public int i_new_atmosphere;

	// Token: 0x04007DF2 RID: 32242
	public int i_is_save;

	// Token: 0x04007DF3 RID: 32243
	public string s_trace_id = "";
}
