using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001730 RID: 5936
public class VisionRefineTabViewParam : IVisionRefineTabViewParam
{
	// Token: 0x17000E3D RID: 3645
	// (get) Token: 0x0600AB84 RID: 43908 RVA: 0x00267D38 File Offset: 0x00265F38
	// (set) Token: 0x0600AB85 RID: 43909 RVA: 0x00267D40 File Offset: 0x00265F40
	public ERefineViewState ViewState { get; set; }

	// Token: 0x17000E3E RID: 3646
	// (get) Token: 0x0600AB86 RID: 43910 RVA: 0x00267D49 File Offset: 0x00265F49
	// (set) Token: 0x0600AB87 RID: 43911 RVA: 0x00267D51 File Offset: 0x00265F51
	public EVisionRefineRefineType? RefineType { get; set; }

	// Token: 0x17000E3F RID: 3647
	// (get) Token: 0x0600AB88 RID: 43912 RVA: 0x00267D5A File Offset: 0x00265F5A
	// (set) Token: 0x0600AB89 RID: 43913 RVA: 0x00267D62 File Offset: 0x00265F62
	public int? UniqueId { get; set; }

	// Token: 0x17000E40 RID: 3648
	// (get) Token: 0x0600AB8A RID: 43914 RVA: 0x00267D6B File Offset: 0x00265F6B
	// (set) Token: 0x0600AB8B RID: 43915 RVA: 0x00267D73 File Offset: 0x00265F73
	public bool? ActiveCaptionItem { get; set; }

	// Token: 0x17000E41 RID: 3649
	// (get) Token: 0x0600AB8C RID: 43916 RVA: 0x00267D7C File Offset: 0x00265F7C
	// (set) Token: 0x0600AB8D RID: 43917 RVA: 0x00267D84 File Offset: 0x00265F84
	public bool? SlotInteractive { get; set; }

	// Token: 0x17000E42 RID: 3650
	// (get) Token: 0x0600AB8E RID: 43918 RVA: 0x00267D8D File Offset: 0x00265F8D
	// (set) Token: 0x0600AB8F RID: 43919 RVA: 0x00267D95 File Offset: 0x00265F95
	public bool? ResultShowTips { get; set; }

	// Token: 0x17000E43 RID: 3651
	// (get) Token: 0x0600AB90 RID: 43920 RVA: 0x00267D9E File Offset: 0x00265F9E
	// (set) Token: 0x0600AB91 RID: 43921 RVA: 0x00267DA6 File Offset: 0x00265FA6
	public bool? IsSingleMode { get; set; }

	// Token: 0x17000E44 RID: 3652
	// (get) Token: 0x0600AB92 RID: 43922 RVA: 0x00267DAF File Offset: 0x00265FAF
	// (set) Token: 0x0600AB93 RID: 43923 RVA: 0x00267DB7 File Offset: 0x00265FB7
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

	// Token: 0x17000E45 RID: 3653
	// (get) Token: 0x0600AB94 RID: 43924 RVA: 0x00267DC0 File Offset: 0x00265FC0
	// (set) Token: 0x0600AB95 RID: 43925 RVA: 0x00267DC8 File Offset: 0x00265FC8
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
