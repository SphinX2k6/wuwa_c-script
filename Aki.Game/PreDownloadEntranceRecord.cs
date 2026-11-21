using System;
using System.Runtime.CompilerServices;

// Token: 0x020015D8 RID: 5592
[NullableContext(1)]
[Nullable(0)]
public class PreDownloadEntranceRecord : PlayerCommonLogData
{
	// Token: 0x170014D4 RID: 5332
	// (get) Token: 0x0600DDAF RID: 56751 RVA: 0x0041792D File Offset: 0x00415B2D
	// (set) Token: 0x0600DDB0 RID: 56752 RVA: 0x00417935 File Offset: 0x00415B35
	public override string event_id { get; set; } = "1054";

	// Token: 0x0600DDB1 RID: 56753 RVA: 0x0041793E File Offset: 0x00415B3E
	public PreDownloadEntranceRecord(int entranceId)
	{
		this.i_entrance_id = entranceId;
	}

	// Token: 0x04007D6B RID: 32107
	public int i_entrance_id;
}
