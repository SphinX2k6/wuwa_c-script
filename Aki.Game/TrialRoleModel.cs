using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.Protocol.Summon;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;

// Token: 0x02001E65 RID: 7781
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class TrialRoleModel : ModelBase
{
	// Token: 0x060133FB RID: 78843 RVA: 0x0059FDCC File Offset: 0x0059DFCC
	public void AddTrialRoles(List<ITrialRoleCreateData> dataList)
	{
		foreach (ITrialRoleCreateData data in dataList)
		{
			this.AddTrialRole(data);
		}
	}

	// Token: 0x060133FC RID: 78844 RVA: 0x0059FE1C File Offset: 0x0059E01C
	public void AddTrialRole(ITrialRoleCreateData data)
	{
		int trialRoleId = data.TrialRoleId;
		if (!RoleUtils.IsSpecialTrialRole(trialRoleId))
		{
			return;
		}
		TrialRoleConfig instance = TrialRoleConfig.Instance;
		int? num = (instance != null) ? instance.GetTrialRoleGroupId(trialRoleId) : null;
		if (num == null)
		{
			return;
		}
		if (this.TrialRoleGroupMap.ContainsKey(num.Value))
		{
			return;
		}
		TrialRoleGroupData trialRoleGroupData = new TrialRoleGroupData(trialRoleId);
		trialRoleGroupData.SetIsUnlocked(data.IsUnlocked);
		this.TrialRoleGroupList.Add(trialRoleGroupData);
		this.TrialRoleGroupMap[trialRoleGroupData.TrialRoleGroupId] = trialRoleGroupData;
		ETrialRoleType trialRoleType = trialRoleGroupData.TrialRoleType;
		if (!this.TrialRoleTypeMap.ContainsKey(trialRoleType))
		{
			this.TrialRoleTypeMap[trialRoleType] = new List<TrialRoleGroupData>();
		}
		this.TrialRoleTypeMap[trialRoleType].Add(trialRoleGroupData);
	}

	// Token: 0x060133FD RID: 78845 RVA: 0x0059FEE0 File Offset: 0x0059E0E0
	public List<TrialRoleGroupData> GetDataListByType(ETrialRoleType trialRoleType)
	{
		List<TrialRoleGroupData> result;
		if (this.TrialRoleTypeMap.TryGetValue(trialRoleType, out result))
		{
			return result;
		}
		return new List<TrialRoleGroupData>();
	}

	// Token: 0x060133FE RID: 78846 RVA: 0x0059FF04 File Offset: 0x0059E104
	[NullableContext(2)]
	public TrialRoleGroupData GetDataByGroupId(int groupId)
	{
		TrialRoleGroupData result;
		if (this.TrialRoleGroupMap.TryGetValue(groupId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060133FF RID: 78847 RVA: 0x0059FF24 File Offset: 0x0059E124
	[NullableContext(2)]
	public TrialRoleGroupData GetCurUseTrialRole(ETrialRoleType trialRoleType)
	{
		TrialRoleGroupData result;
		if (this.CurUseTrailRoleMap.TryGetValue(trialRoleType, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06013400 RID: 78848 RVA: 0x0059FF44 File Offset: 0x0059E144
	public void SetCurUseTrialRole(int trialRoleId, roleInfo trialRoleInfo)
	{
		if (!RoleUtils.IsTrialRole(trialRoleId))
		{
			return;
		}
		TrialRoleConfig instance = TrialRoleConfig.Instance;
		int? num = (instance != null) ? instance.GetTrialRoleGroupId(trialRoleId) : null;
		if (num == null)
		{
			return;
		}
		this.SetCurUseTrialRoleByGroupId(num.Value);
		if (trialRoleInfo != null)
		{
			ETrialRoleType trialRoleType = RoleUtils.GetTrialRoleType(trialRoleId);
			TrialRoleGroupData curUseTrialRole = this.GetCurUseTrialRole(trialRoleType);
			if (curUseTrialRole != null)
			{
				curUseTrialRole.SetActivatedRoleAttr(trialRoleInfo.BaseProp, trialRoleInfo.AddProp);
			}
		}
	}

	// Token: 0x06013401 RID: 78849 RVA: 0x0059FFB4 File Offset: 0x0059E1B4
	public void SetCurUseTrialRoleByGroupId(int groupId)
	{
		TrialRoleGroupData trialRoleGroupData;
		if (!this.TrialRoleGroupMap.TryGetValue(groupId, out trialRoleGroupData))
		{
			return;
		}
		ETrialRoleType trialRoleType = trialRoleGroupData.TrialRoleType;
		TrialRoleGroupData trialRoleGroupData2 = null;
		TrialRoleGroupData trialRoleGroupData3;
		if (this.CurUseTrailRoleMap.TryGetValue(trialRoleType, out trialRoleGroupData3))
		{
			trialRoleGroupData2 = trialRoleGroupData3;
		}
		if (trialRoleGroupData2 != null)
		{
			RoleSpecialRobotData trialRoleData = trialRoleGroupData2.TrialRoleData;
			if (trialRoleData != null)
			{
				trialRoleData.SetIsVisibleInFormation(false);
			}
		}
		if (trialRoleGroupData2 != null)
		{
			RoleSpecialRobotData trialRoleData2 = trialRoleGroupData2.TrialRoleData;
			if (trialRoleData2 != null)
			{
				trialRoleData2.SetIsVisibleInRoleSystem(false);
			}
		}
		this.CurUseTrailRoleMap[trialRoleType] = trialRoleGroupData;
		RoleSpecialRobotData trialRoleData3 = trialRoleGroupData.TrialRoleData;
		if (trialRoleData3 != null)
		{
			trialRoleData3.SetIsVisibleInFormation(true);
		}
		RoleSpecialRobotData trialRoleData4 = trialRoleGroupData.TrialRoleData;
		if (trialRoleData4 != null)
		{
			trialRoleData4.SetIsVisibleInRoleSystem(true);
		}
		EventSystem.Instance.Emit<int?, int>(EEventName.OnCurTrialRoleGroupChanged, (trialRoleGroupData2 != null) ? new int?(trialRoleGroupData2.TrialRoleGroupId) : null, trialRoleGroupData.TrialRoleGroupId);
	}

	// Token: 0x06013402 RID: 78850 RVA: 0x005A0078 File Offset: 0x0059E278
	[NullableContext(2)]
	public void SetGroupTrialRoleId(int trialRoleId, roleInfo trialRoleInfo)
	{
		TrialRoleConfig instance = TrialRoleConfig.Instance;
		int? num = (instance != null) ? instance.GetTrialRoleGroupId(trialRoleId) : null;
		if (num == null)
		{
			return;
		}
		TrialRoleGroupData trialRoleGroupData;
		if (!this.TrialRoleGroupMap.TryGetValue(num.Value, out trialRoleGroupData))
		{
			return;
		}
		if (trialRoleGroupData.IsLocked())
		{
			this.SaveTrialRoleUnlockRedDotById(trialRoleGroupData.TrialRoleGroupId, true);
		}
		int trialRoleId2 = trialRoleGroupData.TrialRoleId;
		trialRoleGroupData.SetActivatedTrialRoleId(trialRoleId);
		trialRoleGroupData.SetIsUnlocked(true);
		bool flag = this.GetCurUseTrialRole(trialRoleGroupData.TrialRoleType) == trialRoleGroupData;
		trialRoleGroupData.SetIsVisibleInFormation(flag);
		trialRoleGroupData.SetIsVisibleInRoleSystem(flag);
		if (trialRoleInfo != null)
		{
			trialRoleGroupData.SetActivatedRoleAttr(trialRoleInfo.BaseProp, trialRoleInfo.AddProp);
		}
		FormationData currentFormationData = FormationModel.Instance.CurrentFormationData;
		List<int> list = (currentFormationData != null) ? currentFormationData.RoleIdList : null;
		if (list != null && list.Contains(trialRoleId))
		{
			TrialRoleConfig instance2 = TrialRoleConfig.Instance;
			TrialRoleInfo? trialRoleInfo2 = (instance2 != null) ? instance2.GetTrialRoleConfig(trialRoleId2) : null;
			TrialRoleConfig instance3 = TrialRoleConfig.Instance;
			TrialRoleInfo? trialRoleInfo3 = (instance3 != null) ? instance3.GetTrialRoleConfig(trialRoleId) : null;
			if (trialRoleInfo2 != null && trialRoleInfo3 != null && trialRoleInfo3.Value.Level > trialRoleInfo2.Value.Level)
			{
				this.TrialRoleLvUpSet.Add(num.Value);
			}
		}
		EventSystem.Instance.Emit<int, int, int>(EEventName.OnGroupTrialRoleChanged, trialRoleId2, trialRoleId, trialRoleGroupData.TrialRoleGroupId);
	}

	// Token: 0x06013403 RID: 78851 RVA: 0x005A01E0 File Offset: 0x0059E3E0
	public void SaveTrialRoleUnlockRedDotById(int groupId, bool isUnlock)
	{
		ServerStorageUtil.OverrideLocalBoolMapToServerSet(ELocalStoragePlayerKey.TrialRoleGroupUnlock, EClientStorageSystemIdType.TrialRoleGroupUnlock, true);
		ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TrialRoleGroupUnlock) as ServerStorageSet;
		if (isUnlock == serverStorageSet.Has(groupId))
		{
			return;
		}
		if (isUnlock)
		{
			serverStorageSet.Add(groupId);
		}
		else
		{
			serverStorageSet.Remove(groupId);
		}
		EventSystem.Instance.Emit(EEventName.OnGroupTrialRoleRedDotUpdate);
	}

	// Token: 0x06013404 RID: 78852 RVA: 0x005A023B File Offset: 0x0059E43B
	public bool GetTrialRoleUnlockRedDotById(int groupId)
	{
		ServerStorageUtil.OverrideLocalBoolMapToServerSet(ELocalStoragePlayerKey.TrialRoleGroupUnlock, EClientStorageSystemIdType.TrialRoleGroupUnlock, true);
		return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.TrialRoleGroupUnlock) as ServerStorageSet).Has(groupId);
	}

	// Token: 0x06013405 RID: 78853 RVA: 0x005A0264 File Offset: 0x0059E464
	public bool GetUpgradeRedDotById(int groupId)
	{
		TrialRoleGroupData dataByGroupId = this.GetDataByGroupId(groupId);
		return dataByGroupId != null && dataByGroupId.CanUpgrade();
	}

	// Token: 0x06013406 RID: 78854 RVA: 0x005A0284 File Offset: 0x0059E484
	public bool CheckCanOperateTrialRole()
	{
		ScrollingTipsController instance = ScrollingTipsController.Instance;
		if (!FunctionModel.Instance.IsOpen(10007))
		{
			return false;
		}
		if (FunctionModel.Instance.IsLockByBehaviorTree(10007))
		{
			instance.ShowTipsById(this.ForbiddenStatTips, Array.Empty<object>());
			return false;
		}
		if (!RoleModel.Instance.CanUseSpecialTrialRole(null))
		{
			instance.ShowTipsById(this.ForbiddenStatTips, Array.Empty<object>());
			return false;
		}
		if (InstanceDungeonEntranceController.Instance.CheckInstanceShieldView(EUiViewName.Formation2DView))
		{
			instance.ShowTipsById(this.ForbiddenStatTips, Array.Empty<object>());
			return false;
		}
		SceneTeamModel instance2 = SceneTeamModel.Instance;
		if (instance2.IsPhantomTeam)
		{
			instance.ShowTipsById("PhantomFormationEnterFormationTip", Array.Empty<object>());
			return false;
		}
		EntityHandle getCurrentEntity = instance2.GetCurrentEntity;
		if (getCurrentEntity == null || !getCurrentEntity.Valid)
		{
			return false;
		}
		int playerId = CreatureModel.Instance.GetPlayerId();
		if (instance2.GetCurrentGroupLivingState(playerId) == ETeamLivingState.Dead)
		{
			return false;
		}
		WorldEntity entity = getCurrentEntity.Entity;
		BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		if (baseTagComponent == null || !baseTagComponent.Valid)
		{
			return false;
		}
		WorldEntity entity2 = getCurrentEntity.Entity;
		CharacterBuffComponent characterBuffComponent = (entity2 != null) ? entity2.GetComponent<CharacterBuffComponent>() : null;
		if (characterBuffComponent == null || !characterBuffComponent.Valid)
		{
			return false;
		}
		WorldEntity entity3 = getCurrentEntity.Entity;
		RoleDriveVehicleComponent roleDriveVehicleComponent = (entity3 != null) ? entity3.GetComponent<RoleDriveVehicleComponent>() : null;
		if (roleDriveVehicleComponent != null && roleDriveVehicleComponent.IsOnVehicle)
		{
			instance.ShowTipsById(this.ForbiddenStatTips, Array.Empty<object>());
			return false;
		}
		if (RoleController.Instance.IsInRoleTrial())
		{
			instance.ShowTipsById(this.ForbiddenStatTips, Array.Empty<object>());
			GenericPromptController.Instance.ShowPromptByCode("TrialRoleTeamLimit", Array.Empty<object>());
			return false;
		}
		if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.水中"]))
		{
			instance.ShowTipsById(this.ForbiddenStatTips, Array.Empty<object>());
			return false;
		}
		if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.溺水"]))
		{
			instance.ShowTipsById(this.ForbiddenStatTips, Array.Empty<object>());
			return false;
		}
		if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]))
		{
			instance.ShowTipsById(this.ForbiddenStatTips, Array.Empty<object>());
			return false;
		}
		if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]))
		{
			instance.ShowTipsById("ForbiddenActionInFight", Array.Empty<object>());
			return false;
		}
		if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.攀爬"]))
		{
			instance.ShowTipsById(this.ForbiddenStatTips, Array.Empty<object>());
			return false;
		}
		if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"]))
		{
			instance.ShowTipsById(this.ForbiddenStatTips, Array.Empty<object>());
			return false;
		}
		if (baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.幻象变身中"]))
		{
			EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(getCurrentEntity.Entity, ESummonType.ConcomitantVision, 1);
			if (summonedEntity != null)
			{
				WorldEntity entity4 = summonedEntity.Entity;
				bool flag;
				if (entity4 == null)
				{
					flag = false;
				}
				else
				{
					BaseTagComponent component = entity4.GetComponent<BaseTagComponent>();
					flag = ((component != null) ? new bool?(component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"])) : null).GetValueOrDefault();
				}
				if (flag)
				{
					instance.ShowTipsById(this.ForbiddenStatTips, Array.Empty<object>());
					return false;
				}
			}
		}
		if (characterBuffComponent.GetBuffTotalStackById(90003001L, false) > 0)
		{
			instance.ShowTipsById(this.ForbiddenStatTips, Array.Empty<object>());
			return false;
		}
		WorldEntity entity5 = getCurrentEntity.Entity;
		CharacterWalkOnWaterComponent characterWalkOnWaterComponent = (entity5 != null) ? entity5.GetComponent<CharacterWalkOnWaterComponent>() : null;
		if (characterWalkOnWaterComponent != null && characterWalkOnWaterComponent.WalkOnWaterStage > EWalkOnWaterStage.None)
		{
			instance.ShowTipsById(this.ForbiddenStatTips, Array.Empty<object>());
			return false;
		}
		return instance2.CurrentGroupType.GetValueOrDefault() == ETeamGroupType.Battle;
	}

	// Token: 0x06013407 RID: 78855 RVA: 0x005A0608 File Offset: 0x0059E808
	public void SetTrialRoleVisibility(int roleId, bool isVisible)
	{
		if (!RoleUtils.IsSpecialTrialRole(roleId))
		{
			return;
		}
		RoleSpecialRobotData roleSpecialRobotData = RoleModel.Instance.GetRoleDataById(roleId, true) as RoleSpecialRobotData;
		if (roleSpecialRobotData == null)
		{
			return;
		}
		roleSpecialRobotData.SetIsVisibleInFormation(isVisible);
		roleSpecialRobotData.SetIsVisibleInRoleSystem(isVisible);
	}

	// Token: 0x17001D66 RID: 7526
	// (get) Token: 0x06013408 RID: 78856 RVA: 0x005A0642 File Offset: 0x0059E842
	public static TrialRoleModel Instance
	{
		get
		{
			return TrialRoleModel._Instance;
		}
	}

	// Token: 0x06013409 RID: 78857 RVA: 0x005A0649 File Offset: 0x0059E849
	public static TrialRoleModel GetOrCreateInstance()
	{
		if (TrialRoleModel._Instance == null)
		{
			TrialRoleModel.CreateInstance();
		}
		return TrialRoleModel._Instance;
	}

	// Token: 0x0601340A RID: 78858 RVA: 0x005A065D File Offset: 0x0059E85D
	public static bool CreateInstance()
	{
		if (TrialRoleModel._Instance != null)
		{
			return true;
		}
		TrialRoleModel._Instance = new TrialRoleModel();
		return true;
	}

	// Token: 0x0601340B RID: 78859 RVA: 0x005A0673 File Offset: 0x0059E873
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601340C RID: 78860 RVA: 0x005A0675 File Offset: 0x0059E875
	public static void ResetStaticDefaultValue()
	{
		TrialRoleModel._Instance = null;
	}

	// Token: 0x0601340D RID: 78861 RVA: 0x005A067D File Offset: 0x0059E87D
	static TrialRoleModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TrialRoleModel.CreateStaticDefaultValue), new Action(TrialRoleModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A4C1 RID: 42177
	private readonly List<TrialRoleGroupData> TrialRoleGroupList = new List<TrialRoleGroupData>();

	// Token: 0x0400A4C2 RID: 42178
	private readonly Dictionary<int, TrialRoleGroupData> TrialRoleGroupMap = new Dictionary<int, TrialRoleGroupData>();

	// Token: 0x0400A4C3 RID: 42179
	private readonly Dictionary<ETrialRoleType, List<TrialRoleGroupData>> TrialRoleTypeMap = new Dictionary<ETrialRoleType, List<TrialRoleGroupData>>();

	// Token: 0x0400A4C4 RID: 42180
	private readonly Dictionary<ETrialRoleType, TrialRoleGroupData> CurUseTrailRoleMap = new Dictionary<ETrialRoleType, TrialRoleGroupData>();

	// Token: 0x0400A4C5 RID: 42181
	private readonly HashSet<int> TrialRoleLvUpSet = new HashSet<int>();

	// Token: 0x0400A4C6 RID: 42182
	private readonly string ForbiddenStatTips = "TrialRoleOperateForbidState";

	// Token: 0x0400A4C7 RID: 42183
	[Nullable(2)]
	private static TrialRoleModel _Instance;
}
