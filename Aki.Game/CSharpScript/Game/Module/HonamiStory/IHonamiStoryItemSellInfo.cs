using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x0200593F RID: 22847
	[NullableContext(1)]
	public interface IHonamiStoryItemSellInfo
	{
		// Token: 0x17008AFA RID: 35578
		// (get) Token: 0x0603A004 RID: 237572
		// (set) Token: 0x0603A005 RID: 237573
		HonamiStoryItemDataBase ItemData { get; set; }

		// Token: 0x17008AFB RID: 35579
		// (get) Token: 0x0603A006 RID: 237574
		// (set) Token: 0x0603A007 RID: 237575
		EHonamiStoryBackpack BackpackType { get; set; }
	}
}
