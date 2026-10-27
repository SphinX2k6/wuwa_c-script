using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x0200594D RID: 22861
	[NullableContext(1)]
	public interface IPickUpItemInfo
	{
		// Token: 0x17008B1A RID: 35610
		// (get) Token: 0x0603A049 RID: 237641
		// (set) Token: 0x0603A04A RID: 237642
		HonamiStoryItemDataBase ItemData { get; set; }

		// Token: 0x17008B1B RID: 35611
		// (get) Token: 0x0603A04B RID: 237643
		// (set) Token: 0x0603A04C RID: 237644
		Entity EntitySelf { get; set; }
	}
}
