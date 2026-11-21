using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckDetail
{
	// Token: 0x02004150 RID: 16720
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaDeckDetailViewData : IPhantomArenaDeckDetailViewData
	{
		// Token: 0x170054EE RID: 21742
		// (get) Token: 0x0602A4C5 RID: 173253 RVA: 0x00BF1737 File Offset: 0x00BEF937
		// (set) Token: 0x0602A4C6 RID: 173254 RVA: 0x00BF173F File Offset: 0x00BEF93F
		public DeckInfo DeckInfo { get; set; }

		// Token: 0x170054EF RID: 21743
		// (get) Token: 0x0602A4C7 RID: 173255 RVA: 0x00BF1748 File Offset: 0x00BEF948
		// (set) Token: 0x0602A4C8 RID: 173256 RVA: 0x00BF1750 File Offset: 0x00BEF950
		public bool ShowLocked { get; set; }

		// Token: 0x170054F0 RID: 21744
		// (get) Token: 0x0602A4C9 RID: 173257 RVA: 0x00BF1759 File Offset: 0x00BEF959
		// (set) Token: 0x0602A4CA RID: 173258 RVA: 0x00BF1761 File Offset: 0x00BEF961
		public int ActivityId { get; set; }

		// Token: 0x170054F1 RID: 21745
		// (get) Token: 0x0602A4CB RID: 173259 RVA: 0x00BF176A File Offset: 0x00BEF96A
		// (set) Token: 0x0602A4CC RID: 173260 RVA: 0x00BF1772 File Offset: 0x00BEF972
		public int? CurrencyId { get; set; }

		// Token: 0x170054F2 RID: 21746
		// (get) Token: 0x0602A4CD RID: 173261 RVA: 0x00BF177B File Offset: 0x00BEF97B
		// (set) Token: 0x0602A4CE RID: 173262 RVA: 0x00BF1783 File Offset: 0x00BEF983
		public int? CurCardId { get; set; }

		// Token: 0x170054F3 RID: 21747
		// (get) Token: 0x0602A4CF RID: 173263 RVA: 0x00BF178C File Offset: 0x00BEF98C
		// (set) Token: 0x0602A4D0 RID: 173264 RVA: 0x00BF1794 File Offset: 0x00BEF994
		public DetailViewCardItemData CardItemData { get; set; }

		// Token: 0x170054F4 RID: 21748
		// (get) Token: 0x0602A4D1 RID: 173265 RVA: 0x00BF179D File Offset: 0x00BEF99D
		// (set) Token: 0x0602A4D2 RID: 173266 RVA: 0x00BF17A5 File Offset: 0x00BEF9A5
		public CardDetailItemData DetailItemData { get; set; }

		// Token: 0x170054F5 RID: 21749
		// (get) Token: 0x0602A4D3 RID: 173267 RVA: 0x00BF17AE File Offset: 0x00BEF9AE
		// (set) Token: 0x0602A4D4 RID: 173268 RVA: 0x00BF17B6 File Offset: 0x00BEF9B6
		public List<int> EntryList { get; set; }

		// Token: 0x170054F6 RID: 21750
		// (get) Token: 0x0602A4D5 RID: 173269 RVA: 0x00BF17BF File Offset: 0x00BEF9BF
		// (set) Token: 0x0602A4D6 RID: 173270 RVA: 0x00BF17C7 File Offset: 0x00BEF9C7
		public bool? IsUnlock { get; set; }

		// Token: 0x170054F7 RID: 21751
		// (get) Token: 0x0602A4D7 RID: 173271 RVA: 0x00BF17D0 File Offset: 0x00BEF9D0
		// (set) Token: 0x0602A4D8 RID: 173272 RVA: 0x00BF17D8 File Offset: 0x00BEF9D8
		public bool? IsRecommend { get; set; }

		// Token: 0x170054F8 RID: 21752
		// (get) Token: 0x0602A4D9 RID: 173273 RVA: 0x00BF17E1 File Offset: 0x00BEF9E1
		// (set) Token: 0x0602A4DA RID: 173274 RVA: 0x00BF17E9 File Offset: 0x00BEF9E9
		public Action<DeckInfo> SaveRecommendDeckCallback { get; set; }
	}
}
