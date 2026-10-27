using System;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Skin
{
	// Token: 0x02004BE1 RID: 19425
	public class SkinViewData : ISkinViewData
	{
		// Token: 0x17007C5A RID: 31834
		// (get) Token: 0x0603238D RID: 205709 RVA: 0x00BAAFC3 File Offset: 0x00BA91C3
		// (set) Token: 0x0603238E RID: 205710 RVA: 0x00BAAFCB File Offset: 0x00BA91CB
		public int RoleId { get; set; }

		// Token: 0x17007C5B RID: 31835
		// (get) Token: 0x0603238F RID: 205711 RVA: 0x00BAAFD4 File Offset: 0x00BA91D4
		// (set) Token: 0x06032390 RID: 205712 RVA: 0x00BAAFDC File Offset: 0x00BA91DC
		public int WeaponId { get; set; }

		// Token: 0x17007C5C RID: 31836
		// (get) Token: 0x06032391 RID: 205713 RVA: 0x00BAAFE5 File Offset: 0x00BA91E5
		// (set) Token: 0x06032392 RID: 205714 RVA: 0x00BAAFED File Offset: 0x00BA91ED
		public EUiTabViewName TabViewName { get; set; }

		// Token: 0x17007C5D RID: 31837
		// (get) Token: 0x06032393 RID: 205715 RVA: 0x00BAAFF6 File Offset: 0x00BA91F6
		// (set) Token: 0x06032394 RID: 205716 RVA: 0x00BAAFFE File Offset: 0x00BA91FE
		public bool NeedLoadRole { get; set; }

		// Token: 0x17007C5E RID: 31838
		// (get) Token: 0x06032395 RID: 205717 RVA: 0x00BAB007 File Offset: 0x00BA9207
		// (set) Token: 0x06032396 RID: 205718 RVA: 0x00BAB00F File Offset: 0x00BA920F
		public int? FlySkinId { get; set; }

		// Token: 0x17007C5F RID: 31839
		// (get) Token: 0x06032397 RID: 205719 RVA: 0x00BAB018 File Offset: 0x00BA9218
		// (set) Token: 0x06032398 RID: 205720 RVA: 0x00BAB020 File Offset: 0x00BA9220
		public EFlySkinTab? FlySkinTab { get; set; }

		// Token: 0x17007C60 RID: 31840
		// (get) Token: 0x06032399 RID: 205721 RVA: 0x00BAB029 File Offset: 0x00BA9229
		// (set) Token: 0x0603239A RID: 205722 RVA: 0x00BAB031 File Offset: 0x00BA9231
		public int? CalabashSkinId { get; set; }

		// Token: 0x17007C61 RID: 31841
		// (get) Token: 0x0603239B RID: 205723 RVA: 0x00BAB03A File Offset: 0x00BA923A
		// (set) Token: 0x0603239C RID: 205724 RVA: 0x00BAB042 File Offset: 0x00BA9242
		public int? SelectRoleSkinId { get; set; }

		// Token: 0x17007C62 RID: 31842
		// (get) Token: 0x0603239D RID: 205725 RVA: 0x00BAB04B File Offset: 0x00BA924B
		// (set) Token: 0x0603239E RID: 205726 RVA: 0x00BAB053 File Offset: 0x00BA9253
		public int? OrnamentSkinId { get; set; }

		// Token: 0x17007C63 RID: 31843
		// (get) Token: 0x0603239F RID: 205727 RVA: 0x00BAB05C File Offset: 0x00BA925C
		// (set) Token: 0x060323A0 RID: 205728 RVA: 0x00BAB064 File Offset: 0x00BA9264
		public int? OrnamentId { get; set; }

		// Token: 0x17007C64 RID: 31844
		// (get) Token: 0x060323A1 RID: 205729 RVA: 0x00BAB06D File Offset: 0x00BA926D
		// (set) Token: 0x060323A2 RID: 205730 RVA: 0x00BAB075 File Offset: 0x00BA9275
		public bool? SkipOrnamentCameraBlend { get; set; }
	}
}
