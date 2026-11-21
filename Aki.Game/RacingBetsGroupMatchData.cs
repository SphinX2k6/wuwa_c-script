using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Module.RacingBets;

// Token: 0x02001BC7 RID: 7111
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsGroupMatchData
{
	// Token: 0x06011B36 RID: 72502 RVA: 0x0053757C File Offset: 0x0053577C
	public void Init(RacingBetsGroupMatchesInfo matchInfo)
	{
		this.Id = matchInfo.GroupMatchId;
		this.MatchConfig = RacingBetsConfig.Instance.GetRacingBetsGroupMatch(this.Id);
		this.MatchTypeInternal = (ERacingBetsGroupMatchType)this.MatchConfig.Value.Type;
		this.InitLegMatchList(new List<RacingBetsLegMatchesInfo>(matchInfo.LegMatchesInfo));
		this.PromoteDangoList = new List<int>(matchInfo.PromoteDangos);
		this.UpdateDangoIdList(new List<int>(matchInfo.Dangos));
	}

	// Token: 0x06011B37 RID: 72503 RVA: 0x005375F7 File Offset: 0x005357F7
	public void Refresh(RacingBetsGroupMatchesInfo matchInfo)
	{
		this.PromoteDangoList = new List<int>(matchInfo.PromoteDangos);
		this.UpdateDangoIdList(new List<int>(matchInfo.Dangos));
	}

	// Token: 0x06011B38 RID: 72504 RVA: 0x0053761C File Offset: 0x0053581C
	private void UpdateDangoIdList(List<int> idList)
	{
		this.InGameDangoIdList = new List<int>();
		foreach (int num in idList)
		{
			DangoConfig instance = DangoConfig.Instance;
			Dango? dango = (instance != null) ? instance.GetDangoById(num) : null;
			if (dango == null || dango.GetValueOrDefault().Type != 1)
			{
				this.InGameDangoIdList.Add(num);
			}
		}
		if (this.PromoteDangoList.Count > 0)
		{
			HashSet<int> hashSet = new HashSet<int>(this.PromoteDangoList);
			this.LossDangoList = new List<int>();
			foreach (int item in this.InGameDangoIdList)
			{
				if (!hashSet.Contains(item))
				{
					this.LossDangoList.Add(item);
				}
			}
		}
	}

	// Token: 0x06011B39 RID: 72505 RVA: 0x00537734 File Offset: 0x00535934
	private void InitLegMatchList(List<RacingBetsLegMatchesInfo> legMatchInfo)
	{
		this.LegMatchList = new List<RacingBetsLegMatchData>();
		foreach (RacingBetsLegMatchesInfo legMatchInfo2 in legMatchInfo)
		{
			RacingBetsLegMatchData racingBetsLegMatchData = new RacingBetsLegMatchData();
			racingBetsLegMatchData.Init(legMatchInfo2, this);
			this.LegMatchList.Add(racingBetsLegMatchData);
		}
	}

	// Token: 0x06011B3A RID: 72506 RVA: 0x005377A0 File Offset: 0x005359A0
	public void RefreshGroupMatchResult(MatchResult matchResult)
	{
		this.PromoteDangoList = new List<int>();
		int num = 0;
		while (num < matchResult.PromoteNum && num < matchResult.DangoRank.Count)
		{
			this.PromoteDangoList.Add(matchResult.DangoRank[num]);
			num++;
		}
	}

	// Token: 0x06011B3B RID: 72507 RVA: 0x005377EE File Offset: 0x005359EE
	public List<RacingBetsLegMatchData> GetLegMatchList()
	{
		return this.LegMatchList;
	}

	// Token: 0x06011B3C RID: 72508 RVA: 0x005377F6 File Offset: 0x005359F6
	public List<int> GetPromoteDangoList()
	{
		return this.PromoteDangoList;
	}

	// Token: 0x06011B3D RID: 72509 RVA: 0x005377FE File Offset: 0x005359FE
	public List<int> GetLossDangoList()
	{
		return this.LossDangoList;
	}

	// Token: 0x17001AAC RID: 6828
	// (get) Token: 0x06011B3E RID: 72510 RVA: 0x00537806 File Offset: 0x00535A06
	public ERacingBetsGroupMatchType MatchType
	{
		get
		{
			return this.MatchTypeInternal;
		}
	}

	// Token: 0x17001AAD RID: 6829
	// (get) Token: 0x06011B3F RID: 72511 RVA: 0x00537810 File Offset: 0x00535A10
	public string Name
	{
		get
		{
			return ((this.MatchConfig != null) ? this.MatchConfig.GetValueOrDefault().Name : null) ?? string.Empty;
		}
	}

	// Token: 0x17001AAE RID: 6830
	// (get) Token: 0x06011B40 RID: 72512 RVA: 0x00537848 File Offset: 0x00535A48
	public string ShortName
	{
		get
		{
			return ((this.MatchConfig != null) ? this.MatchConfig.GetValueOrDefault().ShortName : null) ?? string.Empty;
		}
	}

	// Token: 0x17001AAF RID: 6831
	// (get) Token: 0x06011B41 RID: 72513 RVA: 0x00537880 File Offset: 0x00535A80
	public ERacingBetsLegMatchResultType ResultShowType
	{
		get
		{
			if (this.MatchConfig == null)
			{
				return ERacingBetsLegMatchResultType.Hidden;
			}
			return (ERacingBetsLegMatchResultType)this.MatchConfig.GetValueOrDefault().ResultShowType;
		}
	}

	// Token: 0x17001AB0 RID: 6832
	// (get) Token: 0x06011B42 RID: 72514 RVA: 0x005378AC File Offset: 0x00535AAC
	public int AdvancedNextGroupMatchId
	{
		get
		{
			if (this.MatchConfig == null)
			{
				return 0;
			}
			return this.MatchConfig.GetValueOrDefault().AdvancedGroupId;
		}
	}

	// Token: 0x17001AB1 RID: 6833
	// (get) Token: 0x06011B43 RID: 72515 RVA: 0x005378D8 File Offset: 0x00535AD8
	public int LoserNextGroupMatchId
	{
		get
		{
			if (this.MatchConfig == null)
			{
				return 0;
			}
			return this.MatchConfig.GetValueOrDefault().LoseGroupId;
		}
	}

	// Token: 0x06011B44 RID: 72516 RVA: 0x00537904 File Offset: 0x00535B04
	public bool IsGroupMatchFinished()
	{
		using (List<RacingBetsLegMatchData>.Enumerator enumerator = this.LegMatchList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.IsLegMatchFinished())
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06011B45 RID: 72517 RVA: 0x00537960 File Offset: 0x00535B60
	public List<int> GetInGameDangoList()
	{
		if (this.InGameDangoIdList.Count != 0 || (this.MatchConfig != null && this.MatchConfig.GetValueOrDefault().DangoIsOnlyReadServerData))
		{
			return this.InGameDangoIdList;
		}
		if (this.MatchConfig != null && this.MatchConfig.GetValueOrDefault().DangoList().Length != 0)
		{
			return new List<int>(this.MatchConfig.Value.DangoList());
		}
		if (this.MatchConfig == null || this.MatchConfig.GetValueOrDefault().DangoSourceMatchScheduleId != 0)
		{
			return this.GetMatchDangoListByLastScheduleAdvanced();
		}
		List<int> list = new List<int>();
		foreach (int matchId in this.SourceAdvanceGroupMatchIdList)
		{
			RacingBetsGroupMatchData racingBetsGroupMatchData = RacingBetsModel.Instance.GetRacingBetsGroupMatchData(matchId);
			if (racingBetsGroupMatchData != null)
			{
				list.AddRange(racingBetsGroupMatchData.GetPromoteDangoList());
			}
		}
		foreach (int matchId2 in this.SourceLossGroupMatchIdList)
		{
			RacingBetsGroupMatchData racingBetsGroupMatchData2 = RacingBetsModel.Instance.GetRacingBetsGroupMatchData(matchId2);
			if (racingBetsGroupMatchData2 != null)
			{
				list.AddRange(racingBetsGroupMatchData2.GetLossDangoList());
			}
		}
		return list;
	}

	// Token: 0x06011B46 RID: 72518 RVA: 0x00537ACC File Offset: 0x00535CCC
	public unsafe List<int> GetMatchDangoListByLastScheduleAdvanced()
	{
		if (this.MatchConfig == null)
		{
			return new List<int>();
		}
		RacingBetsMatch? matchTableConfigById = RacingBetsConfig.Instance.GetMatchTableConfigById(this.MatchConfig.Value.DangoSourceMatchScheduleId);
		if (matchTableConfigById == null)
		{
			return new List<int>();
		}
		int num = 0;
		foreach (int num2 in matchTableConfigById.Value.AdvancedDangoIdTargetGroupMatchList())
		{
			if (num2 != this.Id)
			{
				num = num2;
				break;
			}
		}
		if (num == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "Advanced dango destination config error for previous schedule";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("groupMatchId", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("scheduleId", matchTableConfigById.Value.Id);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return new List<int>();
		}
		RacingBetsGroupMatchData racingBetsGroupMatchData = RacingBetsModel.Instance.GetRacingBetsGroupMatchData(num);
		if (racingBetsGroupMatchData == null)
		{
			return new List<int>();
		}
		List<int> inGameDangoList = racingBetsGroupMatchData.GetInGameDangoList();
		if (inGameDangoList.Count == 0)
		{
			return new List<int>();
		}
		List<int> advanceMatchDangoList = RacingBetsModel.Instance.GetAdvanceMatchDangoList((ERacingBetsMatchTableType)this.MatchConfig.Value.DangoSourceMatchScheduleId);
		HashSet<int> hashSet = new HashSet<int>(inGameDangoList);
		List<int> list = new List<int>();
		foreach (int item in advanceMatchDangoList)
		{
			if (!hashSet.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06011B47 RID: 72519 RVA: 0x00537C7C File Offset: 0x00535E7C
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"startTime",
		"endTime"
	})]
	public ValueTuple<long, long> GetTimeRange()
	{
		long num = 0L;
		long num2 = 0L;
		foreach (RacingBetsLegMatchData racingBetsLegMatchData in this.LegMatchList)
		{
			long num3 = (long)racingBetsLegMatchData.MatchStartTime;
			if (num == 0L || num3 < num)
			{
				num = num3;
			}
			if (num2 == 0L || num3 > num2)
			{
				num2 = num3;
			}
		}
		return new ValueTuple<long, long>(num, num2);
	}

	// Token: 0x06011B48 RID: 72520 RVA: 0x00537CF0 File Offset: 0x00535EF0
	public void PushSourceAdvancedGroupMatchId(int groupMatchId)
	{
		this.SourceAdvanceGroupMatchIdList.Add(groupMatchId);
	}

	// Token: 0x06011B49 RID: 72521 RVA: 0x00537CFE File Offset: 0x00535EFE
	public void PushSourceLossGroupMatchId(int groupMatchId)
	{
		this.SourceLossGroupMatchIdList.Add(groupMatchId);
	}

	// Token: 0x04009A94 RID: 39572
	public int Id;

	// Token: 0x04009A95 RID: 39573
	private RacingBetsGroupMatch? MatchConfig;

	// Token: 0x04009A96 RID: 39574
	private List<RacingBetsLegMatchData> LegMatchList = new List<RacingBetsLegMatchData>();

	// Token: 0x04009A97 RID: 39575
	private ERacingBetsGroupMatchType MatchTypeInternal = ERacingBetsGroupMatchType.GroupStage;

	// Token: 0x04009A98 RID: 39576
	private List<int> InGameDangoIdList = new List<int>();

	// Token: 0x04009A99 RID: 39577
	private List<int> PromoteDangoList = new List<int>();

	// Token: 0x04009A9A RID: 39578
	private List<int> LossDangoList = new List<int>();

	// Token: 0x04009A9B RID: 39579
	private readonly List<int> SourceAdvanceGroupMatchIdList = new List<int>();

	// Token: 0x04009A9C RID: 39580
	private readonly List<int> SourceLossGroupMatchIdList = new List<int>();
}
