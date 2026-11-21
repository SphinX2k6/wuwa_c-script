using System;
using System.Runtime.CompilerServices;

// Token: 0x02001B58 RID: 7000
[NullableContext(1)]
public interface IQuestReviewNodeParam
{
	// Token: 0x170019F8 RID: 6648
	// (get) Token: 0x06011745 RID: 71493
	// (set) Token: 0x06011746 RID: 71494
	[Nullable(2)]
	QuestReviewNodeData Data { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170019F9 RID: 6649
	// (get) Token: 0x06011747 RID: 71495
	// (set) Token: 0x06011748 RID: 71496
	bool IsLastSlotEmpty { get; set; }

	// Token: 0x170019FA RID: 6650
	// (get) Token: 0x06011749 RID: 71497
	// (set) Token: 0x0601174A RID: 71498
	bool IsDestroy { get; set; }

	// Token: 0x170019FB RID: 6651
	// (get) Token: 0x0601174B RID: 71499
	// (set) Token: 0x0601174C RID: 71500
	bool IsLastSlot { get; set; }

	// Token: 0x170019FC RID: 6652
	// (get) Token: 0x0601174D RID: 71501
	// (set) Token: 0x0601174E RID: 71502
	string LineColorHex { get; set; }

	// Token: 0x170019FD RID: 6653
	// (get) Token: 0x0601174F RID: 71503
	// (set) Token: 0x06011750 RID: 71504
	string StarIcon { get; set; }

	// Token: 0x170019FE RID: 6654
	// (get) Token: 0x06011751 RID: 71505
	// (set) Token: 0x06011752 RID: 71506
	string RoundIcon { get; set; }

	// Token: 0x170019FF RID: 6655
	// (get) Token: 0x06011753 RID: 71507
	// (set) Token: 0x06011754 RID: 71508
	int LineId { get; set; }

	// Token: 0x17001A00 RID: 6656
	// (get) Token: 0x06011755 RID: 71509
	// (set) Token: 0x06011756 RID: 71510
	bool ShouldHide { get; set; }

	// Token: 0x17001A01 RID: 6657
	// (get) Token: 0x06011757 RID: 71511
	// (set) Token: 0x06011758 RID: 71512
	int SlotIndex { get; set; }
}
