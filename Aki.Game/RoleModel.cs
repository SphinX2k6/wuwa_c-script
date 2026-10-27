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
using CSharpScript.Game.Ui;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x02002897 RID: 10391
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RoleModel : ModelBase
{
	// Token: 0x17001CBE RID: 7358
	// (get) Token: 0x0601564C RID: 87628 RVA: 0x00564CCB File Offset: 0x00562ECB
	public bool IsInGamePlayRoleEdit
	{
		get
		{
			return this.RoleSkillBranchCacheTypeInternal > ESkillBranchCacheType.Normal;
		}
	}

	// Token: 0x17001CBF RID: 7359
	// (get) Token: 0x0601564D RID: 87629 RVA: 0x00564CD6 File Offset: 0x00562ED6
	public ESkillBranchCacheType RoleSkillBranchCacheType
	{
		get
		{
			return this.RoleSkillBranchCacheTypeInternal;
		}
	}

	// Token: 0x17001CC0 RID: 7360
	// (get) Token: 0x0601564E RID: 87630 RVA: 0x00564CDE File Offset: 0x00562EDE
	// (set) Token: 0x0601564F RID: 87631 RVA: 0x00564CE6 File Offset: 0x00562EE6
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

	// Token: 0x06015650 RID: 87632 RVA: 0x00564D1C File Offset: 0x00562F1C
	public void SetCanUseSpecialTrialRole(bool value)
	{
		this.CanUseSpecialTrialRoleInternal = value;
	}

	// Token: 0x06015651 RID: 87633 RVA: 0x00564D28 File Offset: 0x00562F28
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

	// Token: 0x06015652 RID: 87634 RVA: 0x00564DA8 File Offset: 0x00562FA8
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

	// Token: 0x06015653 RID: 87635 RVA: 0x00564DF7 File Offset: 0x00562FF7
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		return true;
	}

	// Token: 0x06015654 RID: 87636 RVA: 0x00564E18 File Offset: 0x00563018
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

	// Token: 0x06015655 RID: 87637 RVA: 0x00564F04 File Offset: 0x00563104
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

	// Token: 0x06015656 RID: 87638 RVA: 0x00564FDC File Offset: 0x005631DC
	public void SortRoleDataList(List<RoleDataBase> resultList)
	{
		resultList.Sort(new Comparison<RoleDataBase>(this.SortByFormationLevelQuality));
	}

	// Token: 0x06015657 RID: 87639 RVA: 0x00564FF0 File Offset: 0x005631F0
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

	// Token: 0x06015658 RID: 87640 RVA: 0x00565004 File Offset: 0x00563204
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

	// Token: 0x06015659 RID: 87641 RVA: 0x00565038 File Offset: 0x00563238
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

	// Token: 0x0601565A RID: 87642 RVA: 0x005650F4 File Offset: 0x005632F4
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

	// Token: 0x0601565B RID: 87643 RVA: 0x00565148 File Offset: 0x00563348
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

	// Token: 0x0601565C RID: 87644 RVA: 0x0056517C File Offset: 0x0056337C
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

	// Token: 0x0601565D RID: 87645 RVA: 0x005651B8 File Offset: 0x005633B8
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.RoleDataItem);
		this.IsInRoleTrial = false;
		this.RoleTrialShowMap.Clear();
		this.RoleInstanceMap.Clear();
		this.RoleRobotDataMap.Clear();
		this.RoleCommonRobotDataMap.Clear();
		this.RoleSpecialRobotDataMap.Clear();
		return true;
	}

	// Token: 0x0601565E RID: 87646 RVA: 0x00565230 File Offset: 0x00563430
	public void UpdateRoleInfoByServerData(roleInfo[] roleDataList)
	{
		foreach (roleInfo roleInfo in roleDataList)
		{
			this.UpdateRoleInfo(roleInfo);
		}
		EventSystem.Instance.Emit(EEventName.RoleInfoUpdate);
	}

	// Token: 0x0601565F RID: 87647 RVA: 0x00565268 File Offset: 0x00563468
	public void RoleChange(int sourceRoleId, roleInfo roleInfo)
	{
		this.RoleInstanceMap.Remove(sourceRoleId);
		this.UpdateRoleInfo(roleInfo);
		this.UpdateMainRoleMap(roleInfo.RoleId);
		EventSystem.Instance.Emit<int>(EEventName.RoleSystemDeleteRole, sourceRoleId);
		EventSystem.Instance.Emit<int>(EEventName.RoleSystemChangeRole, roleInfo.RoleId);
	}

	// Token: 0x06015660 RID: 87648 RVA: 0x005652BC File Offset: 0x005634BC
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
			EventSystem.Instance.Emit<EFunction>(EEventName.RefreshMenuSetting, EFunction.GENDERSETTING);
		}
		roleInstance.RefreshRoleInfo(roleInfo);
	}

	// Token: 0x06015661 RID: 87649 RVA: 0x00565338 File Offset: 0x00563538
	public void UpdateMainRoleMap(int newMainRoleId)
	{
		foreach (int key in this.GetMainRoleSet())
		{
			this.MainRoleIdMap[key] = newMainRoleId;
		}
	}

	// Token: 0x06015662 RID: 87650 RVA: 0x00565394 File Offset: 0x00563594
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
		EventSystem.Instance.Emit(EEventName.RoleInfoUpdate);
		if (level2 < level)
		{
			EventSystem.Instance.Emit<int, int, int>(EEventName.RoleLevelUp, roleId, exp, level);
		}
	}

	// Token: 0x06015663 RID: 87651 RVA: 0x005653F0 File Offset: 0x005635F0
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

	// Token: 0x06015664 RID: 87652 RVA: 0x00565488 File Offset: 0x00563688
	public void RoleBreakUp(int roleId, int breakLevel)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		if (roleInstanceById != null)
		{
			roleInstanceById.GetLevelData().SetBreachLevel(breakLevel);
		}
		EventSystem.Instance.Emit(EEventName.RoleInfoUpdate);
		EventSystem.Instance.Emit<int, int>(EEventName.RoleBreakUp, roleId, breakLevel);
	}

	// Token: 0x06015665 RID: 87653 RVA: 0x005654D0 File Offset: 0x005636D0
	public void RoleSkillLevelUp(int roleId, ArrayIntInt skillInfo)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		if (roleInstanceById != null)
		{
			roleInstanceById.RefreshSkillInfo(skillInfo.Key, skillInfo.Value);
		}
		EventSystem.Instance.Emit<int, ArrayIntInt>(EEventName.RoleSkillLevelUp, roleId, skillInfo);
	}

	// Token: 0x06015666 RID: 87654 RVA: 0x0056550C File Offset: 0x0056370C
	public void RoleNameUpdate(int roleId, string name)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		if (roleInstanceById != null)
		{
			roleInstanceById.SetRoleName(name);
			EventSystem.Instance.Emit(EEventName.RoleRefreshName);
		}
	}

	// Token: 0x06015667 RID: 87655 RVA: 0x0056553C File Offset: 0x0056373C
	public void RoleAttrUpdate(int roleId, ArrayIntInt[] baseAttr, ArrayIntInt[] addAttr)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		if (roleInstanceById != null)
		{
			roleInstanceById.RefreshRoleAttr(baseAttr, addAttr);
		}
	}

	// Token: 0x06015668 RID: 87656 RVA: 0x0056555C File Offset: 0x0056375C
	public void RoleResonanceLockFinish(PbRoleResonLockFinishNotify notify)
	{
		this.RoleInstanceMap[notify.RoleId].GetResonanceData().SetResonanceLock(notify.ResonId);
	}

	// Token: 0x06015669 RID: 87657 RVA: 0x0056557F File Offset: 0x0056377F
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

	// Token: 0x17001CC1 RID: 7361
	// (get) Token: 0x0601566A RID: 87658 RVA: 0x0056559C File Offset: 0x0056379C
	// (set) Token: 0x0601566B RID: 87659 RVA: 0x005655A4 File Offset: 0x005637A4
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

	// Token: 0x17001CC2 RID: 7362
	// (get) Token: 0x0601566C RID: 87660 RVA: 0x005655AD File Offset: 0x005637AD
	// (set) Token: 0x0601566D RID: 87661 RVA: 0x005655B7 File Offset: 0x005637B7
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

	// Token: 0x17001CC3 RID: 7363
	// (get) Token: 0x0601566E RID: 87662 RVA: 0x005655C2 File Offset: 0x005637C2
	// (set) Token: 0x0601566F RID: 87663 RVA: 0x005655CC File Offset: 0x005637CC
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

	// Token: 0x06015670 RID: 87664 RVA: 0x005655D7 File Offset: 0x005637D7
	public bool IsSkillShowTagUnlocked()
	{
		return FunctionModel.Instance.IsOpen(EFunctionType.RoleDev);
	}

	// Token: 0x06015671 RID: 87665 RVA: 0x005655E8 File Offset: 0x005637E8
	public ERoleSkillDescType GetRoleSkillDescType()
	{
		if (GameModeModel.Instance.IsMulti)
		{
			return ERoleSkillDescType.MultiDesc;
		}
		return ERoleSkillDescType.ResumeDesc;
	}

	// Token: 0x06015672 RID: 87666 RVA: 0x005655FC File Offset: 0x005637FC
	public RoleInstance[] GetRoleList()
	{
		List<int> list = new List<int>(this.RoleInstanceMap.Keys);
		this.SortRoleList(list);
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

	// Token: 0x06015673 RID: 87667 RVA: 0x00565690 File Offset: 0x00563890
	public RoleInstance[] GetRoleListWithoutMainRole()
	{
		List<int> list = new List<int>(this.RoleInstanceMap.Keys);
		this.SortRoleList(list);
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

	// Token: 0x06015674 RID: 87668 RVA: 0x00565730 File Offset: 0x00563930
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

	// Token: 0x06015675 RID: 87669 RVA: 0x00565834 File Offset: 0x00563A34
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

	// Token: 0x06015676 RID: 87670 RVA: 0x0056595C File Offset: 0x00563B5C
	public Dictionary<int, RoleInstance> GetRoleMap()
	{
		return this.RoleInstanceMap;
	}

	// Token: 0x06015677 RID: 87671 RVA: 0x00565964 File Offset: 0x00563B64
	public Dictionary<int, RoleRobotData> GetRoleRobotMap()
	{
		return this.RoleRobotDataMap;
	}

	// Token: 0x06015678 RID: 87672 RVA: 0x0056596C File Offset: 0x00563B6C
	public Dictionary<int, RoleRobotData> GetCommonRoleRobotMap()
	{
		return this.RoleCommonRobotDataMap;
	}

	// Token: 0x06015679 RID: 87673 RVA: 0x00565974 File Offset: 0x00563B74
	public Dictionary<int, RoleSpecialRobotData> GetRoleFormationRobotMap()
	{
		return this.RoleSpecialRobotDataMap;
	}

	// Token: 0x0601567A RID: 87674 RVA: 0x0056597C File Offset: 0x00563B7C
	public int? GetBattleTeamFirstRoleId()
	{
		SceneTeamItem getCurrentTeamItem = SceneTeamModel.Instance.GetCurrentTeamItem;
		if (getCurrentTeamItem == null)
		{
			return null;
		}
		return new int?(getCurrentTeamItem.GetConfigId);
	}

	// Token: 0x0601567B RID: 87675 RVA: 0x005659AC File Offset: 0x00563BAC
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

	// Token: 0x0601567C RID: 87676 RVA: 0x00565A78 File Offset: 0x00563C78
	private void SortRoleList(List<int> roleIdList)
	{
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

	// Token: 0x0601567D RID: 87677 RVA: 0x00565A8C File Offset: 0x00563C8C
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

	// Token: 0x0601567E RID: 87678 RVA: 0x00565B3C File Offset: 0x00563D3C
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

	// Token: 0x0601567F RID: 87679 RVA: 0x00565BC8 File Offset: 0x00563DC8
	public int? GetNewMainRoleId(int oldMainRoleId)
	{
		if (this.MainRoleIdMap.ContainsKey(oldMainRoleId))
		{
			return new int?(this.MainRoleIdMap[oldMainRoleId]);
		}
		return null;
	}

	// Token: 0x06015680 RID: 87680 RVA: 0x00565C00 File Offset: 0x00563E00
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

	// Token: 0x06015681 RID: 87681 RVA: 0x00565C54 File Offset: 0x00563E54
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

	// Token: 0x06015682 RID: 87682 RVA: 0x00565CC8 File Offset: 0x00563EC8
	public bool HasAnyTrialRole()
	{
		using (List<int>.Enumerator enumerator = this.GetRoleSystemRoleList(false).GetEnumerator())
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

	// Token: 0x06015683 RID: 87683 RVA: 0x00565D24 File Offset: 0x00563F24
	[NullableContext(2)]
	public RoleInstance GetRoleInstanceById(int id)
	{
		if (this.RoleInstanceMap.ContainsKey(id))
		{
			return this.RoleInstanceMap[id];
		}
		return null;
	}

	// Token: 0x06015684 RID: 87684 RVA: 0x00565D44 File Offset: 0x00563F44
	public string GetRoleName(int roleId, int? playerId = null)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		if (roleDataById != null)
		{
			return roleDataById.GetName(playerId);
		}
		return ConfigMultiTextLang.GetLocalTextNew(RoleConfig.Instance.GetRoleConfig(roleId).Value.Name, null);
	}

	// Token: 0x06015685 RID: 87685 RVA: 0x00565D8C File Offset: 0x00563F8C
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

	// Token: 0x06015686 RID: 87686 RVA: 0x00565DD0 File Offset: 0x00563FD0
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

	// Token: 0x06015687 RID: 87687 RVA: 0x00565E4C File Offset: 0x0056404C
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

	// Token: 0x06015688 RID: 87688 RVA: 0x00565E9C File Offset: 0x0056409C
	public int GetMoneyToLevelUp(int exp)
	{
		int value = ConfigCommonParamById.GetIntConfig("ExpConversionCount").Value;
		return (int)Math.Ceiling((double)(exp * value) / 1000.0);
	}

	// Token: 0x06015689 RID: 87689 RVA: 0x00565ED0 File Offset: 0x005640D0
	public bool GetHasEnoughMoneyLevelUp(int roleId)
	{
		int selectLevelUpItemNeedMoney = this.GetSelectLevelUpItemNeedMoney(roleId);
		int playerMoney = PlayerInfoModel.Instance.GetPlayerMoney(2);
		return selectLevelUpItemNeedMoney <= playerMoney;
	}

	// Token: 0x0601568A RID: 87690 RVA: 0x00565EF8 File Offset: 0x005640F8
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

	// Token: 0x0601568B RID: 87691 RVA: 0x00565F84 File Offset: 0x00564184
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

	// Token: 0x0601568C RID: 87692 RVA: 0x00566074 File Offset: 0x00564274
	public bool GetRoleNeedBreakUp(int roleId)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		return roleInstanceById != null && roleInstanceById.GetLevelData().GetRoleNeedBreakUp();
	}

	// Token: 0x0601568D RID: 87693 RVA: 0x0056609C File Offset: 0x0056429C
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

	// Token: 0x0601568E RID: 87694 RVA: 0x00566120 File Offset: 0x00564320
	public int? GetRoleExpItemExp(int itemId)
	{
		return RoleConfig.Instance.GetRoleExpItemExp(itemId);
	}

	// Token: 0x0601568F RID: 87695 RVA: 0x00566130 File Offset: 0x00564330
	public RoleInstance[] GetAllRoleList()
	{
		List<RoleInstance> list = new List<RoleInstance>();
		foreach (KeyValuePair<int, RoleInstance> keyValuePair in this.RoleInstanceMap)
		{
			list.Add(keyValuePair.Value);
		}
		return list.ToArray();
	}

	// Token: 0x06015690 RID: 87696 RVA: 0x00566198 File Offset: 0x00564398
	public List<int> GetRoleIdList()
	{
		List<int> list = new List<int>(this.RoleInstanceMap.Keys);
		this.SortRoleList(list);
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

	// Token: 0x06015691 RID: 87697 RVA: 0x00566224 File Offset: 0x00564424
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

	// Token: 0x06015692 RID: 87698 RVA: 0x005662A8 File Offset: 0x005644A8
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

	// Token: 0x06015693 RID: 87699 RVA: 0x00566310 File Offset: 0x00564510
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

	// Token: 0x06015694 RID: 87700 RVA: 0x005663E4 File Offset: 0x005645E4
	public bool IsTrialRoleShowFullTab(int trialRoleId)
	{
		bool flag;
		return !this.RoleTrialShowMap.TryGetValue(trialRoleId, out flag) || flag;
	}

	// Token: 0x06015695 RID: 87701 RVA: 0x00566404 File Offset: 0x00564604
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

	// Token: 0x06015696 RID: 87702 RVA: 0x005664CC File Offset: 0x005646CC
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

	// Token: 0x06015697 RID: 87703 RVA: 0x005665A8 File Offset: 0x005647A8
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

	// Token: 0x06015698 RID: 87704 RVA: 0x00566630 File Offset: 0x00564830
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

	// Token: 0x06015699 RID: 87705 RVA: 0x00566680 File Offset: 0x00564880
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

	// Token: 0x0601569A RID: 87706 RVA: 0x005666CC File Offset: 0x005648CC
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

	// Token: 0x0601569B RID: 87707 RVA: 0x0056675C File Offset: 0x0056495C
	public bool RedDotAttributeTabLevelUpCondition(int roleId)
	{
		RoleDataBase roleDataById = this.GetRoleDataById(roleId, true);
		return roleDataById != null && !roleDataById.IsTrialRole() && !roleDataById.GetLevelData().GetRoleIsMaxLevel() && (this.GetSelectHasEnoughItemToLevelUp(roleId) && this.GetHasEnoughMoneyLevelUp(roleId));
	}

	// Token: 0x0601569C RID: 87708 RVA: 0x005667A4 File Offset: 0x005649A4
	public bool RedDotAttributeTabBreakUpCondition(int roleId)
	{
		RoleDataBase roleDataById = this.GetRoleDataById(roleId, true);
		return roleDataById != null && !roleDataById.IsTrialRole() && roleDataById.GetLevelData().GetRoleNeedBreakUp() && this.RedDotAttributeTabBreachCondition(roleDataById);
	}

	// Token: 0x0601569D RID: 87709 RVA: 0x005667E0 File Offset: 0x005649E0
	public bool RedDotFavorItemActiveCondition(int roleId)
	{
		RoleDataBase roleDataById = this.GetRoleDataById(roleId, true);
		return !roleDataById.IsTrialRole() && roleDataById.GetFavorData().IsExistCanUnlockFavorItem();
	}

	// Token: 0x0601569E RID: 87710 RVA: 0x0056680B File Offset: 0x00564A0B
	private bool RedDotAttributeTabBreachCondition(RoleDataBase roleInstance)
	{
		return roleInstance.GetLevelData().IsEnoughBreachConsume();
	}

	// Token: 0x0601569F RID: 87711 RVA: 0x00566818 File Offset: 0x00564A18
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

	// Token: 0x060156A0 RID: 87712 RVA: 0x005668D0 File Offset: 0x00564AD0
	public bool RedDotCondition()
	{
		return this.RedDotResonanceCondition() || this.RedDotRoleSkinCondition() || this.RedDotRoleOrnamentCondition();
	}

	// Token: 0x060156A1 RID: 87713 RVA: 0x005668EC File Offset: 0x00564AEC
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

	// Token: 0x060156A2 RID: 87714 RVA: 0x00566924 File Offset: 0x00564B24
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

	// Token: 0x060156A3 RID: 87715 RVA: 0x00566960 File Offset: 0x00564B60
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

	// Token: 0x060156A4 RID: 87716 RVA: 0x00566A08 File Offset: 0x00564C08
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

	// Token: 0x060156A5 RID: 87717 RVA: 0x00566A30 File Offset: 0x00564C30
	public int GetRoleResonanceGroupIndex(RoleDataBase roleInstance)
	{
		return roleInstance.GetResonanceData().GetResonantChainGroupIndex();
	}

	// Token: 0x060156A6 RID: 87718 RVA: 0x00566A40 File Offset: 0x00564C40
	[return: Nullable(2)]
	public List<ResonantChain> GetRoleResonanceConfigList(RoleDataBase roleInstance)
	{
		int dataId = roleInstance.GetDataId();
		int resonantChainGroupId = RoleConfig.Instance.GetRoleConfig(dataId).Value.ResonantChainGroupId;
		return RoleResonanceConfig.Instance.GetRoleResonanceList(resonantChainGroupId);
	}

	// Token: 0x17001CC4 RID: 7364
	// (get) Token: 0x060156A7 RID: 87719 RVA: 0x00566A7B File Offset: 0x00564C7B
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

	// Token: 0x060156A8 RID: 87720 RVA: 0x00566A98 File Offset: 0x00564C98
	public global::SkillEffect GetCurRoleSkillViewDataLocal(int roleId, int skillGroupId)
	{
		int skillLevel = this.GetRoleDataById(roleId, true).GetSkillData().GetSkillLevel(skillGroupId);
		return this.GetRoleSkillEffect(skillGroupId, skillLevel);
	}

	// Token: 0x060156A9 RID: 87721 RVA: 0x00566AC4 File Offset: 0x00564CC4
	public global::SkillEffect GetNextRoleSkillViewDataLocal(int roleId, int skillGroupId)
	{
		int skillLevel = this.GetRoleDataById(roleId, true).GetSkillData().GetSkillLevel(skillGroupId);
		int maxSkillLevel = RoleSkillConfig.Instance.GetSkillConfigById(skillGroupId).Value.MaxSkillLevel;
		int skillLevel2 = (skillLevel < maxSkillLevel) ? (skillLevel + 1) : maxSkillLevel;
		return this.GetRoleSkillEffect(skillGroupId, skillLevel2);
	}

	// Token: 0x060156AA RID: 87722 RVA: 0x00566B18 File Offset: 0x00564D18
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

	// Token: 0x060156AB RID: 87723 RVA: 0x00566C9C File Offset: 0x00564E9C
	[NullableContext(2)]
	public void UpdateRoleSkillViewData(global::SkillEffect skillEffectList, global::SkillEffect nextSkillEffectList, int skillId)
	{
		this.RoleSkillResponseData.UpdateRoleSkillViewResponse(skillEffectList, nextSkillEffectList, skillId);
	}

	// Token: 0x060156AC RID: 87724 RVA: 0x00566CAC File Offset: 0x00564EAC
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

	// Token: 0x060156AD RID: 87725 RVA: 0x00566D25 File Offset: 0x00564F25
	public int GetUpgradeSkillIdIfUpgraded(int skillId, int roleDataId)
	{
		return this.GetRoleDataById(roleDataId, true).GetSkillData().GetSkillIdAfterUpgrade(skillId);
	}

	// Token: 0x060156AE RID: 87726 RVA: 0x00566D3C File Offset: 0x00564F3C
	public void UpdateRoleFavorData(RoleFavor[] favorList)
	{
		int num = favorList.Length;
		for (int i = 0; i < num; i++)
		{
			this.UpdateRoleFavorDataSingle(favorList[i]);
		}
	}

	// Token: 0x060156AF RID: 87727 RVA: 0x00566D64 File Offset: 0x00564F64
	public void UpdateRoleFavorCondition(Dictionary<int, ConditionInfo> conditionMap)
	{
		foreach (KeyValuePair<int, ConditionInfo> keyValuePair in conditionMap)
		{
			int key = keyValuePair.Key;
			ConditionInfo value = keyValuePair.Value;
			RoleFavorConditionModel.Instance.UpdateRoleFavorCondition(key, value);
		}
	}

	// Token: 0x060156B0 RID: 87728 RVA: 0x00566DC8 File Offset: 0x00564FC8
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

	// Token: 0x060156B1 RID: 87729 RVA: 0x00566E68 File Offset: 0x00565068
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

	// Token: 0x060156B2 RID: 87730 RVA: 0x00566EA4 File Offset: 0x005650A4
	public void UpdateRoleFavorLevelAndExp(RoleFavorLevelUpdateNotify info)
	{
		int roleId = info.RoleId;
		RoleFavorData favorData = RoleModel.Instance.GetRoleInstanceById(roleId).GetFavorData();
		favorData.SetFavorLevel(info.Level);
		favorData.SetFavorExp(info.Exp);
	}

	// Token: 0x060156B3 RID: 87731 RVA: 0x00566EE0 File Offset: 0x005650E0
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

	// Token: 0x060156B4 RID: 87732 RVA: 0x00566F30 File Offset: 0x00565130
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

	// Token: 0x060156B5 RID: 87733 RVA: 0x00566F80 File Offset: 0x00565180
	public bool GetRoleBackgroundMusicEnabled(int roleDataId)
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(roleDataId);
		return roleInstanceById == null || roleInstanceById.GetBackgroundMusicEnabled();
	}

	// Token: 0x060156B6 RID: 87734 RVA: 0x00566FA4 File Offset: 0x005651A4
	public List<int> GetRoleSystemRoleList(bool includeRobots = false)
	{
		if (DangoAbyssModel.Instance.CheckIfInSmallWorldInstance())
		{
			return this.GetRoleIdList();
		}
		if (GameModeModel.Instance.IsMulti)
		{
			return this.GetRoleIdList();
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
			this.SortRoleList(list2);
			return list2;
		}
		List<int> roleIdList = this.GetRoleIdList();
		if (includeRobots)
		{
			List<int> list3 = new List<int>(roleIdList);
			this.MergeSpecialRoleIdList(list3);
			this.SortRoleList(list3);
			return list3;
		}
		return roleIdList;
	}

	// Token: 0x060156B7 RID: 87735 RVA: 0x0056710C File Offset: 0x0056530C
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

	// Token: 0x060156B8 RID: 87736 RVA: 0x0056717C File Offset: 0x0056537C
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

	// Token: 0x060156B9 RID: 87737 RVA: 0x00567268 File Offset: 0x00565468
	public void UpdateCanChangeRoleIdList(int[] roleIds)
	{
		List<int> list = new List<int>(this.CanChangeRoleIdList);
		foreach (int item in roleIds)
		{
			list.Add(item);
		}
		this.CanChangeRoleIdList = list.ToArray();
	}

	// Token: 0x060156BA RID: 87738 RVA: 0x005672A8 File Offset: 0x005654A8
	public int[] GetCanChangeRoleIdList()
	{
		return this.CanChangeRoleIdList;
	}

	// Token: 0x060156BB RID: 87739 RVA: 0x005672B0 File Offset: 0x005654B0
	public bool IsMainRole(int roleId)
	{
		return this.GetMainRoleSet().Contains(roleId);
	}

	// Token: 0x060156BC RID: 87740 RVA: 0x005672BE File Offset: 0x005654BE
	public bool IsLightMainRole(int roleId)
	{
		return this.GetLightMainRoleSet().Contains(roleId);
	}

	// Token: 0x060156BD RID: 87741 RVA: 0x005672CC File Offset: 0x005654CC
	private HashSet<int> GetMainRoleSet()
	{
		if (this.MainRoleIdSet.Count == 0)
		{
			this.InitMainRoleIdSet();
		}
		return this.MainRoleIdSet;
	}

	// Token: 0x060156BE RID: 87742 RVA: 0x005672E7 File Offset: 0x005654E7
	private HashSet<int> GetLightMainRoleSet()
	{
		if (this.LightMainRoleIdSet.Count == 0)
		{
			this.InitLightMainRoleIdSet();
		}
		return this.LightMainRoleIdSet;
	}

	// Token: 0x060156BF RID: 87743 RVA: 0x00567304 File Offset: 0x00565504
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

	// Token: 0x060156C0 RID: 87744 RVA: 0x0056734C File Offset: 0x0056554C
	private void InitLightMainRoleIdSet()
	{
		foreach (int item in ConfigCommonParamById.GetIntArrayConfig("LightMainRoleIdList"))
		{
			this.LightMainRoleIdSet.Add(item);
		}
	}

	// Token: 0x060156C1 RID: 87745 RVA: 0x005673A4 File Offset: 0x005655A4
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

	// Token: 0x060156C2 RID: 87746 RVA: 0x00567414 File Offset: 0x00565614
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

	// Token: 0x060156C3 RID: 87747 RVA: 0x00567480 File Offset: 0x00565680
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

	// Token: 0x060156C4 RID: 87748 RVA: 0x00567508 File Offset: 0x00565708
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

	// Token: 0x060156C5 RID: 87749 RVA: 0x0056762C File Offset: 0x0056582C
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

	// Token: 0x060156C6 RID: 87750 RVA: 0x0056767C File Offset: 0x0056587C
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

	// Token: 0x060156C7 RID: 87751 RVA: 0x005676F4 File Offset: 0x005658F4
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

	// Token: 0x060156C8 RID: 87752 RVA: 0x00567764 File Offset: 0x00565964
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

	// Token: 0x060156C9 RID: 87753 RVA: 0x005677C4 File Offset: 0x005659C4
	public int GetAttributeByLevel(int roleId, EAttributeType attributeId, int level, int breachLevel)
	{
		float baseAttributeById = (float)this.GetBaseAttributeById(roleId, attributeId);
		float attributeRadioByLevel = this.GetAttributeRadioByLevel(attributeId, level, breachLevel);
		return (int)Math.Floor((double)(baseAttributeById * attributeRadioByLevel * 0.0001f));
	}

	// Token: 0x060156CA RID: 87754 RVA: 0x005677F4 File Offset: 0x005659F4
	public int GetAddAttrLevelUp(int roleId, int srcLevel, int srcBreachLevel, int tarLevel, int tarBreachLevel, int attributeId)
	{
		int attributeByLevel = this.GetAttributeByLevel(roleId, (EAttributeType)attributeId, srcLevel, srcBreachLevel);
		return this.GetAttributeByLevel(roleId, (EAttributeType)attributeId, tarLevel, tarBreachLevel) - attributeByLevel;
	}

	// Token: 0x060156CB RID: 87755 RVA: 0x0056781C File Offset: 0x00565A1C
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

	// Token: 0x060156CC RID: 87756 RVA: 0x00567862 File Offset: 0x00565A62
	public int GetRoleSkillTreeNodeLevelByConfig(RoleDataBase roleInstance, SkillTree config)
	{
		return roleInstance.GetSkillData().GetSkillNodeLevel(config);
	}

	// Token: 0x060156CD RID: 87757 RVA: 0x00567870 File Offset: 0x00565A70
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

	// Token: 0x060156CE RID: 87758 RVA: 0x005678D8 File Offset: 0x00565AD8
	public bool GetRoleSkillTreeNodeConsumeSatisfied(int roleId, int skillNodeId)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		return roleInstanceById != null && roleInstanceById.GetSkillData().IsSkillTreeNodeConsumeSatisfied(skillNodeId);
	}

	// Token: 0x060156CF RID: 87759 RVA: 0x00567900 File Offset: 0x00565B00
	public string GetSkillAttributeNameByOneSkillEffect(global::OneSkillEffect effect)
	{
		return RoleSkillConfig.Instance.GetRoleSkillDescriptionConfigById(effect.Id).Value.AttributeName;
	}

	// Token: 0x060156D0 RID: 87760 RVA: 0x00567930 File Offset: 0x00565B30
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

	// Token: 0x060156D1 RID: 87761 RVA: 0x00567A08 File Offset: 0x00565C08
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

	// Token: 0x060156D2 RID: 87762 RVA: 0x00567BFC File Offset: 0x00565DFC
	[NullableContext(2)]
	public int[] GetResonantItemRoleId(int itemId)
	{
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(itemId);
		bool flag;
		if (itemConfig == null)
		{
			flag = true;
		}
		else
		{
			int[] array = itemConfig.GetValueOrDefault().ShowTypes();
			flag = !((array != null) ? new bool?(array.Contains(30)) : null).GetValueOrDefault();
		}
		if (flag)
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

	// Token: 0x060156D3 RID: 87763 RVA: 0x00567C7C File Offset: 0x00565E7C
	public bool CheckRoleResonantIfMax(int roleId)
	{
		RoleInstance roleInstanceById = this.GetRoleInstanceById(roleId);
		return roleInstanceById != null && this.GetRoleResonanceGroupIndex(roleInstanceById) >= RoleResonanceConfig.Instance.GetResonanceMaxLevel();
	}

	// Token: 0x060156D4 RID: 87764 RVA: 0x00567CAC File Offset: 0x00565EAC
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

	// Token: 0x060156D5 RID: 87765 RVA: 0x00567CDC File Offset: 0x00565EDC
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

	// Token: 0x060156D6 RID: 87766 RVA: 0x00567D6C File Offset: 0x00565F6C
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

	// Token: 0x060156D7 RID: 87767 RVA: 0x00567EBE File Offset: 0x005660BE
	public bool InUltraSkill()
	{
		return this.InUltraSkillInternal;
	}

	// Token: 0x060156D8 RID: 87768 RVA: 0x00567EC8 File Offset: 0x005660C8
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

	// Token: 0x060156D9 RID: 87769 RVA: 0x00567F84 File Offset: 0x00566184
	private void OnUltraTagChange(int tagId, bool tagExist)
	{
		if (tagId != GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.大招"])
		{
			return;
		}
		this.InUltraSkillInternal = tagExist;
		EventSystem.Instance.Emit<bool>(EEventName.OnEnterOrExitUltraSkill, tagExist);
	}

	// Token: 0x060156DA RID: 87770 RVA: 0x00567FB1 File Offset: 0x005661B1
	public int[] GetRoleTagByRoleInfo(RoleInfo roleInfo)
	{
		if (this.ClientCheckRoleIsUpgradeLightMainRole(roleInfo.Id))
		{
			return ConfigCommonParamById.GetIntArrayConfig("MainRoleReplaceTagList").ToArray<int>();
		}
		return roleInfo.GetTagArray();
	}

	// Token: 0x060156DB RID: 87771 RVA: 0x00567FDC File Offset: 0x005661DC
	public bool ClientCheckRoleIsUpgradeLightMainRole(int roleId)
	{
		if (!this.IsLightMainRole(roleId))
		{
			return false;
		}
		int? intConfig = ConfigCommonParamById.GetIntConfig("MainRoleTagReplaceCondition");
		return LevelGeneralController.Instance.CheckCondition(intConfig.Value.ToString(), null, false, Array.Empty<object>());
	}

	// Token: 0x060156DC RID: 87772 RVA: 0x0056801F File Offset: 0x0056621F
	public int[] GetRoleBranchIdList(int roleId)
	{
		return RoleConfig.Instance.GetRoleBranchIds(roleId);
	}

	// Token: 0x060156DD RID: 87773 RVA: 0x0056802C File Offset: 0x0056622C
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

	// Token: 0x060156DE RID: 87774 RVA: 0x0056805D File Offset: 0x0056625D
	public int GetRoleBranchIdByIndex(int roleId, int index)
	{
		return this.GetRoleBranchIdList(roleId)[index];
	}

	// Token: 0x060156DF RID: 87775 RVA: 0x00568068 File Offset: 0x00566268
	public int GetRoleDefaultBranchId(int roleId)
	{
		return RoleConfig.Instance.GetRoleDefaultBranch(roleId);
	}

	// Token: 0x060156E0 RID: 87776 RVA: 0x00568078 File Offset: 0x00566278
	public int GetRoleCurrentBranchIndex(int roleId)
	{
		int[] roleBranchIdList = this.GetRoleBranchIdList(roleId);
		int skillBranch = this.GetRoleCurrentBranchId(roleId);
		return Array.FindIndex<int>(roleBranchIdList, (int id) => skillBranch == id);
	}

	// Token: 0x060156E1 RID: 87777 RVA: 0x005680B0 File Offset: 0x005662B0
	public int GetRoleOppositeBranchId(int roleId)
	{
		int roleCurrentBranchIndex = this.GetRoleCurrentBranchIndex(roleId);
		return this.GetRoleBranchIdByIndex(roleId, (roleCurrentBranchIndex == 0) ? 1 : 0);
	}

	// Token: 0x060156E2 RID: 87778 RVA: 0x005680D0 File Offset: 0x005662D0
	public int GetRoleDefaultBranchIndex(int roleId)
	{
		int[] roleBranchIdList = this.GetRoleBranchIdList(roleId);
		int skillBranch = this.GetRoleDefaultBranchId(roleId);
		return Array.FindIndex<int>(roleBranchIdList, (int id) => skillBranch == id);
	}

	// Token: 0x060156E3 RID: 87779 RVA: 0x00568108 File Offset: 0x00566308
	public bool IsSkillNodeHasBranch(int nodeId)
	{
		int[] skillNodeBranchIdList = this.GetSkillNodeBranchIdList(nodeId);
		return skillNodeBranchIdList != null && skillNodeBranchIdList.Length == 2;
	}

	// Token: 0x060156E4 RID: 87780 RVA: 0x00568128 File Offset: 0x00566328
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

	// Token: 0x060156E5 RID: 87781 RVA: 0x00568168 File Offset: 0x00566368
	public int GetSkillNodeCurrentBranchId(int roleId, int nodeId)
	{
		int roleCurrentBranchIndex = this.GetRoleCurrentBranchIndex(roleId);
		return RoleConfig.Instance.GetSkillNodeBranchIds(nodeId)[roleCurrentBranchIndex];
	}

	// Token: 0x060156E6 RID: 87782 RVA: 0x0056818A File Offset: 0x0056638A
	public int[] GetSkillNodeBranchIdList(int nodeId)
	{
		return RoleConfig.Instance.GetSkillNodeBranchIds(nodeId);
	}

	// Token: 0x060156E7 RID: 87783 RVA: 0x00568197 File Offset: 0x00566397
	public void SetRoleBranch(int roleId, int skillBranch)
	{
		this.RoleSkillBranchMap[roleId] = skillBranch;
	}

	// Token: 0x060156E8 RID: 87784 RVA: 0x005681A8 File Offset: 0x005663A8
	public bool IsRoleHasBranch(int roleId)
	{
		if (roleId == 0)
		{
			return false;
		}
		int[] roleBranchIdList = this.GetRoleBranchIdList(roleId);
		return roleBranchIdList != null && roleBranchIdList.Length == 2;
	}

	// Token: 0x060156E9 RID: 87785 RVA: 0x005681CD File Offset: 0x005663CD
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

	// Token: 0x060156EA RID: 87786 RVA: 0x005681F6 File Offset: 0x005663F6
	public bool IsRoleOwned(int roleId)
	{
		return this.RoleInstanceMap.ContainsKey(roleId);
	}

	// Token: 0x060156EB RID: 87787 RVA: 0x00568204 File Offset: 0x00566404
	public int GetRoleBranchIndexById(int roleId, int skillBranchId)
	{
		return Array.FindIndex<int>(this.GetRoleBranchIdList(roleId), (int id) => skillBranchId == id);
	}

	// Token: 0x060156EC RID: 87788 RVA: 0x00568236 File Offset: 0x00566436
	public void StartGamePlayRoleEdit(ESkillBranchCacheType gamePlayType)
	{
		this.RoleSkillBranchCacheTypeInternal = gamePlayType;
	}

	// Token: 0x060156ED RID: 87789 RVA: 0x00568240 File Offset: 0x00566440
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

	// Token: 0x060156EE RID: 87790 RVA: 0x0056827B File Offset: 0x0056647B
	public void StartRecordRoleSkillBranchChangeRequest()
	{
		this.IsRecordRoleSkillBranchChangeRequset = true;
	}

	// Token: 0x060156EF RID: 87791 RVA: 0x00568284 File Offset: 0x00566484
	public void AddRoleSkillBranchChangeRequestRecord(int roleId)
	{
		if (this.IsRecordRoleSkillBranchChangeRequset)
		{
			this.RoleSkillBranchChangeRequsetRecord.Add(roleId);
		}
	}

	// Token: 0x060156F0 RID: 87792 RVA: 0x0056829B File Offset: 0x0056649B
	public List<int> StopRecordRoleSkillBranchChangeRequest()
	{
		List<int> result = new List<int>(this.RoleSkillBranchChangeRequsetRecord);
		this.RoleSkillBranchChangeRequsetRecord.Clear();
		this.IsRecordRoleSkillBranchChangeRequset = false;
		return result;
	}

	// Token: 0x060156F1 RID: 87793 RVA: 0x005682BA File Offset: 0x005664BA
	public bool RedDotRoleOrnamentCondition()
	{
		return RoleOrnamentModel.Instance.CheckNewlyAcquiredOrnamentInMainView();
	}

	// Token: 0x060156F2 RID: 87794 RVA: 0x005682C8 File Offset: 0x005664C8
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

	// Token: 0x060156F3 RID: 87795 RVA: 0x0056830F File Offset: 0x0056650F
	public int GetRoleSkillBranchIdInCurrentGamePlay(int roleId)
	{
		return this.GetRoleSkillBranchIdInGamePlay(roleId, this.RoleSkillBranchCacheTypeInternal);
	}

	// Token: 0x060156F4 RID: 87796 RVA: 0x00568320 File Offset: 0x00566520
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

	// Token: 0x060156F5 RID: 87797 RVA: 0x0056838E File Offset: 0x0056658E
	public int GetRoleSkillBranchIndexInCurrentGamePlay(int roleId)
	{
		return this.GetRoleSkillBranchIndexInGamePlay(roleId, this.RoleSkillBranchCacheTypeInternal);
	}

	// Token: 0x060156F6 RID: 87798 RVA: 0x005683A0 File Offset: 0x005665A0
	public int GetRoleSkillBranchIndexInGamePlay(int roleId, ESkillBranchCacheType gamePlayType)
	{
		int branchId = this.GetRoleSkillBranchIdInGamePlay(roleId, gamePlayType);
		if (branchId == 0)
		{
			return -1;
		}
		return Array.FindIndex<int>(this.GetRoleBranchIdList(roleId), (int id) => branchId == id);
	}

	// Token: 0x17001CC5 RID: 7365
	// (get) Token: 0x060156F7 RID: 87799 RVA: 0x005683E3 File Offset: 0x005665E3
	public static RoleModel Instance
	{
		get
		{
			return RoleModel._Instance;
		}
	}

	// Token: 0x060156F8 RID: 87800 RVA: 0x005683EA File Offset: 0x005665EA
	public static RoleModel GetOrCreateInstance()
	{
		if (RoleModel._Instance == null)
		{
			RoleModel.CreateInstance();
		}
		return RoleModel._Instance;
	}

	// Token: 0x060156F9 RID: 87801 RVA: 0x005683FE File Offset: 0x005665FE
	public static bool CreateInstance()
	{
		if (RoleModel._Instance != null)
		{
			return true;
		}
		RoleModel._Instance = new RoleModel();
		return true;
	}

	// Token: 0x060156FA RID: 87802 RVA: 0x00568414 File Offset: 0x00566614
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060156FB RID: 87803 RVA: 0x00568416 File Offset: 0x00566616
	public static void ResetStaticDefaultValue()
	{
		RoleModel._Instance = null;
	}

	// Token: 0x060156FC RID: 87804 RVA: 0x0056841E File Offset: 0x0056661E
	static RoleModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleModel.CreateStaticDefaultValue), new Action(RoleModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009FCB RID: 40907
	private readonly Dictionary<int, RoleInstance> RoleInstanceMap = new Dictionary<int, RoleInstance>();

	// Token: 0x04009FCC RID: 40908
	private readonly Dictionary<int, RoleRobotData> RoleRobotDataMap = new Dictionary<int, RoleRobotData>();

	// Token: 0x04009FCD RID: 40909
	private readonly Dictionary<int, RoleRobotData> RoleCommonRobotDataMap = new Dictionary<int, RoleRobotData>();

	// Token: 0x04009FCE RID: 40910
	private readonly Dictionary<int, RoleSpecialRobotData> RoleSpecialRobotDataMap = new Dictionary<int, RoleSpecialRobotData>();

	// Token: 0x04009FCF RID: 40911
	private readonly HashSet<int> MainRoleIdSet = new HashSet<int>();

	// Token: 0x04009FD0 RID: 40912
	private readonly HashSet<int> LightMainRoleIdSet = new HashSet<int>();

	// Token: 0x04009FD1 RID: 40913
	private readonly Dictionary<int, int> MainRoleIdMap = new Dictionary<int, int>();

	// Token: 0x04009FD2 RID: 40914
	private bool IsShowMultiSkillDescInternal;

	// Token: 0x04009FD3 RID: 40915
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, int[]> ResonantItemRoleMapInternal;

	// Token: 0x04009FD4 RID: 40916
	private bool IsInRoleTrialInternal;

	// Token: 0x04009FD5 RID: 40917
	public HashSet<int> RoleTrialIdList = new HashSet<int>();

	// Token: 0x04009FD6 RID: 40918
	public Dictionary<int, bool> RoleTrialShowMap = new Dictionary<int, bool>();

	// Token: 0x04009FD7 RID: 40919
	private bool CanUseSpecialTrialRoleInternal = true;

	// Token: 0x04009FD8 RID: 40920
	private readonly Dictionary<int, int> RoleSkillBranchMap = new Dictionary<int, int>();

	// Token: 0x04009FD9 RID: 40921
	private readonly Dictionary<ESkillBranchCacheType, Dictionary<int, int>> RoleSkillBranchGamePlayCacheMap = new Dictionary<ESkillBranchCacheType, Dictionary<int, int>>();

	// Token: 0x04009FDA RID: 40922
	private ESkillBranchCacheType RoleSkillBranchCacheTypeInternal;

	// Token: 0x04009FDB RID: 40923
	private readonly HashSet<int> RoleSkillBranchChangeRequsetRecord = new HashSet<int>();

	// Token: 0x04009FDC RID: 40924
	private bool IsRecordRoleSkillBranchChangeRequset;

	// Token: 0x04009FDD RID: 40925
	[Nullable(2)]
	private RoleSkillResponseData RoleSkillResponseDataInternal;

	// Token: 0x04009FDE RID: 40926
	private int[] CanChangeRoleIdList = new int[0];

	// Token: 0x04009FDF RID: 40927
	private bool InUltraSkillInternal;

	// Token: 0x04009FE0 RID: 40928
	[Nullable(2)]
	private static RoleModel _Instance;
}
