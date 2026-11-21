using System;
using System.Runtime.CompilerServices;

// Token: 0x020006CD RID: 1741
public class AbyssDangoRoleSlotData
{
	// Token: 0x06004FC2 RID: 20418 RVA: 0x001AC955 File Offset: 0x001AAB55
	public int GetSlotIndex()
	{
		return this.SlotIndex;
	}

	// Token: 0x06004FC3 RID: 20419 RVA: 0x001AC95D File Offset: 0x001AAB5D
	public int GetDangoId()
	{
		return this.DangoRoleId;
	}

	// Token: 0x06004FC4 RID: 20420 RVA: 0x001AC965 File Offset: 0x001AAB65
	public int GetIncId()
	{
		return this.UniqueId;
	}

	// Token: 0x06004FC5 RID: 20421 RVA: 0x001AC96D File Offset: 0x001AAB6D
	public int GetEquipId()
	{
		return this.ItemId;
	}

	// Token: 0x06004FC6 RID: 20422 RVA: 0x001AC975 File Offset: 0x001AAB75
	[NullableContext(1)]
	public string GetPassiveSkillDesc()
	{
		if (this.ItemId > 0)
		{
			return DangoAbyssModel.Instance.GetPluginItemInfoById(this.UniqueId).GetPassiveSkillDesc();
		}
		return "";
	}

	// Token: 0x06004FC7 RID: 20423 RVA: 0x001AC99B File Offset: 0x001AAB9B
	public void SetDangoRoleId(int id)
	{
		this.DangoRoleId = id;
	}

	// Token: 0x06004FC8 RID: 20424 RVA: 0x001AC9A4 File Offset: 0x001AABA4
	public void Refresh(int slotIndex, int uniqueId, int itemId)
	{
		this.SlotIndex = slotIndex;
		this.UniqueId = uniqueId;
		this.ItemId = itemId;
	}

	// Token: 0x0400396C RID: 14700
	private int SlotIndex = -1;

	// Token: 0x0400396D RID: 14701
	private int UniqueId;

	// Token: 0x0400396E RID: 14702
	private int ItemId;

	// Token: 0x0400396F RID: 14703
	private int DangoRoleId;
}
