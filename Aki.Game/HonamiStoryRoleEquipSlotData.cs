using System;
using System.Runtime.CompilerServices;

// Token: 0x02001340 RID: 4928
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryRoleEquipSlotData
{
	// Token: 0x0600C215 RID: 49685 RVA: 0x00397DA0 File Offset: 0x00395FA0
	public HonamiStoryRoleEquipSlotData(int slotId)
	{
		this.SlotId = slotId;
	}

	// Token: 0x0600C216 RID: 49686 RVA: 0x00397DAF File Offset: 0x00395FAF
	public int GetSlotId()
	{
		return this.SlotId;
	}

	// Token: 0x0600C217 RID: 49687 RVA: 0x00397DB7 File Offset: 0x00395FB7
	public bool GetIsUnlock()
	{
		return this.IsUnlock;
	}

	// Token: 0x0600C218 RID: 49688 RVA: 0x00397DBF File Offset: 0x00395FBF
	public void SetIsUnlock(bool value)
	{
		this.IsUnlock = value;
	}

	// Token: 0x0600C219 RID: 49689 RVA: 0x00397DC8 File Offset: 0x00395FC8
	public void SetItemData(HonamiStoryEquipItemData itemData)
	{
		this.ItemData = itemData;
	}

	// Token: 0x0600C21A RID: 49690 RVA: 0x00397DD1 File Offset: 0x00395FD1
	public HonamiStoryEquipItemData GetItemData()
	{
		return this.ItemData;
	}

	// Token: 0x04006F49 RID: 28489
	private bool IsUnlock;

	// Token: 0x04006F4A RID: 28490
	private HonamiStoryEquipItemData ItemData;

	// Token: 0x04006F4B RID: 28491
	private readonly int SlotId;
}
