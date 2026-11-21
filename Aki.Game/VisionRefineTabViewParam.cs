using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000BE8 RID: 3048
public class VisionRefineTabViewParam : IVisionRefineTabViewParam
{
	// Token: 0x17000E5E RID: 3678
	// (get) Token: 0x06007F66 RID: 32614 RVA: 0x00272110 File Offset: 0x00270310
	// (set) Token: 0x06007F67 RID: 32615 RVA: 0x00272118 File Offset: 0x00270318
	public ERefineViewState ViewState { get; set; }

	// Token: 0x17000E5F RID: 3679
	// (get) Token: 0x06007F68 RID: 32616 RVA: 0x00272121 File Offset: 0x00270321
	// (set) Token: 0x06007F69 RID: 32617 RVA: 0x00272129 File Offset: 0x00270329
	public EVisionRefineRefineType? RefineType { get; set; }

	// Token: 0x17000E60 RID: 3680
	// (get) Token: 0x06007F6A RID: 32618 RVA: 0x00272132 File Offset: 0x00270332
	// (set) Token: 0x06007F6B RID: 32619 RVA: 0x0027213A File Offset: 0x0027033A
	public int? UniqueId { get; set; }

	// Token: 0x17000E61 RID: 3681
	// (get) Token: 0x06007F6C RID: 32620 RVA: 0x00272143 File Offset: 0x00270343
	// (set) Token: 0x06007F6D RID: 32621 RVA: 0x0027214B File Offset: 0x0027034B
	public bool? ActiveCaptionItem { get; set; }

	// Token: 0x17000E62 RID: 3682
	// (get) Token: 0x06007F6E RID: 32622 RVA: 0x00272154 File Offset: 0x00270354
	// (set) Token: 0x06007F6F RID: 32623 RVA: 0x0027215C File Offset: 0x0027035C
	public bool? SlotInteractive { get; set; }

	// Token: 0x17000E63 RID: 3683
	// (get) Token: 0x06007F70 RID: 32624 RVA: 0x00272165 File Offset: 0x00270365
	// (set) Token: 0x06007F71 RID: 32625 RVA: 0x0027216D File Offset: 0x0027036D
	public bool? ResultShowTips { get; set; }

	// Token: 0x17000E64 RID: 3684
	// (get) Token: 0x06007F72 RID: 32626 RVA: 0x00272176 File Offset: 0x00270376
	// (set) Token: 0x06007F73 RID: 32627 RVA: 0x0027217E File Offset: 0x0027037E
	public bool? IsSingleMode { get; set; }

	// Token: 0x17000E65 RID: 3685
	// (get) Token: 0x06007F74 RID: 32628 RVA: 0x00272187 File Offset: 0x00270387
	// (set) Token: 0x06007F75 RID: 32629 RVA: 0x0027218F File Offset: 0x0027038F
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int[]> CurrencyChangeCallback { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17000E66 RID: 3686
	// (get) Token: 0x06007F76 RID: 32630 RVA: 0x00272198 File Offset: 0x00270398
	// (set) Token: 0x06007F77 RID: 32631 RVA: 0x002721A0 File Offset: 0x002703A0
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<AttrRecommendInfo> RecommendRefineSubList { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }
}
