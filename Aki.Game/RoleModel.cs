using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using CSharpScript.Game.Ui;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x02001E12 RID: 7698
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RoleModel : ModelBase
{
	// Token: 0x17001D16 RID: 7446
	// (get) Token: 0x0601304A RID: 77898 RVA: 0x0058FA27 File Offset: 0x0058DC27
	public bool IsInGamePlayRoleEdit
	{
		get
		{
			return this.RoleSkillBranchCacheTypeInternal > ESkillBranchCacheType.Normal;
		}
	}

	// Token: 0x17001D17 RID: 7447
	// (get) Token: 0x0601304B RID: 77899 RVA: 0x0058FA32 File Offset: 0x0058DC32
	public ESkillBranchCacheType RoleSkillBranchCacheType
	{
		get
		{
			return this.RoleSkillBranchCacheTypeInternal;
		}
	}

	// Token: 0x17001D18 RID: 7448
	// (get) Token: 0x0601304C RID: 77900 RVA: 0x0058FA3A File Offset: 0x0058DC3A
	// (set) Token: 0x0601304D RID: 77901 RVA: 0x0058FA42 File Offset: 0x0058DC42
	public bool IsInRoleTrial
	{
		get
		{
			return this.IsInRoleTrialInternal;
		}
		set
		{
			bool flag = this.IsInRoleTrialInternal != value;
			this.IsInRoleTrialInternal = value;
			OnlineModel.Instance.DisableOnline(EDisableOnlineType.TrialRole, value, 0, 0);
			if (flag)
			{
				EventSystem.Instance.Emit<bool>(EEventName.OnRoleTrialStateChanged, value);
			}
		}
	}

	// Token: 0x0601304E RID: 77902 RVA: 0x0058FA78 File Offset: 0x0058DC78
	public void SetCanUseSpecialTrialRole(bool value)
	{
		this.CanUseSpecialTrialRoleInternal = value;
	}

	// Token: 0x0601304F RID: 77903 RVA: 0x0058FA84 File Offset: 0x0058DC84
	public bool CanUseSpecialTrialRole(int? instanceId = null)
	{
		if (GameModeModel.Instance.IsMulti)
		{
			return false;
		}
		int? num = instanceId;
		InstanceDungeon? instanceDungeon;
		int? num2 = (num != null) ? num : ((GameModeModel.Instance.InstanceDungeon != null) ? new int?(instanceDungeon.GetValueOrDefault().Id) : null);
		return (num2 == null || this.IsDungeonCanUseSpecialTrialRole(num2.Value)) && this.CanUseSpecialTrialRoleInternal;
	}

	// Token: 0x06013050 RID: 77904 RVA: 0x0058FB04 File Offset: 0x0058DD04
	public bool IsDungeonCanUseSpecialTrialRole(int instanceId)
	{
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		if (config == null)
		{
			return false;
		}
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("NewTrialRoleEnableInsSubType");
		return intArrayConfig != null && intArrayConfig.IndexOf(config.Value.InstSubType) >= 0;
	}

	// Token: 0x06013051 RID: 77905 RVA: 0x0058FB53 File Offset: 0x0058DD53
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		return true;
	}

	// Token: 0x06013052 RID: 77906 RVA: 0x0058FB74 File Offset: 0x0058DD74
	public List<RoleDataBase> GetAllConfigRoleDataList()
	{
		List<RoleDataBase> list = new List<RoleDataBase>();
		HashSet<int> hashSet = new HashSet<int>();
		foreach (RoleInfo roleInfo in (RoleConfig.Instance.GetRoleList() ?? new List<RoleInfo>()))
		{
			if (roleInfo.RoleType == 1 && !hashSet.Contains(roleInfo.Id))
			{
				hashSet.Add(roleInfo.Id);
				int id = roleInfo.Id;
				RoleInstance roleInstance;
				bool flag = this.RoleInstanceMap.TryGetValue(id, out roleInstance);
				bool flag2 = RoleDevUtils.GetRoleTypeTagByRoleId(id) == ERoleTypeTag.Forecast;
				if ((flag || !this.IsMainRole(id)) && !flag2 && HandBookModel.Instance.GetRoleCanShowInHandBook(id))
				{
					if (roleInstance == null)
					{
						roleInstance = new RoleInstance(id);
					}
					list.Add(roleInstance);
				}
			}
		}
		this.SortRoleDataList(list);
		return list;
	}

	// Token: 0x06013053 RID: 77907 RVA: 0x0058FC60 File Offset: 0x0058DE60
	public List<int> GetAllConfigRoleIdList()
	{
		List<int> list = new List<int>();
		HashSet<int> hashSet = new HashSet<int>();
		foreach (RoleInfo roleInfo in (RoleConfig.Instance.GetRoleList() ?? new List<RoleInfo>()))
		{
			if (roleInfo.RoleType == 1 && !hashSet.Contains(roleInfo.Id))
			{
				hashSet.Add(roleInfo.Id);
				int id = roleInfo.Id;
				RoleInstance roleInstance;
				bool flag = this.RoleInstanceMap.TryGetValue(id, out roleInstance);
				bool flag2 = RoleDevUtils.GetRoleTypeTagByRoleId(id) == ERoleTypeTag.Forecast;
				if ((flag || !this.IsMainRole(id)) && !flag2 && HandBookModel.Instance.GetRoleCanShowInHandBook(id))
				{
					list.Add(id);
				}
			}
		}
		this.SortRoleIdList(list);
		return list;
	}

	// Token: 0x06013054 RID: 77908 RVA: 0x0058FD38 File Offset: 0x0058DF38
	public void SortRoleDataList(List<RoleDataBase> resultList)
	{
		resultList.Sort(new Comparison<RoleDataBase>(this.SortByFormationLevelQuality));
	}

	// Token: 0x06013055 RID: 77909 RVA: 0x0058FD4C File Offset: 0x0058DF4C
	private void SortRoleIdList(List<int> roleIdList)
	{
		roleIdList.Sort(delegate(int a, int b)
		{
			RoleDataBase roleDataByIdOrCreateDefault = this.GetRoleDataByIdOrCreateDefault(a);
			RoleDataBase roleDataByIdOrCreateDefault2 = this.GetRoleDataByIdOrCreateDefault(b);
			if (roleDataByIdOrCreateDefault == null || roleDataByIdOrCreateDefault2 == null)
			{
				return 0;
			}
			return this.SortByFormationLevelQuality(roleDataByIdOrCreateDefault, roleDataByIdOrCreateDefault2);
		});
	}

	// Token: 0x06013056 RID: 77910 RVA: 0x0058FD60 File Offset: 0x0058DF60
	private int SortByFormationLevelQuality(RoleDataBase a, RoleDataBase b)
	{
		int num = this.SortFormation(a, b);
		if (num != 0)
		{
			return num;
		}
		int num2 = this.SortLevel(a, b);
		if (num2 != 0)
		{
			return num2;
		}
		return this.SortQuality(a, b);
	}

	// Token: 0x06013057 RID: 77911 RVA: 0x0058FD94 File Offset: 0x0058DF94
	private int SortFormation(RoleDataBase a, RoleDataBase b)
	{
		int num = -1;
		int num2 = -1;
		List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(false);
		for (int i = 0; i < teamItems.Count; i++)
		{
			SceneTeamItem sceneTeamItem = teamItems[i];
			if (a.GetDataId() == sceneTeamItem.GetConfigId)
			{
				num = i;
			}
			if (b.GetDataId() == sceneTeamItem.GetConfigId)
			{
				num2 = i;
			}
		}
		SceneTeamItem sceneTeamItem2 = (num >= 0 && num < teamItems.Count) ? teamItems[num] : null;
		object obj = (num2 >= 0 && num2 < teamItems.Count) ? teamItems[num2] : null;
		bool flag = sceneTeamItem2 != null;
		bool flag2 = obj != null;
		if (!flag && !flag2)
		{
			return 0;
		}
		if (flag != flag2)
		{
			int num3 = (flag > false) ? 1 : 0;
			return ((flag2 > false) ? 1 : 0) - num3;
		}
		return num - num2;
	}

	// Token: 0x06013058 RID: 77912 RVA: 0x0058FE50 File Offset: 0x0058E050
	private int SortLevel(RoleDataBase a, RoleDataBase b)
	{
		RoleLevelData levelData = a.GetLevelData();
		RoleLevelData levelData2 = b.GetLevelData();
		if (levelData.GetLevel() != levelData2.GetLevel())
		{
			return levelData2.GetLevel() - levelData.GetLevel();
		}
		if (levelData.GetBreachLevel() != levelData2.GetBreachLevel())
		{
			return levelData2.GetBreachLevel() - levelData.GetBreachLevel();
		}
		return 0;
	}

	// Token: 0x06013059 RID: 77913 RVA: 0x0058FEA4 File Offset: 0x0058E0A4
	private int SortQuality(RoleDataBase a, RoleDataBase b)
	{
		int qualityId = a.GetRoleConfig().QualityId;
		int qualityId2 = b.GetRoleConfig().QualityId;
		if (qualityId != qualityId2)
		{
			return qualityId2 - qualityId;
		}
		return 0;
	}

	// Token: 0x0601305A RID: 77914 RVA: 0x0058FED8 File Offset: 0x0058E0D8
	[NullableContext(2)]
	public RoleDataBase GetRoleDataByIdOrCreateDefault(int roleId)
	{
		if (RoleConfig.Instance.GetRoleConfig(roleId) == null)
		{
			return null;
		}
		RoleInstance result;
		if (!this.RoleInstanceMap.TryGetValue(roleId, out result))
		{
			result = new RoleInstance(roleId);
		}
		return result;
	}

	// Token: 0x0601305B RID: 77915 RVA: 0x0058FF14 File Offset: 0x0058E114
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.RoleDataItem);
		this.IsInRoleTrial = false;
		this.RoleTrialShowMap.Clear();
		this.RoleInstanceMap.Clear();
		this.MainRoleIdMap.Clear();
		this.RoleRobotDataMap.Clear();
		this.RoleCommonRobotDataMap.Clear();
		this.RoleSpecialRobotDataMap.Clear();
		return true;
	}

	// Token: 0x0601305C RID: 77916 RVA: 0x0058FF94 File Offset: 0x0058E194
	public void UpdateRoleInfoByServerData(roleInfo[] roleDataList)
	{
		foreach (roleInfo roleInfo in roleDataList)
		{
			this.UpdateRoleInfo(roleInfo);
			EventSystem.Instance.Emit<int>(EEventName.RoleInfoUpdate, roleInfo.RoleId);
		}
	}

	// Token: 0x0601305D RID: 77917 RVA: 0x0058FFD2 File Offset: 0x0058E1D2
	public void RoleChange(int sourceRoleId, roleInfo roleInfo)
	{
		this.RoleInstanceMap.Remove(sourceRoleId);
		this.UpdateRoleInfo(roleInfo);
		EventSystem.Instance.Emit<int>(EEventName.RoleSystemDeleteRole, sourceRoleId);
		EventSystem.Instance.Emit<int>(EEventName.RoleSystemChangeRole, roleInfo.RoleId);
	}

	// Token: 0x0601305E RID: 77918 RVA: 0x00590010 File Offset: 0x0058E210
	public void UpdateRoleInfo(roleInfo roleInfo)
	{
		RoleInstance roleInstance = null;
		if (this.RoleInstanceMap.ContainsKey(roleInfo.RoleId))
		{
			roleInstance = this.RoleInstanceMap[roleInfo.RoleId];
		}
		if (roleInstance == null)
		{
			roleInstance = new RoleInstance(roleInfo.RoleId);
			this.RoleInstanceMap[roleInfo.RoleId] = roleInstance;
		}
		if (this.IsMainRole(roleInfo.RoleId))
		{
			this.UpdateMainRoleMap(roleInfo.RoleId);
			EventSystem.Instance.Emit<EFunction>(EEventName.RefreshMenuSetting, EFunction.GENDERSETTING);
		}
		roleInstance.RefreshRoleInfo(roleInfo);
	}

	// Token: 0x0601305F RID: 77919 RVA: 0x00590098 File Offset: 0x0058E298
	public void UpdateMainRoleMap(int newMainRoleId)
	{
		foreach (int key in this.GetMainRoleSet())
		{
			this.MainRoleIdMap[key] = newMainRoleId;
		}
	}

	// Token: 0x06013060 RID: 77920 RVA: 0x005900F4 File Offset: 0x0058E2F4
	public void RoleLevelUp(int roleId, int exp, int level)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		RoleLevelData levelData = roleInstanceById.GetLevelData();
		int level2 = levelData.GetLevel();
		if (roleInstanceById != null)
		{
			levelData.SetLevel(level);
			levelData.SetExp(exp);
		}
		EventSystem.Instance.Emit<int>(EEventName.RoleInfoUpdate, roleId);
		if (level2 < level)
		{
			EventSystem.Instance.Emit<int, int, int>(EEventName.RoleLevelUp, roleId, exp, level);
		}
	}

	// Token: 0x06013061 RID: 77921 RVA: 0x00590150 File Offset: 0x0058E350
	public void RoleLevelUpReceiveItem(Dictionary<int, int> itemMap)
	{
		List<TItem> list = new List<TItem>();
		foreach (KeyValuePair<int, int> keyValuePair in itemMap)
		{
			int key = keyValuePair.Key;
			TItem item = new TItem
			{
				ItemData = new InventoryDefine.GetItemData(key, 0),
				Count = keyValuePair.Value
			};
			list.Add(item);
		}
		EventSystem.Instance.Emit<IReadOnlyList<TItem>>(EEventName.RoleLevelUpReceiveItem, list);
	}

	// Token: 0x06013062 RID: 77922 RVA: 0x005901E8 File Offset: 0x0058E3E8
	public void RoleBreakUp(int roleId, int breakLevel)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		if (roleInstanceById != null)
		{
			roleInstanceById.GetLevelData().SetBreachLevel(breakLevel);
		}
		EventSystem.Instance.Emit<int>(EEventName.RoleInfoUpdate, roleId);
		EventSystem.Instance.Emit<int, int>(EEventName.RoleBreakUp, roleId, breakLevel);
	}

	// Token: 0x06013063 RID: 77923 RVA: 0x00590230 File Offset: 0x0058E430
	public void RoleSkillLevelUp(int roleId, ArrayIntInt skillInfo)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		if (roleInstanceById != null)
		{
			roleInstanceById.RefreshSkillInfo(skillInfo.Key, skillInfo.Value);
		}
		EventSystem.Instance.Emit<int, ArrayIntInt>(EEventName.RoleSkillLevelUp, roleId, skillInfo);
	}

	// Token: 0x06013064 RID: 77924 RVA: 0x0059026C File Offset: 0x0058E46C
	public void RoleNameUpdate(int roleId, string name)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		if (roleInstanceById != null)
		{
			roleInstanceById.SetRoleName(name);
			EventSystem.Instance.Emit(EEventName.RoleRefreshName);
		}
	}

	// Token: 0x06013065 RID: 77925 RVA: 0x0059029C File Offset: 0x0058E49C
	public void RoleAttrUpdate(int roleId, ArrayIntInt[] baseAttr, ArrayIntInt[] addAttr)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		if (roleInstanceById != null)
		{
			roleInstanceById.RefreshRoleAttr(baseAttr, addAttr);
		}
	}

	// Token: 0x06013066 RID: 77926 RVA: 0x005902BC File Offset: 0x0058E4BC
	public void RoleResonanceLockFinish(PbRoleResonLockFinishNotify notify)
	{
		this.RoleInstanceMap[notify.RoleId].GetResonanceData().SetResonanceLock(notify.ResonId);
	}

	// Token: 0x06013067 RID: 77927 RVA: 0x005902DF File Offset: 0x0058E4DF
	public RoleViewAgent GetRoleViewAgent(ERoleAgentType agentType)
	{
		if (agentType == ERoleAgentType.Preview)
		{
			return new RolePreviewAgent();
		}
		if (agentType != ERoleAgentType.RoleNewJoin)
		{
			return new RoleViewAgent();
		}
		return new RoleNewJoinAgent();
	}

	// Token: 0x17001D19 RID: 7449
	// (get) Token: 0x06013068 RID: 77928 RVA: 0x005902FC File Offset: 0x0058E4FC
	// (set) Token: 0x06013069 RID: 77929 RVA: 0x00590304 File Offset: 0x0058E504
	public bool IsShowMultiSkillDesc
	{
		get
		{
			return this.IsShowMultiSkillDescInternal;
		}
		set
		{
			this.IsShowMultiSkillDescInternal = value;
		}
	}

	// Token: 0x17001D1A RID: 7450
	// (get) Token: 0x0601306A RID: 77930 RVA: 0x0059030D File Offset: 0x0058E50D
	// (set) Token: 0x0601306B RID: 77931 RVA: 0x00590317 File Offset: 0x0058E517
	public bool IsShowSkillResume
	{
		get
		{
			return LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.ShowSkillResume, false);
		}
		set
		{
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ShowSkillResume, value);
		}
	}

	// Token: 0x17001D1B RID: 7451
	// (get) Token: 0x0601306C RID: 77932 RVA: 0x00590322 File Offset: 0x0058E522
	// (set) Token: 0x0601306D RID: 77933 RVA: 0x0059032C File Offset: 0x0058E52C
	public bool IsShowSkillShowTag
	{
		get
		{
			return LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.ShowSkillShowTag, true);
		}
		set
		{
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.ShowSkillShowTag, value);
		}
	}

	// Token: 0x0601306E RID: 77934 RVA: 0x00590337 File Offset: 0x0058E537
	public bool IsSkillShowTagUnlocked()
	{
		return FunctionModel.Instance.IsOpen(EFunctionType.RoleDev);
	}

	// Token: 0x0601306F RID: 77935 RVA: 0x00590348 File Offset: 0x0058E548
	public ERoleSkillDescType GetRoleSkillDescType()
	{
		if (GameModeModel.Instance.IsMulti)
		{
			return ERoleSkillDescType.MultiDesc;
		}
		return ERoleSkillDescType.ResumeDesc;
	}

	// Token: 0x06013070 RID: 77936 RVA: 0x0059035C File Offset: 0x0058E55C
	public RoleInstance[] GetRoleList()
	{
		List<int> list = new List<int>(this.RoleInstanceMap.Keys);
		this.SortRoleList(list, null);
		List<RoleInstance> list2 = new List<RoleInstance>();
		foreach (int key in list)
		{
			RoleInstance roleInstance = this.RoleInstanceMap[key];
			if (roleInstance.GetRoleConfig().RoleType == 1)
			{
				list2.Add(roleInstance);
			}
		}
		return list2.ToArray();
	}

	// Token: 0x06013071 RID: 77937 RVA: 0x005903F4 File Offset: 0x0058E5F4
	public RoleInstance[] GetRoleListWithoutMainRole()
	{
		List<int> list = new List<int>(this.RoleInstanceMap.Keys);
		this.SortRoleList(list, null);
		List<RoleInstance> list2 = new List<RoleInstance>();
		foreach (int num in list)
		{
			RoleInstance roleInstance = this.RoleInstanceMap[num];
			if (roleInstance.GetRoleConfig().RoleType == 1 && !this.IsMainRole(num))
			{
				list2.Add(roleInstance);
			}
		}
		return list2.ToArray();
	}

	// Token: 0x06013072 RID: 77938 RVA: 0x00590494 File Offset: 0x0058E694
	public List<RoleDataBase> GetRoleDataList(bool includeRobots = false)
	{
		List<RoleDataBase> list = new List<RoleDataBase>();
		foreach (int key in new List<int>(this.RoleInstanceMap.Keys))
		{
			RoleInstance roleInstance = this.RoleInstanceMap[key];
			if (roleInstance.GetRoleConfig().RoleType == 1)
			{
				list.Add(roleInstance);
			}
		}
		if (includeRobots)
		{
			foreach (int key2 in new List<int>(this.RoleSpecialRobotDataMap.Keys))
			{
				RoleSpecialRobotData roleSpecialRobotData;
				if (this.RoleSpecialRobotDataMap.TryGetValue(key2, out roleSpecialRobotData) && roleSpecialRobotData != null && roleSpecialRobotData.IsVisibleInFormation())
				{
					list.Add(roleSpecialRobotData);
				}
			}
		}
		list.Sort((RoleDataBase a, RoleDataBase b) => this.CompareByCondition(a.GetDataId(), b.GetDataId()));
		return list;
	}

	// Token: 0x06013073 RID: 77939 RVA: 0x00590598 File Offset: 0x0058E798
	public Dictionary<int, RoleDataBase> GetRoleDataMap(bool includeRobots = false)
	{
		Dictionary<int, RoleInstance> roleMap = this.GetRoleMap();
		if (!includeRobots)
		{
			Dictionary<int, RoleDataBase> dictionary = new Dictionary<int, RoleDataBase>();
			foreach (KeyValuePair<int, RoleInstance> keyValuePair in roleMap)
			{
				dictionary[keyValuePair.Key] = keyValuePair.Value;
			}
			return dictionary;
		}
		Dictionary<int, RoleDataBase> dictionary2 = new Dictionary<int, RoleDataBase>();
		foreach (KeyValuePair<int, RoleInstance> keyValuePair2 in roleMap)
		{
			dictionary2[keyValuePair2.Key] = keyValuePair2.Value;
		}
		foreach (KeyValuePair<int, RoleSpecialRobotData> keyValuePair3 in this.RoleSpecialRobotDataMap)
		{
			RoleSpecialRobotData value = keyValuePair3.Value;
			if (value != null && value.IsVisibleInFormation())
			{
				dictionary2[keyValuePair3.Key] = keyValuePair3.Value;
			}
		}
		return dictionary2;
	}

	// Token: 0x06013074 RID: 77940 RVA: 0x005906C0 File Offset: 0x0058E8C0
	public Dictionary<int, RoleInstance> GetRoleMap()
	{
		return this.RoleInstanceMap;
	}

	// Token: 0x06013075 RID: 77941 RVA: 0x005906C8 File Offset: 0x0058E8C8
	public Dictionary<int, RoleRobotData> GetRoleRobotMap()
	{
		return this.RoleRobotDataMap;
	}

	// Token: 0x06013076 RID: 77942 RVA: 0x005906D0 File Offset: 0x0058E8D0
	public Dictionary<int, RoleRobotData> GetCommonRoleRobotMap()
	{
		return this.RoleCommonRobotDataMap;
	}

	// Token: 0x06013077 RID: 77943 RVA: 0x005906D8 File Offset: 0x0058E8D8
	public Dictionary<int, RoleSpecialRobotData> GetRoleFormationRobotMap()
	{
		return this.RoleSpecialRobotDataMap;
	}

	// Token: 0x06013078 RID: 77944 RVA: 0x005906E0 File Offset: 0x0058E8E0
	public int? GetBattleTeamFirstRoleId()
	{
		SceneTeamItem getCurrentTeamItem = SceneTeamModel.Instance.GetCurrentTeamItem;
		if (getCurrentTeamItem == null)
		{
			return null;
		}
		return new int?(getCurrentTeamItem.GetConfigId);
	}

	// Token: 0x06013079 RID: 77945 RVA: 0x00590710 File Offset: 0x0058E910
	private int CompareByCondition(int a, int b)
	{
		int num = -1;
		int num2 = -1;
		List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(true);
		for (int i = 0; i < teamItems.Count; i++)
		{
			SceneTeamItem sceneTeamItem = teamItems[i];
			if (a == sceneTeamItem.GetConfigId)
			{
				num = i;
			}
			if (b == sceneTeamItem.GetConfigId)
			{
				num2 = i;
			}
		}
		SceneTeamItem sceneTeamItem2 = (num >= 0 && num < teamItems.Count) ? teamItems[num] : null;
		object obj = (num2 >= 0 && num2 < teamItems.Count) ? teamItems[num2] : null;
		bool flag = sceneTeamItem2 != null;
		bool flag2 = obj != null;
		if (flag != flag2)
		{
			int num3 = (flag > false) ? 1 : 0;
			return ((flag2 > false) ? 1 : 0) - num3;
		}
		if (flag)
		{
			return num - num2;
		}
		RoleDataBase roleDataById = this.GetRoleDataById(a, true);
		RoleDataBase roleDataById2 = this.GetRoleDataById(b, true);
		return this.DefaultSortFunc(roleDataById, roleDataById2);
	}

	// Token: 0x0601307A RID: 77946 RVA: 0x005907DC File Offset: 0x0058E9DC
	private void SortRoleList(List<int> roleIdList, [Nullable(2)] Comparison<int> customCompare = null)
	{
		if (customCompare != null)
		{
			roleIdList.Sort(customCompare);
			return;
		}
		roleIdList.Sort(delegate(int a, int b)
		{
			int num = -1;
			int num2 = -1;
			List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(true);
			for (int i = 0; i < teamItems.Count; i++)
			{
				SceneTeamItem sceneTeamItem = teamItems[i];
				if (a == sceneTeamItem.GetConfigId)
				{
					num = i;
				}
				if (b == sceneTeamItem.GetConfigId)
				{
					num2 = i;
				}
			}
			SceneTeamItem sceneTeamItem2 = (num >= 0) ? teamItems[num] : null;
			object obj = (num2 >= 0) ? teamItems[num2] : null;
			bool flag = sceneTeamItem2 != null;
			bool flag2 = obj != null;
			if (flag != flag2)
			{
				int num3 = (flag > false) ? 1 : 0;
				return ((flag2 > false) ? 1 : 0) - num3;
			}
			if (flag)
			{
				return num - num2;
			}
			RoleDataBase roleDataById = this.GetRoleDataById(a, true);
			RoleDataBase roleDataById2 = this.GetRoleDataById(b, true);
			return this.DefaultSortFunc(roleDataById, roleDataById2);
		});
	}

	// Token: 0x0601307B RID: 77947 RVA: 0x005907FC File Offset: 0x0058E9FC
	public int CompareForMainView(int a, int b)
	{
		RoleModel.<>c__DisplayClass73_0 CS$<>8__locals1;
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.myItems = SceneTeamModel.Instance.GetTeamItems(true);
		CS$<>8__locals1.devTargetRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
		int num2;
		int num = this.<CompareForMainView>g__GetTier|73_0(a, out num2, ref CS$<>8__locals1);
		int num4;
		int num3 = this.<CompareForMainView>g__GetTier|73_0(b, out num4, ref CS$<>8__locals1);
		if (num != num3)
		{
			return num - num3;
		}
		if (num == 0)
		{
			return num2 - num4;
		}
		RoleDataBase roleDataById = this.GetRoleDataById(a, true);
		RoleDataBase roleDataById2 = this.GetRoleDataById(b, true);
		return this.DefaultSortFunc(roleDataById, roleDataById2);
	}

	// Token: 0x0601307C RID: 77948 RVA: 0x0059087C File Offset: 0x0058EA7C
	public int DefaultSortFunc(RoleDataBase a, RoleDataBase b)
	{
		RoleLevelData levelData = a.GetLevelData();
		RoleLevelData levelData2 = b.GetLevelData();
		if (levelData.GetLevel() != levelData2.GetLevel())
		{
			return levelData2.GetLevel() - levelData.GetLevel();
		}
		if (a.GetRoleConfig().QualityId != b.GetRoleConfig().QualityId)
		{
			return b.GetRoleConfig().QualityId - a.GetRoleConfig().QualityId;
		}
		if (a.GetRoleConfig().Priority != b.GetRoleConfig().Priority)
		{
			return b.GetRoleConfig().Priority - a.GetRoleConfig().Priority;
		}
		return 0;
	}

	// Token: 0x0601307D RID: 77949 RVA: 0x0059092C File Offset: 0x0058EB2C
	[NullableContext(2)]
	public RoleDataBase GetRoleDataById(int id, bool isSelf = true)
	{
		RoleDataBase roleDataBase = null;
		if (!isSelf)
		{
			return new RoleOnlineInstanceData(id);
		}
		if (id > 100000)
		{
			roleDataBase = this.GetRoleRobotData(id);
		}
		else
		{
			if (this.RoleInstanceMap.ContainsKey(id))
			{
				roleDataBase = this.RoleInstanceMap[id];
			}
			if (roleDataBase == null && this.IsMainRole(id))
			{
				int? newMainRoleId = this.GetNewMainRoleId(id);
				if (newMainRoleId != null && this.RoleInstanceMap.ContainsKey(newMainRoleId.Value))
				{
					roleDataBase = this.RoleInstanceMap[newMainRoleId.Value];
				}
			}
		}
		return roleDataBase;
	}

	// Token: 0x0601307E RID: 77950 RVA: 0x005909B8 File Offset: 0x0058EBB8
	public int? GetNewMainRoleId(int oldMainRoleId)
	{
		if (this.MainRoleIdMap.ContainsKey(oldMainRoleId))
		{
			return new int?(this.MainRoleIdMap[oldMainRoleId]);
		}
		return null;
	}

	// Token: 0x0601307F RID: 77951 RVA: 0x005909F0 File Offset: 0x0058EBF0
	[NullableContext(2)]
	public RoleDataBase GetRoleDataByTrialRoleId(int trialRoleId)
	{
		RoleDataBase roleDataBase = null;
		if (!RoleUtils.IsTrialRole(trialRoleId))
		{
			return roleDataBase;
		}
		int trailRoleRealRoleId = RoleUtils.GetTrailRoleRealRoleId(trialRoleId);
		RoleInstance roleInstance;
		if (this.RoleInstanceMap.TryGetValue(trailRoleRealRoleId, out roleInstance))
		{
			roleDataBase = roleInstance;
		}
		if (roleDataBase == null && this.IsMainRole(trailRoleRealRoleId))
		{
			roleDataBase = this.GetCurSelectMainRoleInstance();
		}
		if (roleDataBase == null)
		{
			roleDataBase = this.GetRoleRobotData(trialRoleId);
		}
		return roleDataBase;
	}

	// Token: 0x06013080 RID: 77952 RVA: 0x00590A44 File Offset: 0x0058EC44
	public RoleRobotData GetRoleRobotData(int id)
	{
		RoleRobotData roleRobotData = null;
		if (this.RoleRobotDataMap.ContainsKey(id))
		{
			roleRobotData = this.RoleRobotDataMap[id];
		}
		if (roleRobotData == null)
		{
			if (RoleUtils.IsSpecialTrialRole(id))
			{
				roleRobotData = new RoleSpecialRobotData(id);
				this.RoleSpecialRobotDataMap[id] = (roleRobotData as RoleSpecialRobotData);
			}
			else
			{
				roleRobotData = new RoleRobotData(id);
				this.RoleCommonRobotDataMap[id] = roleRobotData;
			}
			this.RoleRobotDataMap[id] = roleRobotData;
		}
		return roleRobotData;
	}

	// Token: 0x06013081 RID: 77953 RVA: 0x00590AB8 File Offset: 0x0058ECB8
	public bool HasAnyTrialRole()
	{
		using (List<int>.Enumerator enumerator = this.GetRoleSystemRoleList(false, null).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current > 100000)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06013082 RID: 77954 RVA: 0x00590B14 File Offset: 0x0058ED14
	[NullableContext(2)]
	public RoleInstance GetRoleInstanceById(int id)
	{
		if (this.RoleInstanceMap.ContainsKey(id))
		{
			return this.RoleInstanceMap[id];
		}
		return null;
	}

	// Token: 0x06013083 RID: 77955 RVA: 0x00590B34 File Offset: 0x0058ED34
	public string GetRoleName(int roleId, int? playerId = null)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		if (roleDataById != null)
		{
			return roleDataById.GetName(playerId);
		}
		return ConfigMultiTextLang.GetLocalTextNew(RoleConfig.Instance.GetRoleConfig(roleId).Value.Name, null);
	}

	// Token: 0x06013084 RID: 77956 RVA: 0x00590B7C File Offset: 0x0058ED7C
	private int SimulateAutoAddExpItem(int needExp, ISelectedData[] sourceList, Func<ISelectedData, int> getExp)
	{
		int num = 0;
		WeaponModel.Instance.AutoAddExpItemEx(needExp, sourceList, getExp);
		foreach (ISelectedData selectedData in sourceList)
		{
			num += selectedData.SelectedCount * getExp(selectedData);
		}
		return num;
	}

	// Token: 0x06013085 RID: 77957 RVA: 0x00590BC0 File Offset: 0x0058EDC0
	public ISelectedData[] GetExpItemInInventory()
	{
		List<ISelectedData> list = new List<ISelectedData>();
		foreach (ItemInfo itemInfo in RoleModel.Instance.GetRoleCostExpList())
		{
			SelectedData item = new SelectedData
			{
				IncId = 0,
				ItemId = itemInfo.Id,
				Count = InventoryModel.Instance.GetCommonItemCount(itemInfo.Id, 0),
				SelectedCount = 0
			};
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x06013086 RID: 77958 RVA: 0x00590C3C File Offset: 0x0058EE3C
	public int GetSelectLevelUpItemNeedMoney(int roleId)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		RoleLevelData roleLevelData = (roleInstanceById != null) ? roleInstanceById.GetLevelData() : null;
		if (roleLevelData == null)
		{
			return 0;
		}
		int levelUpNeedExp = roleLevelData.GetLevelUpNeedExp();
		ISelectedData[] expItemInInventory = this.GetExpItemInInventory();
		int exp = this.SimulateAutoAddExpItem(levelUpNeedExp, expItemInInventory, (ISelectedData data) => this.GetRoleExpItemExp(data.ItemId).GetValueOrDefault());
		return this.GetMoneyToLevelUp(exp);
	}

	// Token: 0x06013087 RID: 77959 RVA: 0x00590C8C File Offset: 0x0058EE8C
	public int GetMoneyToLevelUp(int exp)
	{
		int value = ConfigCommonParamById.GetIntConfig("ExpConversionCount").Value;
		return (int)Math.Ceiling((double)(exp * value) / 1000.0);
	}

	// Token: 0x06013088 RID: 77960 RVA: 0x00590CC0 File Offset: 0x0058EEC0
	public bool GetHasEnoughMoneyLevelUp(int roleId)
	{
		int selectLevelUpItemNeedMoney = this.GetSelectLevelUpItemNeedMoney(roleId);
		int playerMoney = PlayerInfoModel.Instance.GetPlayerMoney(2);
		return selectLevelUpItemNeedMoney <= playerMoney;
	}

	// Token: 0x06013089 RID: 77961 RVA: 0x00590CE8 File Offset: 0x0058EEE8
	public bool GetSelectHasEnoughItemToLevelUp(int roleId)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		RoleLevelData roleLevelData = (roleInstanceById != null) ? roleInstanceById.GetLevelData() : null;
		if (roleLevelData == null)
		{
			return false;
		}
		int levelUpNeedExp = roleLevelData.GetLevelUpNeedExp();
		int num = 0;
		foreach (ItemInfo itemInfo in this.GetRoleCostExpList())
		{
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(itemInfo.Id, 0);
			num += this.GetRoleExpItemExp(itemInfo.Id).GetValueOrDefault() * commonItemCount;
		}
		return num >= levelUpNeedExp;
	}

	// Token: 0x0601308A RID: 77962 RVA: 0x00590D74 File Offset: 0x0058EF74
	public ERoleBreachState GetRoleBreachState(int roleId)
	{
		RoleLevelData levelData = this.GetRoleInstanceById(roleId).GetLevelData();
		RoleBreach? breachConfig = levelData.GetBreachConfig(levelData.GetBreachLevel() + 1);
		if (breachConfig == null)
		{
			return ERoleBreachState.MaxLevel;
		}
		if (!LevelGeneralController.Instance.CheckCondition(breachConfig.Value.ConditionId.ToString(), null, true, Array.Empty<object>()))
		{
			return ERoleBreachState.NoEnoughCondition;
		}
		foreach (KeyValuePair<int, int> keyValuePair in breachConfig.Value.BreachConsume())
		{
			if (keyValuePair.Key == 2)
			{
				if (PlayerInfoModel.Instance.GetPlayerMoney(2) < keyValuePair.Value)
				{
					return ERoleBreachState.NoEnoughMoney;
				}
			}
			else if (InventoryModel.Instance.GetItemCountByConfigId(keyValuePair.Key, 0) < keyValuePair.Value)
			{
				return ERoleBreachState.NoEnoughMaterial;
			}
		}
		return ERoleBreachState.CanBreach;
	}

	// Token: 0x0601308B RID: 77963 RVA: 0x00590E64 File Offset: 0x0058F064
	public bool GetRoleNeedBreakUp(int roleId)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		return roleInstanceById != null && roleInstanceById.GetLevelData().GetRoleNeedBreakUp();
	}

	// Token: 0x0601308C RID: 77964 RVA: 0x00590E8C File Offset: 0x0058F08C
	public ItemInfo[] GetRoleCostExpList()
	{
		List<ItemInfo> list = new List<ItemInfo>();
		IReadOnlyList<RoleExpItem> roleExpItemList = RoleConfig.Instance.GetRoleExpItemList();
		if (roleExpItemList != null)
		{
			foreach (RoleExpItem roleExpItem in roleExpItemList)
			{
				ItemInfo? config = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfig(roleExpItem.Id);
				if (config != null)
				{
					list.Add(config.Value);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x0601308D RID: 77965 RVA: 0x00590F10 File Offset: 0x0058F110
	public int? GetRoleExpItemExp(int itemId)
	{
		return RoleConfig.Instance.GetRoleExpItemExp(itemId);
	}

	// Token: 0x0601308E RID: 77966 RVA: 0x00590F20 File Offset: 0x0058F120
	public RoleInstance[] GetAllRoleList()
	{
		List<RoleInstance> list = new List<RoleInstance>();
		foreach (KeyValuePair<int, RoleInstance> keyValuePair in this.RoleInstanceMap)
		{
			list.Add(keyValuePair.Value);
		}
		return list.ToArray();
	}

	// Token: 0x0601308F RID: 77967 RVA: 0x00590F88 File Offset: 0x0058F188
	public List<int> GetRoleIdList([Nullable(2)] Comparison<int> customCompare = null)
	{
		List<int> list = new List<int>(this.RoleInstanceMap.Keys);
		this.SortRoleList(list, customCompare);
		List<int> list2 = new List<int>();
		foreach (int num in list)
		{
			if (this.RoleInstanceMap[num].GetRoleConfig().RoleType == 1)
			{
				list2.Add(num);
			}
		}
		return list2;
	}

	// Token: 0x06013090 RID: 77968 RVA: 0x00591014 File Offset: 0x0058F214
	public RoleInstance[] GetOfficialRoleList()
	{
		List<RoleInstance> list = new List<RoleInstance>();
		foreach (KeyValuePair<int, RoleInstance> keyValuePair in this.RoleInstanceMap)
		{
			RoleInstance value = keyValuePair.Value;
			if (value.GetRoleConfig().RoleType == 1 && !value.IsTrialRole())
			{
				list.Add(value);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06013091 RID: 77969 RVA: 0x00591098 File Offset: 0x0058F298
	public UiDynamicTab[] GetRoleTabList()
	{
		List<UiDynamicTab> viewTabList = DynamicTabConfig.Instance.GetViewTabList(EUiViewName.RoleRootView);
		int count = viewTabList.Count;
		List<UiDynamicTab> list = new List<UiDynamicTab>();
		for (int i = 0; i < count; i++)
		{
			UiDynamicTab item = viewTabList[i];
			if (FunctionModel.Instance.IsOpen(item.FunctionId))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06013092 RID: 77970 RVA: 0x00591100 File Offset: 0x0058F300
	public UiDynamicTab[] GetNormalRoleTabList()
	{
		UiDynamicTab[] roleTabList = this.GetRoleTabList();
		List<UiDynamicTab> list = new List<UiDynamicTab>();
		foreach (UiDynamicTab item in roleTabList)
		{
			if (item.ChildViewName == EUiTabViewName.RoleAttributeTabView || item.ChildViewName == EUiTabViewName.RoleWeaponTabView || item.ChildViewName == EUiTabViewName.RolePhantomTabView || item.ChildViewName == EUiTabViewName.RoleSkillTabView || item.ChildViewName == EUiTabViewName.RoleResonanceTabNewView || item.ChildViewName == EUiTabViewName.RoleFavorTabView)
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06013093 RID: 77971 RVA: 0x005911D4 File Offset: 0x0058F3D4
	public bool IsTrialRoleShowFullTab(int trialRoleId)
	{
		bool flag;
		return !this.RoleTrialShowMap.TryGetValue(trialRoleId, out flag) || flag;
	}

	// Token: 0x06013094 RID: 77972 RVA: 0x005911F4 File Offset: 0x0058F3F4
	public UiDynamicTab[] GetTrialRoleTabList(int trialRoleId)
	{
		UiDynamicTab[] roleTabList = this.GetRoleTabList();
		bool flag = this.IsTrialRoleShowFullTab(trialRoleId);
		List<UiDynamicTab> list = new List<UiDynamicTab>();
		foreach (UiDynamicTab item in roleTabList)
		{
			if (item.ChildViewName == EUiTabViewName.RoleAttributeTabView || item.ChildViewName == EUiTabViewName.RolePhantomTabView || (flag && (item.ChildViewName == EUiTabViewName.RoleWeaponTabView || item.ChildViewName == EUiTabViewName.RoleSkillTabView || item.ChildViewName == EUiTabViewName.RoleResonanceTabNewView)))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06013095 RID: 77973 RVA: 0x005912BC File Offset: 0x0058F4BC
	public UiDynamicTab[] GetSpecialTrialRoleTabList(int trialRoleId)
	{
		UiDynamicTab[] roleTabList = this.GetRoleTabList();
		if (roleTabList == null)
		{
			return new UiDynamicTab[0];
		}
		bool flag = this.IsTrialRoleShowFullTab(trialRoleId);
		List<UiDynamicTab> list = new List<UiDynamicTab>();
		foreach (UiDynamicTab item in roleTabList)
		{
			if (item.ChildViewName == EUiTabViewName.RoleAttributeTabView || item.ChildViewName == EUiTabViewName.RolePhantomTabView || (flag && (item.ChildViewName == EUiTabViewName.RoleWeaponTabView || item.ChildViewName == EUiTabViewName.RoleSkillTabView || item.ChildViewName == EUiTabViewName.RoleResonanceTabNewView)))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06013096 RID: 77974 RVA: 0x00591398 File Offset: 0x0058F598
	public UiDynamicTab[] GetPreviewRoleTabList()
	{
		UiDynamicTab[] roleTabList = this.GetRoleTabList();
		List<UiDynamicTab> list = new List<UiDynamicTab>();
		foreach (UiDynamicTab item in roleTabList)
		{
			if (item.ChildViewName == EUiTabViewName.RolePreviewAttributeTabView || item.ChildViewName == EUiTabViewName.RoleSkillTabView || item.ChildViewName == EUiTabViewName.RoleResonanceTabNewView)
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06013097 RID: 77975 RVA: 0x00591420 File Offset: 0x0058F620
	public UiDynamicTab[] GetRoleTabListByUiParam(ERoleSystemMode roleMode, int trialRoleId = 0)
	{
		switch (roleMode)
		{
		case ERoleSystemMode.Trial:
			return this.GetTrialRoleTabList(trialRoleId);
		case ERoleSystemMode.Normal:
		case ERoleSystemMode.RoleNewJoin:
			return this.GetNormalRoleTabList();
		case ERoleSystemMode.Preview:
			return this.GetPreviewRoleTabList();
		case ERoleSystemMode.SpecialTrial:
			return this.GetSpecialTrialRoleTabList(trialRoleId);
		default:
			return this.GetNormalRoleTabList();
		}
	}

	// Token: 0x06013098 RID: 77976 RVA: 0x00591470 File Offset: 0x0058F670
	public bool RedDotRoleSelectionListCondition()
	{
		HashSet<int> newFlagSet = NewFlagModel.Instance.GetNewFlagSet(ELocalStoragePlayerKey.RoleDataItem);
		if (newFlagSet == null)
		{
			return false;
		}
		foreach (RoleInstance roleInstance in this.GetAllRoleList())
		{
			if (newFlagSet.Contains(roleInstance.GetDataId()))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06013099 RID: 77977 RVA: 0x005914BC File Offset: 0x0058F6BC
	public bool RedDotRoleSystemRoleListCondition(int roleId)
	{
		bool flag = false;
		FormationData currentFormationData = FormationModel.Instance.CurrentFormationData;
		List<int> list = (currentFormationData != null) ? currentFormationData.RoleIdList : null;
		if (list != null)
		{
			using (List<int>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == roleId)
					{
						flag = true;
						break;
					}
				}
			}
		}
		if (!flag)
		{
			return this.RedDotResonanceTabCondition(roleId);
		}
		return this.RedDotResonanceTabCondition(roleId) || VisionRecommendModel.Instance.CheckVisionOneKeyEquipRedDot(roleId);
	}

	// Token: 0x0601309A RID: 77978 RVA: 0x0059154C File Offset: 0x0058F74C
	public bool RedDotAttributeTabLevelUpCondition(int roleId)
	{
		RoleDataBase roleDataById = this.GetRoleDataById(roleId, true);
		return roleDataById != null && !roleDataById.IsTrialRole() && !roleDataById.GetLevelData().GetRoleIsMaxLevel() && (this.GetSelectHasEnoughItemToLevelUp(roleId) && this.GetHasEnoughMoneyLevelUp(roleId));
	}

	// Token: 0x0601309B RID: 77979 RVA: 0x00591594 File Offset: 0x0058F794
	public bool RedDotAttributeTabBreakUpCondition(int roleId)
	{
		RoleDataBase roleDataById = this.GetRoleDataById(roleId, true);
		return roleDataById != null && !roleDataById.IsTrialRole() && roleDataById.GetLevelData().GetRoleNeedBreakUp() && this.RedDotAttributeTabBreachCondition(roleDataById);
	}

	// Token: 0x0601309C RID: 77980 RVA: 0x005915D0 File Offset: 0x0058F7D0
	public bool RedDotFavorItemActiveCondition(int roleId)
	{
		RoleDataBase roleDataById = this.GetRoleDataById(roleId, true);
		return !roleDataById.IsTrialRole() && roleDataById.GetFavorData().IsExistCanUnlockFavorItem();
	}

	// Token: 0x0601309D RID: 77981 RVA: 0x005915FB File Offset: 0x0058F7FB
	private bool RedDotAttributeTabBreachCondition(RoleDataBase roleInstance)
	{
		return roleInstance.GetLevelData().IsEnoughBreachConsume();
	}

	// Token: 0x0601309E RID: 77982 RVA: 0x00591608 File Offset: 0x0058F808
	public bool RedDotResonanceTabCondition(int roleId)
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(roleId);
		if (roleInstanceById == null)
		{
			return false;
		}
		int roleResonanceGroupIndex = this.GetRoleResonanceGroupIndex(roleInstanceById);
		IReadOnlyList<ResonantChain> configList = ConfigResonantChainByGroupId.GetConfigList(roleInstanceById.GetRoleConfig().ResonanceId, true);
		if (roleResonanceGroupIndex < 0 || roleResonanceGroupIndex >= configList.Count)
		{
			return false;
		}
		foreach (DicIntInt dicIntInt in configList[roleResonanceGroupIndex].ActivateConsumeIter())
		{
			if (InventoryModel.Instance.GetCommonItemCount(dicIntInt.Key, 0) < dicIntInt.Value)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0601309F RID: 77983 RVA: 0x005916C0 File Offset: 0x0058F8C0
	public bool RedDotCondition()
	{
		return this.RedDotResonanceCondition() || this.RedDotRoleSkinCondition() || this.RedDotRoleOrnamentCondition();
	}

	// Token: 0x060130A0 RID: 77984 RVA: 0x005916DC File Offset: 0x0058F8DC
	public bool RedDotResonanceCondition()
	{
		foreach (RoleInstance roleInstance in this.GetAllRoleList())
		{
			if (this.RedDotResonanceTabCondition(roleInstance.GetDataId()))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060130A1 RID: 77985 RVA: 0x00591714 File Offset: 0x0058F914
	public bool RedDotRoleSkinCondition()
	{
		foreach (RoleInstance roleInstance in this.GetAllRoleList())
		{
			if (RoleSkinModel.Instance.HasRoleSkinRedDotByRoleId(roleInstance.GetDataId()))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060130A2 RID: 77986 RVA: 0x00591750 File Offset: 0x0058F950
	public bool RedDotResonanceTabHoleCondition(int roleId, int groupIndex)
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(roleId);
		if (roleInstanceById == null)
		{
			return false;
		}
		int roleResonanceGroupIndex = this.GetRoleResonanceGroupIndex(roleInstanceById);
		if (groupIndex - roleResonanceGroupIndex != 1)
		{
			return false;
		}
		ResonantChain resonantChain = this.GetRoleResonanceConfigList(roleInstanceById)[groupIndex - 1];
		bool result = true;
		foreach (DicIntInt dicIntInt in resonantChain.ActivateConsumeIter())
		{
			int key = dicIntInt.Key;
			int value = dicIntInt.Value;
			if (InventoryModel.Instance.GetCommonItemCount(key, 0) < value)
			{
				result = false;
				break;
			}
		}
		return result;
	}

	// Token: 0x060130A3 RID: 77987 RVA: 0x005917F8 File Offset: 0x0058F9F8
	public ERoleResonanceNodeState GetRoleResonanceState(RoleDataBase roleInstance, int GroupIndex)
	{
		int resonantChainGroupIndex = roleInstance.GetResonanceData().GetResonantChainGroupIndex();
		if (GroupIndex <= resonantChainGroupIndex)
		{
			return ERoleResonanceNodeState.Activated;
		}
		if (GroupIndex - 1 == resonantChainGroupIndex)
		{
			return ERoleResonanceNodeState.ToBeActivated;
		}
		return ERoleResonanceNodeState.NeedFrontActivated;
	}

	// Token: 0x060130A4 RID: 77988 RVA: 0x00591820 File Offset: 0x0058FA20
	public int GetRoleResonanceGroupIndex(RoleDataBase roleInstance)
	{
		return roleInstance.GetResonanceData().GetResonantChainGroupIndex();
	}

	// Token: 0x060130A5 RID: 77989 RVA: 0x00591830 File Offset: 0x0058FA30
	[return: Nullable(2)]
	public List<ResonantChain> GetRoleResonanceConfigList(RoleDataBase roleInstance)
	{
		int dataId = roleInstance.GetDataId();
		int resonantChainGroupId = RoleConfig.Instance.GetRoleConfig(dataId).Value.ResonantChainGroupId;
		return RoleResonanceConfig.Instance.GetRoleResonanceList(resonantChainGroupId);
	}

	// Token: 0x17001D1C RID: 7452
	// (get) Token: 0x060130A6 RID: 77990 RVA: 0x0059186B File Offset: 0x0058FA6B
	public RoleSkillResponseData RoleSkillResponseData
	{
		get
		{
			if (this.RoleSkillResponseDataInternal == null)
			{
				this.RoleSkillResponseDataInternal = new RoleSkillResponseData();
			}
			return this.RoleSkillResponseDataInternal;
		}
	}

	// Token: 0x060130A7 RID: 77991 RVA: 0x00591888 File Offset: 0x0058FA88
	public global::SkillEffect GetCurRoleSkillViewDataLocal(int roleId, int skillGroupId)
	{
		int skillLevel = this.GetRoleDataById(roleId, true).GetSkillData().GetSkillLevel(skillGroupId);
		return this.GetRoleSkillEffect(skillGroupId, skillLevel);
	}

	// Token: 0x060130A8 RID: 77992 RVA: 0x005918B4 File Offset: 0x0058FAB4
	public global::SkillEffect GetNextRoleSkillViewDataLocal(int roleId, int skillGroupId)
	{
		int skillLevel = this.GetRoleDataById(roleId, true).GetSkillData().GetSkillLevel(skillGroupId);
		int maxSkillLevel = RoleSkillConfig.Instance.GetSkillConfigById(skillGroupId).Value.MaxSkillLevel;
		int skillLevel2 = (skillLevel < maxSkillLevel) ? (skillLevel + 1) : maxSkillLevel;
		return this.GetRoleSkillEffect(skillGroupId, skillLevel2);
	}

	// Token: 0x060130A9 RID: 77993 RVA: 0x00591908 File Offset: 0x0058FB08
	public global::SkillEffect GetRoleSkillEffect(int skillGroupId, int skillLevel)
	{
		global::SkillEffect skillEffect = new global::SkillEffect();
		List<SkillDescription> list = ConfigCommon.ToList<SkillDescription>(RoleSkillConfig.Instance.GetAllRoleSkillDescConfigByGroupId(skillGroupId));
		for (int i = 0; i < list.Count; i++)
		{
			for (int j = i + 1; j < list.Count; j++)
			{
				if (list[i].Order > list[j].Order)
				{
					SkillDescription value = list[i];
					list[i] = list[j];
					list[j] = value;
				}
			}
		}
		List<global::OneSkillEffect> list2 = new List<global::OneSkillEffect>();
		foreach (SkillDescription skillDescription in list)
		{
			global::OneSkillEffect oneSkillEffect = new global::OneSkillEffect();
			oneSkillEffect.Id = skillDescription.Id;
			oneSkillEffect.Desc = new List<string>();
			foreach (StringArray stringArray in skillDescription.SkillDetailNumIter())
			{
				if (stringArray.ArrayString().Length != 0 && skillLevel <= stringArray.ArrayString().Length)
				{
					oneSkillEffect.Desc.Add((skillLevel - 1 >= 0) ? stringArray.ArrayString()[skillLevel - 1] : null);
				}
			}
			list2.Add(oneSkillEffect);
		}
		skillEffect.Level = skillLevel;
		skillEffect.EffectDescList = list2;
		return skillEffect;
	}

	// Token: 0x060130AA RID: 77994 RVA: 0x00591A8C File Offset: 0x0058FC8C
	[NullableContext(2)]
	public void UpdateRoleSkillViewData(global::SkillEffect skillEffectList, global::SkillEffect nextSkillEffectList, int skillId)
	{
		this.RoleSkillResponseData.UpdateRoleSkillViewResponse(skillEffectList, nextSkillEffectList, skillId);
	}

	// Token: 0x060130AB RID: 77995 RVA: 0x00591A9C File Offset: 0x0058FC9C
	public void UpdateRoleSkillNodeData(int roleId, ArraySkillNode[] skillNodeState)
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(roleId);
		if (roleInstanceById == null)
		{
			return;
		}
		RoleSkillData skillData = roleInstanceById.GetSkillData();
		if (skillData == null)
		{
			return;
		}
		int num = skillNodeState.Length;
		Dictionary<int, SkillNodeDataInfo> dictionary = new Dictionary<int, SkillNodeDataInfo>();
		for (int i = 0; i < num; i++)
		{
			ArraySkillNode arraySkillNode = skillNodeState[i];
			int skillNodeId = arraySkillNode.SkillNodeId;
			SkillNodeDataInfo value = new SkillNodeDataInfo(skillNodeId, arraySkillNode.IsActive, arraySkillNode.SkillId);
			dictionary.Add(skillNodeId, value);
		}
		skillData.SetSkillNodeStateData(dictionary);
	}

	// Token: 0x060130AC RID: 77996 RVA: 0x00591B15 File Offset: 0x0058FD15
	public int GetUpgradeSkillIdIfUpgraded(int skillId, int roleDataId)
	{
		return this.GetRoleDataById(roleDataId, true).GetSkillData().GetSkillIdAfterUpgrade(skillId);
	}

	// Token: 0x060130AD RID: 77997 RVA: 0x00591B2C File Offset: 0x0058FD2C
	public void UpdateRoleFavorData(RoleFavor[] favorList)
	{
		int num = favorList.Length;
		for (int i = 0; i < num; i++)
		{
			this.UpdateRoleFavorDataSingle(favorList[i]);
		}
	}

	// Token: 0x060130AE RID: 77998 RVA: 0x00591B54 File Offset: 0x0058FD54
	public void UpdateRoleFavorCondition(Dictionary<int, ConditionInfo> conditionMap)
	{
		foreach (KeyValuePair<int, ConditionInfo> keyValuePair in conditionMap)
		{
			int key = keyValuePair.Key;
			ConditionInfo value = keyValuePair.Value;
			RoleFavorConditionModel.Instance.UpdateRoleFavorCondition(key, value);
		}
	}

	// Token: 0x060130AF RID: 77999 RVA: 0x00591BB8 File Offset: 0x0058FDB8
	public void UpdateRoleFavorDataSingle(RoleFavor roleFavor)
	{
		int roleId = roleFavor.RoleId;
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(roleId);
		if (roleInstanceById == null)
		{
			return;
		}
		RoleFavorData favorData = roleInstanceById.GetFavorData();
		if (favorData == null)
		{
			return;
		}
		int level = roleFavor.Level;
		int exp = roleFavor.Exp;
		RepeatedField<FavorItem> wordIds = roleFavor.WordIds;
		RepeatedField<FavorItem> storyIds = roleFavor.StoryIds;
		RepeatedField<FavorItem> goodsIds = roleFavor.GoodsIds;
		favorData.SetFavorLevel(level);
		favorData.SetFavorExp(exp);
		favorData.UpdateRoleFavorData(EFavorContentType.Voice, wordIds.ToArray<FavorItem>());
		favorData.UpdateRoleFavorData(EFavorContentType.ExperienceStory, storyIds.ToArray<FavorItem>());
		favorData.UpdateRoleFavorData(EFavorContentType.PreciousItem, goodsIds.ToArray<FavorItem>());
		EventSystem.Instance.Emit<int>(EEventName.UpdateRoleFavorData, roleId);
	}

	// Token: 0x060130B0 RID: 78000 RVA: 0x00591C58 File Offset: 0x0058FE58
	public void UpdateRoleFavorNewCanUnLockId(RoleFavorNewCanUnLockNotify info)
	{
		int roleId = info.RoleId;
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(roleId);
		if (roleInstanceById == null)
		{
			return;
		}
		roleInstanceById.GetFavorData().UpdateCanUnlockId(info.ItemType, info.CanUnLockId);
	}

	// Token: 0x060130B1 RID: 78001 RVA: 0x00591C94 File Offset: 0x0058FE94
	public void UpdateRoleFavorLevelAndExp(RoleFavorLevelUpdateNotify info)
	{
		int roleId = info.RoleId;
		RoleFavorData favorData = RoleModel.Instance.GetRoleInstanceById(roleId).GetFavorData();
		favorData.SetFavorLevel(info.Level);
		favorData.SetFavorExp(info.Exp);
	}

	// Token: 0x060130B2 RID: 78002 RVA: 0x00591CD0 File Offset: 0x0058FED0
	public void UpdateRoleSkinInfo(int roleId, int skinId)
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(roleId);
		if (roleInstanceById == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.BB;
			string message = "UpdateRoleSkinInfo 无效roleId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		roleInstanceById.SetRoleSkinId(skinId);
	}

	// Token: 0x060130B3 RID: 78003 RVA: 0x00591D20 File Offset: 0x0058FF20
	public void UpdateRoleBackgroundMusicEnabled(int roleDataId, bool enabled)
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(roleDataId);
		if (roleInstanceById == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "UpdateRoleBackgroundMusicEnabled 无效roleId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleDataId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		roleInstanceById.SetBackgroundMusicEnabled(enabled);
	}

	// Token: 0x060130B4 RID: 78004 RVA: 0x00591D70 File Offset: 0x0058FF70
	public bool GetRoleBackgroundMusicEnabled(int roleDataId)
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(roleDataId);
		return roleInstanceById == null || roleInstanceById.GetBackgroundMusicEnabled();
	}

	// Token: 0x060130B5 RID: 78005 RVA: 0x00591D94 File Offset: 0x0058FF94
	public List<int> GetRoleSystemRoleList(bool includeRobots = false, [Nullable(2)] Comparison<int> customCompare = null)
	{
		if (DangoAbyssModel.Instance.CheckIfInSmallWorldInstance())
		{
			return this.GetRoleIdList(customCompare);
		}
		if (GameModeModel.Instance.IsMulti)
		{
			return this.GetRoleIdList(customCompare);
		}
		List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(false);
		List<int> list = new List<int>();
		foreach (SceneTeamItem sceneTeamItem in teamItems)
		{
			int getConfigId = sceneTeamItem.GetConfigId;
			RoleDataBase roleDataById = this.GetRoleDataById(getConfigId, true);
			if (roleDataById != null && roleDataById.IsTrialRole())
			{
				list.Add(getConfigId);
			}
		}
		int teamLength = SceneTeamModel.Instance.GetTeamLength();
		if (GameModeController.Instance.IsInInstance() && list.Count > 0 && list.Count == teamLength)
		{
			return list;
		}
		if (list.Count > 0)
		{
			List<int> list2 = new List<int>(this.RoleInstanceMap.Keys);
			foreach (int item in list)
			{
				list2.Add(item);
			}
			if (includeRobots)
			{
				this.MergeSpecialRoleIdList(list2);
			}
			this.SortRoleList(list2, customCompare);
			return list2;
		}
		List<int> roleIdList = this.GetRoleIdList(customCompare);
		if (includeRobots)
		{
			List<int> list3 = new List<int>(roleIdList);
			this.MergeSpecialRoleIdList(list3);
			this.SortRoleList(list3, customCompare);
			return list3;
		}
		return roleIdList;
	}

	// Token: 0x060130B6 RID: 78006 RVA: 0x00591F00 File Offset: 0x00590100
	private void MergeSpecialRoleIdList(List<int> roleList)
	{
		foreach (RoleSpecialRobotData roleSpecialRobotData in this.RoleSpecialRobotDataMap.Values)
		{
			if (roleSpecialRobotData.IsVisibleInRoleSystem())
			{
				int dataId = roleSpecialRobotData.GetDataId();
				if (!roleList.Contains(dataId))
				{
					roleList.Add(dataId);
				}
			}
		}
	}

	// Token: 0x060130B7 RID: 78007 RVA: 0x00591F70 File Offset: 0x00590170
	public int GetRoleListHighestLevel()
	{
		int num = -1;
		foreach (KeyValuePair<int, RoleInstance> keyValuePair in this.RoleInstanceMap)
		{
			int level = keyValuePair.Value.GetLevelData().GetLevel();
			num = ((level > num) ? level : num);
		}
		foreach (KeyValuePair<int, RoleRobotData> keyValuePair2 in this.RoleRobotDataMap)
		{
			RoleRobotData value = keyValuePair2.Value;
			if (SceneTeamModel.Instance.GetTeamItem((long)value.GetDataId(), new GetTeamItemOptions
			{
				ParamType = ETeamParamType.ConfigId
			}) != null)
			{
				int level2 = value.GetLevelData().GetLevel();
				num = ((level2 > num) ? level2 : num);
			}
		}
		return num;
	}

	// Token: 0x060130B8 RID: 78008 RVA: 0x0059205C File Offset: 0x0059025C
	public void UpdateCanChangeRoleIdList(int[] roleIds)
	{
		List<int> list = new List<int>(this.CanChangeRoleIdList);
		foreach (int item in roleIds)
		{
			list.Add(item);
		}
		this.CanChangeRoleIdList = list.ToArray();
	}

	// Token: 0x060130B9 RID: 78009 RVA: 0x0059209C File Offset: 0x0059029C
	public int[] GetCanChangeRoleIdList()
	{
		return this.CanChangeRoleIdList;
	}

	// Token: 0x060130BA RID: 78010 RVA: 0x005920A4 File Offset: 0x005902A4
	public bool IsMainRole(int roleId)
	{
		return this.GetMainRoleSet().Contains(roleId);
	}

	// Token: 0x060130BB RID: 78011 RVA: 0x005920B2 File Offset: 0x005902B2
	public bool IsLightMainRole(int roleId)
	{
		return this.GetLightMainRoleSet().Contains(roleId);
	}

	// Token: 0x060130BC RID: 78012 RVA: 0x005920C0 File Offset: 0x005902C0
	private HashSet<int> GetMainRoleSet()
	{
		if (this.MainRoleIdSet.Count == 0)
		{
			this.InitMainRoleIdSet();
		}
		return this.MainRoleIdSet;
	}

	// Token: 0x060130BD RID: 78013 RVA: 0x005920DB File Offset: 0x005902DB
	private HashSet<int> GetLightMainRoleSet()
	{
		if (this.LightMainRoleIdSet.Count == 0)
		{
			this.InitLightMainRoleIdSet();
		}
		return this.LightMainRoleIdSet;
	}

	// Token: 0x060130BE RID: 78014 RVA: 0x005920F8 File Offset: 0x005902F8
	private void InitMainRoleIdSet()
	{
		IReadOnlyList<MainRoleConfig> allMainRoleConfig = RoleConfig.Instance.GetAllMainRoleConfig();
		int count = allMainRoleConfig.Count;
		for (int i = 0; i < count; i++)
		{
			MainRoleConfig mainRoleConfig = allMainRoleConfig[i];
			this.MainRoleIdSet.Add(mainRoleConfig.Id);
		}
	}

	// Token: 0x060130BF RID: 78015 RVA: 0x00592140 File Offset: 0x00590340
	private void InitLightMainRoleIdSet()
	{
		foreach (int item in ConfigCommonParamById.GetIntArrayConfig("LightMainRoleIdList"))
		{
			this.LightMainRoleIdSet.Add(item);
		}
	}

	// Token: 0x060130C0 RID: 78016 RVA: 0x00592198 File Offset: 0x00590398
	public int? GetCurSelectMainRoleId()
	{
		foreach (int num in this.GetMainRoleSet())
		{
			if (this.RoleInstanceMap.ContainsKey(num))
			{
				return new int?(num);
			}
		}
		return null;
	}

	// Token: 0x060130C1 RID: 78017 RVA: 0x00592208 File Offset: 0x00590408
	[NullableContext(2)]
	public RoleInstance GetCurSelectMainRoleInstance()
	{
		foreach (int key in this.GetMainRoleSet())
		{
			if (this.RoleInstanceMap.ContainsKey(key))
			{
				return this.RoleInstanceMap[key];
			}
		}
		return null;
	}

	// Token: 0x060130C2 RID: 78018 RVA: 0x00592274 File Offset: 0x00590474
	public bool IsHasRole(int roleId)
	{
		if (!this.IsMainRole(roleId))
		{
			return this.GetRoleDataById(roleId, true) != null;
		}
		int? curSelectMainRoleId = this.GetCurSelectMainRoleId();
		if (curSelectMainRoleId == null)
		{
			return false;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		RoleInfo? roleConfig2 = RoleConfig.Instance.GetRoleConfig(curSelectMainRoleId.Value);
		return roleConfig != null && roleConfig2 != null && roleConfig.Value.ElementId == roleConfig2.Value.ElementId;
	}

	// Token: 0x060130C3 RID: 78019 RVA: 0x005922FC File Offset: 0x005904FC
	public MainRoleConfig? GetCorrectMainRoleConfig(int roleId)
	{
		if (!this.IsMainRole(roleId))
		{
			MainRoleConfig? result = null;
			return result;
		}
		MainRoleConfig? mainRoleById = RoleConfig.Instance.GetMainRoleById(roleId);
		if (mainRoleById == null)
		{
			MainRoleConfig? result = null;
			return result;
		}
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		if (roleConfig == null)
		{
			MainRoleConfig? result = null;
			return result;
		}
		if (mainRoleById.Value.Gender != (int)playerGender)
		{
			IReadOnlyList<MainRoleConfig> mainRoleByGender = RoleConfig.Instance.GetMainRoleByGender((LoginDefine.ELoginSex)playerGender);
			if (mainRoleByGender != null)
			{
				foreach (MainRoleConfig value in mainRoleByGender)
				{
					RoleInfo? roleConfig2 = RoleConfig.Instance.GetRoleConfig(value.Id);
					if (roleConfig2 != null && roleConfig2.Value.ElementId == roleConfig.Value.ElementId)
					{
						return new MainRoleConfig?(value);
					}
				}
			}
		}
		return new MainRoleConfig?(mainRoleById.Value);
	}

	// Token: 0x060130C4 RID: 78020 RVA: 0x00592420 File Offset: 0x00590620
	public int GetRoleLevelUpExp(int roleId, int level)
	{
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		RoleLevelConsume? roleLevelConsume = RoleConfig.Instance.GetRoleLevelConsume(roleConfig.Value.LevelConsumeId, level);
		if (roleLevelConsume != null)
		{
			return roleLevelConsume.Value.ExpCount;
		}
		return 1;
	}

	// Token: 0x060130C5 RID: 78021 RVA: 0x00592470 File Offset: 0x00590670
	public Dictionary<int, int> CalculateExpBackItem(int overExp)
	{
		IReadOnlyList<RoleExpItem> roleExpItemList = RoleConfig.Instance.GetRoleExpItemList();
		int count = roleExpItemList.Count;
		int num = overExp;
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = count - 1; i >= 0; i--)
		{
			int basicExp = roleExpItemList[i].BasicExp;
			int num2 = (int)Math.Floor((double)num / (double)basicExp);
			num %= basicExp;
			if (num2 > 0)
			{
				dictionary[roleExpItemList[i].Id] = num2;
			}
		}
		return dictionary;
	}

	// Token: 0x060130C6 RID: 78022 RVA: 0x005924E8 File Offset: 0x005906E8
	public int GetBaseAttributeById(int roleId, EAttributeType attributeId)
	{
		BaseProperty? config = ConfigBasePropertyById.GetConfig(RoleConfig.Instance.GetRoleConfig(roleId).Value.PropertyId, true);
		if (attributeId == EAttributeType.LifeMax)
		{
			return config.Value.LifeMax;
		}
		if (attributeId == EAttributeType.Atk)
		{
			return config.Value.Atk;
		}
		if (attributeId != EAttributeType.Def)
		{
			return 0;
		}
		return config.Value.Def;
	}

	// Token: 0x060130C7 RID: 78023 RVA: 0x00592558 File Offset: 0x00590758
	public float GetAttributeRadioByLevel(EAttributeType attributeId, int level, int breachLevel)
	{
		RolePropertyGrowth? config = ConfigRolePropertyGrowthByLevelAndBreachLevel.GetConfig(level, breachLevel, true);
		if (attributeId == EAttributeType.LifeMax)
		{
			return (float)config.Value.LifeMaxRatio;
		}
		if (attributeId == EAttributeType.Atk)
		{
			return (float)config.Value.AtkRatio;
		}
		if (attributeId != EAttributeType.Def)
		{
			return 0f;
		}
		return (float)config.Value.DefRatio;
	}

	// Token: 0x060130C8 RID: 78024 RVA: 0x005925B8 File Offset: 0x005907B8
	public int GetAttributeByLevel(int roleId, EAttributeType attributeId, int level, int breachLevel)
	{
		float baseAttributeById = (float)this.GetBaseAttributeById(roleId, attributeId);
		float attributeRadioByLevel = this.GetAttributeRadioByLevel(attributeId, level, breachLevel);
		return (int)Math.Floor((double)(baseAttributeById * attributeRadioByLevel * 0.0001f));
	}

	// Token: 0x060130C9 RID: 78025 RVA: 0x005925E8 File Offset: 0x005907E8
	public int GetAddAttrLevelUp(int roleId, int srcLevel, int srcBreachLevel, int tarLevel, int tarBreachLevel, int attributeId)
	{
		int attributeByLevel = this.GetAttributeByLevel(roleId, (EAttributeType)attributeId, srcLevel, srcBreachLevel);
		return this.GetAttributeByLevel(roleId, (EAttributeType)attributeId, tarLevel, tarBreachLevel) - attributeByLevel;
	}

	// Token: 0x060130CA RID: 78026 RVA: 0x00592610 File Offset: 0x00590810
	public int GetRoleSkillTreeNodeLevel(int roleId, int skillNodeId)
	{
		SkillTree? skillTreeNode = RoleSkillConfig.Instance.GetSkillTreeNode(skillNodeId);
		if (skillTreeNode == null)
		{
			return 0;
		}
		RoleDataBase roleDataBase = this.GetRoleInstanceById(roleId);
		if (roleDataBase == null)
		{
			roleDataBase = this.GetRoleDataById(roleId, true);
		}
		return this.GetRoleSkillTreeNodeLevelByConfig(roleDataBase, skillTreeNode.Value);
	}

	// Token: 0x060130CB RID: 78027 RVA: 0x00592656 File Offset: 0x00590856
	public int GetRoleSkillTreeNodeLevelByConfig(RoleDataBase roleInstance, SkillTree config)
	{
		return roleInstance.GetSkillData().GetSkillNodeLevel(config);
	}

	// Token: 0x060130CC RID: 78028 RVA: 0x00592664 File Offset: 0x00590864
	public ESkillTreeNodeState? GetRoleSkillTreeNodeState(int roleId, int skillNodeId)
	{
		if (skillNodeId <= 0)
		{
			return null;
		}
		SkillTree? skillTreeNode = RoleSkillConfig.Instance.GetSkillTreeNode(skillNodeId);
		if (skillTreeNode == null)
		{
			return null;
		}
		RoleDataBase roleDataBase = this.GetRoleInstanceById(roleId);
		if (roleDataBase == null)
		{
			roleDataBase = this.GetRoleDataById(roleId, true);
		}
		return new ESkillTreeNodeState?(roleDataBase.GetSkillData().GetSkillTreeNodeState(skillTreeNode.Value, roleId));
	}

	// Token: 0x060130CD RID: 78029 RVA: 0x005926CC File Offset: 0x005908CC
	public bool GetRoleSkillTreeNodeConsumeSatisfied(int roleId, int skillNodeId)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		return roleInstanceById != null && roleInstanceById.GetSkillData().IsSkillTreeNodeConsumeSatisfied(skillNodeId);
	}

	// Token: 0x060130CE RID: 78030 RVA: 0x005926F4 File Offset: 0x005908F4
	public string GetSkillAttributeNameByOneSkillEffect(global::OneSkillEffect effect)
	{
		return RoleSkillConfig.Instance.GetRoleSkillDescriptionConfigById(effect.Id).Value.AttributeName;
	}

	// Token: 0x060130CF RID: 78031 RVA: 0x00592724 File Offset: 0x00590924
	public string GetSkillAttributeDescriptionByOneSkillEffect(global::OneSkillEffect effect)
	{
		SkillDescription? roleSkillDescriptionConfigById = RoleSkillConfig.Instance.GetRoleSkillDescriptionConfigById(effect.Id);
		string result;
		if (!StringUtils.IsBlank(roleSkillDescriptionConfigById.Value.Description))
		{
			string[] array = new string[effect.Desc.Count];
			for (int i = 0; i < effect.Desc.Count; i++)
			{
				array[i] = effect.Desc[i];
			}
			result = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(roleSkillDescriptionConfigById.Value.Description, null), array);
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			int count = effect.Desc.Count;
			for (int j = 0; j < count; j++)
			{
				stringBuilder.Append(effect.Desc[j]);
			}
			result = stringBuilder.ToString();
		}
		return result;
	}

	// Token: 0x060130D0 RID: 78032 RVA: 0x005927FC File Offset: 0x005909FC
	public Dictionary<int, int[]> GetResonantItemRoleMap()
	{
		if (this.ResonantItemRoleMapInternal != null)
		{
			return this.ResonantItemRoleMapInternal;
		}
		this.ResonantItemRoleMapInternal = new Dictionary<int, int[]>();
		foreach (RoleInfo roleInfo in RoleConfig.Instance.GetRoleList())
		{
			if (roleInfo.ResonantChainGroupId > 0)
			{
				List<ResonantChain> roleResonanceList = RoleResonanceConfig.Instance.GetRoleResonanceList(roleInfo.ResonantChainGroupId);
				if (roleResonanceList != null)
				{
					foreach (ResonantChain resonantChain in roleResonanceList)
					{
						foreach (DicIntInt dicIntInt in resonantChain.ActivateConsumeIter())
						{
							int key = dicIntInt.Key;
							int value = dicIntInt.Value;
							int[] array = null;
							if (this.ResonantItemRoleMapInternal.ContainsKey(key))
							{
								array = this.ResonantItemRoleMapInternal[key];
							}
							if (array == null)
							{
								array = new int[0];
							}
							bool flag = false;
							int[] array2 = array;
							for (int i = 0; i < array2.Length; i++)
							{
								if (array2[i] == roleInfo.Id)
								{
									flag = true;
									break;
								}
							}
							if (!flag)
							{
								int[] array3 = new int[array.Length + 1];
								for (int j = 0; j < array.Length; j++)
								{
									array3[j] = array[j];
								}
								array3[array.Length] = roleInfo.Id;
								array = array3;
							}
							this.ResonantItemRoleMapInternal[key] = array;
						}
					}
				}
			}
		}
		return this.ResonantItemRoleMapInternal;
	}

	// Token: 0x060130D1 RID: 78033 RVA: 0x005929F0 File Offset: 0x00590BF0
	[NullableContext(2)]
	public int[] GetResonantItemRoleId(int itemId)
	{
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(itemId);
		int[] array = (itemConfig != null) ? itemConfig.GetValueOrDefault().ShowTypes() : null;
		if (array == null || Array.IndexOf<int>(array, 30) < 0)
		{
			return null;
		}
		int[] array3;
		int[] array2 = this.GetResonantItemRoleMap().TryGetValue(itemId, out array3) ? array3 : null;
		if (array2 != null && array2.Length != 0)
		{
			return array2;
		}
		return null;
	}

	// Token: 0x060130D2 RID: 78034 RVA: 0x00592A58 File Offset: 0x00590C58
	public bool CheckRoleResonantIfMax(int roleId)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		return roleInstanceById != null && this.GetRoleResonanceGroupIndex(roleInstanceById) >= RoleResonanceConfig.Instance.GetResonanceMaxLevel();
	}

	// Token: 0x060130D3 RID: 78035 RVA: 0x00592A88 File Offset: 0x00590C88
	public int GetRoleLeftResonantCount(int roleId)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		if (roleInstanceById == null)
		{
			return 0;
		}
		int roleResonanceGroupIndex = this.GetRoleResonanceGroupIndex(roleInstanceById);
		return RoleResonanceConfig.Instance.GetResonanceMaxLevel() - roleResonanceGroupIndex;
	}

	// Token: 0x060130D4 RID: 78036 RVA: 0x00592AB8 File Offset: 0x00590CB8
	public int GetRoleLeftResonantCountWithInventoryItem(int roleId)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		if (roleInstanceById == null)
		{
			return 0;
		}
		RoleInfo roleConfig = roleInstanceById.GetRoleConfig();
		int num = 0;
		foreach (KeyValuePair<int, int> keyValuePair in roleConfig.SpilloverItem())
		{
			num += InventoryModel.Instance.GetItemCountByConfigId(keyValuePair.Key, 0);
		}
		int roleResonanceGroupIndex = this.GetRoleResonanceGroupIndex(roleInstanceById);
		return RoleResonanceConfig.Instance.GetResonanceMaxLevel() - roleResonanceGroupIndex - num;
	}

	// Token: 0x060130D5 RID: 78037 RVA: 0x00592B48 File Offset: 0x00590D48
	public List<TItem> GetResonantItemConvertItemResult(int itemId)
	{
		int[] resonantItemRoleId = RoleModel.Instance.GetResonantItemRoleId(itemId);
		if (resonantItemRoleId == null || resonantItemRoleId.Length == 0)
		{
			return new List<TItem>();
		}
		List<TItem> list = new List<TItem>();
		int id = resonantItemRoleId[0];
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(id);
		if (roleConfig != null)
		{
			for (int i = 0; i < roleConfig.Value.SpiloverCompensateLength; i++)
			{
				DicIntInt? dicIntInt = roleConfig.Value.SpiloverCompensate(i);
				if (dicIntInt != null)
				{
					TItem item = new TItem
					{
						ItemData = new InventoryDefine.GetItemData(dicIntInt.Value.Key, 0),
						Count = dicIntInt.Value.Value
					};
					list.Add(item);
				}
			}
		}
		else
		{
			RoleQualityInfo qualityConfig = this.GetRoleInstanceById(id).GetQualityConfig();
			for (int j = 0; j < qualityConfig.SpiloverCompensateLength; j++)
			{
				DicIntInt? dicIntInt2 = qualityConfig.SpiloverCompensate(j);
				if (dicIntInt2 != null)
				{
					TItem item2 = new TItem
					{
						ItemData = new InventoryDefine.GetItemData(dicIntInt2.Value.Key, 0),
						Count = dicIntInt2.Value.Value
					};
					list.Add(item2);
				}
			}
		}
		return list;
	}

	// Token: 0x060130D6 RID: 78038 RVA: 0x00592C9A File Offset: 0x00590E9A
	public bool InUltraSkill()
	{
		return this.InUltraSkillInternal;
	}

	// Token: 0x060130D7 RID: 78039 RVA: 0x00592CA4 File Offset: 0x00590EA4
	private void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
	{
		if (oldEntityHandle != null)
		{
			WorldEntity entity = oldEntityHandle.Entity;
			((entity != null) ? entity.GetComponent<RoleTagComponent>() : null).RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.大招"], new BaseTagComponent.TTagSwitchedCallback(this.OnUltraTagChange));
		}
		if (newEntityHandle != null)
		{
			WorldEntity entity2 = newEntityHandle.Entity;
			RoleTagComponent roleTagComponent = (entity2 != null) ? entity2.GetComponent<RoleTagComponent>() : null;
			roleTagComponent.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.大招"], new BaseTagComponent.TTagSwitchedCallback(this.OnUltraTagChange), null);
			if (this.InUltraSkillInternal != roleTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.大招"]))
			{
				this.InUltraSkillInternal = !this.InUltraSkillInternal;
				EventSystem.Instance.Emit<bool>(EEventName.OnEnterOrExitUltraSkill, this.InUltraSkillInternal);
			}
		}
	}

	// Token: 0x060130D8 RID: 78040 RVA: 0x00592D60 File Offset: 0x00590F60
	private void OnUltraTagChange(int tagId, bool tagExist)
	{
		if (tagId != GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.大招"])
		{
			return;
		}
		this.InUltraSkillInternal = tagExist;
		EventSystem.Instance.Emit<bool>(EEventName.OnEnterOrExitUltraSkill, tagExist);
	}

	// Token: 0x060130D9 RID: 78041 RVA: 0x00592D8D File Offset: 0x00590F8D
	public int[] GetRoleTagByRoleInfo(RoleInfo roleInfo)
	{
		if (this.ClientCheckRoleIsUpgradeLightMainRole(roleInfo.Id))
		{
			return ConfigCommonParamById.GetIntArrayConfig("MainRoleReplaceTagList").ToArray<int>();
		}
		return roleInfo.GetTagArray();
	}

	// Token: 0x060130DA RID: 78042 RVA: 0x00592DB8 File Offset: 0x00590FB8
	public bool ClientCheckRoleIsUpgradeLightMainRole(int roleId)
	{
		if (!this.IsLightMainRole(roleId))
		{
			return false;
		}
		int? intConfig = ConfigCommonParamById.GetIntConfig("MainRoleTagReplaceCondition");
		return LevelGeneralController.Instance.CheckCondition(intConfig.Value.ToString(), null, false, Array.Empty<object>());
	}

	// Token: 0x060130DB RID: 78043 RVA: 0x00592DFB File Offset: 0x00590FFB
	public int[] GetRoleBranchIdList(int roleId)
	{
		return RoleConfig.Instance.GetRoleBranchIds(roleId);
	}

	// Token: 0x060130DC RID: 78044 RVA: 0x00592E08 File Offset: 0x00591008
	public int GetRoleCurrentBranchId(int roleId)
	{
		if (!this.IsRoleHasBranch(roleId))
		{
			return 0;
		}
		int result;
		if (this.RoleSkillBranchMap.TryGetValue(roleId, out result))
		{
			return result;
		}
		return this.GetRoleDefaultBranchId(roleId);
	}

	// Token: 0x060130DD RID: 78045 RVA: 0x00592E39 File Offset: 0x00591039
	public int GetRoleBranchIdByIndex(int roleId, int index)
	{
		return this.GetRoleBranchIdList(roleId)[index];
	}

	// Token: 0x060130DE RID: 78046 RVA: 0x00592E44 File Offset: 0x00591044
	public int GetRoleDefaultBranchId(int roleId)
	{
		return RoleConfig.Instance.GetRoleDefaultBranch(roleId);
	}

	// Token: 0x060130DF RID: 78047 RVA: 0x00592E54 File Offset: 0x00591054
	public int GetRoleCurrentBranchIndex(int roleId)
	{
		int[] roleBranchIdList = this.GetRoleBranchIdList(roleId);
		int skillBranch = this.GetRoleCurrentBranchId(roleId);
		return Array.FindIndex<int>(roleBranchIdList, (int id) => skillBranch == id);
	}

	// Token: 0x060130E0 RID: 78048 RVA: 0x00592E8C File Offset: 0x0059108C
	public int GetRoleOppositeBranchId(int roleId)
	{
		int roleCurrentBranchIndex = this.GetRoleCurrentBranchIndex(roleId);
		return this.GetRoleBranchIdByIndex(roleId, (roleCurrentBranchIndex == 0) ? 1 : 0);
	}

	// Token: 0x060130E1 RID: 78049 RVA: 0x00592EAC File Offset: 0x005910AC
	public int GetRoleDefaultBranchIndex(int roleId)
	{
		int[] roleBranchIdList = this.GetRoleBranchIdList(roleId);
		int skillBranch = this.GetRoleDefaultBranchId(roleId);
		return Array.FindIndex<int>(roleBranchIdList, (int id) => skillBranch == id);
	}

	// Token: 0x060130E2 RID: 78050 RVA: 0x00592EE4 File Offset: 0x005910E4
	public bool IsSkillNodeHasBranch(int nodeId)
	{
		int[] skillNodeBranchIdList = this.GetSkillNodeBranchIdList(nodeId);
		return skillNodeBranchIdList != null && skillNodeBranchIdList.Length == 2;
	}

	// Token: 0x060130E3 RID: 78051 RVA: 0x00592F04 File Offset: 0x00591104
	public bool IsInHideSkillBranchInstSubTypeList(int instSubType)
	{
		IReadOnlyList<int> readOnlyList = ConfigCommonParamById.GetIntArrayConfig("HideSkillBranchInstSubTypeList") ?? Array.Empty<int>();
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			if (readOnlyList[i] == instSubType)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060130E4 RID: 78052 RVA: 0x00592F44 File Offset: 0x00591144
	public int GetSkillNodeCurrentBranchId(int roleId, int nodeId)
	{
		int roleCurrentBranchIndex = this.GetRoleCurrentBranchIndex(roleId);
		return RoleConfig.Instance.GetSkillNodeBranchIds(nodeId)[roleCurrentBranchIndex];
	}

	// Token: 0x060130E5 RID: 78053 RVA: 0x00592F66 File Offset: 0x00591166
	public int[] GetSkillNodeBranchIdList(int nodeId)
	{
		return RoleConfig.Instance.GetSkillNodeBranchIds(nodeId);
	}

	// Token: 0x060130E6 RID: 78054 RVA: 0x00592F73 File Offset: 0x00591173
	public void SetRoleBranch(int roleId, int skillBranch)
	{
		this.RoleSkillBranchMap[roleId] = skillBranch;
	}

	// Token: 0x060130E7 RID: 78055 RVA: 0x00592F84 File Offset: 0x00591184
	public bool IsRoleHasBranch(int roleId)
	{
		if (roleId == 0)
		{
			return false;
		}
		int[] roleBranchIdList = this.GetRoleBranchIdList(roleId);
		return roleBranchIdList != null && roleBranchIdList.Length == 2;
	}

	// Token: 0x060130E8 RID: 78056 RVA: 0x00592FA9 File Offset: 0x005911A9
	public bool CheckCanSwitchRoleBranch(bool showTips = false)
	{
		if (RoleController.Instance.CheckCharacterInBattleTag(true))
		{
			if (showTips)
			{
				ScrollingTipsController.Instance.ShowTipsById("ForbiddenActionInFight", Array.Empty<object>());
			}
			return false;
		}
		return true;
	}

	// Token: 0x060130E9 RID: 78057 RVA: 0x00592FD2 File Offset: 0x005911D2
	public bool IsRoleOwned(int roleId)
	{
		return this.RoleInstanceMap.ContainsKey(roleId);
	}

	// Token: 0x060130EA RID: 78058 RVA: 0x00592FE0 File Offset: 0x005911E0
	public int GetRoleBranchIndexById(int roleId, int skillBranchId)
	{
		return Array.FindIndex<int>(this.GetRoleBranchIdList(roleId), (int id) => skillBranchId == id);
	}

	// Token: 0x060130EB RID: 78059 RVA: 0x00593012 File Offset: 0x00591212
	public void StartGamePlayRoleEdit(ESkillBranchCacheType gamePlayType)
	{
		this.RoleSkillBranchCacheTypeInternal = gamePlayType;
	}

	// Token: 0x060130EC RID: 78060 RVA: 0x0059301C File Offset: 0x0059121C
	public void ClearGamePlayRoleEdit(ESkillBranchCacheType gamePlayType)
	{
		Dictionary<int, int> dictionary2;
		Dictionary<int, int> dictionary = this.RoleSkillBranchGamePlayCacheMap.TryGetValue(gamePlayType, out dictionary2) ? dictionary2 : null;
		if (dictionary != null)
		{
			dictionary.Clear();
		}
		if (this.RoleSkillBranchCacheTypeInternal == gamePlayType)
		{
			this.RoleSkillBranchCacheTypeInternal = ESkillBranchCacheType.Normal;
		}
	}

	// Token: 0x060130ED RID: 78061 RVA: 0x00593057 File Offset: 0x00591257
	public void StartRecordRoleSkillBranchChangeRequest()
	{
		this.IsRecordRoleSkillBranchChangeRequset = true;
	}

	// Token: 0x060130EE RID: 78062 RVA: 0x00593060 File Offset: 0x00591260
	public void AddRoleSkillBranchChangeRequestRecord(int roleId)
	{
		if (this.IsRecordRoleSkillBranchChangeRequset)
		{
			this.RoleSkillBranchChangeRequsetRecord.Add(roleId);
		}
	}

	// Token: 0x060130EF RID: 78063 RVA: 0x00593077 File Offset: 0x00591277
	public List<int> StopRecordRoleSkillBranchChangeRequest()
	{
		List<int> result = new List<int>(this.RoleSkillBranchChangeRequsetRecord);
		this.RoleSkillBranchChangeRequsetRecord.Clear();
		this.IsRecordRoleSkillBranchChangeRequset = false;
		return result;
	}

	// Token: 0x060130F0 RID: 78064 RVA: 0x00593096 File Offset: 0x00591296
	public bool RedDotRoleOrnamentCondition()
	{
		return RoleOrnamentModel.Instance.CheckNewlyAcquiredOrnamentInMainView();
	}

	// Token: 0x060130F1 RID: 78065 RVA: 0x005930A4 File Offset: 0x005912A4
	public void SetRoleSkillBranchGamePlayCache(int roleId, int branchId, ESkillBranchCacheType gamePlayType)
	{
		if (branchId == 0 || roleId == 0)
		{
			return;
		}
		Dictionary<int, int> dictionary2;
		Dictionary<int, int> dictionary = this.RoleSkillBranchGamePlayCacheMap.TryGetValue(gamePlayType, out dictionary2) ? dictionary2 : null;
		if (dictionary == null)
		{
			dictionary = new Dictionary<int, int>();
			this.RoleSkillBranchGamePlayCacheMap[gamePlayType] = dictionary;
		}
		dictionary[roleId] = branchId;
	}

	// Token: 0x060130F2 RID: 78066 RVA: 0x005930EB File Offset: 0x005912EB
	public int GetRoleSkillBranchIdInCurrentGamePlay(int roleId)
	{
		return this.GetRoleSkillBranchIdInGamePlay(roleId, this.RoleSkillBranchCacheTypeInternal);
	}

	// Token: 0x060130F3 RID: 78067 RVA: 0x005930FC File Offset: 0x005912FC
	public int GetRoleSkillBranchIdInGamePlay(int roleId, ESkillBranchCacheType gamePlayType)
	{
		if (roleId <= 0 || !this.IsRoleHasBranch(roleId))
		{
			return 0;
		}
		Dictionary<int, int> dictionary2;
		Dictionary<int, int> dictionary = this.RoleSkillBranchGamePlayCacheMap.TryGetValue(gamePlayType, out dictionary2) ? dictionary2 : null;
		int value;
		int? num = (dictionary != null && dictionary.TryGetValue(roleId, out value)) ? new int?(value) : null;
		if (num == null)
		{
			return this.GetRoleCurrentBranchId(roleId);
		}
		return num.Value;
	}

	// Token: 0x060130F4 RID: 78068 RVA: 0x0059316A File Offset: 0x0059136A
	public int GetRoleSkillBranchIndexInCurrentGamePlay(int roleId)
	{
		return this.GetRoleSkillBranchIndexInGamePlay(roleId, this.RoleSkillBranchCacheTypeInternal);
	}

	// Token: 0x060130F5 RID: 78069 RVA: 0x0059317C File Offset: 0x0059137C
	public int GetRoleSkillBranchIndexInGamePlay(int roleId, ESkillBranchCacheType gamePlayType)
	{
		int branchId = this.GetRoleSkillBranchIdInGamePlay(roleId, gamePlayType);
		if (branchId == 0)
		{
			return -1;
		}
		return Array.FindIndex<int>(this.GetRoleBranchIdList(roleId), (int id) => branchId == id);
	}

	// Token: 0x17001D1D RID: 7453
	// (get) Token: 0x060130F6 RID: 78070 RVA: 0x005931BF File Offset: 0x005913BF
	public static RoleModel Instance
	{
		get
		{
			return RoleModel._Instance;
		}
	}

	// Token: 0x060130F7 RID: 78071 RVA: 0x005931C6 File Offset: 0x005913C6
	public static RoleModel GetOrCreateInstance()
	{
		if (RoleModel._Instance == null)
		{
			RoleModel.CreateInstance();
		}
		return RoleModel._Instance;
	}

	// Token: 0x060130F8 RID: 78072 RVA: 0x005931DA File Offset: 0x005913DA
	public static bool CreateInstance()
	{
		if (RoleModel._Instance != null)
		{
			return true;
		}
		RoleModel._Instance = new RoleModel();
		return true;
	}

	// Token: 0x060130F9 RID: 78073 RVA: 0x005931F0 File Offset: 0x005913F0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060130FA RID: 78074 RVA: 0x005931F2 File Offset: 0x005913F2
	public static void ResetStaticDefaultValue()
	{
		RoleModel._Instance = null;
	}

	// Token: 0x060130FB RID: 78075 RVA: 0x005931FA File Offset: 0x005913FA
	static RoleModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleModel.CreateStaticDefaultValue), new Action(RoleModel.ResetStaticDefaultValue));
	}

	// Token: 0x06013100 RID: 78080 RVA: 0x005933C8 File Offset: 0x005915C8
	[CompilerGenerated]
	private int <CompareForMainView>g__GetTier|73_0(int roleId, out int teamIndex, ref RoleModel.<>c__DisplayClass73_0 A_3)
	{
		teamIndex = -1;
		for (int i = 0; i < A_3.myItems.Count; i++)
		{
			if (A_3.myItems[i].GetConfigId == roleId)
			{
				teamIndex = i;
				return 0;
			}
		}
		if (A_3.devTargetRoleId > 0 && roleId == A_3.devTargetRoleId)
		{
			return 1;
		}
		RoleDataBase roleDataById = this.GetRoleDataById(roleId, true);
		if (roleDataById != null && roleDataById.GetIsNew())
		{
			return 2;
		}
		return 3;
	}

	// Token: 0x0400A3B4 RID: 41908
	private readonly Dictionary<int, RoleInstance> RoleInstanceMap = new Dictionary<int, RoleInstance>();

	// Token: 0x0400A3B5 RID: 41909
	private readonly Dictionary<int, RoleRobotData> RoleRobotDataMap = new Dictionary<int, RoleRobotData>();

	// Token: 0x0400A3B6 RID: 41910
	private readonly Dictionary<int, RoleRobotData> RoleCommonRobotDataMap = new Dictionary<int, RoleRobotData>();

	// Token: 0x0400A3B7 RID: 41911
	private readonly Dictionary<int, RoleSpecialRobotData> RoleSpecialRobotDataMap = new Dictionary<int, RoleSpecialRobotData>();

	// Token: 0x0400A3B8 RID: 41912
	private readonly HashSet<int> MainRoleIdSet = new HashSet<int>();

	// Token: 0x0400A3B9 RID: 41913
	private readonly HashSet<int> LightMainRoleIdSet = new HashSet<int>();

	// Token: 0x0400A3BA RID: 41914
	private readonly Dictionary<int, int> MainRoleIdMap = new Dictionary<int, int>();

	// Token: 0x0400A3BB RID: 41915
	private bool IsShowMultiSkillDescInternal;

	// Token: 0x0400A3BC RID: 41916
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, int[]> ResonantItemRoleMapInternal;

	// Token: 0x0400A3BD RID: 41917
	private bool IsInRoleTrialInternal;

	// Token: 0x0400A3BE RID: 41918
	public HashSet<int> RoleTrialIdList = new HashSet<int>();

	// Token: 0x0400A3BF RID: 41919
	public Dictionary<int, bool> RoleTrialShowMap = new Dictionary<int, bool>();

	// Token: 0x0400A3C0 RID: 41920
	private bool CanUseSpecialTrialRoleInternal = true;

	// Token: 0x0400A3C1 RID: 41921
	private readonly Dictionary<int, int> RoleSkillBranchMap = new Dictionary<int, int>();

	// Token: 0x0400A3C2 RID: 41922
	private readonly Dictionary<ESkillBranchCacheType, Dictionary<int, int>> RoleSkillBranchGamePlayCacheMap = new Dictionary<ESkillBranchCacheType, Dictionary<int, int>>();

	// Token: 0x0400A3C3 RID: 41923
	private ESkillBranchCacheType RoleSkillBranchCacheTypeInternal;

	// Token: 0x0400A3C4 RID: 41924
	private readonly HashSet<int> RoleSkillBranchChangeRequsetRecord = new HashSet<int>();

	// Token: 0x0400A3C5 RID: 41925
	private bool IsRecordRoleSkillBranchChangeRequset;

	// Token: 0x0400A3C6 RID: 41926
	[Nullable(2)]
	private RoleSkillResponseData RoleSkillResponseDataInternal;

	// Token: 0x0400A3C7 RID: 41927
	private int[] CanChangeRoleIdList = new int[0];

	// Token: 0x0400A3C8 RID: 41928
	private bool InUltraSkillInternal;

	// Token: 0x0400A3C9 RID: 41929
	[Nullable(2)]
	private static RoleModel _Instance;
}
