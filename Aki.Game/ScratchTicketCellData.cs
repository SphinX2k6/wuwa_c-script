using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020014EB RID: 5355
public class ScratchTicketCellData
{
	// Token: 0x0600986D RID: 39021 RVA: 0x0020EAA9 File Offset: 0x0020CCA9
	public ScratchTicketCellData(int index)
	{
		this.Index = index;
	}

	// Token: 0x0600986E RID: 39022 RVA: 0x0020EAB8 File Offset: 0x0020CCB8
	[NullableContext(1)]
	public void SetRewardItem(ScratchCardRewardData reward)
	{
		this.ItemBase = new TItem?(new TItem(new InventoryDefine.GetItemData(reward.ItemId, 0), reward.Num));
	}

	// Token: 0x0600986F RID: 39023 RVA: 0x0020EADC File Offset: 0x0020CCDC
	public bool IsLock()
	{
		return this.ItemBase == null;
	}

	// Token: 0x06009870 RID: 39024 RVA: 0x0020EAEC File Offset: 0x0020CCEC
	public TItem? GetItemData()
	{
		return this.ItemBase;
	}

	// Token: 0x04004320 RID: 17184
	public readonly int Index;

	// Token: 0x04004321 RID: 17185
	private TItem? ItemBase;
}
