using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020010BC RID: 4284
[NullableContext(1)]
[Nullable(0)]
public class ActivityCategoryTabData : IActivityCategoryTabData
{
	// Token: 0x1700096D RID: 2413
	// (get) Token: 0x06006F7F RID: 28543 RVA: 0x0016B8A2 File Offset: 0x00169AA2
	// (set) Token: 0x06006F80 RID: 28544 RVA: 0x0016B8AA File Offset: 0x00169AAA
	public bool IsLineType { get; set; }

	// Token: 0x1700096E RID: 2414
	// (get) Token: 0x06006F81 RID: 28545 RVA: 0x0016B8B3 File Offset: 0x00169AB3
	// (set) Token: 0x06006F82 RID: 28546 RVA: 0x0016B8BB File Offset: 0x00169ABB
	public int? Id { get; set; }

	// Token: 0x1700096F RID: 2415
	// (get) Token: 0x06006F83 RID: 28547 RVA: 0x0016B8C4 File Offset: 0x00169AC4
	// (set) Token: 0x06006F84 RID: 28548 RVA: 0x0016B8CC File Offset: 0x00169ACC
	public string TextId { get; set; }

	// Token: 0x17000970 RID: 2416
	// (get) Token: 0x06006F85 RID: 28549 RVA: 0x0016B8D5 File Offset: 0x00169AD5
	// (set) Token: 0x06006F86 RID: 28550 RVA: 0x0016B8DD File Offset: 0x00169ADD
	public string IconPath { get; set; }

	// Token: 0x17000971 RID: 2417
	// (get) Token: 0x06006F87 RID: 28551 RVA: 0x0016B8E6 File Offset: 0x00169AE6
	// (set) Token: 0x06006F88 RID: 28552 RVA: 0x0016B8EE File Offset: 0x00169AEE
	public List<ActivityBaseData> Activities { get; set; }
}
