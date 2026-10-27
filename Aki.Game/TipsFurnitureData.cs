using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x020018E4 RID: 6372
public class TipsFurnitureData : ItemTipsData
{
	// Token: 0x0600BAB9 RID: 47801 RVA: 0x002A4CA2 File Offset: 0x002A2EA2
	[NullableContext(1)]
	public TipsFurnitureData(ItemTipsParam data) : base(data)
	{
		this.ItemType = EItemTipsType.Furniture;
	}
}
