using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x02000D9E RID: 3486
public class TipsPinballItemData : TipsMaterialData
{
	// Token: 0x06008EA3 RID: 36515 RVA: 0x002AF42F File Offset: 0x002AD62F
	[NullableContext(1)]
	public TipsPinballItemData(ItemTipsParam data) : base(data)
	{
		this.ItemType = EItemTipsType.PinballItem;
	}
}
