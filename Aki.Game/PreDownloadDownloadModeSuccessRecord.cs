using System;
using System.Runtime.CompilerServices;

// Token: 0x02002103 RID: 8451
[NullableContext(1)]
[Nullable(0)]
public class PreDownloadDownloadModeSuccessRecord : PlayerCommonLogData
{
	// Token: 0x170014A9 RID: 5289
	// (get) Token: 0x06010945 RID: 67909 RVA: 0x0040B27A File Offset: 0x0040947A
	// (set) Token: 0x06010946 RID: 67910 RVA: 0x0040B282 File Offset: 0x00409482
	public override string event_id { get; set; } = "1057";

	// Token: 0x06010947 RID: 67911 RVA: 0x0040B28B File Offset: 0x0040948B
	public PreDownloadDownloadModeSuccessRecord(int Id)
	{
		this.i_download_mode = Id;
	}

	// Token: 0x04007C6F RID: 31855
	public int i_download_mode;
}
