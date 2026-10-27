using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001EEB RID: 7915
[NullableContext(1)]
[Nullable(0)]
public class HonamiStorySellConfirmBoxOpenParam : IHonamiStorySellConfirmBoxOpenParam
{
	// Token: 0x17001307 RID: 4871
	// (get) Token: 0x0600F3A6 RID: 62374 RVA: 0x003ABF38 File Offset: 0x003AA138
	// (set) Token: 0x0600F3A7 RID: 62375 RVA: 0x003ABF40 File Offset: 0x003AA140
	public List<IHonamiStoryItemSellInfo> SellItemList { get; set; } = new List<IHonamiStoryItemSellInfo>();

	// Token: 0x17001308 RID: 4872
	// (get) Token: 0x0600F3A8 RID: 62376 RVA: 0x003ABF49 File Offset: 0x003AA149
	// (set) Token: 0x0600F3A9 RID: 62377 RVA: 0x003ABF51 File Offset: 0x003AA151
	public Action SellCallback { get; set; } = delegate()
	{
	};
}
