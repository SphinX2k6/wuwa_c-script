using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020010AA RID: 4266
[NullableContext(1)]
[Nullable(0)]
public class BattleTeamModel : ModelBase
{
	// Token: 0x0600A8F0 RID: 43248 RVA: 0x0031AD54 File Offset: 0x00318F54
	public BattleTeamModel()
	{
		this.Initializer = new BattleTeamSlotInitializer(this);
		for (int i = 1; i <= 4; i++)
		{
			this.RoleSlotDataMap[i] = new BattleRoleSlotData(i);
		}
	}

	// Token: 0x170011A3 RID: 4515
	// (get) Token: 0x0600A8F1 RID: 43249 RVA: 0x0031ADB9 File Offset: 0x00318FB9
	public bool IsInInstanceDungeon
	{
		get
		{
			return GameModeController.Instance.IsInInstance();
		}
	}

	// Token: 0x0600A8F2 RID: 43250 RVA: 0x0031ADC8 File Offset: 0x00318FC8
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

	// Token: 0x0600A8F3 RID: 43251 RVA: 0x0031ADE8 File Offset: 0x00318FE8
	public List<BattleRoleSlotData> GetAllSlots()
	{
		return new List<BattleRoleSlotData>(this.RoleSlotDataMap.Values);
	}

