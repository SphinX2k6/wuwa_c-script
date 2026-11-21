using System;
using System.Runtime.CompilerServices;

// Token: 0x020015DA RID: 5594
[NullableContext(1)]
[Nullable(0)]
public class PreDownloadPauseRecord : PlayerCommonLogData
{
	// Token: 0x170014D6 RID: 5334
	// (get) Token: 0x0600DDB5 RID: 56757 RVA: 0x00417983 File Offset: 0x00415B83
	// (set) Token: 0x0600DDB6 RID: 56758 RVA: 0x0041798B File Offset: 0x00415B8B
	public override string event_id { get; set; } = "1056";

	// Token: 0x0600DDB7 RID: 56759 RVA: 0x00417994 File Offset: 0x00415B94
	public PreDownloadPauseRecord(int Id)
	{
		this.i_pause_reason = Id;
	}

	// Token: 0x04007D6F RID: 32111
	public int i_pause_reason;
}
