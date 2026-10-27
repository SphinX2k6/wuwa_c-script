using System;
using System.Runtime.CompilerServices;

// Token: 0x02002102 RID: 8450
[NullableContext(1)]
[Nullable(0)]
public class PreDownloadPauseRecord : PlayerCommonLogData
{
	// Token: 0x170014A8 RID: 5288
	// (get) Token: 0x06010942 RID: 67906 RVA: 0x0040B24F File Offset: 0x0040944F
	// (set) Token: 0x06010943 RID: 67907 RVA: 0x0040B257 File Offset: 0x00409457
	public override string event_id { get; set; } = "1056";

	// Token: 0x06010944 RID: 67908 RVA: 0x0040B260 File Offset: 0x00409460
	public PreDownloadPauseRecord(int Id)
	{
		this.i_pause_reason = Id;
	}

	// Token: 0x04007C6D RID: 31853
	public int i_pause_reason;
}
