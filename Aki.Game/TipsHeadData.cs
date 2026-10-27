using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x020018DE RID: 6366
public class TipsHeadData : ItemTipsData
{
	// Token: 0x0600BAAC RID: 47788 RVA: 0x002A4BB1 File Offset: 0x002A2DB1
	[NullableContext(1)]
	public TipsHeadData(ItemTipsParam data) : base(data)
	{
		this.ItemType = EItemTipsType.Head;
	}
}
