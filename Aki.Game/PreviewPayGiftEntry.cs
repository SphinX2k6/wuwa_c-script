using System;
using System.Runtime.CompilerServices;

// Token: 0x02002365 RID: 9061
[NullableContext(1)]
[Nullable(0)]
public class PreviewPayGiftEntry : IPreviewPayGiftEntry
{
	// Token: 0x1700179A RID: 6042
	// (get) Token: 0x0601210C RID: 73996 RVA: 0x0046F460 File Offset: 0x0046D660
	// (set) Token: 0x0601210D RID: 73997 RVA: 0x0046F468 File Offset: 0x0046D668
	public long EndStampSec { get; set; }

	// Token: 0x1700179B RID: 6043
	// (get) Token: 0x0601210E RID: 73998 RVA: 0x0046F471 File Offset: 0x0046D671
	// (set) Token: 0x0601210F RID: 73999 RVA: 0x0046F479 File Offset: 0x0046D679
	public string Title { get; set; }

	// Token: 0x1700179C RID: 6044
	// (get) Token: 0x06012110 RID: 74000 RVA: 0x0046F482 File Offset: 0x0046D682
	// (set) Token: 0x06012111 RID: 74001 RVA: 0x0046F48A File Offset: 0x0046D68A
	public string RewardListDesc { get; set; }
}
