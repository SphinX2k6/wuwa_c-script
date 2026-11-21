using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02004919 RID: 18713
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiStoryItemSellInfo : IHonamiStoryItemSellInfo
	{
		// Token: 0x17005EC8 RID: 24264
		// (get) Token: 0x0602EF2B RID: 192299 RVA: 0x00D19806 File Offset: 0x00D17A06
		// (set) Token: 0x0602EF2C RID: 192300 RVA: 0x00D1980E File Offset: 0x00D17A0E
		public HonamiStoryItemDataBase ItemData { get; set; }

		// Token: 0x17005EC9 RID: 24265
		// (get) Token: 0x0602EF2D RID: 192301 RVA: 0x00D19817 File Offset: 0x00D17A17
		// (set) Token: 0x0602EF2E RID: 192302 RVA: 0x00D1981F File Offset: 0x00D17A1F
		public EHonamiStoryBackpack BackpackType { get; set; }
	}
}
