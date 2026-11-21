using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x02000D9D RID: 3485
public class TipsFurnitureData : ItemTipsData
{
	// Token: 0x06008EA2 RID: 36514 RVA: 0x002AF41E File Offset: 0x002AD61E
	[NullableContext(1)]
	public TipsFurnitureData(ItemTipsParam data) : base(data)
	{
		this.ItemType = EItemTipsType.Furniture;
	}
}
