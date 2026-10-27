using System;
using System.Runtime.CompilerServices;

// Token: 0x02001E7E RID: 7806
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryRoleEquipSlotData
{
	// Token: 0x0600EDF6 RID: 60918 RVA: 0x0038C1B0 File Offset: 0x0038A3B0
	public HonamiStoryRoleEquipSlotData(int slotId)
	{
		this.SlotId = slotId;
	}

	// Token: 0x0600EDF7 RID: 60919 RVA: 0x0038C1BF File Offset: 0x0038A3BF
	public int GetSlotId()
	{
		return this.SlotId;
	}

	// Token: 0x0600EDF8 RID: 60920 RVA: 0x0038C1C7 File Offset: 0x0038A3C7
	public bool GetIsUnlock()
	{
		return this.IsUnlock;
	}

	// Token: 0x0600EDF9 RID: 60921 RVA: 0x0038C1CF File Offset: 0x0038A3CF
	public void SetIsUnlock(bool value)
	{
		this.IsUnlock = value;
	}

	// Token: 0x0600EDFA RID: 60922 RVA: 0x0038C1D8 File Offset: 0x0038A3D8
	public void SetItemData(HonamiStoryEquipItemData itemData)
	{
		this.ItemData = itemData;
	}

	// Token: 0x0600EDFB RID: 60923 RVA: 0x0038C1E1 File Offset: 0x0038A3E1
	public HonamiStoryEquipItemData GetItemData()
	{
		return this.ItemData;
	}

	// Token: 0x04006E68 RID: 28264
	private bool IsUnlock;

	// Token: 0x04006E69 RID: 28265
	private HonamiStoryEquipItemData ItemData;

	// Token: 0x04006E6A RID: 28266
	private readonly int SlotId;
}
