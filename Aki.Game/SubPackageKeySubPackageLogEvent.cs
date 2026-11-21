using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001611 RID: 5649
[NullableContext(1)]
[Nullable(0)]
public class SubPackageKeySubPackageLogEvent : CommonLogData
{
	// Token: 0x1700150D RID: 5389
	// (get) Token: 0x0600DE5A RID: 56922 RVA: 0x0041834D File Offset: 0x0041654D
	// (set) Token: 0x0600DE5B RID: 56923 RVA: 0x00418355 File Offset: 0x00416555
	public override string event_id { get; set; } = "1705";

	// Token: 0x04007E67 RID: 32359
	public int i_download_time;

	// Token: 0x04007E68 RID: 32360
	public int i_download_status;

	// Token: 0x04007E69 RID: 32361
	public List<int> o_phantoms = new List<int>();
}
