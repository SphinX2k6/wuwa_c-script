using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.CommonGamePlay
{
	// Token: 0x0200376E RID: 14190
	[NullableContext(2)]
	public interface IMapMoraleLvItemData
	{
		// Token: 0x17004BBB RID: 19387
		// (get) Token: 0x06024E2D RID: 151085
		// (set) Token: 0x06024E2E RID: 151086
		[Nullable(1)]
		string TitleId { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17004BBC RID: 19388
		// (get) Token: 0x06024E2F RID: 151087
		// (set) Token: 0x06024E30 RID: 151088
		int Lv { get; set; }

		// Token: 0x17004BBD RID: 19389
		// (get) Token: 0x06024E31 RID: 151089
		// (set) Token: 0x06024E32 RID: 151090
		string LvColor { get; set; }

		// Token: 0x17004BBE RID: 19390
		// (get) Token: 0x06024E33 RID: 151091
		// (set) Token: 0x06024E34 RID: 151092
		string BgColor { get; set; }
	}
}
