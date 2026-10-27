using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.Define;

// Token: 0x02001BEC RID: 7148
[NullableContext(1)]
[Nullable(0)]
public class BattleTeamSlotInitializer
{
	// Token: 0x0600D50C RID: 54540 RVA: 0x00310D09 File Offset: 0x0030EF09
	public BattleTeamSlotInitializer(BattleTeamModel model)
	{
		this.Model = model;
	}

	// Token: 0x0600D50D RID: 54541 RVA: 0x00310D18 File Offset: 0x0030EF18
	public void InitAll()
	{
		if (this.Model.Context.IsMultiInstanceDungeon)
		{
			InstanceDungeonModel.Instance.SetPrewarFormationDataList();
			this.InitFromMulti(InstanceDungeonModel.Instance.GetPrewarFormationDataList());
			return;
		}
		this.InitFromSingle();
	}

	// Token: 0x0600D50E RID: 54542 RVA: 0x00310D50 File Offset: 0x0030EF50
	public void InitFromMulti(IReadOnlyList<PrewarFormationData> prewarFormations)
	{
		this.Model.ResetAllSlots();
		foreach (PrewarFormationData prewarFormationData in prewarFormations)
		{
			BattleRoleSlotData slot = this.Model.GetSlot(prewarFormationData.GetIndex());
			if (slot != null)
			{
				if (prewarFormationData.IsEmpty())
				{
					if (prewarFormationData.IsLeader())
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Formation;
						ELogAuthor author = ELogAuthor.SYB;
						string message = "[Formation] 联机空位";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("position", prewarFormationData.GetIndex());
						instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
				}
				else
				{
					slot.SetRoleData(this.CreateRoleDataFromPrewar(prewarFormationData));
					if (prewarFormationData.IsLeader())
					{
						this.Model.SetLeaderPlayerId(new int?(prewarFormationData.GetPlayerId()));
					}
				}
			}
		}
		if (this.Model.LeaderPlayerId == null)
		{
			this.Model.SetLeaderPlayerId(PlayerInfoModel.Instance.GetId());
		}
	}

	// Token: 0x0600D50F RID: 54543 RVA: 0x00310E50 File Offset: 0x0030F050
	public void RefreshFromMulti(IReadOnlyList<PrewarFormationData> prewarFormations)
	{
		for (int i = 0; i < 3; i++)
		{
			BattleRoleSlotData slot = this.Model.GetSlot(i + 1);
			if (i + 1 > prewarFormations.Count)
			{
				slot.ResetRoleData();
			}
			else
			{
				slot.SetRoleDataByPrewarInfo(prewarFormations[i]);
			}
		}
	}

	// Token: 0x0600D510 RID: 54544 RVA: 0x00310E98 File Offset: 0x0030F098
	private void InitFromSingle()
	{
		this.Model.ResetAllSlots();
		int? id = PlayerInfoModel.Instance.GetId();
		this.Model.SetLeaderPlayerId(id);
		this.Model.InitTrailRoleInstance();
		if (this.TryInitFromAutoRole())
		{
			return;
		}
		if (this.Model.Context.HasAnyLimit)
		{
			Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "[Formation] 单机存在编队限制,跳过自动装配", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.TryInitFromTower())
		{
			return;
		}
		if (this.TryInitFromAbyss())
		{
			return;
		}
		this.InitFromCurrentFormation();
	}

