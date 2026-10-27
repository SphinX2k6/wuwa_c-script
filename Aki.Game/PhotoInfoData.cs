using System;
using System.Runtime.CompilerServices;

// Token: 0x020025D9 RID: 9689
[NullableContext(1)]
[Nullable(0)]
public class PhotoInfoData : IInfoData
{
	// Token: 0x1700193E RID: 6462
	// (get) Token: 0x06013AED RID: 80621 RVA: 0x004EDD3E File Offset: 0x004EBF3E
	// (set) Token: 0x06013AEE RID: 80622 RVA: 0x004EDD46 File Offset: 0x004EBF46
	public string Text { get; set; } = "";

	// Token: 0x1700193F RID: 6463
	// (get) Token: 0x06013AEF RID: 80623 RVA: 0x004EDD4F File Offset: 0x004EBF4F
	// (set) Token: 0x06013AF0 RID: 80624 RVA: 0x004EDD57 File Offset: 0x004EBF57
	public bool IsFinish { get; set; }

	// Token: 0x17001940 RID: 6464
	// (get) Token: 0x06013AF1 RID: 80625 RVA: 0x004EDD60 File Offset: 0x004EBF60
	// (set) Token: 0x06013AF2 RID: 80626 RVA: 0x004EDD68 File Offset: 0x004EBF68
	public bool IsOptionFinished { get; set; }
}
