using System;
using System.Runtime.CompilerServices;

// Token: 0x02002858 RID: 10328
[NullableContext(1)]
public interface IRoleLangCustomInfo
{
	// Token: 0x17001C66 RID: 7270
	// (get) Token: 0x0601547E RID: 87166
	// (set) Token: 0x0601547F RID: 87167
	int RoleId { get; set; }

	// Token: 0x17001C67 RID: 7271
	// (get) Token: 0x06015480 RID: 87168
	// (set) Token: 0x06015481 RID: 87169
	int LangIndex { get; set; }

	// Token: 0x17001C68 RID: 7272
	// (get) Token: 0x06015482 RID: 87170
	// (set) Token: 0x06015483 RID: 87171
	string LangCode { get; set; }
}
