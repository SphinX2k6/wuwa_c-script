using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DD3 RID: 7635
[NullableContext(1)]
public interface IRoleLangCustomInfo
{
	// Token: 0x17001CBE RID: 7358
	// (get) Token: 0x06012E7C RID: 77436
	// (set) Token: 0x06012E7D RID: 77437
	int RoleId { get; set; }

	// Token: 0x17001CBF RID: 7359
	// (get) Token: 0x06012E7E RID: 77438
	// (set) Token: 0x06012E7F RID: 77439
	int LangIndex { get; set; }

	// Token: 0x17001CC0 RID: 7360
	// (get) Token: 0x06012E80 RID: 77440
	// (set) Token: 0x06012E81 RID: 77441
	string LangCode { get; set; }
}
