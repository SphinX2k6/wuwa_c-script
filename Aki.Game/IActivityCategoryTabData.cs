using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200056F RID: 1391
[NullableContext(1)]
public interface IActivityCategoryTabData
{
	// Token: 0x17000988 RID: 2440
	// (get) Token: 0x0600430B RID: 17163
	// (set) Token: 0x0600430C RID: 17164
	bool IsLineType { get; set; }

	// Token: 0x17000989 RID: 2441
	// (get) Token: 0x0600430D RID: 17165
	// (set) Token: 0x0600430E RID: 17166
	int? Id { get; set; }

	// Token: 0x1700098A RID: 2442
	// (get) Token: 0x0600430F RID: 17167
	// (set) Token: 0x06004310 RID: 17168
	string TextId { get; set; }

	// Token: 0x1700098B RID: 2443
	// (get) Token: 0x06004311 RID: 17169
	// (set) Token: 0x06004312 RID: 17170
	string IconPath { get; set; }

	// Token: 0x1700098C RID: 2444
	// (get) Token: 0x06004313 RID: 17171
	// (set) Token: 0x06004314 RID: 17172
	List<ActivityBaseData> Activities { get; set; }
}
