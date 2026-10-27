using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001BE8 RID: 7144
public class BattleTeamDataProvider : IFormationProvider
{
	// Token: 0x0600D4B7 RID: 54455 RVA: 0x0030F184 File Offset: 0x0030D384
	[NullableContext(1)]
	public IRoleSlotDisplayData BuildSlotDisplayData(int position)
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		BattleRoleSlotData slot = instance.GetSlot(position);
		BattleRoleData battleRoleData = (slot != null) ? slot.RoleData : null;
		if (battleRoleData == null)
		{
			return this.BuildEmptySlotDto();
		}
		bool isMultiInstanceDungeon = instance.Context.IsMultiInstanceDungeon;
		CreatureModel instance2 = CreatureModel.Instance;
		int num = (instance2 != null) ? instance2.GetPlayerId() : 0;
		int playerId = battleRoleData.PlayerId;
		bool flag = playerId == num || playerId == 0;
		string name;
		int onlineIndex;
		if (isMultiInstanceDungeon)
		{
			name = battleRoleData.Name;
			onlineIndex = battleRoleData.OnlineIndex.GetValueOrDefault(1);
		}
		else
		{
			name = RoleModel.Instance.GetRoleName(battleRoleData.ConfigId, null);
			onlineIndex = 0;
		}
		bool flag2 = RoleUtils.IsTrialRole(battleRoleData.ConfigId);
		bool isDead = false;
		if (flag && !flag2 && !TowerModel.Instance.IsOpenFloorFormation() && !LordGymController.Instance.IsInLordGymDungeon())
		{
			FormationModel instance3 = FormationModel.Instance;
			isDead = (instance3 != null && instance3.IsRoleDead(battleRoleData.ConfigId));
		}
		IRoleSlotDisplayData.PrepareData prepare = null;
		if (isMultiInstanceDungeon)
		{
			bool isRoleConflict = instance.IsRoleConflict(playerId, battleRoleData.ConfigId);
			bool flag3;
			if (!TowerDefenseController.Instance.CheckInUiFlow())
			{
				DangoAbyssModel instance4 = DangoAbyssModel.Instance;
				if (instance4 == null || !instance4.CheckInAbyssEditFormationState())
				{
					MultiMotorModel instance5 = MultiMotorModel.Instance;
					flag3 = (instance5 != null && instance5.CheckInMultiMotorEditFormationState());
					goto IL_132;
				}
			}
			flag3 = true;
			IL_132:
			bool shouldSuppressByGameplay = flag3;
			InstanceDungeonModel instance6 = InstanceDungeonModel.Instance;
			MatchTeamInfo matchTeamInfo = instance6.GetMatchTeamInfo();
			int? num2 = (matchTeamInfo != null) ? new int?(matchTeamInfo.HostId) : null;
			prepare = new IRoleSlotDisplayData.PrepareData
			{
				IsRoleConflict = isRoleConflict,
				ShouldSuppressByGameplay = shouldSuppressByGameplay,
				PlayerUiState = ((matchTeamInfo != null) ? new EMatchPlayerUiState?(instance6.GetPlayerUiState(playerId)) : null),
				IsHost = (num2 != null && playerId == num2.Value)
			};
		}
		return new IRoleSlotDisplayData
		{
			ConfigId = battleRoleData.ConfigId,
			SkinId = battleRoleData.SkinId,
			Level = battleRoleData.Level,
			Name = name,
			OnlineIndex = onlineIndex,
			PlayerId = playerId,
			ThirdPartyOnlineId = (battleRoleData.ThirdPartyOnlineId ?? ""),
			CanUseSpecialTrialRole = instance.CanUseSpecialTrialRole,
			IsDead = isDead,
			IsTrialRole = flag2,
			IsSelf = flag,
			IsMultiContext = isMultiInstanceDungeon,
			IsThirdPartyVisible = (KuroSdkController.Instance.NeedShowThirdPartyId() && (isMultiInstanceDungeon || GameModeModel.Instance.IsMulti)),
			SkillBranch = this.BuildSkillBranchDto(battleRoleData.ConfigId, position, playerId),
			Prepare = prepare
		};
	}

	// Token: 0x0600D4B8 RID: 54456 RVA: 0x0030F410 File Offset: 0x0030D610
	[NullableContext(1)]
	private IRoleSlotDisplayData BuildEmptySlotDto()
	{
		IRoleSlotDisplayData roleSlotDisplayData = new IRoleSlotDisplayData();
		roleSlotDisplayData.ConfigId = 0;
		roleSlotDisplayData.SkinId = 0;
		roleSlotDisplayData.Level = 0;
		roleSlotDisplayData.Name = "";
		roleSlotDisplayData.OnlineIndex = 0;
		roleSlotDisplayData.PlayerId = 0;
		roleSlotDisplayData.ThirdPartyOnlineId = "";
		BattleTeamModel instance = BattleTeamModel.Instance;
		roleSlotDisplayData.CanUseSpecialTrialRole = (instance == null || instance.CanUseSpecialTrialRole);
		roleSlotDisplayData.IsDead = false;
		roleSlotDisplayData.IsTrialRole = false;
		roleSlotDisplayData.IsSelf = true;
		BattleTeamModel instance2 = BattleTeamModel.Instance;
		roleSlotDisplayData.IsMultiContext = (instance2 != null && instance2.Context.IsMultiInstanceDungeon);
		roleSlotDisplayData.IsThirdPartyVisible = false;
		return roleSlotDisplayData;
	}

	// Token: 0x0600D4B9 RID: 54457 RVA: 0x0030F4AC File Offset: 0x0030D6AC
	[NullableContext(2)]
	private IRoleSlotDisplayData.SkillBranchData BuildSkillBranchDto(int configId, int position, int playerId)
	{
		RoleModel instance = RoleModel.Instance;
		if (!instance.IsRoleHasBranch(configId))
		{
			return null;
		}
		BattleTeamModel instance2 = BattleTeamModel.Instance;
		InstanceDungeon? instanceDungeon;
		int? num = (instance2 != null) ? ((instance2.Context.GetDungeonConfig() != null) ? new int?(instanceDungeon.GetValueOrDefault().InstSubType) : null) : null;
		bool isHiddenByInstSubType = num != null && instance.IsInHideSkillBranchInstSubTypeList(num.Value);
		int? id = PlayerInfoModel.Instance.GetId();
		bool flag = playerId == id.GetValueOrDefault() & id != null;
		ValueTuple<bool, int> valueTuple = this.ResolveSkillBranchMultiInfo(configId, position, playerId);
		bool item = valueTuple.Item1;
		int item2 = valueTuple.Item2;
		int activeBranchIndex = (item && !flag) ? instance.GetRoleBranchIndexById(configId, item2) : instance.GetRoleSkillBranchIndexInCurrentGamePlay(configId);
		return new IRoleSlotDisplayData.SkillBranchData
		{
			IsMulti = item,
			IsSelf = flag,
			IsHiddenByInstSubType = isHiddenByInstSubType,
			ActiveBranchIndex = activeBranchIndex
		};
	}

	// Token: 0x0600D4BA RID: 54458 RVA: 0x0030F5A8 File Offset: 0x0030D7A8
	[return: TupleElementNames(new string[]
	{
		"IsMulti",
		"MultiSkillBranchId"
	})]
	private ValueTuple<bool, int> ResolveSkillBranchMultiInfo(int configId, int position, int playerId)
	{
		InstanceDungeonModel instance = InstanceDungeonModel.Instance;
		if (instance.GetMatchTeamInfo() != null)
		{
			PrewarFormationData prewarFormationData = null;
			foreach (PrewarFormationData prewarFormationData2 in instance.GetPrewarFormationDataList())
			{
				if (prewarFormationData2.GetPlayerId() == playerId && prewarFormationData2.GetConfigId() == configId)
				{
					prewarFormationData = prewarFormationData2;
					break;
				}
			}
			return new ValueTuple<bool, int>(true, (prewarFormationData != null) ? prewarFormationData.GetMultiSkillBranchId() : 0);
		}
		if (GameModeModel.Instance.IsMulti)
		{
			return new ValueTuple<bool, int>(true, FormationModel.Instance.GetCurrentFormationSkillBranchId(position));
		}
		return new ValueTuple<bool, int>(false, 0);
	}

	// Token: 0x0600D4BB RID: 54459 RVA: 0x0030F64C File Offset: 0x0030D84C
	[NullableContext(2)]
	public global::Vector GetRoleSkinOffset(int skinId)
	{
		RoleSkinModel instance = RoleSkinModel.Instance;
		RoleSkinData roleSkinData = (instance != null) ? instance.GetRoleSkinData(skinId) : null;
		if (roleSkinData == null)
		{
			return null;
		}
		return global::Vector.Create(roleSkinData.GetRoleSkinConfig().FormationOffset);
	}

	// Token: 0x0600D4BC RID: 54460 RVA: 0x0030F684 File Offset: 0x0030D884
	public int ResolveSafePlayerId(int? slotPlayerId)
	{
		int value = PlayerInfoModel.Instance.GetId().Value;
		if (slotPlayerId != null)
		{
			int? num = slotPlayerId;
			int num2 = 0;
			if (!(num.GetValueOrDefault() <= num2 & num != null))
			{
				return slotPlayerId.Value;
			}
		}
		return value;
	}

	// Token: 0x0600D4BD RID: 54461 RVA: 0x0030F6D4 File Offset: 0x0030D8D4
	public bool IsCurrentDungeonDangoAbyss()
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		InstanceDungeon? instanceDungeon = (instance != null) ? instance.Context.GetDungeonConfig() : null;
		return instanceDungeon != null && instanceDungeon.Value.InstSubType == 33;
	}

	// Token: 0x0600D4BE RID: 54462 RVA: 0x0030F71E File Offset: 0x0030D91E
	public bool IsDangoInMatch()
	{
		DangoAbyssModel instance = DangoAbyssModel.Instance;
		return instance != null && instance.CheckIsInMatch();
	}

	// Token: 0x0600D4BF RID: 54463 RVA: 0x0030F730 File Offset: 0x0030D930
	public bool ResolveSpecialTrialDeadState(int roleId)
	{
		SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)roleId, new GetTeamItemOptions
		{
			ParamType = ETeamParamType.ConfigId,
			OnlyMyRole = new bool?(true)
		});
		if (teamItem != null && teamItem.EntityHandle != null && teamItem.EntityHandle.Entity != null)
		{
			return FormationModel.Instance.IsRoleDead(roleId);
		}
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		RoleAttributeData roleAttributeData = (roleDataById != null) ? roleDataById.GetAttributeData() : null;
		return ((roleAttributeData != null) ? roleAttributeData.GetAttrValueById(3) : 0) <= 0;
	}

	// Token: 0x0400617B RID: 24955
	private const int HEALTH_ID_FOR_TRIAL = 3;
}
