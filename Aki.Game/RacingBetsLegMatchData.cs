using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;

// Token: 0x02001BC9 RID: 7113
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsLegMatchData
{
	// Token: 0x17001AB2 RID: 6834
	// (get) Token: 0x06011B4F RID: 72527 RVA: 0x00537E7C File Offset: 0x0053607C
	public int Id
	{
		get
		{
			return this.IdInternal;
		}
	}

	// Token: 0x17001AB3 RID: 6835
	// (get) Token: 0x06011B50 RID: 72528 RVA: 0x00537E84 File Offset: 0x00536084
	public string Name
	{
		get
		{
			return this.LegMatchConfig.Name;
		}
	}

	// Token: 0x17001AB4 RID: 6836
	// (get) Token: 0x06011B51 RID: 72529 RVA: 0x00537E91 File Offset: 0x00536091
	public string ShortName
	{
		get
		{
			return this.LegMatchConfig.ShortName;
		}
	}

	// Token: 0x17001AB5 RID: 6837
	// (get) Token: 0x06011B52 RID: 72530 RVA: 0x00537E9E File Offset: 0x0053609E
	public string SimpleName
	{
		get
		{
			return this.LegMatchConfig.SimpleName;
		}
	}

	// Token: 0x17001AB6 RID: 6838
	// (get) Token: 0x06011B53 RID: 72531 RVA: 0x00537EAB File Offset: 0x005360AB
	public int Type
	{
		get
		{
			return this.LegMatchConfig.Type;
		}
	}

	// Token: 0x17001AB7 RID: 6839
	// (get) Token: 0x06011B54 RID: 72532 RVA: 0x00537EB8 File Offset: 0x005360B8
	public ERacingBetsGroupMatchType GroupMatchType
	{
		get
		{
			return this.ParentMatchData.MatchType;
		}
	}

	// Token: 0x17001AB8 RID: 6840
	// (get) Token: 0x06011B55 RID: 72533 RVA: 0x00537EC5 File Offset: 0x005360C5
	public RacingBetsGroupMatchData ParentGroupMatchData
	{
		get
		{
			return this.ParentMatchData;
		}
	}

	// Token: 0x17001AB9 RID: 6841
	// (get) Token: 0x06011B56 RID: 72534 RVA: 0x00537ECD File Offset: 0x005360CD
	public double BetsStartTime
	{
		get
		{
			return this.BetsStartTimeInternal;
		}
	}

	// Token: 0x17001ABA RID: 6842
	// (get) Token: 0x06011B57 RID: 72535 RVA: 0x00537ED5 File Offset: 0x005360D5
	public double BetsEndTime
	{
		get
		{
			return this.BetsEndTimeInternal;
		}
	}

	// Token: 0x17001ABB RID: 6843
	// (get) Token: 0x06011B58 RID: 72536 RVA: 0x00537EDD File Offset: 0x005360DD
	public double MatchStartTime
	{
		get
		{
			return this.MatchStartTimeInternal;
		}
	}

	// Token: 0x17001ABC RID: 6844
	// (get) Token: 0x06011B59 RID: 72537 RVA: 0x00537EE5 File Offset: 0x005360E5
	public double MatchEndTime
	{
		get
		{
			return this.MatchEndTimeInternal;
		}
	}

	// Token: 0x17001ABD RID: 6845
	// (get) Token: 0x06011B5A RID: 72538 RVA: 0x00537EED File Offset: 0x005360ED
	public bool HasBetting
	{
		get
		{
			return this.HasBettingInternal;
		}
	}

	// Token: 0x17001ABE RID: 6846
	// (get) Token: 0x06011B5B RID: 72539 RVA: 0x00537EF5 File Offset: 0x005360F5
	public int BetDangoId
	{
		get
		{
			return this.BetDangoIdInternal;
		}
	}

	// Token: 0x17001ABF RID: 6847
	// (get) Token: 0x06011B5C RID: 72540 RVA: 0x00537EFD File Offset: 0x005360FD
	public string MatchBtnBgPath
	{
		get
		{
			return this.LegMatchConfig.BtnBgPath;
		}
	}

	// Token: 0x06011B5D RID: 72541 RVA: 0x00537F0C File Offset: 0x0053610C
	public int GetBetDangoRank()
	{
		if (this.DangoRank.Count < 0)
		{
			return 0;
		}
		int result = 0;
		for (int i = 0; i < this.DangoRank.Count; i++)
		{
			if (this.BetDangoId == this.DangoRank[i])
			{
				result = i + 1;
				break;
			}
		}
		return result;
	}

	// Token: 0x17001AC0 RID: 6848
	// (get) Token: 0x06011B5E RID: 72542 RVA: 0x00537F5C File Offset: 0x0053615C
	public int BetGearId
	{
		get
		{
			return this.BetGearIdInternal;
		}
	}

	// Token: 0x17001AC1 RID: 6849
	// (get) Token: 0x06011B5F RID: 72543 RVA: 0x00537F64 File Offset: 0x00536164
	public int BetGearCash
	{
		get
		{
			return this.BetGearCashInternal;
		}
	}

	// Token: 0x17001AC2 RID: 6850
	// (get) Token: 0x06011B60 RID: 72544 RVA: 0x00537F6C File Offset: 0x0053616C
	public double NextOddsRateRefreshTime
	{
		get
		{
			return this.NextOddsRateRefreshTimeInternal;
		}
	}

	// Token: 0x17001AC3 RID: 6851
	// (get) Token: 0x06011B61 RID: 72545 RVA: 0x00537F74 File Offset: 0x00536174
	public bool IsFinalOddsRefresh
	{
		get
		{
			return this.IsFinalOddsRefreshInternal;
		}
	}

	// Token: 0x17001AC4 RID: 6852
	// (get) Token: 0x06011B62 RID: 72546 RVA: 0x00537F7C File Offset: 0x0053617C
	public int Odds
	{
		get
		{
			return this.OddsInternal;
		}
	}

	// Token: 0x17001AC5 RID: 6853
	// (get) Token: 0x06011B63 RID: 72547 RVA: 0x00537F84 File Offset: 0x00536184
	public string OddsVersion
	{
		get
		{
			return this.OddsVersionInternal;
		}
	}

	// Token: 0x17001AC6 RID: 6854
	// (get) Token: 0x06011B64 RID: 72548 RVA: 0x00537F8C File Offset: 0x0053618C
	public int LeaveCancelNum
	{
		get
		{
			return this.LeaveCancelNumInternal;
		}
	}

	// Token: 0x17001AC7 RID: 6855
	// (get) Token: 0x06011B65 RID: 72549 RVA: 0x00537F94 File Offset: 0x00536194
	public int OddsReward
	{
		get
		{
			return this.OddsRewardInternal;
		}
	}

	// Token: 0x06011B66 RID: 72550 RVA: 0x00537F9C File Offset: 0x0053619C
	public unsafe void Init(RacingBetsLegMatchesInfo legMatchInfo, RacingBetsGroupMatchData matchData)
	{
		this.IdInternal = legMatchInfo.Id;
		this.LegMatchConfig = RacingBetsConfig.Instance.GetRacingBetsLegMatches(this.IdInternal).Value;
		this.ParentMatchData = matchData;
		this.MatchWholeStartTimeInternal = (double)MathUtils.Instance.LongToBigInt(legMatchInfo.LegMatchWholeTime.BeginTime);
		this.MatchWholeEndTimeInternal = (double)MathUtils.Instance.LongToBigInt(legMatchInfo.LegMatchWholeTime.EndTime);
		this.BetsStartTimeInternal = (double)MathUtils.Instance.LongToBigInt(legMatchInfo.GearStartEndTime.BeginTime);
		this.BetsEndTimeInternal = (double)MathUtils.Instance.LongToBigInt(legMatchInfo.GearStartEndTime.EndTime);
		this.MatchStartTimeInternal = (double)MathUtils.Instance.LongToBigInt(legMatchInfo.MatchStartEndTime.BeginTime);
		this.MatchEndTimeInternal = (double)MathUtils.Instance.LongToBigInt(legMatchInfo.MatchStartEndTime.EndTime);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RacingBets;
		ELogAuthor author = ELogAuthor.LRC;
		string message = "RacingBetsLegMatchData Init";
		<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MatchWholeStartTimeInternal", this.MatchWholeStartTimeInternal);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("MatchWholeEndTimeInternal", this.MatchWholeEndTimeInternal);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("BetsStartTimeInternal", this.BetsStartTimeInternal);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("BetsEndTimeInternal", this.BetsEndTimeInternal);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("MatchStartTimeInternal", this.MatchStartTimeInternal);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("MatchEndTimeInternal", this.MatchEndTimeInternal);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
		this.Refresh(legMatchInfo);
	}

	// Token: 0x06011B67 RID: 72551 RVA: 0x005381A0 File Offset: 0x005363A0
	public unsafe void RefreshBetInfo(RacingBetsGearInfo info)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RacingBets;
		ELogAuthor author = ELogAuthor.BB;
		string message = "RacingBetsLegMatchData刷新下注信息";
		<>y__InlineArray8<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray8<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BetDangoId", info.DangoId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("BetGearId", info.BettingGearId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("BetGearCash", info.BettingGearCash);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("Odds", info.Odds);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("OddsVersion", info.OddsVersion);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("LeaveCancelNum", info.LeaveCancelNum);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("OddsReward", info.OddsReward);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 8));
		this.HasBettingInternal = (info.DangoId > 0);
		this.BetDangoIdInternal = info.DangoId;
		this.BetGearIdInternal = info.BettingGearId;
		this.BetGearCashInternal = info.BettingGearCash;
		this.OddsInternal = info.Odds;
		this.OddsVersionInternal = info.OddsVersion;
		this.LeaveCancelNumInternal = info.LeaveCancelNum;
		this.OddsRewardInternal = info.OddsReward;
	}

	// Token: 0x06011B68 RID: 72552 RVA: 0x00538341 File Offset: 0x00536541
	public void RefreshLegMatchResultNotify(RacingBetLegMatchResultNotify data)
	{
		this.BetDangoIdInternal = data.BetDangoId;
		this.BetGearCashInternal = data.BetCount;
		this.OddsRewardInternal = data.Reward;
	}

	// Token: 0x06011B69 RID: 72553 RVA: 0x00538368 File Offset: 0x00536568
	public void Refresh(RacingBetsLegMatchesInfo legMatchInfo)
	{
		this.DangoRank = new List<int>(legMatchInfo.DangoRank);
		long num = MathUtils.Instance.LongToBigInt(legMatchInfo.NextOddsTime);
		double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		this.IsFinalOddsRefreshInternal = (serverTimeStamp >= (double)num);
		this.NextOddsRateRefreshTimeInternal = (double)num;
		this.OddsVersionInternal = legMatchInfo.OddsVersion;
		this.RefreshDangoActorInfo(new List<RacingBetsDangoInfo>(legMatchInfo.DangoInfo));
	}

	// Token: 0x06011B6A RID: 72554 RVA: 0x005383D8 File Offset: 0x005365D8
	public void RefreshDangoOdds(RacingBetsUpdateOddsResponse info)
	{
		long num = MathUtils.Instance.LongToBigInt(info.NextOddsTime);
		double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		this.IsFinalOddsRefreshInternal = (serverTimeStamp >= (double)num);
		this.NextOddsRateRefreshTimeInternal = (double)num;
		this.OddsVersionInternal = info.OddsVersion;
		this.RefreshDangoActorInfo(new List<RacingBetsDangoInfo>(info.DangoInfo));
	}

	// Token: 0x06011B6B RID: 72555 RVA: 0x00538434 File Offset: 0x00536634
	private void RefreshDangoActorInfo(List<RacingBetsDangoInfo> dangoInfo)
	{
		if (this.DangoActorDataList.Count <= 0 && this.AbuDangoData == null)
		{
			int num = 0;
			using (List<RacingBetsDangoInfo>.Enumerator enumerator = dangoInfo.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					RacingBetsDangoInfo racingBetsDangoInfo = enumerator.Current;
					DangoConfig instance = DangoConfig.Instance;
					Dango? dango = (instance != null) ? instance.GetDangoById(racingBetsDangoInfo.Id) : null;
					if (dango != null && dango.GetValueOrDefault().Type == 1)
					{
						this.AbuDangoData = new RacingBetsDangoActorData
						{
							UiModelUseWay = EUiModelUseWay.OddsDango,
							DangoId = racingBetsDangoInfo.Id,
							Odds = 0,
							DangoPointCase = "DangoCase7",
							DangoCamera = "Camera_DangoFocus_7",
							IsAbuDango = true
						};
						this.AllDangoActorDataList.Add(this.AbuDangoData);
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
						defaultInterpolatedStringHandler.AppendLiteral("DangoCase");
						defaultInterpolatedStringHandler.AppendFormatted<int>(num + 1);
						string dangoPointCase = defaultInterpolatedStringHandler.ToStringAndClear();
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
						defaultInterpolatedStringHandler.AppendLiteral("Camera_DangoFocus_");
						defaultInterpolatedStringHandler.AppendFormatted<int>(num + 1);
						string dangoCamera = defaultInterpolatedStringHandler.ToStringAndClear();
						float dangoOffset = RacingBetsDefine.RacingBetsDangoOddsOffsetList[num];
						RacingBetsDangoActorData item = new RacingBetsDangoActorData
						{
							UiModelUseWay = EUiModelUseWay.OddsDango,
							DangoId = racingBetsDangoInfo.Id,
							Odds = racingBetsDangoInfo.Odds,
							DangoPointCase = dangoPointCase,
							DangoCamera = dangoCamera,
							DangoOffset = dangoOffset,
							IsAbuDango = false
						};
						this.DangoActorDataList.Add(item);
						this.AllDangoActorDataList.Add(item);
						num++;
					}
				}
				return;
			}
		}
		foreach (RacingBetsDangoInfo racingBetsDangoInfo2 in dangoInfo)
		{
			DangoConfig instance2 = DangoConfig.Instance;
			Dango? dango2 = (instance2 != null) ? instance2.GetDangoById(racingBetsDangoInfo2.Id) : null;
			if (dango2 == null || dango2.GetValueOrDefault().Type != 1)
			{
				IRacingBetsDangoActorData dangoActorData = this.GetDangoActorData(racingBetsDangoInfo2.Id);
				if (dangoActorData != null)
				{
					dangoActorData.Odds = racingBetsDangoInfo2.Odds;
				}
			}
		}
	}

	// Token: 0x06011B6C RID: 72556 RVA: 0x005386B0 File Offset: 0x005368B0
	public void RefreshLegMatchResult(MatchResult matchResult)
	{
		this.DangoRank = new List<int>(matchResult.DangoRank);
	}

	// Token: 0x06011B6D RID: 72557 RVA: 0x005386C4 File Offset: 0x005368C4
	public ERacingBetsLegMatchState GetLegMatchState()
	{
		double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		if (serverTimeStamp < this.MatchWholeStartTimeInternal)
		{
			return ERacingBetsLegMatchState.NotOpen;
		}
		if (serverTimeStamp < this.BetsEndTimeInternal)
		{
			return ERacingBetsLegMatchState.BettingPeriod;
		}
		if (serverTimeStamp < this.MatchStartTimeInternal)
		{
			return ERacingBetsLegMatchState.EndOfBetting;
		}
		if (serverTimeStamp < this.MatchEndTimeInternal)
		{
			if (this.DangoRank.Count <= 0)
			{
				return ERacingBetsLegMatchState.MatchPeriod;
			}
			return ERacingBetsLegMatchState.EndOfMatch;
		}
		else
		{
			if (serverTimeStamp >= this.MatchWholeEndTimeInternal)
			{
				return ERacingBetsLegMatchState.End;
			}
			if (this.DangoRank.Count > 0)
			{
				return ERacingBetsLegMatchState.EndOfMatch;
			}
			return ERacingBetsLegMatchState.MatchPeriod;
		}
	}

	// Token: 0x06011B6E RID: 72558 RVA: 0x00538734 File Offset: 0x00536934
	public double GetLegRemindTime()
	{
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		if (racingBetsSeasonData == null)
		{
			return 0.0;
		}
		double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		if (serverTimeStamp < this.BetsStartTimeInternal || this.DangoActorDataList.Count <= 0)
		{
			return TimeUtil.Instance.SetTimeSecond(this.BetsStartTimeInternal - serverTimeStamp);
		}
		if (serverTimeStamp < this.BetsEndTimeInternal)
		{
			return TimeUtil.Instance.SetTimeSecond(this.BetsEndTimeInternal - serverTimeStamp);
		}
		if (serverTimeStamp < this.MatchStartTimeInternal)
		{
			return TimeUtil.Instance.SetTimeSecond(this.MatchStartTimeInternal - serverTimeStamp);
		}
		if (this.DangoRank.Count <= 0 && serverTimeStamp < this.MatchEndTimeInternal)
		{
			return TimeUtil.Instance.SetTimeSecond(this.MatchEndTimeInternal - serverTimeStamp);
		}
		RacingBetsLegMatchData nextLegMatchData = racingBetsSeasonData.GetNextLegMatchData(this.IdInternal);
		if (nextLegMatchData != null)
		{
			return TimeUtil.Instance.SetTimeSecond(nextLegMatchData.BetsStartTimeInternal - serverTimeStamp);
		}
		return 0.0;
	}

	// Token: 0x06011B6F RID: 72559 RVA: 0x0053881C File Offset: 0x00536A1C
	public bool IsLegMatchFinished()
	{
		ERacingBetsLegMatchState legMatchState = this.GetLegMatchState();
		return legMatchState == ERacingBetsLegMatchState.EndOfMatch || legMatchState == ERacingBetsLegMatchState.End;
	}

	// Token: 0x06011B70 RID: 72560 RVA: 0x0053883A File Offset: 0x00536A3A
	private string GetResultShowGroupName(int groupMatchId)
	{
		RacingBetsGroupMatchData racingBetsGroupMatchData = RacingBetsModel.Instance.GetRacingBetsGroupMatchData(groupMatchId);
		return ((racingBetsGroupMatchData != null) ? racingBetsGroupMatchData.ShortName : null) ?? "";
	}

	// Token: 0x06011B71 RID: 72561 RVA: 0x0053885C File Offset: 0x00536A5C
	private bool IsLastLegMatchInGroup()
	{
		List<RacingBetsLegMatchData> legMatchList = this.ParentMatchData.GetLegMatchList();
		return legMatchList.Count > 0 && legMatchList[legMatchList.Count - 1].Id == this.IdInternal;
	}

	// Token: 0x06011B72 RID: 72562 RVA: 0x0053889C File Offset: 0x00536A9C
	public List<IRacingBetsLegMatchResultData> GetLegMatchResultList()
	{
		List<int> promoteDangoList = this.ParentMatchData.GetPromoteDangoList();
		List<IRacingBetsLegMatchResultData> list = new List<IRacingBetsLegMatchResultData>();
		bool flag = RacingBetsModel.Instance.IsFinalLegMatch(this.IdInternal);
		bool flag2 = this.IsLastLegMatchInGroup();
		RacingBetsGroupMatchData parentMatchData = this.ParentMatchData;
		ERacingBetsLegMatchResultType resultShowType = flag2 ? parentMatchData.ResultShowType : ERacingBetsLegMatchResultType.Hidden;
		int advancedNextGroupMatchId = parentMatchData.AdvancedNextGroupMatchId;
		int loserNextGroupMatchId = parentMatchData.LoserNextGroupMatchId;
		for (int i = 0; i < this.DangoRank.Count; i++)
		{
			int num = this.DangoRank[i];
			bool hasAdvanced = promoteDangoList.Contains(num);
			RacingBetsLegMatchResultData item = new RacingBetsLegMatchResultData
			{
				DangoId = num,
				Rank = i + 1,
				HasAdvanced = hasAdvanced,
				LegMatchType = (ERacingBetsLegMatchType)this.Type,
				IsChampion = (flag && i == 0),
				ResultShowType = resultShowType,
				AdvancedNextMatchName = ((advancedNextGroupMatchId > 0) ? this.GetResultShowGroupName(advancedNextGroupMatchId) : ""),
				LoserNextMatchName = ((loserNextGroupMatchId > 0) ? this.GetResultShowGroupName(loserNextGroupMatchId) : "")
			};
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06011B73 RID: 72563 RVA: 0x005389B4 File Offset: 0x00536BB4
	public int GetChampionDangoId()
	{
		if (this.DangoRank.Count <= 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.BB;
			string message = "半场赛没有排名数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LegMatchId", this.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 0;
		}
		return this.DangoRank[0];
	}

	// Token: 0x06011B74 RID: 72564 RVA: 0x00538A14 File Offset: 0x00536C14
	[NullableContext(2)]
	public unsafe IRacingBetsDangoActorData GetDangoActorData(int dangoId)
	{
		foreach (IRacingBetsDangoActorData racingBetsDangoActorData in this.DangoActorDataList)
		{
			if (racingBetsDangoActorData.DangoId == dangoId)
			{
				return racingBetsDangoActorData;
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RacingBets;
		ELogAuthor author = ELogAuthor.BB;
		string message = "RacingBetsLegMatchData Invalid DangoId";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MatchId", this.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DangoId", dangoId);
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return null;
	}

	// Token: 0x06011B75 RID: 72565 RVA: 0x00538AD8 File Offset: 0x00536CD8
	public List<IRacingBetsDangoActorData> GetAllDangoActorDataList()
	{
		return this.AllDangoActorDataList;
	}

	// Token: 0x06011B76 RID: 72566 RVA: 0x00538AE0 File Offset: 0x00536CE0
	public int GetOddsRewardCount()
	{
		return (int)Math.Ceiling((double)(this.BetGearCash * this.Odds) / 100.0);
	}

	// Token: 0x06011B77 RID: 72567 RVA: 0x00538B00 File Offset: 0x00536D00
	public ERacingBetsMainViewShowType GetRacingBetsMainViewActorShowType(ERacingBetsLegMatchState matchState)
	{
		if (RacingBetsModel.Instance.IsFinalLegMatch(this.IdInternal) && (matchState == ERacingBetsLegMatchState.EndOfMatch || matchState == ERacingBetsLegMatchState.End))
		{
			return ERacingBetsMainViewShowType.OneDango;
		}
		if (matchState == ERacingBetsLegMatchState.EndOfMatch)
		{
			return ERacingBetsMainViewShowType.OneDango;
		}
		return ERacingBetsMainViewShowType.SixDango;
	}

	// Token: 0x06011B78 RID: 72568 RVA: 0x00538B25 File Offset: 0x00536D25
	public string GetMainViewCameraHandleName(ERacingBetsMainViewShowType showType)
	{
		if (showType == ERacingBetsMainViewShowType.OneDango)
		{
			return "Camera_DangoFocus_RaceEnd";
		}
		return "Camera_DangoPreview_6Player";
	}

	// Token: 0x06011B79 RID: 72569 RVA: 0x00538B38 File Offset: 0x00536D38
	[NullableContext(2)]
	public IRacingBetsDangoActorData GetChampionDangoActorData()
	{
		if (this.DangoRank.Count <= 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RacingBets;
			ELogAuthor author = ELogAuthor.BB;
			string message = "半场赛没有排名数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LegMatchId", this.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new RacingBetsDangoActorData
		{
			UiModelUseWay = EUiModelUseWay.Dango,
			DangoId = this.DangoRank[0],
			Odds = 0,
			DangoPointCase = "DangoChampionCase",
			DangoCamera = "",
			DangoOffset = 0f
		};
	}

	// Token: 0x06011B7A RID: 72570 RVA: 0x00538BD0 File Offset: 0x00536DD0
	[return: TupleElementNames(new string[]
	{
		"Text",
		"DangoId"
	})]
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<string, int> GetDangoBroadcastText()
	{
		int num;
		if (this.DangoRank.Count > 0)
		{
			num = this.DangoRank[0];
		}
		else
		{
			int index = new Random().Next(this.DangoActorDataList.Count);
			num = this.DangoActorDataList[index].DangoId;
		}
		string item = "";
		DangoBroadcast? racingBetsDangoBroadcast = RacingBetsConfig.Instance.GetRacingBetsDangoBroadcast(num);
		if (racingBetsDangoBroadcast == null)
		{
			return new ValueTuple<string, int>(item, num);
		}
		ERacingBetsGroupMatchType matchType = this.ParentMatchData.MatchType;
		int num2 = new Random().Next(2);
		switch (matchType)
		{
		case ERacingBetsGroupMatchType.GroupStage:
			item = (this.IsLegMatchFinished() ? racingBetsDangoBroadcast.Value.GroupStageChampText : ((num2 == 0) ? racingBetsDangoBroadcast.Value.GroupStageCheerText1 : racingBetsDangoBroadcast.Value.GroupStageCheerText2));
			break;
		case ERacingBetsGroupMatchType.PromotionRound:
			item = (this.IsLegMatchFinished() ? racingBetsDangoBroadcast.Value.AdvanceStageChampText : ((num2 == 0) ? racingBetsDangoBroadcast.Value.AdvanceStageCheerText1 : racingBetsDangoBroadcast.Value.AdvanceStageCheerText2));
			break;
		case ERacingBetsGroupMatchType.Final:
			item = (this.IsLegMatchFinished() ? racingBetsDangoBroadcast.Value.FinalStageChampText : ((num2 == 0) ? racingBetsDangoBroadcast.Value.FinalStageCheerText1 : racingBetsDangoBroadcast.Value.FinalStageCheerText2));
			break;
		case ERacingBetsGroupMatchType.ShowMatch:
			item = (this.IsLegMatchFinished() ? racingBetsDangoBroadcast.Value.ShowMatchChampText : racingBetsDangoBroadcast.Value.ShowMatchText);
			break;
		}
		return new ValueTuple<string, int>(item, num);
	}

	// Token: 0x06011B7B RID: 72571 RVA: 0x00538D80 File Offset: 0x00536F80
	public string GetRandomRuleText()
	{
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		if (racingBetsSeasonData == null)
		{
			return "";
		}
		int id = racingBetsSeasonData.Id;
		IReadOnlyList<RacingBetsRuleTextPool> randomRuleTextPool = RacingBetsConfig.Instance.GetRandomRuleTextPool(id);
		if (randomRuleTextPool == null)
		{
			return "";
		}
		ERacingBetsLegMatchState legMatchState = this.GetLegMatchState();
		int num = (legMatchState == ERacingBetsLegMatchState.NotOpen || legMatchState == ERacingBetsLegMatchState.BettingPeriod || legMatchState == ERacingBetsLegMatchState.EndOfBetting || legMatchState == ERacingBetsLegMatchState.MatchPeriod) ? 0 : 1;
		List<RacingBetsRuleTextPool> list = new List<RacingBetsRuleTextPool>();
		foreach (RacingBetsRuleTextPool item in randomRuleTextPool)
		{
			if (item.LegMatchId == this.IdInternal && item.MatchState == num)
			{
				list.Add(item);
			}
		}
		if (list.Count <= 0)
		{
			return "";
		}
		int index = new Random().Next(list.Count);
		return list[index].RuleText;
	}

	// Token: 0x04009A9F RID: 39583
	private int IdInternal;

	// Token: 0x04009AA0 RID: 39584
	private bool HasBettingInternal;

	// Token: 0x04009AA1 RID: 39585
	private int BetDangoIdInternal;

	// Token: 0x04009AA2 RID: 39586
	private int BetGearIdInternal;

	// Token: 0x04009AA3 RID: 39587
	private int BetGearCashInternal;

	// Token: 0x04009AA4 RID: 39588
	private double NextOddsRateRefreshTimeInternal;

	// Token: 0x04009AA5 RID: 39589
	private bool IsFinalOddsRefreshInternal;

	// Token: 0x04009AA6 RID: 39590
	private int OddsInternal;

	// Token: 0x04009AA7 RID: 39591
	private string OddsVersionInternal = "";

	// Token: 0x04009AA8 RID: 39592
	private int LeaveCancelNumInternal;

	// Token: 0x04009AA9 RID: 39593
	private int OddsRewardInternal;

	// Token: 0x04009AAA RID: 39594
	private double MatchWholeStartTimeInternal;

	// Token: 0x04009AAB RID: 39595
	private double MatchWholeEndTimeInternal;

	// Token: 0x04009AAC RID: 39596
	private double BetsStartTimeInternal;

	// Token: 0x04009AAD RID: 39597
	private double BetsEndTimeInternal;

	// Token: 0x04009AAE RID: 39598
	private double MatchStartTimeInternal;

	// Token: 0x04009AAF RID: 39599
	private double MatchEndTimeInternal;

	// Token: 0x04009AB0 RID: 39600
	private RacingBetsLegMatches LegMatchConfig;

	// Token: 0x04009AB1 RID: 39601
	private List<int> DangoRank = new List<int>();

	// Token: 0x04009AB2 RID: 39602
	private RacingBetsGroupMatchData ParentMatchData;

	// Token: 0x04009AB3 RID: 39603
	private readonly List<IRacingBetsDangoActorData> DangoActorDataList = new List<IRacingBetsDangoActorData>();

	// Token: 0x04009AB4 RID: 39604
	private readonly List<IRacingBetsDangoActorData> AllDangoActorDataList = new List<IRacingBetsDangoActorData>();

	// Token: 0x04009AB5 RID: 39605
	[Nullable(2)]
	private IRacingBetsDangoActorData AbuDangoData;
}
