using System;
using System.Runtime.CompilerServices;

// Token: 0x02001219 RID: 4633
public class AbyssDangoRoleSlotData
{
	// Token: 0x06007C2C RID: 31788 RVA: 0x001A3CDD File Offset: 0x001A1EDD
	public int GetSlotIndex()
	{
		return this.SlotIndex;
	}

	// Token: 0x06007C2D RID: 31789 RVA: 0x001A3CE5 File Offset: 0x001A1EE5
	public int GetDangoId()
	{
		return this.DangoRoleId;
	}

	// Token: 0x06007C2E RID: 31790 RVA: 0x001A3CED File Offset: 0x001A1EED
	public int GetIncId()
	{
		return this.UniqueId;
	}

	// Token: 0x06007C2F RID: 31791 RVA: 0x001A3CF5 File Offset: 0x001A1EF5
	public int GetEquipId()
	{
		return this.ItemId;
	}

	// Token: 0x06007C30 RID: 31792 RVA: 0x001A3CFD File Offset: 0x001A1EFD
	[NullableContext(1)]
	public string GetPassiveSkillDesc()
	{
		if (this.ItemId > 0)
		{
			return DangoAbyssModel.Instance.GetPluginItemInfoById(this.UniqueId).GetPassiveSkillDesc();
		}
		return "";
	}

	// Token: 0x06007C31 RID: 31793 RVA: 0x001A3D23 File Offset: 0x001A1F23
	public void SetDangoRoleId(int id)
	{
		this.DangoRoleId = id;
	}

	// Token: 0x06007C32 RID: 31794 RVA: 0x001A3D2C File Offset: 0x001A1F2C
	public void Refresh(int slotIndex, int uniqueId, int itemId)
	{
		this.SlotIndex = slotIndex;
		this.UniqueId = uniqueId;
		this.ItemId = itemId;
	}

	// Token: 0x040038D3 RID: 14547
	private int SlotIndex = -1;

	// Token: 0x040038D4 RID: 14548
	private int UniqueId;

	// Token: 0x040038D5 RID: 14549
	private int ItemId;

	// Token: 0x040038D6 RID: 14550
	private int DangoRoleId;
}
