using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.CommonGamePlay
{
	// Token: 0x0200483D RID: 18493
	[NullableContext(2)]
	public interface IMapMoraleLvItemData
	{
		// Token: 0x170078FE RID: 30974
		// (get) Token: 0x0603065D RID: 198237
		// (set) Token: 0x0603065E RID: 198238
		[Nullable(1)]
		string TitleId { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170078FF RID: 30975
		// (get) Token: 0x0603065F RID: 198239
		// (set) Token: 0x06030660 RID: 198240
		int Lv { get; set; }

		// Token: 0x17007900 RID: 30976
		// (get) Token: 0x06030661 RID: 198241
		// (set) Token: 0x06030662 RID: 198242
		string LvColor { get; set; }

		// Token: 0x17007901 RID: 30977
		// (get) Token: 0x06030663 RID: 198243
		// (set) Token: 0x06030664 RID: 198244
		string BgColor { get; set; }
	}
}
