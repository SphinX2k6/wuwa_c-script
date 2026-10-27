using System;
using System.Runtime.CompilerServices;

// Token: 0x02002D05 RID: 11525
[NullableContext(1)]
[Nullable(0)]
public class MaterialData
{
	// Token: 0x060183CC RID: 99276 RVA: 0x0062B62B File Offset: 0x0062982B
	public MaterialData(ItemDataBase itemData, int useCount = 1)
	{
		this.ItemData = itemData;
		this.UseCount = useCount;
	}

	// Token: 0x060183CD RID: 99277 RVA: 0x0062B641 File Offset: 0x00629841
	public void AddCount()
	{
		this.UseCount++;
	}

	// Token: 0x060183CE RID: 99278 RVA: 0x0062B651 File Offset: 0x00629851
	public void ReduceCount()
	{
		this.UseCount--;
	}

	// Token: 0x060183CF RID: 99279 RVA: 0x0062B661 File Offset: 0x00629861
	public bool CheckEmpty()
	{
		return this.UseCount == 0;
	}

	// Token: 0x0400B411 RID: 46097
	public ItemDataBase ItemData;

	// Token: 0x0400B412 RID: 46098
	public int UseCount;
}
