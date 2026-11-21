using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x02000D97 RID: 3479
public class TipsHeadData : ItemTipsData
{
	// Token: 0x06008E95 RID: 36501 RVA: 0x002AF32D File Offset: 0x002AD52D
	[NullableContext(1)]
	public TipsHeadData(ItemTipsParam data) : base(data)
	{
		this.ItemType = EItemTipsType.Head;
	}
}
