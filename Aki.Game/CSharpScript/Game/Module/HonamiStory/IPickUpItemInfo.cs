using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02004926 RID: 18726
	[NullableContext(1)]
	public interface IPickUpItemInfo
	{
		// Token: 0x17005EE6 RID: 24294
		// (get) Token: 0x0602EF6C RID: 192364
		// (set) Token: 0x0602EF6D RID: 192365
		HonamiStoryItemDataBase ItemData { get; set; }

		// Token: 0x17005EE7 RID: 24295
		// (get) Token: 0x0602EF6E RID: 192366
		// (set) Token: 0x0602EF6F RID: 192367
		Entity EntitySelf { get; set; }
	}
}
