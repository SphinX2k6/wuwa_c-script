using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200162B RID: 5675
[NullableContext(1)]
[Nullable(0)]
public class FurnitureSaveLogEvent : PlayerCommonLogData
{
	// Token: 0x17001524 RID: 5412
	// (get) Token: 0x0600DEA2 RID: 56994 RVA: 0x0041879D File Offset: 0x0041699D
	// (set) Token: 0x0600DEA3 RID: 56995 RVA: 0x004187A5 File Offset: 0x004169A5
	public override string event_id { get; set; } = "1836";

	// Token: 0x04007EFC RID: 32508
	public int i_area_id;

	// Token: 0x04007EFD RID: 32509
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<FurniturePlaceLogData> o_old_place;

	// Token: 0x04007EFE RID: 32510
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<FurniturePlaceLogData> o_new_place;

	// Token: 0x04007EFF RID: 32511
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<FurniturePlaceDiffLogData> o_diff;

	// Token: 0x04007F00 RID: 32512
	public int i_old_atmosphere;

	// Token: 0x04007F01 RID: 32513
	public int i_new_atmosphere;

	// Token: 0x04007F02 RID: 32514
	public int i_is_save;

	// Token: 0x04007F03 RID: 32515
	public string s_trace_id = "";
}
