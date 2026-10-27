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

// Token: 0x02002998 RID: 10648
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ShipTowerModel : ModelBase
{
	// Token: 0x17001D93 RID: 7571
	// (get) Token: 0x0601604D RID: 90189 RVA: 0x0058F273 File Offset: 0x0058D473
	public int CurSeason
	{
		get
		{
			return this.Season;
		}
	}

	// Token: 0x17001D94 RID: 7572
	// (get) Token: 0x0601604E RID: 90190 RVA: 0x0058F27C File Offset: 0x0058D47C
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

	// Token: 0x17001D95 RID: 7573
	// (get) Token: 0x0601604F RID: 90191 RVA: 0x0058F2AB File Offset: 0x0058D4AB
	public long CurSeasonEndTime
	{
		get
		{
			return this.SeasonEndTime;
		}
	}

	// Token: 0x17001D96 RID: 7574
	// (get) Token: 0x06016050 RID: 90192 RVA: 0x0058F2B3 File Offset: 0x0058D4B3
	public bool CurIsHaveRecord
	{
		get
		{
			return this.IsHaveRecord;
		}
	}

	// Token: 0x17001D97 RID: 7575
	// (get) Token: 0x06016051 RID: 90193 RVA: 0x0058F2BB File Offset: 0x0058D4BB
	public IReadOnlyList<ShipTowerStageData> TowerStageDataList
	{
		get
		{
			return this.StageDataList;
		}
	}

	// Token: 0x17001D98 RID: 7576
	// (get) Token: 0x06016052 RID: 90194 RVA: 0x0058F2C3 File Offset: 0x0058D4C3
	public IReadOnlyDictionary<int, ShipTowerStageData> TowerStageDataMap
	{
		get
		{
			return this.StageDataMap;
		}
	}

	// Token: 0x17001D99 RID: 7577
	// (get) Token: 0x06016053 RID: 90195 RVA: 0x0058F2CB File Offset: 0x0058D4CB
	public int GetRewardTotalNum
	{
		get
		{
			return this.RewardTotalNum;
		}
	}

	// Token: 0x17001D9A RID: 7578
	// (get) Token: 0x06016054 RID: 90196 RVA: 0x0058F2D3 File Offset: 0x0058D4D3
	public bool IsRewardAllReceived
	{
		get
		{
			return this.ReceivedAwardScoreIdSet.Count == this.RewardTotalNum;
		}
	}

	// Token: 0x06016055 RID: 90197 RVA: 0x0058F2E8 File Offset: 0x0058D4E8
	protected override bool OnInit()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.ShipTowerView, new Func<EUiViewName, object, bool>(this.CheckCanOpen), "ShipTowerModel.CheckCanOpen");
		return true;
	}

	// Token: 0x06016056 RID: 90198 RVA: 0x0058F30C File Offset: 0x0058D50C
	protected override bool OnClear()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.ShipTowerView, new Func<EUiViewName, object, bool>(this.CheckCanOpen));
		this.StageDataList.Clear();
		this.StageDataMap.Clear();
		this.BuffQualityList.Clear();
		this.BuffQualityMap.Clear();
		return true;
	}

	// Token: 0x06016057 RID: 90199 RVA: 0x0058F361 File Offset: 0x0058D561
	protected override bool OnLeaveLevel()
	{
		return true;
	}

	// Token: 0x06016058 RID: 90200 RVA: 0x0058F364 File Offset: 0x0058D564
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

	// Token: 0x06016059 RID: 90201 RVA: 0x0058F388 File Offset: 0x0058D588
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

	// Token: 0x0601605A RID: 90202 RVA: 0x0058F3E8 File Offset: 0x0058D5E8
	public void AddPlayerGetBuff(int buffId)
	{
		this.PlayerGetBuffSet.Add(buffId);
		LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.ShipTowerGetBuffSet, this.PlayerGetBuffSet);
		EventSystem.Instance.Emit(EEventName.ShipTowerBuffNewUpdate);
	}

	// Token: 0x0601605B RID: 90203 RVA: 0x0058F415 File Offset: 0x0058D615
	private void InitBuffQualityList()
	{
		this.AddBuffQualityListBySeason(0);
	}

	// Token: 0x0601605C RID: 90204 RVA: 0x0058F420 File Offset: 0x0058D620
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

	// Token: 0x0601605D RID: 90205 RVA: 0x0058F508 File Offset: 0x0058D708
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

	// Token: 0x0601605E RID: 90206 RVA: 0x0058F638 File Offset: 0x0058D838
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

	// Token: 0x0601605F RID: 90207 RVA: 0x0058F6C8 File Offset: 0x0058D8C8
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

	// Token: 0x06016060 RID: 90208 RVA: 0x0058F870 File Offset: 0x0058DA70
	public bool IsOldSeason(int season)
	{
		return season != 0 && season != this.CurSeason;
	}

	// Token: 0x06016061 RID: 90209 RVA: 0x0058F884 File Offset: 0x0058DA84
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

	// Token: 0x06016062 RID: 90210 RVA: 0x0058F938 File Offset: 0x0058DB38
	private void UpdateBuffQualityList()
	{
		this.BuffQualityList.Clear();
		this.BuffQualityList.AddRange(this.BuffQualityMap.Values);
		this.BuffQualityList.Sort((ShipTowerBuffQuality a, ShipTowerBuffQuality b) => b.Quality - a.Quality);
	}

	// Token: 0x06016063 RID: 90211 RVA: 0x0058F990 File Offset: 0x0058DB90
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

	// Token: 0x06016064 RID: 90212 RVA: 0x0058F9DC File Offset: 0x0058DBDC
	private bool IsNeedRequestInitData()
	{
		return this.IsOpen() && (this.TowerStageDataList.Count == 0 || !this.TowerStageDataList[0].IsHaveProtoData || this.TimeIsOver() || UiManager.Instance.IsViewOpen(EUiViewName.ShipTowerReviewView));
	}

	// Token: 0x06016065 RID: 90213 RVA: 0x0058FA33 File Offset: 0x0058DC33
	private void InitAreaList()
	{
		this.AreaList.Clear();
		this.AreaList.Add(this.CreateAreaDataById(0, false));
	}

	// Token: 0x06016066 RID: 90214 RVA: 0x0058FA54 File Offset: 0x0058DC54
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

	// Token: 0x06016067 RID: 90215 RVA: 0x0058FAE0 File Offset: 0x0058DCE0
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

	// Token: 0x06016068 RID: 90216 RVA: 0x0058FB40 File Offset: 0x0058DD40
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

	// Token: 0x06016069 RID: 90217 RVA: 0x0058FBD0 File Offset: 0x0058DDD0
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

	// Token: 0x0601606A RID: 90218 RVA: 0x0058FBF0 File Offset: 0x0058DDF0
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

	// Token: 0x0601606B RID: 90219 RVA: 0x0058FC68 File Offset: 0x0058DE68
	public List<ShipTowerBuffQuality> GetBuffQualityList(bool isSortData = false)
	{
		if (isSortData)
		{
			this.BuffQualityListSortData();
		}
		return this.BuffQualityList;
	}

	// Token: 0x0601606C RID: 90220 RVA: 0x0058FC7C File Offset: 0x0058DE7C
	private void BuffQualityListSortData()
	{
		foreach (ShipTowerBuffQuality shipTowerBuffQuality in this.BuffQualityList)
		{
			shipTowerBuffQuality.BuffList.Sort((ShipTowerBuffData a, ShipTowerBuffData b) => a.Id - b.Id);
		}
	}

	// Token: 0x0601606D RID: 90221 RVA: 0x0058FCF0 File Offset: 0x0058DEF0
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

	// Token: 0x0601606E RID: 90222 RVA: 0x0058FD10 File Offset: 0x0058DF10
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

	// Token: 0x0601606F RID: 90223 RVA: 0x0058FDE8 File Offset: 0x0058DFE8
	public int GetRecommendLevelByInstId(int instId)
	{
		return InstanceDungeonConfig.Instance.GetRecommendLevel(instId, WorldLevelModel.Instance.CurWorldLevel);
	}

	// Token: 0x06016070 RID: 90224 RVA: 0x0058FE00 File Offset: 0x0058E000
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

	// Token: 0x06016071 RID: 90225 RVA: 0x0058FE6C File Offset: 0x0058E06C
	public bool IsOtherTeamRoleData(int roleId)
	{
		return this.OtherTeamRoleMap.ContainsKey(roleId);
	}

	// Token: 0x06016072 RID: 90226 RVA: 0x0058FE7C File Offset: 0x0058E07C
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

	// Token: 0x06016073 RID: 90227 RVA: 0x0058FE9C File Offset: 0x0058E09C
	public void AddOtherTeamRoleData(ShipTowerRoleData roleData)
	{
		this.OtherTeamRoleMap[roleData.RoleIdEdit] = roleData;
	}

	// Token: 0x06016074 RID: 90228 RVA: 0x0058FEB0 File Offset: 0x0058E0B0
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

	// Token: 0x06016075 RID: 90229 RVA: 0x0058FED0 File Offset: 0x0058E0D0
	public void AddAllTeamRoleData(ShipTowerRoleData roleData)
	{
		this.AllTeamRoleMap[roleData.RoleIdEdit] = roleData;
	}

	// Token: 0x06016076 RID: 90230 RVA: 0x0058FEE4 File Offset: 0x0058E0E4
	public void ClearAllTeamRoleData()
	{
		this.AllTeamRoleMap.Clear();
	}

	// Token: 0x06016077 RID: 90231 RVA: 0x0058FEF1 File Offset: 0x0058E0F1
	public void ClearOtherTeamRoleData()
	{
		this.OtherTeamRoleMap.Clear();
	}

	// Token: 0x06016078 RID: 90232 RVA: 0x0058FF00 File Offset: 0x0058E100
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

	// Token: 0x06016079 RID: 90233 RVA: 0x0058FF80 File Offset: 0x0058E180
	[NullableContext(2)]
	public void OpenViewMain(ShipTowerViewParams param = null)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerView, param, null);
	}

	// Token: 0x0601607A RID: 90234 RVA: 0x0058FF93 File Offset: 0x0058E193
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

	// Token: 0x0601607B RID: 90235 RVA: 0x0058FFB4 File Offset: 0x0058E1B4
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

	// Token: 0x0601607C RID: 90236 RVA: 0x0058FFF1 File Offset: 0x0058E1F1
	public void OpenViewBuff(ShipTowerBuffViewParams param)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerBuffView, param, new TOpenViewCallBack(this.AddNormalStackChildView));
	}

	// Token: 0x0601607D RID: 90237 RVA: 0x0059000F File Offset: 0x0058E20F
	public void OpenViewCover(ShipTowerCoverViewParams param)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerCoverView, param, new TOpenViewCallBack(this.AddNormalStackChildView));
	}

	// Token: 0x0601607E RID: 90238 RVA: 0x0059002D File Offset: 0x0058E22D
	public void OpenViewReset(ShipTowerResetViewParams param)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerResetView, param, new TOpenViewCallBack(this.AddNormalStackChildView));
	}

	// Token: 0x0601607F RID: 90239 RVA: 0x0059004B File Offset: 0x0058E24B
	[NullableContext(2)]
	public void OpenViewReward(ShipTowerRewardViewParams param = null)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerRewardView, param, new TOpenViewCallBack(this.AddNormalStackChildView));
	}

	// Token: 0x06016080 RID: 90240 RVA: 0x00590069 File Offset: 0x0058E269
	public void OpenViewPassBuffShow(ShipTowerPassBuffShowViewParams param)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerPassBuffShowView, param, new TOpenViewCallBack(this.AddNormalStackChildView));
	}

	// Token: 0x06016081 RID: 90241 RVA: 0x00590087 File Offset: 0x0058E287
	public void OpenViewTeamRecommend(ShipTowerTeamRecommendViewParams param)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerTeamRecommendView, param, new TOpenViewCallBack(this.AddNormalStackChildView));
	}

	// Token: 0x06016082 RID: 90242 RVA: 0x005900A5 File Offset: 0x0058E2A5
	public void OpenViewMonsterDesc(ShipTowerMonsterDescViewParams param)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerMonsterDescView, param, new TOpenViewCallBack(this.AddNormalStackChildView));
	}

	// Token: 0x06016083 RID: 90243 RVA: 0x005900C3 File Offset: 0x0058E2C3
	[NullableContext(2)]
	public void OpenViewRecord(ShipTowerRecordViewParams param = null)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerRecordView, param, new TOpenViewCallBack(this.AddNormalStackChildView));
	}

	// Token: 0x06016084 RID: 90244 RVA: 0x005900E1 File Offset: 0x0058E2E1
	[NullableContext(2)]
	public void OpenViewReview(ShipTowerReviewViewParams param = null)
	{
		UiManager.Instance.OpenView(EUiViewName.ShipTowerReviewView, param, new TOpenViewCallBack(this.AddNormalStackChildView));
	}

	// Token: 0x06016085 RID: 90245 RVA: 0x00590100 File Offset: 0x0058E300
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

	// Token: 0x06016086 RID: 90246 RVA: 0x00590199 File Offset: 0x0058E399
	public void UpdateSeasonNotify(SlashAndTowerOverNotify notify)
	{
		this.OpenConfirmSeasonUpdate(null);
	}

	// Token: 0x06016087 RID: 90247 RVA: 0x005901A4 File Offset: 0x0058E3A4
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

	// Token: 0x06016088 RID: 90248 RVA: 0x00590360 File Offset: 0x0058E560
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

	// Token: 0x06016089 RID: 90249 RVA: 0x005905A0 File Offset: 0x0058E7A0
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

	// Token: 0x0601608A RID: 90250 RVA: 0x0059063C File Offset: 0x0058E83C
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

	// Token: 0x0601608B RID: 90251 RVA: 0x0059088C File Offset: 0x0058EA8C
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

	// Token: 0x0601608C RID: 90252 RVA: 0x00590930 File Offset: 0x0058EB30
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

	// Token: 0x0601608D RID: 90253 RVA: 0x0059099C File Offset: 0x0058EB9C
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

	// Token: 0x0601608E RID: 90254 RVA: 0x00590A50 File Offset: 0x0058EC50
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

	// Token: 0x0601608F RID: 90255 RVA: 0x00590AC8 File Offset: 0x0058ECC8
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

	// Token: 0x06016090 RID: 90256 RVA: 0x00590B38 File Offset: 0x0058ED38
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

	// Token: 0x06016091 RID: 90257 RVA: 0x00590B74 File Offset: 0x0058ED74
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

	// Token: 0x06016092 RID: 90258 RVA: 0x00590C88 File Offset: 0x0058EE88
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

	// Token: 0x06016093 RID: 90259 RVA: 0x00590D58 File Offset: 0x0058EF58
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

	// Token: 0x06016094 RID: 90260 RVA: 0x00590DA9 File Offset: 0x0058EFA9
	public bool IsOpen()
	{
		return FunctionModel.Instance.IsOpen(10081);
	}

	// Token: 0x06016095 RID: 90261 RVA: 0x00590DBC File Offset: 0x0058EFBC
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

	// Token: 0x06016096 RID: 90262 RVA: 0x00590E44 File Offset: 0x0058F044
	private void SetChallengeBuffIdList(List<int> buffIdList)
	{
		this.ChallengeBuffIdList.Clear();
		this.ChallengeBuffIdList.AddRange(buffIdList);
	}

	// Token: 0x06016097 RID: 90263 RVA: 0x00590E60 File Offset: 0x0058F060
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

	// Token: 0x06016098 RID: 90264 RVA: 0x00590EDC File Offset: 0x0058F0DC
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

	// Token: 0x06016099 RID: 90265 RVA: 0x00590F30 File Offset: 0x0058F130
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

	// Token: 0x0601609A RID: 90266 RVA: 0x00590FB0 File Offset: 0x0058F1B0
	public void ClearChallengeStageData()
	{
		if (this.ChallengeStageData == null)
		{
			return;
		}
		this.ChallengeStageData.UpdateToEdit();
		this.SetChallengeStageDataNull();
	}

	// Token: 0x0601609B RID: 90267 RVA: 0x00590FCC File Offset: 0x0058F1CC
	public void SetChallengeStageDataNull()
	{
		this.ChallengeStageData = null;
	}

	// Token: 0x0601609C RID: 90268 RVA: 0x00590FD8 File Offset: 0x0058F1D8
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

	// Token: 0x0601609D RID: 90269 RVA: 0x0059101C File Offset: 0x0058F21C
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

	// Token: 0x0601609E RID: 90270 RVA: 0x005910E0 File Offset: 0x0058F2E0
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

	// Token: 0x0601609F RID: 90271 RVA: 0x0059111C File Offset: 0x0058F31C
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

	// Token: 0x060160A0 RID: 90272 RVA: 0x00591158 File Offset: 0x0058F358
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

	// Token: 0x060160A1 RID: 90273 RVA: 0x005911B4 File Offset: 0x0058F3B4
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

	// Token: 0x060160A2 RID: 90274 RVA: 0x005911E4 File Offset: 0x0058F3E4
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

	// Token: 0x060160A3 RID: 90275 RVA: 0x00591214 File Offset: 0x0058F414
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

	// Token: 0x060160A4 RID: 90276 RVA: 0x00591270 File Offset: 0x0058F470
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

	// Token: 0x060160A5 RID: 90277 RVA: 0x005912B8 File Offset: 0x0058F4B8
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

	// Token: 0x060160A6 RID: 90278 RVA: 0x00591300 File Offset: 0x0058F500
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

	// Token: 0x060160A7 RID: 90279 RVA: 0x005914B8 File Offset: 0x0058F6B8
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

	// Token: 0x060160A8 RID: 90280 RVA: 0x005914F8 File Offset: 0x0058F6F8
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

	// Token: 0x060160A9 RID: 90281 RVA: 0x0059153B File Offset: 0x0058F73B
	public void ClearGetBuffIdList()
	{
		this.GetBuffIdList.Clear();
	}

	// Token: 0x060160AA RID: 90282 RVA: 0x00591548 File Offset: 0x0058F748
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

	// Token: 0x060160AB RID: 90283 RVA: 0x00591610 File Offset: 0x0058F810
	public UniTask OpenWelcomeView()
	{
		ShipTowerModel.<OpenWelcomeView>d__136 <OpenWelcomeView>d__;
		<OpenWelcomeView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenWelcomeView>d__.<>4__this = this;
		<OpenWelcomeView>d__.<>1__state = -1;
		<OpenWelcomeView>d__.<>t__builder.Start<ShipTowerModel.<OpenWelcomeView>d__136>(ref <OpenWelcomeView>d__);
		return <OpenWelcomeView>d__.<>t__builder.Task;
	}

	// Token: 0x060160AC RID: 90284 RVA: 0x00591653 File Offset: 0x0058F853
	public void CloseWelcomeView()
	{
		UiManager.Instance.CloseView(EUiViewName.ShipTowerWelcomeView, null);
	}

	// Token: 0x060160AD RID: 90285 RVA: 0x00591665 File Offset: 0x0058F865
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

	// Token: 0x060160AE RID: 90286 RVA: 0x00591679 File Offset: 0x0058F879
	private bool IsShowConfirmSeasonUpdate()
	{
		return this.IsNeedShowSeasonReview || this.TimeIsOver();
	}

	// Token: 0x060160AF RID: 90287 RVA: 0x00591690 File Offset: 0x0058F890
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

	// Token: 0x060160B0 RID: 90288 RVA: 0x00591700 File Offset: 0x0058F900
	public void OpenConfirmBackWorld()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ShipTowerFromViewLeaveInst);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			this.LeaveBattle();
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060160B1 RID: 90289 RVA: 0x0059173C File Offset: 0x0058F93C
	private void ConfirmSeasonUpdateCallback()
	{
		if (this.LeaveBattle())
		{
			return;
		}
		this.CloseMainView();
	}

	// Token: 0x060160B2 RID: 90290 RVA: 0x0059174D File Offset: 0x0058F94D
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

	// Token: 0x060160B3 RID: 90291 RVA: 0x00591784 File Offset: 0x0058F984
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

	// Token: 0x060160B4 RID: 90292 RVA: 0x00591818 File Offset: 0x0058FA18
	public void CloseMainView()
	{
		UiManager.Instance.CloseView(EUiViewName.ShipTowerView, null);
	}

	// Token: 0x060160B5 RID: 90293 RVA: 0x0059182A File Offset: 0x0058FA2A
	public double GetRemainTime()
	{
		if (this.CurSeasonEndTime <= 0L)
		{
			return 0.0;
		}
		return (double)this.CurSeasonEndTime - TimeUtil.Instance.GetServerTime();
	}

	// Token: 0x060160B6 RID: 90294 RVA: 0x00591852 File Offset: 0x0058FA52
	public bool TimeIsOver()
	{
		return this.GetRemainTime() <= 0.0;
	}

	// Token: 0x060160B7 RID: 90295 RVA: 0x00591868 File Offset: 0x0058FA68
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

	// Token: 0x060160B8 RID: 90296 RVA: 0x005918B8 File Offset: 0x0058FAB8
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

	// Token: 0x060160B9 RID: 90297 RVA: 0x0059190B File Offset: 0x0058FB0B
	public bool IsCanReceiveAward()
	{
		return this.RewardCanReceiveNum > 0;
	}

	// Token: 0x060160BA RID: 90298 RVA: 0x00591916 File Offset: 0x0058FB16
	public bool IsEndlessRecordOpen()
	{
		return this.CurIsHaveRecord;
	}

	// Token: 0x060160BB RID: 90299 RVA: 0x0059191E File Offset: 0x0058FB1E
	public bool IsCanUseRole(int roleId)
	{
		return RoleModel.Instance.GetRoleInstanceById(roleId) != null;
	}

	// Token: 0x060160BC RID: 90300 RVA: 0x00591930 File Offset: 0x0058FB30
	public UniTask RequestRecord()
	{
		ShipTowerModel.<RequestRecord>d__153 <RequestRecord>d__;
		<RequestRecord>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRecord>d__.<>1__state = -1;
		<RequestRecord>d__.<>t__builder.Start<ShipTowerModel.<RequestRecord>d__153>(ref <RequestRecord>d__);
		return <RequestRecord>d__.<>t__builder.Task;
	}

	// Token: 0x060160BD RID: 90301 RVA: 0x0059196C File Offset: 0x0058FB6C
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

	// Token: 0x060160BE RID: 90302 RVA: 0x005919F0 File Offset: 0x0058FBF0
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

	// Token: 0x060160BF RID: 90303 RVA: 0x00591B10 File Offset: 0x0058FD10
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

	// Token: 0x060160C0 RID: 90304 RVA: 0x00591B64 File Offset: 0x0058FD64
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

	// Token: 0x060160C1 RID: 90305 RVA: 0x00591BB0 File Offset: 0x0058FDB0
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

	// Token: 0x060160C2 RID: 90306 RVA: 0x00591C08 File Offset: 0x0058FE08
	public bool IsPassZeroSeason()
	{
		if (!this.IsOpen())
		{
			return false;
		}
		ShipTowerStageData currentStage = this.GetCurrentStage();
		return currentStage == null || currentStage.BelongToSeason != 0;
	}

	// Token: 0x060160C3 RID: 90307 RVA: 0x00591C28 File Offset: 0x0058FE28
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

	// Token: 0x060160C4 RID: 90308 RVA: 0x00591C77 File Offset: 0x0058FE77
	public void UpdateToEdit()
	{
		this.StageDataList.ForEach(delegate(ShipTowerStageData stageData)
		{
			stageData.UpdateToEdit();
		});
	}

	// Token: 0x060160C5 RID: 90309 RVA: 0x00591CA4 File Offset: 0x0058FEA4
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

	// Token: 0x060160C6 RID: 90310 RVA: 0x00591D18 File Offset: 0x0058FF18
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

	// Token: 0x060160C7 RID: 90311 RVA: 0x00591DD0 File Offset: 0x0058FFD0
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

	// Token: 0x060160C8 RID: 90312 RVA: 0x00591F5C File Offset: 0x0059015C
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

	// Token: 0x060160C9 RID: 90313 RVA: 0x00591FA0 File Offset: 0x005901A0
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

	// Token: 0x060160CA RID: 90314 RVA: 0x0059223C File Offset: 0x0059043C
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

	// Token: 0x060160CB RID: 90315 RVA: 0x005922C8 File Offset: 0x005904C8
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

	// Token: 0x060160CC RID: 90316 RVA: 0x005923E8 File Offset: 0x005905E8
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

	// Token: 0x060160CD RID: 90317 RVA: 0x005924D4 File Offset: 0x005906D4
	public bool CheckIsScoreBattle()
	{
		if (this.CurSeasonCfg == null || !this.CurSeasonCfg.Value.IsOpenHot)
		{
			return false;
		}
		ShipTowerStageData challengeStageData = this.ChallengeStageData;
		return challengeStageData != null && challengeStageData.StageType > EShipTowerStageType.OneTimeStage;
	}

	// Token: 0x060160CE RID: 90318 RVA: 0x00592520 File Offset: 0x00590720
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

	// Token: 0x060160CF RID: 90319 RVA: 0x00592534 File Offset: 0x00590734
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

	// Token: 0x17001D9B RID: 7579
	// (get) Token: 0x060160D0 RID: 90320 RVA: 0x005926D4 File Offset: 0x005908D4
	public static ShipTowerModel Instance
	{
		get
		{
			return ShipTowerModel._Instance;
		}
	}

	// Token: 0x060160D1 RID: 90321 RVA: 0x005926DB File Offset: 0x005908DB
	public static ShipTowerModel GetOrCreateInstance()
	{
		if (ShipTowerModel._Instance == null)
		{
			ShipTowerModel.CreateInstance();
		}
		return ShipTowerModel._Instance;
	}

	// Token: 0x060160D2 RID: 90322 RVA: 0x005926EF File Offset: 0x005908EF
	public static bool CreateInstance()
	{
		if (ShipTowerModel._Instance != null)
		{
			return true;
		}
		ShipTowerModel._Instance = new ShipTowerModel();
		return true;
	}

	// Token: 0x060160D3 RID: 90323 RVA: 0x00592705 File Offset: 0x00590905
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060160D4 RID: 90324 RVA: 0x00592707 File Offset: 0x00590907
	public static void ResetStaticDefaultValue()
	{
		ShipTowerModel._Instance = null;
	}

	// Token: 0x060160D5 RID: 90325 RVA: 0x0059270F File Offset: 0x0059090F
	static ShipTowerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ShipTowerModel.CreateStaticDefaultValue), new Action(ShipTowerModel.ResetStaticDefaultValue));
	}

	// Token: 0x060160D7 RID: 90327 RVA: 0x00592800 File Offset: 0x00590A00
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

	// Token: 0x060160D8 RID: 90328 RVA: 0x005928A0 File Offset: 0x00590AA0
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

	// Token: 0x0400A44F RID: 42063
	private bool IsInitData;

	// Token: 0x0400A450 RID: 42064
	private readonly List<ShipTowerStageData> StageDataList = new List<ShipTowerStageData>();

	// Token: 0x0400A451 RID: 42065
	private readonly Dictionary<int, ShipTowerStageData> StageDataMap = new Dictionary<int, ShipTowerStageData>();

	// Token: 0x0400A452 RID: 42066
	public bool DebugParallaxSub;

	// Token: 0x0400A453 RID: 42067
	private readonly List<ShipTowerBuffQuality> BuffQualityList = new List<ShipTowerBuffQuality>();

	// Token: 0x0400A454 RID: 42068
	private readonly Dictionary<int, ShipTowerBuffQuality> BuffQualityMap = new Dictionary<int, ShipTowerBuffQuality>();

	// Token: 0x0400A455 RID: 42069
	private readonly Dictionary<int, ShipTowerBuffData> BuffDataMap = new Dictionary<int, ShipTowerBuffData>();

	// Token: 0x0400A456 RID: 42070
	private readonly List<ShipTowerTeamTab> TeamTabList = new List<ShipTowerTeamTab>();

	// Token: 0x0400A457 RID: 42071
	private readonly Dictionary<int, ShipTowerRoleData> OtherTeamRoleMap = new Dictionary<int, ShipTowerRoleData>();

	// Token: 0x0400A458 RID: 42072
	private readonly Dictionary<int, ShipTowerRoleData> AllTeamRoleMap = new Dictionary<int, ShipTowerRoleData>();

	// Token: 0x0400A459 RID: 42073
	private int Season;

	// Token: 0x0400A45A RID: 42074
	private long SeasonEndTime;

	// Token: 0x0400A45B RID: 42075
	private bool IsHaveRecord;

	// Token: 0x0400A45C RID: 42076
	private bool IsNeedShowSeasonReview;

	// Token: 0x0400A45D RID: 42077
	private readonly List<ShipTowerAreaItemData> AreaList = new List<ShipTowerAreaItemData>();

	// Token: 0x0400A45E RID: 42078
	private readonly HashSet<int> ReceivedAwardScoreIdSet = new HashSet<int>();

	// Token: 0x0400A45F RID: 42079
	private int ReceivingAwardId;

	// Token: 0x0400A460 RID: 42080
	public List<ShipTowerAreaItemData> RecordList = new List<ShipTowerAreaItemData>();

	// Token: 0x0400A461 RID: 42081
	private int RewardCanReceiveNum;

	// Token: 0x0400A462 RID: 42082
	private int RewardTotalNum;

	// Token: 0x0400A463 RID: 42083
	[Nullable(2)]
	public ShipTowerStageData ChallengeStageData;

	// Token: 0x0400A464 RID: 42084
	public readonly List<int> ChallengeBuffIdList = new List<int>();

	// Token: 0x0400A465 RID: 42085
	public readonly List<ShipTowerReviewItemData> ReviewList = new List<ShipTowerReviewItemData>();

	// Token: 0x0400A466 RID: 42086
	public readonly List<int> ReviewProgressList = new List<int>();

	// Token: 0x0400A467 RID: 42087
	private readonly List<int> GetBuffIdList = new List<int>();

	// Token: 0x0400A468 RID: 42088
	public readonly List<int> ShowBuffIdList = new List<int>();

	// Token: 0x0400A469 RID: 42089
	[Nullable(2)]
	private CustomPromise<bool> WelcomeViewPromise;

	// Token: 0x0400A46A RID: 42090
	[Nullable(2)]
	private CustomPromise<bool> SeasonReviewViewPromise;

	// Token: 0x0400A46B RID: 42091
	[Nullable(2)]
	private CustomPromise<bool> GetBuffViewPromise;

	// Token: 0x0400A46C RID: 42092
	[Nullable(2)]
	public ShipTowerBuffData CurSelectBuffData;

	// Token: 0x0400A46D RID: 42093
	public readonly HashSet<int> PlayerGetBuffSet = new HashSet<int>();

	// Token: 0x0400A46E RID: 42094
	public bool IsShowLeftTeamPanel;

	// Token: 0x0400A46F RID: 42095
	public bool IsOpenedSeasonUpdate;

	// Token: 0x0400A470 RID: 42096
	public bool IsOpenedViewByWorld;

	// Token: 0x0400A471 RID: 42097
	[Nullable(2)]
	private static ShipTowerModel _Instance;
}
