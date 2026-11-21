using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02004918 RID: 18712
	[NullableContext(1)]
	public interface IHonamiStoryItemSellInfo
	{
		// Token: 0x17005EC6 RID: 24262
		// (get) Token: 0x0602EF27 RID: 192295
		// (set) Token: 0x0602EF28 RID: 192296
		HonamiStoryItemDataBase ItemData { get; set; }

		// Token: 0x17005EC7 RID: 24263
		// (get) Token: 0x0602EF29 RID: 192297
		// (set) Token: 0x0602EF2A RID: 192298
		EHonamiStoryBackpack BackpackType { get; set; }
	}
}
