using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002664 RID: 9828
[NullableContext(1)]
[Nullable(0)]
public class QuestChapterData : IQuestChapterData
{
	// Token: 0x170019A0 RID: 6560
	// (get) Token: 0x060141C9 RID: 82377 RVA: 0x005130A5 File Offset: 0x005112A5
	// (set) Token: 0x060141CA RID: 82378 RVA: 0x005130AD File Offset: 0x005112AD
	public int ChapterId { get; set; }

	// Token: 0x170019A1 RID: 6561
	// (get) Token: 0x060141CB RID: 82379 RVA: 0x005130B6 File Offset: 0x005112B6
	// (set) Token: 0x060141CC RID: 82380 RVA: 0x005130BE File Offset: 0x005112BE
	public int QuestType { get; set; }

	// Token: 0x170019A2 RID: 6562
	// (get) Token: 0x060141CD RID: 82381 RVA: 0x005130C7 File Offset: 0x005112C7
	// (set) Token: 0x060141CE RID: 82382 RVA: 0x005130CF File Offset: 0x005112CF
	public List<int> QuestList { get; set; } = new List<int>();
}
