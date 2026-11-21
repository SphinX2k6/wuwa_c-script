using System;
using System.Runtime.CompilerServices;

// Token: 0x02001B59 RID: 7001
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewNodeParam : IQuestReviewNodeParam
{
	// Token: 0x17001A02 RID: 6658
	// (get) Token: 0x06011759 RID: 71513 RVA: 0x00526266 File Offset: 0x00524466
	// (set) Token: 0x0601175A RID: 71514 RVA: 0x0052626E File Offset: 0x0052446E
	[Nullable(2)]
	public QuestReviewNodeData Data { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001A03 RID: 6659
	// (get) Token: 0x0601175B RID: 71515 RVA: 0x00526277 File Offset: 0x00524477
	// (set) Token: 0x0601175C RID: 71516 RVA: 0x0052627F File Offset: 0x0052447F
	public bool IsLastSlotEmpty { get; set; }

	// Token: 0x17001A04 RID: 6660
	// (get) Token: 0x0601175D RID: 71517 RVA: 0x00526288 File Offset: 0x00524488
	// (set) Token: 0x0601175E RID: 71518 RVA: 0x00526290 File Offset: 0x00524490
	public bool IsDestroy { get; set; }

	// Token: 0x17001A05 RID: 6661
	// (get) Token: 0x0601175F RID: 71519 RVA: 0x00526299 File Offset: 0x00524499
	// (set) Token: 0x06011760 RID: 71520 RVA: 0x005262A1 File Offset: 0x005244A1
	public bool IsLastSlot { get; set; }

	// Token: 0x17001A06 RID: 6662
	// (get) Token: 0x06011761 RID: 71521 RVA: 0x005262AA File Offset: 0x005244AA
	// (set) Token: 0x06011762 RID: 71522 RVA: 0x005262B2 File Offset: 0x005244B2
	public string LineColorHex { get; set; }

	// Token: 0x17001A07 RID: 6663
	// (get) Token: 0x06011763 RID: 71523 RVA: 0x005262BB File Offset: 0x005244BB
	// (set) Token: 0x06011764 RID: 71524 RVA: 0x005262C3 File Offset: 0x005244C3
	public string StarIcon { get; set; }

	// Token: 0x17001A08 RID: 6664
	// (get) Token: 0x06011765 RID: 71525 RVA: 0x005262CC File Offset: 0x005244CC
	// (set) Token: 0x06011766 RID: 71526 RVA: 0x005262D4 File Offset: 0x005244D4
	public string RoundIcon { get; set; }

	// Token: 0x17001A09 RID: 6665
	// (get) Token: 0x06011767 RID: 71527 RVA: 0x005262DD File Offset: 0x005244DD
	// (set) Token: 0x06011768 RID: 71528 RVA: 0x005262E5 File Offset: 0x005244E5
	public int LineId { get; set; }

	// Token: 0x17001A0A RID: 6666
	// (get) Token: 0x06011769 RID: 71529 RVA: 0x005262EE File Offset: 0x005244EE
	// (set) Token: 0x0601176A RID: 71530 RVA: 0x005262F6 File Offset: 0x005244F6
	public bool ShouldHide { get; set; }

	// Token: 0x17001A0B RID: 6667
	// (get) Token: 0x0601176B RID: 71531 RVA: 0x005262FF File Offset: 0x005244FF
	// (set) Token: 0x0601176C RID: 71532 RVA: 0x00526307 File Offset: 0x00524507
	public int SlotIndex { get; set; }

	// Token: 0x0601176D RID: 71533 RVA: 0x00526310 File Offset: 0x00524510
	public QuestReviewNodeParam()
	{
		this.LineColorHex = string.Empty;
		this.StarIcon = string.Empty;
		this.RoundIcon = string.Empty;
	}
}
