using System;
using System.Runtime.CompilerServices;

// Token: 0x020015DC RID: 5596
[NullableContext(1)]
[Nullable(0)]
public class PreDownloadDownloadNoSpaceBeforeStartRecord : PlayerCommonLogData
{
	// Token: 0x170014D8 RID: 5336
	// (get) Token: 0x0600DDBB RID: 56763 RVA: 0x004179D9 File Offset: 0x00415BD9
	// (set) Token: 0x0600DDBC RID: 56764 RVA: 0x004179E1 File Offset: 0x00415BE1
	public override string event_id { get; set; } = "1708";

	// Token: 0x0600DDBD RID: 56765 RVA: 0x004179EA File Offset: 0x00415BEA
	public PreDownloadDownloadNoSpaceBeforeStartRecord(long space)
	{
		this.i_required_space = (int)space;
	}

	// Token: 0x04007D73 RID: 32115
	public int i_required_space;
}
