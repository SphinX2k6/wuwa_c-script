using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000BE7 RID: 3047
public interface IVisionRefineTabViewParam
{
	// Token: 0x17000E55 RID: 3669
	// (get) Token: 0x06007F54 RID: 32596
	// (set) Token: 0x06007F55 RID: 32597
	ERefineViewState ViewState { get; set; }

	// Token: 0x17000E56 RID: 3670
	// (get) Token: 0x06007F56 RID: 32598
	// (set) Token: 0x06007F57 RID: 32599
	EVisionRefineRefineType? RefineType { get; set; }

	// Token: 0x17000E57 RID: 3671
	// (get) Token: 0x06007F58 RID: 32600
	// (set) Token: 0x06007F59 RID: 32601
	int? UniqueId { get; set; }

	// Token: 0x17000E58 RID: 3672
	// (get) Token: 0x06007F5A RID: 32602
	// (set) Token: 0x06007F5B RID: 32603
	bool? ActiveCaptionItem { get; set; }

	// Token: 0x17000E59 RID: 3673
	// (get) Token: 0x06007F5C RID: 32604
	// (set) Token: 0x06007F5D RID: 32605
	bool? SlotInteractive { get; set; }

	// Token: 0x17000E5A RID: 3674
	// (get) Token: 0x06007F5E RID: 32606
	// (set) Token: 0x06007F5F RID: 32607
	bool? ResultShowTips { get; set; }

	// Token: 0x17000E5B RID: 3675
	// (get) Token: 0x06007F60 RID: 32608
	// (set) Token: 0x06007F61 RID: 32609
	bool? IsSingleMode { get; set; }

	// Token: 0x17000E5C RID: 3676
	// (get) Token: 0x06007F62 RID: 32610
	// (set) Token: 0x06007F63 RID: 32611
	[Nullable(new byte[]
	{
		2,
		1
	})]
	Action<int[]> CurrencyChangeCallback { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17000E5D RID: 3677
	// (get) Token: 0x06007F64 RID: 32612
	// (set) Token: 0x06007F65 RID: 32613
	[Nullable(new byte[]
	{
		2,
		1
	})]
	List<AttrRecommendInfo> RecommendRefineSubList { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }
}
