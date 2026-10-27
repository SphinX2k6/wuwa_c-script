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
using CSharpScript.Game.Ui;

// Token: 0x020028EA RID: 10474
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class TrialRoleModel : ModelBase
{
	// Token: 0x060159F7 RID: 88567 RVA: 0x00574F04 File Offset: 0x00573104
	public void AddTrialRoles(List<ITrialRoleCreateData> dataList)
	{
		foreach (ITrialRoleCreateData data in dataList)
		{
			this.AddTrialRole(data);
		}
	}

	// Token: 0x060159F8 RID: 88568 RVA: 0x00574F54 File Offset: 0x00573154
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

	// Token: 0x060159F9 RID: 88569 RVA: 0x00575018 File Offset: 0x00573218
	public List<TrialRoleGroupData> GetDataListByType(ETrialRoleType trialRoleType)
	{
		List<TrialRoleGroupData> result;
		if (this.TrialRoleTypeMap.TryGetValue(trialRoleType, out result))
		{
			return result;
		}
		return new List<TrialRoleGroupData>();
	}

	// Token: 0x060159FA RID: 88570 RVA: 0x0057503C File Offset: 0x0057323C
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

	// Token: 0x060159FB RID: 88571 RVA: 0x0057505C File Offset: 0x0057325C
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

	// Token: 0x060159FC RID: 88572 RVA: 0x0057507C File Offset: 0x0057327C
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

	// Token: 0x060159FD RID: 88573 RVA: 0x005750EC File Offset: 0x005732EC
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

	// Token: 0x060159FE RID: 88574 RVA: 0x005751B0 File Offset: 0x005733B0
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
		if (((currentFormationData != null) ? currentFormationData.RoleIdList : null).Contains(trialRoleId))
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

	// Token: 0x060159FF RID: 88575 RVA: 0x00575314 File Offset: 0x00573514
	public void SaveTrialRoleUnlockRedDotById(int groupId, bool isUnlock)
	{
		Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.TrialRoleGroupUnlock, null);
		if (dictionary == null)
		{
			dictionary = new Dictionary<int, bool>();
		}
		bool flag;
		if (dictionary.TryGetValue(groupId, out flag) && flag == isUnlock)
		{
			return;
		}
		dictionary[groupId] = isUnlock;
		LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.TrialRoleGroupUnlock, dictionary);
		EventSystem.Instance.Emit(EEventName.OnGroupTrialRoleRedDotUpdate);
	}

	// Token: 0x06015A00 RID: 88576 RVA: 0x0057536C File Offset: 0x0057356C
	public bool GetTrialRoleUnlockRedDotById(int groupId)
	{
		Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.TrialRoleGroupUnlock, null);
		bool flag;
		return player != null && player.TryGetValue(groupId, out flag) && flag;
	}

	// Token: 0x06015A01 RID: 88577 RVA: 0x00575398 File Offset: 0x00573598
	public bool GetUpgradeRedDotById(int groupId)
	{
		TrialRoleGroupData dataByGroupId = this.GetDataByGroupId(groupId);
		return dataByGroupId != null && dataByGroupId.CanUpgrade();
	}

	// Token: 0x06015A02 RID: 88578 RVA: 0x005753B8 File Offset: 0x005735B8
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

	// Token: 0x06015A03 RID: 88579 RVA: 0x0057573C File Offset: 0x0057393C
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

	// Token: 0x17001D0C RID: 7436
	// (get) Token: 0x06015A04 RID: 88580 RVA: 0x00575776 File Offset: 0x00573976
	public static TrialRoleModel Instance
	{
		get
		{
			return TrialRoleModel._Instance;
		}
	}

	// Token: 0x06015A05 RID: 88581 RVA: 0x0057577D File Offset: 0x0057397D
	public static TrialRoleModel GetOrCreateInstance()
	{
		if (TrialRoleModel._Instance == null)
		{
			TrialRoleModel.CreateInstance();
		}
		return TrialRoleModel._Instance;
	}

	// Token: 0x06015A06 RID: 88582 RVA: 0x00575791 File Offset: 0x00573991
	public static bool CreateInstance()
	{
		if (TrialRoleModel._Instance != null)
		{
			return true;
		}
		TrialRoleModel._Instance = new TrialRoleModel();
		return true;
	}

	// Token: 0x06015A07 RID: 88583 RVA: 0x005757A7 File Offset: 0x005739A7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015A08 RID: 88584 RVA: 0x005757A9 File Offset: 0x005739A9
	public static void ResetStaticDefaultValue()
	{
		TrialRoleModel._Instance = null;
	}

	// Token: 0x06015A09 RID: 88585 RVA: 0x005757B1 File Offset: 0x005739B1
	static TrialRoleModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TrialRoleModel.CreateStaticDefaultValue), new Action(TrialRoleModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A0D7 RID: 41175
	private readonly List<TrialRoleGroupData> TrialRoleGroupList = new List<TrialRoleGroupData>();

	// Token: 0x0400A0D8 RID: 41176
	private readonly Dictionary<int, TrialRoleGroupData> TrialRoleGroupMap = new Dictionary<int, TrialRoleGroupData>();

	// Token: 0x0400A0D9 RID: 41177
	private readonly Dictionary<ETrialRoleType, List<TrialRoleGroupData>> TrialRoleTypeMap = new Dictionary<ETrialRoleType, List<TrialRoleGroupData>>();

	// Token: 0x0400A0DA RID: 41178
	private readonly Dictionary<ETrialRoleType, TrialRoleGroupData> CurUseTrailRoleMap = new Dictionary<ETrialRoleType, TrialRoleGroupData>();

	// Token: 0x0400A0DB RID: 41179
	private readonly HashSet<int> TrialRoleLvUpSet = new HashSet<int>();

	// Token: 0x0400A0DC RID: 41180
	private readonly string ForbiddenStatTips = "TrialRoleOperateForbidState";

	// Token: 0x0400A0DD RID: 41181
	[Nullable(2)]
	private static TrialRoleModel _Instance;
}
