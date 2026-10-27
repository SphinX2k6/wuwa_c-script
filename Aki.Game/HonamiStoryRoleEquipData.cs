using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory.Data;

// Token: 0x02001E7C RID: 7804
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryRoleEquipData
{
	// Token: 0x0600EDDB RID: 60891 RVA: 0x0038B6FC File Offset: 0x003898FC
	public HonamiStoryRoleEquipData(int rolePosition)
	{
		this.RolePosition = rolePosition;
	}

	// Token: 0x0600EDDC RID: 60892 RVA: 0x0038B728 File Offset: 0x00389928
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

	// Token: 0x0600EDDD RID: 60893 RVA: 0x0038B78C File Offset: 0x0038998C
	public int GetCurPowerLevel(bool isForShow = true)
	{
		List<HonamiStoryEquipItemData> equipItemDataList = this.GetEquipItemDataList();
		return this.GetPowerLevelByItemList(equipItemDataList, isForShow);
	}

	// Token: 0x0600EDDE RID: 60894 RVA: 0x0038B7A8 File Offset: 0x003899A8
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

	// Token: 0x0600EDDF RID: 60895 RVA: 0x0038B9D8 File Offset: 0x00389BD8
	public int GetParentRoleId()
	{
		return HonamiStoryModel.Instance.GetParentRoleId(this.RoleId);
	}

	// Token: 0x0600EDE0 RID: 60896 RVA: 0x0038B9EC File Offset: 0x00389BEC
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

	// Token: 0x0600EDE1 RID: 60897 RVA: 0x0038BAB8 File Offset: 0x00389CB8
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

	// Token: 0x0600EDE2 RID: 60898 RVA: 0x0038BB9C File Offset: 0x00389D9C
	[NullableContext(2)]
	public void SetItemData(int position, HonamiStoryEquipItemData itemData)
	{
		this.ItemDataMap[position] = itemData;
		int honamiStoryPluginIndex = this.GetHonamiStoryPluginIndex(position);
		this.SlotData[honamiStoryPluginIndex].SetItemData(itemData);
	}

	// Token: 0x0600EDE3 RID: 60899 RVA: 0x0038BBD0 File Offset: 0x00389DD0
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

	// Token: 0x0600EDE4 RID: 60900 RVA: 0x0038BBF0 File Offset: 0x00389DF0
	public void RemoveItemData(int position)
	{
		this.ItemDataMap.Remove(position);
		int honamiStoryPluginIndex = this.GetHonamiStoryPluginIndex(position);
		this.SlotData[honamiStoryPluginIndex].SetItemData(null);
	}

	// Token: 0x0600EDE5 RID: 60901 RVA: 0x0038BC24 File Offset: 0x00389E24
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

	// Token: 0x0600EDE6 RID: 60902 RVA: 0x0038BD0C File Offset: 0x00389F0C
	public void SetRoleInfo(int roleId)
	{
		this.RoleId = roleId;
	}

	// Token: 0x0600EDE7 RID: 60903 RVA: 0x0038BD15 File Offset: 0x00389F15
	public void SetWeaponInfo(int weaponId)
	{
		this.WeaponId = weaponId;
	}

	// Token: 0x0600EDE8 RID: 60904 RVA: 0x0038BD1E File Offset: 0x00389F1E
	public int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x0600EDE9 RID: 60905 RVA: 0x0038BD26 File Offset: 0x00389F26
	public int GetPosition()
	{
		return this.RolePosition;
	}

	// Token: 0x0600EDEA RID: 60906 RVA: 0x0038BD2E File Offset: 0x00389F2E
	public int GetHonamiStoryPluginPosition(int pluginIndex)
	{
		return (this.RolePosition + 1) * 100 + pluginIndex + 1;
	}

	// Token: 0x0600EDEB RID: 60907 RVA: 0x0038BD3F File Offset: 0x00389F3F
	public int GetHonamiStoryPluginIndex(int pluginPosition)
	{
		return pluginPosition - (this.RolePosition + 1) * 100 - 1;
	}

	// Token: 0x0600EDEC RID: 60908 RVA: 0x0038BD50 File Offset: 0x00389F50
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

	// Token: 0x0600EDED RID: 60909 RVA: 0x0038BDB0 File Offset: 0x00389FB0
	public int GetWeaponId()
	{
		return this.WeaponId;
	}

	// Token: 0x0600EDEE RID: 60910 RVA: 0x0038BDB8 File Offset: 0x00389FB8
	public int GetUnlockCounts()
	{
		int num = 0;
		foreach (HonamiStoryRoleEquipSlotData honamiStoryRoleEquipSlotData in this.SlotData)
		{
			num += ((honamiStoryRoleEquipSlotData.GetIsUnlock() > false) ? 1 : 0);
		}
		return num;
	}

	// Token: 0x0600EDEF RID: 60911 RVA: 0x0038BE14 File Offset: 0x0038A014
	public List<HonamiStoryRoleEquipSlotData> GetSlotList()
	{
		return this.SlotData;
	}

	// Token: 0x0600EDF0 RID: 60912 RVA: 0x0038BE1C File Offset: 0x0038A01C
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

	// Token: 0x0600EDF1 RID: 60913 RVA: 0x0038BE94 File Offset: 0x0038A094
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

	// Token: 0x0600EDF2 RID: 60914 RVA: 0x0038BF9C File Offset: 0x0038A19C
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

	// Token: 0x0600EDF3 RID: 60915 RVA: 0x0038C030 File Offset: 0x0038A230
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

	// Token: 0x0600EDF4 RID: 60916 RVA: 0x0038C0A0 File Offset: 0x0038A2A0
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

	// Token: 0x04006E60 RID: 28256
	private int RoleId;

	// Token: 0x04006E61 RID: 28257
	private int WeaponId = -1;

	// Token: 0x04006E62 RID: 28258
	private readonly List<HonamiStoryRoleEquipSlotData> SlotData = new List<HonamiStoryRoleEquipSlotData>();

	// Token: 0x04006E63 RID: 28259
	private readonly int RolePosition;

	// Token: 0x04006E64 RID: 28260
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Dictionary<int, HonamiStoryEquipItemData> ItemDataMap = new Dictionary<int, HonamiStoryEquipItemData>();
}