	// Token: 0x0600D511 RID: 54545 RVA: 0x00310F24 File Offset: 0x0030F124
	private bool TryInitFromAutoRole()
	{
		FightFormation? fightFormation;
		int[] array = (this.Model.Context.GetFightFormation() != null) ? fightFormation.GetValueOrDefault().GetAutoRoleArray() : null;
		if (array == null || array.Length == 0)
		{
			return false;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Formation;
		ELogAuthor author = ELogAuthor.SYB;
		string message = "[Formation] AutoRole 装配";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("autoRoleGroupIdList", array);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		int num = 1;
		foreach (int num2 in array)
		{
			BattleRoleSlotData slot = this.Model.GetSlot(num);
			if (slot != null)
			{
				RoleDataBase roleInstance;
				if (!this.Model.TrialRoleInstanceMap.TryGetValue(num2, out roleInstance))
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Formation;
					ELogAuthor author2 = ELogAuthor.SYB;
					string message2 = "[Formation] AutoRole 配置的角色不在试用角色 Map 中";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("groupConfigId", num2);
					instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				else
				{
					slot.SetRoleData(this.CreateRoleDataFromInstance(roleInstance));
					num++;
				}
			}
		}
		return true;
	}

	// Token: 0x0600D512 RID: 54546 RVA: 0x0031101C File Offset: 0x0030F21C
	private bool TryInitFromTower()
	{
		TowerModel instance = TowerModel.Instance;
		if (!instance.IsOpenFloorFormation())
		{
			return false;
		}
		List<int> floorFormation = instance.GetFloorFormation(instance.CurrentSelectFloor);
		List<int> list;
		if (instance.CheckInTower())
		{
			list = ((floorFormation != null && floorFormation.Count > 0) ? floorFormation : instance.CurrentTowerFormation);
		}
		else
		{
			list = floorFormation;
		}
		if (list == null || list.Count == 0)
		{
			return true;
		}
		this.ApplyRoleIdList(list, true);
		return true;
	}

	// Token: 0x0600D513 RID: 54547 RVA: 0x00311080 File Offset: 0x0030F280
	private bool TryInitFromAbyss()
	{
		DangoAbyssModel instance = DangoAbyssModel.Instance;
		if (instance == null || !instance.GetInAbyssFlow())
		{
			return false;
		}
		int currentSelectChallengeId = instance.CurrentSelectChallengeId;
		int[] formationSelectRoleList = instance.GetFormationSelectRoleList(currentSelectChallengeId);
		if (formationSelectRoleList.Length == 0)
		{
			formationSelectRoleList = instance.GetFormationSelectRoleList(currentSelectChallengeId - 1);
		}
		if (formationSelectRoleList.Length == 0)
		{
			return false;
		}
		List<RoleDataBase> roleList = this.Model.GetRoleList();
		List<int> list = new List<int>();
		int[] array = formationSelectRoleList;
		for (int i = 0; i < array.Length; i++)
		{
			int roleId = array[i];
			if (roleList.Any((RoleDataBase r) => r.GetDataId() == roleId))
			{
				list.Add(roleId);
			}
		}
		if (list.Count == 0)
		{
			return false;
		}
		this.ApplyRoleIdList(list, false);
		return true;
	}

	// Token: 0x0600D514 RID: 54548 RVA: 0x00311138 File Offset: 0x0030F338
	private void InitFromCurrentFormation()
	{
		string playerName = FunctionModel.Instance.GetPlayerName();
		int value = PlayerInfoModel.Instance.GetId().Value;
		FormationData currentFormationData = FormationModel.Instance.CurrentFormationData;
		if (currentFormationData == null)
		{
			return;
		}
		int maxLimitRoleCount = this.Model.Context.MaxLimitRoleCount;
		int num = 1;
		foreach (FormationRoleData formationRoleData in currentFormationData.GetRoleDataMap().Values)
		{
			if (formationRoleData.ConfigId > 0 && formationRoleData.PlayerId == value && (maxLimitRoleCount <= 0 || num <= maxLimitRoleCount) && this.Model.Context.CanAddRoleToEditTeam(formationRoleData.ConfigId))
			{
				BattleRoleSlotData slot = this.Model.GetSlot(num);
				if (slot != null)
				{
					RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(formationRoleData.ConfigId, true);
					int level = (roleDataById != null) ? roleDataById.GetLevelData().GetLevel() : 0;
					BattleRoleData battleRoleData = new BattleRoleData();
					battleRoleData.Init(value, formationRoleData.ConfigId, formationRoleData.RoleSkinId, new int?(1), playerName, level, true, true);
					slot.SetRoleData(battleRoleData);
					num++;
				}
			}
		}
	}

	// Token: 0x0600D515 RID: 54549 RVA: 0x00311284 File Offset: 0x0030F484
	public void ApplyRoleIdList(IReadOnlyList<int> roleIdArray, bool reset)
	{
		if (reset)
		{
			this.Model.ResetAllSlots();
		}
		List<BattleRoleSlotData> allSlots = this.Model.GetAllSlots();
		RoleModel instance = RoleModel.Instance;
		int num = 0;
		while (num < roleIdArray.Count && num < allSlots.Count)
		{
			int num2 = roleIdArray[num];
			BattleRoleSlotData battleRoleSlotData = allSlots[num];
			RoleDataBase roleDataById = instance.GetRoleDataById(num2, true);
			if (roleDataById != null)
			{
				BattleRoleData battleRoleData = battleRoleSlotData.RoleData;
				if (battleRoleData == null)
				{
					battleRoleData = this.CreateRoleDataFromInstance(roleDataById);
				}
				battleRoleData.ConfigId = num2;
				battleRoleData.Level = roleDataById.GetLevelData().GetLevel();
				battleRoleSlotData.SetRoleData(battleRoleData);
			}
			num++;
		}
	}

	// Token: 0x0600D516 RID: 54550 RVA: 0x00311328 File Offset: 0x0030F528
	public BattleRoleData CreateRoleDataFromPrewar(PrewarFormationData prewar)
	{
		BattleRoleData battleRoleData = new BattleRoleData();
		battleRoleData.Init(prewar.GetPlayerId(), prewar.GetConfigId(), prewar.GetSkinId(), new int?(prewar.GetOnlineNumber()), prewar.GetPlayerName(), prewar.GetLevel(), prewar.IsSelf(), prewar.GetIsReady());
		battleRoleData.ThirdPartyOnlineId = prewar.GetPlayerOnlineId();
		return battleRoleData;
	}

	// Token: 0x0600D517 RID: 54551 RVA: 0x00311384 File Offset: 0x0030F584
	public BattleRoleData CreateRoleDataFromInstance(RoleDataBase roleInstance)
	{
		BattleRoleData battleRoleData = new BattleRoleData();
		battleRoleData.Init(PlayerInfoModel.Instance.GetId().Value, roleInstance.GetDataId(), roleInstance.GetRoleSkinId(), new int?(1), PlayerInfoModel.Instance.GetAccountName(true), roleInstance.GetLevelData().GetLevel(), true, this.Model.IsSelfReady);
		return battleRoleData;
	}

	// Token: 0x0400618E RID: 24974
	private const int MULTI_SLOT_COUNT = 3;

	// Token: 0x0400618F RID: 24975
	private readonly BattleTeamModel Model;
}
