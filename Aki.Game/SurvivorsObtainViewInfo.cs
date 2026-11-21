using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002058 RID: 8280
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsObtainViewInfo : ISurvivorsObtainViewInfo
{
	// Token: 0x17001EB2 RID: 7858
	// (get) Token: 0x06014788 RID: 83848 RVA: 0x005F8C53 File Offset: 0x005F6E53
	// (set) Token: 0x06014789 RID: 83849 RVA: 0x005F8C5B File Offset: 0x005F6E5B
	public string CaptionId { get; set; } = "";

	// Token: 0x17001EB3 RID: 7859
	// (get) Token: 0x0601478A RID: 83850 RVA: 0x005F8C64 File Offset: 0x005F6E64
	// (set) Token: 0x0601478B RID: 83851 RVA: 0x005F8C6C File Offset: 0x005F6E6C
	public string TitleId { get; set; } = "";

	// Token: 0x17001EB4 RID: 7860
	// (get) Token: 0x0601478C RID: 83852 RVA: 0x005F8C75 File Offset: 0x005F6E75
	// (set) Token: 0x0601478D RID: 83853 RVA: 0x005F8C7D File Offset: 0x005F6E7D
	public string ButtonId { get; set; } = "";

	// Token: 0x17001EB5 RID: 7861
	// (get) Token: 0x0601478E RID: 83854 RVA: 0x005F8C86 File Offset: 0x005F6E86
	// (set) Token: 0x0601478F RID: 83855 RVA: 0x005F8C8E File Offset: 0x005F6E8E
	public ISurvivorsChooseData ChooseData { get; set; }

	// Token: 0x17001EB6 RID: 7862
	// (get) Token: 0x06014790 RID: 83856 RVA: 0x005F8C97 File Offset: 0x005F6E97
	// (set) Token: 0x06014791 RID: 83857 RVA: 0x005F8C9F File Offset: 0x005F6E9F
	public IList<GoodsDetail> GoodsList { get; set; }
}
