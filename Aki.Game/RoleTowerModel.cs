using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x02001CA2 RID: 7330
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RoleTowerModel : ModelBase
{
	// Token: 0x0601226F RID: 74351 RVA: 0x0055836D File Offset: 0x0055656D
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06012270 RID: 74352 RVA: 0x00558370 File Offset: 0x00556570
	protected override bool OnClear()
	{
		this.StopUnlockTimeTimer();
		return true;
	}

	// Token: 0x06012271 RID: 74353 RVA: 0x00558379 File Offset: 0x00556579
	public void SetActivityId(int activityId)
	{
		this.CurActivityId = activityId;
	}

	// Token: 0x17001B63 RID: 7011
	// (get) Token: 0x06012272 RID: 74354 RVA: 0x00558382 File Offset: 0x00556582
	public int ActivityId
	{
		get
		{
			return this.CurActivityId;
		}
	}

	// Token: 0x17001B64 RID: 7012
	// (get) Token: 0x06012273 RID: 74355 RVA: 0x0055838A File Offset: 0x0055658A
	// (set) Token: 0x06012274 RID: 74356 RVA: 0x00558397 File Offset: 0x00556597
	public bool IsShowBriefDesc
	{
		get
		{
			return LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.RoleTowerShowBriefDesc, true);
		}
		set
		{
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.RoleTowerShowBriefDesc, value);
		}
	}

	// Token: 0x06012275 RID: 74357 RVA: 0x005583A8 File Offset: 0x005565A8
	public IReadOnlyList<RoleTowerLevelGroup> GetGroupCfgList()
	{
		List<RoleTowerLevelGroup> list = new List<RoleTowerLevelGroup>(RoleTowerConfig.Instance.GetGroupsByActivityId(this.CurActivityId) ?? new List<RoleTowerLevelGroup>());
		list.Sort((RoleTowerLevelGroup a, RoleTowerLevelGroup b) => a.Id - b.Id);
		return list;
	}

	// Token: 0x06012276 RID: 74358 RVA: 0x005583F8 File Offset: 0x005565F8
	public RoleTowerLevelGroup? GetGroupCfg(int id)
	{
		return RoleTowerConfig.Instance.GetGroupById(id);
	}

	// Token: 0x06012277 RID: 74359 RVA: 0x00558405 File Offset: 0x00556605
	public IReadOnlyList<RoleTowerLevel> GetLevelCfgListByGroup(int groupId)
	{
		List<RoleTowerLevel> list = new List<RoleTowerLevel>(RoleTowerConfig.Instance.GetLevelsByGroup(groupId) ?? new List<RoleTowerLevel>());
		list.Sort((RoleTowerLevel a, RoleTowerLevel b) => b.Id - a.Id);
		return list;
	}

	// Token: 0x06012278 RID: 74360 RVA: 0x00558445 File Offset: 0x00556645
	public IReadOnlyList<RoleTowerLevel> GetLevelCfgListByGroupUnlockFirst(int groupId)
	{
		List<RoleTowerLevel> list = new List<RoleTowerLevel>(this.GetLevelCfgListByGroup(groupId));
		list.Sort(delegate(RoleTowerLevel a, RoleTowerLevel b)
		{
			RoleTowerLevelData levelState = this.GetLevelState(a.Id);
			bool flag = levelState != null && levelState.IsUnlock;
			RoleTowerLevelData levelState2 = this.GetLevelState(b.Id);
			bool flag2 = levelState2 != null && levelState2.IsUnlock;
			if (flag == flag2)
			{
				return b.Id - a.Id;
			}
			if (!flag)
			{
				return 1;
			}
			return -1;
		});
		return list;
	}

	// Token: 0x06012279 RID: 74361 RVA: 0x00558465 File Offset: 0x00556665
	public RoleTowerLevel? GetLevelCfg(int id)
	{
		return RoleTowerConfig.Instance.GetLevelById(id);
	}

	// Token: 0x0601227A RID: 74362 RVA: 0x00558474 File Offset: 0x00556674
	public int? GetCurLevelEntityLevel()
	{
		RoleTowerLevel? levelCfg = this.GetLevelCfg(this.CurSelectLevel);
		if (levelCfg == null)
		{
			return null;
		}
		if (InstanceDungeonConfig.Instance.GetConfig(levelCfg.Value.InstId) == null)
		{
			return null;
		}
		InstanceDungeon? instanceDungeon;
		return new int?(instanceDungeon.GetValueOrDefault().EntityLevel);
	}

	// Token: 0x0601227B RID: 74363 RVA: 0x005584E4 File Offset: 0x005566E4
	public bool IsGroupAllLocked(int groupId)
	{
		IReadOnlyList<RoleTowerLevel> levelCfgListByGroup = this.GetLevelCfgListByGroup(groupId);
		if (levelCfgListByGroup.Count == 0)
		{
			return false;
		}
		foreach (RoleTowerLevel roleTowerLevel in levelCfgListByGroup)
		{
			RoleTowerLevelData levelState = this.GetLevelState(roleTowerLevel.Id);
			if (levelState != null && levelState.IsUnlock)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0601227C RID: 74364 RVA: 0x0055855C File Offset: 0x0055675C
	public IReadOnlyList<RoleTowerFloor> GetFloorCfgListByLevel(int levelId)
	{
		List<RoleTowerFloor> list = new List<RoleTowerFloor>(RoleTowerConfig.Instance.GetFloorsByLevel(levelId) ?? new List<RoleTowerFloor>());
		list.Sort((RoleTowerFloor a, RoleTowerFloor b) => a.FloorIndex - b.FloorIndex);
		return list;
	}

	// Token: 0x0601227D RID: 74365 RVA: 0x0055859C File Offset: 0x0055679C
	public RoleTowerFloor? GetFloorCfg(int id)
	{
		return RoleTowerConfig.Instance.GetFloorById(id);
	}

	// Token: 0x0601227E RID: 74366 RVA: 0x005585A9 File Offset: 0x005567A9
	public RoleTowerStage? GetStageCfg(int id)
	{
		return RoleTowerConfig.Instance.GetStageById(id);
	}

	// Token: 0x0601227F RID: 74367 RVA: 0x005585B8 File Offset: 0x005567B8
	public RoleTowerStage? GetStageCfgByFloor(int floorId)
	{
		int floorStageId = RoleTowerConfig.Instance.GetFloorStageId(floorId);
		if (floorStageId <= 0)
		{
			return null;
		}
		return RoleTowerConfig.Instance.GetStageById(floorStageId);
	}

	// Token: 0x06012280 RID: 74368 RVA: 0x005585EC File Offset: 0x005567EC
	public IReadOnlyList<RoleTowerStage> GetStageCfgListByLevel(int levelId)
	{
		List<RoleTowerStage> list = new List<RoleTowerStage>();
		HashSet<int> hashSet = new HashSet<int>();
		foreach (RoleTowerFloor roleTowerFloor in this.GetFloorCfgListByLevel(levelId))
		{
			int floorStageId = RoleTowerConfig.Instance.GetFloorStageId(roleTowerFloor.Id);
			if (floorStageId > 0 && hashSet.Add(floorStageId))
			{
				RoleTowerStage? stageById = RoleTowerConfig.Instance.GetStageById(floorStageId);
				if (stageById != null)
				{
					list.Add(stageById.Value);
				}
			}
		}
		list.Sort((RoleTowerStage a, RoleTowerStage b) => a.Stage - b.Stage);
		return list;
	}

	// Token: 0x06012281 RID: 74369 RVA: 0x005586AC File Offset: 0x005568AC
	public RoleTowerStage? GetStageCfgInLevel(int levelId, int stageSeqOrId)
	{
		if (stageSeqOrId <= 0)
		{
			return null;
		}
		foreach (RoleTowerStage value in this.GetStageCfgListByLevel(levelId))
		{
			if (value.Stage == stageSeqOrId)
			{
				return new RoleTowerStage?(value);
			}
		}
		return this.GetStageCfg(stageSeqOrId);
	}

	// Token: 0x06012282 RID: 74370 RVA: 0x00558720 File Offset: 0x00556920
	public IReadOnlyList<RoleTowerFloor> GetFloorCfgListByStage(int levelId, int stageSeq)
	{
		List<RoleTowerFloor> list = new List<RoleTowerFloor>();
		foreach (RoleTowerFloor item in this.GetFloorCfgListByLevel(levelId))
		{
			if (RoleTowerConfig.Instance.GetFloorStageSeq(item.Id) == stageSeq)
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06012283 RID: 74371 RVA: 0x0055878C File Offset: 0x0055698C
	public IReadOnlyList<bool> GetStageFloorPassedList(int levelId, int stageSeq)
	{
		SortedDictionary<int, bool> sortedDictionary = new SortedDictionary<int, bool>();
		foreach (RoleTowerFloor roleTowerFloor in this.GetFloorCfgListByStage(levelId, stageSeq))
		{
			RoleTowerFloorData floorState = this.GetFloorState(roleTowerFloor.Id);
			bool flag = floorState != null && floorState.IsPassed;
			bool flag2;
			sortedDictionary[roleTowerFloor.FloorIndex] = (sortedDictionary.TryGetValue(roleTowerFloor.FloorIndex, out flag2) ? (flag2 || flag) : flag);
		}
		return new List<bool>(sortedDictionary.Values);
	}

	// Token: 0x06012284 RID: 74372 RVA: 0x00558824 File Offset: 0x00556A24
	public IReadOnlyList<RoleTowerWave> GetWaveCfgListByFloor(int floorId)
	{
		List<RoleTowerWave> list = new List<RoleTowerWave>(RoleTowerConfig.Instance.GetWavesByFloor(floorId) ?? new List<RoleTowerWave>());
		list.Sort((RoleTowerWave a, RoleTowerWave b) => a.WaveIndex - b.WaveIndex);
		return list;
	}

	// Token: 0x06012285 RID: 74373 RVA: 0x00558864 File Offset: 0x00556A64
	public RoleTowerBranch? GetBranchCfgOfFloor(int floorId)
	{
		RoleTowerFloor? floorCfg = this.GetFloorCfg(floorId);
		if (floorCfg == null || floorCfg.Value.Branch <= 0)
		{
			return null;
		}
		return RoleTowerConfig.Instance.GetBranchById(floorCfg.Value.Branch);
	}

	// Token: 0x06012286 RID: 74374 RVA: 0x005588B8 File Offset: 0x00556AB8
	public IReadOnlyList<RoleTowerBranch> GetBranchOptionsOfStageFloor(int levelId, int stageSeq, int floorIndex)
	{
		List<RoleTowerBranch> list = new List<RoleTowerBranch>();
		foreach (RoleTowerFloor roleTowerFloor in this.GetFloorCfgListByStage(levelId, stageSeq))
		{
			if (roleTowerFloor.FloorIndex == floorIndex && roleTowerFloor.Branch > 0)
			{
				RoleTowerBranch? branchById = RoleTowerConfig.Instance.GetBranchById(roleTowerFloor.Branch);
				if (branchById != null)
				{
					list.Add(branchById.Value);
				}
			}
		}
		list.Sort((RoleTowerBranch a, RoleTowerBranch b) => a.Id - b.Id);
		return list;
	}

	// Token: 0x06012287 RID: 74375 RVA: 0x00558968 File Offset: 0x00556B68
	public RoleTowerBranch? GetBranchCfg(int id)
	{
		return RoleTowerConfig.Instance.GetBranchById(id);
	}

	// Token: 0x06012288 RID: 74376 RVA: 0x00558978 File Offset: 0x00556B78
	public bool HasBranchByFloor(int floorId)
	{
		RoleTowerFloor? roleTowerFloor;
		return this.GetFloorCfg(floorId) != null && roleTowerFloor.GetValueOrDefault().Branch > 0;
	}

	// Token: 0x06012289 RID: 74377 RVA: 0x005589AA File Offset: 0x00556BAA
	public RoleTowerToken? GetTokenCfg(int id)
	{
		return RoleTowerConfig.Instance.GetTokenById(id);
	}

	// Token: 0x0601228A RID: 74378 RVA: 0x005589B7 File Offset: 0x00556BB7
	public RoleTowerTokenType? GetTokenTypeCfg(int id)
	{
		return RoleTowerConfig.Instance.GetTokenTypeById(id);
	}

	// Token: 0x0601228B RID: 74379 RVA: 0x005589C4 File Offset: 0x00556BC4
	public IReadOnlyList<RoleTowerTokenZone> GetTokenZoneCfgList()
	{
		List<RoleTowerTokenZone> list = new List<RoleTowerTokenZone>(RoleTowerConfig.Instance.GetTokenZonesByActivityId(this.CurActivityId) ?? new List<RoleTowerTokenZone>());
		list.Sort((RoleTowerTokenZone a, RoleTowerTokenZone b) => a.Id - b.Id);
		return list;
	}

	// Token: 0x0601228C RID: 74380 RVA: 0x00558A14 File Offset: 0x00556C14
	public IReadOnlyList<RoleTowerToken> GetTokenCfgListByZone(int zoneId)
	{
		List<RoleTowerToken> list = new List<RoleTowerToken>();
		IReadOnlyList<RoleTowerToken> tokensByActivityId = RoleTowerConfig.Instance.GetTokensByActivityId(this.CurActivityId);
		if (tokensByActivityId != null)
		{
			foreach (RoleTowerToken item in tokensByActivityId)
			{
				if (item.ZoneId == zoneId)
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	// Token: 0x0601228D RID: 74381 RVA: 0x00558A84 File Offset: 0x00556C84
	public IReadOnlyList<RoleTowerToken> GetOwnedTokenCfgList()
	{
		List<RoleTowerToken> list = new List<RoleTowerToken>();
		IReadOnlyList<RoleTowerToken> tokensByActivityId = RoleTowerConfig.Instance.GetTokensByActivityId(this.CurActivityId);
		if (tokensByActivityId != null)
		{
			foreach (RoleTowerToken item in tokensByActivityId)
			{
				RoleTowerTokenData tokenState = this.GetTokenState(item.Id);
				if (tokenState != null && tokenState.IsUnlocked)
				{
					list.Add(item);
				}
			}
		}
		list.Sort((RoleTowerToken a, RoleTowerToken b) => a.Id - b.Id);
		return list;
	}

	// Token: 0x0601228E RID: 74382 RVA: 0x00558B28 File Offset: 0x00556D28
	public RoleTowerStarGroup? GetStarGroupCfg(int id)
	{
		return RoleTowerConfig.Instance.GetStarGroupById(id);
	}

	// Token: 0x0601228F RID: 74383 RVA: 0x00558B35 File Offset: 0x00556D35
	public IReadOnlyList<RoleTowerStar> GetStarCfgListByGroup(int groupId)
	{
		List<RoleTowerStar> list = new List<RoleTowerStar>(RoleTowerConfig.Instance.GetStarsByGroup(groupId) ?? new List<RoleTowerStar>());
		list.Sort((RoleTowerStar a, RoleTowerStar b) => a.StarIndex - b.StarIndex);
		return list;
	}

	// Token: 0x06012290 RID: 74384 RVA: 0x00558B78 File Offset: 0x00556D78
	public IReadOnlyList<RoleTowerStar> GetStarCfgListByRole(int roleId = 0)
	{
		if (roleId <= 0)
		{
			roleId = this.GetSlotRoleId(ERoleTowerSlotType.Main);
		}
		int num = 0;
		RoleTowerRole? roleByRoleId = RoleTowerConfig.Instance.GetRoleByRoleId(RoleTowerModel.ToSourceRoleId(roleId));
		if (roleByRoleId != null)
		{
			num = ((roleId == this.GetSlotRoleId(ERoleTowerSlotType.Main)) ? roleByRoleId.Value.MainGroup : roleByRoleId.Value.AssistGroup);
		}
		if (num > 0)
		{
			return this.GetStarCfgListByGroup(num);
		}
		IReadOnlyList<RoleTowerStarGroup> allStarGroups = RoleTowerConfig.Instance.GetAllStarGroups();
		if (allStarGroups == null || allStarGroups.Count == 0)
		{
			return new List<RoleTowerStar>();
		}
		return this.GetStarCfgListByGroup(allStarGroups[0].Id);
	}

	// Token: 0x06012291 RID: 74385 RVA: 0x00558C1C File Offset: 0x00556E1C
	public IReadOnlyList<RoleTowerEchoLevel> GetEchoLevelCfgList()
	{
		List<RoleTowerEchoLevel> list = new List<RoleTowerEchoLevel>(RoleTowerConfig.Instance.GetEchoLevelsByActivityId(this.CurActivityId) ?? new List<RoleTowerEchoLevel>());
		list.Sort((RoleTowerEchoLevel a, RoleTowerEchoLevel b) => a.LevelIndex - b.LevelIndex);
		return list;
	}

	// Token: 0x06012292 RID: 74386 RVA: 0x00558C6C File Offset: 0x00556E6C
	public int GetMaxEchoLevelIndex()
	{
		IReadOnlyList<RoleTowerEchoLevel> echoLevelCfgList = this.GetEchoLevelCfgList();
		if (echoLevelCfgList.Count <= 0)
		{
			return 0;
		}
		return echoLevelCfgList[echoLevelCfgList.Count - 1].LevelIndex;
	}

	// Token: 0x06012293 RID: 74387 RVA: 0x00558CA1 File Offset: 0x00556EA1
	public IReadOnlyList<RoleTowerReward> GetRewardCfgList()
	{
		return RoleTowerConfig.Instance.GetRewardsByActivityId(this.CurActivityId) ?? new List<RoleTowerReward>();
	}

	// Token: 0x06012294 RID: 74388 RVA: 0x00558CBC File Offset: 0x00556EBC
	public IReadOnlyList<RoleTowerRewardTab> GetRewardTabCfgList()
	{
		List<RoleTowerRewardTab> list = new List<RoleTowerRewardTab>(RoleTowerConfig.Instance.GetRewardTabsByActivityId(this.CurActivityId) ?? new List<RoleTowerRewardTab>());
		list.Sort((RoleTowerRewardTab a, RoleTowerRewardTab b) => a.Id - b.Id);
		return list;
	}

	// Token: 0x06012295 RID: 74389 RVA: 0x00558D0C File Offset: 0x00556F0C
	public RoleTowerRewardTab? GetRewardTabCfg(int tabId)
	{
		return RoleTowerConfig.Instance.GetRewardTabById(tabId);
	}

	// Token: 0x06012296 RID: 74390 RVA: 0x00558D19 File Offset: 0x00556F19
	public RoleTowerReward? GetRewardCfg(int rewardId)
	{
		return RoleTowerConfig.Instance.GetRewardById(rewardId);
	}

	// Token: 0x06012297 RID: 74391 RVA: 0x00558D26 File Offset: 0x00556F26
	public RoleTowerScoreReward? GetScoreRewardCfg(int id)
	{
		return RoleTowerConfig.Instance.GetScoreRewardById(id);
	}

	// Token: 0x06012298 RID: 74392 RVA: 0x00558D33 File Offset: 0x00556F33
	public IReadOnlyList<RoleTowerReward> GetRewardCfgListByTab(int tabId)
	{
		List<RoleTowerReward> list = new List<RoleTowerReward>(RoleTowerConfig.Instance.GetRewardsByTab(tabId) ?? new List<RoleTowerReward>());
		list.Sort(delegate(RoleTowerReward a, RoleTowerReward b)
		{
			int rewardStateOrder = this.GetRewardStateOrder(a.Id);
			int rewardStateOrder2 = this.GetRewardStateOrder(b.Id);
			if (rewardStateOrder == rewardStateOrder2)
			{
				return a.Id - b.Id;
			}
			return rewardStateOrder - rewardStateOrder2;
		});
		return list;
	}

	// Token: 0x06012299 RID: 74393 RVA: 0x00558D60 File Offset: 0x00556F60
	private int GetRewardStateOrder(int rewardId)
	{
		RoleTowerRewardData rewardState = this.GetRewardState(rewardId);
		int result;
		switch ((rewardState != null) ? rewardState.State : ERoleTowerRewardState.UnFinish)
		{
		case ERoleTowerRewardState.UnFinish:
			result = 1;
			break;
		case ERoleTowerRewardState.CanReceive:
			result = 0;
			break;
		case ERoleTowerRewardState.Received:
			result = 2;
			break;
		default:
			result = 1;
			break;
		}
		return result;
	}

	// Token: 0x0601229A RID: 74394 RVA: 0x00558DA4 File Offset: 0x00556FA4
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"received",
		"total"
	})]
	public ValueTuple<int, int> GetRewardTabProgress(int tabId)
	{
		IReadOnlyList<RoleTowerReward> readOnlyList = RoleTowerConfig.Instance.GetRewardsByTab(tabId) ?? new List<RoleTowerReward>();
		int num = 0;
		foreach (RoleTowerReward roleTowerReward in readOnlyList)
		{
			RoleTowerRewardData rewardState = this.GetRewardState(roleTowerReward.Id);
			if (((rewardState != null) ? rewardState.State : ERoleTowerRewardState.UnFinish) == ERoleTowerRewardState.Received)
			{
				num++;
			}
		}
		return new ValueTuple<int, int>(num, readOnlyList.Count);
	}

	// Token: 0x0601229B RID: 74395 RVA: 0x00558E28 File Offset: 0x00557028
	public IReadOnlyList<RoleTowerScoreReward> GetScoreRewardCfgList()
	{
		return RoleTowerConfig.Instance.GetScoreRewardsByActivityId(this.CurActivityId) ?? new List<RoleTowerScoreReward>();
	}

	// Token: 0x0601229C RID: 74396 RVA: 0x00558E43 File Offset: 0x00557043
	public List<RoleTowerScoreReward> GetSortedScoreRewardCfgList()
	{
		List<RoleTowerScoreReward> list = new List<RoleTowerScoreReward>(this.GetScoreRewardCfgList());
		list.Sort(delegate(RoleTowerScoreReward a, RoleTowerScoreReward b)
		{
			if (a.NeedScore == b.NeedScore)
			{
				return a.Id - b.Id;
			}
			return a.NeedScore - b.NeedScore;
		});
		return list;
	}

	// Token: 0x0601229D RID: 74397 RVA: 0x00558E78 File Offset: 0x00557078
	public IReadOnlyList<RoleTowerLevelGroup> GetRankGroupCfgList()
	{
		List<RoleTowerLevelGroup> list = new List<RoleTowerLevelGroup>();
		foreach (RoleTowerLevelGroup item in this.GetGroupCfgList())
		{
			if (item.Type == 2)
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x0601229E RID: 74398 RVA: 0x00558ED8 File Offset: 0x005570D8
	public int GetGroupFirstMainRoleId(int groupId)
	{
		IReadOnlyList<RoleTowerLevel> levelCfgListByGroup = this.GetLevelCfgListByGroup(groupId);
		if (levelCfgListByGroup.Count <= 0)
		{
			return 0;
		}
		return levelCfgListByGroup[0].MainRoleId;
	}

	// Token: 0x0601229F RID: 74399 RVA: 0x00558F08 File Offset: 0x00557108
	public IReadOnlyList<RoleTowerLevel> GetRankLevelCfgList()
	{
		List<RoleTowerLevel> list = new List<RoleTowerLevel>();
		foreach (RoleTowerLevelGroup roleTowerLevelGroup in this.GetRankGroupCfgList())
		{
			list.AddRange(this.GetLevelCfgListByGroup(roleTowerLevelGroup.Id));
		}
		return list;
	}

	// Token: 0x060122A0 RID: 74400 RVA: 0x00558F68 File Offset: 0x00557168
	[NullableContext(2)]
	public RoleTowerLevelData GetLevelState(int id)
	{
		RoleTowerLevelData result;
		if (!this.LevelStateMap.TryGetValue(id, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x060122A1 RID: 74401 RVA: 0x00558F88 File Offset: 0x00557188
	[NullableContext(2)]
	public string GetSaveFloorName(int levelId)
	{
		RoleTowerLevelData levelState = this.GetLevelState(levelId);
		if (levelState == null || !levelState.HasSave || levelState.SaveStageSeq <= 0)
		{
			return null;
		}
		if (this.GetStageFirstFloor(levelId, levelState.SaveStageSeq) == null)
		{
			return null;
		}
		RoleTowerFloor? roleTowerFloor;
		return roleTowerFloor.GetValueOrDefault().FloorName;
	}

	// Token: 0x060122A2 RID: 74402 RVA: 0x00558FDC File Offset: 0x005571DC
	public int GetCurStageFirstFloorIndex()
	{
		int curSelectLevel = this.CurSelectLevel;
		int stageSeqById = this.GetStageSeqById(this.GetChallengeableStageId(curSelectLevel));
		if (stageSeqById <= 0)
		{
			return 0;
		}
		if (this.GetStageFirstFloor(curSelectLevel, stageSeqById) == null)
		{
			return 0;
		}
		RoleTowerFloor? roleTowerFloor;
		return roleTowerFloor.GetValueOrDefault().FloorIndex;
	}

	// Token: 0x060122A3 RID: 74403 RVA: 0x00559028 File Offset: 0x00557228
	private RoleTowerFloor? GetStageFirstFloor(int levelId, int stageSeq)
	{
		IReadOnlyList<RoleTowerFloor> floorCfgListByStage = this.GetFloorCfgListByStage(levelId, stageSeq);
		if (floorCfgListByStage.Count == 0)
		{
			return null;
		}
		RoleTowerFloor value = floorCfgListByStage[0];
		foreach (RoleTowerFloor roleTowerFloor in floorCfgListByStage)
		{
			if (roleTowerFloor.FloorIndex < value.FloorIndex)
			{
				value = roleTowerFloor;
			}
		}
		return new RoleTowerFloor?(value);
	}

	// Token: 0x060122A4 RID: 74404 RVA: 0x005590A8 File Offset: 0x005572A8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, RoleTowerStageData> GetStageStateBucket()
	{
		if (this.IsUseInDungeonState(this.CurSelectLevelId))
		{
			return this.InDungeonStageStateMap;
		}
		Dictionary<int, RoleTowerStageData> result;
		if (!this.StageStateMap.TryGetValue(this.CurSelectLevelId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x060122A5 RID: 74405 RVA: 0x005590E2 File Offset: 0x005572E2
	private bool IsUseInDungeonState(int levelId)
	{
		return levelId > 0 && this.InDungeonLevelId == levelId && this.InDungeonStageStateMap.Count > 0 && this.IsInRoleTowerDungeon();
	}

	// Token: 0x060122A6 RID: 74406 RVA: 0x00559107 File Offset: 0x00557307
	private void ClearInDungeonState()
	{
		this.InDungeonLevelId = 0;
		this.InDungeonStageStateMap.Clear();
		this.InDungeonFloorStateMap.Clear();
	}

	// Token: 0x060122A7 RID: 74407 RVA: 0x00559128 File Offset: 0x00557328
	private void SeedInDungeonStateFromSave(int levelId)
	{
		Dictionary<int, RoleTowerStageData> dictionary;
		if (!this.StageStateMap.TryGetValue(levelId, out dictionary) || dictionary.Count == 0)
		{
			return;
		}
		this.ClearInDungeonState();
		this.InDungeonLevelId = levelId;
		foreach (KeyValuePair<int, RoleTowerStageData> keyValuePair in dictionary)
		{
			this.InDungeonStageStateMap[keyValuePair.Key] = keyValuePair.Value;
		}
		Dictionary<int, RoleTowerFloorData> dictionary2;
		if (this.FloorStateMap.TryGetValue(levelId, out dictionary2))
		{
			foreach (KeyValuePair<int, RoleTowerFloorData> keyValuePair2 in dictionary2)
			{
				this.InDungeonFloorStateMap[keyValuePair2.Key] = keyValuePair2.Value;
			}
		}
	}

	// Token: 0x060122A8 RID: 74408 RVA: 0x00559210 File Offset: 0x00557410
	private Dictionary<int, RoleTowerStageData> GetOrCreateStageStateBucket(int levelId)
	{
		Dictionary<int, RoleTowerStageData> dictionary;
		if (!this.StageStateMap.TryGetValue(levelId, out dictionary))
		{
			dictionary = new Dictionary<int, RoleTowerStageData>();
			this.StageStateMap[levelId] = dictionary;
		}
		return dictionary;
	}

	// Token: 0x060122A9 RID: 74409 RVA: 0x00559244 File Offset: 0x00557444
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, RoleTowerFloorData> GetFloorStateBucket()
	{
		if (this.IsUseInDungeonState(this.CurSelectLevelId))
		{
			return this.InDungeonFloorStateMap;
		}
		Dictionary<int, RoleTowerFloorData> result;
		if (!this.FloorStateMap.TryGetValue(this.CurSelectLevelId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x060122AA RID: 74410 RVA: 0x00559280 File Offset: 0x00557480
	private Dictionary<int, RoleTowerFloorData> GetOrCreateFloorStateBucket(int levelId)
	{
		Dictionary<int, RoleTowerFloorData> dictionary;
		if (!this.FloorStateMap.TryGetValue(levelId, out dictionary))
		{
			dictionary = new Dictionary<int, RoleTowerFloorData>();
			this.FloorStateMap[levelId] = dictionary;
		}
		return dictionary;
	}

	// Token: 0x060122AB RID: 74411 RVA: 0x005592B4 File Offset: 0x005574B4
	[NullableContext(2)]
	public RoleTowerFloorData GetFloorState(int id)
	{
		Dictionary<int, RoleTowerFloorData> floorStateBucket = this.GetFloorStateBucket();
		RoleTowerFloorData result;
		if (floorStateBucket == null || !floorStateBucket.TryGetValue(id, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x060122AC RID: 74412 RVA: 0x005592DC File Offset: 0x005574DC
	[NullableContext(2)]
	public RoleTowerStageData GetStageState(int stageId)
	{
		Dictionary<int, RoleTowerStageData> stageStateBucket = this.GetStageStateBucket();
		RoleTowerStageData roleTowerStageData;
		RoleTowerStageData state = (stageStateBucket != null && stageStateBucket.TryGetValue(stageId, out roleTowerStageData)) ? roleTowerStageData : this.AggregateStageState(stageId);
		return this.CorrectStageStateInDungeon(stageId, state);
	}

	// Token: 0x060122AD RID: 74413 RVA: 0x00559314 File Offset: 0x00557514
	[NullableContext(2)]
	private RoleTowerStageData CorrectStageStateInDungeon(int stageId, RoleTowerStageData state)
	{
		if (!this.IsInRoleTowerDungeon() || this.ActiveStageId <= 0 || this.ActiveChallengeId != this.CurSelectLevelId)
		{
			return state;
		}
		int stageSeqById = this.GetStageSeqById(stageId);
		int stageSeqById2 = this.GetStageSeqById(this.ActiveStageId);
		if (stageSeqById <= 0 || stageSeqById2 <= 0 || stageSeqById > stageSeqById2)
		{
			return state;
		}
		bool flag = stageId == this.ActiveStageId;
		bool flag2 = !flag;
		if (state != null && state.IsCurrent == flag && state.IsPassed == flag2)
		{
			return state;
		}
		RoleTowerStageData roleTowerStageData = new RoleTowerStageData
		{
			Id = stageId,
			IsPassed = flag2,
			IsCurrent = flag,
			TimeDeltaSum = ((state != null) ? state.TimeDeltaSum : 0L),
			PassRemainTime = ((state != null) ? state.PassRemainTime : 0L)
		};
		if (state != null)
		{
			roleTowerStageData.PassTeamRoleIds.AddRange(state.PassTeamRoleIds);
			roleTowerStageData.RoleSnapshots.AddRange(state.RoleSnapshots);
		}
		return roleTowerStageData;
	}

	// Token: 0x060122AE RID: 74414 RVA: 0x005593F8 File Offset: 0x005575F8
	public int GetCurrentStageSeq(int levelId)
	{
		if (levelId <= 0 || this.CurProgressLevelId != levelId)
		{
			return 0;
		}
		Dictionary<int, RoleTowerStageData> dictionary = this.IsUseInDungeonState(levelId) ? this.InDungeonStageStateMap : null;
		if (dictionary == null && !this.StageStateMap.TryGetValue(levelId, out dictionary))
		{
			return 0;
		}
		foreach (RoleTowerStageData roleTowerStageData in dictionary.Values)
		{
			if (roleTowerStageData.IsCurrent)
			{
				return this.GetStageSeqById(roleTowerStageData.Id);
			}
		}
		return 0;
	}

	// Token: 0x060122AF RID: 74415 RVA: 0x00559498 File Offset: 0x00557698
	public bool TryGetCurrentEchoLevel(int levelId, out int echoLevel)
	{
		echoLevel = 0;
		if (levelId <= 0 || this.CurProgressLevelId != levelId || !this.HasEchoLevel)
		{
			return false;
		}
		echoLevel = this.CurEchoLevel;
		return true;
	}

	// Token: 0x060122B0 RID: 74416 RVA: 0x005594C0 File Offset: 0x005576C0
	[NullableContext(2)]
	private RoleTowerStageData AggregateStageState(int stageId)
	{
		if (this.GetStageCfg(stageId) == null)
		{
			return null;
		}
		int stageSeqById = this.GetStageSeqById(stageId);
		IReadOnlyList<RoleTowerFloor> floorCfgListByStage = this.GetFloorCfgListByStage(this.CurSelectLevelId, stageSeqById);
		if (floorCfgListByStage.Count == 0)
		{
			return null;
		}
		RoleTowerStageData roleTowerStageData = new RoleTowerStageData
		{
			Id = stageId
		};
		bool isPassed = true;
		long num = 0L;
		foreach (RoleTowerFloor roleTowerFloor in floorCfgListByStage)
		{
			RoleTowerFloorData floorState = this.GetFloorState(roleTowerFloor.Id);
			if (floorState == null || !floorState.IsPassed)
			{
				isPassed = false;
			}
			if (floorState != null && floorState.IsCurrent)
			{
				roleTowerStageData.IsCurrent = true;
			}
			num += ((floorState != null) ? floorState.TimeDeltaSum : 0L);
		}
		roleTowerStageData.IsPassed = isPassed;
		roleTowerStageData.TimeDeltaSum = num;
		if (!roleTowerStageData.IsPassed && !roleTowerStageData.IsCurrent && stageSeqById == 1)
		{
			roleTowerStageData.IsCurrent = true;
		}
		return roleTowerStageData;
	}

	// Token: 0x060122B1 RID: 74417 RVA: 0x005595C4 File Offset: 0x005577C4
	public int GetStageSeqById(int stageId)
	{
		if (this.GetStageCfg(stageId) == null)
		{
			return 0;
		}
		RoleTowerStage? roleTowerStage;
		return roleTowerStage.GetValueOrDefault().Stage;
	}

	// Token: 0x060122B2 RID: 74418 RVA: 0x005595F4 File Offset: 0x005577F4
	public int GetLevelTotalFloorCount(int levelId)
	{
		HashSet<ValueTuple<int, int>> hashSet = new HashSet<ValueTuple<int, int>>();
		foreach (RoleTowerFloor roleTowerFloor in this.GetFloorCfgListByLevel(levelId))
		{
			int floorStageSeq = RoleTowerConfig.Instance.GetFloorStageSeq(roleTowerFloor.Id);
			hashSet.Add(new ValueTuple<int, int>(floorStageSeq, roleTowerFloor.FloorIndex));
		}
		return hashSet.Count;
	}

	// Token: 0x060122B3 RID: 74419 RVA: 0x00559670 File Offset: 0x00557870
	public int GetNextStarUpFloorIndex()
	{
		if (this.GetCurBattleFloorId() > 0)
		{
			RoleTowerFloor? floorCfg = this.GetFloorCfg(this.GetCurBattleFloorId());
			if (floorCfg != null)
			{
				if (this.GetStageCfg(floorCfg.Value.Stage) == null)
				{
					return 0;
				}
				RoleTowerStage? roleTowerStage;
				return roleTowerStage.GetValueOrDefault().NextStarDes;
			}
		}
		return 0;
	}

	// Token: 0x060122B4 RID: 74420 RVA: 0x005596D0 File Offset: 0x005578D0
	[NullableContext(2)]
	public string GetNextStarUpStageName()
	{
		if (this.GetStageCfgInLevel(this.CurSelectLevel, this.GetNextStarUpFloorIndex()) == null)
		{
			return null;
		}
		RoleTowerStage? roleTowerStage;
		return roleTowerStage.GetValueOrDefault().RoleTowerStageName;
	}

	// Token: 0x060122B5 RID: 74421 RVA: 0x0055970C File Offset: 0x0055790C
	public int GetCurrentFloorIndex()
	{
		int curBattleFloorId = this.GetCurBattleFloorId();
		RoleTowerFloor? roleTowerFloor = (curBattleFloorId > 0) ? this.GetFloorCfg(curBattleFloorId) : null;
		int num = (this.IsInRoleTowerDungeon() && this.ActiveStageId > 0) ? this.GetStageSeqById(this.ActiveStageId) : 0;
		if (roleTowerFloor != null && (num <= 0 || RoleTowerConfig.Instance.GetFloorStageSeq(roleTowerFloor.Value.Id) == num))
		{
			return roleTowerFloor.Value.FloorIndex;
		}
		if (num <= 0)
		{
			return 0;
		}
		return this.GuessActiveStageFloorIndex(this.ActiveChallengeId, num);
	}

	// Token: 0x060122B6 RID: 74422 RVA: 0x005597A8 File Offset: 0x005579A8
	private int GuessActiveStageFloorIndex(int levelId, int stageSeq)
	{
		int num = 0;
		foreach (RoleTowerWaveRecordData roleTowerWaveRecordData in this.BattleWaveRecords)
		{
			RoleTowerFloor? floorCfg = this.GetFloorCfg(roleTowerWaveRecordData.FloorId);
			if (floorCfg != null && RoleTowerConfig.Instance.GetFloorStageSeq(roleTowerWaveRecordData.FloorId) == stageSeq)
			{
				num = Math.Max(num, floorCfg.Value.FloorIndex);
			}
		}
		int num2 = 0;
		foreach (RoleTowerFloor roleTowerFloor in this.GetFloorCfgListByStage(levelId, stageSeq))
		{
			if (roleTowerFloor.FloorIndex > num && (num2 == 0 || roleTowerFloor.FloorIndex < num2))
			{
				num2 = roleTowerFloor.FloorIndex;
			}
		}
		if (num2 <= 0)
		{
			return num;
		}
		return num2;
	}

	// Token: 0x060122B7 RID: 74423 RVA: 0x0055989C File Offset: 0x00557A9C
	[NullableContext(2)]
	public RoleTowerWaveData GetWaveState(int id)
	{
		RoleTowerWaveData result;
		if (!this.WaveStateMap.TryGetValue(id, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x060122B8 RID: 74424 RVA: 0x005598BC File Offset: 0x00557ABC
	public IReadOnlyList<RoleTowerWaveRecordData> GetBattleWaveRecords()
	{
		return this.BattleWaveRecords;
	}

	// Token: 0x060122B9 RID: 74425 RVA: 0x005598C4 File Offset: 0x00557AC4
	public long GetLastTimeDelta()
	{
		return this.LastTimeDelta;
	}

	// Token: 0x060122BA RID: 74426 RVA: 0x005598CC File Offset: 0x00557ACC
	[NullableContext(2)]
	public RoleTowerTokenData GetTokenState(int id)
	{
		RoleTowerTokenData result;
		if (!this.TokenStateMap.TryGetValue(id, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x060122BB RID: 74427 RVA: 0x005598EC File Offset: 0x00557AEC
	public int GetItemCount(int itemId)
	{
		int result;
		if (!this.ItemCountMap.TryGetValue(itemId, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x060122BC RID: 74428 RVA: 0x0055990C File Offset: 0x00557B0C
	public int GetTokenCount(int tokenId)
	{
		if (this.IsCheckPointOpen)
		{
			int result;
			if (!this.CheckPointTokenCounts.TryGetValue(tokenId, out result))
			{
				return 0;
			}
			return result;
		}
		else if (this.IsOutOfBattleNoSave())
		{
			int result2;
			if (!this.TryGetInitTokenDictCount(tokenId, out result2))
			{
				return 0;
			}
			return result2;
		}
		else if (!this.InBattle)
		{
			RoleTowerSaveData roleTowerSaveData;
			int result3;
			if (!this.SaveDataMap.TryGetValue(this.CurSelectLevel, out roleTowerSaveData) || !roleTowerSaveData.InitialTokens.TryGetValue(tokenId, out result3))
			{
				return 0;
			}
			return result3;
		}
		else
		{
			RoleTowerTokenData tokenState = this.GetTokenState(tokenId);
			if (tokenState == null)
			{
				return 0;
			}
			return tokenState.RemainCount;
		}
	}

	// Token: 0x060122BD RID: 74429 RVA: 0x00559990 File Offset: 0x00557B90
	private bool TryGetInitTokenDictCount(int tokenId, out int count)
	{
		count = 0;
		if (this.CurSelectLevel <= 0)
		{
			return false;
		}
		RoleTowerLevel? levelCfg = this.GetLevelCfg(this.CurSelectLevel);
		if (levelCfg == null)
		{
			return false;
		}
		RoleTowerLevel value = levelCfg.Value;
		for (int i = 0; i < value.InitTokenDictLength; i++)
		{
			DicIntInt? dicIntInt = value.InitTokenDict(i);
			if (dicIntInt != null && dicIntInt.Value.Key == tokenId)
			{
				count = dicIntInt.Value.Value;
				return true;
			}
		}
		return false;
	}

	// Token: 0x060122BE RID: 74430 RVA: 0x00559A18 File Offset: 0x00557C18
	[NullableContext(2)]
	public RoleTowerRewardData GetRewardState(int id)
	{
		RoleTowerRewardData result;
		if (!this.RewardStateMap.TryGetValue(id, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x060122BF RID: 74431 RVA: 0x00559A38 File Offset: 0x00557C38
	[NullableContext(2)]
	public RoleTowerScoreRewardData GetScoreRewardState(int id)
	{
		RoleTowerScoreRewardData result;
		if (!this.ScoreRewardStateMap.TryGetValue(id, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x060122C0 RID: 74432 RVA: 0x00559A58 File Offset: 0x00557C58
	public int[] GetCanReceiveRewardTaskIds(int tabId)
	{
		List<int> list = new List<int>();
		foreach (RoleTowerReward roleTowerReward in this.GetRewardCfgListByTab(tabId))
		{
			RoleTowerRewardData rewardState = this.GetRewardState(roleTowerReward.Id);
			if (rewardState != null && rewardState.State == ERoleTowerRewardState.CanReceive)
			{
				list.Add(roleTowerReward.Id);
			}
		}
		return list.ToArray();
	}

	// Token: 0x060122C1 RID: 74433 RVA: 0x00559AD8 File Offset: 0x00557CD8
	public int GetLastNotTakenScoreRewardIndex()
	{
		List<RoleTowerScoreReward> sortedScoreRewardCfgList = this.GetSortedScoreRewardCfgList();
		for (int i = sortedScoreRewardCfgList.Count - 1; i >= 0; i--)
		{
			RoleTowerScoreRewardData scoreRewardState = this.GetScoreRewardState(sortedScoreRewardCfgList[i].Id);
			if (scoreRewardState != null && scoreRewardState.State == ERoleTowerRewardState.CanReceive)
			{
				return i + 1;
			}
		}
		return 0;
	}

	// Token: 0x060122C2 RID: 74434 RVA: 0x00559B2C File Offset: 0x00557D2C
	public int[] GetCanReceiveScoreRewardIds()
	{
		List<int> list = new List<int>();
		foreach (RoleTowerScoreReward roleTowerScoreReward in this.GetScoreRewardCfgList())
		{
			RoleTowerScoreRewardData scoreRewardState = this.GetScoreRewardState(roleTowerScoreReward.Id);
			if (scoreRewardState != null && scoreRewardState.State == ERoleTowerRewardState.CanReceive)
			{
				list.Add(roleTowerScoreReward.Id);
			}
		}
		return list.ToArray();
	}

	// Token: 0x060122C3 RID: 74435 RVA: 0x00559BAC File Offset: 0x00557DAC
	public long GetDungeonRemainTime()
	{
		if (!this.TimerActive || this.TimerStartTime <= 0L || this.TimerDuration <= 0L)
		{
			return this.DungeonRemainTime;
		}
		long num = (long)Time.Instance.ServerCombatStopTime;
		long num2 = this.TimerStartTime + this.TimerDuration;
		long num3 = this.TimerPauseEndTime - this.TimerPauseStartTime;
		long num4 = (this.TimerPauseEndTime > num) ? (num2 + this.TimerChangeTime - this.TimerPauseStartTime) : (num2 + num3 - num);
		if (num4 <= 0L)
		{
			return 0L;
		}
		return num4;
	}

	// Token: 0x060122C4 RID: 74436 RVA: 0x00559C30 File Offset: 0x00557E30
	public bool IsDungeonTimePaused()
	{
		if (!this.TimerActive || this.TimerStartTime <= 0L || this.TimerDuration <= 0L)
		{
			return false;
		}
		long num = (long)Time.Instance.ServerCombatStopTime;
		return this.TimerPauseEndTime > num;
	}

	// Token: 0x060122C5 RID: 74437 RVA: 0x00559C70 File Offset: 0x00557E70
	public void TickDungeonTimer()
	{
	}

	// Token: 0x060122C6 RID: 74438 RVA: 0x00559C74 File Offset: 0x00557E74
	private unsafe void SetBattleTimer(RoleTowerTimerData timeData)
	{
		if (timeData == null)
		{
			global::Log.Instance.Info(ELogModule.Temp, ELogAuthor.LJQ, "[角色爬塔][计时] SetBattleTimer 收到空 timeData，忽略", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (timeData.StartTime <= 0L)
		{
			this.TimerActive = false;
			this.TimerStartTime = 0L;
			this.TimerDuration = timeData.Duration;
			this.TimerPauseStartTime = timeData.PauseStartTime;
			this.TimerPauseEndTime = timeData.PauseEndTime;
			this.TimerChangeTime = timeData.ChangeTime;
			this.DungeonRemainTime = timeData.Duration;
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "[角色爬塔][计时] SetBattleTimer 冻结(未正式开打)";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("startTime", timeData.StartTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("duration", timeData.Duration);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("pauseStartTime", timeData.PauseStartTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("pauseEndTime", timeData.PauseEndTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("changeTime", timeData.ChangeTime);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			return;
		}
		if (this.TimerActive && this.TimerStartTime == timeData.StartTime && this.TimerDuration == timeData.Duration && this.TimerPauseStartTime == timeData.PauseStartTime && this.TimerPauseEndTime == timeData.PauseEndTime && this.TimerChangeTime == timeData.ChangeTime)
		{
			return;
		}
		this.TimerActive = true;
		this.TimerStartTime = timeData.StartTime;
		this.TimerDuration = timeData.Duration;
		this.TimerPauseStartTime = timeData.PauseStartTime;
		this.TimerPauseEndTime = timeData.PauseEndTime;
		this.TimerChangeTime = timeData.ChangeTime;
		this.DungeonRemainTime = timeData.Duration;
		global::Log instance2 = global::Log.Instance;
		ELogModule module2 = ELogModule.Temp;
		ELogAuthor author2 = ELogAuthor.LJQ;
		string message2 = "[角色爬塔][计时] SetBattleTimer 起算";
		<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray6<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("startTime", timeData.StartTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("duration", timeData.Duration);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("pauseStartTime", timeData.PauseStartTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("pauseEndTime", timeData.PauseEndTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("changeTime", timeData.ChangeTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("nowServerCombat", (long)Time.Instance.ServerCombatStopTime);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 6));
	}

	// Token: 0x060122C7 RID: 74439 RVA: 0x00559F53 File Offset: 0x00558153
	private void ClearBattleTimer(long staticRemainMs)
	{
		this.TimerActive = false;
		this.TimerStartTime = 0L;
		this.TimerDuration = 0L;
		this.TimerPauseStartTime = 0L;
		this.TimerPauseEndTime = 0L;
		this.TimerChangeTime = 0L;
		this.DungeonRemainTime = staticRemainMs;
	}

	// Token: 0x060122C8 RID: 74440 RVA: 0x00559F8B File Offset: 0x0055818B
	public int GetCurTeamStar()
	{
		return this.CurTeamStar;
	}

	// Token: 0x060122C9 RID: 74441 RVA: 0x00559F93 File Offset: 0x00558193
	public int GetCurEchoLevel()
	{
		return this.CurEchoLevel;
	}

	// Token: 0x060122CA RID: 74442 RVA: 0x00559F9B File Offset: 0x0055819B
	public int GetCurEchoExp()
	{
		return this.CurEchoExp;
	}

	// Token: 0x060122CB RID: 74443 RVA: 0x00559FA3 File Offset: 0x005581A3
	public int GetLastSettleEchoOldLevel()
	{
		return this.LastSettleEchoOldLevel;
	}

	// Token: 0x060122CC RID: 74444 RVA: 0x00559FAB File Offset: 0x005581AB
	public int GetLastSettleEchoOldExp()
	{
		return this.LastSettleEchoOldExp;
	}

	// Token: 0x060122CD RID: 74445 RVA: 0x00559FB3 File Offset: 0x005581B3
	public int GetCurEchoSubPropExtraRate()
	{
		return this.GetEchoSubPropExtraRate(this.CurEchoLevel);
	}

	// Token: 0x060122CE RID: 74446 RVA: 0x00559FC4 File Offset: 0x005581C4
	private int GetEchoSubPropExtraRate(int level)
	{
		foreach (RoleTowerEchoLevel roleTowerEchoLevel in this.GetEchoLevelCfgList())
		{
			if (roleTowerEchoLevel.LevelIndex == level)
			{
				return roleTowerEchoLevel.SubPropExtraRate;
			}
		}
		return 0;
	}

	// Token: 0x060122CF RID: 74447 RVA: 0x0055A024 File Offset: 0x00558224
	public bool GetNeedStarUp()
	{
		return this.NeedStarUp;
	}

	// Token: 0x060122D0 RID: 74448 RVA: 0x0055A02C File Offset: 0x0055822C
	public int GetCurScore()
	{
		return this.CurScore;
	}

	// Token: 0x060122D1 RID: 74449 RVA: 0x0055A034 File Offset: 0x00558234
	public static int ToSourceRoleId(int roleId)
	{
		if (roleId < 100000)
		{
			return roleId;
		}
		TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(roleId);
		if (trialRoleConfig == null)
		{
			return roleId;
		}
		return trialRoleConfig.GetValueOrDefault().ParentId;
	}

	// Token: 0x060122D2 RID: 74450 RVA: 0x0055A074 File Offset: 0x00558274
	public int GetRoleFatigue(int roleId)
	{
		int num = RoleTowerModel.ToSourceRoleId(roleId);
		if (this.IsCheckPointOpen)
		{
			if (this.CheckPointUsesInitialFatigue)
			{
				return this.GetLevelConfigMaxEnergy(num);
			}
			int result;
			if (!this.CheckPointFatigueMap.TryGetValue(num, out result))
			{
				return 0;
			}
			return result;
		}
		else
		{
			if (this.IsOutOfBattleNoSave())
			{
				return this.GetLevelConfigMaxEnergy(num);
			}
			int result2;
			if (!this.FatigueMap.TryGetValue(num, out result2))
			{
				return 0;
			}
			return result2;
		}
	}

	// Token: 0x060122D3 RID: 74451 RVA: 0x0055A0D8 File Offset: 0x005582D8
	private int GetLevelConfigMaxEnergy(int roleId)
	{
		if (this.CurSelectLevel <= 0)
		{
			return 0;
		}
		RoleTowerLevel? levelCfg = this.GetLevelCfg(this.CurSelectLevel);
		if (levelCfg == null)
		{
			return 0;
		}
		RoleTowerLevel value = levelCfg.Value;
		for (int i = 0; i < value.MaxEnergyLength; i++)
		{
			DicIntInt? dicIntInt = value.MaxEnergy(i);
			if (dicIntInt != null && dicIntInt.Value.Key == roleId)
			{
				return dicIntInt.Value.Value;
			}
		}
		return value.DefaultMaxEnergy;
	}

	// Token: 0x060122D4 RID: 74452 RVA: 0x0055A160 File Offset: 0x00558360
	public IReadOnlyList<int> GetFormationRoleList(ERoleTowerSlotType slot, int levelId, ERoleTowerRoleZone zone)
	{
		List<int> list = new List<int>();
		RoleTowerLevel? levelCfg = this.GetLevelCfg(levelId);
		if (levelCfg == null)
		{
			return list;
		}
		RoleTowerLevel value = levelCfg.Value;
		bool flag = slot == ERoleTowerSlotType.Main;
		if (zone == ERoleTowerRoleZone.Trial)
		{
			if (flag)
			{
				if (value.TrialMainRoleId > 0)
				{
					list.Add(value.TrialMainRoleId);
				}
			}
			else
			{
				for (int i = 0; i < value.TrialAssistRoleIdsLength; i++)
				{
					int num = value.TrialAssistRoleIds(i);
					if (num > 0)
					{
						list.Add(num);
					}
				}
			}
			return list;
		}
		if (flag)
		{
			if (value.MainRoleId > 0 && this.IsRoleOwned(value.MainRoleId))
			{
				list.Add(value.MainRoleId);
			}
		}
		else
		{
			for (int j = 0; j < value.AssistRoleIdsLength; j++)
			{
				int num2 = value.AssistRoleIds(j);
				if (num2 > 0 && this.IsRoleOwned(num2))
				{
					list.Add(num2);
				}
			}
		}
		return list;
	}

	// Token: 0x060122D5 RID: 74453 RVA: 0x0055A248 File Offset: 0x00558448
	public bool IsRoleOwned(int roleId)
	{
		RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
		for (int i = 0; i < roleList.Length; i++)
		{
			if (roleList[i].GetRoleId() == roleId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060122D6 RID: 74454 RVA: 0x0055A27C File Offset: 0x0055847C
	public IReadOnlyList<RoleTowerRankData> GetFriendRankList(int levelId)
	{
		RoleTowerRankInfoCache roleTowerRankInfoCache;
		if (!this.RankCacheMap.TryGetValue(levelId, out roleTowerRankInfoCache))
		{
			return Array.Empty<RoleTowerRankData>();
		}
		return roleTowerRankInfoCache.FriendList;
	}

	// Token: 0x060122D7 RID: 74455 RVA: 0x0055A2AC File Offset: 0x005584AC
	[NullableContext(2)]
	public RoleTowerRankData GetSelfRank(int levelId)
	{
		RoleTowerRankInfoCache roleTowerRankInfoCache;
		if (!this.RankCacheMap.TryGetValue(levelId, out roleTowerRankInfoCache))
		{
			return null;
		}
		return roleTowerRankInfoCache.SelfServer;
	}

	// Token: 0x060122D8 RID: 74456 RVA: 0x0055A2D4 File Offset: 0x005584D4
	public long GetRankNextRefreshTime(int levelId)
	{
		RoleTowerRankInfoCache roleTowerRankInfoCache;
		if (!this.RankCacheMap.TryGetValue(levelId, out roleTowerRankInfoCache))
		{
			return 0L;
		}
		return roleTowerRankInfoCache.NextRefreshTime;
	}

	// Token: 0x060122D9 RID: 74457 RVA: 0x0055A2FA File Offset: 0x005584FA
	public long GetRankRewardSettleTime()
	{
		return this.RankRewardSettleTime;
	}

	// Token: 0x060122DA RID: 74458 RVA: 0x0055A304 File Offset: 0x00558504
	public bool GetRankCanGetServerReward(int levelId)
	{
		RoleTowerRankInfoCache roleTowerRankInfoCache;
		return this.RankCacheMap.TryGetValue(levelId, out roleTowerRankInfoCache) && roleTowerRankInfoCache.CanGetServerReward;
	}

	// Token: 0x060122DB RID: 74459 RVA: 0x0055A32C File Offset: 0x0055852C
	public IReadOnlyList<Aki.Protocol.RewardItem> GetRankServerPreviewRewards(int levelId)
	{
		RoleTowerRankInfoCache roleTowerRankInfoCache;
		if (!this.RankCacheMap.TryGetValue(levelId, out roleTowerRankInfoCache))
		{
			return Array.Empty<Aki.Protocol.RewardItem>();
		}
		return roleTowerRankInfoCache.PreviewRewards;
	}

	// Token: 0x060122DC RID: 74460 RVA: 0x0055A359 File Offset: 0x00558559
	[NullableContext(2)]
	public RoleTowerSettleData GetLastSettle()
	{
		return this.LastSettle;
	}

	// Token: 0x060122DD RID: 74461 RVA: 0x0055A361 File Offset: 0x00558561
	public IReadOnlyList<RoleTowerTokenCount> GetLastSettleGainTokens()
	{
		return this.LastSettleGainTokens;
	}

	// Token: 0x060122DE RID: 74462 RVA: 0x0055A369 File Offset: 0x00558569
	[NullableContext(2)]
	public RoleTowerSaveData GetCurChallengeSave()
	{
		return this.CurChallengeSave;
	}

	// Token: 0x060122DF RID: 74463 RVA: 0x0055A374 File Offset: 0x00558574
	public bool HasAnyRedDot()
	{
		foreach (RoleTowerReward roleTowerReward in this.GetRewardCfgList())
		{
			RoleTowerRewardData rewardState = this.GetRewardState(roleTowerReward.Id);
			if (rewardState != null && rewardState.State == ERoleTowerRewardState.CanReceive)
			{
				return true;
			}
		}
		using (Dictionary<int, RoleTowerScoreRewardData>.ValueCollection.Enumerator enumerator2 = this.ScoreRewardStateMap.Values.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				if (enumerator2.Current.State == ERoleTowerRewardState.CanReceive)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060122E0 RID: 74464 RVA: 0x0055A42C File Offset: 0x0055862C
	public bool HasAnyEquippableToken()
	{
		IReadOnlyList<RoleTowerToken> tokensByActivityId = RoleTowerConfig.Instance.GetTokensByActivityId(this.CurActivityId);
		if (tokensByActivityId == null)
		{
			return false;
		}
		foreach (RoleTowerToken roleTowerToken in tokensByActivityId)
		{
			if (this.CanEquipToken(roleTowerToken.Id))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060122E1 RID: 74465 RVA: 0x0055A49C File Offset: 0x0055869C
	public bool HasTokenRedDot()
	{
		if (this.TokenNewEntrySeen)
		{
			return false;
		}
		foreach (RoleTowerTokenData roleTowerTokenData in this.TokenStateMap.Values)
		{
			if (roleTowerTokenData != null && roleTowerTokenData.IsUnlocked && roleTowerTokenData.IsNew)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060122E2 RID: 74466 RVA: 0x0055A514 File Offset: 0x00558714
	public void ClearAllTokenNew()
	{
		bool flag = false;
		foreach (RoleTowerTokenData roleTowerTokenData in this.TokenStateMap.Values)
		{
			if (roleTowerTokenData != null && roleTowerTokenData.IsNew)
			{
				roleTowerTokenData.IsNew = false;
				flag = true;
			}
		}
		if (flag)
		{
			EventSystem.Instance.Emit<int>(EEventName.RoleTowerLevelUpdate, this.CurSelectStageId);
		}
	}

	// Token: 0x060122E3 RID: 74467 RVA: 0x0055A594 File Offset: 0x00558794
	private void MarkTokenAsNew(int tokenId, int count)
	{
		this.TokenNewEntrySeen = false;
		RoleTowerTokenData roleTowerTokenData;
		if (this.TokenStateMap.TryGetValue(tokenId, out roleTowerTokenData) && roleTowerTokenData != null)
		{
			roleTowerTokenData.IsNew = true;
			roleTowerTokenData.IsUnlocked = true;
			if (count > 0)
			{
				roleTowerTokenData.RemainCount = count;
			}
			return;
		}
		this.TokenStateMap[tokenId] = new RoleTowerTokenData
		{
			Id = tokenId,
			IsUnlocked = true,
			IsNew = true,
			RemainCount = count
		};
	}

	// Token: 0x060122E4 RID: 74468 RVA: 0x0055A604 File Offset: 0x00558804
	public bool IsAllRewardReceived()
	{
		if (this.RewardStateMap.Count == 0 && this.ScoreRewardStateMap.Count == 0)
		{
			return false;
		}
		using (Dictionary<int, RoleTowerRewardData>.ValueCollection.Enumerator enumerator = this.RewardStateMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.State != ERoleTowerRewardState.Received)
				{
					return false;
				}
			}
		}
		using (Dictionary<int, RoleTowerScoreRewardData>.ValueCollection.Enumerator enumerator2 = this.ScoreRewardStateMap.Values.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				if (enumerator2.Current.State != ERoleTowerRewardState.Received)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x17001B65 RID: 7013
	// (get) Token: 0x060122E5 RID: 74469 RVA: 0x0055A6CC File Offset: 0x005588CC
	// (set) Token: 0x060122E6 RID: 74470 RVA: 0x0055A6D4 File Offset: 0x005588D4
	public int CurSelectLevel
	{
		get
		{
			return this.CurSelectLevelId;
		}
		set
		{
			this.CurSelectLevelId = value;
		}
	}

	// Token: 0x17001B66 RID: 7014
	// (get) Token: 0x060122E7 RID: 74471 RVA: 0x0055A6DD File Offset: 0x005588DD
	// (set) Token: 0x060122E8 RID: 74472 RVA: 0x0055A6E5 File Offset: 0x005588E5
	public int CurSelectStage
	{
		get
		{
			return this.CurSelectStageId;
		}
		set
		{
			this.CurSelectStageId = value;
		}
	}

	// Token: 0x17001B67 RID: 7015
	// (get) Token: 0x060122E9 RID: 74473 RVA: 0x0055A6EE File Offset: 0x005588EE
	// (set) Token: 0x060122EA RID: 74474 RVA: 0x0055A6F6 File Offset: 0x005588F6
	public int CurSelectFloor
	{
		get
		{
			return this.CurSelectFloorId;
		}
		set
		{
			this.CurSelectFloorId = value;
		}
	}

	// Token: 0x17001B68 RID: 7016
	// (get) Token: 0x060122EB RID: 74475 RVA: 0x0055A6FF File Offset: 0x005588FF
	// (set) Token: 0x060122EC RID: 74476 RVA: 0x0055A707 File Offset: 0x00558907
	public int CurSelectToken
	{
		get
		{
			return this.CurSelectTokenId;
		}
		set
		{
			this.CurSelectTokenId = value;
		}
	}

	// Token: 0x17001B69 RID: 7017
	// (get) Token: 0x060122ED RID: 74477 RVA: 0x0055A710 File Offset: 0x00558910
	// (set) Token: 0x060122EE RID: 74478 RVA: 0x0055A718 File Offset: 0x00558918
	public ERoleTowerTeamTab TeamTab
	{
		get
		{
			return this.CurTeamTab;
		}
		set
		{
			this.CurTeamTab = value;
		}
	}

	// Token: 0x17001B6A RID: 7018
	// (get) Token: 0x060122EF RID: 74479 RVA: 0x0055A721 File Offset: 0x00558921
	public bool InBattle
	{
		get
		{
			return this.IsInBattle;
		}
	}

	// Token: 0x060122F0 RID: 74480 RVA: 0x0055A72C File Offset: 0x0055892C
	private int GetCurLevelPlayId()
	{
		int activeStageId = this.ActiveStageId;
		if (activeStageId <= 0)
		{
			return 0;
		}
		RoleTowerStage? stageById = RoleTowerConfig.Instance.GetStageById(activeStageId);
		if (stageById == null)
		{
			return 0;
		}
		int levelPlayId = stageById.Value.LevelPlayId;
		if (levelPlayId <= 0)
		{
			return 0;
		}
		return levelPlayId;
	}

	// Token: 0x060122F1 RID: 74481 RVA: 0x0055A774 File Offset: 0x00558974
	[NullableContext(0)]
	private T? GetTreeVar<T>([Nullable(1)] string varName) where T : struct
	{
		int curLevelPlayId = this.GetCurLevelPlayId();
		if (curLevelPlayId <= 0)
		{
			return null;
		}
		global::LevelPlayInfo levelPlayInfo = LevelPlayModel.Instance.GetLevelPlayInfo(curLevelPlayId);
		VarDefinePb varValue;
		if (levelPlayInfo == null)
		{
			varValue = null;
		}
		else
		{
			BaseBehaviorTree tree = levelPlayInfo.Tree;
			varValue = ((tree != null) ? tree.GetTreeVarByKey(varName) : null);
		}
		return RoleTowerModel.ConvertTreeVar<T>(varValue);
	}

	// Token: 0x060122F2 RID: 74482 RVA: 0x0055A7C0 File Offset: 0x005589C0
	public int GetCurBattleFloorId()
	{
		return this.GetDungeonTreeVar<int>("层ID").GetValueOrDefault();
	}

	// Token: 0x060122F3 RID: 74483 RVA: 0x0055A7E0 File Offset: 0x005589E0
	[NullableContext(0)]
	private T? GetDungeonTreeVar<T>([Nullable(1)] string varName) where T : struct
	{
		InstanceDungeonInfo instanceDungeonInfo = InstanceDungeonModel.Instance.GetInstanceDungeonInfo();
		BaseBehaviorTree baseBehaviorTree = (instanceDungeonInfo != null) ? instanceDungeonInfo.Tree : null;
		return RoleTowerModel.ConvertTreeVar<T>((baseBehaviorTree != null) ? baseBehaviorTree.GetTreeVarByKey(varName) : null);
	}

	// Token: 0x060122F4 RID: 74484 RVA: 0x0055A80C File Offset: 0x00558A0C
	[NullableContext(0)]
	private static T? ConvertTreeVar<T>([Nullable(2)] VarDefinePb varValue) where T : struct
	{
		if (varValue == null)
		{
			return null;
		}
		object obj;
		switch (varValue.VarType)
		{
		case 0:
			obj = varValue.Boolean;
			goto IL_63;
		case 1:
			obj = (int)MathUtils.Instance.LongToNumber(varValue.Int);
			goto IL_63;
		case 3:
			obj = varValue.Float;
			goto IL_63;
		}
		obj = null;
		IL_63:
		object obj2 = obj;
		if (obj2 == null)
		{
			return null;
		}
		return (T?)obj2;
	}

	// Token: 0x060122F5 RID: 74485 RVA: 0x0055A894 File Offset: 0x00558A94
	public bool IsCurBattleEliteBranch()
	{
		return this.GetTreeVar<bool>("是否为强敌分支层").GetValueOrDefault();
	}

	// Token: 0x060122F6 RID: 74486 RVA: 0x0055A8B4 File Offset: 0x00558AB4
	public bool IsInRoleTowerDungeon()
	{
		if (!GameModeController.Instance.IsInInstance())
		{
			return false;
		}
		int instanceId = CreatureModel.Instance.GetInstanceId();
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		return config != null && config.Value.InstSubType == 67;
	}

	// Token: 0x060122F7 RID: 74487 RVA: 0x0055A904 File Offset: 0x00558B04
	[NullableContext(2)]
	public void OpenActivityMainView(bool playIntro = false, TOpenViewCallBack finishCallback = null, Action introStartCallback = null)
	{
		this.PendingIntroStartCallback = (playIntro ? introStartCallback : null);
		UiManager.Instance.OpenView(EUiViewName.RoleTowerActivityView, playIntro, delegate(bool success, int viewId)
		{
			this.PendingIntroStartCallback = null;
			TOpenViewCallBack finishCallback2 = finishCallback;
			if (finishCallback2 == null)
			{
				return;
			}
			finishCallback2(success, viewId);
		});
	}

	// Token: 0x060122F8 RID: 74488 RVA: 0x0055A953 File Offset: 0x00558B53
	public void NotifyActivityIntroStart()
	{
		Action pendingIntroStartCallback = this.PendingIntroStartCallback;
		this.PendingIntroStartCallback = null;
		if (pendingIntroStartCallback == null)
		{
			return;
		}
		pendingIntroStartCallback();
	}

	// Token: 0x060122F9 RID: 74489 RVA: 0x0055A96C File Offset: 0x00558B6C
	public void OpenActivityLoadingView()
	{
		UiManager.Instance.OpenView(EUiViewName.RoleTowerLoadingView, null, null);
	}

	// Token: 0x060122FA RID: 74490 RVA: 0x0055A97F File Offset: 0x00558B7F
	public void OpenSaveExitConfirmView(bool stayInDungeon = false)
	{
		UiManager.Instance.OpenView(EUiViewName.RoleTowerSaveExitConfirm, stayInDungeon, null);
	}

	// Token: 0x060122FB RID: 74491 RVA: 0x0055A997 File Offset: 0x00558B97
	public void OpenTokenCodexView()
	{
		UiManager.Instance.OpenView(EUiViewName.RoleTowerTokenView, new RoleTowerTokenViewParams
		{
			Mode = ERoleTowerTokenViewMode.Codex
		}, null);
	}

	// Token: 0x060122FC RID: 74492 RVA: 0x0055A9B5 File Offset: 0x00558BB5
	public void OpenRewardView()
	{
		UiManager.Instance.OpenView(EUiViewName.RoleTowerRewardView, null, null);
	}

	// Token: 0x060122FD RID: 74493 RVA: 0x0055A9C8 File Offset: 0x00558BC8
	public void OpenRankView(int levelId)
	{
		UiManager.Instance.OpenView(EUiViewName.RoleTowerRankView, new RoleTowerRankViewParams
		{
			LevelId = levelId
		}, null);
	}

	// Token: 0x060122FE RID: 74494 RVA: 0x0055A9E6 File Offset: 0x00558BE6
	public void OpenRecordView(int levelId, bool isCurrentRecord = false)
	{
		UiManager.Instance.OpenView(EUiViewName.RoleTowerTimeRecordView, new RoleTowerTimeRecordViewParams
		{
			LevelId = levelId,
			IsCurrentRecord = isCurrentRecord
		}, null);
	}

	// Token: 0x060122FF RID: 74495 RVA: 0x0055AA0C File Offset: 0x00558C0C
	public List<RoleTowerStageRecordData> GetAllStageRecords()
	{
		List<RoleTowerStageRecordData> list = new List<RoleTowerStageRecordData>();
		List<int> list2 = new List<int>(this.BestRecordMap.Keys);
		list2.Sort();
		foreach (int key in list2)
		{
			RoleTowerBestRecordData roleTowerBestRecordData;
			if (this.BestRecordMap.TryGetValue(key, out roleTowerBestRecordData) && roleTowerBestRecordData != null)
			{
				list.AddRange(roleTowerBestRecordData.StageRecords);
			}
		}
		return list;
	}

	// Token: 0x06012300 RID: 74496 RVA: 0x0055AA90 File Offset: 0x00558C90
	public List<RoleTowerStageRecordData> GetStageRecordsForView(int levelId, bool isCurrentRecord = false)
	{
		List<RoleTowerStageRecordData> list = new List<RoleTowerStageRecordData>();
		RoleTowerBestRecordData lastSettleRecord;
		if (isCurrentRecord)
		{
			lastSettleRecord = this.LastSettleRecord;
		}
		else
		{
			this.BestRecordMap.TryGetValue(levelId, out lastSettleRecord);
		}
		Dictionary<int, RoleTowerFloorRecordData> dictionary = new Dictionary<int, RoleTowerFloorRecordData>();
		Dictionary<int, RoleTowerStageRecordData> dictionary2 = new Dictionary<int, RoleTowerStageRecordData>();
		if (lastSettleRecord != null)
		{
			foreach (RoleTowerStageRecordData roleTowerStageRecordData in lastSettleRecord.StageRecords)
			{
				dictionary2[roleTowerStageRecordData.StageId] = roleTowerStageRecordData;
				foreach (RoleTowerFloorRecordData roleTowerFloorRecordData in roleTowerStageRecordData.FloorRecords)
				{
					dictionary[roleTowerFloorRecordData.FloorId] = roleTowerFloorRecordData;
				}
			}
		}
		RoleTowerLevel? roleTowerLevel;
		long num = (long)((this.GetLevelCfg(levelId) != null) ? roleTowerLevel.GetValueOrDefault().InitTime : 0);
		SortedDictionary<int, RoleTowerFloor> sortedDictionary = new SortedDictionary<int, RoleTowerFloor>();
		foreach (RoleTowerFloor value in this.GetFloorCfgListByLevel(levelId))
		{
			int floorIndex = value.FloorIndex;
			RoleTowerFloor roleTowerFloor;
			if (!sortedDictionary.TryGetValue(floorIndex, out roleTowerFloor))
			{
				sortedDictionary[floorIndex] = value;
			}
			else if (dictionary.ContainsKey(value.Id) && !dictionary.ContainsKey(roleTowerFloor.Id))
			{
				sortedDictionary[floorIndex] = value;
			}
		}
		long num2 = num;
		bool flag = false;
		Dictionary<int, List<RoleTowerFloorRecordData>> dictionary3 = new Dictionary<int, List<RoleTowerFloorRecordData>>();
		foreach (KeyValuePair<int, RoleTowerFloor> keyValuePair in sortedDictionary)
		{
			RoleTowerFloor value2 = keyValuePair.Value;
			RoleTowerStage? roleTowerStage;
			int key = (this.GetStageCfgByFloor(value2.Id) != null) ? roleTowerStage.GetValueOrDefault().Id : 0;
			RoleTowerFloorRecordData roleTowerFloorRecordData2;
			bool flag2 = dictionary.TryGetValue(value2.Id, out roleTowerFloorRecordData2);
			RoleTowerFloorRecordData roleTowerFloorRecordData3 = new RoleTowerFloorRecordData
			{
				FloorId = value2.Id,
				CostTimeMs = (flag2 ? roleTowerFloorRecordData2.CostTimeMs : 0L),
				RemainTimeMs = (flag2 ? roleTowerFloorRecordData2.RemainTimeMs : 0L),
				IsPassed = flag2
			};
			if (flag || !flag2)
			{
				roleTowerFloorRecordData3.IsPlaceholder = true;
				flag = true;
			}
			else
			{
				roleTowerFloorRecordData3.DeltaTimeMs = roleTowerFloorRecordData2.RemainTimeMs - num2;
				num2 = roleTowerFloorRecordData2.RemainTimeMs;
			}
			List<RoleTowerFloorRecordData> list2;
			if (!dictionary3.TryGetValue(key, out list2))
			{
				list2 = new List<RoleTowerFloorRecordData>();
				dictionary3[key] = list2;
			}
			list2.Add(roleTowerFloorRecordData3);
		}
		IEnumerable<RoleTowerStage> stageCfgListByLevel = this.GetStageCfgListByLevel(levelId);
		HashSet<int> hashSet = new HashSet<int>();
		foreach (RoleTowerStage roleTowerStage2 in stageCfgListByLevel)
		{
			int id = roleTowerStage2.Id;
			hashSet.Add(id);
			RoleTowerStageRecordData roleTowerStageRecordData2;
			dictionary2.TryGetValue(id, out roleTowerStageRecordData2);
			List<RoleTowerFloorRecordData> list3;
			list.Add(new RoleTowerStageRecordData
			{
				StageId = id,
				RemainTimeMs = ((roleTowerStageRecordData2 != null) ? roleTowerStageRecordData2.RemainTimeMs : 0L),
				IsPassed = (roleTowerStageRecordData2 != null),
				RoleIds = ((roleTowerStageRecordData2 != null) ? new List<int>(roleTowerStageRecordData2.RoleIds) : new List<int>()),
				FloorRecords = (dictionary3.TryGetValue(id, out list3) ? list3 : new List<RoleTowerFloorRecordData>())
			});
		}
		foreach (KeyValuePair<int, List<RoleTowerFloorRecordData>> keyValuePair2 in dictionary3)
		{
			if (!hashSet.Contains(keyValuePair2.Key))
			{
				RoleTowerStageRecordData roleTowerStageRecordData3;
				RoleTowerStageRecordData roleTowerStageRecordData4;
				list.Add(new RoleTowerStageRecordData
				{
					StageId = keyValuePair2.Key,
					RemainTimeMs = (dictionary2.TryGetValue(keyValuePair2.Key, out roleTowerStageRecordData3) ? roleTowerStageRecordData3.RemainTimeMs : 0L),
					IsPassed = dictionary2.ContainsKey(keyValuePair2.Key),
					RoleIds = (dictionary2.TryGetValue(keyValuePair2.Key, out roleTowerStageRecordData4) ? new List<int>(roleTowerStageRecordData4.RoleIds) : new List<int>()),
					FloorRecords = keyValuePair2.Value
				});
			}
		}
		return list;
	}

	// Token: 0x06012301 RID: 74497 RVA: 0x0055AF48 File Offset: 0x00559148
	public void OpenLevelSelectView(int groupId)
	{
		ActivityRoleTowerData data = ActivityRoleTowerController.Instance.Data;
		if (data != null)
		{
			data.ReadNewLevelRedDot(ActivityRoleTowerData.ENewLevelRedDotDepth.RoleGroupButton);
		}
		UiManager.Instance.OpenView(EUiViewName.RoleTowerLevelSelectView, new RoleTowerLevelSelectViewParams
		{
			GroupId = groupId
		}, null);
	}

	// Token: 0x06012302 RID: 74498 RVA: 0x0055AF7C File Offset: 0x0055917C
	public void SelectLevel(int levelId)
	{
		this.CurSelectLevelId = levelId;
		EventSystem.Instance.Emit<int>(EEventName.RoleTowerLevelSelectUpdate, levelId);
	}

	// Token: 0x06012303 RID: 74499 RVA: 0x0055AF98 File Offset: 0x00559198
	public void OpenPrepareView(int levelId, bool isFromSave, bool isInPrepare = false, bool isCheckPoint = false)
	{
		if (!isInPrepare && !isCheckPoint)
		{
			this.ResetStageRetryState();
		}
		this.CurSelectLevelId = levelId;
		if (isFromSave)
		{
			RoleTowerSaveData roleTowerSaveData;
			this.CurChallengeSave = (this.SaveDataMap.TryGetValue(levelId, out roleTowerSaveData) ? roleTowerSaveData : null);
			if (this.CurChallengeSave != null)
			{
				this.RestoreFromSave(this.CurChallengeSave);
			}
		}
		else
		{
			this.CurChallengeSave = null;
			if (!isInPrepare && !isCheckPoint)
			{
				this.ClearFormationSelection();
				this.ApplyInitProgressFromParam();
			}
		}
		UiManager.Instance.OpenView(EUiViewName.RoleTowerPrepareView, new RoleTowerPrepareViewParams
		{
			LevelId = levelId,
			IsFromSave = isFromSave,
			IsInPrepare = isInPrepare,
			IsCheckPoint = isCheckPoint
		}, null);
	}

	// Token: 0x06012304 RID: 74500 RVA: 0x0055B038 File Offset: 0x00559238
	private void RestoreFromSave(RoleTowerSaveData save)
	{
		this.SlotRoleMap[ERoleTowerSlotType.Main] = save.MainRoleId;
		this.SlotTrialMap[ERoleTowerSlotType.Main] = save.IsMainTrial;
		ERoleTowerSlotType[] array = new ERoleTowerSlotType[]
		{
			ERoleTowerSlotType.Assist1,
			ERoleTowerSlotType.Assist2
		};
		for (int i = 0; i < array.Length; i++)
		{
			int value = (i < save.AssistRoleIds.Count) ? save.AssistRoleIds[i] : 0;
			this.SlotRoleMap[array[i]] = value;
			this.SlotTrialMap[array[i]] = false;
		}
		this.RemoveStaleMainRoleFromSlots();
		this.CurEquipTokenId = save.CarryTokenId;
		this.FatigueMap.Clear();
		foreach (KeyValuePair<int, int> keyValuePair in save.FatigueMap)
		{
			this.FatigueMap[keyValuePair.Key] = keyValuePair.Value;
		}
		this.RestoreProgressFromSave(save);
	}

	// Token: 0x06012305 RID: 74501 RVA: 0x0055B140 File Offset: 0x00559340
	private void RestoreProgressFromSave(RoleTowerSaveData save)
	{
		this.ApplyInitProgressFromParam();
		this.NeedStarUp = false;
		if (save.HasTeamStarInfo)
		{
			this.CurTeamStar = save.TeamStar;
		}
		if (save.HasEchoInfo)
		{
			this.CurEchoLevel = save.EchoLevel;
			this.CurEchoExp = save.EchoExp;
			this.LastSettleEchoOldLevel = this.CurEchoLevel;
			this.LastSettleEchoOldExp = this.CurEchoExp;
			this.StageStartEchoLevel = this.CurEchoLevel;
			this.StageStartEchoExp = this.CurEchoExp;
		}
	}

	// Token: 0x06012306 RID: 74502 RVA: 0x0055B1C0 File Offset: 0x005593C0
	private unsafe void RemoveStaleMainRoleFromSlots()
	{
		int valueOrDefault = RoleModel.Instance.GetCurSelectMainRoleId().GetValueOrDefault();
		foreach (ERoleTowerSlotType eroleTowerSlotType in new ERoleTowerSlotType[]
		{
			ERoleTowerSlotType.Main,
			ERoleTowerSlotType.Assist1,
			ERoleTowerSlotType.Assist2
		})
		{
			int slotRoleId = this.GetSlotRoleId(eroleTowerSlotType);
			if (slotRoleId > 0 && !this.GetSlotIsTrial(eroleTowerSlotType) && slotRoleId != valueOrDefault && RoleModel.Instance.IsMainRole(slotRoleId))
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Temp;
				ELogAuthor author = ELogAuthor.LJQ;
				string message = "RoleTower 存档主角属性与当前不一致，下阵";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("slot", eroleTowerSlotType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("saveRoleId", slotRoleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("curMainRoleId", valueOrDefault);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				this.SlotRoleMap[eroleTowerSlotType] = 0;
				this.SlotTrialMap[eroleTowerSlotType] = false;
			}
		}
	}

	// Token: 0x06012307 RID: 74503 RVA: 0x0055B2DC File Offset: 0x005594DC
	private void InitDefaultMainRoleByLevel(int levelId)
	{
		RoleTowerLevel? levelCfg = this.GetLevelCfg(levelId);
		if (levelCfg == null)
		{
			return;
		}
		RoleTowerLevel value = levelCfg.Value;
		if (value.MainRoleId > 0 && this.IsRoleOwned(value.MainRoleId))
		{
			this.SetSlotRole(ERoleTowerSlotType.Main, value.MainRoleId, false);
			return;
		}
		if (value.TrialMainRoleId > 0)
		{
			this.SetSlotRole(ERoleTowerSlotType.Main, value.TrialMainRoleId, true);
		}
	}

	// Token: 0x06012308 RID: 74504 RVA: 0x0055B345 File Offset: 0x00559545
	public void OpenMonsterDetailView(int stageId)
	{
		UiManager.Instance.OpenView(EUiViewName.RoleTowerMonsterDetailView, new RoleTowerMonsterDetailViewParams
		{
			StageId = stageId
		}, null);
	}

	// Token: 0x06012309 RID: 74505 RVA: 0x0055B363 File Offset: 0x00559563
	public int GetSelectBranchId()
	{
		return this.CurSelectBranchId;
	}

	// Token: 0x0601230A RID: 74506 RVA: 0x0055B36C File Offset: 0x0055956C
	public bool IsCurSelectEliteBranch()
	{
		RoleTowerPrepareSelection activeStageSelection = this.ActiveStageSelection;
		int num = (activeStageSelection != null) ? activeStageSelection.BranchIndex : 0;
		if (num <= 0)
		{
			num = this.CurSelectBranchId;
		}
		RoleTowerBranch? branchCfg = this.GetBranchCfg(num);
		return branchCfg != null && branchCfg.Value.Type == 1;
	}

	// Token: 0x0601230B RID: 74507 RVA: 0x0055B3BC File Offset: 0x005595BC
	public bool NeedBranchSelectInPrepare()
	{
		return this.CurNeedBranchSelect;
	}

	// Token: 0x0601230C RID: 74508 RVA: 0x0055B3C4 File Offset: 0x005595C4
	[return: TupleElementNames(new string[]
	{
		"branchId",
		"floorId"
	})]
	[return: Nullable(new byte[]
	{
		1,
		0
	})]
	public IReadOnlyList<ValueTuple<int, int>> GetCurBranchOptions()
	{
		List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
		RoleTowerFloorInfo roleTowerFloorInfo = this.IsCheckPointOpen ? this.CheckPointBranchFloorInfo : this.CurBranchFloorInfo;
		if (roleTowerFloorInfo == null)
		{
			return this.GetStageBranchOptionsByCfg(this.CurSelectLevelId, this.GetChallengeableStageId(this.CurSelectLevelId));
		}
		foreach (RoleTowerFloorBranchInfo roleTowerFloorBranchInfo in roleTowerFloorInfo.BranchInfos)
		{
			RoleTowerFloor? floorByBranch = RoleTowerConfig.Instance.GetFloorByBranch(roleTowerFloorBranchInfo.BranchIndex);
			list.Add(new ValueTuple<int, int>(roleTowerFloorBranchInfo.BranchIndex, (floorByBranch != null) ? floorByBranch.GetValueOrDefault().Id : 0));
		}
		return list;
	}

	// Token: 0x0601230D RID: 74509 RVA: 0x0055B484 File Offset: 0x00559684
	[return: TupleElementNames(new string[]
	{
		"branchId",
		"floorId"
	})]
	[return: Nullable(new byte[]
	{
		1,
		0
	})]
	public IReadOnlyList<ValueTuple<int, int>> GetStageBranchOptionsByCfg(int levelId, int stageId)
	{
		List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
		int stageSeqById = this.GetStageSeqById(stageId);
		if (stageSeqById <= 0)
		{
			return list;
		}
		foreach (RoleTowerFloor roleTowerFloor in this.GetFloorCfgListByStage(levelId, stageSeqById))
		{
			if (roleTowerFloor.Branch > 0)
			{
				list.Add(new ValueTuple<int, int>(roleTowerFloor.Branch, roleTowerFloor.Id));
			}
		}
		list.Sort(([TupleElementNames(new string[]
		{
			"branchId",
			"floorId"
		})] ValueTuple<int, int> a, [TupleElementNames(new string[]
		{
			"branchId",
			"floorId"
		})] ValueTuple<int, int> b) => a.Item1 - b.Item1);
		return list;
	}

	// Token: 0x0601230E RID: 74510 RVA: 0x0055B52C File Offset: 0x0055972C
	public void OpenBuffDetailView(int selectTokenId = 0)
	{
		UiManager.Instance.OpenView(EUiViewName.RoleTowerBuffDetailView, new RoleTowerBuffDetailViewParams
		{
			SelectTokenId = selectTokenId
		}, null);
	}

	// Token: 0x0601230F RID: 74511 RVA: 0x0055B54C File Offset: 0x0055974C
	[NullableContext(2)]
	public void OpenMonsterSelectView(int stageId, Action<int> onConfirm = null)
	{
		UiManager.Instance.OpenView(EUiViewName.RoleTowerMonsterSelectView, new RoleTowerMonsterSelectViewParams
		{
			StageId = stageId,
			OnConfirm = delegate(int branchId)
			{
				this.CurSelectBranchId = branchId;
				Action<int> onConfirm2 = onConfirm;
				if (onConfirm2 == null)
				{
					return;
				}
				onConfirm2(branchId);
			}
		}, null);
	}

	// Token: 0x06012310 RID: 74512 RVA: 0x0055B59B File Offset: 0x0055979B
	public void OpenStarEchoView(ERoleTowerStarEchoTab tab, bool useInitInstData = false)
	{
		UiManager.Instance.OpenView(EUiViewName.RoleTowerRolePropertyView, new RoleTowerRolePropertyViewParams
		{
			Tab = tab,
			RoleId = this.GetDefaultSelectSlotRoleId(),
			UseInitInstData = useInitInstData
		}, null);
	}

	// Token: 0x06012311 RID: 74513 RVA: 0x0055B5CC File Offset: 0x005597CC
	public int GetDefaultSelectSlotRoleId()
	{
		foreach (ERoleTowerSlotType slot in new ERoleTowerSlotType[]
		{
			ERoleTowerSlotType.Main,
			ERoleTowerSlotType.Assist1,
			ERoleTowerSlotType.Assist2
		})
		{
			int slotRoleId = this.GetSlotRoleId(slot);
			if (slotRoleId > 0)
			{
				return slotRoleId;
			}
		}
		return 0;
	}

	// Token: 0x06012312 RID: 74514 RVA: 0x0055B60C File Offset: 0x0055980C
	public IReadOnlyList<RoleTowerVisionItemData> GetRoleVisionList(int roleId)
	{
		List<RoleTowerVisionItemData> list = new List<RoleTowerVisionItemData>();
		if (roleId <= 0)
		{
			return list;
		}
		RoleDataBase roleDataBase = RoleModel.Instance.GetRoleDataById(roleId, true) ?? RoleModel.Instance.GetRoleDataByIdOrCreateDefault(roleId);
		RolePhantomData rolePhantomData = (roleDataBase != null) ? roleDataBase.GetPhantomData() : null;
		if (rolePhantomData == null)
		{
			return list;
		}
		Dictionary<int, PhantomDataBase> dataMap = rolePhantomData.GetDataMap();
		List<int> list2 = new List<int>(dataMap.Keys);
		list2.Sort();
		foreach (int num in list2)
		{
			PhantomDataBase phantomDataBase = dataMap[num];
			if (phantomDataBase != null)
			{
				int configId = phantomDataBase.GetConfigId(false);
				Aki.Config.PhantomItem? phantomItem;
				string iconPath = ((PhantomBattleConfig.Instance.GetPhantomItemById(configId) != null) ? phantomItem.GetValueOrDefault().Icon : null) ?? "";
				list.Add(new RoleTowerVisionItemData
				{
					VisionId = configId,
					IsMain = (num == 0),
					IconPath = iconPath,
					Level = phantomDataBase.GetPhantomLevel(),
					Cost = phantomDataBase.GetCost()
				});
			}
		}
		return list;
	}

	// Token: 0x06012313 RID: 74515 RVA: 0x0055B738 File Offset: 0x00559938
	[NullableContext(2)]
	public RoleDataBase GetRoleData(int roleId)
	{
		if (roleId <= 0)
		{
			return null;
		}
		return RoleModel.Instance.GetRoleDataById(roleId, true) ?? RoleModel.Instance.GetRoleDataByIdOrCreateDefault(roleId);
	}

	// Token: 0x06012314 RID: 74516 RVA: 0x0055B75B File Offset: 0x0055995B
	public void OpenVisionDetailView(int roleId, int selectSlot = 0)
	{
		UiManager.Instance.OpenView(EUiViewName.RoleTowerVisionDetailView, new RoleTowerVisionDetailViewParams
		{
			RoleId = roleId,
			SelectSlot = selectSlot
		}, null);
	}

	// Token: 0x06012315 RID: 74517 RVA: 0x0055B780 File Offset: 0x00559980
	public void OpenRoleAttributeDetailView(int roleId)
	{
		RoleDataBase roleData = this.GetRoleData(roleId);
		if (roleData == null)
		{
			return;
		}
		List<AttrListScrollData> showAttrList = roleData.GetShowAttrList();
		RolePropInfo queryRoleProp = this.GetQueryRoleProp(roleId);
		if (queryRoleProp != null)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (ArrayIntInt arrayIntInt in queryRoleProp.BaseProp)
			{
				dictionary[arrayIntInt.Key] = arrayIntInt.Value;
			}
			Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
			foreach (ArrayIntInt arrayIntInt2 in queryRoleProp.AddProp)
			{
				dictionary2[arrayIntInt2.Key] = arrayIntInt2.Value;
			}
			foreach (AttrListScrollData attrListScrollData in showAttrList)
			{
				if (attrListScrollData is RoleAttrListScrollData)
				{
					int num;
					attrListScrollData.BaseValue = (double)(dictionary.TryGetValue(attrListScrollData.Id, out num) ? num : 0);
					int num2;
					attrListScrollData.AddValue = (double)(dictionary2.TryGetValue(attrListScrollData.Id, out num2) ? num2 : 0);
				}
			}
		}
		UiManager.Instance.OpenView(EUiViewName.RoleTowerAttributeDetailView, showAttrList, null);
	}

	// Token: 0x06012316 RID: 74518 RVA: 0x0055B8F0 File Offset: 0x00559AF0
	public void OpenTokenEquipView(int floorId)
	{
		if (!this.TokenNewEntrySeen)
		{
			this.TokenNewEntrySeen = true;
			EventSystem.Instance.Emit<int>(EEventName.RoleTowerLevelUpdate, this.CurSelectStageId);
		}
		UiManager.Instance.OpenView(EUiViewName.RoleTowerTokenView, new RoleTowerTokenViewParams
		{
			Mode = ERoleTowerTokenViewMode.Equip,
			FloorId = floorId,
			JumpTokenId = this.CurEquipTokenId
		}, null);
	}

	// Token: 0x06012317 RID: 74519 RVA: 0x0055B951 File Offset: 0x00559B51
	public void SetEquipToken(int tokenId)
	{
		this.CurEquipTokenId = tokenId;
		EventSystem.Instance.Emit<int>(EEventName.RoleTowerLevelUpdate, this.CurSelectStageId);
	}

	// Token: 0x06012318 RID: 74520 RVA: 0x0055B970 File Offset: 0x00559B70
	public bool IsOutOfBattleNoSave()
	{
		if (this.InBattle)
		{
			return false;
		}
		RoleTowerLevelData levelState = this.GetLevelState(this.CurSelectLevel);
		return levelState == null || !levelState.HasSave;
	}

	// Token: 0x06012319 RID: 74521 RVA: 0x0055B9A4 File Offset: 0x00559BA4
	public bool CanEquipToken(int tokenId)
	{
		if (this.IsCheckPointOpen)
		{
			return this.GetTokenCount(tokenId) > 0;
		}
		if (this.IsOutOfBattleNoSave())
		{
			int num;
			return this.TryGetInitTokenDictCount(tokenId, out num);
		}
		return this.GetTokenCount(tokenId) > 0;
	}

	// Token: 0x0601231A RID: 74522 RVA: 0x0055B9E0 File Offset: 0x00559BE0
	private bool CanShowFormationDetailButton(int levelId)
	{
		RoleTowerSaveData curChallengeSave = this.GetCurChallengeSave();
		if (curChallengeSave != null && curChallengeSave.LevelId == levelId)
		{
			return false;
		}
		RoleTowerLevelData levelState = this.GetLevelState(levelId);
		return (levelState == null || !levelState.HasSave) && !GameModeController.Instance.IsInInstance();
	}

	// Token: 0x0601231B RID: 74523 RVA: 0x0055BA2C File Offset: 0x00559C2C
	public void OpenFormationView(ERoleTowerSlotType slot)
	{
		if (slot == ERoleTowerSlotType.Main)
		{
			this.OpenMainFormationView();
			return;
		}
		this.OpenAssistFormationView();
	}

	// Token: 0x0601231C RID: 74524 RVA: 0x0055BA40 File Offset: 0x00559C40
	private void OpenMainFormationView()
	{
		int curSelectLevelId = this.CurSelectLevelId;
		ERoleTowerSlotType slot = ERoleTowerSlotType.Main;
		HashSet<int> trialSet = new HashSet<int>(this.GetFormationRoleList(slot, curSelectLevelId, ERoleTowerRoleZone.Trial));
		List<MultiTeamRoleData> multiTeamRoleDataList = this.BuildFormationZones(slot, curSelectLevelId);
		int slotRoleId = this.GetSlotRoleId(slot);
		int[] array;
		if (slotRoleId <= 0)
		{
			array = Array.Empty<int>();
		}
		else
		{
			(array = new int[1])[0] = slotRoleId;
		}
		int[] initSelectRoleList = array;
		MultiTeamRoleSelectData multiTeamRoleSelectData = MultiTeamRoleSelectData.Phrase(new EFilterSortGroupId?(EFilterSortGroupId.EditFormation), 1, initSelectRoleList, null, null, delegate(int[] ids, int[] tags)
		{
			int num = (ids.Length != 0) ? ids[0] : 0;
			this.SetSlotRole(slot, num, trialSet.Contains(num));
		}, null, multiTeamRoleDataList, this.GetEquipLockedRoleIds(slot, curSelectLevelId), "RoleTowerWeaponEchoLockTips", "");
		RoleTowerModel.SetFormationUnRecommendBtn(multiTeamRoleSelectData);
		multiTeamRoleSelectData.IfCanSelectCheck = ((int roleId, int[] selected) => RoleTowerModel.CanSelectFormationRole(roleId, Array.Empty<int>(), new int[]
		{
			this.GetSlotRoleId(ERoleTowerSlotType.Assist1),
			this.GetSlotRoleId(ERoleTowerSlotType.Assist2)
		}));
		multiTeamRoleSelectData.IsSingleSelect = true;
		multiTeamRoleSelectData.ShowInitSelectRoleInfo = true;
		multiTeamRoleSelectData.ShowDetailButton = this.CanShowFormationDetailButton(curSelectLevelId);
		multiTeamRoleSelectData.SetMultiTeamTagData(MultiTeamTagDataItem.Phrase(new int[]
		{
			(slotRoleId > 0) ? RoleModel.Instance.GetRoleSkillBranchIdInGamePlay(slotRoleId, ESkillBranchCacheType.Mowing) : 0
		}, ESkillBranchCacheType.Mowing));
		UiManager.Instance.OpenView(EUiViewName.MultiTeamRoleSelectView, multiTeamRoleSelectData, null);
	}

	// Token: 0x0601231D RID: 74525 RVA: 0x0055BB60 File Offset: 0x00559D60
	private void OpenAssistFormationView()
	{
		int curSelectLevelId = this.CurSelectLevelId;
		HashSet<int> trialSet = new HashSet<int>(this.GetFormationRoleList(ERoleTowerSlotType.Assist1, curSelectLevelId, ERoleTowerRoleZone.Trial));
		List<MultiTeamRoleData> multiTeamRoleDataList = this.BuildFormationZones(ERoleTowerSlotType.Assist1, curSelectLevelId);
		int slotRoleId = this.GetSlotRoleId(ERoleTowerSlotType.Assist1);
		int slotRoleId2 = this.GetSlotRoleId(ERoleTowerSlotType.Assist2);
		int[] initSelectRoleList = new int[]
		{
			slotRoleId,
			slotRoleId2
		};
		MultiTeamRoleSelectData multiTeamRoleSelectData = MultiTeamRoleSelectData.Phrase(new EFilterSortGroupId?(EFilterSortGroupId.EditFormation), 2, initSelectRoleList, null, null, delegate(int[] ids, int[] tags)
		{
			int num = (ids.Length != 0) ? ids[0] : 0;
			int num2 = (ids.Length > 1) ? ids[1] : 0;
			this.SetSlotRole(ERoleTowerSlotType.Assist1, num, trialSet.Contains(num));
			this.SetSlotRole(ERoleTowerSlotType.Assist2, num2, trialSet.Contains(num2));
		}, null, multiTeamRoleDataList, this.GetEquipLockedRoleIds(ERoleTowerSlotType.Assist1, curSelectLevelId), "RoleTowerWeaponEchoLockTips", "");
		RoleTowerModel.SetFormationUnRecommendBtn(multiTeamRoleSelectData);
		multiTeamRoleSelectData.IfCanSelectCheck = ((int roleId, int[] selected) => RoleTowerModel.CanSelectFormationRole(roleId, selected, new int[]
		{
			this.GetSlotRoleId(ERoleTowerSlotType.Main)
		}));
		multiTeamRoleSelectData.ShowDetailButton = this.CanShowFormationDetailButton(curSelectLevelId);
		multiTeamRoleSelectData.ShowInitSelectRoleInfo = true;
		multiTeamRoleSelectData.SetMultiTeamTagData(MultiTeamTagDataItem.Phrase(new int[]
		{
			(slotRoleId > 0) ? RoleModel.Instance.GetRoleSkillBranchIdInGamePlay(slotRoleId, ESkillBranchCacheType.Mowing) : 0,
			(slotRoleId2 > 0) ? RoleModel.Instance.GetRoleSkillBranchIdInGamePlay(slotRoleId2, ESkillBranchCacheType.Mowing) : 0
		}, ESkillBranchCacheType.Mowing));
		UiManager.Instance.OpenView(EUiViewName.MultiTeamRoleSelectView, multiTeamRoleSelectData, null);
	}

	// Token: 0x0601231E RID: 74526 RVA: 0x0055BC78 File Offset: 0x00559E78
	private int[] GetEquipLockedRoleIds(ERoleTowerSlotType slot, int levelId)
	{
		List<int> list = new List<int>();
		foreach (int num in this.GetFormationRoleList(slot, levelId, ERoleTowerRoleZone.Owned))
		{
			if (this.IsRoleEquipLocked(num))
			{
				list.Add(num);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0601231F RID: 74527 RVA: 0x0055BCE0 File Offset: 0x00559EE0
	private static void SetFormationUnRecommendBtn(MultiTeamRoleSelectData data)
	{
		data.ShowUnRecommendBtn = false;
	}

	// Token: 0x06012320 RID: 74528 RVA: 0x0055BCEC File Offset: 0x00559EEC
	private static bool CanSelectFormationRole(int roleId, int[] selected, params int[] otherSlotRoleIds)
	{
		if (roleId <= 0 || Array.IndexOf<int>(selected, roleId) >= 0)
		{
			return true;
		}
		int baseRoleId = RoleConfig.Instance.GetBaseRoleId(roleId);
		if (RoleTowerModel.IsSameBaseRole(baseRoleId, selected) || RoleTowerModel.IsSameBaseRole(baseRoleId, otherSlotRoleIds))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_SameRole_Text", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x06012321 RID: 74529 RVA: 0x0055BD40 File Offset: 0x00559F40
	private static bool IsSameBaseRole(int baseId, int[] roleIds)
	{
		foreach (int num in roleIds)
		{
			if (num > 0 && RoleConfig.Instance.GetBaseRoleId(num) == baseId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06012322 RID: 74530 RVA: 0x0055BD78 File Offset: 0x00559F78
	private List<MultiTeamRoleData> BuildFormationZones(ERoleTowerSlotType slot, int levelId)
	{
		List<MultiTeamRoleData> list = new List<MultiTeamRoleData>();
		bool showCost = slot > ERoleTowerSlotType.Main;
		List<MultiTeamRoleGridData> list2 = this.BuildRoleGridList(this.GetFormationRoleList(slot, levelId, ERoleTowerRoleZone.Trial), showCost);
		if (list2.Count > 0)
		{
			MultiTeamRoleData multiTeamRoleData = MultiTeamRoleData.Phrase("RoleTowerFormationTrialZone", list2);
			this.SetupFatigueSink(multiTeamRoleData, showCost);
			list.Add(multiTeamRoleData);
		}
		List<MultiTeamRoleGridData> list3 = this.BuildRoleGridList(this.GetFormationRoleList(slot, levelId, ERoleTowerRoleZone.Owned), showCost);
		if (list3.Count > 0)
		{
			MultiTeamRoleData multiTeamRoleData2 = MultiTeamRoleData.Phrase("RoleTowerFormationOwnedZone", list3);
			this.SetupFatigueSink(multiTeamRoleData2, showCost);
			list.Add(multiTeamRoleData2);
		}
		return list;
	}

	// Token: 0x06012323 RID: 74531 RVA: 0x0055BE04 File Offset: 0x0055A004
	private void SetupFatigueSink(MultiTeamRoleData zone, bool showCost)
	{
		if (!showCost)
		{
			return;
		}
		int assist1 = this.GetSlotRoleId(ERoleTowerSlotType.Assist1);
		int assist2 = this.GetSlotRoleId(ERoleTowerSlotType.Assist2);
		zone.SetPromoteToTopPredicate(delegate(MultiTeamRoleGridData grid)
		{
			RoleDataBase role = grid.GetRole();
			int num = (role != null) ? role.GetRoleId() : 0;
			return num > 0 && (num == assist1 || num == assist2);
		});
		zone.SetSinkToBottomPredicate((MultiTeamRoleGridData grid) => grid.GetIsDisable());
	}

	// Token: 0x06012324 RID: 74532 RVA: 0x0055BE6C File Offset: 0x0055A06C
	private List<MultiTeamRoleGridData> BuildRoleGridList(IReadOnlyList<int> roleIds, bool showCost = false)
	{
		int num = showCost ? this.GetStageFatigueCost(this.GetChallengeableStageId(this.CurSelectLevelId)) : 0;
		List<MultiTeamRoleGridData> list = new List<MultiTeamRoleGridData>();
		foreach (int num2 in roleIds)
		{
			RoleDataBase roleDataBase = RoleModel.Instance.GetRoleDataById(num2, true) ?? RoleModel.Instance.GetRoleDataByIdOrCreateDefault(num2);
			if (roleDataBase == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Temp;
				ELogAuthor author = ELogAuthor.LJQ;
				string message = "RoleTower.OpenFormationView 角色数据缺失，跳过";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", num2);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				bool isDisable = num > 0 && this.GetRoleFatigue(num2) < num;
				MediumItemGridCostComponentData showCostData = showCost ? this.BuildAssistCostData(num2) : null;
				list.Add(MultiTeamRoleGridData.Phrase(roleDataBase, false, false, false, false, showCostData, isDisable, true, this.IsRoleEquipLocked(num2)));
			}
		}
		return list;
	}

	// Token: 0x06012325 RID: 74533 RVA: 0x0055BF68 File Offset: 0x0055A168
	[NullableContext(2)]
	private MediumItemGridCostComponentData BuildAssistCostData(int roleId)
	{
		int stageFatigueCost = this.GetStageFatigueCost(this.GetChallengeableStageId(this.CurSelectLevelId));
		if (stageFatigueCost <= 0)
		{
			return null;
		}
		int roleFatigue = this.GetRoleFatigue(roleId);
		return new MediumItemGridCostComponentData
		{
			Cost = roleFatigue,
			Color = ((roleFatigue >= stageFatigueCost) ? TowerData.highColor : TowerData.redColor).Value
		};
	}

	// Token: 0x06012326 RID: 74534 RVA: 0x0055BFC0 File Offset: 0x0055A1C0
	private void CollectEquipLockMap(Dictionary<int, int> weaponLockMap, Dictionary<int, int> phantomLockMap)
	{
		Dictionary<int, RoleTowerStageData> stageStateBucket = this.GetStageStateBucket();
		if (stageStateBucket == null)
		{
			return;
		}
		foreach (RoleTowerStageData roleTowerStageData in stageStateBucket.Values)
		{
			foreach (RoleTowerRoleSnapshotData roleTowerRoleSnapshotData in roleTowerStageData.RoleSnapshots)
			{
				if (roleTowerRoleSnapshotData.RoleId > 0 && !RoleUtils.IsTrialRole(roleTowerRoleSnapshotData.RoleId))
				{
					if (roleTowerRoleSnapshotData.WeaponIncId > 0)
					{
						weaponLockMap[roleTowerRoleSnapshotData.WeaponIncId] = roleTowerRoleSnapshotData.RoleId;
					}
					foreach (int num in roleTowerRoleSnapshotData.PhantomIncIds)
					{
						if (num > 0)
						{
							phantomLockMap[num] = roleTowerRoleSnapshotData.RoleId;
						}
					}
				}
			}
		}
	}

	// Token: 0x06012327 RID: 74535 RVA: 0x0055C0DC File Offset: 0x0055A2DC
	public bool IsRoleEquipLocked(int roleId)
	{
		if (roleId <= 0 || RoleUtils.IsTrialRole(roleId) || !RoleModel.Instance.IsHasRole(roleId))
		{
			return false;
		}
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
		this.CollectEquipLockMap(dictionary, dictionary2);
		if (dictionary.Count == 0 && dictionary2.Count == 0)
		{
			return false;
		}
		WeaponInstance weaponInstanceByRoleId = WeaponModel.Instance.GetWeaponInstanceByRoleId(roleId);
		int valueOrDefault = ((weaponInstanceByRoleId != null) ? weaponInstanceByRoleId.GetIncId() : null).GetValueOrDefault();
		int ownerId;
		if (valueOrDefault > 0 && dictionary.TryGetValue(valueOrDefault, out ownerId) && !RoleTowerModel.IsSameEquipOwner(ownerId, roleId))
		{
			return true;
		}
		foreach (int num in PhantomBattleModel.Instance.GetBattleDataById(roleId).GetIncrIdList())
		{
			int ownerId2;
			if (num > 0 && dictionary2.TryGetValue(num, out ownerId2) && !RoleTowerModel.IsSameEquipOwner(ownerId2, roleId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06012328 RID: 74536 RVA: 0x0055C1E0 File Offset: 0x0055A3E0
	private static bool IsSameEquipOwner(int ownerId, int roleId)
	{
		return ownerId == roleId || (RoleModel.Instance.IsMainRole(ownerId) && RoleModel.Instance.IsMainRole(roleId));
	}

	// Token: 0x06012329 RID: 74537 RVA: 0x0055C204 File Offset: 0x0055A404
	public bool IsTeamEquipLocked()
	{
		foreach (ERoleTowerSlotType slot in new ERoleTowerSlotType[]
		{
			ERoleTowerSlotType.Main,
			ERoleTowerSlotType.Assist1,
			ERoleTowerSlotType.Assist2
		})
		{
			if (!this.GetSlotIsTrial(slot) && this.IsRoleEquipLocked(this.GetSlotRoleId(slot)))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601232A RID: 74538 RVA: 0x0055C250 File Offset: 0x0055A450
	public int GetSlotRoleId(ERoleTowerSlotType slot)
	{
		int result;
		if (!this.SlotRoleMap.TryGetValue(slot, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x0601232B RID: 74539 RVA: 0x0055C270 File Offset: 0x0055A470
	public bool GetSlotIsTrial(ERoleTowerSlotType slot)
	{
		bool flag;
		return this.SlotTrialMap.TryGetValue(slot, out flag) && flag;
	}

	// Token: 0x0601232C RID: 74540 RVA: 0x0055C28D File Offset: 0x0055A48D
	public void SetSlotRole(ERoleTowerSlotType slot, int roleId, bool isTrial)
	{
		this.SlotRoleMap[slot] = roleId;
		this.SlotTrialMap[slot] = isTrial;
		EventSystem.Instance.Emit<int>(EEventName.RoleTowerLevelUpdate, this.CurSelectStageId);
	}

	// Token: 0x0601232D RID: 74541 RVA: 0x0055C2C0 File Offset: 0x0055A4C0
	public void FixMainRoleInSlots()
	{
		int valueOrDefault = RoleModel.Instance.GetCurSelectMainRoleId().GetValueOrDefault();
		ERoleTowerSlotType[] array = new ERoleTowerSlotType[]
		{
			ERoleTowerSlotType.Main,
			ERoleTowerSlotType.Assist1,
			ERoleTowerSlotType.Assist2
		};
		bool flag = false;
		foreach (ERoleTowerSlotType eroleTowerSlotType in array)
		{
			int slotRoleId = this.GetSlotRoleId(eroleTowerSlotType);
			if (slotRoleId > 0 && !this.GetSlotIsTrial(eroleTowerSlotType) && slotRoleId != valueOrDefault && RoleModel.Instance.IsMainRole(slotRoleId))
			{
				int num = valueOrDefault;
				if (num > 0)
				{
					bool flag2 = false;
					using (IEnumerator<int> enumerator = this.GetFormationRoleList(eroleTowerSlotType, this.CurSelectLevelId, ERoleTowerRoleZone.Owned).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current == num)
							{
								flag2 = true;
								break;
							}
						}
					}
					if (!flag2 || this.GetTeamRoleIds().Contains(num))
					{
						num = 0;
					}
				}
				this.SlotRoleMap[eroleTowerSlotType] = num;
				this.SlotTrialMap[eroleTowerSlotType] = false;
				flag = true;
			}
		}
		if (flag)
		{
			EventSystem.Instance.Emit<int>(EEventName.RoleTowerLevelUpdate, this.CurSelectStageId);
		}
	}

	// Token: 0x0601232E RID: 74542 RVA: 0x0055C3EC File Offset: 0x0055A5EC
	public List<int> GetTeamRoleIds()
	{
		List<int> list = new List<int>();
		foreach (ERoleTowerSlotType slot in new ERoleTowerSlotType[]
		{
			ERoleTowerSlotType.Main,
			ERoleTowerSlotType.Assist1,
			ERoleTowerSlotType.Assist2
		})
		{
			int slotRoleId = this.GetSlotRoleId(slot);
			if (slotRoleId > 0)
			{
				list.Add(slotRoleId);
			}
		}
		return list;
	}

	// Token: 0x0601232F RID: 74543 RVA: 0x0055C438 File Offset: 0x0055A638
	public List<RoleTowerRoleBrief> BuildRoleBriefList()
	{
		List<RoleTowerRoleBrief> list = new List<RoleTowerRoleBrief>();
		foreach (ERoleTowerSlotType slot in new ERoleTowerSlotType[]
		{
			ERoleTowerSlotType.Main,
			ERoleTowerSlotType.Assist1,
			ERoleTowerSlotType.Assist2
		})
		{
			int slotRoleId = this.GetSlotRoleId(slot);
			if (slotRoleId > 0)
			{
				RoleTowerRoleBrief roleTowerRoleBrief = RoleTowerRoleBrief.Create();
				roleTowerRoleBrief.RoleIdOrTrialRoleId = slotRoleId;
				roleTowerRoleBrief.SkillBranchId = RoleModel.Instance.GetRoleSkillBranchIdInGamePlay(slotRoleId, ESkillBranchCacheType.Mowing);
				list.Add(roleTowerRoleBrief);
			}
		}
		return list;
	}

	// Token: 0x06012330 RID: 74544 RVA: 0x0055C4A7 File Offset: 0x0055A6A7
	public RoleTowerPrepareStepPbData BuildPrepareStepData()
	{
		RoleTowerPrepareStepPbData roleTowerPrepareStepPbData = RoleTowerPrepareStepPbData.Create();
		roleTowerPrepareStepPbData.PrepareSelection = this.BuildPrepareSelection();
		return roleTowerPrepareStepPbData;
	}

	// Token: 0x06012331 RID: 74545 RVA: 0x0055C4BA File Offset: 0x0055A6BA
	public RoleTowerPrepareSelection BuildPrepareSelection()
	{
		RoleTowerPrepareSelection roleTowerPrepareSelection = RoleTowerPrepareSelection.Create();
		roleTowerPrepareSelection.Roles.AddRange(this.BuildRoleBriefList());
		roleTowerPrepareSelection.EquipTokenId = this.CurEquipTokenId;
		roleTowerPrepareSelection.BranchIndex = this.CurSelectBranchId;
		return roleTowerPrepareSelection;
	}

	// Token: 0x06012332 RID: 74546 RVA: 0x0055C4EA File Offset: 0x0055A6EA
	public int GetActiveStageId()
	{
		return this.ActiveStageId;
	}

	// Token: 0x06012333 RID: 74547 RVA: 0x0055C4F2 File Offset: 0x0055A6F2
	public int GetActiveChallengeId()
	{
		return this.ActiveChallengeId;
	}

	// Token: 0x06012334 RID: 74548 RVA: 0x0055C4FA File Offset: 0x0055A6FA
	public void ApplyBattleSelection(int challengeId, int stageId, RoleTowerPrepareSelection selection)
	{
		if (this.ActiveChallengeId != challengeId || this.ActiveStageId != stageId)
		{
			return;
		}
		this.ActiveStageSelection = selection.Clone();
	}

	// Token: 0x06012335 RID: 74549 RVA: 0x0055C51C File Offset: 0x0055A71C
	private void RestoreBattleSelectionForPrepare()
	{
		if (this.ActiveStageSelection == null)
		{
			return;
		}
		this.SlotRoleMap.Clear();
		this.SlotTrialMap.Clear();
		ERoleTowerSlotType[] array = new ERoleTowerSlotType[]
		{
			ERoleTowerSlotType.Main,
			ERoleTowerSlotType.Assist1,
			ERoleTowerSlotType.Assist2
		};
		int num = 0;
		while (num < array.Length && num < this.ActiveStageSelection.Roles.Count)
		{
			int roleIdOrTrialRoleId = this.ActiveStageSelection.Roles[num].RoleIdOrTrialRoleId;
			this.SlotRoleMap[array[num]] = roleIdOrTrialRoleId;
			this.SlotTrialMap[array[num]] = (roleIdOrTrialRoleId >= 100000);
			RoleModel.Instance.SetRoleSkillBranchGamePlayCache(roleIdOrTrialRoleId, this.ActiveStageSelection.Roles[num].SkillBranchId, ESkillBranchCacheType.Mowing);
			num++;
		}
		this.CurEquipTokenId = this.ActiveStageSelection.EquipTokenId;
		this.CurSelectBranchId = this.ActiveStageSelection.BranchIndex;
		this.CurSelectLevelId = this.ActiveChallengeId;
		this.CurSelectStageId = this.ActiveStageId;
	}

	// Token: 0x06012336 RID: 74550 RVA: 0x0055C614 File Offset: 0x0055A814
	private void CaptureCheckPointResources(long remainTime, bool useInitialFatigue = false)
	{
		this.CheckPointRemainTime = remainTime;
		this.CheckPointUsesInitialFatigue = useInitialFatigue;
		this.CheckPointFatigueMap.Clear();
		foreach (KeyValuePair<int, int> keyValuePair in this.FatigueMap)
		{
			this.CheckPointFatigueMap[keyValuePair.Key] = keyValuePair.Value;
		}
		this.CheckPointTokenCounts.Clear();
		IReadOnlyList<RoleTowerToken> tokensByActivityId = RoleTowerConfig.Instance.GetTokensByActivityId(this.CurActivityId);
		if (tokensByActivityId != null)
		{
			foreach (RoleTowerToken roleTowerToken in tokensByActivityId)
			{
				Dictionary<int, int> checkPointTokenCounts = this.CheckPointTokenCounts;
				int id = roleTowerToken.Id;
				int value;
				if (!useInitialFatigue)
				{
					RoleTowerTokenData tokenState = this.GetTokenState(roleTowerToken.Id);
					value = ((tokenState != null) ? tokenState.RemainCount : 0);
				}
				else
				{
					int num;
					value = (this.TryGetInitTokenDictCount(roleTowerToken.Id, out num) ? num : 0);
				}
				checkPointTokenCounts[id] = value;
			}
		}
	}

	// Token: 0x06012337 RID: 74551 RVA: 0x0055C728 File Offset: 0x0055A928
	public void ResetStageRetryState()
	{
		this.ClearInDungeonState();
		this.ActiveStageSelection = null;
		this.ActiveChallengeId = 0;
		this.ActiveStageId = 0;
		this.StageStartEchoStageId = 0;
		this.PendingRetryMainRoleId = 0;
		this.IsStageRetryPending = false;
		this.IsCheckPointOpen = false;
		this.CheckPointBranchFloorInfo = null;
		this.CheckPointFatigueMap.Clear();
		this.CheckPointTokenCounts.Clear();
		this.CheckPointRemainTime = 0L;
		this.CheckPointUsesInitialFatigue = false;
	}

	// Token: 0x06012338 RID: 74552 RVA: 0x0055C798 File Offset: 0x0055A998
	public RoleTowerInstParam BuildInstParam(int levelId, bool isContinue)
	{
		RoleTowerInstParam roleTowerInstParam = RoleTowerInstParam.Create();
		roleTowerInstParam.LevelId = levelId;
		roleTowerInstParam.IsContinue = isContinue;
		roleTowerInstParam.TokenId = this.CurEquipTokenId;
		foreach (RoleTowerRoleBrief roleTowerRoleBrief in this.BuildRoleBriefList())
		{
			if (roleTowerRoleBrief.SkillBranchId > 0)
			{
				roleTowerInstParam.RoleSkillBranchIds[roleTowerRoleBrief.RoleIdOrTrialRoleId] = roleTowerRoleBrief.SkillBranchId;
			}
		}
		if (this.CurSelectBranchId > 0)
		{
			foreach (ValueTuple<int, int> valueTuple in this.GetStageBranchOptionsByCfg(levelId, this.GetChallengeableStageId(levelId)))
			{
				int item = valueTuple.Item1;
				if (item == this.CurSelectBranchId)
				{
					roleTowerInstParam.BranchId = item;
					break;
				}
			}
		}
		return roleTowerInstParam;
	}

	// Token: 0x06012339 RID: 74553 RVA: 0x0055C888 File Offset: 0x0055AA88
	private void SeedTokenStateFromSave(int levelId)
	{
		RoleTowerSaveData roleTowerSaveData;
		if (!this.SaveDataMap.TryGetValue(levelId, out roleTowerSaveData) || roleTowerSaveData == null)
		{
			return;
		}
		foreach (RoleTowerTokenData roleTowerTokenData in this.TokenStateMap.Values)
		{
			if (roleTowerTokenData != null)
			{
				roleTowerTokenData.RemainCount = 0;
			}
		}
		foreach (KeyValuePair<int, int> keyValuePair in roleTowerSaveData.InitialTokens)
		{
			RoleTowerTokenData roleTowerTokenData2;
			if (this.TokenStateMap.TryGetValue(keyValuePair.Key, out roleTowerTokenData2) && roleTowerTokenData2 != null)
			{
				roleTowerTokenData2.RemainCount = keyValuePair.Value;
				roleTowerTokenData2.IsUnlocked |= (keyValuePair.Value > 0);
			}
			else
			{
				this.TokenStateMap[keyValuePair.Key] = new RoleTowerTokenData
				{
					Id = keyValuePair.Key,
					IsUnlocked = (keyValuePair.Value > 0),
					RemainCount = keyValuePair.Value,
					IsCarried = (keyValuePair.Key == this.CurEquipTokenId)
				};
			}
		}
	}

	// Token: 0x0601233A RID: 74554 RVA: 0x0055C9D4 File Offset: 0x0055ABD4
	public unsafe void EnterDungeon(int levelId, bool isContinue)
	{
		RoleTowerLevel? levelCfg = this.GetLevelCfg(levelId);
		if (levelCfg == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "RoleTower.EnterDungeon 关卡配置缺失";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("levelId", levelId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		List<int> teamRoleIds = this.GetTeamRoleIds();
		if (teamRoleIds.Count == 0)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Temp;
			ELogAuthor author2 = ELogAuthor.LJQ;
			string message2 = "RoleTower.EnterDungeon 编队为空，无法进本";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("levelId", levelId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		this.ResetStageRetryState();
		this.ActiveChallengeId = levelId;
		this.ActiveStageId = this.GetChallengeableStageId(levelId);
		if (isContinue)
		{
			this.SeedTokenStateFromSave(levelId);
			this.SeedInDungeonStateFromSave(levelId);
		}
		RoleTowerSaveData curChallengeSave = this.CurChallengeSave;
		this.CaptureCheckPointResources((curChallengeSave != null) ? curChallengeSave.DungeonRemainTime : ((long)levelCfg.Value.InitTime), !isContinue);
		RoleTowerPrepareSelection roleTowerPrepareSelection = this.BuildPrepareSelection();
		this.CurProgressLevelId = 0;
		this.HasEchoLevel = false;
		RoleTowerCtx roleTowerCtx = RoleTowerCtx.Create();
		roleTowerCtx.Param = this.BuildInstParam(levelId, isContinue);
		roleTowerPrepareSelection.BranchIndex = roleTowerCtx.Param.BranchId;
		InstanceDungeonModel.Instance.InstanceEnterContentText.RoleTowerCtx = roleTowerCtx;
		this.EnterDungeonAndRememberSelection(levelCfg.Value.InstId, teamRoleIds, levelId, this.ActiveStageId, roleTowerPrepareSelection).Forget();
		this.CurNeedBranchSelect = false;
		this.CurBranchFloorInfo = null;
		this.CurSelectBranchId = roleTowerCtx.Param.BranchId;
		this.PendingGuideHelpId = ((!this.IsTeachLevel(levelId) && this.IsFirstStageOfLevel(levelId, this.GetChallengeableStageId(levelId))) ? levelCfg.Value.HelpId : 0);
		this.CurChallengeSave = null;
		this.BattleWaveRecords.Clear();
		this.LastSettle = null;
		this.LastSettleRecord = null;
		this.LastSettleGainTokens.Clear();
		global::Log instance3 = global::Log.Instance;
		ELogModule module3 = ELogModule.Temp;
		ELogAuthor author3 = ELogAuthor.LJQ;
		string message3 = "RoleTower.EnterDungeon 进本";
		<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("levelId", levelId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("instId", levelCfg.Value.InstId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("tokenId", this.CurEquipTokenId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("roleCount", teamRoleIds.Count);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("isContinue", isContinue);
		instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
	}

	// Token: 0x0601233B RID: 74555 RVA: 0x0055CC64 File Offset: 0x0055AE64
	private UniTask EnterDungeonAndRememberSelection(int instId, List<int> roleIds, int challengeId, int stageId, RoleTowerPrepareSelection selection)
	{
		RoleTowerModel.<EnterDungeonAndRememberSelection>d__292 <EnterDungeonAndRememberSelection>d__;
		<EnterDungeonAndRememberSelection>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<EnterDungeonAndRememberSelection>d__.<>4__this = this;
		<EnterDungeonAndRememberSelection>d__.instId = instId;
		<EnterDungeonAndRememberSelection>d__.roleIds = roleIds;
		<EnterDungeonAndRememberSelection>d__.challengeId = challengeId;
		<EnterDungeonAndRememberSelection>d__.stageId = stageId;
		<EnterDungeonAndRememberSelection>d__.selection = selection;
		<EnterDungeonAndRememberSelection>d__.<>1__state = -1;
		<EnterDungeonAndRememberSelection>d__.<>t__builder.Start<RoleTowerModel.<EnterDungeonAndRememberSelection>d__292>(ref <EnterDungeonAndRememberSelection>d__);
		return <EnterDungeonAndRememberSelection>d__.<>t__builder.Task;
	}

	// Token: 0x0601233C RID: 74556 RVA: 0x0055CCD4 File Offset: 0x0055AED4
	public void OpenBattleHudView()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.LevelUpView))
		{
			UiManager.Instance.CloseView(EUiViewName.LevelUpView, null);
		}
		UiManager.Instance.OpenView(EUiViewName.RoleTowerCountdownView, null, null);
		UiManager.Instance.OpenView(EUiViewName.RoleTowerWaveView, null, null);
		this.OpenExitButtonView();
		this.MountTokenButtonAsync().Forget();
	}

	// Token: 0x0601233D RID: 74557 RVA: 0x0055CD35 File Offset: 0x0055AF35
	public void OpenExitButtonView()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.RoleTowerExitButtonView))
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.RoleTowerExitButtonView, null, null);
	}

	// Token: 0x0601233E RID: 74558 RVA: 0x0055CD5A File Offset: 0x0055AF5A
	public void CloseExitButtonView()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.RoleTowerExitButtonView))
		{
			UiManager.Instance.CloseView(EUiViewName.RoleTowerExitButtonView, null);
		}
	}

	// Token: 0x0601233F RID: 74559 RVA: 0x0055CD7D File Offset: 0x0055AF7D
	[NullableContext(2)]
	public void OpenBossTipsView(IRoleTowerStrongEnemyWarning config)
	{
		UiManager.Instance.OpenView(EUiViewName.RoleTowerBossTipsView, config, null);
	}

	// Token: 0x06012340 RID: 74560 RVA: 0x0055CD90 File Offset: 0x0055AF90
	public void CloseBattleHudView()
	{
		UiManager.Instance.CloseView(EUiViewName.RoleTowerCountdownView, null);
		UiManager.Instance.CloseView(EUiViewName.RoleTowerWaveView, null);
		UiManager.Instance.CloseView(EUiViewName.RoleTowerBossTipsView, null);
	}

	// Token: 0x06012341 RID: 74561 RVA: 0x0055CDC2 File Offset: 0x0055AFC2
	public void OpenTokenButton()
	{
		this.MountTokenButtonAsync().Forget();
	}

	// Token: 0x06012342 RID: 74562 RVA: 0x0055CDCF File Offset: 0x0055AFCF
	public void CloseTokenButton()
	{
		RoleTowerTokenButtonItem tokenButtonItem = this.TokenButtonItem;
		if (tokenButtonItem != null)
		{
			tokenButtonItem.Destroy(null);
		}
		this.TokenButtonItem = null;
		this.TokenButtonParent = null;
	}

	// Token: 0x06012343 RID: 74563 RVA: 0x0055CDF4 File Offset: 0x0055AFF4
	private UniTask MountTokenButtonAsync()
	{
		RoleTowerModel.<MountTokenButtonAsync>d__300 <MountTokenButtonAsync>d__;
		<MountTokenButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MountTokenButtonAsync>d__.<>4__this = this;
		<MountTokenButtonAsync>d__.<>1__state = -1;
		<MountTokenButtonAsync>d__.<>t__builder.Start<RoleTowerModel.<MountTokenButtonAsync>d__300>(ref <MountTokenButtonAsync>d__);
		return <MountTokenButtonAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012344 RID: 74564 RVA: 0x0055CE38 File Offset: 0x0055B038
	public UniTask RemountTokenButtonAsync()
	{
		RoleTowerModel.<RemountTokenButtonAsync>d__301 <RemountTokenButtonAsync>d__;
		<RemountTokenButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RemountTokenButtonAsync>d__.<>4__this = this;
		<RemountTokenButtonAsync>d__.<>1__state = -1;
		<RemountTokenButtonAsync>d__.<>t__builder.Start<RoleTowerModel.<RemountTokenButtonAsync>d__301>(ref <RemountTokenButtonAsync>d__);
		return <RemountTokenButtonAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012345 RID: 74565 RVA: 0x0055CE7C File Offset: 0x0055B07C
	private bool IsFirstStageOfLevel(int levelId, int stageId)
	{
		IReadOnlyList<RoleTowerStage> stageCfgListByLevel = this.GetStageCfgListByLevel(levelId);
		return stageId > 0 && stageCfgListByLevel.Count > 0 && stageCfgListByLevel[0].Id == stageId;
	}

	// Token: 0x06012346 RID: 74566 RVA: 0x0055CEB4 File Offset: 0x0055B0B4
	public void TryShowLevelGuide()
	{
		if (this.PendingGuideHelpId <= 0)
		{
			return;
		}
		int pendingGuideHelpId = this.PendingGuideHelpId;
		this.PendingGuideHelpId = 0;
		UiManager.Instance.OpenView(EUiViewName.InstanceDungeonGuideView, pendingGuideHelpId, null);
	}

	// Token: 0x06012347 RID: 74567 RVA: 0x0055CEF0 File Offset: 0x0055B0F0
	public void OpenGameplayTipsView()
	{
		RoleTowerLevel? roleTowerLevel;
		int num = (this.GetLevelCfg(this.CurSelectLevel) != null) ? roleTowerLevel.GetValueOrDefault().HelpId : 0;
		if (num <= 0)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "RoleTower.OpenGameplayTipsView 当前关卡未配 HelpId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("levelId", this.CurSelectLevel);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.InstanceDungeonGuideView, num, null);
	}

	// Token: 0x06012348 RID: 74568 RVA: 0x0055CF70 File Offset: 0x0055B170
	public void OpenPauseView()
	{
		if (UiManager.Instance.GetViewByName(EUiViewName.RoleTowerPauseView) != null)
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.RoleTowerPauseView, null, null);
	}

	// Token: 0x06012349 RID: 74569 RVA: 0x0055CF95 File Offset: 0x0055B195
	public void OpenFloorSettleView(int floorId)
	{
		UiManager.Instance.OpenView(EUiViewName.RoleTowerFloorSettleView, new RoleTowerFloorSettleViewParams
		{
			FloorId = floorId
		}, null);
	}

	// Token: 0x0601234A RID: 74570 RVA: 0x0055CFB3 File Offset: 0x0055B1B3
	public void OpenStarUpView()
	{
		UiManager.Instance.OpenView(EUiViewName.RoleTowerStarUpView, null, null);
	}

	// Token: 0x0601234B RID: 74571 RVA: 0x0055CFC6 File Offset: 0x0055B1C6
	public void OpenInPrepareView(int stageId)
	{
		this.CurSelectStageId = stageId;
		this.OpenPrepareView(this.CurSelectLevelId, false, true, false);
	}

	// Token: 0x0601234C RID: 74572 RVA: 0x0055CFDE File Offset: 0x0055B1DE
	public void OpenCheckPointView()
	{
		if (this.ActiveStageSelection == null || this.IsCheckPointOpen || this.IsStageRetryPending)
		{
			return;
		}
		this.RestoreBattleSelectionForPrepare();
		this.IsCheckPointOpen = true;
		this.OpenPrepareView(this.ActiveChallengeId, false, false, true);
	}

	// Token: 0x0601234D RID: 74573 RVA: 0x0055D015 File Offset: 0x0055B215
	public void CloseCheckPointView()
	{
		this.IsCheckPointOpen = false;
	}

	// Token: 0x0601234E RID: 74574 RVA: 0x0055D01E File Offset: 0x0055B21E
	public long GetCheckPointRemainTime()
	{
		return this.CheckPointRemainTime;
	}

	// Token: 0x0601234F RID: 74575 RVA: 0x0055D026 File Offset: 0x0055B226
	public bool NeedBranchSelectForRetry()
	{
		RoleTowerFloorInfo checkPointBranchFloorInfo = this.CheckPointBranchFloorInfo;
		return checkPointBranchFloorInfo != null && checkPointBranchFloorInfo.BranchInfos.Count > 0;
	}

	// Token: 0x06012350 RID: 74576 RVA: 0x0055D041 File Offset: 0x0055B241
	[NullableContext(0)]
	public UniTask<bool> RetryStageFromCheckPoint()
	{
		if (!this.IsCheckPointOpen)
		{
			return UniTask.FromResult<bool>(false);
		}
		return this.RetryStage(this.BuildPrepareSelection());
	}

	// Token: 0x06012351 RID: 74577 RVA: 0x0055D05E File Offset: 0x0055B25E
	public void OpenResultView()
	{
		UiManager.Instance.OpenView(EUiViewName.RoleTowerResultView, null, null);
	}

	// Token: 0x06012352 RID: 74578 RVA: 0x0055D074 File Offset: 0x0055B274
	public void RestartChallengeFromResult()
	{
		int slotRoleId = this.GetSlotRoleId(ERoleTowerSlotType.Main);
		bool slotIsTrial = this.GetSlotIsTrial(ERoleTowerSlotType.Main);
		this.OpenPrepareView(this.CurSelectLevelId, false, false, false);
		if (slotRoleId > 0)
		{
			this.SetSlotRole(ERoleTowerSlotType.Main, slotRoleId, slotIsTrial);
		}
	}

	// Token: 0x06012353 RID: 74579 RVA: 0x0055D0B0 File Offset: 0x0055B2B0
	public void ConfirmStageRetry(Action onConfirmed = null)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleTowerStageRetryConfirm);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			this.RequestStageRetry();
			Action onConfirmed2 = onConfirmed;
			if (onConfirmed2 == null)
			{
				return;
			}
			onConfirmed2();
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06012354 RID: 74580 RVA: 0x0055D100 File Offset: 0x0055B300
	private void RequestStageRetry()
	{
		if (this.ActiveStageSelection == null)
		{
			global::Log.Instance.Error(ELogModule.Temp, ELogAuthor.LJQ, "RoleTower.StageRetry 缺少已出战选择", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.RetryStage(this.ActiveStageSelection.Clone()).Forget<bool>();
	}

	// Token: 0x06012355 RID: 74581 RVA: 0x0055D148 File Offset: 0x0055B348
	[NullableContext(0)]
	private UniTask<bool> RetryStage([Nullable(1)] RoleTowerPrepareSelection selection)
	{
		RoleTowerModel.<RetryStage>d__319 <RetryStage>d__;
		<RetryStage>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RetryStage>d__.<>4__this = this;
		<RetryStage>d__.selection = selection;
		<RetryStage>d__.<>1__state = -1;
		<RetryStage>d__.<>t__builder.Start<RoleTowerModel.<RetryStage>d__319>(ref <RetryStage>d__);
		return <RetryStage>d__.<>t__builder.Task;
	}

	// Token: 0x06012356 RID: 74582 RVA: 0x0055D194 File Offset: 0x0055B394
	public void TrySwitchToMainRoleOnRetry()
	{
		if (this.PendingRetryMainRoleId <= 0)
		{
			return;
		}
		int pendingRetryMainRoleId = this.PendingRetryMainRoleId;
		SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)pendingRetryMainRoleId, new GetTeamItemOptions
		{
			ParamType = ETeamParamType.ConfigId
		});
		long num = (teamItem != null) ? teamItem.GetCreatureDataId() : 0L;
		if (num <= 0L)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "RoleTower.重打切主战 主战实体未就绪，跳过";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mainRoleId", pendingRetryMainRoleId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.PendingRetryMainRoleId = 0;
		CooperationController.Instance.TryCooperate(num);
	}

	// Token: 0x06012357 RID: 74583 RVA: 0x0055D21C File Offset: 0x0055B41C
	public void ConfirmSettleExit(Action onConfirmed = null)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleTowerSettleExitConfirm);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			RoleTowerController.Instance.ChallengeSettleRequest(this.CurSelectLevelId).Forget();
			Action onConfirmed2 = onConfirmed;
			if (onConfirmed2 == null)
			{
				return;
			}
			onConfirmed2();
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06012358 RID: 74584 RVA: 0x0055D26C File Offset: 0x0055B46C
	public void LeaveDungeon()
	{
		this.LeaveDungeonAsync().Forget<bool>();
	}

	// Token: 0x06012359 RID: 74585 RVA: 0x0055D27C File Offset: 0x0055B47C
	[NullableContext(0)]
	public UniTask<bool> LeaveDungeonAsync()
	{
		RoleTowerModel.<LeaveDungeonAsync>d__323 <LeaveDungeonAsync>d__;
		<LeaveDungeonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LeaveDungeonAsync>d__.<>4__this = this;
		<LeaveDungeonAsync>d__.<>1__state = -1;
		<LeaveDungeonAsync>d__.<>t__builder.Start<RoleTowerModel.<LeaveDungeonAsync>d__323>(ref <LeaveDungeonAsync>d__);
		return <LeaveDungeonAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601235A RID: 74586 RVA: 0x0055D2C0 File Offset: 0x0055B4C0
	public UniTask LeaveDungeonAndOpenActivityMain()
	{
		RoleTowerModel.<LeaveDungeonAndOpenActivityMain>d__325 <LeaveDungeonAndOpenActivityMain>d__;
		<LeaveDungeonAndOpenActivityMain>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LeaveDungeonAndOpenActivityMain>d__.<>4__this = this;
		<LeaveDungeonAndOpenActivityMain>d__.<>1__state = -1;
		<LeaveDungeonAndOpenActivityMain>d__.<>t__builder.Start<RoleTowerModel.<LeaveDungeonAndOpenActivityMain>d__325>(ref <LeaveDungeonAndOpenActivityMain>d__);
		return <LeaveDungeonAndOpenActivityMain>d__.<>t__builder.Task;
	}

	// Token: 0x0601235B RID: 74587 RVA: 0x0055D303 File Offset: 0x0055B503
	public bool ConsumeOpenActivityMainAfterLeave()
	{
		bool needOpenActivityMainAfterLeave = this.NeedOpenActivityMainAfterLeave;
		this.NeedOpenActivityMainAfterLeave = false;
		return needOpenActivityMainAfterLeave;
	}

	// Token: 0x0601235C RID: 74588 RVA: 0x0055D312 File Offset: 0x0055B512
	[NullableContext(2)]
	public void AddHomeBtnLeaveDungeonCallback(UiBehaviourHomeBtn homeBtn)
	{
		if (homeBtn != null)
		{
			homeBtn.AddExtraAsyncCallback(delegate
			{
				RoleTowerModel.<<AddHomeBtnLeaveDungeonCallback>b__328_0>d <<AddHomeBtnLeaveDungeonCallback>b__328_0>d;
				<<AddHomeBtnLeaveDungeonCallback>b__328_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<AddHomeBtnLeaveDungeonCallback>b__328_0>d.<>4__this = this;
				<<AddHomeBtnLeaveDungeonCallback>b__328_0>d.<>1__state = -1;
				<<AddHomeBtnLeaveDungeonCallback>b__328_0>d.<>t__builder.Start<RoleTowerModel.<<AddHomeBtnLeaveDungeonCallback>b__328_0>d>(ref <<AddHomeBtnLeaveDungeonCallback>b__328_0>d);
				return <<AddHomeBtnLeaveDungeonCallback>b__328_0>d.<>t__builder.Task;
			});
		}
	}

	// Token: 0x0601235D RID: 74589 RVA: 0x0055D32C File Offset: 0x0055B52C
	private UniTask ResetHomeBtnLeavingFlagNextFrame()
	{
		RoleTowerModel.<ResetHomeBtnLeavingFlagNextFrame>d__329 <ResetHomeBtnLeavingFlagNextFrame>d__;
		<ResetHomeBtnLeavingFlagNextFrame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ResetHomeBtnLeavingFlagNextFrame>d__.<>4__this = this;
		<ResetHomeBtnLeavingFlagNextFrame>d__.<>1__state = -1;
		<ResetHomeBtnLeavingFlagNextFrame>d__.<>t__builder.Start<RoleTowerModel.<ResetHomeBtnLeavingFlagNextFrame>d__329>(ref <ResetHomeBtnLeavingFlagNextFrame>d__);
		return <ResetHomeBtnLeavingFlagNextFrame>d__.<>t__builder.Task;
	}

	// Token: 0x0601235E RID: 74590 RVA: 0x0055D36F File Offset: 0x0055B56F
	public void SaveAndBackToActivityMain()
	{
		this.ResetLocalChallengeState();
		this.OpenActivityMainView(false, null, null);
	}

	// Token: 0x0601235F RID: 74591 RVA: 0x0055D380 File Offset: 0x0055B580
	private void ResetLocalChallengeState()
	{
		this.SetInBattle(false);
		this.PendingGuideHelpId = 0;
		this.ClearFormationSelection();
		this.ResetStageRetryState();
		this.ResetGameplayProgressState();
		this.BattleWaveRecords.Clear();
		this.LastSettle = null;
		this.LastSettleRecord = null;
		this.LastSettleGainTokens.Clear();
	}

	// Token: 0x06012360 RID: 74592 RVA: 0x0055D3D4 File Offset: 0x0055B5D4
	private void ApplyInitProgressFromParam()
	{
		RoleTowerParam? paramByActivityId = RoleTowerConfig.Instance.GetParamByActivityId(this.CurActivityId);
		this.CurTeamStar = ((paramByActivityId != null) ? paramByActivityId.GetValueOrDefault().InitTeamLevel : 0);
		int num = (paramByActivityId != null) ? paramByActivityId.GetValueOrDefault().InitPhantomLevel : 0;
		this.CurEchoLevel = ((num > 0) ? num : 1);
		this.CurEchoExp = ((paramByActivityId != null) ? paramByActivityId.GetValueOrDefault().InitPhantomExp : 0);
		this.LastSettleEchoOldLevel = this.CurEchoLevel;
		this.LastSettleEchoOldExp = this.CurEchoExp;
		this.StageStartEchoLevel = this.CurEchoLevel;
		this.StageStartEchoExp = this.CurEchoExp;
		this.StageStartEchoStageId = 0;
	}

	// Token: 0x06012361 RID: 74593 RVA: 0x0055D498 File Offset: 0x0055B698
	private void ResetGameplayProgressState()
	{
		this.CurProgressLevelId = 0;
		this.HasEchoLevel = false;
		this.CurTeamStar = 0;
		this.CurEchoLevel = 1;
		this.CurEchoExp = 0;
		this.LastSettleEchoOldLevel = 0;
		this.LastSettleEchoOldExp = 0;
		this.StageStartEchoLevel = 1;
		this.StageStartEchoExp = 0;
		this.StageStartEchoStageId = 0;
		this.NeedStarUp = false;
	}

	// Token: 0x06012362 RID: 74594 RVA: 0x0055D4F2 File Offset: 0x0055B6F2
	public void ClearFormationSelection()
	{
		this.SlotRoleMap.Clear();
		this.SlotTrialMap.Clear();
		this.CurEquipTokenId = 0;
	}

	// Token: 0x06012363 RID: 74595 RVA: 0x0055D514 File Offset: 0x0055B714
	public void ConfirmDeleteSaveAndRestart(int levelId)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleTowerDeleteSaveConfirm);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			this.DeleteSaveThenPrepare(levelId).Forget();
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06012364 RID: 74596 RVA: 0x0055D564 File Offset: 0x0055B764
	private UniTask DeleteSaveThenPrepare(int levelId)
	{
		RoleTowerModel.<DeleteSaveThenPrepare>d__336 <DeleteSaveThenPrepare>d__;
		<DeleteSaveThenPrepare>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<DeleteSaveThenPrepare>d__.<>4__this = this;
		<DeleteSaveThenPrepare>d__.levelId = levelId;
		<DeleteSaveThenPrepare>d__.<>1__state = -1;
		<DeleteSaveThenPrepare>d__.<>t__builder.Start<RoleTowerModel.<DeleteSaveThenPrepare>d__336>(ref <DeleteSaveThenPrepare>d__);
		return <DeleteSaveThenPrepare>d__.<>t__builder.Task;
	}

	// Token: 0x06012365 RID: 74597 RVA: 0x0055D5AF File Offset: 0x0055B7AF
	public void SetInBattle(bool inBattle)
	{
		if (this.IsInBattle == inBattle)
		{
			return;
		}
		this.IsInBattle = inBattle;
		BattleUiControl.RefreshWorldFormationInputType();
		if (inBattle)
		{
			this.OpenBattleHudView();
			return;
		}
		this.CloseBattleHudView();
	}

	// Token: 0x06012366 RID: 74598 RVA: 0x0055D5D7 File Offset: 0x0055B7D7
	[NullableContext(2)]
	public RoleTowerTokenButtonItem GetTokenButtonItem()
	{
		return this.TokenButtonItem;
	}

	// Token: 0x06012367 RID: 74599 RVA: 0x0055D5E0 File Offset: 0x0055B7E0
	public void TriggerTokenButton()
	{
		if (this.TokenButtonItem != null)
		{
			this.TokenButtonItem.TriggerByKey();
			return;
		}
		global::Log.Instance.Info(ELogModule.Temp, ELogAuthor.LJQ, "RoleTower.TriggerTokenButton 按键触发但按钮实例未挂载", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06012368 RID: 74600 RVA: 0x0055D61B File Offset: 0x0055B81B
	public void SelectStage(int stageId)
	{
		this.CurSelectStageId = stageId;
		EventSystem.Instance.Emit<int>(EEventName.RoleTowerLevelUpdate, stageId);
	}

	// Token: 0x06012369 RID: 74601 RVA: 0x0055D638 File Offset: 0x0055B838
	public void SelectFloor(int floorId)
	{
		this.CurSelectFloorId = floorId;
		RoleTowerStage? stageCfgByFloor = this.GetStageCfgByFloor(floorId);
		EventSystem.Instance.Emit<int>(EEventName.RoleTowerLevelUpdate, (stageCfgByFloor != null) ? stageCfgByFloor.GetValueOrDefault().Id : 0);
	}

	// Token: 0x0601236A RID: 74602 RVA: 0x0055D680 File Offset: 0x0055B880
	public int GetStageFatigueCost(int stageId)
	{
		if (this.GetStageCfg(stageId) == null)
		{
			return 0;
		}
		RoleTowerStage? roleTowerStage;
		return roleTowerStage.GetValueOrDefault().FatigueCost;
	}

	// Token: 0x0601236B RID: 74603 RVA: 0x0055D6B0 File Offset: 0x0055B8B0
	public int GetChallengeableStageId(int levelId)
	{
		if (this.IsInRoleTowerDungeon() && this.ActiveChallengeId == levelId && this.ActiveStageId > 0)
		{
			return this.ActiveStageId;
		}
		IReadOnlyList<RoleTowerStage> stageCfgListByLevel = this.GetStageCfgListByLevel(levelId);
		RoleTowerSaveData curChallengeSave = this.CurChallengeSave;
		if (curChallengeSave != null && curChallengeSave.LevelId == levelId && curChallengeSave.CurStageId > 0)
		{
			foreach (RoleTowerStage roleTowerStage in stageCfgListByLevel)
			{
				if (roleTowerStage.Id == curChallengeSave.CurStageId)
				{
					return curChallengeSave.CurStageId;
				}
			}
		}
		foreach (RoleTowerStage roleTowerStage2 in stageCfgListByLevel)
		{
			RoleTowerStageData stageState = this.GetStageState(roleTowerStage2.Id);
			if (stageState != null && stageState.IsCurrent)
			{
				return roleTowerStage2.Id;
			}
		}
		if (stageCfgListByLevel.Count <= 0)
		{
			return 0;
		}
		return stageCfgListByLevel[0].Id;
	}

	// Token: 0x0601236C RID: 74604 RVA: 0x0055D7C8 File Offset: 0x0055B9C8
	public int GetEquipTokenId()
	{
		return this.CurEquipTokenId;
	}

	// Token: 0x0601236D RID: 74605 RVA: 0x0055D7D0 File Offset: 0x0055B9D0
	public double GetTokenCdEndTime()
	{
		return this.TokenCdEndTime;
	}

	// Token: 0x0601236E RID: 74606 RVA: 0x0055D7D8 File Offset: 0x0055B9D8
	public void SetTokenCdEndTime(double endTime)
	{
		this.TokenCdEndTime = endTime;
	}

	// Token: 0x0601236F RID: 74607 RVA: 0x0055D7E4 File Offset: 0x0055B9E4
	public void OnActivityData(RoleTowerActivityData data)
	{
		if (data == null)
		{
			return;
		}
		RoleTowerModel.NotifyNewRoleLevels(this.WriteChallengeInfos(data.ChallengeInfos));
		this.CurScore = data.Score;
		this.RankRewardSettleTime = data.RankRewardSettleTime;
		this.WriteUnlockTokens(data.UnlockTokens);
		this.WriteLimitTasks(data.LimitTasks);
		this.RebuildScoreRewardStates(data.ScoreTasks);
		EventSystem.Instance.Emit(EEventName.RoleTowerInfoUpdate);
	}

	// Token: 0x06012370 RID: 74608 RVA: 0x0055D854 File Offset: 0x0055BA54
	private List<int> WriteChallengeInfos(IEnumerable<RoleTowerChallengeInfo> infos)
	{
		List<int> list = new List<int>();
		if (infos == null)
		{
			return list;
		}
		foreach (RoleTowerChallengeInfo roleTowerChallengeInfo in infos)
		{
			RoleTowerLevelData roleTowerLevelData;
			bool flag = this.LevelStateMap.TryGetValue(roleTowerChallengeInfo.ChallengeId, out roleTowerLevelData);
			bool flag2 = flag && roleTowerLevelData.IsUnlock;
			RoleTowerLevelData roleTowerLevelData2 = new RoleTowerLevelData
			{
				Id = roleTowerChallengeInfo.ChallengeId,
				UnlockTime = roleTowerChallengeInfo.UnlockTime,
				IsAllPass = roleTowerChallengeInfo.IsAllPassed,
				HasSave = roleTowerChallengeInfo.HasSave
			};
			this.ApplyUnlockState(roleTowerLevelData2, roleTowerChallengeInfo.IsUnlock, roleTowerChallengeInfo.UnlockTime);
			if (roleTowerChallengeInfo.SaveBrief != null)
			{
				roleTowerLevelData2.SaveStageSeq = this.GetStageSeqById(roleTowerChallengeInfo.SaveBrief.CurStageId);
				roleTowerLevelData2.SaveFloorIndex = roleTowerChallengeInfo.SaveBrief.PassedFloorCount;
			}
			if (roleTowerChallengeInfo.BestRecord != null)
			{
				roleTowerLevelData2.BestPassWave = roleTowerChallengeInfo.BestRecord.PassedFloorCount;
				roleTowerLevelData2.BestRemainTime = roleTowerChallengeInfo.BestRecord.RemainTimeMs;
				roleTowerLevelData2.BestCostTime = roleTowerChallengeInfo.BestRecord.CostTimeMs;
				this.BestRecordMap[roleTowerChallengeInfo.ChallengeId] = this.BuildBestRecordData(roleTowerChallengeInfo.ChallengeId, roleTowerChallengeInfo.BestRecord);
			}
			else
			{
				this.BestRecordMap.Remove(roleTowerChallengeInfo.ChallengeId);
			}
			this.LevelStateMap[roleTowerChallengeInfo.ChallengeId] = roleTowerLevelData2;
			if (flag && !flag2 && roleTowerLevelData2.IsUnlock && this.IsRoleChallengeLevel(roleTowerChallengeInfo.ChallengeId))
			{
				list.Add(roleTowerChallengeInfo.ChallengeId);
			}
			if (roleTowerChallengeInfo.HasSave && roleTowerChallengeInfo.SaveBrief != null)
			{
				this.SaveDataMap[roleTowerChallengeInfo.ChallengeId] = this.BuildSaveData(roleTowerChallengeInfo);
			}
			else
			{
				this.SaveDataMap.Remove(roleTowerChallengeInfo.ChallengeId);
			}
			if (roleTowerChallengeInfo.StageInfos.Count > 0)
			{
				using (IEnumerator<RoleTowerStageInfo> enumerator2 = roleTowerChallengeInfo.StageInfos.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						RoleTowerStageInfo stage = enumerator2.Current;
						this.WriteStageInfo(roleTowerChallengeInfo.ChallengeId, stage);
					}
					continue;
				}
			}
			this.RebuildStageStateFromFloors(roleTowerChallengeInfo.ChallengeId);
		}
		this.ScheduleUnlockTimeTimer();
		return list;
	}

	// Token: 0x06012371 RID: 74609 RVA: 0x0055DAB4 File Offset: 0x0055BCB4
	private void ScheduleUnlockTimeTimer()
	{
		this.StopUnlockTimeTimer();
		long num = (long)TimeUtil.Instance.GetServerTime();
		long num2 = 0L;
		foreach (RoleTowerLevelData roleTowerLevelData in this.LevelStateMap.Values)
		{
			if (!roleTowerLevelData.IsUnlock && roleTowerLevelData.ServerIsUnlock && roleTowerLevelData.UnlockTime > 0L && (num2 == 0L || roleTowerLevelData.UnlockTime < num2))
			{
				num2 = roleTowerLevelData.UnlockTime;
			}
		}
		if (num2 == 0L)
		{
			return;
		}
		int num3 = (int)Math.Clamp((num2 - num + 1L) * 1000L, 20L, 180000L);
		this.UnlockTimeTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.OnUnlockTimeTimer();
		}, (float)num3, null, null, true, 1f);
	}

	// Token: 0x06012372 RID: 74610 RVA: 0x0055DB94 File Offset: 0x0055BD94
	private void StopUnlockTimeTimer()
	{
		if (this.UnlockTimeTimerHandle == null)
		{
			return;
		}
		TimerSystem.Instance.Remove(this.UnlockTimeTimerHandle);
		this.UnlockTimeTimerHandle = null;
	}

	// Token: 0x06012373 RID: 74611 RVA: 0x0055DBB8 File Offset: 0x0055BDB8
	private void OnUnlockTimeTimer()
	{
		this.UnlockTimeTimerHandle = null;
		bool flag = false;
		List<int> list = new List<int>();
		foreach (RoleTowerLevelData roleTowerLevelData in this.LevelStateMap.Values)
		{
			if (!roleTowerLevelData.IsUnlock && roleTowerLevelData.ServerIsUnlock)
			{
				int remainUnlockDays = roleTowerLevelData.RemainUnlockDays;
				this.ApplyUnlockState(roleTowerLevelData, roleTowerLevelData.ServerIsUnlock, roleTowerLevelData.UnlockTime);
				if (roleTowerLevelData.IsUnlock && this.IsRoleChallengeLevel(roleTowerLevelData.Id))
				{
					list.Add(roleTowerLevelData.Id);
				}
				flag |= (roleTowerLevelData.IsUnlock || remainUnlockDays != roleTowerLevelData.RemainUnlockDays);
			}
		}
		RoleTowerModel.NotifyNewRoleLevels(list);
		this.ScheduleUnlockTimeTimer();
		if (flag)
		{
			EventSystem.Instance.Emit(EEventName.RoleTowerInfoUpdate);
		}
	}

	// Token: 0x06012374 RID: 74612 RVA: 0x0055DCA0 File Offset: 0x0055BEA0
	public bool IsTeachLevel(int levelId)
	{
		RoleTowerLevel? levelCfg = this.GetLevelCfg(levelId);
		RoleTowerLevelGroup? roleTowerLevelGroup;
		return levelCfg != null && this.GetGroupCfg(levelCfg.Value.GroupId) != null && roleTowerLevelGroup.GetValueOrDefault().Type == 1;
	}

	// Token: 0x06012375 RID: 74613 RVA: 0x0055DCF4 File Offset: 0x0055BEF4
	private bool IsRoleChallengeLevel(int levelId)
	{
		RoleTowerLevel? levelCfg = this.GetLevelCfg(levelId);
		RoleTowerLevelGroup? roleTowerLevelGroup;
		return levelCfg != null && this.GetGroupCfg(levelCfg.Value.GroupId) != null && roleTowerLevelGroup.GetValueOrDefault().Type == 2;
	}

	// Token: 0x06012376 RID: 74614 RVA: 0x0055DD47 File Offset: 0x0055BF47
	private static void NotifyNewRoleLevels(List<int> levelIds)
	{
		if (levelIds.Count == 0)
		{
			return;
		}
		ActivityRoleTowerData data = ActivityRoleTowerController.Instance.Data;
		if (data == null)
		{
			return;
		}
		data.OnNewLevelsUnlocked(levelIds);
	}

	// Token: 0x06012377 RID: 74615 RVA: 0x0055DD68 File Offset: 0x0055BF68
	private void ApplyUnlockState(RoleTowerLevelData levelData, bool serverIsUnlock, long unlockTime)
	{
		long num = (long)TimeUtil.Instance.GetServerTime();
		bool flag = unlockTime <= 0L || num >= unlockTime;
		levelData.ServerIsUnlock = serverIsUnlock;
		levelData.IsUnlock = (serverIsUnlock && flag);
		if (levelData.IsUnlock || unlockTime <= 0L)
		{
			levelData.RemainUnlockDays = 0;
			return;
		}
		long num2 = unlockTime - num;
		levelData.RemainUnlockDays = ((num2 <= 0L) ? 0 : ((int)((num2 + 86400L - 1L) / 86400L)));
	}

	// Token: 0x06012378 RID: 74616 RVA: 0x0055DDDC File Offset: 0x0055BFDC
	private RoleTowerBestRecordData BuildBestRecordData(int levelId, RoleTowerBestRecord best)
	{
		RoleTowerBestRecordData roleTowerBestRecordData = new RoleTowerBestRecordData
		{
			LevelId = levelId,
			MainRoleId = best.MainRoleId,
			IsAllPassed = best.IsAllPassed
		};
		foreach (RoleTowerStageRecord roleTowerStageRecord in best.StageRecords)
		{
			RoleTowerStageRecordData roleTowerStageRecordData = new RoleTowerStageRecordData
			{
				StageId = roleTowerStageRecord.StageId,
				RemainTimeMs = roleTowerStageRecord.RemainTimeMs
			};
			foreach (RoleTowerRoleBrief roleTowerRoleBrief in roleTowerStageRecord.Roles)
			{
				roleTowerStageRecordData.RoleIds.Add(roleTowerRoleBrief.RoleIdOrTrialRoleId);
			}
			foreach (RoleTowerFloorRecord roleTowerFloorRecord in roleTowerStageRecord.FloorRecords)
			{
				roleTowerStageRecordData.FloorRecords.Add(new RoleTowerFloorRecordData
				{
					FloorId = roleTowerFloorRecord.FloorId,
					CostTimeMs = roleTowerFloorRecord.CostTimeMs,
					RemainTimeMs = roleTowerFloorRecord.RemainTimeMs,
					IsPassed = roleTowerFloorRecord.IsPassed
				});
			}
			roleTowerBestRecordData.StageRecords.Add(roleTowerStageRecordData);
		}
		return roleTowerBestRecordData;
	}

	// Token: 0x06012379 RID: 74617 RVA: 0x0055DF44 File Offset: 0x0055C144
	private RoleTowerSaveData BuildSaveData(RoleTowerChallengeInfo info)
	{
		RoleTowerChallengeSaveBrief saveBrief = info.SaveBrief;
		RoleTowerSaveData roleTowerSaveData = new RoleTowerSaveData
		{
			LevelId = info.ChallengeId,
			CurStageId = saveBrief.CurStageId,
			CurFloorId = 0,
			DungeonRemainTime = saveBrief.RemainTimeMs
		};
		RepeatedField<int> roleList = saveBrief.RoleList;
		for (int i = 0; i < roleList.Count; i++)
		{
			int num = roleList[i];
			if (num > 0)
			{
				if (i == 0)
				{
					roleTowerSaveData.MainRoleId = num;
				}
				else
				{
					roleTowerSaveData.AssistRoleIds.Add(num);
				}
			}
		}
		foreach (RoleTowerRoleEnergyInfo roleTowerRoleEnergyInfo in saveBrief.RoleTowerRoleEnergyInfos)
		{
			if (roleTowerRoleEnergyInfo.RoleIdOrTrialRoleId > 0)
			{
				roleTowerSaveData.FatigueMap[roleTowerRoleEnergyInfo.RoleIdOrTrialRoleId] = roleTowerRoleEnergyInfo.CurEnergy;
			}
		}
		foreach (KeyValuePair<int, int> keyValuePair in saveBrief.InitialTokens)
		{
			roleTowerSaveData.InitialTokens[keyValuePair.Key] = keyValuePair.Value;
		}
		roleTowerSaveData.CarryTokenId = 0;
		foreach (KeyValuePair<int, int> keyValuePair2 in saveBrief.TeamStarInfo)
		{
			roleTowerSaveData.HasTeamStarInfo = true;
			roleTowerSaveData.TeamStar = keyValuePair2.Value;
		}
		if (saveBrief.PhantomInfo != null)
		{
			roleTowerSaveData.HasEchoInfo = true;
			roleTowerSaveData.EchoLevel = saveBrief.PhantomInfo.Level;
			roleTowerSaveData.EchoExp = saveBrief.PhantomInfo.CurExp;
		}
		return roleTowerSaveData;
	}

	// Token: 0x0601237A RID: 74618 RVA: 0x0055E108 File Offset: 0x0055C308
	private void WriteStageInfo(int levelId, RoleTowerStageInfo stage)
	{
		RoleTowerModel.WriteStageInfo(this.GetOrCreateStageStateBucket(levelId), this.GetOrCreateFloorStateBucket(levelId), stage);
	}

	// Token: 0x0601237B RID: 74619 RVA: 0x0055E120 File Offset: 0x0055C320
	private static void WriteStageInfo(Dictionary<int, RoleTowerStageData> stageBucket, Dictionary<int, RoleTowerFloorData> floorBucket, RoleTowerStageInfo stage)
	{
		if (stage == null)
		{
			return;
		}
		RoleTowerStageData roleTowerStageData = new RoleTowerStageData
		{
			Id = stage.StageId,
			IsPassed = (stage.State == RoleTowerStageState.Passed),
			IsCurrent = (stage.State == RoleTowerStageState.Current),
			PassRemainTime = stage.PassRemainTimeMs
		};
		foreach (RoleTowerRoleBrief roleTowerRoleBrief in stage.PassRoles)
		{
			roleTowerStageData.PassTeamRoleIds.Add(roleTowerRoleBrief.RoleIdOrTrialRoleId);
		}
		foreach (RoleTowerRoleSnapshot roleTowerRoleSnapshot in stage.RoleSnapshots)
		{
			RoleTowerRoleSnapshotData roleTowerRoleSnapshotData = new RoleTowerRoleSnapshotData
			{
				RoleId = roleTowerRoleSnapshot.RoleIdOrTrialRoleId,
				WeaponIncId = roleTowerRoleSnapshot.WeaponIncId
			};
			roleTowerRoleSnapshotData.PhantomIncIds.AddRange(roleTowerRoleSnapshot.PhantomIncIds);
			roleTowerStageData.RoleSnapshots.Add(roleTowerRoleSnapshotData);
		}
		stageBucket[stage.StageId] = roleTowerStageData;
		foreach (RoleTowerFloorInfo floor in stage.FloorInfos)
		{
			RoleTowerModel.WriteFloorInfo(floorBucket, floor);
		}
	}

	// Token: 0x0601237C RID: 74620 RVA: 0x0055E280 File Offset: 0x0055C480
	private static void WriteFloorInfo(Dictionary<int, RoleTowerFloorData> floorBucket, RoleTowerFloorInfo floor)
	{
		if (floor == null)
		{
			return;
		}
		floorBucket[floor.FloorId] = new RoleTowerFloorData
		{
			Id = floor.FloorId,
			IsPassed = floor.IsPassed,
			PassRemainTime = floor.PassRemainTimeMs
		};
	}

	// Token: 0x0601237D RID: 74621 RVA: 0x0055E2BC File Offset: 0x0055C4BC
	private void WriteTokenPanel(RoleTowerTokenPanelInfo panel)
	{
		if (panel == null)
		{
			return;
		}
		HashSet<int> hashSet = new HashSet<int>();
		foreach (KeyValuePair<int, RoleTowerTokenData> keyValuePair in this.TokenStateMap)
		{
			RoleTowerTokenData value = keyValuePair.Value;
			if (value != null && value.IsNew)
			{
				hashSet.Add(keyValuePair.Key);
			}
		}
		this.TokenStateMap.Clear();
		foreach (RoleTowerTokenInfo roleTowerTokenInfo in panel.Tokens)
		{
			this.TokenStateMap[roleTowerTokenInfo.TokenId] = new RoleTowerTokenData
			{
				Id = roleTowerTokenInfo.TokenId,
				IsUnlocked = (roleTowerTokenInfo.Count > 0),
				RemainCount = roleTowerTokenInfo.Count,
				CdEndTime = roleTowerTokenInfo.CdEndTimeMs,
				IsCarried = (roleTowerTokenInfo.TokenId == this.CurEquipTokenId),
				IsNew = hashSet.Contains(roleTowerTokenInfo.TokenId)
			};
		}
	}

	// Token: 0x0601237E RID: 74622 RVA: 0x0055E3F4 File Offset: 0x0055C5F4
	private void WriteUnlockTokens(IEnumerable<int> tokenIds)
	{
		if (tokenIds == null)
		{
			return;
		}
		foreach (int num in tokenIds)
		{
			RoleTowerTokenData roleTowerTokenData;
			if (this.TokenStateMap.TryGetValue(num, out roleTowerTokenData) && roleTowerTokenData != null)
			{
				roleTowerTokenData.IsUnlocked = true;
			}
			else
			{
				this.TokenStateMap[num] = new RoleTowerTokenData
				{
					Id = num,
					IsUnlocked = true,
					IsCarried = (num == this.CurEquipTokenId)
				};
			}
		}
	}

	// Token: 0x0601237F RID: 74623 RVA: 0x0055E484 File Offset: 0x0055C684
	private void WriteLimitTasks(IEnumerable<ConditionTask> tasks)
	{
		if (tasks == null)
		{
			return;
		}
		foreach (ConditionTask conditionTask in tasks)
		{
			this.RewardStateMap[conditionTask.Id] = new RoleTowerRewardData
			{
				Id = conditionTask.Id,
				State = RoleTowerModel.ToRewardState(conditionTask.Status),
				Progress = conditionTask.Current,
				Target = conditionTask.Target
			};
		}
	}

	// Token: 0x06012380 RID: 74624 RVA: 0x0055E514 File Offset: 0x0055C714
	private static ERoleTowerRewardState ToRewardState(ConditionTaskState status)
	{
		ERoleTowerRewardState result;
		if (status != ConditionTaskState.ConditionTaskFinish)
		{
			if (status != ConditionTaskState.ConditionTaskTaken)
			{
				result = ERoleTowerRewardState.UnFinish;
			}
			else
			{
				result = ERoleTowerRewardState.Received;
			}
		}
		else
		{
			result = ERoleTowerRewardState.CanReceive;
		}
		return result;
	}

	// Token: 0x06012381 RID: 74625 RVA: 0x0055E538 File Offset: 0x0055C738
	private void RebuildScoreRewardStates(IEnumerable<int> receivedIds)
	{
		if (receivedIds != null)
		{
			this.ReceivedScoreRewardIds.Clear();
			foreach (int item in receivedIds)
			{
				this.ReceivedScoreRewardIds.Add(item);
			}
		}
		this.ScoreRewardStateMap.Clear();
		foreach (RoleTowerScoreReward roleTowerScoreReward in this.GetScoreRewardCfgList())
		{
			ERoleTowerRewardState state;
			if (this.ReceivedScoreRewardIds.Contains(roleTowerScoreReward.Id))
			{
				state = ERoleTowerRewardState.Received;
			}
			else if (this.CurScore >= roleTowerScoreReward.NeedScore)
			{
				state = ERoleTowerRewardState.CanReceive;
			}
			else
			{
				state = ERoleTowerRewardState.UnFinish;
			}
			this.ScoreRewardStateMap[roleTowerScoreReward.Id] = new RoleTowerScoreRewardData
			{
				Id = roleTowerScoreReward.Id,
				State = state
			};
		}
	}

	// Token: 0x06012382 RID: 74626 RVA: 0x0055E630 File Offset: 0x0055C830
	private void WritePrepareInfo(RoleTowerPrepareInfo info)
	{
		if (info == null)
		{
			return;
		}
		RoleTowerPrepareSelection activeStageSelection = this.ActiveStageSelection;
		bool flag = this.ActiveChallengeId != info.ChallengeId || this.ActiveStageId != info.CurStageId;
		this.ActiveChallengeId = info.ChallengeId;
		this.ActiveStageId = info.CurStageId;
		RoleTowerPrepareSelection roleTowerPrepareSelection = new RoleTowerPrepareSelection
		{
			EquipTokenId = info.EquipTokenId,
			BranchIndex = (flag ? 0 : ((activeStageSelection != null) ? activeStageSelection.BranchIndex : 0))
		};
		foreach (RoleTowerRoleBrief roleTowerRoleBrief in info.Roles)
		{
			RoleTowerRoleBrief roleTowerRoleBrief2 = roleTowerRoleBrief.Clone();
			if (roleTowerRoleBrief2.SkillBranchId == 0)
			{
				roleTowerRoleBrief2.SkillBranchId = RoleModel.Instance.GetRoleCurrentBranchId(roleTowerRoleBrief2.RoleIdOrTrialRoleId);
				if (activeStageSelection != null)
				{
					foreach (RoleTowerRoleBrief roleTowerRoleBrief3 in activeStageSelection.Roles)
					{
						if (roleTowerRoleBrief3.RoleIdOrTrialRoleId == roleTowerRoleBrief2.RoleIdOrTrialRoleId)
						{
							roleTowerRoleBrief2.SkillBranchId = roleTowerRoleBrief3.SkillBranchId;
							break;
						}
					}
				}
			}
			roleTowerPrepareSelection.Roles.Add(roleTowerRoleBrief2);
		}
		this.ActiveStageSelection = roleTowerPrepareSelection;
		if (flag)
		{
			this.CheckPointBranchFloorInfo = null;
			this.CurSelectBranchId = 0;
		}
		if (info.NeedBranchSelect && info.BranchFloorInfo != null)
		{
			this.CheckPointBranchFloorInfo = info.BranchFloorInfo.Clone();
		}
		this.CurSelectLevelId = info.ChallengeId;
		this.CurSelectStageId = info.CurStageId;
		this.CurSelectFloorId = 0;
		this.CurNeedBranchSelect = info.NeedBranchSelect;
		this.CurBranchFloorInfo = (info.NeedBranchSelect ? info.BranchFloorInfo : null);
		this.ClearBattleTimer(info.RemainTimeMs);
		if (flag)
		{
			this.BattleWaveRecords.Clear();
		}
		this.CurEquipTokenId = info.EquipTokenId;
		this.FatigueMap.Clear();
		foreach (RoleTowerRoleEnergyInfo roleTowerRoleEnergyInfo in info.RoleEnergyInfos)
		{
			this.FatigueMap[roleTowerRoleEnergyInfo.RoleIdOrTrialRoleId] = roleTowerRoleEnergyInfo.CurEnergy;
		}
		this.WriteTokenPanel(info.TokenPanelInfo);
		if (info.NeedOpenUi)
		{
			this.IsCheckPointOpen = false;
			this.CaptureCheckPointResources(info.RemainTimeMs, false);
			this.RestoreBattleSelectionForPrepare();
		}
		this.CurTeamStar = 0;
		this.CurEchoLevel = 1;
		this.CurEchoExp = 0;
		this.LastSettleEchoOldLevel = this.CurEchoLevel;
		this.LastSettleEchoOldExp = this.CurEchoExp;
		this.NeedStarUp = false;
		foreach (KeyValuePair<int, int> keyValuePair in info.TeamStarInfo)
		{
			this.CurTeamStar = keyValuePair.Value;
		}
		this.HasEchoLevel = (info.PhantomInfo != null);
		if (info.PhantomInfo != null)
		{
			this.CurEchoLevel = info.PhantomInfo.Level;
			this.CurEchoExp = info.PhantomInfo.CurExp;
			this.LastSettleEchoOldLevel = this.CurEchoLevel;
			this.LastSettleEchoOldExp = this.CurEchoExp;
			if (info.CurStageId != this.StageStartEchoStageId)
			{
				this.StageStartEchoLevel = this.CurEchoLevel;
				this.StageStartEchoExp = this.CurEchoExp;
				this.StageStartEchoStageId = info.CurStageId;
			}
		}
		if (info.StageInfos.Count > 0)
		{
			this.ClearInDungeonState();
			this.InDungeonLevelId = info.ChallengeId;
			using (IEnumerator<RoleTowerStageInfo> enumerator5 = info.StageInfos.GetEnumerator())
			{
				while (enumerator5.MoveNext())
				{
					RoleTowerStageInfo stage = enumerator5.Current;
					this.WriteStageInfo(info.ChallengeId, stage);
					RoleTowerModel.WriteStageInfo(this.InDungeonStageStateMap, this.InDungeonFloorStateMap, stage);
				}
				goto IL_3B6;
			}
		}
		this.RebuildStageStateFromFloors(info.ChallengeId);
		IL_3B6:
		this.CurProgressLevelId = info.ChallengeId;
	}

	// Token: 0x06012383 RID: 74627 RVA: 0x0055EA40 File Offset: 0x0055CC40
	private void RebuildStageStateFromFloors(int levelId)
	{
		int curSelectLevelId = this.CurSelectLevelId;
		this.CurSelectLevelId = levelId;
		Dictionary<int, RoleTowerStageData> orCreateStageStateBucket = this.GetOrCreateStageStateBucket(levelId);
		foreach (RoleTowerStage roleTowerStage in this.GetStageCfgListByLevel(levelId))
		{
			RoleTowerStageData roleTowerStageData = this.AggregateStageState(roleTowerStage.Id);
			if (roleTowerStageData != null)
			{
				orCreateStageStateBucket[roleTowerStage.Id] = roleTowerStageData;
			}
		}
		this.CurSelectLevelId = curSelectLevelId;
	}

	// Token: 0x06012384 RID: 74628 RVA: 0x0055EAC8 File Offset: 0x0055CCC8
	public void OnSaveDeleteResponse(int challengeId, RoleTowerSaveDeleteResponse resp)
	{
		if (resp == null || resp.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			return;
		}
		RoleTowerLevelData roleTowerLevelData;
		if (this.LevelStateMap.TryGetValue(challengeId, out roleTowerLevelData))
		{
			roleTowerLevelData.HasSave = false;
		}
		EventSystem.Instance.Emit(EEventName.RoleTowerInfoUpdate);
	}

	// Token: 0x06012385 RID: 74629 RVA: 0x0055EB08 File Offset: 0x0055CD08
	public bool OnStepAdvanceResponse(RoleTowerStepAdvanceResponse resp)
	{
		if (resp == null || resp.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "RoleTower.StepAdvance 失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("errorCode", (resp != null) ? new Aki.Protocol.ErrorCode?(resp.ErrorCode) : null);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		return true;
	}

	// Token: 0x06012386 RID: 74630 RVA: 0x0055EB68 File Offset: 0x0055CD68
	public void OnStageSettleResponse(RoleTowerStageSettleResponse resp)
	{
		if (resp == null || resp.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "RoleTower.StageSettle 失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("errorCode", (resp != null) ? new Aki.Protocol.ErrorCode?(resp.ErrorCode) : null);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x06012387 RID: 74631 RVA: 0x0055EBC4 File Offset: 0x0055CDC4
	public bool OnStageRetryResponse(RoleTowerStageRetryResponse resp)
	{
		if (resp == null || resp.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "RoleTower.StageRetry 失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("errorCode", (resp != null) ? new Aki.Protocol.ErrorCode?(resp.ErrorCode) : null);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.BattleWaveRecords.Clear();
		this.LastSettle = null;
		this.LastSettleRecord = null;
		this.LastSettleGainTokens.Clear();
		this.CurEchoLevel = this.StageStartEchoLevel;
		this.CurEchoExp = this.StageStartEchoExp;
		this.LastSettleEchoOldLevel = this.StageStartEchoLevel;
		this.LastSettleEchoOldExp = this.StageStartEchoExp;
		EventSystem.Instance.Emit(EEventName.RoleTowerBattleWaveUpdate);
		return true;
	}

	// Token: 0x06012388 RID: 74632 RVA: 0x0055EC85 File Offset: 0x0055CE85
	public void OnChallengeSettleResponse(RoleTowerChallengeSettleResponse resp)
	{
	}

	// Token: 0x06012389 RID: 74633 RVA: 0x0055EC88 File Offset: 0x0055CE88
	[NullableContext(2)]
	public unsafe void OnAttributeQueryResponse(int roleId, RoleTowerAttributeQueryResponse resp)
	{
		if (resp == null || resp.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			this.RoleAttrInfoMap.Remove(roleId);
			this.RoleQueryPhantomLevelMap.Remove(roleId);
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "RoleTower 角色属性查询失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", roleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ErrorCode", (resp != null) ? new Aki.Protocol.ErrorCode?(resp.ErrorCode) : null);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		foreach (RoleTowerRoleAttributeInfo roleTowerRoleAttributeInfo in resp.RoleInfos)
		{
			if (roleTowerRoleAttributeInfo != null)
			{
				int key = (roleTowerRoleAttributeInfo.RoleProp != null && roleTowerRoleAttributeInfo.RoleProp.RoleId > 0) ? roleTowerRoleAttributeInfo.RoleProp.RoleId : roleId;
				this.RoleAttrInfoMap[key] = roleTowerRoleAttributeInfo;
				this.RoleQueryPhantomLevelMap[key] = resp.PhantomLevel;
			}
		}
	}

	// Token: 0x0601238A RID: 74634 RVA: 0x0055EDB4 File Offset: 0x0055CFB4
	[NullableContext(2)]
	public RolePropInfo GetQueryRoleProp(int roleId)
	{
		RoleTowerRoleAttributeInfo roleTowerRoleAttributeInfo;
		if (!this.RoleAttrInfoMap.TryGetValue(roleId, out roleTowerRoleAttributeInfo))
		{
			return null;
		}
		return roleTowerRoleAttributeInfo.RoleProp;
	}

	// Token: 0x0601238B RID: 74635 RVA: 0x0055EDD9 File Offset: 0x0055CFD9
	[NullableContext(2)]
	public Dictionary<int, int> GetQueryPhantomTotalAttrs(int roleId)
	{
		RolePropInfo queryRoleProp = this.GetQueryRoleProp(roleId);
		return RoleTowerModel.SumPhantomPropInfo((queryRoleProp != null) ? queryRoleProp.PhantomProp : null);
	}

	// Token: 0x0601238C RID: 74636 RVA: 0x0055EDF4 File Offset: 0x0055CFF4
	public int GetQuerySubPropExtraRate(int roleId)
	{
		int level;
		if (!this.RoleQueryPhantomLevelMap.TryGetValue(roleId, out level))
		{
			return 0;
		}
		return this.GetEchoSubPropExtraRate(level);
	}

	// Token: 0x0601238D RID: 74637 RVA: 0x0055EE1C File Offset: 0x0055D01C
	[NullableContext(2)]
	private static Dictionary<int, int> SumPhantomPropInfo(RolePhantomPropInfo prop)
	{
		if (prop == null)
		{
			return null;
		}
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (ArrayIntInt arrayIntInt in prop.BaseProp)
		{
			int num;
			dictionary[arrayIntInt.Key] = (dictionary.TryGetValue(arrayIntInt.Key, out num) ? (num + arrayIntInt.Value) : arrayIntInt.Value);
		}
		foreach (ArrayIntInt arrayIntInt2 in prop.AddProp)
		{
			int num2;
			dictionary[arrayIntInt2.Key] = (dictionary.TryGetValue(arrayIntInt2.Key, out num2) ? (num2 + arrayIntInt2.Value) : arrayIntInt2.Value);
		}
		return dictionary;
	}

	// Token: 0x0601238E RID: 74638 RVA: 0x0055EF04 File Offset: 0x0055D104
	public void OnRankResponse(RoleTowerRankResponse resp)
	{
		if (resp == null)
		{
			return;
		}
		if (resp.ErrorCode == Aki.Protocol.ErrorCode.RoleTowerRankRequestInCd)
		{
			EventSystem.Instance.Emit(EEventName.RoleTowerRankUpdate);
			return;
		}
		if (resp.ErrorCode == Aki.Protocol.ErrorCode.RoleTowerRankEntranceClosed)
		{
			ErrorCodeController.Instance.OpenErrorCodeTipView(resp.ErrorCode, EResponseMessageId.RoleTowerRankResponse, null, true, true);
			if (UiManager.Instance.GetViewByName(EUiViewName.RoleTowerRankView) != null)
			{
				UiManager.Instance.CloseView(EUiViewName.RoleTowerRankView, null);
			}
			return;
		}
		if (resp.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			return;
		}
		this.RankCacheMap.Clear();
		if (resp.RankInfo != null)
		{
			foreach (RoleTowerRankInfo roleTowerRankInfo in resp.RankInfo)
			{
				if (roleTowerRankInfo != null)
				{
					this.WriteRankInfo(roleTowerRankInfo.ChallengeId, roleTowerRankInfo);
				}
			}
		}
		EventSystem.Instance.Emit(EEventName.RoleTowerRankUpdate);
		ActivityRoleTowerController.RefreshActivityRedDot();
	}

	// Token: 0x0601238F RID: 74639 RVA: 0x0055EFF4 File Offset: 0x0055D1F4
	public void OnRankRewardReceiveResponse(RoleTowerRankRewardReceiveResponse resp)
	{
		if (resp == null || resp.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			return;
		}
		EventSystem.Instance.Emit(EEventName.RoleTowerRankUpdate);
	}

	// Token: 0x06012390 RID: 74640 RVA: 0x0055F014 File Offset: 0x0055D214
	public void OnRewardTaskReceiveResponse(RoleTowerRewardTaskReceiveResponse resp, int[] taskIds)
	{
		if (resp == null || resp.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			return;
		}
		if (taskIds != null)
		{
			foreach (int num in taskIds)
			{
				RoleTowerRewardData roleTowerRewardData2;
				RoleTowerRewardData roleTowerRewardData = this.RewardStateMap.TryGetValue(num, out roleTowerRewardData2) ? roleTowerRewardData2 : null;
				this.RewardStateMap[num] = new RoleTowerRewardData
				{
					Id = num,
					State = ERoleTowerRewardState.Received,
					Progress = ((roleTowerRewardData != null) ? roleTowerRewardData.Progress : 0),
					Target = ((roleTowerRewardData != null) ? roleTowerRewardData.Target : 0)
				};
			}
		}
		EventSystem.Instance.Emit(EEventName.RoleTowerRewardReceive);
	}

	// Token: 0x06012391 RID: 74641 RVA: 0x0055F0B0 File Offset: 0x0055D2B0
	public void OnScoreRewardReceiveResponse(RoleTowerScoreRewardReceiveResponse resp, int[] rewardIds)
	{
		if (resp == null || resp.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			return;
		}
		if (rewardIds != null)
		{
			foreach (int item in rewardIds)
			{
				this.ReceivedScoreRewardIds.Add(item);
			}
			this.RebuildScoreRewardStates(null);
		}
		EventSystem.Instance.Emit(EEventName.RoleTowerRewardReceive);
	}

	// Token: 0x06012392 RID: 74642 RVA: 0x0055F104 File Offset: 0x0055D304
	public unsafe void OnConsumeItemResponse(RoleTowerConsumeItemResponse resp, int itemId)
	{
		if (resp == null || resp.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "RoleTower.ConsumeItem 失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("errorCode", (resp != null) ? new Aki.Protocol.ErrorCode?(resp.ErrorCode) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("itemId", itemId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.PlayTokenItemSkill(itemId);
	}

	// Token: 0x06012393 RID: 74643 RVA: 0x0055F198 File Offset: 0x0055D398
	private unsafe void PlayTokenItemSkill(int itemId)
	{
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(itemId);
		int num;
		if (itemConfig == null || !itemConfig.Value.Parameters().TryGetValue(21, out num) || num <= 0)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "RoleTower.ConsumeItem 成功但道具未配 UseExploreSkill 技能，跳过放技能";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", itemId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
		CharacterSkillComponent characterSkillComponent = (worldEntity != null) ? worldEntity.GetComponent<CharacterSkillComponent>() : null;
		if (characterSkillComponent == null || !characterSkillComponent.Valid)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Temp;
			ELogAuthor author2 = ELogAuthor.LJQ;
			string message2 = "RoleTower.ConsumeItem 放技能失败：当前主控角色无有效技能组件";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("itemId", itemId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("skillId", num);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		characterSkillComponent.BeginSkillAsync(num, new SkillParam
		{
			Reason = "RoleTower token item: UseSkill"
		});
		global::Log instance3 = global::Log.Instance;
		ELogModule module3 = ELogModule.Temp;
		ELogAuthor author3 = ELogAuthor.LJQ;
		string message3 = "RoleTower.ConsumeItem 成功，本地释放信物技能";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("itemId", itemId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("skillId", num);
		instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
	}

	// Token: 0x06012394 RID: 74644 RVA: 0x0055F308 File Offset: 0x0055D508
	public unsafe void OnStepUpdateNotify(RoleTowerStepUpdateNotify notify)
	{
		if (notify == null)
		{
			global::Log.Instance.Info(ELogModule.Temp, ELogAuthor.LJQ, "[角色爬塔][阶段通知] 收到空 notify，忽略", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Temp;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "[角色爬塔][阶段通知] 收到 StepUpdateNotify";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("阶段类型", notify.StepPbDataCase.ToString());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		RoleTowerStepUpdateNotify.StepPbDataOneofCase stepPbDataCase = notify.StepPbDataCase;
		if (stepPbDataCase == RoleTowerStepUpdateNotify.StepPbDataOneofCase.PrepareStepPbData)
		{
			RoleTowerPrepareStepPbData prepareStepPbData = notify.PrepareStepPbData;
			RoleTowerPrepareInfo roleTowerPrepareInfo = (prepareStepPbData != null) ? prepareStepPbData.PrepareInfo : null;
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Temp;
			ELogAuthor author2 = ELogAuthor.LJQ;
			string message2 = "[角色爬塔][阶段通知] 准备阶段";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("hasPrepareInfo", roleTowerPrepareInfo != null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("challengeId", (roleTowerPrepareInfo != null) ? roleTowerPrepareInfo.ChallengeId : 0);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("curStageId", (roleTowerPrepareInfo != null) ? roleTowerPrepareInfo.CurStageId : 0);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("remainTimeMs", (roleTowerPrepareInfo != null) ? roleTowerPrepareInfo.RemainTimeMs : 0L);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("equipTokenId", (roleTowerPrepareInfo != null) ? roleTowerPrepareInfo.EquipTokenId : 0);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("needBranchSelect", roleTowerPrepareInfo != null && roleTowerPrepareInfo.NeedBranchSelect);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("needOpenUi", roleTowerPrepareInfo != null && roleTowerPrepareInfo.NeedOpenUi);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
			this.WritePrepareInfo(roleTowerPrepareInfo);
			RoleTowerPrepareStepPbData prepareStepPbData2 = notify.PrepareStepPbData;
			bool flag;
			if (prepareStepPbData2 == null)
			{
				flag = false;
			}
			else
			{
				RoleTowerPrepareInfo prepareInfo = prepareStepPbData2.PrepareInfo;
				flag = ((prepareInfo != null) ? new bool?(prepareInfo.NeedOpenUi) : null).GetValueOrDefault();
			}
			if (flag)
			{
				this.OpenInPrepareView(this.CurSelectStageId);
			}
			EventSystem.Instance.Emit<int>(EEventName.RoleTowerLevelUpdate, this.CurSelectStageId);
			return;
		}
		if (stepPbDataCase == RoleTowerStepUpdateNotify.StepPbDataOneofCase.TeamUpgradeStepPbData)
		{
			global::Log instance3 = global::Log.Instance;
			ELogModule module3 = ELogModule.Temp;
			ELogAuthor author3 = ELogAuthor.LJQ;
			string message3 = "[角色爬塔][阶段通知] 队伍升星阶段";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("curStageId", this.CurSelectStageId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("curTeamStar", this.CurTeamStar);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			this.NeedStarUp = true;
			this.OpenStarUpView();
			EventSystem.Instance.Emit<int>(EEventName.RoleTowerLevelUpdate, this.CurSelectStageId);
			return;
		}
		switch (stepPbDataCase)
		{
		case RoleTowerStepUpdateNotify.StepPbDataOneofCase.SettleStepPbData:
		{
			RoleTowerSettleStepPbData settleStepPbData = notify.SettleStepPbData;
			SettleStepPbData settleStepPbData2 = (settleStepPbData != null) ? settleStepPbData.StageSettleInfo : null;
			global::Log instance4 = global::Log.Instance;
			ELogModule module4 = ELogModule.Temp;
			ELogAuthor author4 = ELogAuthor.LJQ;
			string message4 = "[角色爬塔][阶段通知] 阶段结算";
			<>y__InlineArray8<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray8<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("hasSettleInfo", settleStepPbData2 != null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("challengeId", (settleStepPbData2 != null) ? settleStepPbData2.ChallengeId : 0);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("stageId", (settleStepPbData2 != null) ? settleStepPbData2.StageId : 0);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("floorId", (settleStepPbData2 != null) ? settleStepPbData2.FloorId : 0);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 4) = new ValueTuple<string, object>("branchIndex", (settleStepPbData2 != null) ? settleStepPbData2.BranchIndex : 0);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 5) = new ValueTuple<string, object>("costTimeMs", (settleStepPbData2 != null) ? settleStepPbData2.CostTimeMs : 0L);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 6) = new ValueTuple<string, object>("gainTimeMs", (settleStepPbData2 != null) ? settleStepPbData2.GainTimeMs : 0L);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 7) = new ValueTuple<string, object>("remainTimeMs", (settleStepPbData2 != null) ? settleStepPbData2.RemainTimeMs : 0L);
			instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 8));
			this.OnStepSettle(settleStepPbData2);
			this.OpenFloorSettleView((settleStepPbData2 != null) ? settleStepPbData2.FloorId : this.CurSelectFloorId);
			return;
		}
		case RoleTowerStepUpdateNotify.StepPbDataOneofCase.LoadSubLevelStepPbData:
		{
			RoleTowerLoadSubLevelStepPbData loadSubLevelStepPbData = notify.LoadSubLevelStepPbData;
			global::Log instance5 = global::Log.Instance;
			ELogModule module5 = ELogModule.Temp;
			ELogAuthor author5 = ELogAuthor.LJQ;
			string message5 = "[角色爬塔][阶段通知] 子关加载阶段";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0);
			string item = "待加载子关数";
			int? num;
			if (loadSubLevelStepPbData == null)
			{
				num = null;
			}
			else
			{
				RepeatedField<string> loadSubLevels = loadSubLevelStepPbData.LoadSubLevels;
				num = ((loadSubLevels != null) ? new int?(loadSubLevels.Count) : null);
			}
			int? num2 = num;
			ptr = new ValueTuple<string, object>(item, num2.GetValueOrDefault());
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1);
			string item2 = "待卸载子关数";
			int? num3;
			if (loadSubLevelStepPbData == null)
			{
				num3 = null;
			}
			else
			{
				RepeatedField<string> unLoadSubLevels = loadSubLevelStepPbData.UnLoadSubLevels;
				num3 = ((unLoadSubLevels != null) ? new int?(unLoadSubLevels.Count) : null);
			}
			num2 = num3;
			ptr2 = new ValueTuple<string, object>(item2, num2.GetValueOrDefault());
			instance5.Info(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
			RoleTowerController.Instance.HandleLoadSubLevel(loadSubLevelStepPbData);
			return;
		}
		case RoleTowerStepUpdateNotify.StepPbDataOneofCase.BattleStepPbData:
		{
			RoleTowerBattleStepPbData battleStepPbData = notify.BattleStepPbData;
			RoleTowerTimerData roleTowerTimerData = (battleStepPbData != null) ? battleStepPbData.TimeData : null;
			bool flag2 = roleTowerTimerData != null && roleTowerTimerData.StartTime > 0L;
			global::Log instance6 = global::Log.Instance;
			ELogModule module6 = ELogModule.Temp;
			ELogAuthor author6 = ELogAuthor.LJQ;
			string message6 = "[角色爬塔][阶段通知] 战斗阶段";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("进战/出战", flag2 ? "进入战斗" : "结束战斗");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("hasTimeData", roleTowerTimerData != null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 2) = new ValueTuple<string, object>("startTime", (roleTowerTimerData != null) ? roleTowerTimerData.StartTime : 0L);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 3) = new ValueTuple<string, object>("duration", (roleTowerTimerData != null) ? roleTowerTimerData.Duration : 0L);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 4) = new ValueTuple<string, object>("pauseEndTime", (roleTowerTimerData != null) ? roleTowerTimerData.PauseEndTime : 0L);
			instance6.Info(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 5));
			this.SetBattleTimer(roleTowerTimerData);
			this.SetInBattle(flag2);
			EventSystem.Instance.Emit(EEventName.RoleTowerBattleTimeUpdate);
			return;
		}
		default:
		{
			global::Log instance7 = global::Log.Instance;
			ELogModule module7 = ELogModule.Temp;
			ELogAuthor author7 = ELogAuthor.LJQ;
			string message7 = "[角色爬塔][阶段通知] 未识别阶段类型(StepPbDataCase 未命中任何分支)";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("stepPbDataCase", notify.StepPbDataCase.ToString());
			instance7.Info(module7, author7, message7, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		}
	}

	// Token: 0x06012395 RID: 74645 RVA: 0x0055F9CC File Offset: 0x0055DBCC
	private void OnStepSettle(SettleStepPbData settle)
	{
		if (settle == null)
		{
			return;
		}
		foreach (KeyValuePair<int, int> keyValuePair in settle.TeamStarInfo)
		{
			this.CurTeamStar = keyValuePair.Value;
		}
		this.LastSettleEchoOldLevel = this.StageStartEchoLevel;
		this.LastSettleEchoOldExp = this.StageStartEchoExp;
		if (settle.PhantomInfo != null)
		{
			this.HasEchoLevel = true;
			this.CurEchoLevel = settle.PhantomInfo.Level;
			this.CurEchoExp = settle.PhantomInfo.CurExp;
		}
		this.ClearBattleTimer(settle.RemainTimeMs);
		this.LastSettle = new RoleTowerSettleData
		{
			RemainTime = settle.RemainTimeMs,
			TotalCostTime = settle.CostTimeMs,
			TotalGetTime = settle.GainTimeMs
		};
		this.LastSettleGainTokens.Clear();
		foreach (RoleTowerTokenCount roleTowerTokenCount in settle.GainTokens)
		{
			this.LastSettleGainTokens.Add(roleTowerTokenCount);
			this.MarkTokenAsNew(roleTowerTokenCount.TokenId, roleTowerTokenCount.Count);
		}
		EventSystem.Instance.Emit(EEventName.RoleTowerBattleWaveUpdate);
	}

	// Token: 0x06012396 RID: 74646 RVA: 0x0055FB18 File Offset: 0x0055DD18
	public void OnTimerDataUpdateNotify(RoleTowerTimerDataUpdateNotify notify)
	{
		RoleTowerTimerData roleTowerTimerData = (notify != null) ? notify.TimeData : null;
		long num = 0L;
		if (roleTowerTimerData != null && this.TimerActive && this.TimerStartTime == roleTowerTimerData.StartTime)
		{
			num = roleTowerTimerData.Duration - this.TimerDuration;
		}
		this.SetBattleTimer(roleTowerTimerData);
		this.EnsureInBattleOnTimerStarted(roleTowerTimerData);
		EventSystem.Instance.Emit(EEventName.RoleTowerBattleTimeUpdate);
		if (num != 0L)
		{
			this.LastTimeDelta = num;
			EventSystem.Instance.Emit(EEventName.RoleTowerBattleTimeDeltaUpdate);
		}
	}

	// Token: 0x06012397 RID: 74647 RVA: 0x0055FB94 File Offset: 0x0055DD94
	[NullableContext(2)]
	private void EnsureInBattleOnTimerStarted(RoleTowerTimerData timeData)
	{
		if (timeData == null || timeData.StartTime <= 0L || this.IsInBattle || !this.IsInRoleTowerDungeon())
		{
			return;
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Temp;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "[角色爬塔][计时] 计时起算但未在战斗态，补切战斗态";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("startTime", timeData.StartTime);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.SetInBattle(true);
	}

	// Token: 0x06012398 RID: 74648 RVA: 0x0055FBF8 File Offset: 0x0055DDF8
	public void OnTimerDurationUpdateNotify(RoleTowerTimerDurationUpdateNotify notify)
	{
		if (notify == null)
		{
			return;
		}
		long num = 0L;
		foreach (int num2 in notify.DurationUpdates)
		{
			num += (long)num2;
		}
		this.SetBattleTimer(notify.TimeData);
		this.EnsureInBattleOnTimerStarted(notify.TimeData);
		if (num != 0L)
		{
			this.LastTimeDelta = num;
			EventSystem.Instance.Emit(EEventName.RoleTowerBattleTimeDeltaUpdate);
		}
	}

	// Token: 0x06012399 RID: 74649 RVA: 0x0055FC7C File Offset: 0x0055DE7C
	public void OnScoreUpdateNotify(RoleTowerScoreUpdateNotify notify)
	{
		if (notify != null)
		{
			this.CurScore = notify.Score;
		}
		this.RebuildScoreRewardStates(null);
		EventSystem.Instance.Emit(EEventName.RoleTowerInfoUpdate);
	}

	// Token: 0x0601239A RID: 74650 RVA: 0x0055FCA4 File Offset: 0x0055DEA4
	public void OnChallengeSettleNotify(RoleTowerChallengeSettleNotify notify)
	{
		this.WriteSettleInfo((notify != null) ? notify.ChallengeSettleInfo : null);
		this.ClearInDungeonState();
		this.SetInBattle(false);
		this.OpenResultView();
	}

	// Token: 0x0601239B RID: 74651 RVA: 0x0055FCCC File Offset: 0x0055DECC
	public void OnDieNotify(RoleTowerDieNotify notify)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleTowerDieSettleConfirm);
		confirmBoxDataNew.FunctionMap[1] = delegate()
		{
			RoleTowerController.Instance.ChallengeSettleRequest(this.CurSelectLevelId).Forget();
		};
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			this.RequestStageRetry();
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0601239C RID: 74652 RVA: 0x0055FD20 File Offset: 0x0055DF20
	public void OnRewardTaskUpdateNotify(RoleTowerRewardTaskUpdateNotify notify)
	{
		this.WriteLimitTasks((notify != null) ? notify.LimitTasks : null);
		EventSystem.Instance.Emit(EEventName.RoleTowerRewardReceive);
	}

	// Token: 0x0601239D RID: 74653 RVA: 0x0055FD44 File Offset: 0x0055DF44
	public void OnScoreTaskUpdateNotify(RoleTowerScoreTaskUpdateNotify notify)
	{
		if (((notify != null) ? notify.ScoreTasks : null) != null)
		{
			foreach (int item in notify.ScoreTasks)
			{
				this.ReceivedScoreRewardIds.Add(item);
			}
		}
		this.RebuildScoreRewardStates(null);
		EventSystem.Instance.Emit(EEventName.RoleTowerRewardReceive);
	}

	// Token: 0x0601239E RID: 74654 RVA: 0x0055FDBC File Offset: 0x0055DFBC
	public void OnChallengeUpdateNotify(RoleTowerChallengeUpdateNotify notify)
	{
		if (notify != null)
		{
			RoleTowerModel.NotifyNewRoleLevels(this.WriteChallengeInfos(notify.ChallengeInfos));
		}
		EventSystem.Instance.Emit(EEventName.RoleTowerInfoUpdate);
	}

	// Token: 0x0601239F RID: 74655 RVA: 0x0055FDE2 File Offset: 0x0055DFE2
	public void OnTokenUpdateNotify(RoleTowerTokenUpdateNotify notify)
	{
		this.WriteTokenPanel((notify != null) ? notify.TokenPanelInfo : null);
		RoleTowerTokenButtonItem tokenButtonItem = this.TokenButtonItem;
		if (tokenButtonItem != null)
		{
			tokenButtonItem.Refresh();
		}
		EventSystem.Instance.Emit(EEventName.RoleTowerInfoUpdate);
	}

	// Token: 0x060123A0 RID: 74656 RVA: 0x0055FE18 File Offset: 0x0055E018
	public void OnItemUpdateNotify(RoleTowerItemUpdateNotify notify)
	{
		if (notify == null)
		{
			return;
		}
		this.ItemCountMap.Clear();
		foreach (KeyValuePair<int, int> keyValuePair in notify.Items)
		{
			this.ItemCountMap[keyValuePair.Key] = keyValuePair.Value;
		}
		EventSystem.Instance.Emit(EEventName.RoleTowerItemUpdate);
		EventSystem.Instance.Emit(EEventName.RoleTowerInfoUpdate);
	}

	// Token: 0x060123A1 RID: 74657 RVA: 0x0055FEA8 File Offset: 0x0055E0A8
	public void OnFloorSettleNotify(RoleTowerFloorSettleNotify notify)
	{
		if (notify == null)
		{
			return;
		}
		RoleTowerWaveRecordData roleTowerWaveRecordData = this.BattleWaveRecords.Find((RoleTowerWaveRecordData r) => r.FloorId == notify.FloorId);
		if (roleTowerWaveRecordData == null)
		{
			roleTowerWaveRecordData = new RoleTowerWaveRecordData
			{
				FloorId = notify.FloorId
			};
			this.BattleWaveRecords.Insert(0, roleTowerWaveRecordData);
		}
		roleTowerWaveRecordData.RemainTime = notify.RemainTimeMs;
		roleTowerWaveRecordData.CostTime = notify.TotalCostTimeMs;
		roleTowerWaveRecordData.GainTime = notify.TotalGainTimeMs;
		EventSystem.Instance.Emit(EEventName.RoleTowerBattleWaveUpdate);
	}

	// Token: 0x060123A2 RID: 74658 RVA: 0x0055FF4D File Offset: 0x0055E14D
	public void OnUnlockTokenUpdateNotify(RoleTowerUnlockTokenUpdateNotify notify)
	{
		if (notify == null)
		{
			return;
		}
		this.WriteUnlockTokens(notify.UnlockTokens);
		EventSystem.Instance.Emit(EEventName.RoleTowerInfoUpdate);
	}

	// Token: 0x060123A3 RID: 74659 RVA: 0x0055FF70 File Offset: 0x0055E170
	private void WriteSettleInfo(RoleTowerChallengeSettleInfo info)
	{
		if (info == null)
		{
			return;
		}
		RoleTowerBestRecord currentRecord = info.CurrentRecord;
		long num = 0L;
		if (currentRecord != null)
		{
			foreach (RoleTowerStageRecord roleTowerStageRecord in currentRecord.StageRecords)
			{
				num += roleTowerStageRecord.GainTimeMs;
			}
		}
		this.LastSettleRecord = ((currentRecord != null) ? this.BuildBestRecordData(this.CurSelectLevel, currentRecord) : null);
		int num2 = (currentRecord != null) ? currentRecord.MainRoleId : 0;
		if (num2 <= 0)
		{
			num2 = this.GetSlotRoleId(ERoleTowerSlotType.Main);
		}
		if (num2 <= 0)
		{
			RoleTowerLevel? roleTowerLevel;
			num2 = ((this.GetLevelCfg(this.CurSelectLevel) != null) ? roleTowerLevel.GetValueOrDefault().MainRoleId : 0);
		}
		this.LastSettle = new RoleTowerSettleData
		{
			PassWave = ((currentRecord != null) ? currentRecord.PassedFloorCount : 0),
			RemainTime = ((currentRecord != null) ? currentRecord.RemainTimeMs : 0L),
			TotalGetTime = num,
			TotalCostTime = ((currentRecord != null) ? currentRecord.CostTimeMs : 0L),
			MainRoleId = num2,
			IsNewRecord = (info.IsBestRecordUpdated || (currentRecord != null && currentRecord.IsNewRecord)),
			SettleTimeStamp = ((currentRecord != null) ? currentRecord.SettleTime : 0L),
			Rank = info.CurrentRankPercent,
			RankErrorCode = info.RankErrorCode
		};
		if (this.LastSettle.IsNewRecord)
		{
			int num3 = (info.ChallengeId > 0) ? info.ChallengeId : this.CurSelectLevel;
			if (num3 > 0 && !this.IsTeachLevel(num3))
			{
				ActivityRoleTowerData data = ActivityRoleTowerController.Instance.Data;
				if (data == null)
				{
					return;
				}
				data.OnNewRecord(num3);
			}
		}
	}

	// Token: 0x060123A4 RID: 74660 RVA: 0x00560118 File Offset: 0x0055E318
	private void WriteRankInfo(int levelId, RoleTowerRankInfo info)
	{
		if (info == null || levelId <= 0)
		{
			return;
		}
		RoleTowerRankInfoCache roleTowerRankInfoCache = new RoleTowerRankInfoCache();
		foreach (RoleTowerRankEntry entry in info.FriendEntries)
		{
			roleTowerRankInfoCache.FriendList.Add(RoleTowerModel.ToRankData(entry));
		}
		roleTowerRankInfoCache.SelfServer = ((info.SelfServerEntry != null) ? RoleTowerModel.ToRankData(info.SelfServerEntry) : null);
		RoleTowerModel.MergeSelfIntoFriendList(roleTowerRankInfoCache);
		roleTowerRankInfoCache.RewardSettleTime = info.RewardSettleTime;
		roleTowerRankInfoCache.NextRefreshTime = RoleTowerModel.ToMilliseconds(info.NextRefreshTime);
		roleTowerRankInfoCache.CanGetServerReward = info.CanGetServerRankReward;
		roleTowerRankInfoCache.PreviewRewards.AddRange(info.RewardPreview);
		this.RankCacheMap[levelId] = roleTowerRankInfoCache;
	}

	// Token: 0x060123A5 RID: 74661 RVA: 0x005601E8 File Offset: 0x0055E3E8
	private static void MergeSelfIntoFriendList(RoleTowerRankInfoCache cache)
	{
		RoleTowerRankData selfServer = cache.SelfServer;
		if (selfServer != null && selfServer.PassWave > 0)
		{
			if (!cache.FriendList.Exists((RoleTowerRankData d) => d.IsSelf))
			{
				cache.FriendList.Add(new RoleTowerRankData
				{
					PlayerName = selfServer.PlayerName,
					HeadIcon = selfServer.HeadIcon,
					PassWave = selfServer.PassWave,
					RemainTime = selfServer.RemainTime,
					IsSelf = true,
					FuzzyPercent = selfServer.FuzzyPercent,
					IsNewRecord = selfServer.IsNewRecord
				});
				List<RoleTowerRankData> list = new List<RoleTowerRankData>(cache.FriendList);
				for (int i = 1; i < list.Count; i++)
				{
					RoleTowerRankData roleTowerRankData = list[i];
					int j;
					for (j = i - 1; j >= 0; j--)
					{
						RoleTowerRankData roleTowerRankData2 = list[j];
						if (roleTowerRankData2.PassWave >= roleTowerRankData.PassWave && (roleTowerRankData2.PassWave != roleTowerRankData.PassWave || roleTowerRankData2.RemainTime >= roleTowerRankData.RemainTime))
						{
							break;
						}
						list[j + 1] = roleTowerRankData2;
					}
					list[j + 1] = roleTowerRankData;
				}
				cache.FriendList.Clear();
				for (int k = 0; k < list.Count; k++)
				{
					list[k].Rank = k + 1;
					cache.FriendList.Add(list[k]);
				}
				return;
			}
		}
	}

	// Token: 0x060123A6 RID: 74662 RVA: 0x0056035D File Offset: 0x0055E55D
	private static long ToMilliseconds(long timestamp)
	{
		if (timestamp <= 0L || timestamp >= 100000000000L)
		{
			return timestamp;
		}
		return timestamp * 1000L;
	}

	// Token: 0x060123A7 RID: 74663 RVA: 0x0056037C File Offset: 0x0055E57C
	private static RoleTowerRankData ToRankData(RoleTowerRankEntry entry)
	{
		RoleTowerBestRecord record = entry.Record;
		RoleTowerRankData roleTowerRankData = new RoleTowerRankData();
		roleTowerRankData.Rank = entry.Rank;
		roleTowerRankData.PlayerName = (entry.Name ?? "");
		roleTowerRankData.Remark = (entry.Remark ?? "");
		roleTowerRankData.PassWave = ((record != null) ? record.PassedFloorCount : 0);
		roleTowerRankData.RemainTime = ((record != null) ? record.RemainTimeMs : 0L);
		int playerId = entry.PlayerId;
		int? id = PlayerInfoModel.Instance.GetId();
		roleTowerRankData.IsSelf = (playerId == id.GetValueOrDefault() & id != null);
		roleTowerRankData.FuzzyPercent = entry.RankPercent;
		roleTowerRankData.IsNewRecord = (record != null && record.IsNewRecord);
		return roleTowerRankData;
	}

	// Token: 0x17001B6B RID: 7019
	// (get) Token: 0x060123A8 RID: 74664 RVA: 0x00560436 File Offset: 0x0055E636
	public static RoleTowerModel Instance
	{
		get
		{
			return RoleTowerModel._Instance;
		}
	}

	// Token: 0x060123A9 RID: 74665 RVA: 0x0056043D File Offset: 0x0055E63D
	public static RoleTowerModel GetOrCreateInstance()
	{
		if (RoleTowerModel._Instance == null)
		{
			RoleTowerModel.CreateInstance();
		}
		return RoleTowerModel._Instance;
	}

	// Token: 0x060123AA RID: 74666 RVA: 0x00560451 File Offset: 0x0055E651
	public static bool CreateInstance()
	{
		if (RoleTowerModel._Instance != null)
		{
			return true;
		}
		RoleTowerModel._Instance = new RoleTowerModel();
		return true;
	}

	// Token: 0x060123AB RID: 74667 RVA: 0x00560467 File Offset: 0x0055E667
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060123AC RID: 74668 RVA: 0x00560469 File Offset: 0x0055E669
	public static void ResetStaticDefaultValue()
	{
		RoleTowerModel._Instance = null;
	}

	// Token: 0x060123AD RID: 74669 RVA: 0x00560474 File Offset: 0x0055E674
	static RoleTowerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleTowerModel.CreateStaticDefaultValue), new Action(RoleTowerModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009E8B RID: 40587
	private int CurActivityId;

	// Token: 0x04009E8C RID: 40588
	[Nullable(2)]
	private Action PendingIntroStartCallback;

	// Token: 0x04009E8D RID: 40589
	private readonly Dictionary<int, RoleTowerLevelData> LevelStateMap = new Dictionary<int, RoleTowerLevelData>();

	// Token: 0x04009E8E RID: 40590
	private readonly Dictionary<int, RoleTowerBestRecordData> BestRecordMap = new Dictionary<int, RoleTowerBestRecordData>();

	// Token: 0x04009E8F RID: 40591
	private readonly Dictionary<int, Dictionary<int, RoleTowerStageData>> StageStateMap = new Dictionary<int, Dictionary<int, RoleTowerStageData>>();

	// Token: 0x04009E90 RID: 40592
	private readonly Dictionary<int, Dictionary<int, RoleTowerFloorData>> FloorStateMap = new Dictionary<int, Dictionary<int, RoleTowerFloorData>>();

	// Token: 0x04009E91 RID: 40593
	private int InDungeonLevelId;

	// Token: 0x04009E92 RID: 40594
	private readonly Dictionary<int, RoleTowerStageData> InDungeonStageStateMap = new Dictionary<int, RoleTowerStageData>();

	// Token: 0x04009E93 RID: 40595
	private readonly Dictionary<int, RoleTowerFloorData> InDungeonFloorStateMap = new Dictionary<int, RoleTowerFloorData>();

	// Token: 0x04009E94 RID: 40596
	private readonly Dictionary<int, RoleTowerWaveData> WaveStateMap = new Dictionary<int, RoleTowerWaveData>();

	// Token: 0x04009E95 RID: 40597
	private readonly Dictionary<int, RoleTowerTokenData> TokenStateMap = new Dictionary<int, RoleTowerTokenData>();

	// Token: 0x04009E96 RID: 40598
	private readonly Dictionary<int, int> ItemCountMap = new Dictionary<int, int>();

	// Token: 0x04009E97 RID: 40599
	private readonly Dictionary<int, RoleTowerRewardData> RewardStateMap = new Dictionary<int, RoleTowerRewardData>();

	// Token: 0x04009E98 RID: 40600
	private readonly Dictionary<int, RoleTowerScoreRewardData> ScoreRewardStateMap = new Dictionary<int, RoleTowerScoreRewardData>();

	// Token: 0x04009E99 RID: 40601
	private readonly HashSet<int> ReceivedScoreRewardIds = new HashSet<int>();

	// Token: 0x04009E9A RID: 40602
	private long DungeonRemainTime;

	// Token: 0x04009E9B RID: 40603
	private bool TimerActive;

	// Token: 0x04009E9C RID: 40604
	private long TimerDuration;

	// Token: 0x04009E9D RID: 40605
	private long TimerStartTime;

	// Token: 0x04009E9E RID: 40606
	private long TimerPauseStartTime;

	// Token: 0x04009E9F RID: 40607
	private long TimerPauseEndTime;

	// Token: 0x04009EA0 RID: 40608
	private long TimerChangeTime;

	// Token: 0x04009EA1 RID: 40609
	private int CurTeamStar;

	// Token: 0x04009EA2 RID: 40610
	private int CurEchoLevel = 1;

	// Token: 0x04009EA3 RID: 40611
	private int CurEchoExp;

	// Token: 0x04009EA4 RID: 40612
	private int CurProgressLevelId;

	// Token: 0x04009EA5 RID: 40613
	private bool HasEchoLevel;

	// Token: 0x04009EA6 RID: 40614
	private int LastSettleEchoOldLevel;

	// Token: 0x04009EA7 RID: 40615
	private int LastSettleEchoOldExp;

	// Token: 0x04009EA8 RID: 40616
	private int StageStartEchoLevel = 1;

	// Token: 0x04009EA9 RID: 40617
	private int StageStartEchoExp;

	// Token: 0x04009EAA RID: 40618
	private int StageStartEchoStageId;

	// Token: 0x04009EAB RID: 40619
	private bool NeedStarUp;

	// Token: 0x04009EAC RID: 40620
	private int CurScore;

	// Token: 0x04009EAD RID: 40621
	private int CurEquipTokenId;

	// Token: 0x04009EAE RID: 40622
	private readonly Dictionary<int, int> FatigueMap = new Dictionary<int, int>();

	// Token: 0x04009EAF RID: 40623
	private readonly Dictionary<int, RoleTowerRankInfoCache> RankCacheMap = new Dictionary<int, RoleTowerRankInfoCache>();

	// Token: 0x04009EB0 RID: 40624
	private long RankRewardSettleTime;

	// Token: 0x04009EB1 RID: 40625
	[Nullable(2)]
	private RoleTowerSettleData LastSettle;

	// Token: 0x04009EB2 RID: 40626
	[Nullable(2)]
	private RoleTowerBestRecordData LastSettleRecord;

	// Token: 0x04009EB3 RID: 40627
	private readonly List<RoleTowerTokenCount> LastSettleGainTokens = new List<RoleTowerTokenCount>();

	// Token: 0x04009EB4 RID: 40628
	[Nullable(2)]
	private RoleTowerSaveData CurChallengeSave;

	// Token: 0x04009EB5 RID: 40629
	private readonly Dictionary<int, RoleTowerSaveData> SaveDataMap = new Dictionary<int, RoleTowerSaveData>();

	// Token: 0x04009EB6 RID: 40630
	private int CurSelectLevelId;

	// Token: 0x04009EB7 RID: 40631
	private int CurSelectStageId;

	// Token: 0x04009EB8 RID: 40632
	private int CurSelectFloorId;

	// Token: 0x04009EB9 RID: 40633
	private int CurSelectTokenId;

	// Token: 0x04009EBA RID: 40634
	private ERoleTowerTeamTab CurTeamTab;

	// Token: 0x04009EBB RID: 40635
	private readonly List<int> SelectOrderList = new List<int>();

	// Token: 0x04009EBC RID: 40636
	private bool IsInBattle;

	// Token: 0x04009EBD RID: 40637
	private int PendingGuideHelpId;

	// Token: 0x04009EBE RID: 40638
	private readonly Dictionary<ERoleTowerSlotType, int> SlotRoleMap = new Dictionary<ERoleTowerSlotType, int>();

	// Token: 0x04009EBF RID: 40639
	private readonly Dictionary<ERoleTowerSlotType, bool> SlotTrialMap = new Dictionary<ERoleTowerSlotType, bool>();

	// Token: 0x04009EC0 RID: 40640
	private readonly Dictionary<int, RoleTowerRoleAttributeInfo> RoleAttrInfoMap = new Dictionary<int, RoleTowerRoleAttributeInfo>();

	// Token: 0x04009EC1 RID: 40641
	private readonly Dictionary<int, int> RoleQueryPhantomLevelMap = new Dictionary<int, int>();

	// Token: 0x04009EC2 RID: 40642
	private readonly List<RoleTowerWaveRecordData> BattleWaveRecords = new List<RoleTowerWaveRecordData>();

	// Token: 0x04009EC3 RID: 40643
	private bool CurNeedBranchSelect;

	// Token: 0x04009EC4 RID: 40644
	[Nullable(2)]
	private RoleTowerFloorInfo CurBranchFloorInfo;

	// Token: 0x04009EC5 RID: 40645
	private long LastTimeDelta;

	// Token: 0x04009EC6 RID: 40646
	[Nullable(2)]
	private RoleTowerTokenButtonItem TokenButtonItem;

	// Token: 0x04009EC7 RID: 40647
	[Nullable(2)]
	private UUIItem TokenButtonParent;

	// Token: 0x04009EC8 RID: 40648
	private double TokenCdEndTime;

	// Token: 0x04009EC9 RID: 40649
	private int PendingRetryMainRoleId;

	// Token: 0x04009ECA RID: 40650
	[Nullable(2)]
	private RoleTowerPrepareSelection ActiveStageSelection;

	// Token: 0x04009ECB RID: 40651
	private int ActiveChallengeId;

	// Token: 0x04009ECC RID: 40652
	private int ActiveStageId;

	// Token: 0x04009ECD RID: 40653
	private bool IsStageRetryPending;

	// Token: 0x04009ECE RID: 40654
	private bool IsCheckPointOpen;

	// Token: 0x04009ECF RID: 40655
	[Nullable(2)]
	private RoleTowerFloorInfo CheckPointBranchFloorInfo;

	// Token: 0x04009ED0 RID: 40656
	private readonly Dictionary<int, int> CheckPointFatigueMap = new Dictionary<int, int>();

	// Token: 0x04009ED1 RID: 40657
	private readonly Dictionary<int, int> CheckPointTokenCounts = new Dictionary<int, int>();

	// Token: 0x04009ED2 RID: 40658
	private bool CheckPointUsesInitialFatigue;

	// Token: 0x04009ED3 RID: 40659
	private long CheckPointRemainTime;

	// Token: 0x04009ED4 RID: 40660
	[StaticVariableRuleIgnore]
	public static readonly IReadOnlyList<IRoleTowerDataTableConfig> DataTableConfigs = new IRoleTowerDataTableConfig[]
	{
		new RoleTowerDataTableConfig("/Game/Aki/GamePlay/RoleTower/Common/Data/DT_RoleTower_Common_Role_SkillInfo.DT_RoleTower_Common_Role_SkillInfo", "CommonSkillInfoDataTable"),
		new RoleTowerDataTableConfig("/Game/Aki/GamePlay/RoleTower/Common/Data/DT_RoleTower_Common_ReBulletDataMain.DT_RoleTower_Common_ReBulletDataMain", "CommonBulletDataTable")
	};

	// Token: 0x04009ED5 RID: 40661
	[Nullable(2)]
	public UDataTable CommonSkillInfoDataTable;

	// Token: 0x04009ED6 RID: 40662
	[Nullable(2)]
	public UDataTable CommonBulletDataTable;

	// Token: 0x04009ED7 RID: 40663
	[Nullable(2)]
	public UDataTable CommonHitEffectDataTable;

	// Token: 0x04009ED8 RID: 40664
	private bool TokenNewEntrySeen;

	// Token: 0x04009ED9 RID: 40665
	private int CurSelectBranchId;

	// Token: 0x04009EDA RID: 40666
	public const string EquipLockTipsTextId = "RoleTowerWeaponEchoLockTips";

	// Token: 0x04009EDB RID: 40667
	private const int RemountWaitMaxFrames = 60;

	// Token: 0x04009EDC RID: 40668
	private bool NeedOpenActivityMainAfterLeave;

	// Token: 0x04009EDD RID: 40669
	private bool IsHomeBtnLeavingDungeon;

	// Token: 0x04009EDE RID: 40670
	[Nullable(2)]
	private TimerHandle UnlockTimeTimerHandle;

	// Token: 0x04009EDF RID: 40671
	private const long OneDaySec = 86400L;

	// Token: 0x04009EE0 RID: 40672
	[Nullable(2)]
	private static RoleTowerModel _Instance;
}