	// Token: 0x0600A8F4 RID: 43252 RVA: 0x0031ADFC File Offset: 0x00318FFC
	public void ResetAllSlots()
	{
		foreach (BattleRoleSlotData battleRoleSlotData in this.RoleSlotDataMap.Values)
		{
			battleRoleSlotData.ResetRoleData();
		}
		this.TrialRoleInstanceMap.Clear();
		Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "[Formation] 还原所有战前编队数据", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600A8F5 RID: 43253 RVA: 0x0031AE78 File Offset: 0x00319078
	public void InitAllRoleSlotData()
	{
		this.Initializer.InitAll();
		EventSystem.Instance.Emit<ERefreshRoleSlotReason>(EEventName.OnRefreshBattleRoleSlot, this.Context.IsMultiInstanceDungeon ? ERefreshRoleSlotReason.InitPrewarTeamOnline : ERefreshRoleSlotReason.InitPrewarTeamOffline);
		this.PrintRoleSlotsDebugString();
	}

	// Token: 0x0600A8F6 RID: 43254 RVA: 0x0031AEAC File Offset: 0x003190AC
	public void RefreshAllMultiRoleData()
	{
		IReadOnlyList<PrewarFormationData> prewarFormationDataList = InstanceDungeonModel.Instance.GetPrewarFormationDataList();
		this.Initializer.RefreshFromMulti(prewarFormationDataList);
		EventSystem.Instance.Emit<ERefreshRoleSlotReason>(EEventName.OnRefreshBattleRoleSlot, ERefreshRoleSlotReason.RefreshPrewarTeamOnline);
	}

	// Token: 0x0600A8F7 RID: 43255 RVA: 0x0031AEE4 File Offset: 0x003190E4
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

	// Token: 0x0600A8F8 RID: 43256 RVA: 0x0031AF85 File Offset: 0x00319185
	public void ApplyRoleIdList(int[] roleIdArray, bool reset)
	{
		this.Initializer.ApplyRoleIdList(roleIdArray, reset);
		EventSystem.Instance.Emit<ERefreshRoleSlotReason>(EEventName.OnRefreshBattleRoleSlot, ERefreshRoleSlotReason.SetTeamByRoleId);
	}

	// Token: 0x0600A8F9 RID: 43257 RVA: 0x0031AFA5 File Offset: 0x003191A5
	public BattleRoleData CreateRoleDataFromRoleInstance(RoleDataBase roleInstance)
	{
		return this.Initializer.CreateRoleDataFromInstance(roleInstance);
	}

	// Token: 0x0600A8FA RID: 43258 RVA: 0x0031AFB4 File Offset: 0x003191B4
	public BattleRoleData CreateEmptyRoleData(int roleConfigId)
	{
		int value = PlayerInfoModel.Instance.GetId().Value;
		string accountName = PlayerInfoModel.Instance.GetAccountName(true);
		RoleInfo? roleInfo;
		int skinId = (RoleConfig.Instance.GetRoleConfig(roleConfigId) != null) ? roleInfo.GetValueOrDefault().SkinId : 0;
		BattleRoleData battleRoleData = new BattleRoleData();
		battleRoleData.Init(value, roleConfigId, skinId, new int?(1), accountName, 0, true, this.IsSelfReady);
		return battleRoleData;
	}

	// Token: 0x0600A8FB RID: 43259 RVA: 0x0031B028 File Offset: 0x00319228
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

	// Token: 0x170011A4 RID: 4516
	// (get) Token: 0x0600A8FC RID: 43260 RVA: 0x0031B068 File Offset: 0x00319268
	public int? LeaderPlayerId
	{
		get
		{
			return this.LeaderPlayerIdInternal;
		}
	}

	// Token: 0x170011A5 RID: 4517
	// (get) Token: 0x0600A8FD RID: 43261 RVA: 0x0031B070 File Offset: 0x00319270
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

	// Token: 0x0600A8FE RID: 43262 RVA: 0x0031B0BF File Offset: 0x003192BF
	public void SetCurrentEditPosition(int position)
	{
		this.CurrentEditPosition = new int?(position);
	}

	// Token: 0x170011A6 RID: 4518
	// (get) Token: 0x0600A8FF RID: 43263 RVA: 0x0031B0CD File Offset: 0x003192CD
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

	// Token: 0x0600A900 RID: 43264 RVA: 0x0031B0F0 File Offset: 0x003192F0
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

	// Token: 0x0600A901 RID: 43265 RVA: 0x0031B184 File Offset: 0x00319384
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

	// Token: 0x170011A7 RID: 4519
	// (get) Token: 0x0600A902 RID: 43266 RVA: 0x0031B1F4 File Offset: 0x003193F4
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

	// Token: 0x170011A8 RID: 4520
	// (get) Token: 0x0600A903 RID: 43267 RVA: 0x0031B29C File Offset: 0x0031949C
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

	// Token: 0x170011A9 RID: 4521
	// (get) Token: 0x0600A904 RID: 43268 RVA: 0x0031B354 File Offset: 0x00319554
	public int OwnRoleCountInRoleSlot
	{
		get
		{
			return this.GetAllSelfRoleData().Count;
		}
	}

	// Token: 0x170011AA RID: 4522
	// (get) Token: 0x0600A905 RID: 43269 RVA: 0x0031B364 File Offset: 0x00319564
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

	// Token: 0x0600A906 RID: 43270 RVA: 0x0031B3C4 File Offset: 0x003195C4
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

	// Token: 0x0600A907 RID: 43271 RVA: 0x0031B44C File Offset: 0x0031964C
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

	// Token: 0x0600A908 RID: 43272 RVA: 0x0031B4A8 File Offset: 0x003196A8
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

	// Token: 0x170011AB RID: 4523
	// (get) Token: 0x0600A909 RID: 43273 RVA: 0x0031B51C File Offset: 0x0031971C
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

	// Token: 0x170011AC RID: 4524
	// (get) Token: 0x0600A90A RID: 43274 RVA: 0x0031B59C File Offset: 0x0031979C
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

	// Token: 0x170011AD RID: 4525
	// (get) Token: 0x0600A90B RID: 43275 RVA: 0x0031B654 File Offset: 0x00319854
	public bool HasSpecialTrialRole
	{
		get
		{
			using (List<BattleRoleData>.Enumerator enumerator = this.GetAllSelfRoleData().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (RoleUtils.IsSpecialTrialRole(enumerator.Current.ConfigId))
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	// Token: 0x0600A90C RID: 43276 RVA: 0x0031B6B4 File Offset: 0x003198B4
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

	// Token: 0x0600A90D RID: 43277 RVA: 0x0031B78C File Offset: 0x0031998C
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

	// Token: 0x170011AE RID: 4526
	// (get) Token: 0x0600A90E RID: 43278 RVA: 0x0031B808 File Offset: 0x00319A08
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

	// Token: 0x0600A90F RID: 43279 RVA: 0x0031B870 File Offset: 0x00319A70
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

	// Token: 0x170011AF RID: 4527
	// (get) Token: 0x0600A910 RID: 43280 RVA: 0x0031B8F4 File Offset: 0x00319AF4
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

	// Token: 0x170011B0 RID: 4528
	// (get) Token: 0x0600A911 RID: 43281 RVA: 0x0031B990 File Offset: 0x00319B90
	public bool IsSelfReady
	{
		get
		{
			int? id = PlayerInfoModel.Instance.GetId();
			return InstanceDungeonModel.Instance.GetPrewarPlayerReadyState(id.Value);
		}
	}

	// Token: 0x0600A912 RID: 43282 RVA: 0x0031B9BC File Offset: 0x00319BBC
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

	// Token: 0x0600A913 RID: 43283 RVA: 0x0031BAEC File Offset: 0x00319CEC
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

	// Token: 0x0600A914 RID: 43284 RVA: 0x0031BC18 File Offset: 0x00319E18
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

	// Token: 0x0600A915 RID: 43285 RVA: 0x0031BD14 File Offset: 0x00319F14
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

	// Token: 0x0600A916 RID: 43286 RVA: 0x0031BD84 File Offset: 0x00319F84
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

	// Token: 0x0600A917 RID: 43287 RVA: 0x0031BE14 File Offset: 0x0031A014
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

	// Token: 0x0600A918 RID: 43288 RVA: 0x0031BE84 File Offset: 0x0031A084
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

	// Token: 0x170011B1 RID: 4529
	// (get) Token: 0x0600A919 RID: 43289 RVA: 0x0031BECB File Offset: 0x0031A0CB
	public static BattleTeamModel Instance
	{
		get
		{
			return BattleTeamModel._Instance;
		}
	}

	// Token: 0x0600A91A RID: 43290 RVA: 0x0031BED2 File Offset: 0x0031A0D2
	public static BattleTeamModel GetOrCreateInstance()
	{
		if (BattleTeamModel._Instance == null)
		{
			BattleTeamModel.CreateInstance();
		}
		return BattleTeamModel._Instance;
	}

	// Token: 0x0600A91B RID: 43291 RVA: 0x0031BEE6 File Offset: 0x0031A0E6
	public static bool CreateInstance()
	{
		if (BattleTeamModel._Instance != null)
		{
			return true;
		}
		BattleTeamModel._Instance = new BattleTeamModel();
		return true;
	}

	// Token: 0x0600A91C RID: 43292 RVA: 0x0031BEFC File Offset: 0x0031A0FC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A91D RID: 43293 RVA: 0x0031BEFE File Offset: 0x0031A0FE
	public static void ResetStaticDefaultValue()
	{
		BattleTeamModel._Instance = null;
	}

	// Token: 0x0600A91E RID: 43294 RVA: 0x0031BF06 File Offset: 0x0031A106
	static BattleTeamModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BattleTeamModel.CreateStaticDefaultValue), new Action(BattleTeamModel.ResetStaticDefaultValue));
	}

	// Token: 0x04006251 RID: 25169
	private readonly Dictionary<int, BattleRoleSlotData> RoleSlotDataMap = new Dictionary<int, BattleRoleSlotData>();

	// Token: 0x04006252 RID: 25170
	private int? CurrentEditPosition;

	// Token: 0x04006253 RID: 25171
	private int? LeaderPlayerIdInternal;

	// Token: 0x04006254 RID: 25172
	public readonly Dictionary<int, RoleDataBase> TrialRoleInstanceMap = new Dictionary<int, RoleDataBase>();

	// Token: 0x04006255 RID: 25173
	[Nullable(2)]
	private List<int> CurrentGenderRoleList;

	// Token: 0x04006256 RID: 25174
	public readonly BattleTeamDungeonContext Context = new BattleTeamDungeonContext();

	// Token: 0x04006257 RID: 25175
	public bool NeedEntrance = true;

	// Token: 0x04006258 RID: 25176
	public bool IsFormTeleportAction;

	// Token: 0x04006259 RID: 25177
	[Nullable(2)]
	public IFastReturnDungeonContext FastReturnDungeonContext;

	// Token: 0x0400625A RID: 25178
	public bool CanUseSpecialTrialRole;

	// Token: 0x0400625B RID: 25179
	private readonly BattleTeamSlotInitializer Initializer;

	// Token: 0x0400625C RID: 25180
	[Nullable(2)]
	private static BattleTeamModel _Instance;
}
