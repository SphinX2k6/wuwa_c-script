using System;
using System.Runtime.CompilerServices;

// Token: 0x02002104 RID: 8452
[NullableContext(1)]
[Nullable(0)]
public class PreDownloadDownloadNoSpaceBeforeStartRecord : PlayerCommonLogData
{
	// Token: 0x170014AA RID: 5290
	// (get) Token: 0x06010948 RID: 67912 RVA: 0x0040B2A5 File Offset: 0x004094A5
	// (set) Token: 0x06010949 RID: 67913 RVA: 0x0040B2AD File Offset: 0x004094AD
	public override string event_id { get; set; } = "1708";

	// Token: 0x0601094A RID: 67914 RVA: 0x0040B2B6 File Offset: 0x004094B6
	public PreDownloadDownloadNoSpaceBeforeStartRecord(long space)
	{
		this.i_required_space = (int)space;
	}

	// Token: 0x04007C71 RID: 31857
	public int i_required_space;
}
