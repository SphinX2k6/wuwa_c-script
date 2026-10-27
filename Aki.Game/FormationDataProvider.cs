using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.Define;

// Token: 0x02001BF4 RID: 7156
public class FormationDataProvider : IFormationProvider
{
	// Token: 0x0600D53E RID: 54590 RVA: 0x00311980 File Offset: 0x0030FB80
	[NullableContext(1)]
	public unsafe IRoleSlotDisplayData BuildSlotDisplayData(int formationId, int position)
	{
		FormationModel instance = FormationModel.Instance;
		if (instance == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Formation;
			ELogAuthor author = ELogAuthor.SYB;
			string message = "FormationDataProvider.BuildSlotDisplayData: FormationModel 未就绪";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("formationId", formationId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("position", position);
			instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return this.BuildEmptySlotDto();
		}
		GameModeModel instance3 = GameModeModel.Instance;
		bool flag = instance3 != null && instance3.IsMulti;
		CreatureModel instance4 = CreatureModel.Instance;
		int num = (instance4 != null) ? instance4.GetPlayerId() : 0;
		if (!instance.IsMyPosition(position))
		{
			return this.BuildTeammateSlotDto(formationId, position, num);
		}
		int editingRoleId = instance.GetEditingRoleId(formationId, position);
		if (editingRoleId <= 0)
		{
			return this.BuildEmptySlotDto();
		}
		RoleModel instance5 = RoleModel.Instance;
		RoleDataBase roleDataBase = (instance5 != null) ? instance5.GetRoleDataById(editingRoleId, true) : null;
		if (roleDataBase == null)
		{
			return this.BuildEmptySlotDto();
		}
		RoleModel instance6 = RoleModel.Instance;
		RoleLevelData levelData = roleDataBase.GetLevelData();
		int roleSkinId = roleDataBase.GetRoleSkinId();
		int level = levelData.GetLevel();
		PlayerInfoModel instance7 = PlayerInfoModel.Instance;
		string thirdPartyOnlineId = ((instance7 != null) ? instance7.GetThirdPartyOnlineId() : null) ?? "";
		int onlineIndex = 0;
		string name;
		if (flag)
		{
			FunctionModel instance8 = FunctionModel.Instance;
			name = (((instance8 != null) ? instance8.GetPlayerName() : null) ?? "");
			OnlineModel instance9 = OnlineModel.Instance;
			int? num2;
			if (instance9 == null)
			{
				num2 = null;
			}
			else
			{
				OnlineTeamData currentTeamListById = instance9.GetCurrentTeamListById(num);
				num2 = ((currentTeamListById != null) ? new int?(currentTeamListById.PlayerNumber) : null);
			}
			int? num3 = num2;
			onlineIndex = num3.GetValueOrDefault(1);
		}
		else
		{
			name = instance6.GetRoleName(editingRoleId, null);
		}
		bool flag2 = roleDataBase.IsTrialRole();
		bool isDead = false;
		if (!flag2 && !TowerModel.Instance.IsOpenFloorFormation() && !LordGymController.Instance.IsInLordGymDungeon())
		{
			isDead = instance.IsRoleDead(editingRoleId);
		}
		IRoleSlotDisplayData roleSlotDisplayData = new IRoleSlotDisplayData();
		roleSlotDisplayData.ConfigId = editingRoleId;
		roleSlotDisplayData.SkinId = roleSkinId;
		roleSlotDisplayData.Level = level;
		roleSlotDisplayData.Name = name;
		roleSlotDisplayData.OnlineIndex = onlineIndex;
		roleSlotDisplayData.PlayerId = num;
		roleSlotDisplayData.ThirdPartyOnlineId = thirdPartyOnlineId;
		RoleModel instance10 = RoleModel.Instance;
		roleSlotDisplayData.CanUseSpecialTrialRole = (instance10 == null || instance10.CanUseSpecialTrialRole(null));
		roleSlotDisplayData.IsDead = isDead;
		roleSlotDisplayData.IsTrialRole = flag2;
		roleSlotDisplayData.IsSelf = true;
		roleSlotDisplayData.IsMultiContext = flag;
		roleSlotDisplayData.IsThirdPartyVisible = (KuroSdkController.Instance.NeedShowThirdPartyId() && flag);
		roleSlotDisplayData.SkillBranch = this.BuildSkillBranchDto(editingRoleId, position, num);
		return roleSlotDisplayData;
	}

	// Token: 0x0600D53F RID: 54591 RVA: 0x00311BF0 File Offset: 0x0030FDF0
	[NullableContext(1)]
	private IRoleSlotDisplayData BuildTeammateSlotDto(int formationId, int position, int selfPlayerId)
	{
		FormationData formationData = FormationModel.Instance.GetFormationData(formationId);
		FormationRoleData formationRoleData = (formationData != null) ? formationData.GetRoleDataByPosition(position) : null;
		if (formationRoleData == null)
		{
			return this.BuildEmptySlotDto();
		}
		int playerId = formationRoleData.PlayerId;
		bool flag = GameModeController.Instance.IsInInstance();
		CreatureModel instance = CreatureModel.Instance;
		ScenePlayerData scenePlayerData = (instance != null) ? instance.GetScenePlayerData(playerId) : null;
		if (flag && scenePlayerData == null)
		{
			return this.BuildEmptySlotDto();
		}
		OnlineModel instance2 = OnlineModel.Instance;
		WorldTeamPlayerFightInfo worldTeamPlayerFightInfo = (instance2 != null) ? instance2.GetWorldTeamPlayerFightInfo(playerId) : null;
		OnlineModel instance3 = OnlineModel.Instance;
		OnlineTeamData onlineTeamData = (instance3 != null) ? instance3.GetCurrentTeamListById(playerId) : null;
		int onlineIndex = (onlineTeamData != null) ? onlineTeamData.PlayerNumber : 1;
		string text = ((worldTeamPlayerFightInfo != null) ? worldTeamPlayerFightInfo.Name : null) ?? "";
		if (text != "")
		{
			text = (((onlineTeamData != null) ? onlineTeamData.GetRawName() : null) ?? text);
		}
		GameModeModel instance4 = GameModeModel.Instance;
		bool flag2 = instance4 != null && instance4.IsMulti;
		return new IRoleSlotDisplayData
		{
			ConfigId = formationRoleData.ConfigId,
			SkinId = formationRoleData.RoleSkinId,
			Level = formationRoleData.Level,
			Name = text,
			OnlineIndex = onlineIndex,
			PlayerId = playerId,
			ThirdPartyOnlineId = (((worldTeamPlayerFightInfo != null) ? worldTeamPlayerFightInfo.ThirdPartyOnlineName : null) ?? ""),
			CanUseSpecialTrialRole = false,
			IsDead = false,
			IsTrialRole = false,
			IsSelf = (playerId == selfPlayerId),
			IsMultiContext = flag2,
			IsThirdPartyVisible = (KuroSdkController.Instance.NeedShowThirdPartyId() && flag2),
			SkillBranch = this.BuildSkillBranchDto(formationRoleData.ConfigId, position, playerId),
			Equip = formationRoleData.Equip
		};
	}

	// Token: 0x0600D540 RID: 54592 RVA: 0x00311D8C File Offset: 0x0030FF8C
	[NullableContext(1)]
	private IRoleSlotDisplayData BuildEmptySlotDto()
	{
		return new IRoleSlotDisplayData
		{
			ConfigId = 0,
			SkinId = 0,
			Level = 0,
			Name = "",
			OnlineIndex = 0,
			PlayerId = 0,
			ThirdPartyOnlineId = "",
			CanUseSpecialTrialRole = true,
			IsDead = false,
			IsTrialRole = false,
			IsSelf = true,
			IsMultiContext = false,
			IsThirdPartyVisible = false
		};
	}

	// Token: 0x0600D541 RID: 54593 RVA: 0x00311E04 File Offset: 0x00310004
	[NullableContext(2)]
	private IRoleSlotDisplayData.SkillBranchData BuildSkillBranchDto(int configId, int position, int playerId)
	{
		RoleModel instance = RoleModel.Instance;
		if (!instance.IsRoleHasBranch(configId))
		{
			return null;
		}
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
			IsHiddenByInstSubType = false,
			ActiveBranchIndex = activeBranchIndex
		};
	}

