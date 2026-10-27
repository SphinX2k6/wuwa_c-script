using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x020018DD RID: 6365
public class TipsCardData : ItemTipsData
{
	// Token: 0x0600BAAB RID: 47787 RVA: 0x002A4BA1 File Offset: 0x002A2DA1
	[NullableContext(1)]
	public TipsCardData(ItemTipsParam data) : base(data)
	{
		this.ItemType = EItemTipsType.Card;
	}
}
