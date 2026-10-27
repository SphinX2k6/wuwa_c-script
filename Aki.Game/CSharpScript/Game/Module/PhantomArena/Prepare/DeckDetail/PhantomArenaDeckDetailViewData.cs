using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckDetail
{
	// Token: 0x02005180 RID: 20864
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaDeckDetailViewData : IPhantomArenaDeckDetailViewData
	{
		// Token: 0x1700812E RID: 33070
		// (get) Token: 0x060355CA RID: 218570 RVA: 0x00CA417F File Offset: 0x00CA237F
		// (set) Token: 0x060355CB RID: 218571 RVA: 0x00CA4187 File Offset: 0x00CA2387
		public DeckInfo DeckInfo { get; set; }

		// Token: 0x1700812F RID: 33071
		// (get) Token: 0x060355CC RID: 218572 RVA: 0x00CA4190 File Offset: 0x00CA2390
		// (set) Token: 0x060355CD RID: 218573 RVA: 0x00CA4198 File Offset: 0x00CA2398
		public bool ShowLocked { get; set; }

		// Token: 0x17008130 RID: 33072
		// (get) Token: 0x060355CE RID: 218574 RVA: 0x00CA41A1 File Offset: 0x00CA23A1
		// (set) Token: 0x060355CF RID: 218575 RVA: 0x00CA41A9 File Offset: 0x00CA23A9
		public int ActivityId { get; set; }

		// Token: 0x17008131 RID: 33073
		// (get) Token: 0x060355D0 RID: 218576 RVA: 0x00CA41B2 File Offset: 0x00CA23B2
		// (set) Token: 0x060355D1 RID: 218577 RVA: 0x00CA41BA File Offset: 0x00CA23BA
		public int? CurrencyId { get; set; }

		// Token: 0x17008132 RID: 33074
		// (get) Token: 0x060355D2 RID: 218578 RVA: 0x00CA41C3 File Offset: 0x00CA23C3
		// (set) Token: 0x060355D3 RID: 218579 RVA: 0x00CA41CB File Offset: 0x00CA23CB
		public int? CurCardId { get; set; }

		// Token: 0x17008133 RID: 33075
		// (get) Token: 0x060355D4 RID: 218580 RVA: 0x00CA41D4 File Offset: 0x00CA23D4
		// (set) Token: 0x060355D5 RID: 218581 RVA: 0x00CA41DC File Offset: 0x00CA23DC
		public DetailViewCardItemData CardItemData { get; set; }

		// Token: 0x17008134 RID: 33076
		// (get) Token: 0x060355D6 RID: 218582 RVA: 0x00CA41E5 File Offset: 0x00CA23E5
		// (set) Token: 0x060355D7 RID: 218583 RVA: 0x00CA41ED File Offset: 0x00CA23ED
		public CardDetailItemData DetailItemData { get; set; }

		// Token: 0x17008135 RID: 33077
		// (get) Token: 0x060355D8 RID: 218584 RVA: 0x00CA41F6 File Offset: 0x00CA23F6
		// (set) Token: 0x060355D9 RID: 218585 RVA: 0x00CA41FE File Offset: 0x00CA23FE
		public List<int> EntryList { get; set; }

		// Token: 0x17008136 RID: 33078
		// (get) Token: 0x060355DA RID: 218586 RVA: 0x00CA4207 File Offset: 0x00CA2407
		// (set) Token: 0x060355DB RID: 218587 RVA: 0x00CA420F File Offset: 0x00CA240F
		public bool? IsUnlock { get; set; }

		// Token: 0x17008137 RID: 33079
		// (get) Token: 0x060355DC RID: 218588 RVA: 0x00CA4218 File Offset: 0x00CA2418
		// (set) Token: 0x060355DD RID: 218589 RVA: 0x00CA4220 File Offset: 0x00CA2420
		public bool? IsRecommend { get; set; }

		// Token: 0x17008138 RID: 33080
		// (get) Token: 0x060355DE RID: 218590 RVA: 0x00CA4229 File Offset: 0x00CA2429
		// (set) Token: 0x060355DF RID: 218591 RVA: 0x00CA4231 File Offset: 0x00CA2431
		public Action<DeckInfo> SaveRecommendDeckCallback { get; set; }
	}
}