	// Token: 0x0600D542 RID: 54594 RVA: 0x00311E94 File Offset: 0x00310094
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

	// Token: 0x0600D543 RID: 54595 RVA: 0x00311F38 File Offset: 0x00310138
	[NullableContext(2)]
	public Vector GetRoleSkinOffset(int skinId)
	{
		RoleSkinModel instance = RoleSkinModel.Instance;
		RoleSkinData roleSkinData = (instance != null) ? instance.GetRoleSkinData(skinId) : null;
		if (roleSkinData == null)
		{
			return null;
		}
		return Vector.Create(roleSkinData.GetRoleSkinConfig().FormationOffset);
	}

	// Token: 0x0600D544 RID: 54596 RVA: 0x00311F70 File Offset: 0x00310170
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

	// Token: 0x0600D545 RID: 54597 RVA: 0x00311FBD File Offset: 0x003101BD
	public bool IsCurrentDungeonDangoAbyss()
	{
		return false;
	}

	// Token: 0x0600D546 RID: 54598 RVA: 0x00311FC0 File Offset: 0x003101C0
	public bool IsDangoInMatch()
	{
		return false;
	}

	// Token: 0x0600D547 RID: 54599 RVA: 0x00311FC4 File Offset: 0x003101C4
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

	// Token: 0x040061B0 RID: 25008
	private const int HEALTH_ID_FOR_TRIAL = 3;
}
