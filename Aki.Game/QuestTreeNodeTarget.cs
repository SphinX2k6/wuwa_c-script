using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002692 RID: 9874
[NullableContext(2)]
[Nullable(0)]
public class QuestTreeNodeTarget : IQuestTreeNodeTarget
{
	// Token: 0x17001A21 RID: 6689
	// (get) Token: 0x060143E2 RID: 82914 RVA: 0x0051E277 File Offset: 0x0051C477
	// (set) Token: 0x060143E3 RID: 82915 RVA: 0x0051E27F File Offset: 0x0051C47F
	public EQuestTreeNodeTargetType Type { get; set; }

	// Token: 0x17001A22 RID: 6690
	// (get) Token: 0x060143E4 RID: 82916 RVA: 0x0051E288 File Offset: 0x0051C488
	// (set) Token: 0x060143E5 RID: 82917 RVA: 0x0051E290 File Offset: 0x0051C490
	public string Text { get; set; }

	// Token: 0x17001A23 RID: 6691
	// (get) Token: 0x060143E6 RID: 82918 RVA: 0x0051E299 File Offset: 0x0051C499
	// (set) Token: 0x060143E7 RID: 82919 RVA: 0x0051E2A1 File Offset: 0x0051C4A1
	public string TextKey { get; set; }

	// Token: 0x17001A24 RID: 6692
	// (get) Token: 0x060143E8 RID: 82920 RVA: 0x0051E2AA File Offset: 0x0051C4AA
	// (set) Token: 0x060143E9 RID: 82921 RVA: 0x0051E2B2 File Offset: 0x0051C4B2
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<object> TextParam { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17001A25 RID: 6693
	// (get) Token: 0x060143EA RID: 82922 RVA: 0x0051E2BB File Offset: 0x0051C4BB
	// (set) Token: 0x060143EB RID: 82923 RVA: 0x0051E2C3 File Offset: 0x0051C4C3
	public bool? IsFinished { get; set; }

	// Token: 0x17001A26 RID: 6694
	// (get) Token: 0x060143EC RID: 82924 RVA: 0x0051E2CC File Offset: 0x0051C4CC
	// (set) Token: 0x060143ED RID: 82925 RVA: 0x0051E2D4 File Offset: 0x0051C4D4
	public int? HelpId { get; set; }

	// Token: 0x17001A27 RID: 6695
	// (get) Token: 0x060143EE RID: 82926 RVA: 0x0051E2DD File Offset: 0x0051C4DD
	// (set) Token: 0x060143EF RID: 82927 RVA: 0x0051E2E5 File Offset: 0x0051C4E5
	public int? GotoId { get; set; }

	// Token: 0x17001A28 RID: 6696
	// (get) Token: 0x060143F0 RID: 82928 RVA: 0x0051E2EE File Offset: 0x0051C4EE
	// (set) Token: 0x060143F1 RID: 82929 RVA: 0x0051E2F6 File Offset: 0x0051C4F6
	public Action OnGoto { get; set; }
}
