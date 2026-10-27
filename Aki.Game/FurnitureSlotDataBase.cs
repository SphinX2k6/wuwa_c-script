using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000F77 RID: 3959
[NullableContext(1)]
[Nullable(0)]
public abstract class FurnitureSlotDataBase
{
	// Token: 0x06006558 RID: 25944
	public abstract EFurnitureSlotType GetSlotType();

	// Token: 0x06006559 RID: 25945
	public abstract void PlaceFurniture(int furnitureConfigId);

	// Token: 0x0600655A RID: 25946
	public abstract void UnPlaceFurniture();

	// Token: 0x0600655B RID: 25947 RVA: 0x00142815 File Offset: 0x00140A15
	public void DeepCopy(FurnitureSlotDataBase other)
	{
		this.PlacedFurnitureConfigId = other.PlacedFurnitureConfigId;
		this.SlotTagId = other.SlotTagId;
		this.ExcludedFurnitureIds = new List<int>(other.ExcludedFurnitureIds);
	}

	// Token: 0x0600655C RID: 25948 RVA: 0x00142840 File Offset: 0x00140A40
	public bool Compare(FurnitureSlotDataBase other)
	{
		if (this.PlacedFurnitureConfigId != other.PlacedFurnitureConfigId)
		{
			return false;
		}
		if (this.SlotTagId != other.SlotTagId)
		{
			return false;
		}
		if (this.ExcludedFurnitureIds.Count != other.ExcludedFurnitureIds.Count)
		{
			return false;
		}
		for (int i = 0; i < this.ExcludedFurnitureIds.Count; i++)
		{
			if (this.ExcludedFurnitureIds[i] != other.ExcludedFurnitureIds[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600655D RID: 25949 RVA: 0x001428BA File Offset: 0x00140ABA
	public int GetPlacedFurnitureConfigId()
	{
		return this.PlacedFurnitureConfigId;
	}

	// Token: 0x0600655E RID: 25950 RVA: 0x001428C2 File Offset: 0x00140AC2
	public int GetSlotTagId()
	{
		return this.SlotTagId;
	}

	// Token: 0x0600655F RID: 25951 RVA: 0x001428CA File Offset: 0x00140ACA
	public List<int> GetExcludedFurnitureIds()
	{
		return this.ExcludedFurnitureIds;
	}

	// Token: 0x06006560 RID: 25952 RVA: 0x001428D4 File Offset: 0x00140AD4
	public bool CheckCanPlace(int furnitureConfigId)
	{
		Furniture? furnitureConfig = FurnitureConfig.Instance.GetFurnitureConfig(furnitureConfigId);
		return furnitureConfig != null && this.CheckCanPlaceByConfig(furnitureConfig.Value);
	}

	// Token: 0x06006561 RID: 25953 RVA: 0x00142908 File Offset: 0x00140B08
	public bool CheckCanPlaceByConfig(Furniture config)
	{
		int id = config.Id;
		int num = -1;
		for (int i = 0; i < this.ExcludedFurnitureIds.Count; i++)
		{
			if (this.ExcludedFurnitureIds[i] == id)
			{
				num = i;
				break;
			}
		}
		return num == -1 && config.TagId == this.SlotTagId;
	}

	// Token: 0x06006562 RID: 25954 RVA: 0x00142960 File Offset: 0x00140B60
	public bool IsPlaced()
	{
		return this.PlacedFurnitureConfigId != 0;
	}

	// Token: 0x04002E0A RID: 11786
	protected int PlacedFurnitureConfigId;

	// Token: 0x04002E0B RID: 11787
	protected int SlotTagId;

	// Token: 0x04002E0C RID: 11788
	protected List<int> ExcludedFurnitureIds = new List<int>();
}
