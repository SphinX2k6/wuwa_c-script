using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002003 RID: 8195
[NullableContext(2)]
[Nullable(0)]
public class ItemHintViewNewData : UiViewData
{
	// Token: 0x040076D5 RID: 30421
	public string TitleTextId;

	// Token: 0x040076D6 RID: 30422
	public Func<bool> CheckNext;

	// Token: 0x040076D7 RID: 30423
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<ItemRewardInfo> ShiftItem;

	// Token: 0x040076D8 RID: 30424
	public int? MaxShowCount;

	// Token: 0x040076D9 RID: 30425
	public int? AddItemTime;

	// Token: 0x040076DA RID: 30426
	public int? ItemSliderTime;

	// Token: 0x040076DB RID: 30427
	public int? ItemShowTime;

	// Token: 0x040076DC RID: 30428
	public string SlotResourceId;

	// Token: 0x040076DD RID: 30429
	public Func<bool> CheckPriorNext;

	// Token: 0x040076DE RID: 30430
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<ItemRewardInfo> ShiftPriorItem;

	// Token: 0x040076DF RID: 30431
	public int? PriorMaxShowCount;

	// Token: 0x040076E0 RID: 30432
	public int? AddPriorItemTime;

	// Token: 0x040076E1 RID: 30433
	public int? PriorItemSliderTime;

	// Token: 0x040076E2 RID: 30434
	public int? PriorItemShowTime;

	// Token: 0x040076E3 RID: 30435
	public string PriorSlotResourceId;
}
