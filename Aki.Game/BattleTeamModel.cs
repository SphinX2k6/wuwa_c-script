using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001BEB RID: 7147
[NullableContext(1)]
[Nullable(0)]
public class BattleTeamModel : ModelBase
{
	// Token: 0x0600D4DE RID: 54494 RVA: 0x0030FBE0 File Offset: 0x0030DDE0
	public BattleTeamModel()
	{
		this.Initializer = new BattleTeamSlotInitializer(this);
		for (int i = 1; i <= 4; i++)
		{
			this.RoleSlotDataMap[i] = new BattleRoleSlotData(i);
		}
	}

	// Token: 0x1700117E RID: 4478
	// (get) Token: 0x0600D4DF RID: 54495 RVA: 0x0030FC45 File Offset: 0x0030DE45
	public bool IsInInstanceDungeon
	{
		get
		{
			return GameModeController.Instance.IsInInstance();
		}
	}

	// Token: 0x0600D4E0 RID: 54496 RVA: 0x0030FC54 File Offset: 0x0030DE54
	[NullableContext(2)]
	public BattleRoleSlotData GetSlot(int position)
	{
		BattleRoleSlotData result;
		if (this.RoleSlotDataMap.TryGetValue(position, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600D4E1 RID: 54497 RVA: 0x0030FC74 File Offset: 0x0030DE74
	public List<BattleRoleSlotData> GetAllSlots()
	{
		return new List<BattleRoleSlotData>(this.RoleSlotDataMap.Values);
	}

	// Token: 0x0600D4E2 RID: 54498 RVA: 0x0030FC88 File Offset: 0x0030DE88
	public void ResetAllSlots()
	{
		foreach (BattleRoleSlotData battleRoleSlotData in this.RoleSlotDataMap.Values)
		{
			battleRoleSlotData.ResetRoleData();
		}
		this.TrialRoleInstanceMap.Clear();
		Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "[Formation] 还原所有战前编队数据", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600D4E3 RID: 54499 RVA: 0x0030FD04 File Offset: 0x0030DF04
	public void InitAllRoleSlotData()
	{
		this.Initializer.InitAll();
		EventSystem.Instance.Emit<ERefreshRoleSlotReason>(EEventName.OnRefreshBattleRoleSlot, this.Context.IsMultiInstanceDungeon ? ERefreshRoleSlotReason.InitPrewarTeamOnline : ERefreshRoleSlotReason.InitPrewarTeamOffline);
		this.PrintRoleSlotsDebugString();
	}

	// Token: 0x0600D4E4 RID: 54500 RVA: 0x0030FD38 File Offset: 0x0030DF38
	public void RefreshAllMultiRoleData()
	{
		IReadOnlyList<PrewarFormationData> prewarFormationDataList = InstanceDungeonModel.Instance.GetPrewarFormationDataList();
		this.Initializer.RefreshFromMulti(prewarFormationDataList);
		EventSystem.Instance.Emit<ERefreshRoleSlotReason>(EEventName.OnRefreshBattleRoleSlot, ERefreshRoleSlotReason.RefreshPrewarTeamOnline);
	}

	// Token: 0x0600D4E5 RID: 54501 RVA: 0x0030FD70 File Offset: 0x0030DF70
	public void InitTrailRoleInstance()
	{
		this.TrialRoleInstanceMap.Clear();
		FightFormation? fightFormation;
		int[] array = (this.Context.GetFightFormation() != null) ? fightFormation.GetValueOrDefault().GetTrialRoleArray() : null;
		if (array == null)
		{
			return;
		}
		RoleModel instance = RoleModel.Instance;
		RoleConfig instance2 = RoleConfig.Instance;
		foreach (int num in array)
		{
			if (!this.TrialRoleInstanceMap.ContainsKey(num))
			{
				RoleDataBase roleDataById = instance.GetRoleDataById(instance2.GetTrialRoleIdConfigByGroupId(num), true);
				if (roleDataById != null)
				{
					this.TrialRoleInstanceMap[num] = roleDataById;
				}
			}
		}
	}

	// Token: 0x0600D4E6 RID: 54502 RVA: 0x0030FE11 File Offset: 0x0030E011
	public void ApplyRoleIdList(int[] roleIdArray, bool reset)
	{
		this.Initializer.ApplyRoleIdList(roleIdArray, reset);
		EventSystem.Instance.Emit<ERefreshRoleSlotReason>(EEventName.OnRefreshBattleRoleSlot, ERefreshRoleSlotReason.SetTeamByRoleId);
	}

	// Token: 0x0600D4E7 RID: 54503 RVA: 0x0030FE31 File Offset: 0x0030E031
	public BattleRoleData CreateRoleDataFromRoleInstance(RoleDataBase roleInstance)
	{
		return this.Initializer.CreateRoleDataFromInstance(roleInstance);
	}

	// Token: 0x0600D4E8 RID: 54504 RVA: 0x0030FE40 File Offset: 0x0030E040
	public void SetLeaderPlayerId(int? playerId)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Formation;
		ELogAuthor author = ELogAuthor.SYB;
		string message = "[Formation] 设置队长";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("playerId", playerId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.LeaderPlayerIdInternal = playerId;
	}

	// Token: 0x1700117F RID: 4479
	// (get) Token: 0x0600D4E9 RID: 54505 RVA: 0x0030FE80 File Offset: 0x0030E080
	public int? LeaderPlayerId
	{
		get
		{
			return this.LeaderPlayerIdInternal;
		}
	}

	// Token: 0x17001180 RID: 4480
	// (get) Token: 0x0600D4EA RID: 54506 RVA: 0x0030FE88 File Offset: 0x0030E088
	public bool IsLeaderSelf
	{
		get
		{
			if (this.LeaderPlayerIdInternal == null)
			{
				return false;
			}
			int? id = PlayerInfoModel.Instance.GetId();
			int? leaderPlayerIdInternal = this.LeaderPlayerIdInternal;
			return id.GetValueOrDefault() == leaderPlayerIdInternal.GetValueOrDefault() & id != null == (leaderPlayerIdInternal != null);
		}
	}

	// Token: 0x0600D4EB RID: 54507 RVA: 0x0030FED7 File Offset: 0x0030E0D7
	public void SetCurrentEditPosition(int position)
	{
		this.CurrentEditPosition = new int?(position);
	}

	// Token: 0x17001181 RID: 4481
	// (get) Token: 0x0600D4EC RID: 54508 RVA: 0x0030FEE5 File Offset: 0x0030E0E5
	[Nullable(2)]
	public BattleRoleSlotData CurrentEditRoleSlotData
	{
		[NullableContext(2)]
		get
		{
			if (this.CurrentEditPosition == null)
			{
				return null;
			}
			return this.GetSlot(this.CurrentEditPosition.Value);
		}
	}

	// Token: 0x0600D4ED RID: 54509 RVA: 0x0030FF08 File Offset: 0x0030E108
	public bool IsInBattleTeam(int roleConfigId, bool isOwnRoleOnly = false)
	{
		int? id = PlayerInfoModel.Instance.GetId();
		foreach (BattleRoleSlotData battleRoleSlotData in this.RoleSlotDataMap.Values)
		{
			BattleRoleData roleData = battleRoleSlotData.RoleData;
			if (roleData != null)
			{
				if (isOwnRoleOnly)
				{
					int playerId = roleData.PlayerId;
					int? num = id;
					if (!(playerId == num.GetValueOrDefault() & num != null))
					{
						continue;
					}
				}
				if (roleData.ConfigId == roleConfigId)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600D4EE RID: 54510 RVA: 0x0030FF9C File Offset: 0x0030E19C
	[NullableContext(2)]
	public BattleRoleSlotData GetSlotDataByConfigId(int roleConfigId)
	{
		foreach (BattleRoleSlotData battleRoleSlotData in this.RoleSlotDataMap.Values)
		{
			BattleRoleData roleData = battleRoleSlotData.RoleData;
			if (roleData != null && roleData.ConfigId == roleConfigId)
			{
				return battleRoleSlotData;
			}
		}
		return null;
	}

	// Token: 0x17001182 RID: 4482
	// (get) Token: 0x0600D4EF RID: 54511 RVA: 0x0031000C File Offset: 0x0030E20C
	public List<int> AllRoleConfigIdList
	{
		get
		{
			List<int> list = new List<int>();
			foreach (BattleRoleSlotData battleRoleSlotData in this.RoleSlotDataMap.Values)
			{
				BattleRoleData roleData = battleRoleSlotData.RoleData;
				int? num = (roleData != null) ? new int?(roleData.ConfigId) : null;
				if (num != null)
				{
					int? num2 = num;
					int num3 = 0;
					if (!(num2.GetValueOrDefault() == num3 & num2 != null))
					{
						list.Add(num.Value);
					}
				}
			}
			return list;
		}
	}

	// Token: 0x17001183 RID: 4483
	// (get) Token: 0x0600D4F0 RID: 54512 RVA: 0x003100B4 File Offset: 0x0030E2B4
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public ValueTuple<List<int>, List<int>> OwnRoleConfigIdList
	{
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		get
		{
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			int? id = PlayerInfoModel.Instance.GetId();
			foreach (BattleRoleSlotData battleRoleSlotData in this.RoleSlotDataMap.Values)
			{
				BattleRoleData roleData = battleRoleSlotData.RoleData;
				if (roleData != null)
				{
					int playerId = roleData.PlayerId;
					int? num = id;
					if (playerId == num.GetValueOrDefault() & num != null)
					{
						list.Add(roleData.ConfigId);
						list2.Add(battleRoleSlotData.Position - 1);
					}
				}
			}
			return new ValueTuple<List<int>, List<int>>(list, list2);
		}
	}

	// Token: 0x17001184 RID: 4484
	// (get) Token: 0x0600D4F1 RID: 54513 RVA: 0x0031016C File Offset: 0x0030E36C
	public int OwnRoleCountInRoleSlot
	{
		get
		{
			return this.GetAllSelfRoleData().Count;
		}
	}

	// Token: 0x17001185 RID: 4485
	// (get) Token: 0x0600D4F2 RID: 54514 RVA: 0x0031017C File Offset: 0x0030E37C
	public int RoleCountInRoleSlot
	{
		get
		{
			int num = 0;
			using (Dictionary<int, BattleRoleSlotData>.ValueCollection.Enumerator enumerator = this.RoleSlotDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.HasRole)
					{
						num++;
					}
				}
			}
			return num;
		}
	}

	// Token: 0x0600D4F3 RID: 54515 RVA: 0x003101DC File Offset: 0x0030E3DC
	public int GetPlayerRoleNumber(int? playerId)
	{
		int num = 0;
		foreach (BattleRoleSlotData battleRoleSlotData in this.RoleSlotDataMap.Values)
		{
			BattleRoleData roleData = battleRoleSlotData.RoleData;
			bool flag;
			if (roleData == null)
			{
				flag = (playerId == null);
			}
			else
			{
				int playerId2 = roleData.PlayerId;
				int? num2 = playerId;
				flag = (playerId2 == num2.GetValueOrDefault() & num2 != null);
			}
			if (flag)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x0600D4F4 RID: 54516 RVA: 0x00310264 File Offset: 0x0030E464
	public bool HasSameConfigIdInAnyOwnRoleSlot(int configId)
	{
		using (List<BattleRoleData>.Enumerator enumerator = this.GetAllSelfRoleData().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.ConfigId == configId)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600D4F5 RID: 54517 RVA: 0x003102C0 File Offset: 0x0030E4C0
	public bool IsRoleConflict(int playerId, int roleId)
	{
		foreach (BattleRoleSlotData battleRoleSlotData in this.RoleSlotDataMap.Values)
		{
			BattleRoleData roleData = battleRoleSlotData.RoleData;
			if (roleData != null && roleData.PlayerId != playerId && roleData.ConfigId == roleId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x17001186 RID: 4486
	// (get) Token: 0x0600D4F6 RID: 54518 RVA: 0x00310334 File Offset: 0x0030E534
	public bool IsAllRoleDie
	{
		get
		{
			foreach (BattleRoleSlotData battleRoleSlotData in this.RoleSlotDataMap.Values)
			{
				BattleRoleData roleData = battleRoleSlotData.RoleData;
				if (roleData != null)
				{
					if (RoleUtils.IsTrialRole(roleData.ConfigId))
					{
						return false;
					}
					if (!RoleUtils.IsRoleDead(roleData.ConfigId))
					{
						return false;
					}
				}
			}
			return true;
		}
	}

	// Token: 0x17001187 RID: 4487
	// (get) Token: 0x0600D4F7 RID: 54519 RVA: 0x003103B4 File Offset: 0x0030E5B4
	public bool HasSameRole
	{
		get
		{
			foreach (BattleRoleData battleRoleData in this.GetAllSelfRoleData())
			{
				int num = this.ResolveParentRoleId(battleRoleData);
				foreach (BattleRoleSlotData battleRoleSlotData in this.RoleSlotDataMap.Values)
				{
					BattleRoleData roleData = battleRoleSlotData.RoleData;
					if (roleData != null && roleData != battleRoleData && this.ResolveParentRoleId(roleData) == num)
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	// Token: 0x17001188 RID: 4488
	// (get) Token: 0x0600D4F8 RID: 54520 RVA: 0x0031046C File Offset: 0x0030E66C
	public bool HasSpecialTrialRole
	{
		get
		{
			return this.GetAllSelfRoleData().Any((BattleRoleData r) => RoleUtils.IsSpecialTrialRole(r.ConfigId));
		}
	}

	// Token: 0x0600D4F9 RID: 54521 RVA: 0x00310498 File Offset: 0x0030E698
	public int GetParentRolePositionInEditBattleTeam(int roleConfigId)
	{
		if (!RoleUtils.IsTrialRole(roleConfigId))
		{
			foreach (BattleRoleSlotData battleRoleSlotData in this.RoleSlotDataMap.Values)
			{
				BattleRoleData roleData = battleRoleSlotData.RoleData;
				TrialRoleInfo? trialRoleInfo = (roleData != null) ? roleData.TrialRoleConfig : null;
				if (trialRoleInfo != null && trialRoleInfo.GetValueOrDefault().ParentId == roleConfigId)
				{
					return battleRoleSlotData.Position;
				}
			}
			return -1;
		}
		int id = RoleConfig.Instance.GetRoleConfig(roleConfigId).Value.Id;
		BattleRoleSlotData slotDataByConfigId = this.GetSlotDataByConfigId(id);
		if (slotDataByConfigId == null)
		{
			return -1;
		}
		return slotDataByConfigId.Position;
	}

	// Token: 0x0600D4FA RID: 54522 RVA: 0x00310570 File Offset: 0x0030E770
	public void RefreshAllEmptySlotData()
	{
		int count = this.RoleSlotDataMap.Count;
		for (int i = 1; i <= count; i++)
		{
			BattleRoleSlotData battleRoleSlotData;
			if (this.RoleSlotDataMap.TryGetValue(i, out battleRoleSlotData) && battleRoleSlotData.RoleData == null)
			{
				for (int j = i + 1; j <= count; j++)
				{
					BattleRoleSlotData battleRoleSlotData2;
					if (this.RoleSlotDataMap.TryGetValue(j, out battleRoleSlotData2))
					{
						BattleRoleData roleData = battleRoleSlotData2.RoleData;
						if (roleData != null)
						{
							battleRoleSlotData.SetRoleData(roleData);
							battleRoleSlotData2.ResetRoleData();
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x17001189 RID: 4489
	// (get) Token: 0x0600D4FB RID: 54523 RVA: 0x003105EC File Offset: 0x0030E7EC
	public List<int> SelfRoleSlotDataRoleIdList
	{
		get
		{
			List<int> list = new List<int>();
			foreach (BattleRoleData battleRoleData in this.GetAllSelfRoleData())
			{
				if (battleRoleData.ConfigId > 0)
				{
					list.Add(battleRoleData.ConfigId);
				}
			}
			return list;
		}
	}

	// Token: 0x0600D4FC RID: 54524 RVA: 0x00310654 File Offset: 0x0030E854
	public void SetPlayerReady(int playerId, bool bReady)
	{
		foreach (BattleRoleSlotData battleRoleSlotData in this.RoleSlotDataMap.Values)
		{
			BattleRoleData roleData = battleRoleSlotData.RoleData;
			if (roleData != null && roleData.PlayerId == playerId)
			{
				roleData.SetReady(bReady);
				EventSystem.Instance.Emit<int, bool>(EEventName.OnRefreshEditBattleRoleReady, battleRoleSlotData.Position, bReady);
			}
		}
	}

	// Token: 0x1700118A RID: 4490
	// (get) Token: 0x0600D4FD RID: 54525 RVA: 0x003106D8 File Offset: 0x0030E8D8
	public bool IsAllReady
	{
		get
		{
			int? id = PlayerInfoModel.Instance.GetId();
			bool isLeaderSelf = this.IsLeaderSelf;
			foreach (BattleRoleSlotData battleRoleSlotData in this.RoleSlotDataMap.Values)
			{
				BattleRoleData roleData = battleRoleSlotData.RoleData;
				if (roleData != null)
				{
					if (isLeaderSelf)
					{
						int playerId = roleData.PlayerId;
						int? num = id;
						if (playerId == num.GetValueOrDefault() & num != null)
						{
							continue;
						}
					}
					if (!roleData.IsReady)
					{
						return false;
					}
				}
			}
			return true;
		}
	}

	// Token: 0x1700118B RID: 4491
	// (get) Token: 0x0600D4FE RID: 54526 RVA: 0x00310774 File Offset: 0x0030E974
	public bool IsSelfReady
	{
		get
		{
			int? id = PlayerInfoModel.Instance.GetId();
			return InstanceDungeonModel.Instance.GetPrewarPlayerReadyState(id.Value);
		}
	}

	// Token: 0x0600D4FF RID: 54527 RVA: 0x003107A0 File Offset: 0x0030E9A0
	public void ChangeMainRoleData()
	{
		if (GameModeModel.Instance.IsMulti)
		{
			return;
		}
		RoleModel instance = RoleModel.Instance;
		foreach (BattleRoleSlotData battleRoleSlotData in this.RoleSlotDataMap.Values)
		{
			BattleRoleData roleData = battleRoleSlotData.RoleData;
			int? num = (roleData != null) ? new int?(roleData.ConfigId) : null;
			if (num != null)
			{
				int? num2 = num;
				int num3 = 0;
				if (!(num2.GetValueOrDefault() == num3 & num2 != null) && !RoleUtils.IsTrialRole(num.Value) && instance.IsMainRole(num.Value))
				{
					int? newMainRoleId = instance.GetNewMainRoleId(num.Value);
					if (newMainRoleId != null)
					{
						num2 = num;
						int? num4 = newMainRoleId;
						if (!(num2.GetValueOrDefault() == num4.GetValueOrDefault() & num2 != null == (num4 != null)))
						{
							roleData.ConfigId = newMainRoleId.Value;
						}
					}
				}
			}
		}
		EventSystem.Instance.Emit<ERefreshRoleSlotReason>(EEventName.OnRefreshBattleRoleSlot, ERefreshRoleSlotReason.ChangeMainRoleOffline);
	}

	// Token: 0x0600D500 RID: 54528 RVA: 0x003108D0 File Offset: 0x0030EAD0
	public List<RoleDataBase> GetRoleList()
	{
		RoleModel instance = RoleModel.Instance;
		List<RoleDataBase> list = new List<RoleDataBase>();
		if (this.Context.HasLimitRole)
		{
			foreach (int id in this.Context.CurrentLimitRoleIdList)
			{
				RoleDataBase roleDataById = instance.GetRoleDataById(id, true);
				if (roleDataById != null && this.Context.CanAddRoleToEditTeam(roleDataById.GetDataId()))
				{
					list.Add(roleDataById);
				}
			}
		}
		else
		{
			foreach (RoleDataBase roleDataBase in instance.GetRoleDataMap(true).Values)
			{
				if (this.Context.CanAddRoleToEditTeam(roleDataBase.GetDataId()))
				{
					list.Add(roleDataBase);
				}
			}
			foreach (RoleDataBase item in this.TrialRoleInstanceMap.Values)
			{
				list.Add(item);
			}
		}
		return this.FilterByCurrentGender(list);
	}

	// Token: 0x0600D501 RID: 54529 RVA: 0x003109FC File Offset: 0x0030EBFC
	private List<RoleDataBase> FilterByCurrentGender(List<RoleDataBase> roleDataList)
	{
		RoleModel instance = RoleModel.Instance;
		if (this.CurrentGenderRoleList == null)
		{
			this.CurrentGenderRoleList = new List<int>();
			int sex = WorldLevelModel.Instance.Sex;
			IReadOnlyList<MainRoleConfig> mainRoleByGender = RoleConfig.Instance.GetMainRoleByGender((LoginDefine.ELoginSex)sex);
			if (mainRoleByGender != null)
			{
				foreach (MainRoleConfig mainRoleConfig in mainRoleByGender)
				{
					this.CurrentGenderRoleList.Add(mainRoleConfig.Id);
				}
			}
		}
		List<int> currentGenderRoleList = this.CurrentGenderRoleList;
		List<RoleDataBase> list = new List<RoleDataBase>();
		foreach (RoleDataBase roleDataBase in roleDataList)
		{
			int roleId = roleDataBase.GetRoleId();
			if (!instance.IsMainRole(roleId) || currentGenderRoleList.Contains(roleId))
			{
				list.Add(roleDataBase);
			}
		}
		return list;
	}

	// Token: 0x0600D502 RID: 54530 RVA: 0x00310AF8 File Offset: 0x0030ECF8
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"CanAdd",
		"LimitRoleId"
	})]
	public ValueTuple<bool, int> GetAllRoleCanAddToTeam()
	{
		foreach (int num in this.AllRoleConfigIdList)
		{
			if (!this.Context.CanAddRoleToEditTeam(num))
			{
				return new ValueTuple<bool, int>(false, num);
			}
		}
		return new ValueTuple<bool, int>(true, 0);
	}

	// Token: 0x0600D503 RID: 54531 RVA: 0x00310B68 File Offset: 0x0030ED68
	public unsafe void PrintRoleSlotsDebugString()
	{
		for (int i = 1; i <= 4; i++)
		{
			BattleRoleSlotData slot = this.GetSlot(i);
			if (slot != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Formation;
				ELogAuthor author = ELogAuthor.SYB;
				string message = slot.HasRole ? "[Formation] 槽位角色信息" : "[Formation] 槽位无角色";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("position", i);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("roleData", slot.RoleData);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
	}

	// Token: 0x0600D504 RID: 54532 RVA: 0x00310BF8 File Offset: 0x0030EDF8
	private List<BattleRoleData> GetAllSelfRoleData()
	{
		List<BattleRoleData> list = new List<BattleRoleData>();
		foreach (BattleRoleSlotData battleRoleSlotData in this.RoleSlotDataMap.Values)
		{
			BattleRoleData roleData = battleRoleSlotData.RoleData;
			if (roleData != null && roleData.IsSelf)
			{
				list.Add(roleData);
			}
		}
		return list;
	}

	// Token: 0x0600D505 RID: 54533 RVA: 0x00310C68 File Offset: 0x0030EE68
	private int ResolveParentRoleId(BattleRoleData roleData)
	{
		if (!RoleUtils.IsTrialRole(roleData.ConfigId))
		{
			return roleData.ConfigId;
		}
		if (roleData.TrialRoleConfig == null)
		{
			return roleData.ConfigId;
		}
		TrialRoleInfo? trialRoleInfo;
		return trialRoleInfo.GetValueOrDefault().ParentId;
	}

	// Token: 0x1700118C RID: 4492
	// (get) Token: 0x0600D506 RID: 54534 RVA: 0x00310CAF File Offset: 0x0030EEAF
	public static BattleTeamModel Instance
	{
		get
		{
			return BattleTeamModel._Instance;
		}
	}

	// Token: 0x0600D507 RID: 54535 RVA: 0x00310CB6 File Offset: 0x0030EEB6
	public static BattleTeamModel GetOrCreateInstance()
	{
		if (BattleTeamModel._Instance == null)
		{
			BattleTeamModel.CreateInstance();
		}
		return BattleTeamModel._Instance;
	}

	// Token: 0x0600D508 RID: 54536 RVA: 0x00310CCA File Offset: 0x0030EECA
	public static bool CreateInstance()
	{
		if (BattleTeamModel._Instance != null)
		{
			return true;
		}
		BattleTeamModel._Instance = new BattleTeamModel();
		return true;
	}

	// Token: 0x0600D509 RID: 54537 RVA: 0x00310CE0 File Offset: 0x0030EEE0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D50A RID: 54538 RVA: 0x00310CE2 File Offset: 0x0030EEE2
	public static void ResetStaticDefaultValue()
	{
		BattleTeamModel._Instance = null;
	}

	// Token: 0x0600D50B RID: 54539 RVA: 0x00310CEA File Offset: 0x0030EEEA
	static BattleTeamModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BattleTeamModel.CreateStaticDefaultValue), new Action(BattleTeamModel.ResetStaticDefaultValue));
	}

	// Token: 0x04006182 RID: 24962
	private readonly Dictionary<int, BattleRoleSlotData> RoleSlotDataMap = new Dictionary<int, BattleRoleSlotData>();

	// Token: 0x04006183 RID: 24963
	private int? CurrentEditPosition;

	// Token: 0x04006184 RID: 24964
	private int? LeaderPlayerIdInternal;

	// Token: 0x04006185 RID: 24965
	public readonly Dictionary<int, RoleDataBase> TrialRoleInstanceMap = new Dictionary<int, RoleDataBase>();

	// Token: 0x04006186 RID: 24966
	[Nullable(2)]
	private List<int> CurrentGenderRoleList;

	// Token: 0x04006187 RID: 24967
	public readonly BattleTeamDungeonContext Context = new BattleTeamDungeonContext();

	// Token: 0x04006188 RID: 24968
	public bool NeedEntrance = true;

	// Token: 0x04006189 RID: 24969
	public bool IsFormTeleportAction;

	// Token: 0x0400618A RID: 24970
	[Nullable(2)]
	public IFastReturnDungeonContext FastReturnDungeonContext;

	// Token: 0x0400618B RID: 24971
	public bool CanUseSpecialTrialRole;

	// Token: 0x0400618C RID: 24972
	private readonly BattleTeamSlotInitializer Initializer;

	// Token: 0x0400618D RID: 24973
	[Nullable(2)]
	private static BattleTeamModel _Instance;
}
