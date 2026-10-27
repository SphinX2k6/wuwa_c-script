using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x020018E2 RID: 6370
public class TipsHonamiStoryData : ItemTipsData
{
	// Token: 0x0600BAB7 RID: 47799 RVA: 0x002A4C4F File Offset: 0x002A2E4F
	[NullableContext(1)]
	public TipsHonamiStoryData(ItemTipsParam data) : base(data)
	{
		this.ItemType = EItemTipsType.HonamiStory;
	}
}
