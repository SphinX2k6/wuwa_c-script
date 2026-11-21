using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020009A3 RID: 2467
public class ScratchTicketCellData
{
	// Token: 0x06006C47 RID: 27719 RVA: 0x002187E4 File Offset: 0x002169E4
	public ScratchTicketCellData(int index)
	{
		this.Index = index;
	}

	// Token: 0x06006C48 RID: 27720 RVA: 0x002187F3 File Offset: 0x002169F3
	[NullableContext(1)]
	public void SetRewardItem(ScratchCardRewardData reward)
	{
		this.ItemBase = new TItem?(new TItem(new InventoryDefine.GetItemData(reward.ItemId, 0), reward.Num));
	}

	// Token: 0x06006C49 RID: 27721 RVA: 0x00218817 File Offset: 0x00216A17
	public bool IsLock()
	{
		return this.ItemBase == null;
	}

	// Token: 0x06006C4A RID: 27722 RVA: 0x00218827 File Offset: 0x00216A27
	public TItem? GetItemData()
	{
		return this.ItemBase;
	}

	// Token: 0x040043C5 RID: 17349
	public readonly int Index;

	// Token: 0x040043C6 RID: 17350
	private TItem? ItemBase;
}
