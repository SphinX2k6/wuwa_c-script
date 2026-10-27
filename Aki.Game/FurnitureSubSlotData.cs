using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000F78 RID: 3960
[NullableContext(1)]
[Nullable(0)]
public class FurnitureSubSlotData : FurnitureSlotDataBase
{
	// Token: 0x06006564 RID: 25956 RVA: 0x0014297E File Offset: 0x00140B7E
	public override EFurnitureSlotType GetSlotType()
	{
		return EFurnitureSlotType.SubSlot;
	}

	// Token: 0x06006565 RID: 25957 RVA: 0x00142981 File Offset: 0x00140B81
	public void DeepCopy(FurnitureSubSlotData other)
	{
		base.DeepCopy(other);
		this.RootFurnitureEntityId = other.RootFurnitureEntityId;
		this.RootFurnitureConfigId = other.RootFurnitureConfigId;
		this.SlotIndex = other.SlotIndex;
	}

	// Token: 0x06006566 RID: 25958 RVA: 0x001429AE File Offset: 0x00140BAE
	public bool Compare(FurnitureSubSlotData other)
	{
		return base.Compare(other) && this.RootFurnitureEntityId == other.RootFurnitureEntityId && this.RootFurnitureConfigId == other.RootFurnitureConfigId && this.SlotIndex == other.SlotIndex;
	}

	// Token: 0x06006567 RID: 25959 RVA: 0x001429EC File Offset: 0x00140BEC
	public void SetSlotData(int rootFurnitureEntityId, int rootFurnitureConfigId, int slotIndex, int slotTagId, List<int> excludedFurnitureIds)
	{
		this.RootFurnitureEntityId = rootFurnitureEntityId;
		this.RootFurnitureConfigId = rootFurnitureConfigId;
		this.SlotIndex = slotIndex;
		this.SlotTagId = slotTagId;
		this.ExcludedFurnitureIds = excludedFurnitureIds;
	}

	// Token: 0x06006568 RID: 25960 RVA: 0x00142A13 File Offset: 0x00140C13
	public override void PlaceFurniture(int furnitureConfigId)
	{
		this.PlacedFurnitureConfigId = furnitureConfigId;
	}

	// Token: 0x06006569 RID: 25961 RVA: 0x00142A1C File Offset: 0x00140C1C
	public override void UnPlaceFurniture()
	{
		this.PlacedFurnitureConfigId = 0;
	}

	// Token: 0x0600656A RID: 25962 RVA: 0x00142A25 File Offset: 0x00140C25
	public int GetRootFurnitureEntityId()
	{
		return this.RootFurnitureEntityId;
	}

	// Token: 0x0600656B RID: 25963 RVA: 0x00142A2D File Offset: 0x00140C2D
	public int GetRootFurnitureConfigId()
	{
		return this.RootFurnitureConfigId;
	}

	// Token: 0x0600656C RID: 25964 RVA: 0x00142A35 File Offset: 0x00140C35
	public int GetSlotIndex()
	{
		return this.SlotIndex;
	}

	// Token: 0x04002E0D RID: 11789
	protected int RootFurnitureEntityId;

	// Token: 0x04002E0E RID: 11790
	protected int RootFurnitureConfigId;

	// Token: 0x04002E0F RID: 11791
	protected int SlotIndex;
}
