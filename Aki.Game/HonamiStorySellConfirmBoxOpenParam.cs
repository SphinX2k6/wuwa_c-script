using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x020013AD RID: 5037
[NullableContext(1)]
[Nullable(0)]
public class HonamiStorySellConfirmBoxOpenParam : IHonamiStorySellConfirmBoxOpenParam
{
	// Token: 0x17001331 RID: 4913
	// (get) Token: 0x0600C7C5 RID: 51141 RVA: 0x003B7A34 File Offset: 0x003B5C34
	// (set) Token: 0x0600C7C6 RID: 51142 RVA: 0x003B7A3C File Offset: 0x003B5C3C
	public List<IHonamiStoryItemSellInfo> SellItemList { get; set; } = new List<IHonamiStoryItemSellInfo>();

	// Token: 0x17001332 RID: 4914
	// (get) Token: 0x0600C7C7 RID: 51143 RVA: 0x003B7A45 File Offset: 0x003B5C45
	// (set) Token: 0x0600C7C8 RID: 51144 RVA: 0x003B7A4D File Offset: 0x003B5C4D
	public Action SellCallback { get; set; } = delegate()
	{
	};
}
