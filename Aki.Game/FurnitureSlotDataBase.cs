using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200042C RID: 1068
[NullableContext(1)]
[Nullable(0)]
public abstract class FurnitureSlotDataBase
{
	// Token: 0x060038F0 RID: 14576
	public abstract EFurnitureSlotType GetSlotType();

	// Token: 0x060038F1 RID: 14577
	public abstract void PlaceFurniture(int furnitureConfigId);

	// Token: 0x060038F2 RID: 14578
	public abstract void UnPlaceFurniture();

	// Token: 0x060038F3 RID: 14579 RVA: 0x0014B0B1 File Offset: 0x001492B1
	public void DeepCopy(FurnitureSlotDataBase other)
	{
		this.PlacedFurnitureConfigId = other.PlacedFurnitureConfigId;
		this.SlotTagId = other.SlotTagId;
		this.ExcludedFurnitureIds = new List<int>(other.ExcludedFurnitureIds);
	}

	// Token: 0x060038F4 RID: 14580 RVA: 0x0014B0DC File Offset: 0x001492DC
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

	// Token: 0x060038F5 RID: 14581 RVA: 0x0014B156 File Offset: 0x00149356
	public int GetPlacedFurnitureConfigId()
	{
		return this.PlacedFurnitureConfigId;
	}

	// Token: 0x060038F6 RID: 14582 RVA: 0x0014B15E File Offset: 0x0014935E
	public int GetSlotTagId()
	{
		return this.SlotTagId;
	}

	// Token: 0x060038F7 RID: 14583 RVA: 0x0014B166 File Offset: 0x00149366
	public List<int> GetExcludedFurnitureIds()
	{
		return this.ExcludedFurnitureIds;
	}

	// Token: 0x060038F8 RID: 14584 RVA: 0x0014B170 File Offset: 0x00149370
	public bool CheckCanPlace(int furnitureConfigId)
	{
		Furniture? furnitureConfig = FurnitureConfig.Instance.GetFurnitureConfig(furnitureConfigId);
		return furnitureConfig != null && this.CheckCanPlaceByConfig(furnitureConfig.Value);
	}

	// Token: 0x060038F9 RID: 14585 RVA: 0x0014B1A4 File Offset: 0x001493A4
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

	// Token: 0x060038FA RID: 14586 RVA: 0x0014B1FC File Offset: 0x001493FC
	public bool IsPlaced()
	{
		return this.PlacedFurnitureConfigId != 0;
	}

	// Token: 0x04002EA3 RID: 11939
	protected int PlacedFurnitureConfigId;

	// Token: 0x04002EA4 RID: 11940
	protected int SlotTagId;

	// Token: 0x04002EA5 RID: 11941
	protected List<int> ExcludedFurnitureIds = new List<int>();
}
