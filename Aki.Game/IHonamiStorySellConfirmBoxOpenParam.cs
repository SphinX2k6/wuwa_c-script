using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001EEA RID: 7914
[NullableContext(1)]
public interface IHonamiStorySellConfirmBoxOpenParam
{
	// Token: 0x17001305 RID: 4869
	// (get) Token: 0x0600F3A2 RID: 62370
	// (set) Token: 0x0600F3A3 RID: 62371
	List<IHonamiStoryItemSellInfo> SellItemList { get; set; }

	// Token: 0x17001306 RID: 4870
	// (get) Token: 0x0600F3A4 RID: 62372
	// (set) Token: 0x0600F3A5 RID: 62373
	Action SellCallback { get; set; }
}
