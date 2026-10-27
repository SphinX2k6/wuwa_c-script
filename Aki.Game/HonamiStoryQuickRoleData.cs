using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory.Data;

// Token: 0x02001E79 RID: 7801
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryQuickRoleData
{
	// Token: 0x0600EDC2 RID: 60866 RVA: 0x00389DF4 File Offset: 0x00387FF4
	public void Init(HonamiStoryRoleEquipData roleData)
	{
		this.Clear();
		this.RoleData = roleData;
		this.RoleId = this.RoleData.GetParentRoleId();
		this.InitSuitList();
		this.SlotUnlockCount = this.RoleData.GetUnlockCounts();
		HonamiStoryWeaponData weaponData = HonamiStoryModel.Instance.GetWeaponData(this.RoleData.GetWeaponId());
		if (weaponData != null)
		{
			this.WeaponTags = new List<int>(weaponData.PluginTags);
		}
	}

	// Token: 0x0600EDC3 RID: 60867 RVA: 0x00389E60 File Offset: 0x00388060
	public void Clear()
	{
		this.SortMap.Clear();
		this.WeaponTags.Clear();
		this.SuitNeedList.Clear();
		this.SuitNeedMap.Clear();
	}

	// Token: 0x0600EDC4 RID: 60868 RVA: 0x00389E90 File Offset: 0x00388090
	private void InitSuitList()
	{
		if (this.RoleData.GetParentRoleId() <= 0)
		{
			return;
		}
		int weaponId = this.RoleData.GetWeaponId();
		if (weaponId <= 0)
		{
			return;
		}
		HonamiStoryWeaponData weaponData = HonamiStoryModel.Instance.GetWeaponData(weaponId);
		if (weaponData == null)
		{
			return;
		}
		this.SuitNeedList = new List<int>(weaponData.SuitId);
		foreach (int suitId in this.SuitNeedList)
		{
			HonamiStoryWeaponSuitData weaponSuitData = HonamiStoryModel.Instance.GetWeaponSuitData(suitId);
			int weaponPluginType = weaponSuitData.WeaponPluginType;
			if (!this.SuitNeedMap.ContainsKey(weaponPluginType))
			{
				this.SuitNeedMap[weaponPluginType] = new List<int>();
			}
			this.SuitNeedMap[weaponPluginType].Add(weaponSuitData.NeedNum);
		}
	}

	// Token: 0x0600EDC5 RID: 60869 RVA: 0x00389F70 File Offset: 0x00388170
	public int GetMaxPower(Dictionary<int, List<HonamiStoryItemDataBase>> itemMap, [Nullable(new byte[]
	{
		2,
		1
	})] HashSet<HonamiStoryItemDataBase> occupySet)
	{
		this.BestResult.Clear();
		this.BestPower = 0;
		List<IHonamiStoryQuickSubType> list = new List<IHonamiStoryQuickSubType>();
		for (int i = 0; i < 3; i++)
		{
			list.Add(new HonamiStoryQuickSubType
			{
				SubType = i + 1,
				ItemList = new List<HonamiStoryEquipItemData>()
			});
		}
		foreach (KeyValuePair<int, List<HonamiStoryItemDataBase>> keyValuePair in itemMap)
		{
			int key = keyValuePair.Key;
			if (!this.SortMap.ContainsKey(key))
			{
				List<HonamiStoryItemDataBase> list2 = new List<HonamiStoryItemDataBase>(keyValuePair.Value);
				Dictionary<HonamiStoryItemDataBase, int> itemSortIndexMap = new Dictionary<HonamiStoryItemDataBase, int>();
				for (int j = 0; j < list2.Count; j++)
				{
					itemSortIndexMap[list2[j]] = j;
				}
				list2.Sort((HonamiStoryItemDataBase a, HonamiStoryItemDataBase b) => this.ItemSort(a, b, itemSortIndexMap));
				this.SortMap[key] = list2;
			}
			HonamiStoryQuickSubType honamiStoryQuickSubType = new HonamiStoryQuickSubType
			{
				SubType = key,
				ItemList = new List<HonamiStoryEquipItemData>()
			};
			List<HonamiStoryItemDataBase> itemList = this.SortMap[key];
			honamiStoryQuickSubType.ItemList = this.GetBestList(itemList, this.SlotUnlockCount * 2, occupySet ?? new HashSet<HonamiStoryItemDataBase>());
			list[key - 1] = honamiStoryQuickSubType;
		}
		this.BestPower = this.GetBest(list);
		List<HonamiStoryEquipItemData> list3 = new List<HonamiStoryEquipItemData>();
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in this.BestResult)
		{
			list3.Add(honamiStoryItemDataBase as HonamiStoryEquipItemData);
		}
		this.RealBestPower = this.RoleData.GetPowerLevelByItemList(list3, true);
		return this.BestPower;
	}

	// Token: 0x0600EDC6 RID: 60870 RVA: 0x0038A178 File Offset: 0x00388378
	protected int GetPower(HonamiStoryItemDataBase item, bool needPlus = true)
	{
		HonamiStoryEquipItemData honamiStoryEquipItemData = item as HonamiStoryEquipItemData;
		int num = honamiStoryEquipItemData.GetBaseEnhance();
		if (!needPlus)
		{
			return num;
		}
		if (this.WeaponTags.Contains(honamiStoryEquipItemData.GetWeaponTag()))
		{
			num += honamiStoryEquipItemData.GetWeaponEnhance();
		}
		if (HonamiStoryUtil.CheckRolePowerValid(this.RoleId, honamiStoryEquipItemData.GetRoleId()))
		{
			num += honamiStoryEquipItemData.GetRoleEnhance() + 100;
		}
		return num;
	}

	// Token: 0x0600EDC7 RID: 60871 RVA: 0x0038A1D4 File Offset: 0x003883D4
	private int ItemSort(HonamiStoryItemDataBase a, HonamiStoryItemDataBase b, Dictionary<HonamiStoryItemDataBase, int> itemSortIndexMap)
	{
		int power = this.GetPower(b, true);
		int power2 = this.GetPower(a, true);
		if (power != power2)
		{
			return power - power2;
		}
		HonamiStoryEquipItemData honamiStoryEquipItemData = a as HonamiStoryEquipItemData;
		bool flag = HonamiStoryUtil.CheckRolePowerValid(this.RoleId, honamiStoryEquipItemData.GetRoleId());
		HonamiStoryEquipItemData honamiStoryEquipItemData2 = b as HonamiStoryEquipItemData;
		bool flag2 = HonamiStoryUtil.CheckRolePowerValid(this.RoleId, honamiStoryEquipItemData2.GetRoleId());
		if (flag != flag2)
		{
			if (!flag)
			{
				return 1;
			}
			return -1;
		}
		else
		{
			int num;
			itemSortIndexMap.TryGetValue(a, out num);
			int num2;
			itemSortIndexMap.TryGetValue(b, out num2);
			if (num == num2)
			{
				return 0;
			}
			if (num >= num2)
			{
				return 1;
			}
			return -1;
		}
	}

	// Token: 0x0600EDC8 RID: 60872 RVA: 0x0038A264 File Offset: 0x00388464
	private int ItemSortNoPlus(HonamiStoryItemDataBase a, HonamiStoryItemDataBase b)
	{
		int power = this.GetPower(b, false);
		int power2 = this.GetPower(a, false);
		return power - power2;
	}

	// Token: 0x0600EDC9 RID: 60873 RVA: 0x0038A284 File Offset: 0x00388484
	private int GetBest(List<IHonamiStoryQuickSubType> powerList)
	{
		int num = 0;
		foreach (List<int> list in this.SortOrder.GetSortOrderList(3))
		{
			int index = list[0];
			int index2 = list[1];
			int index3 = list[2];
			for (int i = 0; i <= this.SlotUnlockCount; i++)
			{
				HashSet<int> hashSet = new HashSet<int>();
				ValueTuple<HashSet<int>, List<HonamiStoryEquipItemData>> lastList = this.GetLastList(powerList[index].ItemList, hashSet, i);
				hashSet = lastList.Item1;
				List<HonamiStoryEquipItemData> item = lastList.Item2;
				for (int j = 0; j <= this.SlotUnlockCount - i; j++)
				{
					HashSet<int> groupList = new HashSet<int>(hashSet);
					ValueTuple<HashSet<int>, List<HonamiStoryEquipItemData>> lastList2 = this.GetLastList(powerList[index2].ItemList, groupList, j);
					groupList = lastList2.Item1;
					List<HonamiStoryEquipItemData> item2 = lastList2.Item2;
					ValueTuple<HashSet<int>, List<HonamiStoryEquipItemData>> lastList3 = this.GetLastList(powerList[index3].ItemList, groupList, this.SlotUnlockCount - i - j);
					groupList = lastList3.Item1;
					List<HonamiStoryEquipItemData> item3 = lastList3.Item2;
					List<HonamiStoryEquipItemData> list2 = new List<HonamiStoryEquipItemData>();
					list2.AddRange(item);
					list2.AddRange(item2);
					list2.AddRange(item3);
					int powerLevelByItemList = this.RoleData.GetPowerLevelByItemList(list2, false);
					if (powerLevelByItemList > num)
					{
						this.BestResult.Clear();
						foreach (HonamiStoryEquipItemData item4 in list2)
						{
							this.BestResult.Add(item4);
						}
						num = powerLevelByItemList;
					}
				}
			}
		}
		return num;
	}

	// Token: 0x0600EDCA RID: 60874 RVA: 0x0038A45C File Offset: 0x0038865C
	private List<HonamiStoryEquipItemData> GetBestList(List<HonamiStoryItemDataBase> itemList, int length, HashSet<HonamiStoryItemDataBase> ignoreSet)
	{
		int num = 0;
		HashSet<int> hashSet = new HashSet<int>();
		List<HonamiStoryEquipItemData> list = new List<HonamiStoryEquipItemData>();
		List<HonamiStoryEquipItemData> list2 = new List<HonamiStoryEquipItemData>();
		while (num < itemList.Count && list.Count < length)
		{
			HonamiStoryEquipItemData honamiStoryEquipItemData = itemList[num] as HonamiStoryEquipItemData;
			if (ignoreSet.Contains(honamiStoryEquipItemData))
			{
				num++;
			}
			else
			{
				int groupId = honamiStoryEquipItemData.GetGroupId();
				if (groupId != 0 && !hashSet.Contains(groupId))
				{
					list.Add(honamiStoryEquipItemData);
					hashSet.Add(groupId);
				}
				else
				{
					list2.Add(honamiStoryEquipItemData);
				}
				num++;
			}
		}
		list2.Sort(new Comparison<HonamiStoryEquipItemData>(this.ItemSortNoPlus));
		return this.CompareList(list, list2, length);
	}

	// Token: 0x0600EDCB RID: 60875 RVA: 0x0038A508 File Offset: 0x00388708
	private List<HonamiStoryEquipItemData> CompareList(List<HonamiStoryEquipItemData> goodItemList, List<HonamiStoryEquipItemData> badItemList, int length)
	{
		List<HonamiStoryEquipItemData> list = new List<HonamiStoryEquipItemData>();
		int num = 0;
		int num2 = 0;
		while ((num < goodItemList.Count || num2 < badItemList.Count) && list.Count < length)
		{
			if (num < goodItemList.Count && num2 < badItemList.Count)
			{
				bool flag = this.GetPower(goodItemList[num], true) >= this.GetPower(badItemList[num2], false);
				list.Add(flag ? goodItemList[num] : badItemList[num2]);
				num += ((flag > false) ? 1 : 0);
				num2 += ((!flag) ? 1 : 0);
			}
			else if (num >= goodItemList.Count)
			{
				list.Add(badItemList[num2]);
				num2++;
			}
			else if (num2 >= badItemList.Count)
			{
				list.Add(goodItemList[num]);
				num++;
			}
		}
		return list;
	}

	// Token: 0x0600EDCC RID: 60876 RVA: 0x0038A5D8 File Offset: 0x003887D8
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	private ValueTuple<HashSet<int>, List<HonamiStoryEquipItemData>> GetLastList(List<HonamiStoryEquipItemData> itemList, HashSet<int> groupList, int length)
	{
		HashSet<int> hashSet = new HashSet<int>(groupList);
		List<HonamiStoryEquipItemData> list = new List<HonamiStoryEquipItemData>();
		List<HonamiStoryEquipItemData> list2 = new List<HonamiStoryEquipItemData>();
		foreach (HonamiStoryEquipItemData honamiStoryEquipItemData in itemList)
		{
			if (honamiStoryEquipItemData.GetRoleId() == this.RoleId && this.RoleId != 0)
			{
				if (hashSet.Contains(honamiStoryEquipItemData.GetGroupId()))
				{
					list2.Add(honamiStoryEquipItemData);
				}
				else
				{
					hashSet.Add(honamiStoryEquipItemData.GetGroupId());
					list.Add(honamiStoryEquipItemData);
				}
			}
			else
			{
				list.Add(honamiStoryEquipItemData);
			}
		}
		List<HonamiStoryEquipItemData> list3 = this.CompareList(list, list2, length);
		foreach (HonamiStoryEquipItemData honamiStoryEquipItemData2 in list3)
		{
			if (honamiStoryEquipItemData2.GetGroupId() != 0)
			{
				groupList.Add(honamiStoryEquipItemData2.GetGroupId());
			}
		}
		return new ValueTuple<HashSet<int>, List<HonamiStoryEquipItemData>>(groupList, list3);
	}

	// Token: 0x0600EDCD RID: 60877 RVA: 0x0038A6E4 File Offset: 0x003888E4
	public List<int> ApplyQuickEquip(HashSet<HonamiStoryItemDataBase> itemSet, HonamiStoryBagUpdateContext playerContext, HonamiStoryBagUpdateContext bagContext, HonamiStoryBagUpdateContext pickContext)
	{
		int honamiStoryPluginPosition = this.RoleData.GetHonamiStoryPluginPosition(0);
		List<int> list = new List<int>();
		HonamiStoryBackpackData honamiStoryBackpackData = HonamiStoryUtil.CheckInHonamiStoryDungeon() ? HonamiStoryModel.Instance.GetBackPackData(2, false) : null;
		for (int i = 0; i < this.BestResult.Count; i++)
		{
			int num = honamiStoryPluginPosition + i;
			HonamiStoryItemDataBase honamiStoryItemDataBase = this.BestResult[i];
			if (itemSet.Contains(honamiStoryItemDataBase) && num == honamiStoryItemDataBase.GetPosition())
			{
				itemSet.Remove(honamiStoryItemDataBase);
			}
			else if (itemSet.Contains(honamiStoryItemDataBase))
			{
				itemSet.Remove(honamiStoryItemDataBase);
				HonamiStoryBagUpdateInfo honamiStoryItemSwapInfo = HonamiStoryUtil.GetHonamiStoryItemSwapInfo(honamiStoryItemDataBase, num);
				playerContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemSwapInfo);
			}
			else
			{
				HonamiStoryBagUpdateInfo honamiStoryItemRemoveInfo = HonamiStoryUtil.GetHonamiStoryItemRemoveInfo(honamiStoryItemDataBase);
				if (honamiStoryBackpackData != null)
				{
					if (honamiStoryBackpackData.GetItemDataByInstanceId(honamiStoryItemDataBase.GetIncId(), false) != null)
					{
						list.Add(honamiStoryItemDataBase.GetPosition());
						bagContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemRemoveInfo);
					}
					else
					{
						pickContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemRemoveInfo);
					}
				}
				else
				{
					list.Add(honamiStoryItemDataBase.GetPosition());
					bagContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemRemoveInfo);
				}
				HonamiStoryBagUpdateInfo honamiStoryItemAddInfo = HonamiStoryUtil.GetHonamiStoryItemAddInfo(honamiStoryItemDataBase, num);
				playerContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemAddInfo);
			}
		}
		return list;
	}

	// Token: 0x04006E4A RID: 28234
	public int RoleId;

	// Token: 0x04006E4B RID: 28235
	public HonamiStoryRoleEquipData RoleData;

	// Token: 0x04006E4C RID: 28236
	public List<int> SuitNeedList = new List<int>();

	// Token: 0x04006E4D RID: 28237
	public Dictionary<int, List<int>> SuitNeedMap = new Dictionary<int, List<int>>();

	// Token: 0x04006E4E RID: 28238
	public int SlotUnlockCount;

	// Token: 0x04006E4F RID: 28239
	private List<int> WeaponTags = new List<int>();

	// Token: 0x04006E50 RID: 28240
	private readonly Dictionary<int, List<HonamiStoryItemDataBase>> SortMap = new Dictionary<int, List<HonamiStoryItemDataBase>>();

	// Token: 0x04006E51 RID: 28241
	public List<HonamiStoryItemDataBase> BestResult = new List<HonamiStoryItemDataBase>();

	// Token: 0x04006E52 RID: 28242
	public int BestPower;

	// Token: 0x04006E53 RID: 28243
	public int RealBestPower;

	// Token: 0x04006E54 RID: 28244
	private readonly HonamiSortOrderListClass SortOrder = new HonamiSortOrderListClass();
}
