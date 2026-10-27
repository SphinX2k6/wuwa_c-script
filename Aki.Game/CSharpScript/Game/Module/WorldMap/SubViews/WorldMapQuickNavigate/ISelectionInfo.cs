using System;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x020047D9 RID: 18393
	public interface ISelectionInfo
	{
		// Token: 0x170078B5 RID: 30901
		// (get) Token: 0x060302EC RID: 197356
		// (set) Token: 0x060302ED RID: 197357
		int FirstIndex { get; set; }

		// Token: 0x170078B6 RID: 30902
		// (get) Token: 0x060302EE RID: 197358
		// (set) Token: 0x060302EF RID: 197359
		int SecondIndex { get; set; }

		// Token: 0x170078B7 RID: 30903
		// (get) Token: 0x060302F0 RID: 197360
		// (set) Token: 0x060302F1 RID: 197361
		int CountryId { get; set; }

		// Token: 0x170078B8 RID: 30904
		// (get) Token: 0x060302F2 RID: 197362
		// (set) Token: 0x060302F3 RID: 197363
		bool ExpandCountry { get; set; }

		// Token: 0x170078B9 RID: 30905
		// (get) Token: 0x060302F4 RID: 197364
		// (set) Token: 0x060302F5 RID: 197365
		int StateId { get; set; }

		// Token: 0x170078BA RID: 30906
		// (get) Token: 0x060302F6 RID: 197366
		// (set) Token: 0x060302F7 RID: 197367
		int AreaId { get; set; }
	}
}
