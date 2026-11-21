using System;
using System.Runtime.CompilerServices;

// Token: 0x020015DB RID: 5595
[NullableContext(1)]
[Nullable(0)]
public class PreDownloadDownloadModeSuccessRecord : PlayerCommonLogData
{
	// Token: 0x170014D7 RID: 5335
	// (get) Token: 0x0600DDB8 RID: 56760 RVA: 0x004179AE File Offset: 0x00415BAE
	// (set) Token: 0x0600DDB9 RID: 56761 RVA: 0x004179B6 File Offset: 0x00415BB6
	public override string event_id { get; set; } = "1057";

	// Token: 0x0600DDBA RID: 56762 RVA: 0x004179BF File Offset: 0x00415BBF
	public PreDownloadDownloadModeSuccessRecord(int Id)
	{
		this.i_download_mode = Id;
	}

	// Token: 0x04007D71 RID: 32113
	public int i_download_mode;
}
