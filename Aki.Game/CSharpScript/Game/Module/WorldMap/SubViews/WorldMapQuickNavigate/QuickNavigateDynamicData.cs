using System;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x020047D0 RID: 18384
	public class QuickNavigateDynamicData
	{
		// Token: 0x170078AC RID: 30892
		// (get) Token: 0x060302B9 RID: 197305 RVA: 0x00B29BB0 File Offset: 0x00B27DB0
		// (set) Token: 0x060302BA RID: 197306 RVA: 0x00B29BB8 File Offset: 0x00B27DB8
		public EQuickNavigateItemType ItemType { get; set; }

		// Token: 0x170078AD RID: 30893
		// (get) Token: 0x060302BB RID: 197307 RVA: 0x00B29BC1 File Offset: 0x00B27DC1
		// (set) Token: 0x060302BC RID: 197308 RVA: 0x00B29BC9 File Offset: 0x00B27DC9
		public int CountryId { get; set; }

		// Token: 0x170078AE RID: 30894
		// (get) Token: 0x060302BD RID: 197309 RVA: 0x00B29BD2 File Offset: 0x00B27DD2
		// (set) Token: 0x060302BE RID: 197310 RVA: 0x00B29BDA File Offset: 0x00B27DDA
		public int StateId { get; set; }

		// Token: 0x170078AF RID: 30895
		// (get) Token: 0x060302BF RID: 197311 RVA: 0x00B29BE3 File Offset: 0x00B27DE3
		// (set) Token: 0x060302C0 RID: 197312 RVA: 0x00B29BEB File Offset: 0x00B27DEB
		public int AreaId { get; set; }

		// Token: 0x170078B0 RID: 30896
		// (get) Token: 0x060302C1 RID: 197313 RVA: 0x00B29BF4 File Offset: 0x00B27DF4
		// (set) Token: 0x060302C2 RID: 197314 RVA: 0x00B29BFC File Offset: 0x00B27DFC
		public int Index { get; set; }

		// Token: 0x170078B1 RID: 30897
		// (get) Token: 0x060302C3 RID: 197315 RVA: 0x00B29C05 File Offset: 0x00B27E05
		// (set) Token: 0x060302C4 RID: 197316 RVA: 0x00B29C0D File Offset: 0x00B27E0D
		public bool IsSelected { get; set; }

		// Token: 0x170078B2 RID: 30898
		// (get) Token: 0x060302C5 RID: 197317 RVA: 0x00B29C16 File Offset: 0x00B27E16
		// (set) Token: 0x060302C6 RID: 197318 RVA: 0x00B29C1E File Offset: 0x00B27E1E
		public ERefreshNavigateType RefreshType { get; set; }

		// Token: 0x170078B3 RID: 30899
		// (get) Token: 0x060302C7 RID: 197319 RVA: 0x00B29C27 File Offset: 0x00B27E27
		// (set) Token: 0x060302C8 RID: 197320 RVA: 0x00B29C2F File Offset: 0x00B27E2F
		public bool HasState { get; set; } = true;

		// Token: 0x170078B4 RID: 30900
		// (get) Token: 0x060302C9 RID: 197321 RVA: 0x00B29C38 File Offset: 0x00B27E38
		// (set) Token: 0x060302CA RID: 197322 RVA: 0x00B29C40 File Offset: 0x00B27E40
		public bool IsExpand { get; set; }
	}
}
