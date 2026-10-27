using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020010BB RID: 4283
[NullableContext(1)]
public interface IActivityCategoryTabData
{
	// Token: 0x17000968 RID: 2408
	// (get) Token: 0x06006F75 RID: 28533
	// (set) Token: 0x06006F76 RID: 28534
	bool IsLineType { get; set; }

	// Token: 0x17000969 RID: 2409
	// (get) Token: 0x06006F77 RID: 28535
	// (set) Token: 0x06006F78 RID: 28536
	int? Id { get; set; }

	// Token: 0x1700096A RID: 2410
	// (get) Token: 0x06006F79 RID: 28537
	// (set) Token: 0x06006F7A RID: 28538
	string TextId { get; set; }

	// Token: 0x1700096B RID: 2411
	// (get) Token: 0x06006F7B RID: 28539
	// (set) Token: 0x06006F7C RID: 28540
	string IconPath { get; set; }

	// Token: 0x1700096C RID: 2412
	// (get) Token: 0x06006F7D RID: 28541
	// (set) Token: 0x06006F7E RID: 28542
	List<ActivityBaseData> Activities { get; set; }
}
