using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001B4F RID: 6991
[NullableContext(1)]
[Nullable(0)]
public class QuestChapterData : IQuestChapterData
{
	// Token: 0x170019D8 RID: 6616
	// (get) Token: 0x060116AB RID: 71339 RVA: 0x00521D5D File Offset: 0x0051FF5D
	// (set) Token: 0x060116AC RID: 71340 RVA: 0x00521D65 File Offset: 0x0051FF65
	public int ChapterId { get; set; }

	// Token: 0x170019D9 RID: 6617
	// (get) Token: 0x060116AD RID: 71341 RVA: 0x00521D6E File Offset: 0x0051FF6E
	// (set) Token: 0x060116AE RID: 71342 RVA: 0x00521D76 File Offset: 0x0051FF76
	public int QuestType { get; set; }

	// Token: 0x170019DA RID: 6618
	// (get) Token: 0x060116AF RID: 71343 RVA: 0x00521D7F File Offset: 0x0051FF7F
	// (set) Token: 0x060116B0 RID: 71344 RVA: 0x00521D87 File Offset: 0x0051FF87
	public List<int> QuestList { get; set; } = new List<int>();
}
