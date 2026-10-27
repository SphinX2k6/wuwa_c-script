using System;
using System.Runtime.CompilerServices;

// Token: 0x0200266D RID: 9837
[NullableContext(1)]
public interface IQuestReviewNodeParam
{
	// Token: 0x170019C0 RID: 6592
	// (get) Token: 0x06014263 RID: 82531
	// (set) Token: 0x06014264 RID: 82532
	[Nullable(2)]
	QuestReviewNodeData Data { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170019C1 RID: 6593
	// (get) Token: 0x06014265 RID: 82533
	// (set) Token: 0x06014266 RID: 82534
	bool IsLastSlotEmpty { get; set; }

	// Token: 0x170019C2 RID: 6594
	// (get) Token: 0x06014267 RID: 82535
	// (set) Token: 0x06014268 RID: 82536
	bool IsDestroy { get; set; }

	// Token: 0x170019C3 RID: 6595
	// (get) Token: 0x06014269 RID: 82537
	// (set) Token: 0x0601426A RID: 82538
	bool IsLastSlot { get; set; }

	// Token: 0x170019C4 RID: 6596
	// (get) Token: 0x0601426B RID: 82539
	// (set) Token: 0x0601426C RID: 82540
	string LineColorHex { get; set; }

	// Token: 0x170019C5 RID: 6597
	// (get) Token: 0x0601426D RID: 82541
	// (set) Token: 0x0601426E RID: 82542
	string StarIcon { get; set; }

	// Token: 0x170019C6 RID: 6598
	// (get) Token: 0x0601426F RID: 82543
	// (set) Token: 0x06014270 RID: 82544
	string RoundIcon { get; set; }

	// Token: 0x170019C7 RID: 6599
	// (get) Token: 0x06014271 RID: 82545
	// (set) Token: 0x06014272 RID: 82546
	int LineId { get; set; }

	// Token: 0x170019C8 RID: 6600
	// (get) Token: 0x06014273 RID: 82547
	// (set) Token: 0x06014274 RID: 82548
	bool ShouldHide { get; set; }

	// Token: 0x170019C9 RID: 6601
	// (get) Token: 0x06014275 RID: 82549
	// (set) Token: 0x06014276 RID: 82550
	int SlotIndex { get; set; }
}
