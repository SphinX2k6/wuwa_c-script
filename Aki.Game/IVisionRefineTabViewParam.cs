using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200172F RID: 5935
public interface IVisionRefineTabViewParam
{
	// Token: 0x17000E34 RID: 3636
	// (get) Token: 0x0600AB72 RID: 43890
	// (set) Token: 0x0600AB73 RID: 43891
	ERefineViewState ViewState { get; set; }

	// Token: 0x17000E35 RID: 3637
	// (get) Token: 0x0600AB74 RID: 43892
	// (set) Token: 0x0600AB75 RID: 43893
	EVisionRefineRefineType? RefineType { get; set; }

	// Token: 0x17000E36 RID: 3638
	// (get) Token: 0x0600AB76 RID: 43894
	// (set) Token: 0x0600AB77 RID: 43895
	int? UniqueId { get; set; }

	// Token: 0x17000E37 RID: 3639
	// (get) Token: 0x0600AB78 RID: 43896
	// (set) Token: 0x0600AB79 RID: 43897
	bool? ActiveCaptionItem { get; set; }

	// Token: 0x17000E38 RID: 3640
	// (get) Token: 0x0600AB7A RID: 43898
	// (set) Token: 0x0600AB7B RID: 43899
	bool? SlotInteractive { get; set; }

	// Token: 0x17000E39 RID: 3641
	// (get) Token: 0x0600AB7C RID: 43900
	// (set) Token: 0x0600AB7D RID: 43901
	bool? ResultShowTips { get; set; }

	// Token: 0x17000E3A RID: 3642
	// (get) Token: 0x0600AB7E RID: 43902
	// (set) Token: 0x0600AB7F RID: 43903
	bool? IsSingleMode { get; set; }

	// Token: 0x17000E3B RID: 3643
	// (get) Token: 0x0600AB80 RID: 43904
	// (set) Token: 0x0600AB81 RID: 43905
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

	// Token: 0x17000E3C RID: 3644
	// (get) Token: 0x0600AB82 RID: 43906
	// (set) Token: 0x0600AB83 RID: 43907
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
