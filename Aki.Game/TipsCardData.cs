using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x02000D96 RID: 3478
public class TipsCardData : ItemTipsData
{
	// Token: 0x06008E94 RID: 36500 RVA: 0x002AF31D File Offset: 0x002AD51D
	[NullableContext(1)]
	public TipsCardData(ItemTipsParam data) : base(data)
	{
		this.ItemType = EItemTipsType.Card;
	}
}
