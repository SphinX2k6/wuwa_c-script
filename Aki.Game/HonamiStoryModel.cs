using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001E8A RID: 7818
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class HonamiStoryModel : ModelBase
{
	// Token: 0x0600EE85 RID: 61061 RVA: 0x0038E151 File Offset: 0x0038C351
	protected override bool OnInit()
	{
		this.ActivityData = null;
		this.ItemDataMap.Clear();
		this.AddOpenViewCheck();
		return true;
	}

	// Token: 0x0600EE86 RID: 61062 RVA: 0x0038E16C File Offset: 0x0038C36C
	protected override bool OnClear()
	{
		this.RemoveOpenViewCheck();
		return true;
	}

	// Token: 0x0600EE87 RID: 61063 RVA: 0x0038E178 File Offset: 0x0038C378
	private void AddOpenViewCheck()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.HonamiStoryBackpackView, new Func<EUiViewName, object, bool>(HonamiStoryController.Instance.CanOpenBackpack), "HonamiStoryController.CanOpenView");
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.HonamiStoryPickUpBackpackView, new Func<EUiViewName, object, bool>(HonamiStoryController.Instance.CanOpenBackpack), "HonamiStoryController.CanOpenView");
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.HonamiStoryPickUpMobileView, new Func<EUiViewName, object, bool>(HonamiStoryController.Instance.CanOpenBackpack), "HonamiStoryController.CanOpenView");
	}

	// Token: 0x0600EE88 RID: 61064 RVA: 0x0038E1F4 File Offset: 0x0038C3F4
	private void RemoveOpenViewCheck()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.HonamiStoryBackpackView, new Func<EUiViewName, object, bool>(HonamiStoryController.Instance.CanOpenBackpack));
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.HonamiStoryPickUpBackpackView, new Func<EUiViewName, object, bool>(HonamiStoryController.Instance.CanOpenBackpack));
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.HonamiStoryPickUpMobileView, new Func<EUiViewName, object, bool>(HonamiStoryController.Instance.CanOpenBackpack));
	}

	// Token: 0x0600EE89 RID: 61065 RVA: 0x0038E260 File Offset: 0x0038C460
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

	// Token: 0x0600EE8A RID: 61066 RVA: 0x0038E2DA File Offset: 0x0038C4DA
	public void SetActivityData(HonamiStoryActivityData activityData)
	{
		this.ActivityData = activityData;
	}

	// Token: 0x0600EE8B RID: 61067 RVA: 0x0038E2E4 File Offset: 0x0038C4E4
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

	// Token: 0x0600EE8C RID: 61068 RVA: 0x0038E323 File Offset: 0x0038C523
	public HonamiStoryPlayerData GetPlayerData()
	{
		return this.PlayerData;
	}

	// Token: 0x0600EE8D RID: 61069 RVA: 0x0038E32C File Offset: 0x0038C52C
	public void InitActivityInfo(int activityId, HonamiStoryActivityInfo activityInfo)
	{
		this.ActivityId = activityId;
		this.InitPlayerInfo(activityId, activityInfo.HonamiStoryPlayerBagInfo);
		this.InitBackPackInfo(activityInfo.HonamiStoryPlayerBagInfo.Warehouse);
		this.InitTechNodeData();
		this.RefreshTalentInfos(activityInfo.HonamiStoryTalentInfos);
		this.UpdateLiefSupport(activityInfo.LifeSupportLevel);
	}

	// Token: 0x0600EE8E RID: 61070 RVA: 0x0038E37C File Offset: 0x0038C57C
	public void UpdateActivityInfo(int activityId, HonamiStoryActivityInfo activityInfo)
	{
		this.UpdatePlayerInfo(activityId, activityInfo.HonamiStoryPlayerBagInfo);
		this.UpdateBackPackInfo(activityInfo.HonamiStoryPlayerBagInfo.Warehouse);
		this.RefreshTalentInfos(activityInfo.HonamiStoryTalentInfos);
		this.UpdateLiefSupport(activityInfo.LifeSupportLevel);
	}

	// Token: 0x0600EE8F RID: 61071 RVA: 0x0038E3B4 File Offset: 0x0038C5B4
	private void UpdateLiefSupport(int curLevel)
	{
		this.PlayerData.SetLifeSupportLevel(curLevel);
	}

	// Token: 0x0600EE90 RID: 61072 RVA: 0x0038E3C4 File Offset: 0x0038C5C4
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
		this.UpdateWeaponDataList(playerInfo.UnlockWeapon.ToList<int>());
	}

	// Token: 0x0600EE91 RID: 61073 RVA: 0x0038E47C File Offset: 0x0038C67C
	[NullableContext(2)]
	private void UpdatePlayerInfo(int activityId, HonamiStoryPlayerBagInfo playerInfo)
	{
		if (playerInfo == null)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.BB, "InitPlayerBagInfo 无效playerInfo", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.PlayerBackpackData.RefreshEquipInfo(playerInfo.HonamiStoryRackInfos.ToList<HonamiStoryRackInfo>());
		if (playerInfo.EquipRack != null)
		{
			this.PlayerBackpackData.RefreshGridItemInfo(playerInfo.EquipRack.HonamiStoryBagItemInfos.ToList<HonamiStoryBagItemInfo>());
		}
		foreach (HonamiStoryWeapon honamiStoryWeapon in HonamiStoryConfig.Instance.GetHonamiStoryWeaponConfigList(activityId))
		{
			HonamiStoryWeaponData value = new HonamiStoryWeaponData(honamiStoryWeapon.Id);
			this.WeaponDataMap[honamiStoryWeapon.Id] = value;
		}
		this.UpdateWeaponDataList(playerInfo.UnlockWeapon.ToList<int>());
	}

	// Token: 0x0600EE92 RID: 61074 RVA: 0x0038E554 File Offset: 0x0038C754
	public void UpdateRoleList(List<int> roleList)
	{
		this.PlayerBackpackData.RefreshRoleInfo(roleList);
	}

	// Token: 0x0600EE93 RID: 61075 RVA: 0x0038E562 File Offset: 0x0038C762
	public void UpdateRoleByPosition(int roleId, int position)
	{
		this.PlayerBackpackData.RefreshRoleInfoByPosition(roleId, position);
	}

	// Token: 0x0600EE94 RID: 61076 RVA: 0x0038E571 File Offset: 0x0038C771
	public void UpdateWeaponByPosition(int weaponId, int position)
	{
		this.PlayerBackpackData.RefreshWeaponInfoByPosition(weaponId, position);
	}

	// Token: 0x0600EE95 RID: 61077 RVA: 0x0038E580 File Offset: 0x0038C780
	public void UpdatePlayerBackPack(HonamiStoryBagUpdateContext updateContext)
	{
		this.PlayerBackpackData.UpdateByContext(updateContext.HonamiStoryBagUpdateInfo.ToList<HonamiStoryBagUpdateInfo>());
	}

	// Token: 0x0600EE96 RID: 61078 RVA: 0x0038E598 File Offset: 0x0038C798
	public HonamiStoryPlayerBackpackData GetPlayerBackpackData()
	{
		return this.PlayerBackpackData;
	}

	// Token: 0x0600EE97 RID: 61079 RVA: 0x0038E5A0 File Offset: 0x0038C7A0
	public int[] GetAllRoleIdList()
	{
		List<int> list = new List<int>();
		foreach (HonamiStoryRoleEquipData honamiStoryRoleEquipData in this.PlayerBackpackData.GetRoleEquipDataList(true))
		{
			list.Add(honamiStoryRoleEquipData.GetRoleId());
		}
		return list.ToArray();
	}

	// Token: 0x0600EE98 RID: 61080 RVA: 0x0038E60C File Offset: 0x0038C80C
	[NullableContext(2)]
	public HonamiStoryRoleEquipData GetRoleItemDataByPosition(int position)
	{
		return this.PlayerBackpackData.GetRoleItemDataByPosition(position);
	}

	// Token: 0x0600EE99 RID: 61081 RVA: 0x0038E61A File Offset: 0x0038C81A
	[NullableContext(2)]
	public HonamiStoryRoleEquipData GetRoleEquipDataByPosition(int position)
	{
		return this.PlayerBackpackData.GetRoleEquipDataByPosition(position);
	}

	// Token: 0x0600EE9A RID: 61082 RVA: 0x0038E628 File Offset: 0x0038C828
	[NullableContext(2)]
	public HonamiStoryRoleEquipData GetRoleEquipDataByRoleId(int roleId)
	{
		return this.PlayerBackpackData.GetRoleEquipDataByRoleId(roleId);
	}

	// Token: 0x0600EE9B RID: 61083 RVA: 0x0038E638 File Offset: 0x0038C838
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

	// Token: 0x0600EE9C RID: 61084 RVA: 0x0038E6DC File Offset: 0x0038C8DC
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

	// Token: 0x0600EE9D RID: 61085 RVA: 0x0038E7B8 File Offset: 0x0038C9B8
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

	// Token: 0x0600EE9E RID: 61086 RVA: 0x0038E820 File Offset: 0x0038CA20
	public void UpdateWeaponDataList(List<int> weaponIdList)
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

	// Token: 0x0600EE9F RID: 61087 RVA: 0x0038E87C File Offset: 0x0038CA7C
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

	// Token: 0x0600EEA0 RID: 61088 RVA: 0x0038E89C File Offset: 0x0038CA9C
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

	// Token: 0x0600EEA1 RID: 61089 RVA: 0x0038E8BC File Offset: 0x0038CABC
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

	// Token: 0x0600EEA2 RID: 61090 RVA: 0x0038E924 File Offset: 0x0038CB24
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

	// Token: 0x170012D3 RID: 4819
	// (get) Token: 0x0600EEA3 RID: 61091 RVA: 0x0038E967 File Offset: 0x0038CB67
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

	// Token: 0x0600EEA4 RID: 61092 RVA: 0x0038E982 File Offset: 0x0038CB82
	[NullableContext(2)]
	public HonamiStoryBackpackData GetInventory()
	{
		return this.WareHouseBackpackData;
	}

	// Token: 0x0600EEA5 RID: 61093 RVA: 0x0038E98A File Offset: 0x0038CB8A
	public void SetInventory(HonamiStoryBackpackData newData)
	{
		this.WareHouseBackpackData = newData;
	}

	// Token: 0x0600EEA6 RID: 61094 RVA: 0x0038E993 File Offset: 0x0038CB93
	public bool CheckIsNewInInventory()
	{
		return this.WareHouseBackpackData != null && (this.WareHouseBackpackData.CheckIsNewInBackpack() || (LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryWeaponUnlockSet, null) ?? new HashSet<int>()).Count > 0);
	}

	// Token: 0x0600EEA7 RID: 61095 RVA: 0x0038E9CC File Offset: 0x0038CBCC
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

	// Token: 0x0600EEA8 RID: 61096 RVA: 0x0038EAA8 File Offset: 0x0038CCA8
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

	// Token: 0x0600EEA9 RID: 61097 RVA: 0x0038EB38 File Offset: 0x0038CD38
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

	// Token: 0x0600EEAA RID: 61098 RVA: 0x0038EBA0 File Offset: 0x0038CDA0
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

	// Token: 0x0600EEAB RID: 61099 RVA: 0x0038EBF0 File Offset: 0x0038CDF0
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

	// Token: 0x170012D4 RID: 4820
	// (get) Token: 0x0600EEAC RID: 61100 RVA: 0x0038EC40 File Offset: 0x0038CE40
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

	// Token: 0x0600EEAD RID: 61101 RVA: 0x0038ECB0 File Offset: 0x0038CEB0
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

	// Token: 0x0600EEAE RID: 61102 RVA: 0x0038EDD4 File Offset: 0x0038CFD4
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

	// Token: 0x0600EEAF RID: 61103 RVA: 0x0038EE44 File Offset: 0x0038D044
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

	// Token: 0x0600EEB0 RID: 61104 RVA: 0x0038EEA8 File Offset: 0x0038D0A8
	public HonamiStoryTechNodeData[] GetAllTechNodeDataList()
	{
		List<HonamiStoryTechNodeData> list = new List<HonamiStoryTechNodeData>();
		foreach (HonamiStoryTechNodeData item in this.TechNodeDataMap.Values)
		{
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x0600EEB1 RID: 61105 RVA: 0x0038EF0C File Offset: 0x0038D10C
	public HonamiStoryTechAreaData[] GetAllTechAreaDataList()
	{
		List<HonamiStoryTechAreaData> list = new List<HonamiStoryTechAreaData>();
		foreach (HonamiStoryTechAreaData item in this.TechAreaDataMap.Values)
		{
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x0600EEB2 RID: 61106 RVA: 0x0038EF70 File Offset: 0x0038D170
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

	// Token: 0x0600EEB3 RID: 61107 RVA: 0x0038EFE0 File Offset: 0x0038D1E0
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

	// Token: 0x0600EEB4 RID: 61108 RVA: 0x0038F080 File Offset: 0x0038D280
	public bool IsShopHasRedDot()
	{
		if (this.ActivityData == null)
		{
			return false;
		}
		int shopId = this.ActivityData.ShopId;
		return PayShopModel.Instance.CheckShopItemCheckFlag((PayShopDefine.EPayShopTabType)shopId, 1);
	}

	// Token: 0x0600EEB5 RID: 61109 RVA: 0x0038F0B0 File Offset: 0x0038D2B0
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

	// Token: 0x0600EEB6 RID: 61110 RVA: 0x0038F160 File Offset: 0x0038D360
	public CSharpScript.Game.Module.HonamiStory.Data.HonamiStoryWeaponSuitData GetWeaponSuitData(int suitId)
	{
		CSharpScript.Game.Module.HonamiStory.Data.HonamiStoryWeaponSuitData result;
		if (!this.WeaponSuitMap.TryGetValue(suitId, out result))
		{
			result = (this.WeaponSuitMap[suitId] = new CSharpScript.Game.Module.HonamiStory.Data.HonamiStoryWeaponSuitData(suitId));
		}
		return result;
	}

	// Token: 0x0600EEB7 RID: 61111 RVA: 0x0038F194 File Offset: 0x0038D394
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

	// Token: 0x0600EEB8 RID: 61112 RVA: 0x0038F1D8 File Offset: 0x0038D3D8
	public bool CheckItemPlayerAlreadyPick(int incId)
	{
		HonamiStoryBackpackData backPackData = this.GetBackPackData(2, false);
		HonamiStoryPlayerBackpackData playerBackpackData = this.GetPlayerBackpackData();
		return backPackData.GetItemDataByInstanceId(incId, false) != null || playerBackpackData.CheckItemByIncId(incId);
	}

	// Token: 0x0600EEB9 RID: 61113 RVA: 0x0038F208 File Offset: 0x0038D408
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

	// Token: 0x0600EEBA RID: 61114 RVA: 0x0038F258 File Offset: 0x0038D458
	private HonamiStoryItemDataBase CreateItemData(int itemId)
	{
		if (HonamiStoryConfig.Instance.GetHonamiStoryItem(itemId).Value.ItemType == 1)
		{
			return new HonamiStoryEquipItemData();
		}
		return new HonamiStoryItemDataBase();
	}

	// Token: 0x0600EEBB RID: 61115 RVA: 0x0038F290 File Offset: 0x0038D490
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

	// Token: 0x0600EEBC RID: 61116 RVA: 0x0038F2F0 File Offset: 0x0038D4F0
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

	// Token: 0x0600EEBD RID: 61117 RVA: 0x0038F348 File Offset: 0x0038D548
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
			this.QuestDataMapCache[taskType] = subQuestTaskDataList.Cast<HonamiStoryQuestDataBase>().ToList<HonamiStoryQuestDataBase>();
		}
		return this.QuestDataMapCache[taskType];
	}

	// Token: 0x0600EEBE RID: 61118 RVA: 0x0038F3CC File Offset: 0x0038D5CC
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

	// Token: 0x0600EEBF RID: 61119 RVA: 0x0038F57C File Offset: 0x0038D77C
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

	// Token: 0x0600EEC0 RID: 61120 RVA: 0x0038F600 File Offset: 0x0038D800
	public void InitBackPackInfoList(List<HonamiStoryBagInfo> backpackInfoList)
	{
		foreach (HonamiStoryBagInfo bagInfo in backpackInfoList)
		{
			this.InitBackPackInfo(bagInfo);
		}
	}

	// Token: 0x0600EEC1 RID: 61121 RVA: 0x0038F650 File Offset: 0x0038D850
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

	// Token: 0x0600EEC2 RID: 61122 RVA: 0x0038F6E8 File Offset: 0x0038D8E8
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

	// Token: 0x0600EEC3 RID: 61123 RVA: 0x0038F794 File Offset: 0x0038D994
	public bool GetSkillDescMode()
	{
		return LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.HonamiStorySkillDescMode, false);
	}

	// Token: 0x0600EEC4 RID: 61124 RVA: 0x0038F7A1 File Offset: 0x0038D9A1
	public void SetSkillDescMode(bool isSimple)
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.HonamiStorySkillDescMode, isSimple);
		EventSystem.Instance.Emit<bool>(EEventName.OnHonamiStorySkillDescModeChange, isSimple);
	}

	// Token: 0x0600EEC5 RID: 61125 RVA: 0x0038F7C0 File Offset: 0x0038D9C0
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

	// Token: 0x0600EEC6 RID: 61126 RVA: 0x0038F82C File Offset: 0x0038DA2C
	public void UpdateBackpackInfo(HonamiStoryBagInfoUpdateNotify updateInfo)
	{
		foreach (HonamiStoryBagInfo honamiStoryBagInfo in updateInfo.HonamiStoryBagInfos)
		{
			HonamiStoryBackpackData backPackData = this.GetBackPackData(honamiStoryBagInfo.BagConfigId, false);
			backPackData.SetCapacity(honamiStoryBagInfo.BagSize);
			backPackData.Update(honamiStoryBagInfo.HonamiStoryBagItemInfos.ToList<HonamiStoryBagItemInfo>());
		}
	}

	// Token: 0x0600EEC7 RID: 61127 RVA: 0x0038F89C File Offset: 0x0038DA9C
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

	// Token: 0x0600EEC8 RID: 61128 RVA: 0x0038F908 File Offset: 0x0038DB08
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
						inventory.UpdateByContext(honamiStoryBagUpdateInfo.ToList<HonamiStoryBagUpdateInfo>());
					}
				}
				else
				{
					this.GetBackPackData(backPackConfigId, false).UpdateByContext(honamiStoryBagUpdateInfo.ToList<HonamiStoryBagUpdateInfo>());
				}
			}
		}
	}

	// Token: 0x0600EEC9 RID: 61129 RVA: 0x0038F994 File Offset: 0x0038DB94
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

	// Token: 0x0600EECA RID: 61130 RVA: 0x0038FA48 File Offset: 0x0038DC48
	public bool IsPickUpViewOpened()
	{
		return UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryPickUpBackpackView) != null || UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryPickUpMobileView) != null;
	}

	// Token: 0x0600EECB RID: 61131 RVA: 0x0038FA70 File Offset: 0x0038DC70
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

	// Token: 0x0600EECC RID: 61132 RVA: 0x0038FB78 File Offset: 0x0038DD78
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

	// Token: 0x0600EECD RID: 61133 RVA: 0x0038FC54 File Offset: 0x0038DE54
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

	// Token: 0x0600EECE RID: 61134 RVA: 0x0038FCA0 File Offset: 0x0038DEA0
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

	// Token: 0x0600EECF RID: 61135 RVA: 0x0038FCEC File Offset: 0x0038DEEC
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

	// Token: 0x0600EED0 RID: 61136 RVA: 0x0038FD5C File Offset: 0x0038DF5C
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

	// Token: 0x0600EED1 RID: 61137 RVA: 0x0038FE3B File Offset: 0x0038E03B
	[NullableContext(2)]
	public HonamiStoryBackpackLogicController GetBackpackLogic()
	{
		return this.CurBackpackLogicController;
	}

	// Token: 0x0600EED2 RID: 61138 RVA: 0x0038FE43 File Offset: 0x0038E043
	[NullableContext(2)]
	public void SetBackpackLogic(HonamiStoryBackpackLogicController value)
	{
		if (this.CurBackpackLogicController != null)
		{
			this.CurBackpackLogicController.Destroy();
		}
		this.CurBackpackLogicController = value;
	}

	// Token: 0x0600EED3 RID: 61139 RVA: 0x0038FE5F File Offset: 0x0038E05F
	public EHonamiStoryBackpackLogicState GetBackpackLogicState()
	{
		return this.CurBackpackLogicController.GetLogicState();
	}

	// Token: 0x0600EED4 RID: 61140 RVA: 0x0038FE6C File Offset: 0x0038E06C
	public void SetBackpackLogicState(EHonamiStoryBackpackLogicState state)
	{
		this.CurBackpackLogicController.SetLogicState(state, null, null);
	}

	// Token: 0x0600EED5 RID: 61141 RVA: 0x0038FE90 File Offset: 0x0038E090
	public void ShowDiscardTips(HonamiStoryItemDataBase item)
	{
		string name = item.GetName();
		string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(name, name);
		ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_DiscardItemTips", new object[]
		{
			multiTextByKey
		});
	}

	// Token: 0x0600EED6 RID: 61142 RVA: 0x0038FECA File Offset: 0x0038E0CA
	public HonamiStoryInteractController GetInteractController()
	{
		return this.CurBackpackLogicController.GetInteractController();
	}

	// Token: 0x0600EED7 RID: 61143 RVA: 0x0038FED8 File Offset: 0x0038E0D8
	public int GetCurrencyCount()
	{
		int outCoinItemId = HonamiStoryConfig.Instance.GetHonamiStoryActivityConfig(this.ActivityData.Id).Value.OutCoinItemId;
		return InventoryModel.Instance.GetItemCountByConfigId(outCoinItemId, 0);
	}

	// Token: 0x0600EED8 RID: 61144 RVA: 0x0038FF18 File Offset: 0x0038E118
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

	// Token: 0x0600EED9 RID: 61145 RVA: 0x0039000C File Offset: 0x0038E20C
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

	// Token: 0x0600EEDA RID: 61146 RVA: 0x00390084 File Offset: 0x0038E284
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

	// Token: 0x0600EEDB RID: 61147 RVA: 0x003900D8 File Offset: 0x0038E2D8
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

	// Token: 0x0600EEDC RID: 61148 RVA: 0x00390188 File Offset: 0x0038E388
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

	// Token: 0x0600EEDD RID: 61149 RVA: 0x003901D4 File Offset: 0x0038E3D4
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

	// Token: 0x0600EEDE RID: 61150 RVA: 0x003902A4 File Offset: 0x0038E4A4
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

	// Token: 0x0600EEDF RID: 61151 RVA: 0x003902F8 File Offset: 0x0038E4F8
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

	// Token: 0x0600EEE0 RID: 61152 RVA: 0x00390400 File Offset: 0x0038E600
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

	// Token: 0x0600EEE1 RID: 61153 RVA: 0x0039044B File Offset: 0x0038E64B
	public void SetIsLastPickUpViewDirty(bool value)
	{
		this.IsLastPickUpViewDirty = value;
	}

	// Token: 0x0600EEE2 RID: 61154 RVA: 0x00390454 File Offset: 0x0038E654
	public bool GetIsLastPickUpViewDirty()
	{
		return HonamiStoryUtil.CheckInHonamiStoryDungeon() && this.IsLastPickUpViewDirty;
	}

	// Token: 0x0600EEE3 RID: 61155 RVA: 0x00390465 File Offset: 0x0038E665
	public void SetQuickAllDirty(bool needRefresh = true)
	{
		this.QuickAllManager.SetDirty();
		if (needRefresh && this.GetBackpackLogic() != null)
		{
			this.QuickAllRefresh(false);
			this.GetBackpackLogic().RefreshNeedQuickAll();
		}
	}

	// Token: 0x0600EEE4 RID: 61156 RVA: 0x00390490 File Offset: 0x0038E690
	public bool QuickAllRefresh(bool force = false)
	{
		return this.QuickAllManager.Refresh(force);
	}

	// Token: 0x0600EEE5 RID: 61157 RVA: 0x003904A0 File Offset: 0x0038E6A0
	public bool QuickAllCheck(bool needVirtual = true)
	{
		if (this.QuickAllManager.GetDirty())
		{
			this.QuickAllRefresh(false);
		}
		int powerLevel = this.GetPlayerBackpackData().GetPowerLevel(!needVirtual);
		return (needVirtual ? this.QuickAllManager.GetCurPowerLevel() : this.QuickAllManager.GetRealPowerLevel()) > powerLevel;
	}

	// Token: 0x0600EEE6 RID: 61158 RVA: 0x003904F0 File Offset: 0x0038E6F0
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

	// Token: 0x0600EEE7 RID: 61159 RVA: 0x00390530 File Offset: 0x0038E730
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

	// Token: 0x0600EEE8 RID: 61160 RVA: 0x003906D8 File Offset: 0x0038E8D8
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

	// Token: 0x0600EEE9 RID: 61161 RVA: 0x00390794 File Offset: 0x0038E994
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

	// Token: 0x0600EEEA RID: 61162 RVA: 0x0039085C File Offset: 0x0038EA5C
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

	// Token: 0x0600EEEB RID: 61163 RVA: 0x0039097C File Offset: 0x0038EB7C
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

	// Token: 0x0600EEEC RID: 61164 RVA: 0x00390AF0 File Offset: 0x0038ECF0
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

	// Token: 0x0600EEED RID: 61165 RVA: 0x00390DF0 File Offset: 0x0038EFF0
	[NullableContext(2)]
	public HonamiStoryGamepadLogicController GetGamepadLogic()
	{
		if (this.CurGamepadLogicController == null)
		{
			this.CurGamepadLogicController = new HonamiStoryGamepadLogicController();
		}
		return this.CurGamepadLogicController;
	}

	// Token: 0x0600EEEE RID: 61166 RVA: 0x00390E0B File Offset: 0x0038F00B
	[NullableContext(2)]
	public void SetGamepadLogic(HonamiStoryGamepadLogicController value)
	{
		this.CurGamepadLogicController = value;
	}

	// Token: 0x0600EEEF RID: 61167 RVA: 0x00390E14 File Offset: 0x0038F014
	public void SetMainTaskLoadingData(IHonamiStoryLoadingData data)
	{
		this.MainTaskParam = data;
	}

	// Token: 0x0600EEF0 RID: 61168 RVA: 0x00390E1D File Offset: 0x0038F01D
	public void SetGamePlayLoadingData(IHonamiStoryLoadingData data)
	{
		this.GamePlayParam = data;
	}

	// Token: 0x0600EEF1 RID: 61169 RVA: 0x00390E26 File Offset: 0x0038F026
	public void ClearCurLoadingData()
	{
		this.MainTaskParam = null;
		this.GamePlayParam = null;
	}

	// Token: 0x0600EEF2 RID: 61170 RVA: 0x00390E36 File Offset: 0x0038F036
	[NullableContext(2)]
	public IHonamiStoryLoadingData GetCurLoadingData()
	{
		return this.MainTaskParam ?? this.GamePlayParam;
	}

	// Token: 0x0600EEF3 RID: 61171 RVA: 0x00390E48 File Offset: 0x0038F048
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

	// Token: 0x170012D5 RID: 4821
	// (get) Token: 0x0600EEF4 RID: 61172 RVA: 0x00390F8D File Offset: 0x0038F18D
	public static HonamiStoryModel Instance
	{
		get
		{
			return HonamiStoryModel._Instance;
		}
	}

	// Token: 0x0600EEF5 RID: 61173 RVA: 0x00390F94 File Offset: 0x0038F194
	public static HonamiStoryModel GetOrCreateInstance()
	{
		if (HonamiStoryModel._Instance == null)
		{
			HonamiStoryModel.CreateInstance();
		}
		return HonamiStoryModel._Instance;
	}

	// Token: 0x0600EEF6 RID: 61174 RVA: 0x00390FA8 File Offset: 0x0038F1A8
	public static bool CreateInstance()
	{
		if (HonamiStoryModel._Instance != null)
		{
			return true;
		}
		HonamiStoryModel._Instance = new HonamiStoryModel();
		return true;
	}

	// Token: 0x0600EEF7 RID: 61175 RVA: 0x00390FBE File Offset: 0x0038F1BE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600EEF8 RID: 61176 RVA: 0x00390FC0 File Offset: 0x0038F1C0
	public static void ResetStaticDefaultValue()
	{
		HonamiStoryModel._Instance = null;
	}

	// Token: 0x0600EEF9 RID: 61177 RVA: 0x00390FC8 File Offset: 0x0038F1C8
	static HonamiStoryModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HonamiStoryModel.CreateStaticDefaultValue), new Action(HonamiStoryModel.ResetStaticDefaultValue));
	}

	// Token: 0x04006E8F RID: 28303
	public int ActivityId;

	// Token: 0x04006E90 RID: 28304
	public HonamiStoryQuickEquipAllManager QuickAllManager = new HonamiStoryQuickEquipAllManager();

	// Token: 0x04006E91 RID: 28305
	[Nullable(2)]
	protected HonamiStoryBackpackLogicController CurBackpackLogicController;

	// Token: 0x04006E92 RID: 28306
	[Nullable(2)]
	private HonamiStoryGamepadLogicController CurGamepadLogicController;

	// Token: 0x04006E93 RID: 28307
	protected List<IPickUpItemInfo> PickUpItemDataQueue = new List<IPickUpItemInfo>();

	// Token: 0x04006E94 RID: 28308
	protected double PickUpTime;

	// Token: 0x04006E95 RID: 28309
	protected bool IsPickingUp;

	// Token: 0x04006E96 RID: 28310
	public HashSet<int> PickedEntityId = new HashSet<int>();

	// Token: 0x04006E97 RID: 28311
	public readonly FRotator NormalRotation = global::Rotator.Create(0f, 0f, 0f).ToUeRotator();

	// Token: 0x04006E98 RID: 28312
	public readonly FRotator TransRotation = global::Rotator.Create(0f, 90f, 0f).ToUeRotator();

	// Token: 0x04006E99 RID: 28313
	protected bool IsLastPickUpViewDirty;

	// Token: 0x04006E9A RID: 28314
	public bool CanSafeLeave;

	// Token: 0x04006E9B RID: 28315
	public bool CacheShowSafeLeaveUpdate;

	// Token: 0x04006E9C RID: 28316
	public int PollutionLevel;

	// Token: 0x04006E9D RID: 28317
	public int PollutionMaxLevel;

	// Token: 0x04006E9E RID: 28318
	public float PollutionStarTime;

	// Token: 0x04006E9F RID: 28319
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, IHonamiStoryPollution> PollutionLevelMap;

	// Token: 0x04006EA0 RID: 28320
	public int PollutionWarningLevel;

	// Token: 0x04006EA1 RID: 28321
	public int PollutionDangerLevel;

	// Token: 0x04006EA2 RID: 28322
	public int MonsterBaseEnhanceLevel;

	// Token: 0x04006EA3 RID: 28323
	public int DangerLevel;

	// Token: 0x04006EA4 RID: 28324
	public int MonsterLevelSafeOffset;

	// Token: 0x04006EA5 RID: 28325
	public int MonsterLevelDangerOffset;

	// Token: 0x04006EA6 RID: 28326
	public int? ScanMarkId;

	// Token: 0x04006EA7 RID: 28327
	public HashSet<int> ScanMarkItemIds = new HashSet<int>();

	// Token: 0x04006EA8 RID: 28328
	public int CurrentUnlockFogId;

	// Token: 0x04006EA9 RID: 28329
	public int CurAreaId;

	// Token: 0x04006EAA RID: 28330
	[Nullable(2)]
	private IHonamiStoryLoadingData MainTaskParam;

	// Token: 0x04006EAB RID: 28331
	[Nullable(2)]
	private IHonamiStoryLoadingData GamePlayParam;

	// Token: 0x04006EAC RID: 28332
	[Nullable(2)]
	private HonamiStoryActivityData ActivityData;

	// Token: 0x04006EAD RID: 28333
	public HonamiStoryPlayerData PlayerData = HonamiStoryPlayerData.Create();

	// Token: 0x04006EAE RID: 28334
	private HonamiStoryPlayerBackpackData PlayerBackpackData;

	// Token: 0x04006EAF RID: 28335
	private readonly Dictionary<int, HonamiStoryWeaponData> WeaponDataMap = new Dictionary<int, HonamiStoryWeaponData>();

	// Token: 0x04006EB0 RID: 28336
	public int LastRecordRevenue;

	// Token: 0x04006EB1 RID: 28337
	private int TotalRevenueInternal;

	// Token: 0x04006EB2 RID: 28338
	[Nullable(2)]
	private HonamiStoryBackpackData WareHouseBackpackData;

	// Token: 0x04006EB3 RID: 28339
	private readonly Dictionary<int, HonamiStoryTechNodeData> TechNodeDataMap = new Dictionary<int, HonamiStoryTechNodeData>();

	// Token: 0x04006EB4 RID: 28340
	private readonly Dictionary<int, HonamiStoryTechAreaData> TechAreaDataMap = new Dictionary<int, HonamiStoryTechAreaData>();

	// Token: 0x04006EB5 RID: 28341
	[Nullable(2)]
	public HonamiStoryTechNodeData CurrentSelectNode;

	// Token: 0x04006EB6 RID: 28342
	[Nullable(2)]
	public HonamiStoryTechnologyNodeItem CurrentSelectNodeItem;

	// Token: 0x04006EB7 RID: 28343
	public Dictionary<int, int> RoleParentMap = new Dictionary<int, int>();

	// Token: 0x04006EB8 RID: 28344
	public Dictionary<int, HonamiStoryItemDataBase> ItemDataMap = new Dictionary<int, HonamiStoryItemDataBase>();

	// Token: 0x04006EB9 RID: 28345
	public Dictionary<int, CSharpScript.Game.Module.HonamiStory.Data.HonamiStoryWeaponSuitData> WeaponSuitMap = new Dictionary<int, CSharpScript.Game.Module.HonamiStory.Data.HonamiStoryWeaponSuitData>();

	// Token: 0x04006EBA RID: 28346
	public int[] AddLevel = new int[]
	{
		-1,
		-1
	};

	// Token: 0x04006EBB RID: 28347
	[Nullable(2)]
	public HonamiStoryQuestDataBase CurTrackTaskData;

	// Token: 0x04006EBC RID: 28348
	private readonly Dictionary<EHonamiStoryQuestType, List<HonamiStoryQuestDataBase>> QuestDataMapCache = new Dictionary<EHonamiStoryQuestType, List<HonamiStoryQuestDataBase>>();

	// Token: 0x04006EBD RID: 28349
	private readonly Dictionary<int, HonamiStoryBackpackData> BackpackDataMap = new Dictionary<int, HonamiStoryBackpackData>();

	// Token: 0x04006EBE RID: 28350
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

	// Token: 0x04006EBF RID: 28351
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

	// Token: 0x04006EC0 RID: 28352
	[Nullable(2)]
	private static HonamiStoryModel _Instance;
}
