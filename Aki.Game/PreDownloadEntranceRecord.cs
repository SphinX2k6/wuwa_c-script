using System;
using System.Runtime.CompilerServices;

// Token: 0x02002100 RID: 8448
[NullableContext(1)]
[Nullable(0)]
public class PreDownloadEntranceRecord : PlayerCommonLogData
{
	// Token: 0x170014A6 RID: 5286
	// (get) Token: 0x0601093C RID: 67900 RVA: 0x0040B1F9 File Offset: 0x004093F9
	// (set) Token: 0x0601093D RID: 67901 RVA: 0x0040B201 File Offset: 0x00409401
	public override string event_id { get; set; } = "1054";

	// Token: 0x0601093E RID: 67902 RVA: 0x0040B20A File Offset: 0x0040940A
	public PreDownloadEntranceRecord(int entranceId)
	{
		this.i_entrance_id = entranceId;
	}

	// Token: 0x04007C69 RID: 31849
	public int i_entrance_id;
}
