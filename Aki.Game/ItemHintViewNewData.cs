using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020014D6 RID: 5334
[NullableContext(2)]
[Nullable(0)]
public class ItemHintViewNewData : UiViewData
{
	// Token: 0x040077BE RID: 30654
	public string TitleTextId;

	// Token: 0x040077BF RID: 30655
	public Func<bool> CheckNext;

	// Token: 0x040077C0 RID: 30656
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<ItemRewardInfo> ShiftItem;

	// Token: 0x040077C1 RID: 30657
	public int? MaxShowCount;

	// Token: 0x040077C2 RID: 30658
	public int? AddItemTime;

	// Token: 0x040077C3 RID: 30659
	public int? ItemSliderTime;

	// Token: 0x040077C4 RID: 30660
	public int? ItemShowTime;

	// Token: 0x040077C5 RID: 30661
	public string SlotResourceId;

	// Token: 0x040077C6 RID: 30662
	public Func<bool> CheckPriorNext;

	// Token: 0x040077C7 RID: 30663
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<ItemRewardInfo> ShiftPriorItem;

	// Token: 0x040077C8 RID: 30664
	public int? PriorMaxShowCount;

	// Token: 0x040077C9 RID: 30665
	public int? AddPriorItemTime;

	// Token: 0x040077CA RID: 30666
	public int? PriorItemSliderTime;

	// Token: 0x040077CB RID: 30667
	public int? PriorItemShowTime;

	// Token: 0x040077CC RID: 30668
	public string PriorSlotResourceId;
}
