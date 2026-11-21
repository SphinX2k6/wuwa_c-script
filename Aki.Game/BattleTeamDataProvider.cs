using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020010A7 RID: 4263
public class BattleTeamDataProvider : IFormationProvider
{
	// Token: 0x0600A8C9 RID: 43209 RVA: 0x0031A2F8 File Offset: 0x003184F8
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

	// Token: 0x0600A8CA RID: 43210 RVA: 0x0031A584 File Offset: 0x00318784
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

	// Token: 0x0600A8CB RID: 43211 RVA: 0x0031A620 File Offset: 0x00318820
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

	// Token: 0x0600A8CC RID: 43212 RVA: 0x0031A71C File Offset: 0x0031891C
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

	// Token: 0x0600A8CD RID: 43213 RVA: 0x0031A7C0 File Offset: 0x003189C0
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

	// Token: 0x0600A8CE RID: 43214 RVA: 0x0031A7F8 File Offset: 0x003189F8
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

	// Token: 0x0600A8CF RID: 43215 RVA: 0x0031A848 File Offset: 0x00318A48
	public bool IsCurrentDungeonDangoAbyss()
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		InstanceDungeon? instanceDungeon = (instance != null) ? instance.Context.GetDungeonConfig() : null;
		return instanceDungeon != null && instanceDungeon.Value.InstSubType == 33;
	}

	// Token: 0x0600A8D0 RID: 43216 RVA: 0x0031A892 File Offset: 0x00318A92
	public bool IsDangoInMatch()
	{
		DangoAbyssModel instance = DangoAbyssModel.Instance;
		return instance != null && instance.CheckIsInMatch();
	}

	// Token: 0x0600A8D1 RID: 43217 RVA: 0x0031A8A4 File Offset: 0x00318AA4
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

	// Token: 0x0400624A RID: 25162
	private const int HEALTH_ID_FOR_TRIAL = 3;
}
