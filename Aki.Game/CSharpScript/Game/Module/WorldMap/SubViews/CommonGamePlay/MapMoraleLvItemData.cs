using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.CommonGamePlay
{
	// Token: 0x0200483E RID: 18494
	[NullableContext(2)]
	[Nullable(0)]
	public class MapMoraleLvItemData : IMapMoraleLvItemData
	{
		// Token: 0x17007902 RID: 30978
		// (get) Token: 0x06030665 RID: 198245 RVA: 0x00B3C33B File Offset: 0x00B3A53B
		// (set) Token: 0x06030666 RID: 198246 RVA: 0x00B3C343 File Offset: 0x00B3A543
		[Nullable(1)]
		public string TitleId { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17007903 RID: 30979
		// (get) Token: 0x06030667 RID: 198247 RVA: 0x00B3C34C File Offset: 0x00B3A54C
		// (set) Token: 0x06030668 RID: 198248 RVA: 0x00B3C354 File Offset: 0x00B3A554
		public int Lv { get; set; }

		// Token: 0x17007904 RID: 30980
		// (get) Token: 0x06030669 RID: 198249 RVA: 0x00B3C35D File Offset: 0x00B3A55D
		// (set) Token: 0x0603066A RID: 198250 RVA: 0x00B3C365 File Offset: 0x00B3A565
		public string LvColor { get; set; }

		// Token: 0x17007905 RID: 30981
		// (get) Token: 0x0603066B RID: 198251 RVA: 0x00B3C36E File Offset: 0x00B3A56E
		// (set) Token: 0x0603066C RID: 198252 RVA: 0x00B3C376 File Offset: 0x00B3A576
		public string BgColor { get; set; }
	}
}
