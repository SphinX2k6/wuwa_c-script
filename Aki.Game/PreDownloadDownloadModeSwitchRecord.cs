using System;
using System.Runtime.CompilerServices;

// Token: 0x02002101 RID: 8449
[NullableContext(1)]
[Nullable(0)]
public class PreDownloadDownloadModeSwitchRecord : PlayerCommonLogData
{
	// Token: 0x170014A7 RID: 5287
	// (get) Token: 0x0601093F RID: 67903 RVA: 0x0040B224 File Offset: 0x00409424
	// (set) Token: 0x06010940 RID: 67904 RVA: 0x0040B22C File Offset: 0x0040942C
	public override string event_id { get; set; } = "1055";

	// Token: 0x06010941 RID: 67905 RVA: 0x0040B235 File Offset: 0x00409435
	public PreDownloadDownloadModeSwitchRecord(int Id)
	{
		this.i_download_mode = Id;
	}

	// Token: 0x04007C6B RID: 31851
	public int i_download_mode;
}
