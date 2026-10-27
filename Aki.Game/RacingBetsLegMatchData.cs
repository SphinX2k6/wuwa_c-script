using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;

// Token: 0x020026DE RID: 9950
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsLegMatchData
{
	// Token: 0x17001A7A RID: 6778
	// (get) Token: 0x0601466D RID: 83565 RVA: 0x00529144 File Offset: 0x00527344
	public int Id
	{
		get
		{
			return this.IdInternal;
		}
	}

	// Token: 0x17001A7B RID: 6779
	// (get) Token: 0x0601466E RID: 83566 RVA: 0x0052914C File Offset: 0x0052734C
	public string Name
	{
		get
		{
			return this.LegMatchConfig.Name;
		}
	}

	// Token: 0x17001A7C RID: 6780
	// (get) Token: 0x0601466F RID: 83567 RVA: 0x00529159 File Offset: 0x00527359
	public string ShortName
	{
		get
		{
			return this.LegMatchConfig.ShortName;
		}
	}

	// Token: 0x17001A7D RID: 6781
	// (get) Token: 0x06014670 RID: 83568 RVA: 0x00529166 File Offset: 0x00527366
	public string SimpleName
	{
		get
		{
			return this.LegMatchConfig.SimpleName;
		}
	}

	// Token: 0x17001A7E RID: 6782
	// (get) Token: 0x06014671 RID: 83569 RVA: 0x00529173 File Offset: 0x00527373
	public int Type
	{
		get
		{
			return this.LegMatchConfig.Type;
		}
	}

	// Token: 0x17001A7F RID: 6783
	// (get) Token: 0x06014672 RID: 83570 RVA: 0x00529180 File Offset: 0x00527380
	public ERacingBetsGroupMatchType GroupMatchType
	{
		get
		{
			return this.ParentMatchData.MatchType;
		}
	}

	// Token: 0x17001A80 RID: 6784
	// (get) Token: 0x06014673 RID: 83571 RVA: 0x0052918D File Offset: 0x0052738D
	public RacingBetsGroupMatchData ParentGroupMatchData
	{
		get
		{
			return this.ParentMatchData;
		}
	}

	// Token: 0x17001A81 RID: 6785
	// (get) Token: 0x06014674 RID: 83572 RVA: 0x00529195 File Offset: 0x00527395
	public double BetsStartTime
	{
		get
		{
			return this.BetsStartTimeInternal;
		}
	}

	// Token: 0x17001A82 RID: 6786
	// (get) Token: 0x06014675 RID: 83573 RVA: 0x0052919D File Offset: 0x0052739D
	public double BetsEndTime
	{
		get
		{
			return this.BetsEndTimeInternal;
		}
	}

	// Token: 0x17001A83 RID: 6787
	// (get) Token: 0x06014676 RID: 83574 RVA: 0x005291A5 File Offset: 0x005273A5
	public double MatchStartTime
	{
		get
		{
			return this.MatchStartTimeInternal;
		}
	}

	// Token: 0x17001A84 RID: 6788
	// (get) Token: 0x06014677 RID: 83575 RVA: 0x005291AD File Offset: 0x005273AD
	public double MatchEndTime
	{
		get
		{
			return this.MatchEndTimeInternal;
		}
	}

	// Token: 0x17001A85 RID: 6789
	// (get) Token: 0x06014678 RID: 83576 RVA: 0x005291B5 File Offset: 0x005273B5
	public bool HasBetting
	{
		get
		{
			return this.HasBettingInternal;
		}
	}

	// Token: 0x17001A86 RID: 6790
	// (get) Token: 0x06014679 RID: 83577 RVA: 0x005291BD File Offset: 0x005273BD
	public int BetDangoId
	{
		get
		{
			return this.BetDangoIdInternal;
		}
	}

	// Token: 0x17001A87 RID: 6791
	// (get) Token: 0x0601467A RID: 83578 RVA: 0x005291C5 File Offset: 0x005273C5
	public string MatchBtnBgPath
	{
		get
		{
			return this.LegMatchConfig.BtnBgPath;
		}
	}

	// Token: 0x0601467B RID: 83579 RVA: 0x005291D4 File Offset: 0x005273D4
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

	// Token: 0x17001A88 RID: 6792
	// (get) Token: 0x0601467C RID: 83580 RVA: 0x00529224 File Offset: 0x00527424
	public int BetGearId
	{
		get
		{
			return this.BetGearIdInternal;
		}
	}

	// Token: 0x17001A89 RID: 6793
	// (get) Token: 0x0601467D RID: 83581 RVA: 0x0052922C File Offset: 0x0052742C
	public int BetGearCash
	{
		get
		{
			return this.BetGearCashInternal;
		}
	}

	// Token: 0x17001A8A RID: 6794
	// (get) Token: 0x0601467E RID: 83582 RVA: 0x00529234 File Offset: 0x00527434
	public double NextOddsRateRefreshTime
	{
		get
		{
			return this.NextOddsRateRefreshTimeInternal;
		}
	}

	// Token: 0x17001A8B RID: 6795
	// (get) Token: 0x0601467F RID: 83583 RVA: 0x0052923C File Offset: 0x0052743C
	public bool IsFinalOddsRefresh
	{
		get
		{
			return this.IsFinalOddsRefreshInternal;
		}
	}

	// Token: 0x17001A8C RID: 6796
	// (get) Token: 0x06014680 RID: 83584 RVA: 0x00529244 File Offset: 0x00527444
	public int Odds
	{
		get
		{
			return this.OddsInternal;
		}
	}

	// Token: 0x17001A8D RID: 6797
	// (get) Token: 0x06014681 RID: 83585 RVA: 0x0052924C File Offset: 0x0052744C
	public string OddsVersion
	{
		get
		{
			return this.OddsVersionInternal;
		}
	}

	// Token: 0x17001A8E RID: 6798
	// (get) Token: 0x06014682 RID: 83586 RVA: 0x00529254 File Offset: 0x00527454
	public int LeaveCancelNum
	{
		get
		{
			return this.LeaveCancelNumInternal;
		}
	}

	// Token: 0x17001A8F RID: 6799
	// (get) Token: 0x06014683 RID: 83587 RVA: 0x0052925C File Offset: 0x0052745C
	public int OddsReward
	{
		get
		{
			return this.OddsRewardInternal;
		}
	}

	// Token: 0x06014684 RID: 83588 RVA: 0x00529264 File Offset: 0x00527464
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

	// Token: 0x06014685 RID: 83589 RVA: 0x00529468 File Offset: 0x00527668
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

	// Token: 0x06014686 RID: 83590 RVA: 0x00529609 File Offset: 0x00527809
	public void RefreshLegMatchResultNotify(RacingBetLegMatchResultNotify data)
	{
		this.BetDangoIdInternal = data.BetDangoId;
		this.BetGearCashInternal = data.BetCount;
		this.OddsRewardInternal = data.Reward;
	}

	// Token: 0x06014687 RID: 83591 RVA: 0x00529630 File Offset: 0x00527830
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

	// Token: 0x06014688 RID: 83592 RVA: 0x005296A0 File Offset: 0x005278A0
	public void RefreshDangoOdds(RacingBetsUpdateOddsResponse info)
	{
		long num = MathUtils.Instance.LongToBigInt(info.NextOddsTime);
		double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		this.IsFinalOddsRefreshInternal = (serverTimeStamp >= (double)num);
		this.NextOddsRateRefreshTimeInternal = (double)num;
		this.OddsVersionInternal = info.OddsVersion;
		this.RefreshDangoActorInfo(new List<RacingBetsDangoInfo>(info.DangoInfo));
	}

	// Token: 0x06014689 RID: 83593 RVA: 0x005296FC File Offset: 0x005278FC
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

	// Token: 0x0601468A RID: 83594 RVA: 0x00529978 File Offset: 0x00527B78
	public void RefreshLegMatchResult(MatchResult matchResult)
	{
		this.DangoRank = new List<int>(matchResult.DangoRank);
	}

	// Token: 0x0601468B RID: 83595 RVA: 0x0052998C File Offset: 0x00527B8C
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

	// Token: 0x0601468C RID: 83596 RVA: 0x005299FC File Offset: 0x00527BFC
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

	// Token: 0x0601468D RID: 83597 RVA: 0x00529AE4 File Offset: 0x00527CE4
	public bool IsLegMatchFinished()
	{
		ERacingBetsLegMatchState legMatchState = this.GetLegMatchState();
		return legMatchState == ERacingBetsLegMatchState.EndOfMatch || legMatchState == ERacingBetsLegMatchState.End;
	}

	// Token: 0x0601468E RID: 83598 RVA: 0x00529B02 File Offset: 0x00527D02
	private string GetResultShowGroupName(int groupMatchId)
	{
		RacingBetsGroupMatchData racingBetsGroupMatchData = RacingBetsModel.Instance.GetRacingBetsGroupMatchData(groupMatchId);
		return ((racingBetsGroupMatchData != null) ? racingBetsGroupMatchData.ShortName : null) ?? "";
	}

	// Token: 0x0601468F RID: 83599 RVA: 0x00529B24 File Offset: 0x00527D24
	private bool IsLastLegMatchInGroup()
	{
		List<RacingBetsLegMatchData> legMatchList = this.ParentMatchData.GetLegMatchList();
		RacingBetsLegMatchData racingBetsLegMatchData = legMatchList.ElementAtOrDefault(legMatchList.Count - 1);
		int? num = (racingBetsLegMatchData != null) ? new int?(racingBetsLegMatchData.Id) : null;
		int idInternal = this.IdInternal;
		return num.GetValueOrDefault() == idInternal & num != null;
	}

	// Token: 0x06014690 RID: 83600 RVA: 0x00529B80 File Offset: 0x00527D80
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

	// Token: 0x06014691 RID: 83601 RVA: 0x00529C98 File Offset: 0x00527E98
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

	// Token: 0x06014692 RID: 83602 RVA: 0x00529CF8 File Offset: 0x00527EF8
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

	// Token: 0x06014693 RID: 83603 RVA: 0x00529DBC File Offset: 0x00527FBC
	public List<IRacingBetsDangoActorData> GetAllDangoActorDataList()
	{
		return this.AllDangoActorDataList;
	}

	// Token: 0x06014694 RID: 83604 RVA: 0x00529DC4 File Offset: 0x00527FC4
	public int GetOddsRewardCount()
	{
		return (int)Math.Ceiling((double)(this.BetGearCash * this.Odds) / 100.0);
	}

	// Token: 0x06014695 RID: 83605 RVA: 0x00529DE4 File Offset: 0x00527FE4
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

	// Token: 0x06014696 RID: 83606 RVA: 0x00529E09 File Offset: 0x00528009
	public string GetMainViewCameraHandleName(ERacingBetsMainViewShowType showType)
	{
		if (showType == ERacingBetsMainViewShowType.OneDango)
		{
			return "Camera_DangoFocus_RaceEnd";
		}
		return "Camera_DangoPreview_6Player";
	}

	// Token: 0x06014697 RID: 83607 RVA: 0x00529E1C File Offset: 0x0052801C
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

	// Token: 0x06014698 RID: 83608 RVA: 0x00529EB4 File Offset: 0x005280B4
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

	// Token: 0x06014699 RID: 83609 RVA: 0x0052A064 File Offset: 0x00528264
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

	// Token: 0x04009947 RID: 39239
	private int IdInternal;

	// Token: 0x04009948 RID: 39240
	private bool HasBettingInternal;

	// Token: 0x04009949 RID: 39241
	private int BetDangoIdInternal;

	// Token: 0x0400994A RID: 39242
	private int BetGearIdInternal;

	// Token: 0x0400994B RID: 39243
	private int BetGearCashInternal;

	// Token: 0x0400994C RID: 39244
	private double NextOddsRateRefreshTimeInternal;

	// Token: 0x0400994D RID: 39245
	private bool IsFinalOddsRefreshInternal;

	// Token: 0x0400994E RID: 39246
	private int OddsInternal;

	// Token: 0x0400994F RID: 39247
	private string OddsVersionInternal = "";

	// Token: 0x04009950 RID: 39248
	private int LeaveCancelNumInternal;

	// Token: 0x04009951 RID: 39249
	private int OddsRewardInternal;

	// Token: 0x04009952 RID: 39250
	private double MatchWholeStartTimeInternal;

	// Token: 0x04009953 RID: 39251
	private double MatchWholeEndTimeInternal;

	// Token: 0x04009954 RID: 39252
	private double BetsStartTimeInternal;

	// Token: 0x04009955 RID: 39253
	private double BetsEndTimeInternal;

	// Token: 0x04009956 RID: 39254
	private double MatchStartTimeInternal;

	// Token: 0x04009957 RID: 39255
	private double MatchEndTimeInternal;

	// Token: 0x04009958 RID: 39256
	private RacingBetsLegMatches LegMatchConfig;

	// Token: 0x04009959 RID: 39257
	private List<int> DangoRank = new List<int>();

	// Token: 0x0400995A RID: 39258
	private RacingBetsGroupMatchData ParentMatchData;

	// Token: 0x0400995B RID: 39259
	private readonly List<IRacingBetsDangoActorData> DangoActorDataList = new List<IRacingBetsDangoActorData>();

	// Token: 0x0400995C RID: 39260
	private readonly List<IRacingBetsDangoActorData> AllDangoActorDataList = new List<IRacingBetsDangoActorData>();

	// Token: 0x0400995D RID: 39261
	[Nullable(2)]
	private IRacingBetsDangoActorData AbuDangoData;
}
