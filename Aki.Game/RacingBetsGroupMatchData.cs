using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Module.RacingBets;

// Token: 0x020026DC RID: 9948
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsGroupMatchData
{
	// Token: 0x06014654 RID: 83540 RVA: 0x00528844 File Offset: 0x00526A44
	public void Init(RacingBetsGroupMatchesInfo matchInfo)
	{
		this.Id = matchInfo.GroupMatchId;
		this.MatchConfig = RacingBetsConfig.Instance.GetRacingBetsGroupMatch(this.Id);
		this.MatchTypeInternal = (ERacingBetsGroupMatchType)this.MatchConfig.Value.Type;
		this.InitLegMatchList(new List<RacingBetsLegMatchesInfo>(matchInfo.LegMatchesInfo));
		this.PromoteDangoList = new List<int>(matchInfo.PromoteDangos);
		this.UpdateDangoIdList(new List<int>(matchInfo.Dangos));
	}

	// Token: 0x06014655 RID: 83541 RVA: 0x005288BF File Offset: 0x00526ABF
	public void Refresh(RacingBetsGroupMatchesInfo matchInfo)
	{
		this.PromoteDangoList = new List<int>(matchInfo.PromoteDangos);
		this.UpdateDangoIdList(new List<int>(matchInfo.Dangos));
	}

	// Token: 0x06014656 RID: 83542 RVA: 0x005288E4 File Offset: 0x00526AE4
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

	// Token: 0x06014657 RID: 83543 RVA: 0x005289FC File Offset: 0x00526BFC
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

	// Token: 0x06014658 RID: 83544 RVA: 0x00528A68 File Offset: 0x00526C68
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

	// Token: 0x06014659 RID: 83545 RVA: 0x00528AB6 File Offset: 0x00526CB6
	public List<RacingBetsLegMatchData> GetLegMatchList()
	{
		return this.LegMatchList;
	}

	// Token: 0x0601465A RID: 83546 RVA: 0x00528ABE File Offset: 0x00526CBE
	public List<int> GetPromoteDangoList()
	{
		return this.PromoteDangoList;
	}

	// Token: 0x0601465B RID: 83547 RVA: 0x00528AC6 File Offset: 0x00526CC6
	public List<int> GetLossDangoList()
	{
		return this.LossDangoList;
	}

	// Token: 0x17001A74 RID: 6772
	// (get) Token: 0x0601465C RID: 83548 RVA: 0x00528ACE File Offset: 0x00526CCE
	public ERacingBetsGroupMatchType MatchType
	{
		get
		{
			return this.MatchTypeInternal;
		}
	}

	// Token: 0x17001A75 RID: 6773
	// (get) Token: 0x0601465D RID: 83549 RVA: 0x00528AD8 File Offset: 0x00526CD8
	public string Name
	{
		get
		{
			return ((this.MatchConfig != null) ? this.MatchConfig.GetValueOrDefault().Name : null) ?? string.Empty;
		}
	}

	// Token: 0x17001A76 RID: 6774
	// (get) Token: 0x0601465E RID: 83550 RVA: 0x00528B10 File Offset: 0x00526D10
	public string ShortName
	{
		get
		{
			return ((this.MatchConfig != null) ? this.MatchConfig.GetValueOrDefault().ShortName : null) ?? string.Empty;
		}
	}

	// Token: 0x17001A77 RID: 6775
	// (get) Token: 0x0601465F RID: 83551 RVA: 0x00528B48 File Offset: 0x00526D48
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

	// Token: 0x17001A78 RID: 6776
	// (get) Token: 0x06014660 RID: 83552 RVA: 0x00528B74 File Offset: 0x00526D74
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

	// Token: 0x17001A79 RID: 6777
	// (get) Token: 0x06014661 RID: 83553 RVA: 0x00528BA0 File Offset: 0x00526DA0
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

	// Token: 0x06014662 RID: 83554 RVA: 0x00528BCC File Offset: 0x00526DCC
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

	// Token: 0x06014663 RID: 83555 RVA: 0x00528C28 File Offset: 0x00526E28
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

	// Token: 0x06014664 RID: 83556 RVA: 0x00528D94 File Offset: 0x00526F94
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

	// Token: 0x06014665 RID: 83557 RVA: 0x00528F44 File Offset: 0x00527144
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

	// Token: 0x06014666 RID: 83558 RVA: 0x00528FB8 File Offset: 0x005271B8
	public void PushSourceAdvancedGroupMatchId(int groupMatchId)
	{
		this.SourceAdvanceGroupMatchIdList.Add(groupMatchId);
	}

	// Token: 0x06014667 RID: 83559 RVA: 0x00528FC6 File Offset: 0x005271C6
	public void PushSourceLossGroupMatchId(int groupMatchId)
	{
		this.SourceLossGroupMatchIdList.Add(groupMatchId);
	}

	// Token: 0x0400993C RID: 39228
	public int Id;

	// Token: 0x0400993D RID: 39229
	private RacingBetsGroupMatch? MatchConfig;

	// Token: 0x0400993E RID: 39230
	private List<RacingBetsLegMatchData> LegMatchList = new List<RacingBetsLegMatchData>();

	// Token: 0x0400993F RID: 39231
	private ERacingBetsGroupMatchType MatchTypeInternal = ERacingBetsGroupMatchType.GroupStage;

	// Token: 0x04009940 RID: 39232
	private List<int> InGameDangoIdList = new List<int>();

	// Token: 0x04009941 RID: 39233
	private List<int> PromoteDangoList = new List<int>();

	// Token: 0x04009942 RID: 39234
	private List<int> LossDangoList = new List<int>();

	// Token: 0x04009943 RID: 39235
	private readonly List<int> SourceAdvanceGroupMatchIdList = new List<int>();

	// Token: 0x04009944 RID: 39236
	private readonly List<int> SourceLossGroupMatchIdList = new List<int>();
}
