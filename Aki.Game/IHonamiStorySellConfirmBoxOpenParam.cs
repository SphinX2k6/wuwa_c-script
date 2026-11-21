using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x020013AC RID: 5036
[NullableContext(1)]
public interface IHonamiStorySellConfirmBoxOpenParam
{
	// Token: 0x1700132F RID: 4911
	// (get) Token: 0x0600C7C1 RID: 51137
	// (set) Token: 0x0600C7C2 RID: 51138
	List<IHonamiStoryItemSellInfo> SellItemList { get; set; }

	// Token: 0x17001330 RID: 4912
	// (get) Token: 0x0600C7C3 RID: 51139
	// (set) Token: 0x0600C7C4 RID: 51140
	Action SellCallback { get; set; }
}
