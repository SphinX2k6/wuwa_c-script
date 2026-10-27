using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002139 RID: 8505
[NullableContext(1)]
[Nullable(0)]
public class SubPackageKeySubPackageLogEvent : CommonLogData
{
	// Token: 0x170014DF RID: 5343
	// (get) Token: 0x060109E7 RID: 68071 RVA: 0x0040BC05 File Offset: 0x00409E05
	// (set) Token: 0x060109E8 RID: 68072 RVA: 0x0040BC0D File Offset: 0x00409E0D
	public override string event_id { get; set; } = "1705";

	// Token: 0x04007D57 RID: 32087
	public int i_download_time;

	// Token: 0x04007D58 RID: 32088
	public int i_download_status;

	// Token: 0x04007D59 RID: 32089
	public List<int> o_phantoms = new List<int>();
}
