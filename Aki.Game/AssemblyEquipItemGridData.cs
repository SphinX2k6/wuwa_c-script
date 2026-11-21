using System;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001E90 RID: 7824
public class AssemblyEquipItemGridData : AssemblyGridData
{
	// Token: 0x060134F7 RID: 79095 RVA: 0x005A356B File Offset: 0x005A176B
	public AssemblyEquipItemGridData()
	{
		this.ItemType = InventoryDefine.EItemType.Common;
		this.QualityId = 0;
		this.ItemNum = 0;
	}

	// Token: 0x0400A579 RID: 42361
	public InventoryDefine.EItemType ItemType;

	// Token: 0x0400A57A RID: 42362
	public int QualityId;

	// Token: 0x0400A57B RID: 42363
	public int ItemNum;
}
