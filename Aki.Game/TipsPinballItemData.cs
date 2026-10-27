using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x020018E5 RID: 6373
public class TipsPinballItemData : TipsMaterialData
{
	// Token: 0x0600BABA RID: 47802 RVA: 0x002A4CB3 File Offset: 0x002A2EB3
	[NullableContext(1)]
	public TipsPinballItemData(ItemTipsParam data) : base(data)
	{
		this.ItemType = EItemTipsType.PinballItem;
	}
}
