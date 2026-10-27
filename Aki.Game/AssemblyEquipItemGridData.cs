using System;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02002915 RID: 10517
public class AssemblyEquipItemGridData : AssemblyGridData
{
	// Token: 0x06015AF3 RID: 88819 RVA: 0x00578677 File Offset: 0x00576877
	public AssemblyEquipItemGridData()
	{
		this.ItemType = InventoryDefine.EItemType.Common;
		this.QualityId = 0;
		this.ItemNum = 0;
	}

	// Token: 0x0400A18E RID: 41358
	public InventoryDefine.EItemType ItemType;

	// Token: 0x0400A18F RID: 41359
	public int QualityId;

	// Token: 0x0400A190 RID: 41360
	public int ItemNum;
}
