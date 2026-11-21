using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001661 RID: 5729
[NullableContext(1)]
[Nullable(0)]
public class SolarSchoolImportantAttrSelectLogData : SolarSchoolLogData
{
	// Token: 0x17001554 RID: 5460
	// (get) Token: 0x0600DF38 RID: 57144 RVA: 0x00418FBE File Offset: 0x004171BE
	// (set) Token: 0x0600DF39 RID: 57145 RVA: 0x00418FC6 File Offset: 0x004171C6
	public override string event_id { get; set; } = "2103";

	// Token: 0x04008017 RID: 32791
	public int i_activity_type;

	// Token: 0x04008018 RID: 32792
	public List<int> o_option_ids = new List<int>();
}
