using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200042D RID: 1069
[NullableContext(1)]
[Nullable(0)]
public class FurnitureSubSlotData : FurnitureSlotDataBase
{
	// Token: 0x060038FC RID: 14588 RVA: 0x0014B21A File Offset: 0x0014941A
	public override EFurnitureSlotType GetSlotType()
	{
		return EFurnitureSlotType.SubSlot;
	}

	// Token: 0x060038FD RID: 14589 RVA: 0x0014B21D File Offset: 0x0014941D
	public void DeepCopy(FurnitureSubSlotData other)
	{
		base.DeepCopy(other);
		this.RootFurnitureEntityId = other.RootFurnitureEntityId;
		this.RootFurnitureConfigId = other.RootFurnitureConfigId;
		this.SlotIndex = other.SlotIndex;
	}

	// Token: 0x060038FE RID: 14590 RVA: 0x0014B24A File Offset: 0x0014944A
	public bool Compare(FurnitureSubSlotData other)
	{
		return base.Compare(other) && this.RootFurnitureEntityId == other.RootFurnitureEntityId && this.RootFurnitureConfigId == other.RootFurnitureConfigId && this.SlotIndex == other.SlotIndex;
	}

	// Token: 0x060038FF RID: 14591 RVA: 0x0014B288 File Offset: 0x00149488
	public void SetSlotData(int rootFurnitureEntityId, int rootFurnitureConfigId, int slotIndex, int slotTagId, List<int> excludedFurnitureIds)
	{
		this.RootFurnitureEntityId = rootFurnitureEntityId;
		this.RootFurnitureConfigId = rootFurnitureConfigId;
		this.SlotIndex = slotIndex;
		this.SlotTagId = slotTagId;
		this.ExcludedFurnitureIds = excludedFurnitureIds;
	}

	// Token: 0x06003900 RID: 14592 RVA: 0x0014B2AF File Offset: 0x001494AF
	public override void PlaceFurniture(int furnitureConfigId)
	{
		this.PlacedFurnitureConfigId = furnitureConfigId;
	}

	// Token: 0x06003901 RID: 14593 RVA: 0x0014B2B8 File Offset: 0x001494B8
	public override void UnPlaceFurniture()
	{
		this.PlacedFurnitureConfigId = 0;
	}

	// Token: 0x06003902 RID: 14594 RVA: 0x0014B2C1 File Offset: 0x001494C1
	public int GetRootFurnitureEntityId()
	{
		return this.RootFurnitureEntityId;
	}

	// Token: 0x06003903 RID: 14595 RVA: 0x0014B2C9 File Offset: 0x001494C9
	public int GetRootFurnitureConfigId()
	{
		return this.RootFurnitureConfigId;
	}

	// Token: 0x06003904 RID: 14596 RVA: 0x0014B2D1 File Offset: 0x001494D1
	public int GetSlotIndex()
	{
		return this.SlotIndex;
	}

	// Token: 0x04002EA6 RID: 11942
	protected int RootFurnitureEntityId;

	// Token: 0x04002EA7 RID: 11943
	protected int RootFurnitureConfigId;

	// Token: 0x04002EA8 RID: 11944
	protected int SlotIndex;
}
