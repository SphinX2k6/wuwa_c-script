using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;

// Token: 0x02001F13 RID: 7955
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ShipTowerModel : ModelBase
{
	// Token: 0x17001DEC RID: 7660
	// (get) Token: 0x06013A53 RID: 80467 RVA: 0x005BA237 File Offset: 0x005B8437
	public int CurSeason
	{
		get
		{
			return this.Season;
		}
	}

	// Token: 0x17001DED RID: 7661
	// (get) Token: 0x06013A54 RID: 80468 RVA: 0x005BA240 File Offset: 0x005B8440
	public SlashAndTowerSeason? CurSeasonCfg
	{
		get
		{
			if (this.CurSeason == 0)
			{
				return null;
			}
			return ShipTowerConfig.Instance.GetSeasonCfgById(this.CurSeason);
		}
	}

	// Token: 0x17001DEE RID: 7662
	// (get) Token: 0x06013A55 RID: 80469 RVA: 0x005BA26F File Offset: 0x005B846F
	public long CurSeasonEndTime
	{
		get
		{
			return this.SeasonEndTime;
		}
	}

	// Token: 0x17001DEF RID: 7663
	// (get) Token: 0x06013A56 RID: 80470 RVA: 0x005BA277 File Offset: 0x005B8477
	public bool CurIsHaveRecord
	{
		get
		{
			return this.IsHaveRecord;
		}
	}

	// Token: 0x17001DF0 RID: 7664
	// (get) Token: 0x06013A57 RID: 80471 RVA: 0x005BA27F File Offset: 0x005B847F
	public IReadOnlyList<ShipTowerStageData> TowerStageDataList
	{
		get
		{
			return this.StageDataList;
		}
	}

	// Token: 0x17001DF1 RID: 7665
	// (get) Token: 0x06013A58 RID: 80472 RVA: 0x005BA287 File Offset: 0x005B8487
	public IReadOnlyDictionary<int, ShipTowerStageData> TowerStageDataMap
	{
		get
		{
			return this.StageDataMap;
		}
	}

	// Token: 0x17001DF2 RID: 7666
	// (get) Token: 0x06013A59 RID: 80473 RVA: 0x005BA28F File Offset: 0x005B848F
	public int GetRewardTotalNum
	{
		get
		{
			return this.RewardTotalNum;
		}
	}

	// Token: 0x17001DF3 RID: 7667
	// (get) Token: 0x06013A5A RID: 80474 RVA: 0x005BA297 File Offset: 0x005B8497
	public bool IsRewardAllReceived
	{
		get
		{
			return this.ReceivedAwardScoreIdSet.Count == this.RewardTotalNum;
		}
	}

	// Token: 0x06013A5B RID: 80475 RVA: 0x005BA2AC File Offset: 0x005B84AC
	protected override bool OnInit()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.ShipTowerView, new Func<EUiViewName, object, bool>(this.CheckCanOpen), "ShipTowerModel.CheckCanOpen");
		return true;
	}

	// Token: 0x06013A5C RID: 80476 RVA: 0x005BA2D0 File Offset: 0x005B84D0
	protected override bool OnClear()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.ShipTowerView, new Func<EUiViewName, object, bool>(this.CheckCanOpen));
		this.StageDataList.Clear();
		this.StageDataMap.Clear();
		this.BuffQualityList.Clear();
		this.BuffQualityMap.Clear();
		return true;
	}

	// Token: 0x06013A5D RID: 80477 RVA: 0x005BA325 File Offset: 0x005B8525
	protected override bool OnLeaveLevel()
	{
		return true;
	}

	// Token: 0x06013A5E RID: 80478 RVA: 0x005BA328 File Offset: 0x005B8528
	public void InitData(bool force = false)
	{
		if (this.IsInitData && !force)
		{
			return;
		}
		this.IsInitData = true;
		this.InitAreaList();
		this.InitPlayerGetBuffList();
	}

	// Token: 0x06013A5F RID: 80479 RVA: 0x005BA34C File Offset: 0x005B854C
	private void InitPlayerGetBuffList()
	{
		HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.ShipTowerGetBuffSet, null);
		if (player != null)
		{
			foreach (int item in player)
			{
				this.PlayerGetBuffSet.Add(item);
			}
		}
	}

	// Token: 0x06013A60 RID: 80480 RVA: 0x005BA3AC File Offset: 0x005B85AC
	public void AddPlayerGetBuff(int buffId)
	{
		this.PlayerGetBuffSet.Add(buffId);
		LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.ShipTowerGetBuffSet, this.PlayerGetBuffSet);
		EventSystem.Instance.Emit(EEventName.ShipTowerBuffNewUpdate);
	}

	// Token: 0x06013A61 RID: 80481 RVA: 0x005BA3D9 File Offset: 0x005B85D9
	private void InitBuffQualityList()
	{
		this.AddBuffQualityListBySeason(0);
	}

	// Token: 0x06013A62 RID: 80482 RVA: 0x005BA3E4 File Offset: 0x005B85E4
	private void AddBuffQualityListBySeason(int season)
	{
		IEnumerable<SlashBuffToItem> enumerable = ShipTowerConfig.Instance.GetBuffCfgBySeason(season) ?? new List<SlashBuffToItem>();
		int curSeason = this.CurSeason;
		List<SlashBuffToItem> list = new List<SlashBuffToItem>();
		foreach (SlashBuffToItem item in enumerable)
		{
			if (season != 0)
			{
				list.Add(item);
			}
			else
			{
				bool flag = curSeason >= item.StartSeason;
				bool flag2 = item.EndSeason == -1 || curSeason <= item.EndSeason;
				if (flag && flag2)
				{
					list.Add(item);
				}
			}
		}
		foreach (SlashBuffToItem cfg in list)
		{
			this.AddBuffData(cfg);
		}
		this.UpdateBuffQualityList();
	}

	// Token: 0x06013A63 RID: 80483 RVA: 0x005BA4CC File Offset: 0x005B86CC
	public void CheckOldSeasonBuffQualityList()
	{
		foreach (ShipTowerBuffQuality shipTowerBuffQuality in this.BuffQualityList)
		{
			bool flag = false;
			foreach (ShipTowerBuffData buffData in shipTowerBuffQuality.BuffList)
			{
				if (this.IsOldSeasonByBuffData(buffData))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				List<ShipTowerBuffData> list = new List<ShipTowerBuffData>();
				foreach (ShipTowerBuffData shipTowerBuffData in shipTowerBuffQuality.BuffList)
				{
					if (!this.IsOldSeasonByBuffData(shipTowerBuffData))
					{
						list.Add(shipTowerBuffData);
					}
				}
				shipTowerBuffQuality.BuffList.Clear();
				shipTowerBuffQuality.BuffList.AddRange(list);
				if (shipTowerBuffQuality.BuffList.Count == 0)
				{
					this.BuffQualityMap.Remove(shipTowerBuffQuality.Quality);
				}
			}
		}
	}

	// Token: 0x06013A64 RID: 80484 RVA: 0x005BA5FC File Offset: 0x005B87FC
	private bool IsOldSeasonByBuffData(ShipTowerBuffData buffData)
	{
		if (buffData.Season != 0)
		{
			return this.IsOldSeason(buffData.Season);
		}
		SlashBuffToItem? buffCfgByItemId = ShipTowerConfig.Instance.GetBuffCfgByItemId(buffData.ItemId);
		if (buffCfgByItemId == null)
		{
			return true;
		}
		bool flag = this.CurSeason >= buffCfgByItemId.Value.StartSeason;
		bool flag2 = buffCfgByItemId.Value.EndSeason == -1 || this.CurSeason <= buffCfgByItemId.Value.EndSeason;
		return !flag || !flag2;
	}

	// Token: 0x06013A65 RID: 80485 RVA: 0x005BA68C File Offset: 0x005B888C
	public List<SlashAndTowerCfg> GetZeroSeasonInstConfig()
	{
		IReadOnlyList<SlashAndTowerCfg> stageCfgBySeason = ShipTowerConfig.Instance.GetStageCfgBySeason(0);
		if (stageCfgBySeason == null)
		{
			return new List<SlashAndTowerCfg>();
		}
		Dictionary<int, List<SlashAndTowerCfg>> dictionary = new Dictionary<int, List<SlashAndTowerCfg>>();
		foreach (SlashAndTowerCfg item in stageCfgBySeason)
		{
			if (!dictionary.ContainsKey(item.OrderIndex))
			{
				dictionary[item.OrderIndex] = new List<SlashAndTowerCfg>();
			}
			dictionary[item.OrderIndex].Add(item);
		}
		List<SlashAndTowerCfg> list = new List<SlashAndTowerCfg>();
		foreach (KeyValuePair<int, List<SlashAndTowerCfg>> keyValuePair in dictionary)
		{
			List<SlashAndTowerCfg> value = keyValuePair.Value;
			if (value.Count == 1)
			{
				list.Add(value[0]);
			}
			else
			{
				SlashAndTowerCfg? slashAndTowerCfg = null;
				int num = 0;
				foreach (SlashAndTowerCfg value2 in value)
				{
					if (num <= value2.SeasonVersion && this.CurSeason >= value2.SeasonVersion)
					{
						num = value2.SeasonVersion;
						slashAndTowerCfg = new SlashAndTowerCfg?(value2);
					}
				}
				if (slashAndTowerCfg != null)
				{
					list.Add(slashAndTowerCfg.Value);
				}
			}
		}
		list.Sort((SlashAndTowerCfg a, SlashAndTowerCfg b) => a.OrderIndex - b.OrderIndex);
		return list;
	}

	// Token: 0x06013A66 RID: 80486 RVA: 0x005BA834 File Offset: 0x005B8A34
	public bool IsOldSeason(int season)
	{
		return season != 0 && season != this.CurSeason;
	}

	// Token: 0x06013A67 RID: 80487 RVA: 0x005BA848 File Offset: 0x005B8A48
	private void AddBuffData(SlashBuffToItem cfg)
	{
		if (this.BuffDataMap.ContainsKey(cfg.Id))
		{
			return;
		}
		ShipTowerBuffData shipTowerBuffData = new ShipTowerBuffData();
		shipTowerBuffData.Init(cfg);
		this.BuffDataMap[cfg.Id] = shipTowerBuffData;
		if (this.BuffQualityMap.ContainsKey(shipTowerBuffData.Quality))
		{
			this.BuffQualityMap[shipTowerBuffData.Quality].BuffList.Add(shipTowerBuffData);
			return;
		}
		ShipTowerBuffQuality value = new ShipTowerBuffQuality
		{
			Quality = shipTowerBuffData.Quality,
			Title = shipTowerBuffData.GetQualityTitle(),
			BuffList = new List<ShipTowerBuffData>
			{
				shipTowerBuffData
			}
		};
		this.BuffQualityMap[shipTowerBuffData.Quality] = value;
	}

	// Token: 0x06013A68 RID: 80488 RVA: 0x005BA8FC File Offset: 0x005B8AFC
	private void UpdateBuffQualityList()
	{
		this.BuffQualityList.Clear();
		this.BuffQualityList.AddRange(this.BuffQualityMap.Values);
		this.BuffQualityList.Sort((ShipTowerBuffQuality a, ShipTowerBuffQuality b) => b.Quality - a.Quality);
	}

	// Token: 0x06013A69 RID: 80489 RVA: 0x005BA954 File Offset: 0x005B8B54
	[NullableContext(0)]
	public UniTask<bool> CheckInitProto(bool needInitAreaData = false)
	{
		ShipTowerModel.<CheckInitProto>d__64 <CheckInitProto>d__;
		<CheckInitProto>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<CheckInitProto>d__.<>4__this = this;
		<CheckInitProto>d__.needInitAreaData = needInitAreaData;
		<CheckInitProto>d__.<>1__state = -1;
		<CheckInitProto>d__.<>t__builder.Start<ShipTowerModel.<CheckInitProto>d__64>(ref <CheckInitProto>d__);
		return <CheckInitProto>d__.<>t__builder.Task;
	}

	// Token: 0x06013A6A RID: 80490 RVA: 0x005BA9A0 File Offset: 0x005B8BA0
	private bool IsNeedRequestInitData()
	{
		return this.IsOpen() && (this.TowerStageDataList.Count == 0 || !this.TowerStageDataList[0].IsHaveProtoData || this.TimeIsOver() || UiManager.Instance.IsViewOpen(EUiViewName.ShipTowerReviewView));
	}

	// Token: 0x06013A6B RID: 80491 RVA: 0x005BA9F7 File Offset: 0x005B8BF7
	private void InitAreaList()
	{
		this.AreaList.Clear();
		this.AreaList.Add(this.CreateAreaDataById(0, false));
	}

	// Token: 0x06013A6C RID: 80492 RVA: 0x005BAA18 File Offset: 0x005B8C18
	public void CreateDefaultStageDataList()
	{
		if (this.TowerStageDataList.Count > 0)
		{
			return;
		}
		foreach (int season in new int[]
		{
			0,
			1
		})
		{
			IReadOnlyList<SlashAndTowerCfg> stageCfgBySeason = ShipTowerConfig.Instance.GetStageCfgBySeason(season);
			if (stageCfgBySeason != null)
			{
				foreach (SlashAndTowerCfg cfg in stageCfgBySeason)
				{
					this.CreateStageDataByCfg(cfg);
				}
			}
		}
	}

	// Token: 0x06013A6D RID: 80493 RVA: 0x005BAAA4 File Offset: 0x005B8CA4
	[NullableContext(2)]
	private ShipTowerStageData CreateStageDataById(int id)
	{
		SlashAndTowerCfg? stageCfgById = ShipTowerConfig.Instance.GetStageCfgById(id);
		if (stageCfgById == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ShipTower;
			ELogAuthor author = ELogAuthor.CX;
			string message = "CreateStageDataById";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return this.CreateStageDataByCfg(stageCfgById.Value);
	}

	// Token: 0x06013A6E RID: 80494 RVA: 0x005BAB04 File Offset: 0x005B8D04
	private ShipTowerStageData CreateStageDataByCfg(SlashAndTowerCfg cfg)
	{
		if (this.StageDataMap.ContainsKey(cfg.Id))
		{
			ShipTowerStageData shipTowerStageData = this.StageDataMap[cfg.Id];
			if (!this.StageDataList.Contains(shipTowerStageData))
			{
				this.StageDataList.Add(shipTowerStageData);
			}
			return shipTowerStageData;
		}
		ShipTowerStageData shipTowerStageData2 = new ShipTowerStageData();
		shipTowerStageData2.Init(cfg);
		shipTowerStageData2.SetOrderIndex(this.StageDataList.Count + 1);
		this.StageDataList.Add(shipTowerStageData2);
		this.StageDataMap[cfg.Id] = shipTowerStageData2;
		return shipTowerStageData2;
	}

	// Token: 0x06013A6F RID: 80495 RVA: 0x005BAB94 File Offset: 0x005B8D94
	[NullableContext(2)]
	public ShipTowerStageData GetStageDataById(int id)
	{
		ShipTowerStageData result;
		if (!this.StageDataMap.TryGetValue(id, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06013A70 RID: 80496 RVA: 0x005BABB4 File Offset: 0x005B8DB4
	[NullableContext(2)]
	public ShipTowerStageData GetEndlessStageData()
	{
		foreach (ShipTowerStageData shipTowerStageData in this.StageDataList)
		{
			if (shipTowerStageData.IsEndLess)
			{
				return shipTowerStageData;
			}
		}
		if (this.StageDataList.Count <= 0)
		{
			return null;
		}
		return this.StageDataList[0];
	}

	// Token: 0x06013A71 RID: 80497 RVA: 0x005BAC2C File Offset: 0x005B8E2C
	public List<ShipTowerBuffQuality> GetBuffQualityList(bool isSortData = false)
	{
		if (isSortData)
		{
			this.BuffQualityListSortData();
		}
		return this.BuffQualityList;
	}

	// Token: 0x06013A72 RID: 80498 RVA: 0x005BAC40 File Offset: 0x005B8E40
	private void BuffQualityListSortData()
	{
		foreach (ShipTowerBuffQuality shipTowerBuffQuality in this.BuffQualityList)
		{
			shipTowerBuffQuality.BuffList.Sort((ShipTowerBuffData a, ShipTowerBuffData b) => a.Id - b.Id);
		}
	}

	// Token: 0x06013A73 RID: 80499 RVA: 0x005BACB4 File Offset: 0x005B8EB4
	[NullableContext(2)]
	public ShipTowerBuffData GetBuffDataByBuffId(int buffId)
	{
		ShipTowerBuffData result;
		if (!this.BuffDataMap.TryGetValue(buffId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06013A74 RID: 80500 RVA: 0x005BACD4 File Offset: 0x005B8ED4
	public void SelectDefaultBuff(int? stageId = null)
	{
		foreach (ShipTowerBuffQuality shipTowerBuffQuality in this.GetBuffQualityList(true))
		{
			foreach (ShipTowerBuffData shipTowerBuffData in shipTowerBuffQuality.BuffList)
			{
				if (shipTowerBuffData.IsCanUse(stageId))
				{
					shipTowerBuffData.SetSelected(true);
					return;
				}
			}
		}
		List<ShipTowerBuffQuality> buffQualityList = this.GetBuffQualityList(false);
		if (buffQualityList.Count > 0 && buffQualityList[0].BuffList.Count > 0)
		{
			buffQualityList[0].BuffList[0].SetSelected(true);
		}
	}

	// Token: 0x06013A75 RID: 80501 RVA: 0x005BADAC File Offset: 0x005B8FAC
	public int GetRecommendLevelByInstId(int instId)
	{
		return InstanceDungeonConfig.Instance.GetRecommendLevel(instId, WorldLevelModel.Instance.CurWorldLevel);
	}

	// Token: 0x06013A76 RID: 80502 RVA: 0x005BADC4 File Offset: 0x005B8FC4
	public List<ShipTowerTeamTab> GetTeamTabList()
	{
		if (this.TeamTabList.Count > 0)
		{
			return this.TeamTabList;
		}
		this.TeamTabList.Add(new ShipTowerTeamTab
		{
			TabType = EShipTowerTeamTabType.RoleList,
			Title = "GhostShipRoleList_Text"
		});
		this.TeamTabList.Add(new ShipTowerTeamTab
		{
			TabType = EShipTowerTeamTabType.UseTeam,
			Title = "GhostShipPreTeam_Text"
		});
		return this.TeamTabList;
	}

	// Token: 0x06013A77 RID: 80503 RVA: 0x005BAE30 File Offset: 0x005B9030
	public bool IsOtherTeamRoleData(int roleId)
	{
		return this.OtherTeamRoleMap.ContainsKey(roleId);
	}

	// Token: 0x06013A78 RID: 80504 RVA: 0x005BAE40 File Offset: 0x005B9040
	[NullableContext(2)]
	public ShipTowerRoleData GetOtherTeamRoleData(int roleId)
	{
		ShipTowerRoleData result;
		if (!this.OtherTeamRoleMap.TryGetValue(roleId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06013A79 RID: 80505 RVA: 0x005BAE60 File Offset: 0x005B9060
	public void AddOtherTeamRoleData(ShipTowerRoleData roleData)
	{
		this.OtherTeamRoleMap[roleData.RoleIdEdit] = roleData;
	}

	// Token: 0x06013A7A RID: 80506 RVA: 0x005BAE74 File Offset: 0x005B9074
	[NullableContext(2)]
	public ShipTowerRoleData GetAllTeamRoleData(int roleId)
	{
		ShipTowerRoleData result;
		if (!this.AllTeamRoleMap.TryGetValue(roleId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06013A7B RID: 80507 RVA: 0x005BAE94 File Offset: 0x005B9094
	public void AddAllTeamRoleData(ShipTowerRoleData roleData)
	{
		this.AllTeamRoleMap[roleData.RoleIdEdit] = roleData;
	}

	// Token: 0x06013A7C RID: 80508 RVA: 0x005BAEA8 File Offset: 0x005B90A8
	public void ClearAllTeamRoleData()
	{
		this.AllTeamRoleMap.Clear();
	}

	// Token: 0x06013A7D RID: 80509 RVA: 0x005BAEB5 File Offset: 0x005B90B5
	public void ClearOtherTeamRoleData()
	{
		this.OtherTeamRoleMap.Clear();
	}

	// Token: 0x06013A7E RID: 80510 RVA: 0x005BAEC4 File Offset: 0x005B90C4
	public ShipTowerStageData GetNextChallengeStageData([Nullable(2)] ShipTowerStageData ignoreData = null)
	{
		foreach (ShipTowerStageData shipTowerStageData in this.StageDataList)
		{
			if (!shipTowerStageData.IsPassed() && shipTowerStageData.IsUnLocked() && shipTowerStageData != ignoreData)
			{
				return shipTowerStageData;
			}
		}
		return this.StageDataList[this.StageDataList.Count - 1];
	}

	// Token: 0x06013A7F RID: 80511 RVA: 0x005BAF44 File Offset: 0x005B9144
	[NullableContext(2)]
	public void OpenViewMain(ShipTowerViewParams param = null)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerView, param, null);
	}

	// Token: 0x06013A80 RID: 80512 RVA: 0x005BAF57 File Offset: 0x005B9157
	public void AddNormalStackChildView(bool success, int viewId)
	{
		if (success)
		{
			UiViewBase uiViewBase = UiModel.Instance.NormalStack.Peek();
			if (uiViewBase == null)
			{
				return;
			}
			uiViewBase.AddChildViewById(viewId);
		}
	}

	// Token: 0x06013A81 RID: 80513 RVA: 0x005BAF78 File Offset: 0x005B9178
	public void OpenViewDesc(ShipTowerDescViewParams param, [Nullable(2)] TOpenViewCallBack finishCallback = null)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerDescView, param, delegate(bool success, int viewId)
		{
			this.AddNormalStackChildView(success, viewId);
			TOpenViewCallBack finishCallback2 = finishCallback;
			if (finishCallback2 == null)
			{
				return;
			}
			finishCallback2(success, viewId);
		});
	}

	// Token: 0x06013A82 RID: 80514 RVA: 0x005BAFB5 File Offset: 0x005B91B5
	public void OpenViewBuff(ShipTowerBuffViewParams param)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerBuffView, param, new TOpenViewCallBack(this.AddNormalStackChildView));
	}

	// Token: 0x06013A83 RID: 80515 RVA: 0x005BAFD3 File Offset: 0x005B91D3
	public void OpenViewCover(ShipTowerCoverViewParams param)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerCoverView, param, new TOpenViewCallBack(this.AddNormalStackChildView));
	}

	// Token: 0x06013A84 RID: 80516 RVA: 0x005BAFF1 File Offset: 0x005B91F1
	public void OpenViewReset(ShipTowerResetViewParams param)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerResetView, param, new TOpenViewCallBack(this.AddNormalStackChildView));
	}

	// Token: 0x06013A85 RID: 80517 RVA: 0x005BB00F File Offset: 0x005B920F
	[NullableContext(2)]
	public void OpenViewReward(ShipTowerRewardViewParams param = null)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerRewardView, param, new TOpenViewCallBack(this.AddNormalStackChildView));
	}

	// Token: 0x06013A86 RID: 80518 RVA: 0x005BB02D File Offset: 0x005B922D
	public void OpenViewPassBuffShow(ShipTowerPassBuffShowViewParams param)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerPassBuffShowView, param, new TOpenViewCallBack(this.AddNormalStackChildView));
	}

	// Token: 0x06013A87 RID: 80519 RVA: 0x005BB04B File Offset: 0x005B924B
	public void OpenViewTeamRecommend(ShipTowerTeamRecommendViewParams param)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerTeamRecommendView, param, new TOpenViewCallBack(this.AddNormalStackChildView));
	}

	// Token: 0x06013A88 RID: 80520 RVA: 0x005BB069 File Offset: 0x005B9269
	public void OpenViewMonsterDesc(ShipTowerMonsterDescViewParams param)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerMonsterDescView, param, new TOpenViewCallBack(this.AddNormalStackChildView));
	}

	// Token: 0x06013A89 RID: 80521 RVA: 0x005BB087 File Offset: 0x005B9287
	[NullableContext(2)]
	public void OpenViewRecord(ShipTowerRecordViewParams param = null)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerRecordView, param, new TOpenViewCallBack(this.AddNormalStackChildView));
	}

	// Token: 0x06013A8A RID: 80522 RVA: 0x005BB0A5 File Offset: 0x005B92A5
	[NullableContext(2)]
	public void OpenViewReview(ShipTowerReviewViewParams param = null)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerReviewView, param, new TOpenViewCallBack(this.AddNormalStackChildView));
	}

	// Token: 0x06013A8B RID: 80523 RVA: 0x005BB0C4 File Offset: 0x005B92C4
	[NullableContext(2)]
	private unsafe bool CheckErrorCode(TErrorCode response, EResponseMessageId msgId, bool isShowTip = true)
	{
		if (response == null)
		{
			return true;
		}
		if (response.ErrorCode != Aki.Protocol.ErrorCode.Success)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ShipTower;
			ELogAuthor author = ELogAuthor.CX;
			string message = "CheckErrorCode";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ErrorCode", response.ErrorCode);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MsgId", msgId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (isShowTip)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(response.ErrorCode, (int)msgId, null, true, true);
			}
			return true;
		}
		return false;
	}

	// Token: 0x06013A8C RID: 80524 RVA: 0x005BB15D File Offset: 0x005B935D
	public void UpdateSeasonNotify(SlashAndTowerOverNotify notify)
	{
		this.OpenConfirmSeasonUpdate(null);
	}

	// Token: 0x06013A8D RID: 80525 RVA: 0x005BB168 File Offset: 0x005B9368
	public void UpdateResultNotify(SlashAndTowerResultNotify notify)
	{
		ShipTowerStageData stageDataById = this.GetStageDataById(notify.LevelsId);
		if (stageDataById == null)
		{
			this.LeaveBattle();
			return;
		}
		if (this.CheckIsNeedShowConfirmSeasonUpdate(null))
		{
			return;
		}
		stageDataById.ProtoTeamEditFromResult(notify);
		int newChallengeScore = stageDataById.NewChallengeScore;
		bool isNewRecord = stageDataById.IsNewRecord(new int?(newChallengeScore));
		string titleA = "GhostShipMonsterScore_Text";
		string titleB = "GhostShipTimeScore_Text";
		List<ShipTowerFightFinishItemData> list = new List<ShipTowerFightFinishItemData>();
		ShipTowerFightFinishItemData shipTowerFightFinishItemData = new ShipTowerFightFinishItemData();
		shipTowerFightFinishItemData.TotalTitle = stageDataById.TeamDataList[0].AreaName;
		shipTowerFightFinishItemData.TitleA = titleA;
		shipTowerFightFinishItemData.TitleB = titleB;
		shipTowerFightFinishItemData.ScoreA = notify.FirstKillMonsterScore;
		shipTowerFightFinishItemData.ScoreB = notify.FirstRoundScore;
		shipTowerFightFinishItemData.RoleList = ShipTowerModel.<UpdateResultNotify>g__MakeRoleList|100_0(stageDataById.TeamDataList[0]);
		ShipTowerBuffData buffDataEdit = stageDataById.TeamDataList[0].BuffDataEdit;
		shipTowerFightFinishItemData.BuffId = ((buffDataEdit != null) ? buffDataEdit.Id : 0);
		list.Add(shipTowerFightFinishItemData);
		ShipTowerFightFinishItemData shipTowerFightFinishItemData2 = new ShipTowerFightFinishItemData();
		shipTowerFightFinishItemData2.TotalTitle = stageDataById.TeamDataList[1].AreaName;
		shipTowerFightFinishItemData2.TitleA = titleA;
		shipTowerFightFinishItemData2.TitleB = titleB;
		shipTowerFightFinishItemData2.ScoreA = notify.SecondKillMonsterScore;
		shipTowerFightFinishItemData2.ScoreB = notify.SecondRoundScore;
		shipTowerFightFinishItemData2.RoleList = ShipTowerModel.<UpdateResultNotify>g__MakeRoleList|100_0(stageDataById.TeamDataList[1]);
		ShipTowerBuffData buffDataEdit2 = stageDataById.TeamDataList[1].BuffDataEdit;
		shipTowerFightFinishItemData2.BuffId = ((buffDataEdit2 != null) ? buffDataEdit2.Id : 0);
		list.Add(shipTowerFightFinishItemData2);
		List<ShipTowerFightFinishItemData> areaList = list;
		UiManager.Instance.OpenView(EUiViewName.ShipTowerFightFinishView, new ShipTowerFightFinishViewParams
		{
			TotalScore = newChallengeScore,
			GradeResId = this.GetStageGradeResIdByStageId(stageDataById.Id, newChallengeScore),
			IsNewRecord = isNewRecord,
			ButtonList = this.GetFightFinishButtonList(stageDataById, newChallengeScore),
			AreaList = areaList,
			IsEndless = stageDataById.IsEndLess
		}, null);
	}

	// Token: 0x06013A8E RID: 80526 RVA: 0x005BB324 File Offset: 0x005B9524
	private unsafe List<IRewardExploreConfirmButton> GetFightFinishButtonList(ShipTowerStageData stageData, int newScore)
	{
		List<IRewardExploreConfirmButton> list = new List<IRewardExploreConfirmButton>
		{
			new RewardExploreConfirmButtonData
			{
				ButtonTextId = "ConfirmBox_252_ButtonText_0",
				DescriptionTextId = null,
				IsTimeDownCloseView = true,
				IsClickedCloseView = true,
				OnClickedCallback = delegate(int _)
				{
					this.OpenViewMain(new ShipTowerViewParams
					{
						StageId = new int?(stageData.Id),
						IsFromInstanceDungeon = new bool?(true)
					});
				}
			},
			new RewardExploreConfirmButtonData
			{
				ButtonTextId = "Text_ButtonTextConfirmResult_Text",
				DescriptionTextId = null,
				IsTimeDownCloseView = true,
				IsClickedCloseView = true,
				OnClickedCallback = null
			}
		};
		if (stageData.IsNeedSureScore)
		{
			list[0] = null;
			list[1].OnClickedCallback = delegate(int _)
			{
				stageData.SureResultFromInstance();
			};
		}
		else if (stageData.IsEndLess)
		{
			list[1].ButtonTextId = "Text_ButtonTextRetry_Text";
			list[1].OnClickedCallback = delegate(int _)
			{
				stageData.GotoDescFromInstance();
			};
			stageData.SaveLastData();
		}
		else if (!stageData.CheckPass(newScore))
		{
			list[1].ButtonTextId = "Text_ButtonTextRetry_Text";
			list[1].DescriptionTextId = "Text_NotFinished_Text";
			list[1].OnClickedCallback = delegate(int _)
			{
				stageData.GotoDescFromInstance();
			};
			stageData.SaveLastData();
		}
		else
		{
			ShipTowerStageData nextStageData = this.GetNextChallengeStageData(stageData);
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(nextStageData.TitleKey);
			list[1].ButtonTextId = "Text_ButtonTextContinue_Text";
			list[1].DescriptionTextId = "Text_ButtonTextGoOnTower_Text";
			IRewardExploreConfirmButton rewardExploreConfirmButton = list[1];
			int num = 2;
			List<object> list2 = new List<object>(num);
			CollectionsMarshal.SetCount<object>(list2, num);
			Span<object> span = CollectionsMarshal.AsSpan<object>(list2);
			int num2 = 0;
			*span[num2] = multiTextByKey;
			num2++;
			*span[num2] = nextStageData.OrderIndex;
			rewardExploreConfirmButton.DescriptionArgs = list2;
			list[1].OnClickedCallback = delegate(int _)
			{
				stageData.GotoNextDescFromInstance(nextStageData);
			};
			stageData.SaveLastData();
		}
		return list;
	}

	// Token: 0x06013A8F RID: 80527 RVA: 0x005BB564 File Offset: 0x005B9764
	public void UpdateLevelPlayNotify(SlashAndTowerLevelPlayNotify notify)
	{
		foreach (SlashLevelPlayInfo slashLevelPlayInfo in notify.SlashLevelPlayInfos)
		{
			ShipTowerStageData stageDataById = this.GetStageDataById(slashLevelPlayInfo.Id);
			if (stageDataById != null)
			{
				stageDataById.ProtoNotifyUpdateData(slashLevelPlayInfo);
			}
			if (stageDataById != null && stageDataById.IsEndLess && !this.IsOldSeason(stageDataById.BelongToSeason) && stageDataById.IsTeamSetRoleFinish())
			{
				this.IsHaveRecord = true;
				EventSystem.Instance.Emit(EEventName.ShipTowerEndlessRecordUpdate);
			}
		}
		this.UpdateAreaListState();
	}

	// Token: 0x06013A90 RID: 80528 RVA: 0x005BB600 File Offset: 0x005B9800
	[NullableContext(2)]
	public void SlashAndTowerInfoResponse(SlashAndTowerInfoResponse response)
	{
		object response2;
		if (response == null)
		{
			response2 = null;
		}
		else
		{
			(response2 = new TErrorCode()).ErrorCode = response.ErrorCode;
		}
		if (this.CheckErrorCode(response2, EResponseMessageId.SlashAndTowerInfoResponse, false))
		{
			return;
		}
		this.StageDataMap.Clear();
		this.StageDataList.Clear();
		if (((response != null) ? response.SlashLevelPlayInfos : null) != null)
		{
			foreach (SlashLevelPlayInfo slashLevelPlayInfo in response.SlashLevelPlayInfos)
			{
				this.CreateStageDataById(slashLevelPlayInfo.Id);
			}
		}
		this.Season = ((this.StageDataList.Count > 0) ? new int?(this.StageDataList[this.StageDataList.Count - 1].BelongToSeason) : null).GetValueOrDefault(1);
		this.InitBuffQualityList();
		this.SeasonEndTime = MathUtils.Instance.LongToNumber((response != null) ? response.SeasonEndTime : 0L);
		this.IsHaveRecord = (response != null && response.ExistEndlessRecord);
		this.IsNeedShowSeasonReview = (response != null && response.UpdateSeason);
		this.CheckOldSeasonBuffQualityList();
		this.AddBuffQualityListBySeason(this.CurSeason);
		if (((response != null) ? response.SlashLevelPlayInfos : null) != null)
		{
			foreach (SlashLevelPlayInfo slashLevelPlayInfo2 in response.SlashLevelPlayInfos)
			{
				ShipTowerStageData stageDataById = this.GetStageDataById(slashLevelPlayInfo2.Id);
				if (stageDataById != null)
				{
					stageDataById.ProtoNotifyInitData(slashLevelPlayInfo2);
				}
			}
		}
		this.ReceivedAwardScoreIdSet.Clear();
		if (((response != null) ? response.ReceivedAward : null) != null)
		{
			foreach (int item in response.ReceivedAward)
			{
				this.ReceivedAwardScoreIdSet.Add(item);
			}
		}
		this.SetChallengeBuffIdList((((response != null) ? response.BuffCache : null) != null) ? new List<int>(response.BuffCache) : new List<int>());
		ActivityShipTowerController instance = ActivityShipTowerController.Instance;
		ActivityShipTowerData activityShipTowerData = (instance != null) ? instance.Data : null;
		if (activityShipTowerData != null && activityShipTowerData.RedPointShowState)
		{
			AdventureGuideModel.Instance.ReportPeriodicActivityRedAppear(EDungeonSubType.ShipTower);
		}
	}

	// Token: 0x06013A91 RID: 80529 RVA: 0x005BB850 File Offset: 0x005B9A50
	[NullableContext(2)]
	public void SlashAndTowerScoreRewardResponse(SlashAndTowerScoreRewardResponse response)
	{
		object response2;
		if (response == null)
		{
			response2 = null;
		}
		else
		{
			(response2 = new TErrorCode()).ErrorCode = response.ErrorCode;
		}
		if (this.CheckErrorCode(response2, EResponseMessageId.SlashAndTowerScoreRewardResponse, true))
		{
			return;
		}
		if (((response != null) ? response.RewardIds : null) != null)
		{
			foreach (int item in response.RewardIds)
			{
				this.ReceivedAwardScoreIdSet.Add(item);
			}
		}
		this.UpdateAreaListState();
		EventSystem.Instance.Emit<int>(EEventName.ShipTowerRewardReceive, this.ReceivingAwardId);
	}

	// Token: 0x06013A92 RID: 80530 RVA: 0x005BB8F4 File Offset: 0x005B9AF4
	[NullableContext(2)]
	public void EndLessHistoryResponse(EndLessHistoryResponse response)
	{
		object response2;
		if (response == null)
		{
			response2 = null;
		}
		else
		{
			(response2 = new TErrorCode()).ErrorCode = response.ErrorCode;
		}
		if (this.CheckErrorCode(response2, EResponseMessageId.EndLessHistoryResponse, true))
		{
			return;
		}
		this.RecordList.Clear();
		this.AddRecord("GhostShipCycle_Text1", (response != null) ? response.NowSeasonRecord : null);
		this.AddRecord("GhostShipCycle_Text2", (response != null) ? response.HistoryRecord : null);
	}

	// Token: 0x06013A93 RID: 80531 RVA: 0x005BB960 File Offset: 0x005B9B60
	private void AddRecord(string name, [Nullable(2)] EndlessBattleRecord protoInfo)
	{
		if (protoInfo == null || (protoInfo != null && protoInfo.Id == 0))
		{
			return;
		}
		string text = "GhostShipRecordTime_Text";
		double timeStampSecond = (double)MathUtils.Instance.LongToNumber(protoInfo.SaveTime);
		ShipTowerModel.<>c__DisplayClass106_0 CS$<>8__locals1;
		CS$<>8__locals1.data = new ShipTowerAreaItemData
		{
			Id = 0,
			Name = name,
			Desc = TextConfig.Instance.GetMultiTextByKey(text, text),
			TimeContent = TimeUtil.Instance.DateFormat4String(timeStampSecond),
			RecordList = new List<ShipTowerRecordItemData>()
		};
		ShipTowerModel.<AddRecord>g__functionAddTeam|106_0("GhostShipTeamName_Text1", protoInfo.FirstRecord, ref CS$<>8__locals1);
		ShipTowerModel.<AddRecord>g__functionAddTeam|106_0("GhostShipTeamName_Text2", protoInfo.SecondRecord, ref CS$<>8__locals1);
		this.RecordList.Add(CS$<>8__locals1.data);
	}

	// Token: 0x06013A94 RID: 80532 RVA: 0x005BBA14 File Offset: 0x005B9C14
	[NullableContext(2)]
	public void SlashAndTowerSaveRecordResponse(int id, SlashAndTowerSaveRecordResponse response)
	{
		object response2;
		if (response == null)
		{
			response2 = null;
		}
		else
		{
			(response2 = new TErrorCode()).ErrorCode = response.ErrorCode;
		}
		if (this.CheckErrorCode(response2, EResponseMessageId.SlashAndTowerSaveRecordResponse, true))
		{
			return;
		}
		ShipTowerStageData stageDataById = this.GetStageDataById(id);
		if (stageDataById != null)
		{
			stageDataById.CoverChallenge();
		}
		this.UpdateAreaListState();
		this.SetChallengeStageDataNull();
		ScrollingTipsController.Instance.ShowTipsByTextId("GhostShipRecordSuccess_Text", Array.Empty<object>());
		EventSystem.Instance.Emit<int>(EEventName.ShipTowerSureCoverChallenge, id);
	}

	// Token: 0x06013A95 RID: 80533 RVA: 0x005BBA8C File Offset: 0x005B9C8C
	[NullableContext(2)]
	public void SlashAndTowerResetResponse(int id, SlashAndTowerResetResponse response)
	{
		object response2;
		if (response == null)
		{
			response2 = null;
		}
		else
		{
			(response2 = new TErrorCode()).ErrorCode = response.ErrorCode;
		}
		if (this.CheckErrorCode(response2, EResponseMessageId.SlashAndTowerResetResponse, true))
		{
			return;
		}
		ShipTowerStageData stageDataById = this.GetStageDataById(id);
		if (stageDataById != null)
		{
			stageDataById.ResetStage();
		}
		this.UpdateAreaListState();
		EventSystem.Instance.Emit<int>(EEventName.ShipTowerSureResetStage, id);
		ScrollingTipsController.Instance.ShowTipsByTextId("GhostShipRecordReset_Text", Array.Empty<object>());
	}

	// Token: 0x06013A96 RID: 80534 RVA: 0x005BBAFC File Offset: 0x005B9CFC
	[NullableContext(2)]
	public void SlashAndTowerRecommendResponse(int id, SlashAndTowerRecommendResponse response)
	{
		object response2;
		if (response == null)
		{
			response2 = null;
		}
		else
		{
			(response2 = new TErrorCode()).ErrorCode = response.ErrorCode;
		}
		if (this.CheckErrorCode(response2, EResponseMessageId.SlashAndTowerRecommendResponse, true))
		{
			return;
		}
		ShipTowerStageData stageDataById = this.GetStageDataById(id);
		if (stageDataById == null)
		{
			return;
		}
		stageDataById.ProtoUpdateTeamRecommendList(response);
	}

	// Token: 0x06013A97 RID: 80535 RVA: 0x005BBB38 File Offset: 0x005B9D38
	[NullableContext(2)]
	public void SlashAndTowerReviewResponse(LstBattleRecordResponse response)
	{
		object response2;
		if (response == null)
		{
			response2 = null;
		}
		else
		{
			(response2 = new TErrorCode()).ErrorCode = response.ErrorCode;
		}
		if (this.CheckErrorCode(response2, EResponseMessageId.LstBattleRecordResponse, true))
		{
			return;
		}
		this.ReviewList.Clear();
		if (((response != null) ? response.LstLevelInfos : null) != null)
		{
			foreach (LstLevelInfo lstLevelInfo in response.LstLevelInfos)
			{
				int levelId = lstLevelInfo.LevelId;
				int score = lstLevelInfo.Score;
				this.ReviewList.Add(new ShipTowerReviewItemData
				{
					Title = this.GetStageNameById(levelId),
					Score = score,
					Grade = this.GetStageGradeResIdByStageId(levelId, score),
					StageId = levelId,
					IsQuickPass = lstLevelInfo.EasyPassFlag
				});
			}
		}
		this.ReviewProgressList.Clear();
		this.ReviewProgressList.Add((response != null) ? response.LastCanRewardCount : 0);
		this.ReviewProgressList.Add((response != null) ? response.LastTotalRewardCount : 0);
	}

	// Token: 0x06013A98 RID: 80536 RVA: 0x005BBC4C File Offset: 0x005B9E4C
	public bool CheckCanOpen(EUiViewName name, object ob)
	{
		if (OnlineModel.Instance.GetIsTeamModel())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_600064_Text", Array.Empty<object>());
			return false;
		}
		bool flag = this.IsOpen();
		if (!flag)
		{
			FunctionCondition? functionCondition = FunctionConfig.Instance.GetFunctionCondition(10081);
			int? num = (functionCondition != null) ? new int?(functionCondition.GetValueOrDefault().OpenConditionId) : null;
			if (num != null)
			{
				ConditionGroup? conditionGroupConfig = ConditionConfig.Instance.GetConditionGroupConfig(num.Value);
				if (((conditionGroupConfig != null) ? conditionGroupConfig.GetValueOrDefault().HintText : null) != null)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId(conditionGroupConfig.Value.HintText, Array.Empty<object>());
				}
			}
		}
		return flag;
	}

	// Token: 0x06013A99 RID: 80537 RVA: 0x005BBD1C File Offset: 0x005B9F1C
	public bool CheckInBattleShipTower()
	{
		if (!GameModeController.Instance.IsInInstance())
		{
			return false;
		}
		int instanceId = CreatureModel.Instance.GetInstanceId();
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		return config != null && config.Value.InstSubType == 27;
	}

	// Token: 0x06013A9A RID: 80538 RVA: 0x005BBD6D File Offset: 0x005B9F6D
	public bool IsOpen()
	{
		return FunctionModel.Instance.IsOpen(10081);
	}

	// Token: 0x06013A9B RID: 80539 RVA: 0x005BBD80 File Offset: 0x005B9F80
	public void StartChallenge(ShipTowerStageData stageData)
	{
		this.ChallengeStageData = stageData;
		List<int> list = new List<int>();
		foreach (ShipTowerTeamData shipTowerTeamData in stageData.TeamDataList)
		{
			List<int> list2 = list;
			ShipTowerBuffData buffDataEdit = shipTowerTeamData.BuffDataEdit;
			list2.Add((buffDataEdit != null) ? buffDataEdit.Id : 0);
		}
		this.SetChallengeBuffIdList(list);
		ShipTowerController.Instance.RequestChallenge(stageData, false, false);
	}

	// Token: 0x06013A9C RID: 80540 RVA: 0x005BBE08 File Offset: 0x005BA008
	private void SetChallengeBuffIdList(List<int> buffIdList)
	{
		this.ChallengeBuffIdList.Clear();
		this.ChallengeBuffIdList.AddRange(buffIdList);
	}

	// Token: 0x06013A9D RID: 80541 RVA: 0x005BBE24 File Offset: 0x005BA024
	public void AgainChallenge()
	{
		if (this.CheckIsNeedShowConfirmSeasonUpdate(null))
		{
			return;
		}
		if (!this.CheckChallengeStageData())
		{
			return;
		}
		if (SceneTeamModel.Instance.IsAllDid())
		{
			return;
		}
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("ShipTower");
		int instanceId = CreatureModel.Instance.GetInstanceId();
		ShipTowerStageData challengeStageData = this.ChallengeStageData;
		bool isFromLast = challengeStageData != null && challengeStageData.TeamDataList[1].InstId == instanceId;
		ShipTowerController.Instance.RequestChallenge(this.ChallengeStageData, isFromLast, true);
	}

	// Token: 0x06013A9E RID: 80542 RVA: 0x005BBEA0 File Offset: 0x005BA0A0
	public void OpenViewMainFromFight()
	{
		if (!this.CheckChallengeStageData())
		{
			return;
		}
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("ShipTower");
		int id = this.ChallengeStageData.Id;
		this.OpenViewMain(new ShipTowerViewParams
		{
			StageId = new int?(id),
			IsFromInstanceDungeon = new bool?(true)
		});
	}

	// Token: 0x06013A9F RID: 80543 RVA: 0x005BBEF4 File Offset: 0x005BA0F4
	private bool CheckChallengeStageData()
	{
		if (this.ChallengeStageData != null)
		{
			return true;
		}
		int instanceId = CreatureModel.Instance.GetInstanceId();
		foreach (ShipTowerStageData shipTowerStageData in this.StageDataList)
		{
			if (shipTowerStageData.InstIds.Contains(instanceId))
			{
				this.ChallengeStageData = shipTowerStageData;
				return true;
			}
		}
		return false;
	}

	// Token: 0x06013AA0 RID: 80544 RVA: 0x005BBF74 File Offset: 0x005BA174
	public void ClearChallengeStageData()
	{
		if (this.ChallengeStageData == null)
		{
			return;
		}
		this.ChallengeStageData.UpdateToEdit();
		this.SetChallengeStageDataNull();
	}

	// Token: 0x06013AA1 RID: 80545 RVA: 0x005BBF90 File Offset: 0x005BA190
	public void SetChallengeStageDataNull()
	{
		this.ChallengeStageData = null;
	}

	// Token: 0x06013AA2 RID: 80546 RVA: 0x005BBF9C File Offset: 0x005BA19C
	[NullableContext(0)]
	public UniTask<bool> CheckIsNeedShowSeasonReview()
	{
		ShipTowerModel.<CheckIsNeedShowSeasonReview>d__121 <CheckIsNeedShowSeasonReview>d__;
		<CheckIsNeedShowSeasonReview>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<CheckIsNeedShowSeasonReview>d__.<>4__this = this;
		<CheckIsNeedShowSeasonReview>d__.<>1__state = -1;
		<CheckIsNeedShowSeasonReview>d__.<>t__builder.Start<ShipTowerModel.<CheckIsNeedShowSeasonReview>d__121>(ref <CheckIsNeedShowSeasonReview>d__);
		return <CheckIsNeedShowSeasonReview>d__.<>t__builder.Task;
	}

	// Token: 0x06013AA3 RID: 80547 RVA: 0x005BBFE0 File Offset: 0x005BA1E0
	private void CheckOldSeasonData()
	{
		List<ShipTowerStageData> list = new List<ShipTowerStageData>();
		foreach (ShipTowerStageData shipTowerStageData in this.StageDataList)
		{
			if (shipTowerStageData.IsOldSeasonData())
			{
				list.Add(shipTowerStageData);
			}
		}
		if (list.Count > 0)
		{
			foreach (ShipTowerStageData shipTowerStageData2 in list)
			{
				shipTowerStageData2.ResetStage();
				EventSystem.Instance.Emit<int>(EEventName.ShipTowerStageUpdate, shipTowerStageData2.Id);
			}
			this.UpdateAreaListState();
		}
	}

	// Token: 0x06013AA4 RID: 80548 RVA: 0x005BC0A4 File Offset: 0x005BA2A4
	public string GetStageGradeResId(string charStr)
	{
		ShipTowerScoreGrade shipTowerScoreGrade;
		ShipTowerDefine.shipTowerScoreGradeMap.TryGetValue(charStr, out shipTowerScoreGrade);
		if (shipTowerScoreGrade == null)
		{
			return ShipTowerDefine.shipTowerScoreGradeMap["D"].ResId;
		}
		return shipTowerScoreGrade.ResId;
	}

	// Token: 0x06013AA5 RID: 80549 RVA: 0x005BC0E0 File Offset: 0x005BA2E0
	public string GetShareStageGradeResId(string charStr)
	{
		ShipTowerScoreGrade shipTowerScoreGrade;
		ShipTowerDefine.shipTowerScoreGradeMap.TryGetValue(charStr, out shipTowerScoreGrade);
		if (shipTowerScoreGrade == null)
		{
			return ShipTowerDefine.shipTowerScoreGradeMap["D"].BigResId;
		}
		return shipTowerScoreGrade.BigResId;
	}

	// Token: 0x06013AA6 RID: 80550 RVA: 0x005BC11C File Offset: 0x005BA31C
	[NullableContext(2)]
	public string GetStageGradeResIdByStageId(int stageId, int score)
	{
		ShipTowerStageData stageDataById = this.GetStageDataById(stageId);
		if (stageDataById != null)
		{
			return stageDataById.GetStageGradeResIdByScore(score);
		}
		SlashAndTowerCfg? stageCfgById = ShipTowerConfig.Instance.GetStageCfgById(stageId);
		if (stageCfgById != null)
		{
			return this.GetStageGradeResIdByScore(score, stageCfgById.Value.TargetScore(), stageCfgById.Value.ScoreStage());
		}
		return null;
	}

	// Token: 0x06013AA7 RID: 80551 RVA: 0x005BC178 File Offset: 0x005BA378
	[return: Nullable(2)]
	public string GetStageGradeResIdByScore(int score, int[] targetList, string[] stageList)
	{
		for (int i = targetList.Length - 1; i >= 0; i--)
		{
			if (score >= targetList[i])
			{
				return this.GetStageGradeResId(stageList[i]);
			}
		}
		return null;
	}

	// Token: 0x06013AA8 RID: 80552 RVA: 0x005BC1A8 File Offset: 0x005BA3A8
	[return: Nullable(2)]
	public string GetShareStageGradeResIdByScore(int score, int[] targetList, string[] stageList)
	{
		for (int i = targetList.Length - 1; i >= 0; i--)
		{
			if (score >= targetList[i])
			{
				return this.GetShareStageGradeResId(stageList[i]);
			}
		}
		return null;
	}

	// Token: 0x06013AA9 RID: 80553 RVA: 0x005BC1D8 File Offset: 0x005BA3D8
	public string GetStageNameById(int stageId)
	{
		ShipTowerStageData stageDataById = this.GetStageDataById(stageId);
		string text = null;
		if (stageDataById != null)
		{
			text = stageDataById.TitleKey;
		}
		SlashAndTowerCfg? stageCfgById = ShipTowerConfig.Instance.GetStageCfgById(stageId);
		if (stageCfgById != null)
		{
			text = stageCfgById.Value.Title;
		}
		if (text != null)
		{
			return TextConfig.Instance.GetMultiTextByKey(text, text);
		}
		return "";
	}

	// Token: 0x06013AAA RID: 80554 RVA: 0x005BC234 File Offset: 0x005BA434
	public int GetStageOrderIndexById(int stageId)
	{
		ShipTowerStageData stageDataById = this.GetStageDataById(stageId);
		int result = 0;
		if (stageDataById != null)
		{
			result = stageDataById.OrderIndex;
		}
		SlashAndTowerCfg? stageCfgById = ShipTowerConfig.Instance.GetStageCfgById(stageId);
		if (stageCfgById != null)
		{
			result = stageCfgById.Value.OrderIndex;
		}
		return result;
	}

	// Token: 0x06013AAB RID: 80555 RVA: 0x005BC27C File Offset: 0x005BA47C
	public bool GetStageIsEndlessById(int stageId)
	{
		ShipTowerStageData stageDataById = this.GetStageDataById(stageId);
		if (stageDataById != null)
		{
			return stageDataById.IsEndLess;
		}
		SlashAndTowerCfg? stageCfgById = ShipTowerConfig.Instance.GetStageCfgById(stageId);
		return stageCfgById != null && stageCfgById.Value.EndLess;
	}

	// Token: 0x06013AAC RID: 80556 RVA: 0x005BC2C4 File Offset: 0x005BA4C4
	public IBattleUiHoverTipsD GetInTheBattleBuffInfo()
	{
		object obj = this.CheckChallengeStageData() ? this.ChallengeStageData : this.StageDataList[0];
		int instId = CreatureModel.Instance.GetInstanceId();
		object obj2 = obj;
		int index = (obj2 != null) ? obj2.TeamDataList.FindIndex((ShipTowerTeamData data) => data.InstId == instId) : 0;
		int id = this.ChallengeBuffIdList[index];
		SlashBuffToItem? buffCfgById = ShipTowerConfig.Instance.GetBuffCfgById(id);
		int num;
		if (buffCfgById != null)
		{
			num = buffCfgById.Value.ItemId;
		}
		else
		{
			num = 0;
			using (Dictionary<int, ShipTowerBuffData>.Enumerator enumerator = this.BuffDataMap.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					KeyValuePair<int, ShipTowerBuffData> keyValuePair = enumerator.Current;
					num = keyValuePair.Value.ItemId;
				}
			}
		}
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(num);
		string name = itemConfig.Value.Name;
		string obtainedShowDescription = itemConfig.Value.ObtainedShowDescription;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
		defaultInterpolatedStringHandler.AppendLiteral("GhostShipItemQuality_Text");
		defaultInterpolatedStringHandler.AppendFormatted<int>(itemConfig.Value.QualityId);
		string subTitleKey = defaultInterpolatedStringHandler.ToStringAndClear();
		return new BattleUiHoverTipsD
		{
			TitleKey = name,
			SubTitleKey = subTitleKey,
			ItemInfo = new PropSmallItemGrid
			{
				ItemConfigId = new int?(num),
				Data = null
			},
			DescInfoList = new List<IBattleUiHoverTipsDescInfo>
			{
				new BattleUiHoverTipsDescInfo
				{
					DescKey = obtainedShowDescription,
					DescUseChangeColor = new bool?(true)
				}
			},
			DescTitleKey = "GhostShipSkillTitle_Text"
		};
	}

	// Token: 0x06013AAD RID: 80557 RVA: 0x005BC47C File Offset: 0x005BA67C
	public void AddShowBuffId(int buffId, bool isShowTips = true)
	{
		this.GetBuffIdList.Add(buffId);
		if (isShowTips)
		{
			this.ShowBuffIdList.Add(buffId);
			if (!UiManager.Instance.IsViewOpen(EUiViewName.ShipTowerShowBuffView))
			{
				UiManager.Instance.OpenView(EUiViewName.ShipTowerShowBuffView, null, null);
			}
		}
	}

	// Token: 0x06013AAE RID: 80558 RVA: 0x005BC4BC File Offset: 0x005BA6BC
	[NullableContext(0)]
	public UniTask<bool> CheckShowGetBuff()
	{
		ShipTowerModel.<CheckShowGetBuff>d__133 <CheckShowGetBuff>d__;
		<CheckShowGetBuff>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<CheckShowGetBuff>d__.<>4__this = this;
		<CheckShowGetBuff>d__.<>1__state = -1;
		<CheckShowGetBuff>d__.<>t__builder.Start<ShipTowerModel.<CheckShowGetBuff>d__133>(ref <CheckShowGetBuff>d__);
		return <CheckShowGetBuff>d__.<>t__builder.Task;
	}

	// Token: 0x06013AAF RID: 80559 RVA: 0x005BC4FF File Offset: 0x005BA6FF
	public void ClearGetBuffIdList()
	{
		this.GetBuffIdList.Clear();
	}

	// Token: 0x06013AB0 RID: 80560 RVA: 0x005BC50C File Offset: 0x005BA70C
	private List<TItem> GetShowGetBuffDataList()
	{
		List<TItem> list = new List<TItem>();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (int buffId in this.GetBuffIdList)
		{
			ShipTowerBuffData buffDataByBuffId = this.GetBuffDataByBuffId(buffId);
			if (buffDataByBuffId != null)
			{
				int index;
				if (dictionary.TryGetValue(buffDataByBuffId.ItemId, out index))
				{
					TItem value = list[index];
					value.Count++;
					list[index] = value;
				}
				else
				{
					dictionary[buffDataByBuffId.ItemId] = list.Count;
					list.Add(new TItem(new InventoryDefine.GetItemData(buffDataByBuffId.ItemId, 0), 0));
				}
			}
		}
		return list;
	}

	// Token: 0x06013AB1 RID: 80561 RVA: 0x005BC5D4 File Offset: 0x005BA7D4
	public UniTask OpenWelcomeView()
	{
		ShipTowerModel.<OpenWelcomeView>d__136 <OpenWelcomeView>d__;
		<OpenWelcomeView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenWelcomeView>d__.<>4__this = this;
		<OpenWelcomeView>d__.<>1__state = -1;
		<OpenWelcomeView>d__.<>t__builder.Start<ShipTowerModel.<OpenWelcomeView>d__136>(ref <OpenWelcomeView>d__);
		return <OpenWelcomeView>d__.<>t__builder.Task;
	}

	// Token: 0x06013AB2 RID: 80562 RVA: 0x005BC617 File Offset: 0x005BA817
	public void CloseWelcomeView()
	{
		UiManager.Instance.CloseView(EUiViewName.ShipTowerWelcomeView, null);
	}

	// Token: 0x06013AB3 RID: 80563 RVA: 0x005BC629 File Offset: 0x005BA829
	[NullableContext(2)]
	public bool CheckIsNeedShowConfirmSeasonUpdate(Action confirmCallback = null)
	{
		if (this.IsShowConfirmSeasonUpdate())
		{
			this.OpenConfirmSeasonUpdate(confirmCallback);
			return true;
		}
		return false;
	}

	// Token: 0x06013AB4 RID: 80564 RVA: 0x005BC63D File Offset: 0x005BA83D
	private bool IsShowConfirmSeasonUpdate()
	{
		return this.IsNeedShowSeasonReview || this.TimeIsOver();
	}

	// Token: 0x06013AB5 RID: 80565 RVA: 0x005BC654 File Offset: 0x005BA854
	[NullableContext(2)]
	private void OpenConfirmSeasonUpdate(Action confirmCallback = null)
	{
		if (this.IsOpenedSeasonUpdate)
		{
			return;
		}
		this.IsOpenedSeasonUpdate = true;
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ShipTowerSeasonUpdate);
		Action value = delegate()
		{
			Action action = confirmCallback ?? new Action(this.ConfirmSeasonUpdateCallback);
			if (action != null)
			{
				action();
			}
			this.IsOpenedSeasonUpdate = false;
		};
		confirmBoxDataNew.FunctionMap[1] = value;
		confirmBoxDataNew.FunctionMap[2] = value;
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06013AB6 RID: 80566 RVA: 0x005BC6C4 File Offset: 0x005BA8C4
	public void OpenConfirmBackWorld()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ShipTowerFromViewLeaveInst);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			this.LeaveBattle();
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06013AB7 RID: 80567 RVA: 0x005BC700 File Offset: 0x005BA900
	private void ConfirmSeasonUpdateCallback()
	{
		if (this.LeaveBattle())
		{
			return;
		}
		this.CloseMainView();
	}

	// Token: 0x06013AB8 RID: 80568 RVA: 0x005BC711 File Offset: 0x005BA911
	public bool LeaveBattle()
	{
		if (!this.CheckInBattleShipTower())
		{
			return false;
		}
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("ShipTower");
		TowerModel.Instance.CurrentTowerId = -1;
		InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
		return true;
	}

	// Token: 0x06013AB9 RID: 80569 RVA: 0x005BC748 File Offset: 0x005BA948
	public bool IsExistFirstGetBuff()
	{
		foreach (ShipTowerBuffQuality shipTowerBuffQuality in this.BuffQualityList)
		{
			using (List<ShipTowerBuffData>.Enumerator enumerator2 = shipTowerBuffQuality.BuffList.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.IsFirstGet())
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06013ABA RID: 80570 RVA: 0x005BC7DC File Offset: 0x005BA9DC
	public void CloseMainView()
	{
		UiManager.Instance.CloseView(EUiViewName.ShipTowerView, null);
	}

	// Token: 0x06013ABB RID: 80571 RVA: 0x005BC7EE File Offset: 0x005BA9EE
	public double GetRemainTime()
	{
		if (this.CurSeasonEndTime <= 0L)
		{
			return 0.0;
		}
		return (double)this.CurSeasonEndTime - TimeUtil.Instance.GetServerTime();
	}

	// Token: 0x06013ABC RID: 80572 RVA: 0x005BC816 File Offset: 0x005BAA16
	public bool TimeIsOver()
	{
		return this.GetRemainTime() <= 0.0;
	}

	// Token: 0x06013ABD RID: 80573 RVA: 0x005BC82C File Offset: 0x005BAA2C
	public string GetRewardCountDownDesc()
	{
		double remainTime = this.GetRemainTime();
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(remainTime);
		if (remainTimeDataFormat.CountDownText == null)
		{
			return "";
		}
		string key = "GhostShipTimeLimit_Text";
		return TextConfig.Instance.GetMultiText(key, new string[]
		{
			remainTimeDataFormat.CountDownText
		});
	}

	// Token: 0x06013ABE RID: 80574 RVA: 0x005BC87C File Offset: 0x005BAA7C
	public UniTask ReceiveAward(int id, int[] ids)
	{
		ShipTowerModel.<ReceiveAward>d__149 <ReceiveAward>d__;
		<ReceiveAward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ReceiveAward>d__.<>4__this = this;
		<ReceiveAward>d__.id = id;
		<ReceiveAward>d__.ids = ids;
		<ReceiveAward>d__.<>1__state = -1;
		<ReceiveAward>d__.<>t__builder.Start<ShipTowerModel.<ReceiveAward>d__149>(ref <ReceiveAward>d__);
		return <ReceiveAward>d__.<>t__builder.Task;
	}

	// Token: 0x06013ABF RID: 80575 RVA: 0x005BC8CF File Offset: 0x005BAACF
	public bool IsCanReceiveAward()
	{
		return this.RewardCanReceiveNum > 0;
	}

	// Token: 0x06013AC0 RID: 80576 RVA: 0x005BC8DA File Offset: 0x005BAADA
	public bool IsEndlessRecordOpen()
	{
		return this.CurIsHaveRecord;
	}

	// Token: 0x06013AC1 RID: 80577 RVA: 0x005BC8E2 File Offset: 0x005BAAE2
	public bool IsCanUseRole(int roleId)
	{
		return RoleModel.Instance.GetRoleInstanceById(roleId) != null;
	}

	// Token: 0x06013AC2 RID: 80578 RVA: 0x005BC8F4 File Offset: 0x005BAAF4
	public UniTask RequestRecord()
	{
		ShipTowerModel.<RequestRecord>d__153 <RequestRecord>d__;
		<RequestRecord>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRecord>d__.<>1__state = -1;
		<RequestRecord>d__.<>t__builder.Start<ShipTowerModel.<RequestRecord>d__153>(ref <RequestRecord>d__);
		return <RequestRecord>d__.<>t__builder.Task;
	}

	// Token: 0x06013AC3 RID: 80579 RVA: 0x005BC930 File Offset: 0x005BAB30
	public CommonDefine.ICountDown GetSeasonCountDownData()
	{
		double num = this.GetRemainTime();
		if (num <= 1.0)
		{
			num = 1.0;
		}
		CommonDefine.ETimeType value = (num >= 86400.0) ? CommonDefine.ETimeType.Day : ((num >= 3600.0) ? CommonDefine.ETimeType.Hour : CommonDefine.ETimeType.Minute);
		CommonDefine.ETimeType value2 = (num >= 86400.0) ? CommonDefine.ETimeType.Hour : ((num >= 3600.0) ? CommonDefine.ETimeType.Minute : CommonDefine.ETimeType.Second);
		return TimeUtil.Instance.GetCountDownDataFormat2(num, new CommonDefine.ETimeType?(value), new CommonDefine.ETimeType?(value2));
	}

	// Token: 0x06013AC4 RID: 80580 RVA: 0x005BC9B4 File Offset: 0x005BABB4
	public string GetStageAreaName(int? stageId = null)
	{
		ShipTowerStageData shipTowerStageData;
		if (stageId == null)
		{
			shipTowerStageData = this.GetCurrentStage();
		}
		else
		{
			shipTowerStageData = this.GetStageDataById(stageId.Value);
			if (shipTowerStageData == null)
			{
				shipTowerStageData = ((this.StageDataList.Count > 0) ? this.StageDataList[0] : null);
			}
		}
		int num = -1;
		for (int i = 0; i < this.StageDataList.Count; i++)
		{
			int id = this.StageDataList[i].Id;
			int? num2 = (shipTowerStageData != null) ? new int?(shipTowerStageData.Id) : null;
			if (id == num2.GetValueOrDefault() & num2 != null)
			{
				num = i;
				break;
			}
		}
		IReadOnlyList<SlashTowerShowStage> allShowStageCfg = ShipTowerConfig.Instance.GetAllShowStageCfg();
		if (allShowStageCfg != null)
		{
			foreach (SlashTowerShowStage slashTowerShowStage in allShowStageCfg)
			{
				if (slashTowerShowStage.OutIndex >= num)
				{
					return TextConfig.Instance.GetMultiTextByKey(slashTowerShowStage.Name, slashTowerShowStage.Name);
				}
			}
		}
		return "";
	}

	// Token: 0x06013AC5 RID: 80581 RVA: 0x005BCAD4 File Offset: 0x005BACD4
	public string GetCurrentStageSeasonName()
	{
		ShipTowerStageData currentStage = this.GetCurrentStage();
		if ((currentStage != null && currentStage.BelongToSeason == 0) || !this.IsOpen())
		{
			string text = "GhostShipProgressName_Text1";
			return TextConfig.Instance.GetMultiTextByKey(text, text);
		}
		string text2 = "GhostShipProgressName_Text2";
		return TextConfig.Instance.GetMultiTextByKey(text2, text2);
	}

	// Token: 0x06013AC6 RID: 80582 RVA: 0x005BCB28 File Offset: 0x005BAD28
	public string GetCurrentStageSeasonName2()
	{
		ShipTowerStageData currentStage = this.GetCurrentStage();
		if (currentStage != null && currentStage.BelongToSeason == 0)
		{
			string text = "GhostShipLevelStage_Text1";
			return TextConfig.Instance.GetMultiTextByKey(text, text);
		}
		string text2 = "GhostShipLevelStage_Text4";
		return TextConfig.Instance.GetMultiTextByKey(text2, text2);
	}

	// Token: 0x06013AC7 RID: 80583 RVA: 0x005BCB74 File Offset: 0x005BAD74
	[NullableContext(2)]
	public ShipTowerStageData GetCurrentStage()
	{
		for (int i = this.StageDataList.Count - 1; i >= 0; i--)
		{
			ShipTowerStageData shipTowerStageData = this.StageDataList[i];
			if (shipTowerStageData.IsUnLocked())
			{
				return shipTowerStageData;
			}
		}
		if (this.StageDataList.Count <= 0)
		{
			return null;
		}
		return this.StageDataList[0];
	}

	// Token: 0x06013AC8 RID: 80584 RVA: 0x005BCBCC File Offset: 0x005BADCC
	public bool IsPassZeroSeason()
	{
		if (!this.IsOpen())
		{
			return false;
		}
		ShipTowerStageData currentStage = this.GetCurrentStage();
		return currentStage == null || currentStage.BelongToSeason != 0;
	}

	// Token: 0x06013AC9 RID: 80585 RVA: 0x005BCBEC File Offset: 0x005BADEC
	public List<FormationData> GetPlayerTeamList()
	{
		List<FormationData> list = new List<FormationData>();
		int maxFormationId = FormationConfig.Instance.GetMaxFormationId();
		for (int i = 1; i <= maxFormationId; i++)
		{
			FormationData formationData = FormationModel.Instance.GetFormationData(i);
			if (formationData != null)
			{
				list.Add(formationData);
			}
			else
			{
				list.Add(new FormationData(i));
			}
		}
		return list;
	}

	// Token: 0x06013ACA RID: 80586 RVA: 0x005BCC3B File Offset: 0x005BAE3B
	public void UpdateToEdit()
	{
		this.StageDataList.ForEach(delegate(ShipTowerStageData stageData)
		{
			stageData.UpdateToEdit();
		});
	}

	// Token: 0x06013ACB RID: 80587 RVA: 0x005BCC68 File Offset: 0x005BAE68
	public List<ShipTowerAreaItemData> GetAreaList()
	{
		if (this.AreaList.Count >= 2)
		{
			return this.AreaList;
		}
		if (this.AreaList.Count == 0)
		{
			this.InitAreaList();
		}
		int areaId = Math.Max(this.CurSeason, 1);
		this.AreaList.Add(this.CreateAreaDataById(areaId, false));
		this.AreaList.Add(this.CreateAreaDataById(areaId, true));
		this.UpdateAreaListState();
		return this.AreaList;
	}

	// Token: 0x06013ACC RID: 80588 RVA: 0x005BCCDC File Offset: 0x005BAEDC
	public ShipTowerAreaItemData CreateAreaDataById(int areaId, bool isEndless = false)
	{
		List<ShipTowerRewardItemData> rewardListByAreaId = this.GetRewardListByAreaId(areaId, isEndless);
		string name = "GhostShipLevelStage_Text1";
		if (areaId != 0)
		{
			name = (isEndless ? "GhostShipLevelStage_Text3" : "GhostShipLevelStage_Text2");
		}
		return new ShipTowerAreaItemData
		{
			Id = areaId,
			Index = new int?(this.AreaList.Count),
			Name = name,
			Desc = "",
			RewardList = rewardListByAreaId,
			IsEndless = new bool?(isEndless),
			MaxScore = new int?(((rewardListByAreaId.Count > 0) ? new int?(rewardListByAreaId[rewardListByAreaId.Count - 1].TotalScore) : null).GetValueOrDefault())
		};
	}

	// Token: 0x06013ACD RID: 80589 RVA: 0x005BCD94 File Offset: 0x005BAF94
	public List<ShipTowerRewardItemData> GetRewardListByAreaId(int areaId, bool isEndless = false)
	{
		List<ShipTowerRewardItemData> list = new List<ShipTowerRewardItemData>();
		IReadOnlyList<SlashAndTowerReward> challengeRewardCfgBySeason = ShipTowerConfig.Instance.GetChallengeRewardCfgBySeason(areaId);
		if (challengeRewardCfgBySeason != null)
		{
			foreach (SlashAndTowerReward slashAndTowerReward in challengeRewardCfgBySeason)
			{
				if (isEndless == slashAndTowerReward.EndLessReward)
				{
					List<TItem> list2 = new List<TItem>();
					DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(slashAndTowerReward.RewardId);
					if (((dropPackage != null) ? dropPackage.GetValueOrDefault().DropPreview() : null) != null)
					{
						foreach (KeyValuePair<int, int> keyValuePair in dropPackage.Value.DropPreview())
						{
							InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(keyValuePair.Key, 0);
							list2.Add(new TItem
							{
								ItemData = itemData,
								Count = keyValuePair.Value
							});
						}
					}
					list.Add(new ShipTowerRewardItemData
					{
						Id = slashAndTowerReward.Id,
						TitleKey = slashAndTowerReward.Desc,
						TotalScore = slashAndTowerReward.SumScore,
						RewardList = list2,
						IsReceive = false,
						IsProgress = false,
						IsCompleted = false
					});
				}
			}
		}
		return list;
	}

	// Token: 0x06013ACE RID: 80590 RVA: 0x005BCF20 File Offset: 0x005BB120
	public void ClearAreaList()
	{
		for (int i = this.AreaList.Count - 1; i >= 0; i--)
		{
			if (this.AreaList[i].Id != 0)
			{
				this.AreaList.RemoveAt(i);
			}
		}
	}

	// Token: 0x06013ACF RID: 80591 RVA: 0x005BCF64 File Offset: 0x005BB164
	private void UpdateAreaListState()
	{
		this.RewardCanReceiveNum = 0;
		this.RewardTotalNum = 0;
		foreach (ShipTowerAreaItemData shipTowerAreaItemData in this.AreaList)
		{
			int id = shipTowerAreaItemData.Id;
			bool? isEndless = shipTowerAreaItemData.IsEndless;
			int num = 0;
			foreach (ShipTowerStageData shipTowerStageData in this.TowerStageDataList)
			{
				if (shipTowerStageData.BelongToSeason == id)
				{
					bool isEndLess = shipTowerStageData.IsEndLess;
					bool? flag = isEndless;
					if (isEndLess == flag.GetValueOrDefault() & flag != null)
					{
						num += shipTowerStageData.CurrentScore;
					}
				}
			}
			ShipTowerAreaItemData shipTowerAreaItemData2 = shipTowerAreaItemData;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#fee488ff>");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral("</color>/");
			defaultInterpolatedStringHandler.AppendFormatted<int?>(shipTowerAreaItemData.MaxScore);
			shipTowerAreaItemData2.Desc = defaultInterpolatedStringHandler.ToStringAndClear();
			bool value = true;
			bool value2 = false;
			foreach (ShipTowerRewardItemData shipTowerRewardItemData in shipTowerAreaItemData.RewardList)
			{
				bool flag2 = this.ReceivedAwardScoreIdSet.Contains(shipTowerRewardItemData.Id);
				shipTowerRewardItemData.IsReceive = (!flag2 && num >= shipTowerRewardItemData.TotalScore);
				shipTowerRewardItemData.IsProgress = (!flag2 && num < shipTowerRewardItemData.TotalScore);
				shipTowerRewardItemData.IsCompleted = flag2;
				if (!shipTowerRewardItemData.IsCompleted)
				{
					value = false;
				}
				if (shipTowerRewardItemData.IsReceive)
				{
					value2 = true;
					this.RewardCanReceiveNum++;
				}
				this.RewardTotalNum++;
			}
			shipTowerAreaItemData.IsFinish = new bool?(value);
			shipTowerAreaItemData.IsRedPoint = new bool?(value2);
			shipTowerAreaItemData.RewardList.Sort(delegate(ShipTowerRewardItemData a, ShipTowerRewardItemData b)
			{
				if (a.IsReceive != b.IsReceive)
				{
					if (!a.IsReceive)
					{
						return 1;
					}
					return -1;
				}
				else
				{
					if (a.IsProgress == b.IsProgress)
					{
						return a.Id - b.Id;
					}
					if (!a.IsProgress)
					{
						return 1;
					}
					return -1;
				}
			});
		}
		this.AreaList.Sort(delegate(ShipTowerAreaItemData a, ShipTowerAreaItemData b)
		{
			bool? isFinish = a.IsFinish;
			bool? isFinish2 = b.IsFinish;
			if (isFinish.GetValueOrDefault() == isFinish2.GetValueOrDefault() & isFinish != null == (isFinish2 != null))
			{
				return a.Index.Value - b.Index.Value;
			}
			if (!a.IsFinish.GetValueOrDefault())
			{
				return -1;
			}
			return 1;
		});
		EventSystem.Instance.Emit(EEventName.RedDotUpdateShipTowerReward);
		ActivityShipTowerController.RefreshActivityRedDot();
	}

	// Token: 0x06013AD0 RID: 80592 RVA: 0x005BD200 File Offset: 0x005BB400
	public string GetRewardProgressText(bool useColor = true)
	{
		ValueTuple<int, int> rewardProgressNumData = this.GetRewardProgressNumData();
		int item = rewardProgressNumData.Item1;
		int item2 = rewardProgressNumData.Item2;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (useColor)
		{
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#fadf85>");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item);
			defaultInterpolatedStringHandler.AppendLiteral("</color>/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(item);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06013AD1 RID: 80593 RVA: 0x005BD28C File Offset: 0x005BB48C
	[NullableContext(0)]
	public ValueTuple<int, int> GetRewardProgressNumData()
	{
		int num = 0;
		int num2 = 0;
		bool flag = this.IsPassZeroSeason();
		List<ShipTowerAreaItemData> areaList = this.GetAreaList();
		List<ShipTowerAreaItemData> list = new List<ShipTowerAreaItemData>();
		foreach (ShipTowerAreaItemData shipTowerAreaItemData in areaList)
		{
			bool flag2 = shipTowerAreaItemData.Id == 0;
			if (flag ? (!flag2) : flag2)
			{
				list.Add(shipTowerAreaItemData);
			}
		}
		foreach (ShipTowerAreaItemData shipTowerAreaItemData2 in list)
		{
			int num3 = 0;
			using (List<ShipTowerRewardItemData>.Enumerator enumerator2 = shipTowerAreaItemData2.RewardList.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.IsCompleted)
					{
						num3++;
					}
				}
			}
			num += num3;
			num2 += shipTowerAreaItemData2.RewardList.Count;
		}
		return new ValueTuple<int, int>(num, num2);
	}

	// Token: 0x06013AD2 RID: 80594 RVA: 0x005BD3AC File Offset: 0x005BB5AC
	[NullableContext(0)]
	public ValueTuple<int, int> GetEndlessRewardProgressNumData()
	{
		int num = 0;
		int num2 = 0;
		List<ShipTowerAreaItemData> list = new List<ShipTowerAreaItemData>();
		foreach (ShipTowerAreaItemData shipTowerAreaItemData in this.AreaList)
		{
			if (shipTowerAreaItemData.Id != 0)
			{
				list.Add(shipTowerAreaItemData);
			}
		}
		foreach (ShipTowerAreaItemData shipTowerAreaItemData2 in list)
		{
			num += shipTowerAreaItemData2.RewardList.FindAll((ShipTowerRewardItemData item) => item.IsCompleted).Count;
			num2 += shipTowerAreaItemData2.RewardList.Count;
		}
		return new ValueTuple<int, int>(num, num2);
	}

	// Token: 0x06013AD3 RID: 80595 RVA: 0x005BD498 File Offset: 0x005BB698
	public bool CheckIsScoreBattle()
	{
		if (this.CurSeasonCfg == null || !this.CurSeasonCfg.Value.IsOpenHot)
		{
			return false;
		}
		ShipTowerStageData challengeStageData = this.ChallengeStageData;
		return challengeStageData != null && challengeStageData.StageType > EShipTowerStageType.OneTimeStage;
	}

	// Token: 0x06013AD4 RID: 80596 RVA: 0x005BD4E4 File Offset: 0x005BB6E4
	[NullableContext(2)]
	public ShipTowerTeamData GetCurrentStageTeamData()
	{
		ShipTowerStageData currentStage = this.GetCurrentStage();
		if (currentStage == null)
		{
			return null;
		}
		return currentStage.GetCurrentTeamData();
	}

	// Token: 0x06013AD5 RID: 80597 RVA: 0x005BD4F8 File Offset: 0x005BB6F8
	[NullableContext(2)]
	public List<int> GetRewardIdsByDifficulties(bool isCanReceive)
	{
		if (this.RewardCanReceiveNum <= 0)
		{
			return null;
		}
		List<int> list = new List<int>();
		foreach (ShipTowerAreaItemData shipTowerAreaItemData in this.AreaList)
		{
			foreach (ShipTowerRewardItemData shipTowerRewardItemData in shipTowerAreaItemData.RewardList)
			{
				int id = shipTowerAreaItemData.Id;
				bool? isEndless = shipTowerAreaItemData.IsEndless;
				int num = 0;
				foreach (ShipTowerStageData shipTowerStageData in this.TowerStageDataList)
				{
					bool flag = shipTowerStageData.BelongToSeason == id;
					bool flag2 = shipTowerStageData.IsEndLess == isEndless.GetValueOrDefault();
					if (flag && flag2)
					{
						num += shipTowerStageData.CurrentScore;
					}
				}
				if (isCanReceive)
				{
					if (!this.ReceivedAwardScoreIdSet.Contains(shipTowerRewardItemData.Id) && num >= shipTowerRewardItemData.TotalScore)
					{
						list.Add(shipTowerRewardItemData.Id);
					}
				}
				else if (this.ReceivedAwardScoreIdSet.Contains(shipTowerRewardItemData.Id))
				{
					list.Add(shipTowerRewardItemData.Id);
				}
			}
		}
		return list;
	}

	// Token: 0x17001DF4 RID: 7668
	// (get) Token: 0x06013AD6 RID: 80598 RVA: 0x005BD698 File Offset: 0x005BB898
	public static ShipTowerModel Instance
	{
		get
		{
			return ShipTowerModel._Instance;
		}
	}

	// Token: 0x06013AD7 RID: 80599 RVA: 0x005BD69F File Offset: 0x005BB89F
	public static ShipTowerModel GetOrCreateInstance()
	{
		if (ShipTowerModel._Instance == null)
		{
			ShipTowerModel.CreateInstance();
		}
		return ShipTowerModel._Instance;
	}

	// Token: 0x06013AD8 RID: 80600 RVA: 0x005BD6B3 File Offset: 0x005BB8B3
	public static bool CreateInstance()
	{
		if (ShipTowerModel._Instance != null)
		{
			return true;
		}
		ShipTowerModel._Instance = new ShipTowerModel();
		return true;
	}

	// Token: 0x06013AD9 RID: 80601 RVA: 0x005BD6C9 File Offset: 0x005BB8C9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013ADA RID: 80602 RVA: 0x005BD6CB File Offset: 0x005BB8CB
	public static void ResetStaticDefaultValue()
	{
		ShipTowerModel._Instance = null;
	}

	// Token: 0x06013ADB RID: 80603 RVA: 0x005BD6D3 File Offset: 0x005BB8D3
	static ShipTowerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ShipTowerModel.CreateStaticDefaultValue), new Action(ShipTowerModel.ResetStaticDefaultValue));
	}

	// Token: 0x06013ADD RID: 80605 RVA: 0x005BD7C4 File Offset: 0x005BB9C4
	[CompilerGenerated]
	internal static List<ShipTowerMediumItemData> <UpdateResultNotify>g__MakeRoleList|100_0(ShipTowerTeamData teamData)
	{
		List<ShipTowerMediumItemData> list = new List<ShipTowerMediumItemData>();
		foreach (ShipTowerRoleData shipTowerRoleData in teamData.RoleList)
		{
			List<ShipTowerMediumItemData> list2 = list;
			ShipTowerMediumItemData shipTowerMediumItemData = new ShipTowerMediumItemData();
			shipTowerMediumItemData.Id = shipTowerRoleData.RoleIdEdit;
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(shipTowerRoleData.RoleIdEdit, true);
			shipTowerMediumItemData.Count = ((roleDataById != null) ? roleDataById.GetLevelData().GetLevel() : 0);
			shipTowerMediumItemData.SkillBranchId = shipTowerRoleData.SkillBranchIdEdit;
			list2.Add(shipTowerMediumItemData);
		}
		return list;
	}

	// Token: 0x06013ADE RID: 80606 RVA: 0x005BD864 File Offset: 0x005BBA64
	[CompilerGenerated]
	internal static void <AddRecord>g__functionAddTeam|106_0(string teamTitle, [Nullable(2)] HalfEndlessBattleRecord teamInfo, ref ShipTowerModel.<>c__DisplayClass106_0 A_2)
	{
		if (teamInfo == null)
		{
			return;
		}
		BattleFormation battleFormation = teamInfo.BattleFormation;
		RepeatedField<int> repeatedField = (battleFormation != null) ? battleFormation.SelectRoles : null;
		List<int> list = (repeatedField != null) ? new List<int>(repeatedField) : new List<int>();
		List<int> list2 = new List<int>(teamInfo.RoleLevels);
		BattleFormation battleFormation2 = teamInfo.BattleFormation;
		RepeatedField<int> repeatedField2 = (battleFormation2 != null) ? battleFormation2.SkillBranchIds : null;
		List<ShipTowerMediumItemData> list3 = new List<ShipTowerMediumItemData>();
		for (int i = 0; i < list.Count; i++)
		{
			int id = list[i];
			int count = (i < list2.Count) ? list2[i] : 0;
			int skillBranchId = (repeatedField2 != null && i < repeatedField2.Count) ? repeatedField2[i] : 0;
			list3.Add(new ShipTowerMediumItemData
			{
				Id = id,
				Count = count,
				SkillBranchId = skillBranchId
			});
		}
		ShipTowerRecordItemData shipTowerRecordItemData = new ShipTowerRecordItemData();
		shipTowerRecordItemData.Title = TextConfig.Instance.GetMultiTextByKey(teamTitle, teamTitle);
		shipTowerRecordItemData.Score = teamInfo.MaxScore;
		shipTowerRecordItemData.Wave = teamInfo.MaxRound;
		shipTowerRecordItemData.TeamList = list3;
		BattleFormation battleFormation3 = teamInfo.BattleFormation;
		shipTowerRecordItemData.BuffId = ((battleFormation3 != null) ? battleFormation3.BuffSelect : 0);
		ShipTowerRecordItemData item = shipTowerRecordItemData;
		A_2.data.RecordList.Add(item);
	}

	// Token: 0x0400A839 RID: 43065
	private bool IsInitData;

	// Token: 0x0400A83A RID: 43066
	private readonly List<ShipTowerStageData> StageDataList = new List<ShipTowerStageData>();

	// Token: 0x0400A83B RID: 43067
	private readonly Dictionary<int, ShipTowerStageData> StageDataMap = new Dictionary<int, ShipTowerStageData>();

	// Token: 0x0400A83C RID: 43068
	public bool DebugParallaxSub;

	// Token: 0x0400A83D RID: 43069
	private readonly List<ShipTowerBuffQuality> BuffQualityList = new List<ShipTowerBuffQuality>();

	// Token: 0x0400A83E RID: 43070
	private readonly Dictionary<int, ShipTowerBuffQuality> BuffQualityMap = new Dictionary<int, ShipTowerBuffQuality>();

	// Token: 0x0400A83F RID: 43071
	private readonly Dictionary<int, ShipTowerBuffData> BuffDataMap = new Dictionary<int, ShipTowerBuffData>();

	// Token: 0x0400A840 RID: 43072
	private readonly List<ShipTowerTeamTab> TeamTabList = new List<ShipTowerTeamTab>();

	// Token: 0x0400A841 RID: 43073
	private readonly Dictionary<int, ShipTowerRoleData> OtherTeamRoleMap = new Dictionary<int, ShipTowerRoleData>();

	// Token: 0x0400A842 RID: 43074
	private readonly Dictionary<int, ShipTowerRoleData> AllTeamRoleMap = new Dictionary<int, ShipTowerRoleData>();

	// Token: 0x0400A843 RID: 43075
	private int Season;

	// Token: 0x0400A844 RID: 43076
	private long SeasonEndTime;

	// Token: 0x0400A845 RID: 43077
	private bool IsHaveRecord;

	// Token: 0x0400A846 RID: 43078
	private bool IsNeedShowSeasonReview;

	// Token: 0x0400A847 RID: 43079
	private readonly List<ShipTowerAreaItemData> AreaList = new List<ShipTowerAreaItemData>();

	// Token: 0x0400A848 RID: 43080
	private readonly HashSet<int> ReceivedAwardScoreIdSet = new HashSet<int>();

	// Token: 0x0400A849 RID: 43081
	private int ReceivingAwardId;

	// Token: 0x0400A84A RID: 43082
	public List<ShipTowerAreaItemData> RecordList = new List<ShipTowerAreaItemData>();

	// Token: 0x0400A84B RID: 43083
	private int RewardCanReceiveNum;

	// Token: 0x0400A84C RID: 43084
	private int RewardTotalNum;

	// Token: 0x0400A84D RID: 43085
	[Nullable(2)]
	public ShipTowerStageData ChallengeStageData;

	// Token: 0x0400A84E RID: 43086
	public readonly List<int> ChallengeBuffIdList = new List<int>();

	// Token: 0x0400A84F RID: 43087
	public readonly List<ShipTowerReviewItemData> ReviewList = new List<ShipTowerReviewItemData>();

	// Token: 0x0400A850 RID: 43088
	public readonly List<int> ReviewProgressList = new List<int>();

	// Token: 0x0400A851 RID: 43089
	private readonly List<int> GetBuffIdList = new List<int>();

	// Token: 0x0400A852 RID: 43090
	public readonly List<int> ShowBuffIdList = new List<int>();

	// Token: 0x0400A853 RID: 43091
	[Nullable(2)]
	private CustomPromise<bool> WelcomeViewPromise;

	// Token: 0x0400A854 RID: 43092
	[Nullable(2)]
	private CustomPromise<bool> SeasonReviewViewPromise;

	// Token: 0x0400A855 RID: 43093
	[Nullable(2)]
	private CustomPromise<bool> GetBuffViewPromise;

	// Token: 0x0400A856 RID: 43094
	[Nullable(2)]
	public ShipTowerBuffData CurSelectBuffData;

	// Token: 0x0400A857 RID: 43095
	public readonly HashSet<int> PlayerGetBuffSet = new HashSet<int>();

	// Token: 0x0400A858 RID: 43096
	public bool IsShowLeftTeamPanel;

	// Token: 0x0400A859 RID: 43097
	public bool IsOpenedSeasonUpdate;

	// Token: 0x0400A85A RID: 43098
	public bool IsOpenedViewByWorld;

	// Token: 0x0400A85B RID: 43099
	[Nullable(2)]
	private static ShipTowerModel _Instance;
}
