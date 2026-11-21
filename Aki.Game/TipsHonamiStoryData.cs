using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x02000D9B RID: 3483
public class TipsHonamiStoryData : ItemTipsData
{
	// Token: 0x06008EA0 RID: 36512 RVA: 0x002AF3CB File Offset: 0x002AD5CB
	[NullableContext(1)]
	public TipsHonamiStoryData(ItemTipsParam data) : base(data)
	{
		this.ItemType = EItemTipsType.HonamiStory;
	}
}
