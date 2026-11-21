using System;
using System.Runtime.CompilerServices;

// Token: 0x0200225F RID: 8799
[NullableContext(1)]
[Nullable(0)]
public class MaterialData
{
	// Token: 0x06015C6D RID: 89197 RVA: 0x00651623 File Offset: 0x0064F823
	public MaterialData(ItemDataBase itemData, int useCount = 1)
	{
		this.ItemData = itemData;
		this.UseCount = useCount;
	}

	// Token: 0x06015C6E RID: 89198 RVA: 0x00651639 File Offset: 0x0064F839
	public void AddCount()
	{
		this.UseCount++;
	}

	// Token: 0x06015C6F RID: 89199 RVA: 0x00651649 File Offset: 0x0064F849
	public void ReduceCount()
	{
		this.UseCount--;
	}

	// Token: 0x06015C70 RID: 89200 RVA: 0x00651659 File Offset: 0x0064F859
	public bool CheckEmpty()
	{
		return this.UseCount == 0;
	}

	// Token: 0x0400B786 RID: 46982
	public ItemDataBase ItemData;

	// Token: 0x0400B787 RID: 46983
	public int UseCount;
}
