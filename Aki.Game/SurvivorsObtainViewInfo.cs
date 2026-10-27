using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002ADC RID: 10972
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsObtainViewInfo : ISurvivorsObtainViewInfo
{
	// Token: 0x17001E5A RID: 7770
	// (get) Token: 0x06016D57 RID: 93527 RVA: 0x005CC103 File Offset: 0x005CA303
	// (set) Token: 0x06016D58 RID: 93528 RVA: 0x005CC10B File Offset: 0x005CA30B
	public string CaptionId { get; set; } = "";

	// Token: 0x17001E5B RID: 7771
	// (get) Token: 0x06016D59 RID: 93529 RVA: 0x005CC114 File Offset: 0x005CA314
	// (set) Token: 0x06016D5A RID: 93530 RVA: 0x005CC11C File Offset: 0x005CA31C
	public string TitleId { get; set; } = "";

	// Token: 0x17001E5C RID: 7772
	// (get) Token: 0x06016D5B RID: 93531 RVA: 0x005CC125 File Offset: 0x005CA325
	// (set) Token: 0x06016D5C RID: 93532 RVA: 0x005CC12D File Offset: 0x005CA32D
	public string ButtonId { get; set; } = "";

	// Token: 0x17001E5D RID: 7773
	// (get) Token: 0x06016D5D RID: 93533 RVA: 0x005CC136 File Offset: 0x005CA336
	// (set) Token: 0x06016D5E RID: 93534 RVA: 0x005CC13E File Offset: 0x005CA33E
	public ISurvivorsChooseData ChooseData { get; set; }

	// Token: 0x17001E5E RID: 7774
	// (get) Token: 0x06016D5F RID: 93535 RVA: 0x005CC147 File Offset: 0x005CA347
	// (set) Token: 0x06016D60 RID: 93536 RVA: 0x005CC14F File Offset: 0x005CA34F
	public IList<GoodsDetail> GoodsList { get; set; }
}
