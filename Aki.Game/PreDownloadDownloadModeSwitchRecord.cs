using System;
using System.Runtime.CompilerServices;

// Token: 0x020015D9 RID: 5593
[NullableContext(1)]
[Nullable(0)]
public class PreDownloadDownloadModeSwitchRecord : PlayerCommonLogData
{
	// Token: 0x170014D5 RID: 5333
	// (get) Token: 0x0600DDB2 RID: 56754 RVA: 0x00417958 File Offset: 0x00415B58
	// (set) Token: 0x0600DDB3 RID: 56755 RVA: 0x00417960 File Offset: 0x00415B60
	public override string event_id { get; set; } = "1055";

	// Token: 0x0600DDB4 RID: 56756 RVA: 0x00417969 File Offset: 0x00415B69
	public PreDownloadDownloadModeSwitchRecord(int Id)
	{
		this.i_download_mode = Id;
	}

	// Token: 0x04007D6D RID: 32109
	public int i_download_mode;
}
