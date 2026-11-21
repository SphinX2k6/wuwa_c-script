using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.HonamiStory.Data;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x0200134C RID: 4940
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class HonamiStoryModel : ModelBase
{
	// Token: 0x0600C2A4 RID: 49828 RVA: 0x00399D41 File Offset: 0x00397F41
	protected override bool OnInit()
	{
		this.ActivityData = null;
		this.ItemDataMap.Clear();
		this.AddOpenViewCheck();
		return true;
	}

	// Token: 0x0600C2A5 RID: 49829 RVA: 0x00399D5C File Offset: 0x00397F5C
	protected override bool OnClear()
	{
		this.RemoveOpenViewCheck();
		return true;
	}

	// Token: 0x0600C2A6 RID: 49830 RVA: 0x00399D68 File Offset: 0x00397F68
	private void AddOpenViewCheck()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.HonamiStoryBackpackView, new Func<EUiViewName, object, bool>(HonamiStoryController.Instance.CanOpenBackpack), "HonamiStoryController.CanOpenView");
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.HonamiStoryPickUpBackpackView, new Func<EUiViewName, object, bool>(HonamiStoryController.Instance.CanOpenBackpack), "HonamiStoryController.CanOpenView");
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.HonamiStoryPickUpMobileView, new Func<EUiViewName, object, bool>(HonamiStoryController.Instance.CanOpenBackpack), "HonamiStoryController.CanOpenView");
	}

	// Token: 0x0600C2A7 RID: 49831 RVA: 0x00399DE4 File Offset: 0x00397FE4
	private void RemoveOpenViewCheck()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.HonamiStoryBackpackView, new Func<EUiViewName, object, bool>(HonamiStoryController.Instance.CanOpenBackpack));
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.HonamiStoryPickUpBackpackView, new Func<EUiViewName, object, bool>(HonamiStoryController.Instance.CanOpenBackpack));
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.HonamiStoryPickUpMobileView, new Func<EUiViewName, object, bool>(HonamiStoryController.Instance.CanOpenBackpack));
	}

	// Token: 0x0600C2A8 RID: 49832 RVA: 0x00399E50 File Offset: 0x00398050
	protected override bool OnLeaveLevel()
	{
		this.CurTrackTaskData = null;
		this.CanSafeLeave = false;
		this.CacheShowSafeLeaveUpdate = false;
		this.PollutionLevel = 0;
		this.PollutionMaxLevel = 0;
		this.PollutionStarTime = 0f;
		Dictionary<int, IHonamiStoryPollution> pollutionLevelMap = this.PollutionLevelMap;
		if (pollutionLevelMap != null)
		{
			pollutionLevelMap.Clear();
		}
		this.PollutionWarningLevel = 0;
		this.PollutionDangerLevel = 0;
		this.PollutionLevelMap = null;
		this.MonsterBaseEnhanceLevel = 0;
		this.DangerLevel = 0;
		MapModel.Instance.ClearHonamiScanMarkInfo();
		return true;
	}

	// Token: 0x0600C2A9 RID: 49833 RVA: 0x00399ECA File Offset: 0x003980CA
	public void SetActivityData(HonamiStoryActivityData activityData)
	{
		this.ActivityData = activityData;
	}

	// Token: 0x0600C2AA RID: 49834 RVA: 0x00399ED4 File Offset: 0x003980D4
	[NullableContext(2)]
	public HonamiStoryActivityData GetActivityData(bool needErrorLog = true)
	{
		if (this.ActivityData == null)
		{
			if (needErrorLog)
			{
				Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.BB, "HonamiStoryActivityData is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return null;
		}
		return this.ActivityData;
	}

	// Token: 0x0600C2AB RID: 49835 RVA: 0x00399F13 File Offset: 0x00398113
	public HonamiStoryPlayerData GetPlayerData()
	{
		return this.PlayerData;
	}

	// Token: 0x0600C2AC RID: 49836 RVA: 0x00399F1C File Offset: 0x0039811C
	public void InitActivityInfo(int activityId, HonamiStoryActivityInfo activityInfo)
	{
		this.ActivityId = activityId;
		this.InitPlayerInfo(activityId, activityInfo.HonamiStoryPlayerBagInfo);
		this.InitBackPackInfo(activityInfo.HonamiStoryPlayerBagInfo.Warehouse);
		this.InitTechNodeData();
		this.RefreshTalentInfos(activityInfo.HonamiStoryTalentInfos);
		this.UpdateLiefSupport(activityInfo.LifeSupportLevel);
	}

	// Token: 0x0600C2AD RID: 49837 RVA: 0x00399F6C File Offset: 0x0039816C
	public void UpdateActivityInfo(int activityId, HonamiStoryActivityInfo activityInfo)
	{
		this.UpdatePlayerInfo(activityId, activityInfo.HonamiStoryPlayerBagInfo);
		this.UpdateBackPackInfo(activityInfo.HonamiStoryPlayerBagInfo.Warehouse);
		this.RefreshTalentInfos(activityInfo.HonamiStoryTalentInfos);
		this.UpdateLiefSupport(activityInfo.LifeSupportLevel);
	}

	// Token: 0x0600C2AE RID: 49838 RVA: 0x00399FA4 File Offset: 0x003981A4
	private void UpdateLiefSupport(int curLevel)
	{
		this.PlayerData.SetLifeSupportLevel(curLevel);
	}

	// Token: 0x0600C2AF RID: 49839 RVA: 0x00399FB4 File Offset: 0x003981B4
	[NullableContext(2)]
	private void InitPlayerInfo(int activityId, HonamiStoryPlayerBagInfo playerInfo)
	{
		if (playerInfo == null)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.BB, "InitPlayerBagInfo 无效playerInfo", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.PlayerBackpackData = new HonamiStoryPlayerBackpackData();
		this.PlayerBackpackData.Init(playerInfo);
		foreach (HonamiStoryWeapon honamiStoryWeapon in HonamiStoryConfig.Instance.GetHonamiStoryWeaponConfigList(activityId))
		{
			HonamiStoryWeaponData value = new HonamiStoryWeaponData(honamiStoryWeapon.Id);
			this.WeaponDataMap[honamiStoryWeapon.Id] = value;
		}
		this.UpdateWeaponDataList(playerInfo.UnlockWeapon);
	}

	// Token: 0x0600C2B0 RID: 49840 RVA: 0x0039A068 File Offset: 0x00398268
	[NullableContext(2)]
	private void UpdatePlayerInfo(int activityId, HonamiStoryPlayerBagInfo playerInfo)
	{
		if (playerInfo == null)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.BB, "InitPlayerBagInfo 无效playerInfo", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.PlayerBackpackData.RefreshEquipInfo(playerInfo.HonamiStoryRackInfos);
		if (playerInfo.EquipRack != null)
		{
			this.PlayerBackpackData.RefreshGridItemInfo(playerInfo.EquipRack.HonamiStoryBagItemInfos);
		}
		foreach (HonamiStoryWeapon honamiStoryWeapon in HonamiStoryConfig.Instance.GetHonamiStoryWeaponConfigList(activityId))
		{
			HonamiStoryWeaponData value = new HonamiStoryWeaponData(honamiStoryWeapon.Id);
			this.WeaponDataMap[honamiStoryWeapon.Id] = value;
		}
		this.UpdateWeaponDataList(playerInfo.UnlockWeapon);
	}

	// Token: 0x0600C2B1 RID: 49841 RVA: 0x0039A134 File Offset: 0x00398334
	public void UpdateRoleList(List<int> roleList)
	{
		this.PlayerBackpackData.RefreshRoleInfo(roleList);
	}

	// Token: 0x0600C2B2 RID: 49842 RVA: 0x0039A142 File Offset: 0x00398342
	public void UpdateRoleByPosition(int roleId, int position)
	{
		this.PlayerBackpackData.RefreshRoleInfoByPosition(roleId, position);
	}

	// Token: 0x0600C2B3 RID: 49843 RVA: 0x0039A151 File Offset: 0x00398351
	public void UpdateWeaponByPosition(int weaponId, int position)
	{
		this.PlayerBackpackData.RefreshWeaponInfoByPosition(weaponId, position);
	}

	// Token: 0x0600C2B4 RID: 49844 RVA: 0x0039A160 File Offset: 0x00398360
	public void UpdatePlayerBackPack(HonamiStoryBagUpdateContext updateContext)
	{
		this.PlayerBackpackData.UpdateByContext(updateContext.HonamiStoryBagUpdateInfo);
	}

	// Token: 0x0600C2B5 RID: 49845 RVA: 0x0039A173 File Offset: 0x00398373
	public HonamiStoryPlayerBackpackData GetPlayerBackpackData()
	{
		return this.PlayerBackpackData;
	}

	// Token: 0x0600C2B6 RID: 49846 RVA: 0x0039A17C File Offset: 0x0039837C
	public int[] GetAllRoleIdList()
	{
		List<int> list = new List<int>();
		foreach (HonamiStoryRoleEquipData honamiStoryRoleEquipData in this.PlayerBackpackData.GetRoleEquipDataList(true))
		{
			list.Add(honamiStoryRoleEquipData.GetRoleId());
		}
		return list.ToArray();
	}

	// Token: 0x0600C2B7 RID: 49847 RVA: 0x0039A1E8 File Offset: 0x003983E8
	[NullableContext(2)]
	public HonamiStoryRoleEquipData GetRoleItemDataByPosition(int position)
	{
		return this.PlayerBackpackData.GetRoleItemDataByPosition(position);
	}

	// Token: 0x0600C2B8 RID: 49848 RVA: 0x0039A1F6 File Offset: 0x003983F6
	[NullableContext(2)]
	public HonamiStoryRoleEquipData GetRoleEquipDataByPosition(int position)
	{
		return this.PlayerBackpackData.GetRoleEquipDataByPosition(position);
	}

	// Token: 0x0600C2B9 RID: 49849 RVA: 0x0039A204 File Offset: 0x00398404
	[NullableContext(2)]
	public HonamiStoryRoleEquipData GetRoleEquipDataByRoleId(int roleId)
	{
		return this.PlayerBackpackData.GetRoleEquipDataByRoleId(roleId);
	}

	// Token: 0x0600C2BA RID: 49850 RVA: 0x0039A214 File Offset: 0x00398414
	[NullableContext(2)]
	public HonamiStoryItemDataBase GetEquipItemDataByIncId(int incId)
	{
		foreach (HonamiStoryRoleEquipData honamiStoryRoleEquipData in this.PlayerBackpackData.GetRoleEquipDataList(true))
		{
			foreach (HonamiStoryRoleEquipSlotData honamiStoryRoleEquipSlotData in honamiStoryRoleEquipData.GetSlotList())
			{
				HonamiStoryEquipItemData itemData = honamiStoryRoleEquipSlotData.GetItemData();
				if (itemData != null && itemData.GetIncId() == incId)
				{
					return itemData;
				}
			}
		}
		return null;
	}

	// Token: 0x0600C2BB RID: 49851 RVA: 0x0039A2B8 File Offset: 0x003984B8
	public EHonamiStoryWeaponType[] GetWeaponTypeList()
	{
		HashSet<EHonamiStoryWeaponType> hashSet = new HashSet<EHonamiStoryWeaponType>();
		bool flag = HonamiStoryUtil.CheckInHonamiStoryDungeon();
		foreach (HonamiStoryWeaponData honamiStoryWeaponData in this.WeaponDataMap.Values)
		{
			if (flag)
			{
				if (this.GetWeaponEquipState(honamiStoryWeaponData.WeaponId) != null)
				{
					hashSet.Add(honamiStoryWeaponData.WeaponType);
				}
			}
			else
			{
				hashSet.Add(honamiStoryWeaponData.WeaponType);
			}
		}
		List<EHonamiStoryWeaponType> list = new List<EHonamiStoryWeaponType>();
		foreach (EHonamiStoryWeaponType item in hashSet)
		{
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x0600C2BC RID: 49852 RVA: 0x0039A394 File Offset: 0x00398594
	public List<HonamiStoryWeaponData> GetWeaponDataListByType(EHonamiStoryWeaponType type)
	{
		List<HonamiStoryWeaponData> list = new List<HonamiStoryWeaponData>();
		foreach (HonamiStoryWeaponData honamiStoryWeaponData in this.WeaponDataMap.Values)
		{
			if (honamiStoryWeaponData.WeaponType == type)
			{
				list.Add(honamiStoryWeaponData);
			}
		}
		return list;
	}

	// Token: 0x0600C2BD RID: 49853 RVA: 0x0039A3FC File Offset: 0x003985FC
	public void UpdateWeaponDataList(IEnumerable<int> weaponIdList)
	{
		foreach (int weaponId in weaponIdList)
		{
			HonamiStoryWeaponData weaponData = this.GetWeaponData(weaponId);
			if (weaponData != null)
			{
				weaponData.SetUnlock(true);
			}
		}
	}

	// Token: 0x0600C2BE RID: 49854 RVA: 0x0039A450 File Offset: 0x00398650
	[NullableContext(2)]
	public HonamiStoryWeaponData GetWeaponData(int weaponId)
	{
		HonamiStoryWeaponData result;
		if (this.WeaponDataMap.TryGetValue(weaponId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600C2BF RID: 49855 RVA: 0x0039A470 File Offset: 0x00398670
	public EHonamiStoryWeaponState CheckSelectWeaponState(int weaponId, HonamiStoryRoleEquipData equipData)
	{
		int weaponId2 = equipData.GetWeaponId();
		if (weaponId2 == 0)
		{
			return EHonamiStoryWeaponState.Equip;
		}
		if (weaponId == weaponId2)
		{
			return EHonamiStoryWeaponState.Remove;
		}
		return EHonamiStoryWeaponState.Change;
	}

	// Token: 0x0600C2C0 RID: 49856 RVA: 0x0039A490 File Offset: 0x00398690
	[NullableContext(2)]
	public HonamiStoryRoleEquipData GetWeaponEquipState(int weaponId)
	{
		if (weaponId == 0)
		{
			return null;
		}
		foreach (HonamiStoryRoleEquipData honamiStoryRoleEquipData in this.PlayerBackpackData.GetRoleEquipDataList(true))
		{
			if (honamiStoryRoleEquipData.GetWeaponId() == weaponId)
			{
				return honamiStoryRoleEquipData;
			}
		}
		return null;
	}

	// Token: 0x0600C2C1 RID: 49857 RVA: 0x0039A4F8 File Offset: 0x003986F8
	public void SetTotalRevenueInternal(int value)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.HonamiStory;
		ELogAuthor author = ELogAuthor.LRC;
		string message = "SetTotalRevenueInternal";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.TotalRevenueInternal = value;
	}

	// Token: 0x170012FD RID: 4861
	// (get) Token: 0x0600C2C2 RID: 49858 RVA: 0x0039A53B File Offset: 0x0039873B
	public int TotalRevenue
	{
		get
		{
			if (this.TotalRevenueInternal >= 99999999)
			{
				return 99999999;
			}
			return this.TotalRevenueInternal;
		}
	}

	// Token: 0x0600C2C3 RID: 49859 RVA: 0x0039A556 File Offset: 0x00398756
	[NullableContext(2)]
	public HonamiStoryBackpackData GetInventory()
	{
		return this.WareHouseBackpackData;
	}

	// Token: 0x0600C2C4 RID: 49860 RVA: 0x0039A55E File Offset: 0x0039875E
	public void SetInventory(HonamiStoryBackpackData newData)
	{
		this.WareHouseBackpackData = newData;
	}

	// Token: 0x0600C2C5 RID: 49861 RVA: 0x0039A567 File Offset: 0x00398767
	public bool CheckIsNewInInventory()
	{
		return this.WareHouseBackpackData != null && (this.WareHouseBackpackData.CheckIsNewInBackpack() || (LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryWeaponUnlockSet, null) ?? new HashSet<int>()).Count > 0);
	}

	// Token: 0x0600C2C6 RID: 49862 RVA: 0x0039A5A0 File Offset: 0x003987A0
	private void InitTechNodeData()
	{
		this.TechNodeDataMap.Clear();
		this.TechAreaDataMap.Clear();
		foreach (HonamiStoryTalent config in HonamiStoryConfig.Instance.GetHonamiStoryTalentConfigList(this.ActivityId))
		{
			HonamiStoryTechNodeData value = new HonamiStoryTechNodeData(config);
			this.TechNodeDataMap[config.Id] = value;
			HonamiStoryTechAreaData honamiStoryTechAreaData;
			if (!this.TechAreaDataMap.TryGetValue(config.Area, out honamiStoryTechAreaData))
			{
				honamiStoryTechAreaData = new HonamiStoryTechAreaData();
				honamiStoryTechAreaData.AreaId = config.Area;
				honamiStoryTechAreaData.NodeIds = new List<int>();
			}
			honamiStoryTechAreaData.NodeIds.Add(config.Id);
			this.TechAreaDataMap[honamiStoryTechAreaData.AreaId] = honamiStoryTechAreaData;
		}
	}

	// Token: 0x0600C2C7 RID: 49863 RVA: 0x0039A67C File Offset: 0x0039887C
	public bool CheckNodeCanActiveAndIsEnough(HonamiStoryTechNodeData data)
	{
		if (data == null)
		{
			return false;
		}
		if (data.GetNodeStatus != ENodeStatus.CanActive)
		{
			return false;
		}
		Dictionary<int, int> dictionary = data.GetConfig.ConsumeItems();
		if (dictionary == null)
		{
			return true;
		}
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			if (InventoryModel.Instance.GetItemCountByConfigId(keyValuePair.Key, 0) < keyValuePair.Value)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600C2C8 RID: 49864 RVA: 0x0039A70C File Offset: 0x0039890C
	public void RefreshTalentInfos(IReadOnlyList<HonamiStoryTalentInfo> techNodeList)
	{
		if (techNodeList == null)
		{
			return;
		}
		foreach (HonamiStoryTalentInfo honamiStoryTalentInfo in techNodeList)
		{
			int talentId = honamiStoryTalentInfo.TalentId;
			int status = honamiStoryTalentInfo.Status;
			HonamiStoryTechNodeData honamiStoryTechNodeData;
			if (this.TechNodeDataMap.TryGetValue(talentId, out honamiStoryTechNodeData))
			{
				honamiStoryTechNodeData.SetNodeStatus(status);
			}
		}
	}

	// Token: 0x0600C2C9 RID: 49865 RVA: 0x0039A774 File Offset: 0x00398974
	[NullableContext(2)]
	public HonamiStoryTechNodeData GetTechNodeData(int id)
	{
		HonamiStoryTechNodeData result;
		if (!this.TechNodeDataMap.TryGetValue(id, out result))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryTechNodeData 无效Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return result;
	}

	// Token: 0x0600C2CA RID: 49866 RVA: 0x0039A7C4 File Offset: 0x003989C4
	[NullableContext(2)]
	public HonamiStoryTechAreaData GetTechAreaData(int id)
	{
		HonamiStoryTechAreaData result;
		if (!this.TechAreaDataMap.TryGetValue(id, out result))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryTechAreaData 无效Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return result;
	}

	// Token: 0x170012FE RID: 4862
	// (get) Token: 0x0600C2CB RID: 49867 RVA: 0x0039A814 File Offset: 0x00398A14
	public HonamiStoryTechAreaData[] GetTechAreaDataList
	{
		get
		{
			List<HonamiStoryTechAreaData> list = new List<HonamiStoryTechAreaData>();
			foreach (KeyValuePair<int, HonamiStoryTechAreaData> keyValuePair in this.TechAreaDataMap)
			{
				if (keyValuePair.Key != 0)
				{
					list.Add(keyValuePair.Value);
				}
			}
			return list.ToArray();
		}
	}

	// Token: 0x0600C2CC RID: 49868 RVA: 0x0039A884 File Offset: 0x00398A84
	public void CheckCurrentTalentTreeNode()
	{
		HonamiStoryTechNodeData honamiStoryTechNodeData = null;
		HonamiStoryTechNodeData honamiStoryTechNodeData2 = null;
		List<HonamiStoryTechNodeData> list = new List<HonamiStoryTechNodeData>();
		foreach (HonamiStoryTechNodeData item in this.TechNodeDataMap.Values)
		{
			list.Add(item);
		}
		list.Sort((HonamiStoryTechNodeData a, HonamiStoryTechNodeData b) => a.GetConfig.IndexSortId - b.GetConfig.IndexSortId);
		foreach (HonamiStoryTechNodeData honamiStoryTechNodeData3 in list)
		{
			if (honamiStoryTechNodeData3.GetNodeStatus != ENodeStatus.IsActive)
			{
				if (honamiStoryTechNodeData3.GetNodeStatus == ENodeStatus.CanActive)
				{
					if (this.CheckNodeCanActiveAndIsEnough(honamiStoryTechNodeData3))
					{
						this.CurrentSelectNode = honamiStoryTechNodeData3;
						return;
					}
					if (honamiStoryTechNodeData == null)
					{
						honamiStoryTechNodeData = honamiStoryTechNodeData3;
					}
				}
				else if (honamiStoryTechNodeData2 == null)
				{
					honamiStoryTechNodeData2 = honamiStoryTechNodeData3;
				}
			}
		}
		this.CurrentSelectNode = (honamiStoryTechNodeData ?? honamiStoryTechNodeData2);
		if (this.CurrentSelectNode == null)
		{
			this.CurrentSelectNode = ((list.Count > 0) ? list[0] : null);
		}
	}

	// Token: 0x0600C2CD RID: 49869 RVA: 0x0039A9A8 File Offset: 0x00398BA8
	[NullableContext(2)]
	public HonamiStoryTechNodeData GetFirstTechnologyNode()
	{
		HonamiStoryTechNodeData result = null;
		foreach (KeyValuePair<int, HonamiStoryTechNodeData> keyValuePair in this.TechNodeDataMap)
		{
			if (keyValuePair.Value.GetConfig.Area == 0)
			{
				result = keyValuePair.Value;
			}
		}
		return result;
	}

	// Token: 0x0600C2CE RID: 49870 RVA: 0x0039AA18 File Offset: 0x00398C18
	public bool IsTechHasRedDot()
	{
		foreach (HonamiStoryTechNodeData data in this.TechNodeDataMap.Values)
		{
			if (this.CheckNodeCanActiveAndIsEnough(data))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600C2CF RID: 49871 RVA: 0x0039AA7C File Offset: 0x00398C7C
	public HonamiStoryTechNodeData[] GetAllTechNodeDataList()
	{
		List<HonamiStoryTechNodeData> list = new List<HonamiStoryTechNodeData>();
		foreach (HonamiStoryTechNodeData item in this.TechNodeDataMap.Values)
		{
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x0600C2D0 RID: 49872 RVA: 0x0039AAE0 File Offset: 0x00398CE0
	public HonamiStoryTechAreaData[] GetAllTechAreaDataList()
	{
		List<HonamiStoryTechAreaData> list = new List<HonamiStoryTechAreaData>();
		foreach (HonamiStoryTechAreaData item in this.TechAreaDataMap.Values)
		{
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x0600C2D1 RID: 49873 RVA: 0x0039AB44 File Offset: 0x00398D44
	public HonamiStoryTechNodeData[] GetAllActiveTechNodeDataList()
	{
		List<HonamiStoryTechNodeData> list = new List<HonamiStoryTechNodeData>();
		foreach (HonamiStoryTechNodeData honamiStoryTechNodeData in this.TechNodeDataMap.Values)
		{
			if (honamiStoryTechNodeData.GetNodeStatus == ENodeStatus.IsActive)
			{
				list.Add(honamiStoryTechNodeData);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600C2D2 RID: 49874 RVA: 0x0039ABB4 File Offset: 0x00398DB4
	public int GetSubTaskBonusDataList()
	{
		HonamiStoryTechNodeData[] allActiveTechNodeDataList = this.GetAllActiveTechNodeDataList();
		int num = 1;
		HonamiStoryTechNodeData[] array = allActiveTechNodeDataList;
		for (int i = 0; i < array.Length; i++)
		{
			foreach (int id in array[i].GetConfig.EffectIds())
			{
				HonamiStoryEffect? effectConfig = HonamiStoryConfig.Instance.GetEffectConfig(id);
				if (effectConfig != null && effectConfig.Value.EffectType == 5)
				{
					int num2 = int.Parse(effectConfig.Value.Param()[0]);
					num += num2 / 10000;
				}
			}
		}
		return num;
	}

	// Token: 0x0600C2D3 RID: 49875 RVA: 0x0039AC54 File Offset: 0x00398E54
	public bool IsShopHasRedDot()
	{
		if (this.ActivityData == null)
		{
			return false;
		}
		int shopId = this.ActivityData.ShopId;
		return PayShopModel.Instance.CheckShopItemCheckFlag((PayShopDefine.EPayShopTabType)shopId, 1);
	}

	// Token: 0x0600C2D4 RID: 49876 RVA: 0x0039AC84 File Offset: 0x00398E84
	public HonamiStoryOutDialog? GetRandomDialogData(int dialogType)
	{
		IEnumerable<HonamiStoryOutDialog> honamiStoryOutDialogList = HonamiStoryConfig.Instance.GetHonamiStoryOutDialogList(this.ActivityId);
		List<HonamiStoryOutDialog> list = new List<HonamiStoryOutDialog>();
		foreach (HonamiStoryOutDialog item in honamiStoryOutDialogList)
		{
			if (item.Type == dialogType)
			{
				list.Add(item);
			}
		}
		int count = list.Count;
		if (count == 0)
		{
			return null;
		}
		if (count == 1)
		{
			return new HonamiStoryOutDialog?(list[0]);
		}
		int index = (int)Math.Floor(new Random().NextDouble() * (double)count);
		return new HonamiStoryOutDialog?(list[index]);
	}

	// Token: 0x0600C2D5 RID: 49877 RVA: 0x0039AD34 File Offset: 0x00398F34
	public CSharpScript.Game.Module.HonamiStory.Data.HonamiStoryWeaponSuitData GetWeaponSuitData(int suitId)
	{
		CSharpScript.Game.Module.HonamiStory.Data.HonamiStoryWeaponSuitData result;
		if (!this.WeaponSuitMap.TryGetValue(suitId, out result))
		{
			result = (this.WeaponSuitMap[suitId] = new CSharpScript.Game.Module.HonamiStory.Data.HonamiStoryWeaponSuitData(suitId));
		}
		return result;
	}

	// Token: 0x0600C2D6 RID: 49878 RVA: 0x0039AD68 File Offset: 0x00398F68
	public int GetParentRoleId(int id)
	{
		int baseRoleId;
		if (!this.RoleParentMap.TryGetValue(id, out baseRoleId))
		{
			baseRoleId = RoleConfig.Instance.GetBaseRoleId(id);
			this.RoleParentMap[id] = baseRoleId;
		}
		return this.RoleParentMap[id];
	}

	// Token: 0x0600C2D7 RID: 49879 RVA: 0x0039ADAC File Offset: 0x00398FAC
	public bool CheckItemPlayerAlreadyPick(int incId)
	{
		HonamiStoryBackpackData backPackData = this.GetBackPackData(2, false);
		HonamiStoryPlayerBackpackData playerBackpackData = this.GetPlayerBackpackData();
		return backPackData.GetItemDataByInstanceId(incId, false) != null || playerBackpackData.CheckItemByIncId(incId);
	}

	// Token: 0x0600C2D8 RID: 49880 RVA: 0x0039ADDC File Offset: 0x00398FDC
	public HonamiStoryItemDataBase CreateHonamiStoryItemData(HonamiStoryItemInfo itemInfo, [Nullable(2)] HonamiStoryPosInfo posInfo = null)
	{
		HonamiStoryItemDataBase honamiStoryItemDataBase;
		if (!this.ItemDataMap.TryGetValue(itemInfo.IncrId, out honamiStoryItemDataBase))
		{
			honamiStoryItemDataBase = this.CreateItemData(itemInfo.HonamiStoryItemId);
		}
		honamiStoryItemDataBase.Init(itemInfo);
		honamiStoryItemDataBase.UpdatePositionInfo(posInfo);
		this.ItemDataMap[honamiStoryItemDataBase.GetIncId()] = honamiStoryItemDataBase;
		return honamiStoryItemDataBase;
	}

	// Token: 0x0600C2D9 RID: 49881 RVA: 0x0039AE2C File Offset: 0x0039902C
	private HonamiStoryItemDataBase CreateItemData(int itemId)
	{
		if (HonamiStoryConfig.Instance.GetHonamiStoryItem(itemId).Value.ItemType == 1)
		{
			return new HonamiStoryEquipItemData();
		}
		return new HonamiStoryItemDataBase();
	}

	// Token: 0x0600C2DA RID: 49882 RVA: 0x0039AE64 File Offset: 0x00399064
	[NullableContext(2)]
	public HonamiStoryItemDataBase GetItemData(int instanceId)
	{
		HonamiStoryItemDataBase result;
		if (!this.ItemDataMap.TryGetValue(instanceId, out result))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.BB;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 1);
			defaultInterpolatedStringHandler.AppendLiteral("ItemDataMap not found instanceId: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(instanceId);
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return result;
	}

	// Token: 0x0600C2DB RID: 49883 RVA: 0x0039AEC4 File Offset: 0x003990C4
	public void RemoveItemData(int instanceId)
	{
		if (this.GetItemData(instanceId) == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.BB;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 1);
			defaultInterpolatedStringHandler.AppendLiteral("ItemDataMap not found instanceId: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(instanceId);
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x0600C2DC RID: 49884 RVA: 0x0039AF1C File Offset: 0x0039911C
	public List<HonamiStoryQuestDataBase> GetQuestDataListByQuestType(EHonamiStoryQuestType taskType)
	{
		if (this.ActivityData == null)
		{
			return new List<HonamiStoryQuestDataBase>();
		}
		List<HonamiStoryQuestDataBase> result;
		if (this.QuestDataMapCache.TryGetValue(taskType, out result))
		{
			return result;
		}
		if (taskType == EHonamiStoryQuestType.Main)
		{
			List<HonamiStoryQuestDataBase> list = new List<HonamiStoryQuestDataBase>();
			list.Add(new HonamiStoryMainQuestData());
			this.QuestDataMapCache[taskType] = list;
		}
		else if (taskType == EHonamiStoryQuestType.Sub)
		{
			List<HonamiStorySubQuestData> subQuestTaskDataList = this.ActivityData.GetSubQuestTaskDataList();
			this.QuestDataMapCache[taskType] = new List<HonamiStoryQuestDataBase>(subQuestTaskDataList);
		}
		return this.QuestDataMapCache[taskType];
	}

	// Token: 0x0600C2DD RID: 49885 RVA: 0x0039AF9C File Offset: 0x0039919C
	public void SetSubQuestTrack(HonamiStoryQuestDataBase taskData)
	{
		if (taskData.TaskType != EHonamiStoryQuestType.Sub)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
			defaultInterpolatedStringHandler.AppendLiteral("SetSubQuestTrack 任务类型错误: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(taskData.Id);
			instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (taskData.IsFinished())
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.HonamiStory;
			ELogAuthor author2 = ELogAuthor.LRC;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
			defaultInterpolatedStringHandler.AppendLiteral("SetSubQuestTrack 任务已结束: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(taskData.Id);
			instance2.Warn(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		HonamiStoryQuestDataBase curTrackTaskData = this.CurTrackTaskData;
		int? num = (curTrackTaskData != null) ? new int?(curTrackTaskData.Id) : null;
		int id = taskData.Id;
		bool flag = num.GetValueOrDefault() == id & num != null;
		HonamiStoryQuestDataBase curTrackTaskData2 = this.CurTrackTaskData;
		bool flag2 = curTrackTaskData2 != null && curTrackTaskData2.DoMapTrack(false);
		if (this.CurTrackTaskData != null)
		{
			Log.Instance.Info(ELogModule.HonamiStory, ELogAuthor.LRC, "SetSubQuestTrack 取消追踪任务" + (flag2 ? "成功" : "失败") + ": " + ConfigMultiTextLang.GetLocalTextNew(this.CurTrackTaskData.GetNameKey(), null), default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		if (flag2)
		{
			this.CurTrackTaskData = null;
		}
		if (!flag)
		{
			bool flag3 = taskData.DoMapTrack(true);
			Log.Instance.Info(ELogModule.HonamiStory, ELogAuthor.LRC, "SetSubQuestTrack 设置追踪任务" + (flag3 ? "成功" : "失败") + ": " + ConfigMultiTextLang.GetLocalTextNew(taskData.GetNameKey(), null), default(ReadOnlySpan<ValueTuple<string, object>>));
			if (flag3)
			{
				this.CurTrackTaskData = taskData;
			}
		}
	}

	// Token: 0x0600C2DE RID: 49886 RVA: 0x0039B14C File Offset: 0x0039934C
	public void InitSubQuestTrack()
	{
		if (this.CurTrackTaskData != null && !this.CurTrackTaskData.IsFinished())
		{
			return;
		}
		List<HonamiStoryQuestDataBase> questDataListByQuestType = this.GetQuestDataListByQuestType(EHonamiStoryQuestType.Sub);
		if (questDataListByQuestType == null || questDataListByQuestType.Count <= 0)
		{
			return;
		}
		foreach (HonamiStoryQuestDataBase honamiStoryQuestDataBase in questDataListByQuestType)
		{
			if (!honamiStoryQuestDataBase.IsFinished())
			{
				this.SetSubQuestTrack(honamiStoryQuestDataBase);
				break;
			}
		}
	}

	// Token: 0x0600C2DF RID: 49887 RVA: 0x0039B1D0 File Offset: 0x003993D0
	public void InitBackPackInfoList(IEnumerable<HonamiStoryBagInfo> backpackInfoList)
	{
		foreach (HonamiStoryBagInfo bagInfo in backpackInfoList)
		{
			this.InitBackPackInfo(bagInfo);
		}
	}

	// Token: 0x0600C2E0 RID: 49888 RVA: 0x0039B218 File Offset: 0x00399418
	[NullableContext(2)]
	public void InitBackPackInfo(HonamiStoryBagInfo bagInfo)
	{
		if (bagInfo == null)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.BB, "InitBackPackInfo 无效bagInfo", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (bagInfo.BagConfigId == 1)
		{
			HonamiStoryBackpackData honamiStoryBackpackData = new HonamiStoryBackpackData();
			this.SetInventory(honamiStoryBackpackData);
			honamiStoryBackpackData.Init(bagInfo);
			return;
		}
		HonamiStoryBackpackData honamiStoryBackpackData2 = this.GetBackPackData(bagInfo.BagConfigId, true);
		if (honamiStoryBackpackData2 == null)
		{
			if (bagInfo.BagConfigId != 3)
			{
				honamiStoryBackpackData2 = new HonamiStoryBackpackData();
			}
			else
			{
				honamiStoryBackpackData2 = new HonamiStoryPickupBoxData();
			}
			this.BackpackDataMap[bagInfo.BagConfigId] = honamiStoryBackpackData2;
		}
		else
		{
			honamiStoryBackpackData2.ClearBackpack();
		}
		honamiStoryBackpackData2.Init(bagInfo);
	}

	// Token: 0x0600C2E1 RID: 49889 RVA: 0x0039B2B0 File Offset: 0x003994B0
	[NullableContext(2)]
	public void UpdateBackPackInfo(HonamiStoryBagInfo bagInfo)
	{
		if (bagInfo == null)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.BB, "InitBackPackInfo 无效bagInfo", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (bagInfo.BagConfigId != 1)
		{
			HonamiStoryBackpackData honamiStoryBackpackData = this.GetBackPackData(bagInfo.BagConfigId, true);
			if (honamiStoryBackpackData == null)
			{
				if (bagInfo.BagConfigId != 3)
				{
					honamiStoryBackpackData = new HonamiStoryBackpackData();
				}
				else
				{
					honamiStoryBackpackData = new HonamiStoryPickupBoxData();
				}
				this.BackpackDataMap[bagInfo.BagConfigId] = honamiStoryBackpackData;
			}
			else
			{
				honamiStoryBackpackData.ClearBackpack();
			}
			honamiStoryBackpackData.Init(bagInfo);
			return;
		}
		if (this.WareHouseBackpackData == null)
		{
			HonamiStoryBackpackData honamiStoryBackpackData2 = new HonamiStoryBackpackData();
			this.SetInventory(honamiStoryBackpackData2);
			honamiStoryBackpackData2.Init(bagInfo);
			return;
		}
		this.WareHouseBackpackData.Init(bagInfo);
	}

	// Token: 0x0600C2E2 RID: 49890 RVA: 0x0039B35C File Offset: 0x0039955C
	public bool GetSkillDescMode()
	{
		return LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.HonamiStorySkillDescMode, false);
	}

	// Token: 0x0600C2E3 RID: 49891 RVA: 0x0039B369 File Offset: 0x00399569
	public void SetSkillDescMode(bool isSimple)
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.HonamiStorySkillDescMode, isSimple);
		EventSystem.Instance.Emit<bool>(EEventName.OnHonamiStorySkillDescModeChange, isSimple);
	}

	// Token: 0x0600C2E4 RID: 49892 RVA: 0x0039B388 File Offset: 0x00399588
	public void RemoveBackPack(int backpackId)
	{
		HonamiStoryBackpackData backPackData = this.GetBackPackData(backpackId, false);
		if (backPackData == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.BB;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
			defaultInterpolatedStringHandler.AppendLiteral("RemoveBackPack 无效backpackId: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(backpackId);
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		backPackData.ClearBackpack();
		this.BackpackDataMap.Remove(backpackId);
	}

	// Token: 0x0600C2E5 RID: 49893 RVA: 0x0039B3F4 File Offset: 0x003995F4
	public void UpdateBackpackInfo(HonamiStoryBagInfoUpdateNotify updateInfo)
	{
		foreach (HonamiStoryBagInfo honamiStoryBagInfo in updateInfo.HonamiStoryBagInfos)
		{
			HonamiStoryBackpackData backPackData = this.GetBackPackData(honamiStoryBagInfo.BagConfigId, false);
			backPackData.SetCapacity(honamiStoryBagInfo.BagSize);
			backPackData.Update(honamiStoryBagInfo.HonamiStoryBagItemInfos);
		}
	}

	// Token: 0x0600C2E6 RID: 49894 RVA: 0x0039B460 File Offset: 0x00399660
	public void UpdateBackpackSize(Dictionary<int, int> updateInfo)
	{
		foreach (KeyValuePair<int, int> keyValuePair in updateInfo)
		{
			int key = keyValuePair.Key;
			HonamiStoryBackpackData backPackData = this.GetBackPackData(key, false);
			if (backPackData != null)
			{
				backPackData.SetCapacity(keyValuePair.Value);
			}
		}
	}

	// Token: 0x0600C2E7 RID: 49895 RVA: 0x0039B4CC File Offset: 0x003996CC
	public void UpdateBackPackContext(IReadOnlyList<HonamiStoryBagUpdateContext> updateContext)
	{
		foreach (HonamiStoryBagUpdateContext honamiStoryBagUpdateContext in updateContext)
		{
			int backPackConfigId = honamiStoryBagUpdateContext.BackPackConfigId;
			if (backPackConfigId == 4)
			{
				this.UpdatePlayerBackPack(honamiStoryBagUpdateContext);
			}
			else
			{
				RepeatedField<HonamiStoryBagUpdateInfo> honamiStoryBagUpdateInfo = honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo;
				if (backPackConfigId == 1)
				{
					HonamiStoryBackpackData inventory = this.GetInventory();
					if (inventory != null)
					{
						inventory.UpdateByContext(honamiStoryBagUpdateInfo);
					}
				}
				else
				{
					this.GetBackPackData(backPackConfigId, false).UpdateByContext(honamiStoryBagUpdateInfo);
				}
			}
		}
	}

	// Token: 0x0600C2E8 RID: 49896 RVA: 0x0039B550 File Offset: 0x00399750
	[NullableContext(2)]
	public HonamiStoryBackpackData GetBackPackData(int backpackId, bool notLog = false)
	{
		if (backpackId == 1)
		{
			HonamiStoryBackpackData inventory = this.GetInventory();
			if (!notLog && inventory == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.HonamiStory;
				ELogAuthor author = ELogAuthor.BB;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
				defaultInterpolatedStringHandler.AppendLiteral("GetBackPackData 无效backpackId: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(backpackId);
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return inventory;
		}
		HonamiStoryBackpackData result;
		if (!this.BackpackDataMap.TryGetValue(backpackId, out result))
		{
			if (!notLog)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.HonamiStory;
				ELogAuthor author2 = ELogAuthor.BB;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
				defaultInterpolatedStringHandler.AppendLiteral("GetBackPackData 无效backpackId: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(backpackId);
				instance2.Error(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return null;
		}
		return result;
	}

	// Token: 0x0600C2E9 RID: 49897 RVA: 0x0039B604 File Offset: 0x00399804
	public bool IsPickUpViewOpened()
	{
		return UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryPickUpBackpackView) != null || UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryPickUpMobileView) != null;
	}

	// Token: 0x0600C2EA RID: 49898 RVA: 0x0039B62C File Offset: 0x0039982C
	public void TryPickUp(HonamiStoryItemDataBase itemDataBase, Entity entity)
	{
		HonamiStoryBackpackData backPackData = this.GetBackPackData(2, false);
		itemDataBase.SetBackpackWidth(backPackData.GetWidthCount());
		if (this.IsPickUpViewOpened())
		{
			this.IsPickingUp = false;
			PawnInteractNewComponent pawnInteractNewComponent = entity.CheckGetComponent<PawnInteractNewComponent>();
			if (pawnInteractNewComponent != null)
			{
				pawnInteractNewComponent.SetInteractionState(true, "HonamiStoryPickUp");
			}
			this.ClearPickUpQueue();
			this.PickedEntityId.Clear();
			return;
		}
		if (this.IsPickingUp)
		{
			using (List<IPickUpItemInfo>.Enumerator enumerator = this.PickUpItemDataQueue.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.ItemData.GetIncId() == itemDataBase.GetIncId())
					{
						return;
					}
				}
			}
			this.PickUpItemDataQueue.Add(new PickUpItemInfo
			{
				ItemData = itemDataBase,
				EntitySelf = entity
			});
			return;
		}
		this.PickedEntityId.Clear();
		this.IsPickingUp = true;
		this.PickUpItemDataQueue.Add(new PickUpItemInfo
		{
			ItemData = itemDataBase,
			EntitySelf = entity
		});
		this.OnPickUpEnd();
	}

	// Token: 0x0600C2EB RID: 49899 RVA: 0x0039B734 File Offset: 0x00399934
	public void OnPickUpEnd()
	{
		if (this.PickUpItemDataQueue.Count == 0)
		{
			this.IsPickingUp = false;
			this.ClearPickUpQueue();
			return;
		}
		IPickUpItemInfo itemData = this.PickUpItemDataQueue[0];
		this.PickUpItemDataQueue.RemoveAt(0);
		if (itemData == null)
		{
			this.IsPickingUp = false;
			this.ClearPickUpQueue();
			return;
		}
		double now = Time.Instance.Now;
		if (now - this.PickUpTime < 200.0)
		{
			double num = Math.Max(200.0 - (now - this.PickUpTime), 20.0);
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.ExecutePickUp(itemData).Forget();
			}, (float)num, null, null, true, 1f);
			return;
		}
		this.ExecutePickUp(itemData).Forget();
	}

	// Token: 0x0600C2EC RID: 49900 RVA: 0x0039B810 File Offset: 0x00399A10
	private UniTask ExecutePickUp(IPickUpItemInfo info)
	{
		HonamiStoryModel.<ExecutePickUp>d__121 <ExecutePickUp>d__;
		<ExecutePickUp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExecutePickUp>d__.<>4__this = this;
		<ExecutePickUp>d__.info = info;
		<ExecutePickUp>d__.<>1__state = -1;
		<ExecutePickUp>d__.<>t__builder.Start<HonamiStoryModel.<ExecutePickUp>d__121>(ref <ExecutePickUp>d__);
		return <ExecutePickUp>d__.<>t__builder.Task;
	}

	// Token: 0x0600C2ED RID: 49901 RVA: 0x0039B85C File Offset: 0x00399A5C
	[NullableContext(0)]
	protected UniTask<bool> DoPickUpLogic([Nullable(1)] IPickUpItemInfo info)
	{
		HonamiStoryModel.<DoPickUpLogic>d__122 <DoPickUpLogic>d__;
		<DoPickUpLogic>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<DoPickUpLogic>d__.<>4__this = this;
		<DoPickUpLogic>d__.info = info;
		<DoPickUpLogic>d__.<>1__state = -1;
		<DoPickUpLogic>d__.<>t__builder.Start<HonamiStoryModel.<DoPickUpLogic>d__122>(ref <DoPickUpLogic>d__);
		return <DoPickUpLogic>d__.<>t__builder.Task;
	}

	// Token: 0x0600C2EE RID: 49902 RVA: 0x0039B8A8 File Offset: 0x00399AA8
	private void ClearPickUpQueue()
	{
		foreach (IPickUpItemInfo pickUpItemInfo in this.PickUpItemDataQueue)
		{
			PawnInteractNewComponent pawnInteractNewComponent = pickUpItemInfo.EntitySelf.CheckGetComponent<PawnInteractNewComponent>();
			if (pawnInteractNewComponent != null)
			{
				pawnInteractNewComponent.SetInteractionState(true, "HonamiStoryPickUp");
			}
		}
		this.PickUpItemDataQueue.Clear();
	}

	// Token: 0x0600C2EF RID: 49903 RVA: 0x0039B918 File Offset: 0x00399B18
	private void AddHonamiStoryItemNewGetTipsList(HonamiStoryItemDataBase itemData)
	{
		int itemId = itemData.GetItemId();
		HonamiStoryItem? honamiStoryItem = HonamiStoryConfig.Instance.GetHonamiStoryItem(itemId);
		if (honamiStoryItem == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.BB;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 1);
			defaultInterpolatedStringHandler.AppendLiteral("AddHonamiStoryItemNewGetTipsList 无效itemId: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(itemId);
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int num;
		if (HonamiStoryUtil.CheckInHonamiStoryMainDungeon())
		{
			num = HonamiStoryUtil.GetDropQualityInMainQuest();
		}
		else
		{
			num = HonamiStoryConfig.Instance.GetDangerLevelConfig(this.DangerLevel).Value.HightQuality;
		}
		if (honamiStoryItem.Value.QualityId >= num)
		{
			UiManager.Instance.OpenView(EUiViewName.HonamiStoryNewTipsView, itemData, null);
			return;
		}
		ItemHintModel.Instance.AddItemToPriorInterfaceData(itemId, 1, honamiStoryItem.Value.QualityId);
	}

	// Token: 0x0600C2F0 RID: 49904 RVA: 0x0039B9F7 File Offset: 0x00399BF7
	[NullableContext(2)]
	public HonamiStoryBackpackLogicController GetBackpackLogic()
	{
		return this.CurBackpackLogicController;
	}

	// Token: 0x0600C2F1 RID: 49905 RVA: 0x0039B9FF File Offset: 0x00399BFF
	[NullableContext(2)]
	public void SetBackpackLogic(HonamiStoryBackpackLogicController value)
	{
		if (this.CurBackpackLogicController != null)
		{
			this.CurBackpackLogicController.Destroy();
		}
		this.CurBackpackLogicController = value;
	}

	// Token: 0x0600C2F2 RID: 49906 RVA: 0x0039BA1B File Offset: 0x00399C1B
	public EHonamiStoryBackpackLogicState GetBackpackLogicState()
	{
		return this.CurBackpackLogicController.GetLogicState();
	}

	// Token: 0x0600C2F3 RID: 49907 RVA: 0x0039BA28 File Offset: 0x00399C28
	public void SetBackpackLogicState(EHonamiStoryBackpackLogicState state)
	{
		this.CurBackpackLogicController.SetLogicState(state, null, null);
	}

	// Token: 0x0600C2F4 RID: 49908 RVA: 0x0039BA4C File Offset: 0x00399C4C
	public void ShowDiscardTips(HonamiStoryItemDataBase item)
	{
		string name = item.GetName();
		string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(name, name);
		ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_DiscardItemTips", new object[]
		{
			multiTextByKey
		});
	}

	// Token: 0x0600C2F5 RID: 49909 RVA: 0x0039BA86 File Offset: 0x00399C86
	public HonamiStoryInteractController GetInteractController()
	{
		return this.CurBackpackLogicController.GetInteractController();
	}

	// Token: 0x0600C2F6 RID: 49910 RVA: 0x0039BA94 File Offset: 0x00399C94
	public int GetCurrencyCount()
	{
		int outCoinItemId = HonamiStoryConfig.Instance.GetHonamiStoryActivityConfig(this.ActivityData.Id).Value.OutCoinItemId;
		return InventoryModel.Instance.GetItemCountByConfigId(outCoinItemId, 0);
	}

	// Token: 0x0600C2F7 RID: 49911 RVA: 0x0039BAD4 File Offset: 0x00399CD4
	public void QuickPickUpFromPickUpBox(HonamiStoryItemDataBase itemData, int curPos)
	{
		HonamiStoryBackpackData backPackData = this.GetBackPackData(2, false);
		if (backPackData == null)
		{
			return;
		}
		int num = this.CheckCanEquipOnEmpty(itemData);
		if (num != -1)
		{
			HonamiStoryController.Instance.RequestSwitchItem(itemData, null, curPos, num, EHonamiStoryBackpack.PickUpBox, EHonamiStoryBackpack.Player).Forget<bool>();
			return;
		}
		IHonamiStoryAvailablePosInfo honamiStoryAvailablePosInfo = HonamiStoryUtil.FindFirstAvailablePosition(backPackData.GetEmptyGridSet(), itemData, backPackData.GetWidthCount(), null);
		ValueTuple<int, HonamiStoryItemDataBase> valueTuple = this.CheckCanEquipInstead(itemData);
		int item = valueTuple.Item1;
		HonamiStoryItemDataBase item2 = valueTuple.Item2;
		if (honamiStoryAvailablePosInfo.Position >= 0)
		{
			itemData.SetIsDragCross(honamiStoryAvailablePosInfo.IsCross);
			if (item == -1)
			{
				HonamiStoryController.Instance.RequestSwitchItem(itemData, null, curPos, honamiStoryAvailablePosInfo.Position, EHonamiStoryBackpack.PickUpBox, EHonamiStoryBackpack.Backpack).Forget<bool>();
				return;
			}
			HonamiStoryController.Instance.RequestEquipFromPickUpBox(itemData, item2, item, honamiStoryAvailablePosInfo.Position).Forget<bool>();
			return;
		}
		else
		{
			if (itemData.GetItemType() == EHonamiStoryItemType.Normal)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_NoEnoughSpace", Array.Empty<object>());
				return;
			}
			string textId = (item >= 0) ? "HonamiStory_NoEnoughForQuickInstead" : "HonamiStory_NoEnoughSpace";
			ScrollingTipsController.Instance.ShowTipsByTextId(textId, Array.Empty<object>());
			return;
		}
	}

	// Token: 0x0600C2F8 RID: 49912 RVA: 0x0039BBC8 File Offset: 0x00399DC8
	public bool QuickEquipFromBackpack(HonamiStoryItemDataBase itemData, int curPos)
	{
		if (itemData.GetItemType() == EHonamiStoryItemType.Normal)
		{
			return false;
		}
		int num = this.CheckCanEquipOnEmpty(itemData);
		EHonamiStoryBackpack sourceBag = HonamiStoryUtil.CheckInHonamiStoryDungeon() ? EHonamiStoryBackpack.Backpack : EHonamiStoryBackpack.Inventory;
		if (num != -1)
		{
			HonamiStoryController.Instance.RequestSwitchItem(itemData, null, curPos, num, sourceBag, EHonamiStoryBackpack.Player).Forget<bool>();
			return true;
		}
		ValueTuple<int, HonamiStoryItemDataBase> valueTuple = this.CheckCanEquipInstead(itemData);
		int item = valueTuple.Item1;
		HonamiStoryItemDataBase item2 = valueTuple.Item2;
		if (item != -1)
		{
			HonamiStoryController.Instance.RequestSwitchItem(itemData, item2, curPos, item, sourceBag, EHonamiStoryBackpack.Player).Forget<bool>();
			return true;
		}
		return false;
	}

	// Token: 0x0600C2F9 RID: 49913 RVA: 0x0039BC40 File Offset: 0x00399E40
	[NullableContext(0)]
	public UniTask<bool> PickUpFromWorld([Nullable(1)] HonamiStoryItemDataBase itemData, int position)
	{
		HonamiStoryModel.<PickUpFromWorld>d__134 <PickUpFromWorld>d__;
		<PickUpFromWorld>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<PickUpFromWorld>d__.<>4__this = this;
		<PickUpFromWorld>d__.itemData = itemData;
		<PickUpFromWorld>d__.position = position;
		<PickUpFromWorld>d__.<>1__state = -1;
		<PickUpFromWorld>d__.<>t__builder.Start<HonamiStoryModel.<PickUpFromWorld>d__134>(ref <PickUpFromWorld>d__);
		return <PickUpFromWorld>d__.<>t__builder.Task;
	}

	// Token: 0x0600C2FA RID: 49914 RVA: 0x0039BC94 File Offset: 0x00399E94
	public int CheckCanEquipOnEmpty(HonamiStoryItemDataBase itemDataBase)
	{
		if (itemDataBase.GetItemType() == EHonamiStoryItemType.Normal)
		{
			return -1;
		}
		HonamiStoryEquipItemData honamiStoryEquipItemData = itemDataBase as HonamiStoryEquipItemData;
		if (honamiStoryEquipItemData == null)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.WHJ, "获取道具类型出现错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			return -1;
		}
		List<HonamiStoryRoleEquipData> roleEquipDataList = this.GetPlayerBackpackData().GetRoleEquipDataList(true);
		HonamiStoryRoleEquipData honamiStoryRoleEquipData = null;
		int num = 0;
		foreach (HonamiStoryRoleEquipData honamiStoryRoleEquipData2 in roleEquipDataList)
		{
			int num2 = honamiStoryRoleEquipData2.CheckEquipOnEmpty(honamiStoryEquipItemData);
			if (num2 > num)
			{
				num = num2;
				honamiStoryRoleEquipData = honamiStoryRoleEquipData2;
			}
		}
		if (honamiStoryRoleEquipData == null)
		{
			return -1;
		}
		return honamiStoryRoleEquipData.GetNextEmptySlot();
	}

	// Token: 0x0600C2FB RID: 49915 RVA: 0x0039BD44 File Offset: 0x00399F44
	[NullableContext(0)]
	public UniTask<bool> TryQuickEquipOnEmpty([Nullable(1)] HonamiStoryItemDataBase itemDataBase)
	{
		HonamiStoryModel.<TryQuickEquipOnEmpty>d__136 <TryQuickEquipOnEmpty>d__;
		<TryQuickEquipOnEmpty>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<TryQuickEquipOnEmpty>d__.<>4__this = this;
		<TryQuickEquipOnEmpty>d__.itemDataBase = itemDataBase;
		<TryQuickEquipOnEmpty>d__.<>1__state = -1;
		<TryQuickEquipOnEmpty>d__.<>t__builder.Start<HonamiStoryModel.<TryQuickEquipOnEmpty>d__136>(ref <TryQuickEquipOnEmpty>d__);
		return <TryQuickEquipOnEmpty>d__.<>t__builder.Task;
	}

	// Token: 0x0600C2FC RID: 49916 RVA: 0x0039BD90 File Offset: 0x00399F90
	[return: TupleElementNames(new string[]
	{
		"equipPosition",
		"equippedItemData"
	})]
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public ValueTuple<int, HonamiStoryItemDataBase> CheckCanEquipInstead(HonamiStoryItemDataBase itemDataBase)
	{
		if (itemDataBase.GetItemType() == EHonamiStoryItemType.Normal)
		{
			return new ValueTuple<int, HonamiStoryItemDataBase>(-1, null);
		}
		HonamiStoryEquipItemData honamiStoryEquipItemData = itemDataBase as HonamiStoryEquipItemData;
		if (honamiStoryEquipItemData == null)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.WHJ, "获取道具类型出现错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new ValueTuple<int, HonamiStoryItemDataBase>(-1, null);
		}
		List<HonamiStoryRoleEquipData> roleEquipDataList = this.GetPlayerBackpackData().GetRoleEquipDataList(true);
		int num = 0;
		int item = -1;
		HonamiStoryItemDataBase item2 = null;
		foreach (HonamiStoryRoleEquipData honamiStoryRoleEquipData in roleEquipDataList)
		{
			ValueTuple<int, int, HonamiStoryEquipItemData> valueTuple = honamiStoryRoleEquipData.CheckEquipInstead(honamiStoryEquipItemData);
			int item3 = valueTuple.Item1;
			int item4 = valueTuple.Item2;
			HonamiStoryEquipItemData item5 = valueTuple.Item3;
			if (item4 > num)
			{
				num = item4;
				item = item3;
				item2 = item5;
			}
		}
		return new ValueTuple<int, HonamiStoryItemDataBase>(item, item2);
	}

	// Token: 0x0600C2FD RID: 49917 RVA: 0x0039BE60 File Offset: 0x0039A060
	[NullableContext(0)]
	public UniTask<bool> TryQuickEquipInstead([Nullable(1)] HonamiStoryItemDataBase itemDataBase, int position)
	{
		HonamiStoryModel.<TryQuickEquipInstead>d__138 <TryQuickEquipInstead>d__;
		<TryQuickEquipInstead>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<TryQuickEquipInstead>d__.<>4__this = this;
		<TryQuickEquipInstead>d__.itemDataBase = itemDataBase;
		<TryQuickEquipInstead>d__.position = position;
		<TryQuickEquipInstead>d__.<>1__state = -1;
		<TryQuickEquipInstead>d__.<>t__builder.Start<HonamiStoryModel.<TryQuickEquipInstead>d__138>(ref <TryQuickEquipInstead>d__);
		return <TryQuickEquipInstead>d__.<>t__builder.Task;
	}

	// Token: 0x0600C2FE RID: 49918 RVA: 0x0039BEB4 File Offset: 0x0039A0B4
	public bool SetItemIntoBag(HonamiStoryItemDataBase itemData, EHonamiStoryBackpack curBackpack, EHonamiStoryBackpack toBackpack)
	{
		HonamiStoryBackpackData backPackData = this.GetBackPackData((int)toBackpack, false);
		if (backPackData == null)
		{
			return false;
		}
		IHonamiStoryAvailablePosInfo honamiStoryAvailablePosInfo = HonamiStoryUtil.FindFirstAvailablePosition(backPackData.GetEmptyGridSet(), itemData, backPackData.GetWidthCount(), null);
		if (honamiStoryAvailablePosInfo.Position == -1)
		{
			return false;
		}
		using (List<int>.Enumerator enumerator = itemData.GetGridFillPositionByPosition(honamiStoryAvailablePosInfo.Position, honamiStoryAvailablePosInfo.IsCross).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current >= backPackData.GetCapacity())
				{
					return false;
				}
			}
		}
		itemData.SetIsDragCross(honamiStoryAvailablePosInfo.IsCross);
		HonamiStoryController.Instance.RequestSwitchItem(itemData, null, -1, honamiStoryAvailablePosInfo.Position, curBackpack, toBackpack).ContinueWith(delegate(bool _)
		{
			if (toBackpack == EHonamiStoryBackpack.PickUpBox)
			{
				this.ShowDiscardTips(itemData);
			}
		}).Forget();
		return true;
	}

	// Token: 0x0600C2FF RID: 49919 RVA: 0x0039BFBC File Offset: 0x0039A1BC
	[NullableContext(0)]
	public UniTask<bool> SellSingleItem([Nullable(1)] HonamiStoryItemDataBase itemData, EHonamiStoryBackpack backpack)
	{
		HonamiStoryModel.<SellSingleItem>d__140 <SellSingleItem>d__;
		<SellSingleItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SellSingleItem>d__.itemData = itemData;
		<SellSingleItem>d__.backpack = backpack;
		<SellSingleItem>d__.<>1__state = -1;
		<SellSingleItem>d__.<>t__builder.Start<HonamiStoryModel.<SellSingleItem>d__140>(ref <SellSingleItem>d__);
		return <SellSingleItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C300 RID: 49920 RVA: 0x0039C007 File Offset: 0x0039A207
	public void SetIsLastPickUpViewDirty(bool value)
	{
		this.IsLastPickUpViewDirty = value;
	}

	// Token: 0x0600C301 RID: 49921 RVA: 0x0039C010 File Offset: 0x0039A210
	public bool GetIsLastPickUpViewDirty()
	{
		return HonamiStoryUtil.CheckInHonamiStoryDungeon() && this.IsLastPickUpViewDirty;
	}

	// Token: 0x0600C302 RID: 49922 RVA: 0x0039C021 File Offset: 0x0039A221
	public void SetQuickAllDirty(bool needRefresh = true)
	{
		this.QuickAllManager.SetDirty();
		if (needRefresh && this.GetBackpackLogic() != null)
		{
			this.QuickAllRefresh(false);
			this.GetBackpackLogic().RefreshNeedQuickAll();
		}
	}

	// Token: 0x0600C303 RID: 49923 RVA: 0x0039C04C File Offset: 0x0039A24C
	public bool QuickAllRefresh(bool force = false)
	{
		return this.QuickAllManager.Refresh(force);
	}

	// Token: 0x0600C304 RID: 49924 RVA: 0x0039C05C File Offset: 0x0039A25C
	public bool QuickAllCheck(bool needVirtual = true)
	{
		if (this.QuickAllManager.GetDirty())
		{
			this.QuickAllRefresh(false);
		}
		int powerLevel = this.GetPlayerBackpackData().GetPowerLevel(!needVirtual);
		return (needVirtual ? this.QuickAllManager.GetCurPowerLevel() : this.QuickAllManager.GetRealPowerLevel()) > powerLevel;
	}

	// Token: 0x0600C305 RID: 49925 RVA: 0x0039C0AC File Offset: 0x0039A2AC
	public void ApplyQuickAll()
	{
		if (!this.QuickAllCheck(true))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_QuickEquip_BestAlready", Array.Empty<object>());
			return;
		}
		if (this.QuickAllManager.GetDirty())
		{
			this.QuickAllRefresh(false);
		}
		this.QuickAllManager.ApplyQuickAll();
	}

	// Token: 0x0600C306 RID: 49926 RVA: 0x0039C0EC File Offset: 0x0039A2EC
	public void QuickUnloadAllSlot()
	{
		List<HonamiStoryRoleEquipData> roleEquipDataList = this.GetPlayerBackpackData().GetRoleEquipDataList(true);
		List<HonamiStoryItemDataBase> list = new List<HonamiStoryItemDataBase>();
		foreach (HonamiStoryRoleEquipData honamiStoryRoleEquipData in roleEquipDataList)
		{
			foreach (HonamiStoryRoleEquipSlotData honamiStoryRoleEquipSlotData in honamiStoryRoleEquipData.GetSlotList())
			{
				HonamiStoryEquipItemData itemData = honamiStoryRoleEquipSlotData.GetItemData();
				if (itemData != null)
				{
					list.Add(itemData);
				}
			}
		}
		bool flag = HonamiStoryUtil.CheckInHonamiStoryDungeon();
		EHonamiStoryBackpack ehonamiStoryBackpack = flag ? EHonamiStoryBackpack.Backpack : EHonamiStoryBackpack.Inventory;
		HonamiStoryBackpackData backPackData = this.GetBackPackData((int)ehonamiStoryBackpack, false);
		if (backPackData == null)
		{
			return;
		}
		HashSet<int> hashSet = new HashSet<int>();
		int capacity = backPackData.GetCapacity();
		foreach (HonamiStoryItemDataBase itemData2 in list)
		{
			IHonamiStoryAvailablePosInfo honamiStoryAvailablePosInfo = HonamiStoryUtil.FindFirstAvailablePosition(backPackData.GetEmptyGridSet(), itemData2, backPackData.GetWidthCount(), hashSet);
			if (!flag && honamiStoryAvailablePosInfo.Position >= capacity)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_NoEnoughSpace", Array.Empty<object>());
				return;
			}
			if (honamiStoryAvailablePosInfo.Position == -1)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_NoEnoughSpace", Array.Empty<object>());
				return;
			}
			hashSet.Add(honamiStoryAvailablePosInfo.Position);
		}
		if (hashSet.Count != list.Count)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_NoEnoughSpace", Array.Empty<object>());
			return;
		}
		HonamiStoryController.Instance.RequestHonamiStoryQuickUnloadAll(list, hashSet, ehonamiStoryBackpack).Forget<bool>();
	}

	// Token: 0x0600C307 RID: 49927 RVA: 0x0039C294 File Offset: 0x0039A494
	[return: Nullable(2)]
	protected HonamiStoryBagUpdateContext GetSortContext(EHonamiStoryBackpack backpack, Dictionary<HonamiStoryItemDataBase, IHonamiStoryAvailablePosInfo> sortMap)
	{
		HonamiStoryBagUpdateContext honamiStoryBagUpdateContext = HonamiStoryBagUpdateContext.Create();
		honamiStoryBagUpdateContext.BackPackConfigId = (int)backpack;
		foreach (KeyValuePair<HonamiStoryItemDataBase, IHonamiStoryAvailablePosInfo> keyValuePair in sortMap)
		{
			HonamiStoryItemDataBase key = keyValuePair.Key;
			IHonamiStoryAvailablePosInfo value = keyValuePair.Value;
			if (key.GetPosition() != value.Position || value.IsCross != key.GetIsCross())
			{
				key.SetIsDragCross(value.IsCross);
				HonamiStoryBagUpdateInfo honamiStoryItemSwapInfo = HonamiStoryUtil.GetHonamiStoryItemSwapInfo(key, value.Position);
				honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemSwapInfo);
			}
		}
		if (honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Count == 0)
		{
			return null;
		}
		return honamiStoryBagUpdateContext;
	}

	// Token: 0x0600C308 RID: 49928 RVA: 0x0039C350 File Offset: 0x0039A550
	public void SortBackpack()
	{
		EHonamiStoryBackpack backpack = HonamiStoryUtil.CheckInHonamiStoryDungeon() ? EHonamiStoryBackpack.Backpack : EHonamiStoryBackpack.Inventory;
		ValueTuple<bool, HonamiStoryBagUpdateContext> valueTuple = this.TrySort(backpack, true);
		bool item = valueTuple.Item1;
		HonamiStoryBagUpdateContext item2 = valueTuple.Item2;
		List<HonamiStoryBagUpdateContext> list = new List<HonamiStoryBagUpdateContext>();
		if (item2 != null)
		{
			list.Add(item2);
		}
		if (HonamiStoryUtil.CheckInHonamiStoryDungeon())
		{
			HonamiStoryBagUpdateContext item3 = this.TrySort(EHonamiStoryBackpack.PickUpBox, false).Item2;
			if (item3 != null)
			{
				list.Add(item3);
			}
		}
		if (list.Count > 0)
		{
			HonamiStoryController.Instance.SendHonamiStoryBagOperateRequest(list).ContinueWith(delegate(bool task)
			{
				if (task)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_SortSuccess", Array.Empty<object>());
					EventSystem.Instance.Emit(EEventName.OnHonamiStorySortSuccess);
				}
			}).Forget();
			return;
		}
		if (!item)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_SortSuccess", Array.Empty<object>());
			EventSystem.Instance.Emit(EEventName.OnHonamiStorySortSuccess);
		}
	}

	// Token: 0x0600C309 RID: 49929 RVA: 0x0039C418 File Offset: 0x0039A618
	[return: TupleElementNames(new string[]
	{
		"sortFailTips",
		"context"
	})]
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public ValueTuple<bool, HonamiStoryBagUpdateContext> TrySort(EHonamiStoryBackpack backpack, bool needTips)
	{
		HonamiStoryBackpackData backPackData = this.GetBackPackData((int)backpack, false);
		int widthCount = backPackData.GetWidthCount();
		int capacity = backPackData.GetCapacity();
		List<HonamiStoryItemDataBase> itemDataList = backPackData.GetItemDataList();
		List<HonamiStoryItemDataBase> list = new List<HonamiStoryItemDataBase>();
		List<HonamiStoryItemDataBase> list2 = new List<HonamiStoryItemDataBase>();
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in itemDataList)
		{
			if (honamiStoryItemDataBase.GetItemType() == EHonamiStoryItemType.Normal)
			{
				list2.Add(honamiStoryItemDataBase);
			}
			else
			{
				list.Add(honamiStoryItemDataBase);
			}
		}
		list.Sort(this.PluginSort);
		list2.Sort(this.NormalSort);
		ValueTuple<bool, HonamiStoryBagUpdateContext> valueTuple = this.FirstSortBackpack(backpack, list, list2, capacity, widthCount);
		bool item = valueTuple.Item1;
		HonamiStoryBagUpdateContext item2 = valueTuple.Item2;
		if (item)
		{
			return new ValueTuple<bool, HonamiStoryBagUpdateContext>(false, item2);
		}
		ValueTuple<HonamiStoryBagUpdateContext, int> valueTuple2 = this.SecondSortBackpack(backpack, list, list2, capacity, widthCount);
		HonamiStoryBagUpdateContext item3 = valueTuple2.Item1;
		int item4 = valueTuple2.Item2;
		if (item3 == null && item4 > 0)
		{
			if (needTips)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_CantSortBackpack", new object[]
				{
					item4
				});
			}
			return new ValueTuple<bool, HonamiStoryBagUpdateContext>(true, null);
		}
		return new ValueTuple<bool, HonamiStoryBagUpdateContext>(false, item3);
	}

	// Token: 0x0600C30A RID: 49930 RVA: 0x0039C538 File Offset: 0x0039A738
	[return: TupleElementNames(new string[]
	{
		"valid",
		"context"
	})]
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	protected ValueTuple<bool, HonamiStoryBagUpdateContext> FirstSortBackpack(EHonamiStoryBackpack backpackId, List<HonamiStoryItemDataBase> pluginList, List<HonamiStoryItemDataBase> normalList, int capacity, int width)
	{
		HashSet<int> hashSet = new HashSet<int>();
		for (int i = 0; i < capacity; i++)
		{
			hashSet.Add(i);
		}
		Dictionary<HonamiStoryItemDataBase, IHonamiStoryAvailablePosInfo> dictionary = new Dictionary<HonamiStoryItemDataBase, IHonamiStoryAvailablePosInfo>();
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in pluginList)
		{
			IHonamiStoryAvailablePosInfo honamiStoryAvailablePosInfo = HonamiStoryUtil.FindFirstAvailablePosition(hashSet, honamiStoryItemDataBase, width, null);
			if (honamiStoryAvailablePosInfo.Position == -1)
			{
				return new ValueTuple<bool, HonamiStoryBagUpdateContext>(false, null);
			}
			hashSet.Remove(honamiStoryAvailablePosInfo.Position);
			dictionary[honamiStoryItemDataBase] = honamiStoryAvailablePosInfo;
		}
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase2 in normalList)
		{
			IHonamiStoryAvailablePosInfo honamiStoryAvailablePosInfo2 = HonamiStoryUtil.FindFirstAvailablePosition(hashSet, honamiStoryItemDataBase2, width, null);
			if (honamiStoryAvailablePosInfo2.Position == -1)
			{
				return new ValueTuple<bool, HonamiStoryBagUpdateContext>(false, null);
			}
			foreach (int item in honamiStoryItemDataBase2.GetGridFillPositionByPosition(honamiStoryAvailablePosInfo2.Position, honamiStoryAvailablePosInfo2.IsCross))
			{
				hashSet.Remove(item);
			}
			dictionary[honamiStoryItemDataBase2] = honamiStoryAvailablePosInfo2;
		}
		return new ValueTuple<bool, HonamiStoryBagUpdateContext>(true, this.GetSortContext(backpackId, dictionary));
	}

	// Token: 0x0600C30B RID: 49931 RVA: 0x0039C6AC File Offset: 0x0039A8AC
	[return: TupleElementNames(new string[]
	{
		"context",
		"count"
	})]
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	protected ValueTuple<HonamiStoryBagUpdateContext, int> SecondSortBackpack(EHonamiStoryBackpack backpackId, List<HonamiStoryItemDataBase> pluginList, List<HonamiStoryItemDataBase> normalList, int capacity, int width)
	{
		HashSet<int> hashSet = new HashSet<int>();
		for (int i = 0; i < capacity; i++)
		{
			hashSet.Add(i);
		}
		Dictionary<HonamiStoryItemDataBase, IHonamiStoryAvailablePosInfo> dictionary = new Dictionary<HonamiStoryItemDataBase, IHonamiStoryAvailablePosInfo>();
		int num = -1;
		bool flag = false;
		int num2 = 0;
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in normalList)
		{
			if (flag)
			{
				num2 += honamiStoryItemDataBase.GetGridHeight() * honamiStoryItemDataBase.GetGridWidth();
			}
			else
			{
				IHonamiStoryAvailablePosInfo honamiStoryAvailablePosInfo = HonamiStoryUtil.FindFirstAvailablePosition(hashSet, honamiStoryItemDataBase, width, null);
				if (honamiStoryAvailablePosInfo.Position == -1)
				{
					flag = true;
					num2 += honamiStoryItemDataBase.GetGridHeight() * honamiStoryItemDataBase.GetGridWidth();
				}
				else
				{
					foreach (int num3 in honamiStoryItemDataBase.GetGridFillPositionByPosition(honamiStoryAvailablePosInfo.Position, honamiStoryAvailablePosInfo.IsCross))
					{
						num = Math.Max(num, num3);
						hashSet.Remove(num3);
					}
					dictionary[honamiStoryItemDataBase] = honamiStoryAvailablePosInfo;
				}
			}
		}
		HashSet<int> hashSet2 = new HashSet<int>();
		if (!flag)
		{
			int num4 = (int)(Math.Floor((double)(num + 1) / (double)width) * (double)width + (double)(((num + 1) % width == 0) ? 0 : width));
			int num5 = capacity - num4;
			for (int j = 0; j < capacity; j++)
			{
				if (j < num5 || hashSet.Contains(j - num5))
				{
					hashSet2.Add(j);
				}
			}
			foreach (KeyValuePair<HonamiStoryItemDataBase, IHonamiStoryAvailablePosInfo> keyValuePair in dictionary)
			{
				keyValuePair.Value.Position += num5;
			}
		}
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase2 in pluginList)
		{
			if (flag)
			{
				num2 += honamiStoryItemDataBase2.GetGridHeight() * honamiStoryItemDataBase2.GetGridWidth();
			}
			else
			{
				IHonamiStoryAvailablePosInfo honamiStoryAvailablePosInfo2 = HonamiStoryUtil.FindFirstAvailablePosition(hashSet2, honamiStoryItemDataBase2, width, null);
				if (honamiStoryAvailablePosInfo2.Position == -1)
				{
					flag = true;
					num2 += honamiStoryItemDataBase2.GetGridHeight() * honamiStoryItemDataBase2.GetGridWidth();
				}
				else
				{
					hashSet2.Remove(honamiStoryAvailablePosInfo2.Position);
					dictionary[honamiStoryItemDataBase2] = honamiStoryAvailablePosInfo2;
				}
			}
		}
		if (flag)
		{
			return new ValueTuple<HonamiStoryBagUpdateContext, int>(null, num2);
		}
		HashSet<int> hashSet3 = new HashSet<int>();
		foreach (KeyValuePair<HonamiStoryItemDataBase, IHonamiStoryAvailablePosInfo> keyValuePair2 in dictionary)
		{
			if (!hashSet3.Contains(keyValuePair2.Value.Position))
			{
				hashSet3.Add(keyValuePair2.Value.Position);
			}
		}
		return new ValueTuple<HonamiStoryBagUpdateContext, int>(this.GetSortContext(backpackId, dictionary), 0);
	}

	// Token: 0x0600C30C RID: 49932 RVA: 0x0039C9AC File Offset: 0x0039ABAC
	[NullableContext(2)]
	public HonamiStoryGamepadLogicController GetGamepadLogic()
	{
		if (this.CurGamepadLogicController == null)
		{
			this.CurGamepadLogicController = new HonamiStoryGamepadLogicController();
		}
		return this.CurGamepadLogicController;
	}

	// Token: 0x0600C30D RID: 49933 RVA: 0x0039C9C7 File Offset: 0x0039ABC7
	[NullableContext(2)]
	public void SetGamepadLogic(HonamiStoryGamepadLogicController value)
	{
		this.CurGamepadLogicController = value;
	}

	// Token: 0x0600C30E RID: 49934 RVA: 0x0039C9D0 File Offset: 0x0039ABD0
	public void SetMainTaskLoadingData(IHonamiStoryLoadingData data)
	{
		this.MainTaskParam = data;
	}

	// Token: 0x0600C30F RID: 49935 RVA: 0x0039C9D9 File Offset: 0x0039ABD9
	public void SetGamePlayLoadingData(IHonamiStoryLoadingData data)
	{
		this.GamePlayParam = data;
	}

	// Token: 0x0600C310 RID: 49936 RVA: 0x0039C9E2 File Offset: 0x0039ABE2
	public void ClearCurLoadingData()
	{
		this.MainTaskParam = null;
		this.GamePlayParam = null;
	}

	// Token: 0x0600C311 RID: 49937 RVA: 0x0039C9F2 File Offset: 0x0039ABF2
	[NullableContext(2)]
	public IHonamiStoryLoadingData GetCurLoadingData()
	{
		return this.MainTaskParam ?? this.GamePlayParam;
	}

	// Token: 0x0600C312 RID: 49938 RVA: 0x0039CA04 File Offset: 0x0039AC04
	public EUiViewName? GetCurLoadViewName()
	{
		IHonamiStoryLoadingData curLoadingData = this.GetCurLoadingData();
		if (curLoadingData == null)
		{
			return null;
		}
		HonamiStoryLoadingPerform? honamiStoryLoadingPerform = null;
		bool flag = curLoadingData.LoadingId > 0;
		bool flag2 = curLoadingData.BtId > 0;
		bool flag3 = curLoadingData.Timing > 0;
		if (flag)
		{
			honamiStoryLoadingPerform = HonamiStoryConfig.Instance.GetLoadingPerformConfigById(curLoadingData.LoadingId.Value);
		}
		else if (flag3)
		{
			if (flag2)
			{
				honamiStoryLoadingPerform = HonamiStoryConfig.Instance.GetLoadingPerformConfigByBtAndTime(curLoadingData.BtId.Value, curLoadingData.Timing.Value);
			}
			else
			{
				IReadOnlyList<HonamiStoryLoadingPerform> loadingPerformConfigListByTiming = HonamiStoryConfig.Instance.GetLoadingPerformConfigListByTiming(curLoadingData.Timing.Value);
				if (loadingPerformConfigListByTiming.Count > 0)
				{
					honamiStoryLoadingPerform = new HonamiStoryLoadingPerform?(loadingPerformConfigListByTiming[0]);
				}
			}
		}
		if (honamiStoryLoadingPerform == null)
		{
			return null;
		}
		if (honamiStoryLoadingPerform.Value.PerformType == 5)
		{
			return new EUiViewName?(EUiViewName.HonamiStoryMainLoadingView);
		}
		return new EUiViewName?(EUiViewName.HonamiStoryLoadingView);
	}

	// Token: 0x170012FF RID: 4863
	// (get) Token: 0x0600C313 RID: 49939 RVA: 0x0039CB49 File Offset: 0x0039AD49
	public static HonamiStoryModel Instance
	{
		get
		{
			return HonamiStoryModel._Instance;
		}
	}

	// Token: 0x0600C314 RID: 49940 RVA: 0x0039CB50 File Offset: 0x0039AD50
	public static HonamiStoryModel GetOrCreateInstance()
	{
		if (HonamiStoryModel._Instance == null)
		{
			HonamiStoryModel.CreateInstance();
		}
		return HonamiStoryModel._Instance;
	}

	// Token: 0x0600C315 RID: 49941 RVA: 0x0039CB64 File Offset: 0x0039AD64
	public static bool CreateInstance()
	{
		if (HonamiStoryModel._Instance != null)
		{
			return true;
		}
		HonamiStoryModel._Instance = new HonamiStoryModel();
		return true;
	}

	// Token: 0x0600C316 RID: 49942 RVA: 0x0039CB7A File Offset: 0x0039AD7A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C317 RID: 49943 RVA: 0x0039CB7C File Offset: 0x0039AD7C
	public static void ResetStaticDefaultValue()
	{
		HonamiStoryModel._Instance = null;
	}

	// Token: 0x0600C318 RID: 49944 RVA: 0x0039CB84 File Offset: 0x0039AD84
	static HonamiStoryModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HonamiStoryModel.CreateStaticDefaultValue), new Action(HonamiStoryModel.ResetStaticDefaultValue));
	}

	// Token: 0x04006F70 RID: 28528
	public int ActivityId;

	// Token: 0x04006F71 RID: 28529
	public HonamiStoryQuickEquipAllManager QuickAllManager = new HonamiStoryQuickEquipAllManager();

	// Token: 0x04006F72 RID: 28530
	[Nullable(2)]
	protected HonamiStoryBackpackLogicController CurBackpackLogicController;

	// Token: 0x04006F73 RID: 28531
	[Nullable(2)]
	private HonamiStoryGamepadLogicController CurGamepadLogicController;

	// Token: 0x04006F74 RID: 28532
	protected List<IPickUpItemInfo> PickUpItemDataQueue = new List<IPickUpItemInfo>();

	// Token: 0x04006F75 RID: 28533
	protected double PickUpTime;

	// Token: 0x04006F76 RID: 28534
	protected bool IsPickingUp;

	// Token: 0x04006F77 RID: 28535
	public HashSet<int> PickedEntityId = new HashSet<int>();

	// Token: 0x04006F78 RID: 28536
	public readonly FRotator NormalRotation = global::Rotator.Create(0f, 0f, 0f).ToUeRotator();

	// Token: 0x04006F79 RID: 28537
	public readonly FRotator TransRotation = global::Rotator.Create(0f, 90f, 0f).ToUeRotator();

	// Token: 0x04006F7A RID: 28538
	protected bool IsLastPickUpViewDirty;

	// Token: 0x04006F7B RID: 28539
	public bool CanSafeLeave;

	// Token: 0x04006F7C RID: 28540
	public bool CacheShowSafeLeaveUpdate;

	// Token: 0x04006F7D RID: 28541
	public int PollutionLevel;

	// Token: 0x04006F7E RID: 28542
	public int PollutionMaxLevel;

	// Token: 0x04006F7F RID: 28543
	public float PollutionStarTime;

	// Token: 0x04006F80 RID: 28544
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, IHonamiStoryPollution> PollutionLevelMap;

	// Token: 0x04006F81 RID: 28545
	public int PollutionWarningLevel;

	// Token: 0x04006F82 RID: 28546
	public int PollutionDangerLevel;

	// Token: 0x04006F83 RID: 28547
	public int MonsterBaseEnhanceLevel;

	// Token: 0x04006F84 RID: 28548
	public int DangerLevel;

	// Token: 0x04006F85 RID: 28549
	public int MonsterLevelSafeOffset;

	// Token: 0x04006F86 RID: 28550
	public int MonsterLevelDangerOffset;

	// Token: 0x04006F87 RID: 28551
	public int? ScanMarkId;

	// Token: 0x04006F88 RID: 28552
	public HashSet<int> ScanMarkItemIds = new HashSet<int>();

	// Token: 0x04006F89 RID: 28553
	public int CurrentUnlockFogId;

	// Token: 0x04006F8A RID: 28554
	public int CurAreaId;

	// Token: 0x04006F8B RID: 28555
	[Nullable(2)]
	private IHonamiStoryLoadingData MainTaskParam;

	// Token: 0x04006F8C RID: 28556
	[Nullable(2)]
	private IHonamiStoryLoadingData GamePlayParam;

	// Token: 0x04006F8D RID: 28557
	[Nullable(2)]
	private HonamiStoryActivityData ActivityData;

	// Token: 0x04006F8E RID: 28558
	public HonamiStoryPlayerData PlayerData = HonamiStoryPlayerData.Create();

	// Token: 0x04006F8F RID: 28559
	private HonamiStoryPlayerBackpackData PlayerBackpackData;

	// Token: 0x04006F90 RID: 28560
	private readonly Dictionary<int, HonamiStoryWeaponData> WeaponDataMap = new Dictionary<int, HonamiStoryWeaponData>();

	// Token: 0x04006F91 RID: 28561
	public int LastRecordRevenue;

	// Token: 0x04006F92 RID: 28562
	private int TotalRevenueInternal;

	// Token: 0x04006F93 RID: 28563
	[Nullable(2)]
	private HonamiStoryBackpackData WareHouseBackpackData;

	// Token: 0x04006F94 RID: 28564
	private readonly Dictionary<int, HonamiStoryTechNodeData> TechNodeDataMap = new Dictionary<int, HonamiStoryTechNodeData>();

	// Token: 0x04006F95 RID: 28565
	private readonly Dictionary<int, HonamiStoryTechAreaData> TechAreaDataMap = new Dictionary<int, HonamiStoryTechAreaData>();

	// Token: 0x04006F96 RID: 28566
	[Nullable(2)]
	public HonamiStoryTechNodeData CurrentSelectNode;

	// Token: 0x04006F97 RID: 28567
	[Nullable(2)]
	public HonamiStoryTechnologyNodeItem CurrentSelectNodeItem;

	// Token: 0x04006F98 RID: 28568
	public Dictionary<int, int> RoleParentMap = new Dictionary<int, int>();

	// Token: 0x04006F99 RID: 28569
	public Dictionary<int, HonamiStoryItemDataBase> ItemDataMap = new Dictionary<int, HonamiStoryItemDataBase>();

	// Token: 0x04006F9A RID: 28570
	public Dictionary<int, CSharpScript.Game.Module.HonamiStory.Data.HonamiStoryWeaponSuitData> WeaponSuitMap = new Dictionary<int, CSharpScript.Game.Module.HonamiStory.Data.HonamiStoryWeaponSuitData>();

	// Token: 0x04006F9B RID: 28571
	public int[] AddLevel = new int[]
	{
		-1,
		-1
	};

	// Token: 0x04006F9C RID: 28572
	[Nullable(2)]
	public HonamiStoryQuestDataBase CurTrackTaskData;

	// Token: 0x04006F9D RID: 28573
	private readonly Dictionary<EHonamiStoryQuestType, List<HonamiStoryQuestDataBase>> QuestDataMapCache = new Dictionary<EHonamiStoryQuestType, List<HonamiStoryQuestDataBase>>();

	// Token: 0x04006F9E RID: 28574
	private readonly Dictionary<int, HonamiStoryBackpackData> BackpackDataMap = new Dictionary<int, HonamiStoryBackpackData>();

	// Token: 0x04006F9F RID: 28575
	private readonly Comparison<HonamiStoryItemDataBase> NormalSort = delegate(HonamiStoryItemDataBase a, HonamiStoryItemDataBase b)
	{
		if (a.IsLock() != b.IsLock())
		{
			if (!a.IsLock())
			{
				return 1;
			}
			return -1;
		}
		else
		{
			int num = a.GetGridHeight() * a.GetGridWidth();
			int num2 = b.GetGridHeight() * b.GetGridWidth();
			if (num != num2)
			{
				return num2 - num;
			}
			if (a.GetSubType() != b.GetSubType())
			{
				return b.GetSubType() - a.GetSubType();
			}
			if (a.GetQuality() != b.GetQuality())
			{
				return b.GetQuality() - a.GetQuality();
			}
			if (a.GetItemId() != b.GetItemId())
			{
				return a.GetItemId() - b.GetItemId();
			}
			return a.GetIncId() - b.GetIncId();
		}
	};

	// Token: 0x04006FA0 RID: 28576
	private readonly Comparison<HonamiStoryItemDataBase> PluginSort = delegate(HonamiStoryItemDataBase a, HonamiStoryItemDataBase b)
	{
		if (a.IsLock() != b.IsLock())
		{
			if (!a.IsLock())
			{
				return 1;
			}
			return -1;
		}
		else
		{
			if (a.GetSubType() != b.GetSubType())
			{
				return b.GetSubType() - a.GetSubType();
			}
			if (a.GetQuality() != b.GetQuality())
			{
				return b.GetQuality() - a.GetQuality();
			}
			if (a.GetItemId() != b.GetItemId())
			{
				return a.GetItemId() - b.GetItemId();
			}
			return a.GetIncId() - b.GetIncId();
		}
	};

	// Token: 0x04006FA1 RID: 28577
	[Nullable(2)]
	private static HonamiStoryModel _Instance;
}
