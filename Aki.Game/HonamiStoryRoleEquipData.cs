using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory.Data;

// Token: 0x0200133E RID: 4926
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryRoleEquipData
{
	// Token: 0x0600C1FA RID: 49658 RVA: 0x003972EC File Offset: 0x003954EC
	public HonamiStoryRoleEquipData(int rolePosition)
	{
		this.RolePosition = rolePosition;
	}

	// Token: 0x0600C1FB RID: 49659 RVA: 0x00397318 File Offset: 0x00395518
	public List<HonamiStoryEquipItemData> GetEquipItemDataList()
	{
		List<HonamiStoryEquipItemData> list = new List<HonamiStoryEquipItemData>();
		foreach (HonamiStoryRoleEquipSlotData honamiStoryRoleEquipSlotData in this.SlotData)
		{
			HonamiStoryEquipItemData itemData = honamiStoryRoleEquipSlotData.GetItemData();
			if (itemData != null)
			{
				list.Add(itemData);
			}
		}
		return list;
	}

	// Token: 0x0600C1FC RID: 49660 RVA: 0x0039737C File Offset: 0x0039557C
	public int GetCurPowerLevel(bool isForShow = true)
	{
		List<HonamiStoryEquipItemData> equipItemDataList = this.GetEquipItemDataList();
		return this.GetPowerLevelByItemList(equipItemDataList, isForShow);
	}

	// Token: 0x0600C1FD RID: 49661 RVA: 0x00397398 File Offset: 0x00395598
	public int GetPowerLevelByItemList(List<HonamiStoryEquipItemData> itemList, bool isForShow)
	{
		if (this.RoleId <= 0)
		{
			return 0;
		}
		int num = 0;
		HonamiStoryWeaponData weaponData = HonamiStoryModel.Instance.GetWeaponData(this.WeaponId);
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		int num2 = isForShow ? 0 : 100;
		foreach (HonamiStoryEquipItemData honamiStoryEquipItemData in itemList)
		{
			num += honamiStoryEquipItemData.GetBaseEnhance();
			int groupId = honamiStoryEquipItemData.GetGroupId();
			if (HonamiStoryUtil.CheckRolePowerValid(honamiStoryEquipItemData.GetRoleId(), this.GetParentRoleId()))
			{
				if (groupId == 0)
				{
					num += honamiStoryEquipItemData.GetRoleEnhance() + num2;
				}
				else
				{
					int val;
					if (!dictionary.TryGetValue(groupId, out val))
					{
						val = 0;
					}
					dictionary[groupId] = Math.Max(val, honamiStoryEquipItemData.GetRoleEnhance() + num2);
				}
			}
			if (weaponData != null && weaponData.PluginTags.Contains(honamiStoryEquipItemData.GetWeaponTag()))
			{
				if (groupId == 0)
				{
					num += honamiStoryEquipItemData.GetWeaponEnhance();
				}
				else
				{
					int val2;
					if (!dictionary.TryGetValue(groupId, out val2))
					{
						val2 = 0;
					}
					dictionary[groupId] = Math.Max(val2, honamiStoryEquipItemData.GetWeaponEnhance());
				}
			}
		}
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			num += keyValuePair.Value;
		}
		if (weaponData == null)
		{
			return num;
		}
		int num3 = 0;
		foreach (int suitId in weaponData.SuitId)
		{
			if (this.IsSuitActivate(suitId, itemList).IsActive)
			{
				HonamiStoryWeaponSuitData weaponSuitData = HonamiStoryModel.Instance.GetWeaponSuitData(suitId);
				num += weaponSuitData.Enhance;
				num3++;
			}
		}
		foreach (KeyValuePair<int, int> keyValuePair2 in weaponData.ExtraSuitAddEnhanceLevel)
		{
			if (keyValuePair2.Key <= num3)
			{
				num += keyValuePair2.Value;
			}
		}
		return num;
	}

	// Token: 0x0600C1FE RID: 49662 RVA: 0x003975C8 File Offset: 0x003957C8
	public int GetParentRoleId()
	{
		return HonamiStoryModel.Instance.GetParentRoleId(this.RoleId);
	}

	// Token: 0x0600C1FF RID: 49663 RVA: 0x003975DC File Offset: 0x003957DC
	public bool CheckItemBuffIsActive(HonamiStoryEquipItemData itemData)
	{
		if (itemData.GetRoleId() != 0)
		{
			return this.CheckRoleItemBuffIsActive(itemData);
		}
		if (itemData.GetGroupId() == 0)
		{
			return true;
		}
		bool result = false;
		List<HonamiStoryEquipItemData> equipItemDataList = this.GetEquipItemDataList();
		Dictionary<int, HonamiStoryEquipItemData> dictionary = new Dictionary<int, HonamiStoryEquipItemData>();
		foreach (HonamiStoryEquipItemData honamiStoryEquipItemData in equipItemDataList)
		{
			int groupId = honamiStoryEquipItemData.GetGroupId();
			if (groupId != 0)
			{
				HonamiStoryEquipItemData honamiStoryEquipItemData2;
				if (dictionary.TryGetValue(groupId, out honamiStoryEquipItemData2))
				{
					int quality = honamiStoryEquipItemData2.GetQuality();
					int quality2 = honamiStoryEquipItemData.GetQuality();
					if (quality >= quality2)
					{
						continue;
					}
				}
				dictionary[groupId] = honamiStoryEquipItemData;
			}
		}
		int groupId2 = itemData.GetGroupId();
		HonamiStoryEquipItemData honamiStoryEquipItemData3;
		if (dictionary.TryGetValue(groupId2, out honamiStoryEquipItemData3) && honamiStoryEquipItemData3.GetIncId() == itemData.GetIncId())
		{
			result = true;
		}
		return result;
	}

	// Token: 0x0600C200 RID: 49664 RVA: 0x003976A8 File Offset: 0x003958A8
	public bool CheckRoleItemBuffIsActive(HonamiStoryEquipItemData itemData)
	{
		bool groupId = itemData.GetGroupId() != 0;
		int roleId = itemData.GetRoleId();
		if (!groupId && HonamiStoryUtil.CheckRolePowerValid(roleId, this.GetParentRoleId()))
		{
			return true;
		}
		bool result = false;
		List<HonamiStoryEquipItemData> equipItemDataList = this.GetEquipItemDataList();
		Dictionary<int, HonamiStoryEquipItemData> dictionary = new Dictionary<int, HonamiStoryEquipItemData>();
		foreach (HonamiStoryEquipItemData honamiStoryEquipItemData in equipItemDataList)
		{
			int groupId2 = honamiStoryEquipItemData.GetGroupId();
			if (groupId2 != 0 && HonamiStoryUtil.CheckRolePowerValid(honamiStoryEquipItemData.GetRoleId(), this.GetParentRoleId()))
			{
				HonamiStoryEquipItemData honamiStoryEquipItemData2;
				if (dictionary.TryGetValue(groupId2, out honamiStoryEquipItemData2))
				{
					int quality = honamiStoryEquipItemData2.GetQuality();
					int quality2 = honamiStoryEquipItemData.GetQuality();
					if (quality >= quality2)
					{
						continue;
					}
				}
				dictionary[groupId2] = honamiStoryEquipItemData;
			}
		}
		int groupId3 = itemData.GetGroupId();
		HonamiStoryEquipItemData honamiStoryEquipItemData3;
		if (dictionary.TryGetValue(groupId3, out honamiStoryEquipItemData3) && honamiStoryEquipItemData3.GetIncId() == itemData.GetIncId())
		{
			result = true;
		}
		return result;
	}

	// Token: 0x0600C201 RID: 49665 RVA: 0x0039778C File Offset: 0x0039598C
	[NullableContext(2)]
	public void SetItemData(int position, HonamiStoryEquipItemData itemData)
	{
		this.ItemDataMap[position] = itemData;
		int honamiStoryPluginIndex = this.GetHonamiStoryPluginIndex(position);
		this.SlotData[honamiStoryPluginIndex].SetItemData(itemData);
	}

	// Token: 0x0600C202 RID: 49666 RVA: 0x003977C0 File Offset: 0x003959C0
	[NullableContext(2)]
	public HonamiStoryEquipItemData GetItemDataByPosition(int position)
	{
		HonamiStoryEquipItemData result;
		if (this.ItemDataMap.TryGetValue(position, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600C203 RID: 49667 RVA: 0x003977E0 File Offset: 0x003959E0
	public void RemoveItemData(int position)
	{
		this.ItemDataMap.Remove(position);
		int honamiStoryPluginIndex = this.GetHonamiStoryPluginIndex(position);
		this.SlotData[honamiStoryPluginIndex].SetItemData(null);
	}

	// Token: 0x0600C204 RID: 49668 RVA: 0x00397814 File Offset: 0x00395A14
	[NullableContext(2)]
	public void SetEquipData(HonamiStoryRackInfo info)
	{
		if (info == null)
		{
			return;
		}
		this.RoleId = info.RoleId;
		this.WeaponId = info.DressWeapon;
		List<HonamiStorySlotInfo> list = new List<HonamiStorySlotInfo>(info.HonamiStorySlotInfos);
		list.Sort((HonamiStorySlotInfo a, HonamiStorySlotInfo b) => a.SlotId.CompareTo(b.SlotId));
		foreach (HonamiStorySlotInfo honamiStorySlotInfo in list)
		{
			int num = honamiStorySlotInfo.SlotId - 1;
			if (num >= this.SlotData.Count)
			{
				HonamiStoryRoleEquipSlotData honamiStoryRoleEquipSlotData = new HonamiStoryRoleEquipSlotData(honamiStorySlotInfo.SlotId);
				honamiStoryRoleEquipSlotData.SetIsUnlock(honamiStorySlotInfo.IsUnlock);
				this.SlotData.Add(honamiStoryRoleEquipSlotData);
			}
			else
			{
				this.SlotData[num].SetIsUnlock(honamiStorySlotInfo.IsUnlock);
			}
		}
	}

	// Token: 0x0600C205 RID: 49669 RVA: 0x003978FC File Offset: 0x00395AFC
	public void SetRoleInfo(int roleId)
	{
		this.RoleId = roleId;
	}

	// Token: 0x0600C206 RID: 49670 RVA: 0x00397905 File Offset: 0x00395B05
	public void SetWeaponInfo(int weaponId)
	{
		this.WeaponId = weaponId;
	}

	// Token: 0x0600C207 RID: 49671 RVA: 0x0039790E File Offset: 0x00395B0E
	public int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x0600C208 RID: 49672 RVA: 0x00397916 File Offset: 0x00395B16
	public int GetPosition()
	{
		return this.RolePosition;
	}

	// Token: 0x0600C209 RID: 49673 RVA: 0x0039791E File Offset: 0x00395B1E
	public int GetHonamiStoryPluginPosition(int pluginIndex)
	{
		return (this.RolePosition + 1) * 100 + pluginIndex + 1;
	}

	// Token: 0x0600C20A RID: 49674 RVA: 0x0039792F File Offset: 0x00395B2F
	public int GetHonamiStoryPluginIndex(int pluginPosition)
	{
		return pluginPosition - (this.RolePosition + 1) * 100 - 1;
	}

	// Token: 0x0600C20B RID: 49675 RVA: 0x00397940 File Offset: 0x00395B40
	[return: Nullable(new byte[]
	{
		1,
		2
	})]
	public List<HonamiStoryEquipItemData> GetPluginList()
	{
		List<HonamiStoryEquipItemData> list = new List<HonamiStoryEquipItemData>();
		foreach (HonamiStoryRoleEquipSlotData honamiStoryRoleEquipSlotData in this.SlotData)
		{
			list.Add(honamiStoryRoleEquipSlotData.GetItemData());
		}
		return list;
	}

	// Token: 0x0600C20C RID: 49676 RVA: 0x003979A0 File Offset: 0x00395BA0
	public int GetWeaponId()
	{
		return this.WeaponId;
	}

	// Token: 0x0600C20D RID: 49677 RVA: 0x003979A8 File Offset: 0x00395BA8
	public int GetUnlockCounts()
	{
		int num = 0;
		foreach (HonamiStoryRoleEquipSlotData honamiStoryRoleEquipSlotData in this.SlotData)
		{
			num += ((honamiStoryRoleEquipSlotData.GetIsUnlock() > false) ? 1 : 0);
		}
		return num;
	}

	// Token: 0x0600C20E RID: 49678 RVA: 0x00397A04 File Offset: 0x00395C04
	public List<HonamiStoryRoleEquipSlotData> GetSlotList()
	{
		return this.SlotData;
	}

	// Token: 0x0600C20F RID: 49679 RVA: 0x00397A0C File Offset: 0x00395C0C
	public List<HonamiStoryEquipItemData> GetEquipRoleItemList()
	{
		List<HonamiStoryEquipItemData> list = new List<HonamiStoryEquipItemData>();
		foreach (KeyValuePair<int, HonamiStoryEquipItemData> keyValuePair in this.ItemDataMap)
		{
			if (keyValuePair.Value != null && keyValuePair.Value.GetRoleId() != 0)
			{
				list.Add(keyValuePair.Value);
			}
		}
		return list;
	}

	// Token: 0x0600C210 RID: 49680 RVA: 0x00397A84 File Offset: 0x00395C84
	public HonamiStoryWeaponSuitActiveData IsSuitActivate(int suitId, [Nullable(new byte[]
	{
		2,
		1
	})] List<HonamiStoryEquipItemData> itemList = null)
	{
		HonamiStoryWeaponSuitData weaponSuitData = HonamiStoryModel.Instance.GetWeaponSuitData(suitId);
		if (weaponSuitData == null)
		{
			return new HonamiStoryWeaponSuitActiveData
			{
				IsActive = false,
				CurCount = 0,
				NeedCount = 0
			};
		}
		int weaponPluginType = weaponSuitData.WeaponPluginType;
		int needNum = weaponSuitData.NeedNum;
		int num = 0;
		if (itemList != null)
		{
			using (List<HonamiStoryEquipItemData>.Enumerator enumerator = itemList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetSubType() == weaponPluginType)
					{
						num++;
					}
				}
				goto IL_BF;
			}
		}
		foreach (KeyValuePair<int, HonamiStoryEquipItemData> keyValuePair in this.ItemDataMap)
		{
			HonamiStoryEquipItemData value = keyValuePair.Value;
			if (value != null && value.GetSubType() == weaponPluginType)
			{
				num++;
			}
		}
		IL_BF:
		return new HonamiStoryWeaponSuitActiveData
		{
			IsActive = (num >= needNum),
			CurCount = num,
			NeedCount = needNum
		};
	}

	// Token: 0x0600C211 RID: 49681 RVA: 0x00397B8C File Offset: 0x00395D8C
	public int CheckEquipOnEmpty(HonamiStoryEquipItemData itemData)
	{
		List<HonamiStoryEquipItemData> list = new List<HonamiStoryEquipItemData>();
		int num = 0;
		foreach (HonamiStoryRoleEquipSlotData honamiStoryRoleEquipSlotData in this.SlotData)
		{
			HonamiStoryEquipItemData itemData2 = honamiStoryRoleEquipSlotData.GetItemData();
			if (itemData2 != null)
			{
				list.Add(itemData2);
			}
			if (!honamiStoryRoleEquipSlotData.GetIsUnlock())
			{
				break;
			}
			num++;
		}
		if (list.Count >= num)
		{
			return 0;
		}
		list.Add(itemData);
		return this.GetPowerLevelByItemList(list, false) - this.GetCurPowerLevel(false);
	}

	// Token: 0x0600C212 RID: 49682 RVA: 0x00397C20 File Offset: 0x00395E20
	public int GetNextEmptySlot()
	{
		foreach (HonamiStoryRoleEquipSlotData honamiStoryRoleEquipSlotData in this.SlotData)
		{
			if (honamiStoryRoleEquipSlotData.GetIsUnlock() && honamiStoryRoleEquipSlotData.GetItemData() == null)
			{
				return this.GetHonamiStoryPluginPosition(honamiStoryRoleEquipSlotData.GetSlotId() - 1);
			}
		}
		return -1;
	}

	// Token: 0x0600C213 RID: 49683 RVA: 0x00397C90 File Offset: 0x00395E90
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public ValueTuple<int, int, HonamiStoryEquipItemData> CheckEquipInstead(HonamiStoryEquipItemData itemData)
	{
		int num = -1;
		int num2 = this.GetCurPowerLevel(true);
		HonamiStoryEquipItemData item = null;
		List<HonamiStoryEquipItemData> list = new List<HonamiStoryEquipItemData>();
		foreach (HonamiStoryRoleEquipSlotData honamiStoryRoleEquipSlotData in this.SlotData)
		{
			HonamiStoryEquipItemData itemData2 = honamiStoryRoleEquipSlotData.GetItemData();
			if (itemData2 != null)
			{
				list.Add(itemData2);
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			List<HonamiStoryEquipItemData> list2 = new List<HonamiStoryEquipItemData>();
			for (int j = 0; j < list.Count; j++)
			{
				if (i == j)
				{
					list2.Add(itemData);
				}
				else
				{
					list2.Add(list[j]);
				}
			}
			int powerLevelByItemList = this.GetPowerLevelByItemList(list2, false);
			if (powerLevelByItemList > num2)
			{
				num = i;
				num2 = powerLevelByItemList;
				item = list[i];
			}
		}
		int item2 = (num != -1) ? this.GetHonamiStoryPluginPosition(num) : -1;
		int item3 = Math.Max(0, num2 - this.GetCurPowerLevel(false));
		return new ValueTuple<int, int, HonamiStoryEquipItemData>(item2, item3, item);
	}

	// Token: 0x04006F41 RID: 28481
	private int RoleId;

	// Token: 0x04006F42 RID: 28482
	private int WeaponId = -1;

	// Token: 0x04006F43 RID: 28483
	private readonly List<HonamiStoryRoleEquipSlotData> SlotData = new List<HonamiStoryRoleEquipSlotData>();

	// Token: 0x04006F44 RID: 28484
	private readonly int RolePosition;

	// Token: 0x04006F45 RID: 28485
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Dictionary<int, HonamiStoryEquipItemData> ItemDataMap = new Dictionary<int, HonamiStoryEquipItemData>();
}
