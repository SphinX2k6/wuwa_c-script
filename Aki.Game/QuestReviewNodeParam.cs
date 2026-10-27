using System;
using System.Runtime.CompilerServices;

// Token: 0x0200266E RID: 9838
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewNodeParam : IQuestReviewNodeParam
{
	// Token: 0x170019CA RID: 6602
	// (get) Token: 0x06014277 RID: 82551 RVA: 0x0051750E File Offset: 0x0051570E
	// (set) Token: 0x06014278 RID: 82552 RVA: 0x00517516 File Offset: 0x00515716
	[Nullable(2)]
	public QuestReviewNodeData Data { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170019CB RID: 6603
	// (get) Token: 0x06014279 RID: 82553 RVA: 0x0051751F File Offset: 0x0051571F
	// (set) Token: 0x0601427A RID: 82554 RVA: 0x00517527 File Offset: 0x00515727
	public bool IsLastSlotEmpty { get; set; }

	// Token: 0x170019CC RID: 6604
	// (get) Token: 0x0601427B RID: 82555 RVA: 0x00517530 File Offset: 0x00515730
	// (set) Token: 0x0601427C RID: 82556 RVA: 0x00517538 File Offset: 0x00515738
	public bool IsDestroy { get; set; }

	// Token: 0x170019CD RID: 6605
	// (get) Token: 0x0601427D RID: 82557 RVA: 0x00517541 File Offset: 0x00515741
	// (set) Token: 0x0601427E RID: 82558 RVA: 0x00517549 File Offset: 0x00515749
	public bool IsLastSlot { get; set; }

	// Token: 0x170019CE RID: 6606
	// (get) Token: 0x0601427F RID: 82559 RVA: 0x00517552 File Offset: 0x00515752
	// (set) Token: 0x06014280 RID: 82560 RVA: 0x0051755A File Offset: 0x0051575A
	public string LineColorHex { get; set; }

	// Token: 0x170019CF RID: 6607
	// (get) Token: 0x06014281 RID: 82561 RVA: 0x00517563 File Offset: 0x00515763
	// (set) Token: 0x06014282 RID: 82562 RVA: 0x0051756B File Offset: 0x0051576B
	public string StarIcon { get; set; }

	// Token: 0x170019D0 RID: 6608
	// (get) Token: 0x06014283 RID: 82563 RVA: 0x00517574 File Offset: 0x00515774
	// (set) Token: 0x06014284 RID: 82564 RVA: 0x0051757C File Offset: 0x0051577C
	public string RoundIcon { get; set; }

	// Token: 0x170019D1 RID: 6609
	// (get) Token: 0x06014285 RID: 82565 RVA: 0x00517585 File Offset: 0x00515785
	// (set) Token: 0x06014286 RID: 82566 RVA: 0x0051758D File Offset: 0x0051578D
	public int LineId { get; set; }

	// Token: 0x170019D2 RID: 6610
	// (get) Token: 0x06014287 RID: 82567 RVA: 0x00517596 File Offset: 0x00515796
	// (set) Token: 0x06014288 RID: 82568 RVA: 0x0051759E File Offset: 0x0051579E
	public bool ShouldHide { get; set; }

	// Token: 0x170019D3 RID: 6611
	// (get) Token: 0x06014289 RID: 82569 RVA: 0x005175A7 File Offset: 0x005157A7
	// (set) Token: 0x0601428A RID: 82570 RVA: 0x005175AF File Offset: 0x005157AF
	public int SlotIndex { get; set; }

	// Token: 0x0601428B RID: 82571 RVA: 0x005175B8 File Offset: 0x005157B8
	public QuestReviewNodeParam()
	{
		this.LineColorHex = string.Empty;
		this.StarIcon = string.Empty;
		this.RoundIcon = string.Empty;
	}
}
