using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002735 RID: 10037
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsMainView : UiTickViewBase, IUiCameraBehavior
{
	// Token: 0x0601494B RID: 84299 RVA: 0x005341AC File Offset: 0x005323AC
	public RacingBetsMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601494C RID: 84300 RVA: 0x005341FC File Offset: 0x005323FC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 37;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(34, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(35, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(36, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickRaycastButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickCloseButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(32, new Action(this.OnClickMatchResultDetailButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(34, new Action(this.OnClickViewPreviousResultButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601494D RID: 84301 RVA: 0x005347B0 File Offset: 0x005329B0
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsMainView.<OnBeforeStartAsync>d__34 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsMainView.<OnBeforeStartAsync>d__34>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601494E RID: 84302 RVA: 0x005347F4 File Offset: 0x005329F4
	protected override UniTask OnBeforeShowAsyncImplementImplement()
	{
		RacingBetsMainView.<OnBeforeShowAsyncImplementImplement>d__35 <OnBeforeShowAsyncImplementImplement>d__;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<RacingBetsMainView.<OnBeforeShowAsyncImplementImplement>d__35>(ref <OnBeforeShowAsyncImplementImplement>d__);
		return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x0601494F RID: 84303 RVA: 0x00534838 File Offset: 0x00532A38
	private void ApplyMainViewDisplayRule()
	{
		int curLegMatchDataIndex = this.SeasonData.GetCurLegMatchDataIndex();
		RacingBetsLegMatchData legMatchDataByIndex = this.SeasonData.GetLegMatchDataByIndex(curLegMatchDataIndex);
		int id = this.SeasonData.Id;
		RacingBetsLegMatchData endOfMatchLegMatchData = this.SeasonData.GetEndOfMatchLegMatchData();
		RacingBetsLegMatchData racingBetsLegMatchData = (legMatchDataByIndex.GetLegMatchState() == ERacingBetsLegMatchState.BettingPeriod) ? legMatchDataByIndex : null;
		if (endOfMatchLegMatchData != null && racingBetsLegMatchData != null && endOfMatchLegMatchData.Id != racingBetsLegMatchData.Id)
		{
			if (!RacingBetsModel.Instance.HasEnteredBettingMainView(id, endOfMatchLegMatchData.Id))
			{
				this.ShowLegMatchData = endOfMatchLegMatchData;
				this.ActualLegMatchData = racingBetsLegMatchData;
				this.IsViewingPreviousResult = true;
				return;
			}
			bool flag;
			if (this.IsViewingPreviousResult)
			{
				RacingBetsLegMatchData showLegMatchData = this.ShowLegMatchData;
				int? num = (showLegMatchData != null) ? new int?(showLegMatchData.Id) : null;
				int id2 = endOfMatchLegMatchData.Id;
				flag = (num.GetValueOrDefault() == id2 & num != null);
			}
			else
			{
				flag = false;
			}
			if (flag)
			{
				this.ShowLegMatchData = endOfMatchLegMatchData;
				this.ActualLegMatchData = racingBetsLegMatchData;
				this.IsViewingPreviousResult = true;
				return;
			}
			this.ShowLegMatchData = racingBetsLegMatchData;
			this.ActualLegMatchData = racingBetsLegMatchData;
			this.IsViewingPreviousResult = false;
			return;
		}
		else
		{
			if (endOfMatchLegMatchData == null)
			{
				this.ShowLegMatchData = legMatchDataByIndex;
				this.ActualLegMatchData = legMatchDataByIndex;
				this.IsViewingPreviousResult = false;
				return;
			}
			RacingBetsLegMatchData nextLegMatchData = this.SeasonData.GetNextLegMatchData(endOfMatchLegMatchData.Id);
			if (nextLegMatchData == null || nextLegMatchData.GetLegMatchState() != ERacingBetsLegMatchState.BettingPeriod)
			{
				this.ShowLegMatchData = endOfMatchLegMatchData;
				this.ActualLegMatchData = (nextLegMatchData ?? legMatchDataByIndex);
				this.IsViewingPreviousResult = false;
				return;
			}
			this.ShowLegMatchData = legMatchDataByIndex;
			this.ActualLegMatchData = legMatchDataByIndex;
			this.IsViewingPreviousResult = false;
			return;
		}
	}

	// Token: 0x06014950 RID: 84304 RVA: 0x005349B8 File Offset: 0x00532BB8
	private UniTask InitComponent()
	{
		RacingBetsMainView.<InitComponent>d__37 <InitComponent>d__;
		<InitComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitComponent>d__.<>4__this = this;
		<InitComponent>d__.<>1__state = -1;
		<InitComponent>d__.<>t__builder.Start<RacingBetsMainView.<InitComponent>d__37>(ref <InitComponent>d__);
		return <InitComponent>d__.<>t__builder.Task;
	}

	// Token: 0x06014951 RID: 84305 RVA: 0x005349FC File Offset: 0x00532BFC
	private void InitButtonItem()
	{
		this.ActivityInternalRewardButton.BindRedDot(ERedDotName.RedDotRacingBetsActivityInternalReward, 0);
		this.ActivityRewardButton.BindRedDot(ERedDotName.RedDotRacingBetsActivityReward, 0);
		this.HistoryButton.SetRedDotVisible(false);
		this.ReplayButton.SetFunction(new Action(this.OnClickReplayButton));
		this.ReplayChampionButton.SetFunction(new Action(this.OnClickReplayButton));
		this.BetButton.SetFunction(new Action(this.OnClickBetButton));
		this.RankButton.SetFunction(new Action(this.OnClickRankButton));
		this.HistoryButton.SetFunction(new Action(this.OnClickBettingHistoryButton));
		this.ScheduleButton.SetFunction(new Action(this.OnClickScheduleButton));
		this.ActivityInternalRewardButton.SetFunction(new Action(this.OnClickActivityInternalRewardButton));
		this.ActivityRewardButton.SetFunction(new Action(this.OnClickActivityRewardButton));
		this.ToBetButton.SetFunction(new Action(this.OnClickToBetButton));
	}

	// Token: 0x06014952 RID: 84306 RVA: 0x00534B06 File Offset: 0x00532D06
	private RacingBetsLegMatchResultItem ResultItemProxyCreate()
	{
		return new RacingBetsLegMatchResultItem();
	}

	// Token: 0x06014953 RID: 84307 RVA: 0x00534B0D File Offset: 0x00532D0D
	public void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend)
	{
		UiCameraAnimationController.Instance.PushCameraHandle((EUiViewName)"Camera_DangoPreview_Start", new int?(viewId), isBlend);
	}

	// Token: 0x06014954 RID: 84308 RVA: 0x00534B2C File Offset: 0x00532D2C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnRacingBetsCloseLoading));
		EventSystem.Instance.Add(EEventName.OnRacingBetsDangoOddsUpdate, new Action(this.OnRacingBetsDangoOddsUpdate));
		EventSystem.Instance.Add<RacingBetsSeasonData>(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.OnRacingBetsDataRefresh));
		EventSystem.Instance.Add(EEventName.OnRacingBetsRedDotUpdate, new Action(this.OnRacingBetsRedDotUpdate));
		EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
	}

	// Token: 0x06014955 RID: 84309 RVA: 0x00534BC5 File Offset: 0x00532DC5
	protected override void OnBeforeShow()
	{
		if (RacingBetsModel.Instance.IsFinalLegMatch(this.ShowLegMatchData.Id) && this.CurMatchState == ERacingBetsLegMatchState.EndOfMatch)
		{
			base.PlaySequence("Champion", null, false);
		}
		this.RefreshUi();
	}

	// Token: 0x06014956 RID: 84310 RVA: 0x00534BFC File Offset: 0x00532DFC
	protected override void OnAfterShow()
	{
		this.RefreshDangoOddsInfo();
		EventSystem.Instance.Emit(EEventName.OnRacingBetsViewAfterShow);
		if (RacingBetsController.Instance.TryOpenRacingBetsLegMatchResultView())
		{
			return;
		}
		if (this.IsFirstShow)
		{
			return;
		}
		RacingBetsController.Instance.TryStartRacingBetsGaming(this.ShowLegMatchData.Id);
		if (this.ActorShowType == ERacingBetsMainViewShowType.SixDango)
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RacingBetsMainSixDango");
			return;
		}
		EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RacingBetsMainOneDango");
	}

	// Token: 0x06014957 RID: 84311 RVA: 0x00534C80 File Offset: 0x00532E80
	private void RefreshUi()
	{
		this.FirstLegMatchItem.RefreshUi(this.ShowLegMatchData);
		this.SecondLegMatchItem.RefreshUi(this.NextLegMatchData);
		this.BroadcastItem.Init(this.ShowLegMatchData);
		this.RefreshCurrencyItem(this.SeasonData);
		this.RefreshResultPanel(this.ShowLegMatchData);
		this.RefreshBetPanel(this.ShowLegMatchData);
		this.RefreshTimePanel(this.ShowLegMatchData);
		this.RefreshAudio(this.ShowLegMatchData);
		this.RefreshButtonShowState(this.ShowLegMatchData);
		this.RefreshButtonRedDot();
	}

	// Token: 0x06014958 RID: 84312 RVA: 0x00534D10 File Offset: 0x00532F10
	private void RefreshCurrencyItem(RacingBetsSeasonData seasonData)
	{
		this.CommonCurrencyItem.RefreshTemp(seasonData.GetCurrencyItemId(), seasonData.GetCurrencyCount().ToString());
		this.CommonCurrencyItem.SetButtonActive(false);
	}

	// Token: 0x06014959 RID: 84313 RVA: 0x00534D48 File Offset: 0x00532F48
	private void RefreshResultPanel(RacingBetsLegMatchData legMatchData)
	{
		bool flag = RacingBetsModel.Instance.IsFinalLegMatch(legMatchData.Id);
		bool flag2 = legMatchData.IsLegMatchFinished();
		base.GetItem(27).SetUIActive(!flag && flag2);
		base.GetItem(28).SetUIActive(flag && flag2);
		base.GetItem(30).SetUIActive(flag && flag2);
		base.GetItem(12).SetUIActive(flag2);
		if (flag2)
		{
			if (flag)
			{
				this.RefreshFinalResultPanel(legMatchData);
				return;
			}
			this.RefreshNormalResultPanel(legMatchData);
		}
	}

	// Token: 0x0601495A RID: 84314 RVA: 0x00534DC4 File Offset: 0x00532FC4
	private void RefreshNormalResultPanel(RacingBetsLegMatchData legMatchData)
	{
		List<IRacingBetsLegMatchResultData> legMatchResultList = legMatchData.GetLegMatchResultList();
		base.GetText(14).ShowTextNew(legMatchData.Name);
		this.MatchResultLayout.RefreshByData(legMatchResultList, null, false);
		this.ReplayChampionButton.SetActive(false);
		this.ReplayButton.SetActive(true);
	}

	// Token: 0x0601495B RID: 84315 RVA: 0x00534E14 File Offset: 0x00533014
	private void RefreshFinalResultPanel(RacingBetsLegMatchData legMatchData)
	{
		this.ChampionRewardItem.Refresh(this.SeasonData.GetSeasonConfig().EndReward);
		int championDangoId = legMatchData.GetChampionDangoId();
		DangoData dangoData = DangoManager.Instance.GetDangoData(championDangoId);
		base.GetText(31).ShowTextNew(dangoData.NameKey);
		this.ReplayChampionButton.SetActive(true);
		this.ReplayButton.SetActive(false);
	}

	// Token: 0x0601495C RID: 84316 RVA: 0x00534E80 File Offset: 0x00533080
	private void RefreshBetPanel(RacingBetsLegMatchData legMatchData)
	{
		ERacingBetsLegMatchState curMatchState = this.CurMatchState;
		if (curMatchState != ERacingBetsLegMatchState.BettingPeriod && curMatchState != ERacingBetsLegMatchState.EndOfBetting && curMatchState != ERacingBetsLegMatchState.MatchPeriod)
		{
			base.GetItem(19).SetUIActive(false);
			return;
		}
		base.GetItem(19).SetUIActive(true);
		if (!legMatchData.HasBetting)
		{
			base.GetItem(20).SetUIActive(false);
			base.GetItem(25).SetUIActive(true);
			return;
		}
		base.GetItem(20).SetUIActive(true);
		base.GetItem(25).SetUIActive(false);
		UUIText text = base.GetText(24);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("×");
		defaultInterpolatedStringHandler.AppendFormatted<int>(legMatchData.Odds / 100);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		int currencyItemId = this.SeasonData.GetCurrencyItemId();
		this.BetsCostItem.RefreshUi(currencyItemId, legMatchData.BetGearCash);
		this.BetRewardItem.RefreshUi(currencyItemId, legMatchData.GetOddsRewardCount());
	}

	// Token: 0x0601495D RID: 84317 RVA: 0x00534F68 File Offset: 0x00533168
	private void RefreshTimePanel(RacingBetsLegMatchData legMatchData)
	{
		ERacingBetsLegMatchState legMatchState = legMatchData.GetLegMatchState();
		UUIText text = base.GetText(3);
		double num = 0.0;
		if (legMatchState == ERacingBetsLegMatchState.EndOfMatch)
		{
			RacingBetsLegMatchData nextLegMatchData = this.NextLegMatchData;
			if (nextLegMatchData != null)
			{
				num = nextLegMatchData.GetLegRemindTime();
			}
		}
		else if (legMatchState != ERacingBetsLegMatchState.MatchPeriod)
		{
			num = legMatchData.GetLegRemindTime();
		}
		if (legMatchState == ERacingBetsLegMatchState.NotOpen)
		{
			text.ShowTextNew("Dango_MainPage_StatusTime_Bet");
		}
		else if (legMatchState == ERacingBetsLegMatchState.BettingPeriod)
		{
			text.ShowTextNew("Dango_MainPage_StatusTime_Bet");
		}
		else if (legMatchState == ERacingBetsLegMatchState.EndOfBetting)
		{
			text.ShowTextNew("Dango_MainPage_StatusTime_Wait");
		}
		else if (legMatchState == ERacingBetsLegMatchState.MatchPeriod)
		{
			text.ShowTextNew("Dango_MainPage_StatusTime_Race");
		}
		else if (legMatchState == ERacingBetsLegMatchState.EndOfMatch || legMatchState == ERacingBetsLegMatchState.End)
		{
			if (RacingBetsModel.Instance.IsFinalLegMatch(legMatchData.Id))
			{
				text.ShowTextNew("Dango_MainPage_StatusTime_FinalRaceEnd");
			}
			else
			{
				text.ShowTextNew("Dango_MainPage_StatusTime_Settle");
			}
		}
		if (num > 0.0)
		{
			UUIText text2 = base.GetText(4);
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(num);
			text2.SetText(((remainTimeDataFormat != null) ? remainTimeDataFormat.CountDownText : null) ?? "", true);
			text2.SetUIActive(true);
			return;
		}
		base.GetText(4).SetUIActive(false);
	}

	// Token: 0x0601495E RID: 84318 RVA: 0x00535078 File Offset: 0x00533278
	private void RefreshAudio(RacingBetsLegMatchData legMatchData)
	{
		if (this.CurMatchState == ERacingBetsLegMatchState.EndOfMatch)
		{
			AudioSystem.Instance.SetState("dungeon_2_3_race_music", ERacingBetsAudioState.RaceFinals.ToString(), true);
			return;
		}
		AudioSystem.Instance.SetState("dungeon_2_3_race_music", ERacingBetsAudioState.None.ToString(), true);
	}

	// Token: 0x0601495F RID: 84319 RVA: 0x005350D0 File Offset: 0x005332D0
	private void RefreshButtonShowState(RacingBetsLegMatchData legMatchData)
	{
		bool flag = this.CurMatchState == ERacingBetsLegMatchState.BettingPeriod;
		RacingBetsLegMatchData endOfMatchLegMatchData = this.SeasonData.GetEndOfMatchLegMatchData();
		if (this.IsViewingPreviousResult)
		{
			bool active = endOfMatchLegMatchData != null && endOfMatchLegMatchData.Id == this.ShowLegMatchData.Id;
			base.GetButton(34).RootUIComp.Get().SetUIActive(false);
			this.ToBetButton.SetActive(active);
		}
		else
		{
			bool uiactive = flag && endOfMatchLegMatchData != null;
			base.GetButton(34).RootUIComp.Get().SetUIActive(uiactive);
			this.ToBetButton.SetActive(false);
		}
		base.GetButton(0).SetSelfInteractive(flag && !this.IsViewingPreviousResult);
		ERacingBetsLegMatchState legMatchState = this.SeasonData.GetCurLegMatchData().GetLegMatchState();
		base.GetButton(32).RootUIComp.Get().SetUIActive(legMatchState != ERacingBetsLegMatchState.End && legMatchState != ERacingBetsLegMatchState.EndOfMatch && !this.IsViewingPreviousResult);
		this.BetButton.SetActive(legMatchState != ERacingBetsLegMatchState.End && legMatchState != ERacingBetsLegMatchState.EndOfMatch && !this.IsViewingPreviousResult);
	}

	// Token: 0x06014960 RID: 84320 RVA: 0x005351F0 File Offset: 0x005333F0
	private void RefreshButtonRedDot()
	{
		if (this.ShowLegMatchData == null)
		{
			return;
		}
		ERacingBetsLegMatchState legMatchState = this.ShowLegMatchData.GetLegMatchState();
		RacingBetsRedDotState player = LocalStorage.GetPlayer<RacingBetsRedDotState>(ELocalStoragePlayerKey.RacingBetsMatchViewRecord, null);
		this.ScheduleButton.SetRedDotVisible(player != null && !player.HasViewed);
		RacingBetsRedDotState player2 = LocalStorage.GetPlayer<RacingBetsRedDotState>(ELocalStoragePlayerKey.RacingBetsRankViewRecord, null);
		bool flag = this.SeasonData.CheckRankOpen();
		this.RankButton.SetRedDotVisible(player2 != null && !player2.HasViewed && flag);
		int player3 = LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.RacingBetsReplayGameRecord, 0);
		bool redDotVisible = legMatchState == ERacingBetsLegMatchState.EndOfMatch && this.ShowLegMatchData.Id > player3;
		this.ReplayButton.SetRedDotVisible(redDotVisible);
		this.ReplayChampionButton.SetRedDotVisible(redDotVisible);
		bool redDotVisible2 = false;
		int betDangoId = this.ShowLegMatchData.BetDangoId;
		if (legMatchState == ERacingBetsLegMatchState.BettingPeriod)
		{
			redDotVisible2 = (betDangoId == 0);
		}
		else if (legMatchState == ERacingBetsLegMatchState.MatchPeriod)
		{
			int player4 = LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.RacingBetsWatchGameRecord, 0);
			redDotVisible2 = (this.ShowLegMatchData.Id > player4);
		}
		this.BetButton.SetRedDotVisible(redDotVisible2);
		bool redDotVisible3 = this.IsViewingPreviousResult && this.ActualLegMatchData != null && this.ActualLegMatchData.GetLegMatchState() == ERacingBetsLegMatchState.BettingPeriod && this.ActualLegMatchData.BetDangoId == 0;
		this.ToBetButton.SetRedDotVisible(redDotVisible3);
	}

	// Token: 0x06014961 RID: 84321 RVA: 0x00535338 File Offset: 0x00533538
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnRacingBetsCloseLoading));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDangoOddsUpdate, new Action(this.OnRacingBetsDangoOddsUpdate));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.OnRacingBetsDataRefresh));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsRedDotUpdate, new Action(this.OnRacingBetsRedDotUpdate));
		EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
	}

	// Token: 0x06014962 RID: 84322 RVA: 0x005353D1 File Offset: 0x005335D1
	[NullableContext(2)]
	public void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete)
	{
		UiCameraAnimationController.Instance.PopCameraHandle((EUiViewName)"Camera_DangoPreview_Start", stackTopInfo, closeViewId, popOrDelete);
	}

	// Token: 0x06014963 RID: 84323 RVA: 0x005353EB File Offset: 0x005335EB
	protected override void OnBeforeHide()
	{
		this.RefreshDangoListOddsVisible(this.BettingDangoActorList, false);
	}

	// Token: 0x06014964 RID: 84324 RVA: 0x005353FA File Offset: 0x005335FA
	protected override void OnAfterHide()
	{
		if (this.HoverDango != null)
		{
			UiModelUtil.Instance.SelectDangoActor(this.HoverDango, false);
			this.HoverDango = null;
		}
	}

	// Token: 0x06014965 RID: 84325 RVA: 0x0053541C File Offset: 0x0053361C
	protected override void OnBeforeDestroy()
	{
		if (this.MatchStateChangeDelayTimer != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.MatchStateChangeDelayTimer);
			this.MatchStateChangeDelayTimer = null;
		}
		this.DestroyDangoActor();
	}

	// Token: 0x06014966 RID: 84326 RVA: 0x00535444 File Offset: 0x00533644
	private UniTask InitDangoActorList()
	{
		RacingBetsMainView.<InitDangoActorList>d__59 <InitDangoActorList>d__;
		<InitDangoActorList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDangoActorList>d__.<>4__this = this;
		<InitDangoActorList>d__.<>1__state = -1;
		<InitDangoActorList>d__.<>t__builder.Start<RacingBetsMainView.<InitDangoActorList>d__59>(ref <InitDangoActorList>d__);
		return <InitDangoActorList>d__.<>t__builder.Task;
	}

	// Token: 0x06014967 RID: 84327 RVA: 0x00535487 File Offset: 0x00533687
	private void RefreshDangoOddsInfo()
	{
		if (this.ActorShowType != ERacingBetsMainViewShowType.OneDango)
		{
			this.RefreshDangoActorOdds(this.BettingDangoActorList, this.ShowLegMatchData);
			this.RefreshDangoListOddsVisible(this.BettingDangoActorList, !this.IsViewingPreviousResult);
			return;
		}
		this.RefreshDangoListOddsVisible(this.BettingDangoActorList, false);
	}

	// Token: 0x06014968 RID: 84328 RVA: 0x005354C8 File Offset: 0x005336C8
	private void RefreshDangoActorOdds(List<TsUiSceneDangoActor> dangoActorList, RacingBetsLegMatchData legMatchData)
	{
		bool flag = legMatchData.Type == 2;
		for (int i = 0; i < dangoActorList.Count - 1; i++)
		{
			TsUiSceneDangoActor tsUiSceneDangoActor = dangoActorList[i];
			UiDangoDataComponent uiDangoDataComponent = tsUiSceneDangoActor.Model.CheckGetComponent<UiDangoDataComponent>();
			int dangoId = uiDangoDataComponent.DangoId;
			DangoConfig instance = DangoConfig.Instance;
			Dango? dango = (instance != null) ? instance.GetDangoById(dangoId) : null;
			if (dango == null || dango.GetValueOrDefault().Type != 1)
			{
				IRacingBetsDangoActorData dangoActorData = legMatchData.GetDangoActorData(dangoId);
				UiDangoOddsComponent uiDangoOddsComponent = tsUiSceneDangoActor.Model.CheckGetComponent<UiDangoOddsComponent>();
				int rank = flag ? (i + 1) : 0;
				bool isBet = legMatchData.BetDangoId == uiDangoDataComponent.DangoId;
				uiDangoOddsComponent.SetOffset(dangoActorData.DangoOffset);
				uiDangoOddsComponent.Refresh(dangoActorData.Odds / 100, rank, isBet);
			}
		}
	}

	// Token: 0x06014969 RID: 84329 RVA: 0x005355A4 File Offset: 0x005337A4
	private void RefreshDangoListOddsVisible(List<TsUiSceneDangoActor> dangoActorList, bool visible)
	{
		foreach (TsUiSceneDangoActor tsUiSceneDangoActor in dangoActorList)
		{
			UiDangoDataComponent uiDangoDataComponent = tsUiSceneDangoActor.Model.CheckGetComponent<UiDangoDataComponent>();
			DangoConfig instance = DangoConfig.Instance;
			Dango? dango = (instance != null) ? instance.GetDangoById(uiDangoDataComponent.DangoId) : null;
			bool flag = dango != null && dango.GetValueOrDefault().Type == 1;
			tsUiSceneDangoActor.Model.CheckGetComponent<UiDangoOddsComponent>().SetVisible(!flag && visible);
		}
	}

	// Token: 0x0601496A RID: 84330 RVA: 0x00535650 File Offset: 0x00533850
	private void DestroyDangoActor()
	{
		this.DestroyBettingDangoActor();
		this.DestroyWinnerDangoActor();
	}

	// Token: 0x0601496B RID: 84331 RVA: 0x00535660 File Offset: 0x00533860
	private void DestroyBettingDangoActor()
	{
		if (this.BettingDangoActorList.Count == 0)
		{
			return;
		}
		foreach (TsUiSceneDangoActor dango in this.BettingDangoActorList)
		{
			UiSceneManager.Instance.DestroyDangoActor(dango);
		}
		this.BettingDangoActorList = new List<TsUiSceneDangoActor>();
	}

	// Token: 0x0601496C RID: 84332 RVA: 0x005356D0 File Offset: 0x005338D0
	private void DestroyWinnerDangoActor()
	{
		if (this.WinnerDangoActorList.Count == 0)
		{
			return;
		}
		foreach (TsUiSceneDangoActor dango in this.WinnerDangoActorList)
		{
			UiSceneManager.Instance.DestroyDangoActor(dango);
		}
		this.WinnerDangoActorList = new List<TsUiSceneDangoActor>();
	}

	// Token: 0x0601496D RID: 84333 RVA: 0x00535740 File Offset: 0x00533940
	protected unsafe override void OnTick(float delta)
	{
		this.RefreshTimePanel(this.ShowLegMatchData);
		this.BroadcastItem.OnTick(delta);
		this.CheckHoverDango();
		if (!RacingBetsModel.Instance.UseGmState)
		{
			if (this.IsViewingPreviousResult)
			{
				RacingBetsLegMatchData endOfMatchLegMatchData = this.SeasonData.GetEndOfMatchLegMatchData();
				if (endOfMatchLegMatchData == null || endOfMatchLegMatchData.Id != this.ShowLegMatchData.Id)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RacingBets;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[OnTick] AutoSwitchBack triggered";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("endOfMatchLegId", (endOfMatchLegMatchData != null) ? endOfMatchLegMatchData.Id : -1);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ShowLegId", this.ShowLegMatchData.Id);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					this.SwitchBackToBettingMode().Forget();
				}
				return;
			}
			RacingBetsLegMatchData curLegMatchData = this.SeasonData.GetCurLegMatchData();
			if (curLegMatchData == null)
			{
				return;
			}
			if (curLegMatchData.GetLegMatchState() == this.CurMatchState && curLegMatchData.Id == this.ShowLegMatchData.Id)
			{
				return;
			}
			if (this.IsMatchStateChangePending)
			{
				return;
			}
			this.IsMatchStateChangePending = true;
			bool flag = curLegMatchData.Id != this.ShowLegMatchData.Id;
			bool flag2 = this.SeasonData.GetEndOfMatchLegMatchData() != null;
			if (flag && !flag2)
			{
				this.MatchStateChangeDelayTimer = TimerSystem.RealTimeInstance.Delay(new TTimerAction(this.OnMatchStateChangeDelayTimerEnd), 10000f, null, null, true, 1f);
				return;
			}
			this.MatchStateChange().Forget();
		}
	}

	// Token: 0x0601496E RID: 84334 RVA: 0x005358CC File Offset: 0x00533ACC
	private void CheckHoverDango()
	{
		if (!Info.Instance.IsInKeyBoard())
		{
			return;
		}
		ERacingBetsLegMatchState legMatchState = this.ShowLegMatchData.GetLegMatchState();
		if (!base.IsShowOrShowing || legMatchState != ERacingBetsLegMatchState.BettingPeriod)
		{
			if (this.HoverDango != null)
			{
				UiModelUtil.Instance.SelectDangoActor(this.HoverDango, false);
				this.HoverDango = null;
			}
			return;
		}
		FVector? pointerEventDataPosition = LguiEventSystemManager.Instance.GetPointerEventDataPosition(0);
		if (pointerEventDataPosition == null)
		{
			return;
		}
		TsUiSceneDangoActor tsUiSceneDangoActor = UiSceneManager.Instance.RayTraceDangoActor(pointerEventDataPosition.Value);
		if (tsUiSceneDangoActor == this.HoverDango)
		{
			return;
		}
		if (tsUiSceneDangoActor == null)
		{
			if (this.HoverDango != null)
			{
				UiModelUtil.Instance.SelectDangoActor(this.HoverDango, false);
			}
			this.HoverDango = null;
			return;
		}
		if (this.HoverDango != null)
		{
			UiModelUtil.Instance.SelectDangoActor(this.HoverDango, false);
		}
		this.HoverDango = tsUiSceneDangoActor;
		UiModelUtil.Instance.SelectDangoActor(this.HoverDango, true);
	}

	// Token: 0x0601496F RID: 84335 RVA: 0x005359A6 File Offset: 0x00533BA6
	private void OnMatchStateChangeDelayTimerEnd(float _)
	{
		this.MatchStateChangeDelayTimer = null;
		this.MatchStateChange().Forget();
	}

	// Token: 0x06014970 RID: 84336 RVA: 0x005359BC File Offset: 0x00533BBC
	private UniTask MatchStateChange()
	{
		RacingBetsMainView.<MatchStateChange>d__70 <MatchStateChange>d__;
		<MatchStateChange>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MatchStateChange>d__.<>4__this = this;
		<MatchStateChange>d__.<>1__state = -1;
		<MatchStateChange>d__.<>t__builder.Start<RacingBetsMainView.<MatchStateChange>d__70>(ref <MatchStateChange>d__);
		return <MatchStateChange>d__.<>t__builder.Task;
	}

	// Token: 0x06014971 RID: 84337 RVA: 0x005359FF File Offset: 0x00533BFF
	private void OnRacingBetsDangoOddsUpdate()
	{
		this.RefreshDangoActorOdds(this.BettingDangoActorList, this.ShowLegMatchData);
	}

	// Token: 0x06014972 RID: 84338 RVA: 0x00535A13 File Offset: 0x00533C13
	private void OnRacingBetsCloseLoading()
	{
		AudioSystem.Instance.PostEvent("play_ui_fx_spl_rsnt_weapon_cam_in");
	}

	// Token: 0x06014973 RID: 84339 RVA: 0x00535A25 File Offset: 0x00533C25
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		if (handleData.HandleName != this.CameraHandleName)
		{
			return;
		}
		if (!this.IsFirstShow)
		{
			return;
		}
		RacingBetsController.Instance.TryStartRacingBetsGaming(this.ShowLegMatchData.Id);
		this.IsFirstShow = false;
	}

	// Token: 0x06014974 RID: 84340 RVA: 0x00535A60 File Offset: 0x00533C60
	private void OnRacingBetsRedDotUpdate()
	{
		this.RefreshButtonRedDot();
	}

	// Token: 0x06014975 RID: 84341 RVA: 0x00535A68 File Offset: 0x00533C68
	private void OnRacingBetsDataRefresh(RacingBetsSeasonData seasonData)
	{
		if (!base.IsShowOrShowing || seasonData == null || seasonData.Id != this.SeasonData.Id)
		{
			return;
		}
		this.RefreshBySeasonData().Forget();
	}

	// Token: 0x06014976 RID: 84342 RVA: 0x00535A94 File Offset: 0x00533C94
	private UniTask RefreshBySeasonData()
	{
		RacingBetsMainView.<RefreshBySeasonData>d__76 <RefreshBySeasonData>d__;
		<RefreshBySeasonData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshBySeasonData>d__.<>4__this = this;
		<RefreshBySeasonData>d__.<>1__state = -1;
		<RefreshBySeasonData>d__.<>t__builder.Start<RacingBetsMainView.<RefreshBySeasonData>d__76>(ref <RefreshBySeasonData>d__);
		return <RefreshBySeasonData>d__.<>t__builder.Task;
	}

	// Token: 0x06014977 RID: 84343 RVA: 0x00535AD8 File Offset: 0x00533CD8
	private UniTask SwitchToViewPreviousResult()
	{
		RacingBetsMainView.<SwitchToViewPreviousResult>d__77 <SwitchToViewPreviousResult>d__;
		<SwitchToViewPreviousResult>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SwitchToViewPreviousResult>d__.<>4__this = this;
		<SwitchToViewPreviousResult>d__.<>1__state = -1;
		<SwitchToViewPreviousResult>d__.<>t__builder.Start<RacingBetsMainView.<SwitchToViewPreviousResult>d__77>(ref <SwitchToViewPreviousResult>d__);
		return <SwitchToViewPreviousResult>d__.<>t__builder.Task;
	}

	// Token: 0x06014978 RID: 84344 RVA: 0x00535B1C File Offset: 0x00533D1C
	private UniTask SwitchBackToBettingMode()
	{
		RacingBetsMainView.<SwitchBackToBettingMode>d__78 <SwitchBackToBettingMode>d__;
		<SwitchBackToBettingMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SwitchBackToBettingMode>d__.<>4__this = this;
		<SwitchBackToBettingMode>d__.<>1__state = -1;
		<SwitchBackToBettingMode>d__.<>t__builder.Start<RacingBetsMainView.<SwitchBackToBettingMode>d__78>(ref <SwitchBackToBettingMode>d__);
		return <SwitchBackToBettingMode>d__.<>t__builder.Task;
	}

	// Token: 0x06014979 RID: 84345 RVA: 0x00535B60 File Offset: 0x00533D60
	private void OnClickRaycastButton()
	{
		FVector? pointerEventDataPosition = LguiEventSystemManager.Instance.GetPointerEventDataPosition(0);
		if (pointerEventDataPosition == null)
		{
			return;
		}
		TsUiSceneDangoActor tsUiSceneDangoActor = UiSceneManager.Instance.RayTraceDangoActor(pointerEventDataPosition.Value);
		if (tsUiSceneDangoActor == null)
		{
			return;
		}
		UiModelBase model = tsUiSceneDangoActor.Model;
		UiDangoDataComponent uiDangoDataComponent = (model != null) ? model.CheckGetComponent<UiDangoDataComponent>() : null;
		RacingBetsBettingViewData param = new RacingBetsBettingViewData
		{
			SelectDangoId = uiDangoDataComponent.DangoId,
			LegMatchData = this.ShowLegMatchData,
			DangoActorList = this.BettingDangoActorList
		};
		AudioSystem.Instance.PostEvent("play_ui_tuanzi_saima_click_large");
		UiManager.Instance.OpenView(EUiViewName.RacingBetsBettingView, param, null);
	}

	// Token: 0x0601497A RID: 84346 RVA: 0x00535BF8 File Offset: 0x00533DF8
	private void OnClickCloseButton()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RacingBetsExitDungeonBackFightConfirm);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default).Forget<bool>();
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0601497B RID: 84347 RVA: 0x00535C48 File Offset: 0x00533E48
	private void OnClickActivityRewardButton()
	{
		RacingBetsSeasonData seasonData = this.SeasonData;
		RacingBetsGroupRewardData item = (seasonData != null) ? seasonData.GetGroupRewardData(ERacingBetsRewardType.BetsCount) : null;
		RacingBetsSeasonData seasonData2 = this.SeasonData;
		RacingBetsGroupRewardData item2 = (seasonData2 != null) ? seasonData2.GetGroupRewardData(ERacingBetsRewardType.DailyEarn) : null;
		UiManager.Instance.OpenView(EUiViewName.RacingBetsActivityRewardView, new List<RacingBetsGroupRewardData>
		{
			item,
			item2
		}, null);
	}

	// Token: 0x0601497C RID: 84348 RVA: 0x00535CA0 File Offset: 0x00533EA0
	private void OnClickActivityInternalRewardButton()
	{
		RacingBetsSeasonData seasonData = this.SeasonData;
		RacingBetsGroupRewardData item = (seasonData != null) ? seasonData.GetGroupRewardData(ERacingBetsRewardType.DailyGameEarn) : null;
		UiManager.Instance.OpenView(EUiViewName.RacingBetsRewardView, new List<RacingBetsGroupRewardData>
		{
			item
		}, null);
	}

	// Token: 0x0601497D RID: 84349 RVA: 0x00535CDD File Offset: 0x00533EDD
	private void OnClickBettingHistoryButton()
	{
		UiManager.Instance.OpenView(EUiViewName.RacingBetsHistoryView, null, null);
	}

	// Token: 0x0601497E RID: 84350 RVA: 0x00535CF0 File Offset: 0x00533EF0
	private void OnClickRankButton()
	{
		RacingBetsController.Instance.RacingBetsRankRequest(this.SeasonData.Id, delegate
		{
			UiManager.Instance.OpenView(EUiViewName.RacingBetsRankView, null, null);
		});
		RacingBetsModel.Instance.SetViewRedDotState(ELocalStoragePlayerKey.RacingBetsRankViewRecord);
	}

	// Token: 0x0601497F RID: 84351 RVA: 0x00535D40 File Offset: 0x00533F40
	private void OnClickScheduleButton()
	{
		RacingBetsModel.Instance.SetViewRedDotState(ELocalStoragePlayerKey.RacingBetsMatchViewRecord);
		UiManager.Instance.OpenView(EUiViewName.RacingBetsMatchView, null, null);
	}

	// Token: 0x06014980 RID: 84352 RVA: 0x00535D62 File Offset: 0x00533F62
	private void OnClickReplayButton()
	{
		RacingBetsController.Instance.RacingBetMatchActionRequest(this.SeasonData.Id, this.ShowLegMatchData.Id);
		LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.RacingBetsReplayGameRecord, this.ShowLegMatchData.Id);
	}

	// Token: 0x06014981 RID: 84353 RVA: 0x00535D9C File Offset: 0x00533F9C
	private void OnClickMatchResultDetailButton()
	{
		int id = this.SeasonData.GetCurLegMatchData().Id;
		RacingBetsController.Instance.RacingBetsMatchInfoRequest(this.SeasonData.Id, id);
	}

	// Token: 0x06014982 RID: 84354 RVA: 0x00535DD0 File Offset: 0x00533FD0
	private void OnClickBetButton()
	{
		if (this.CurMatchState == ERacingBetsLegMatchState.NotOpen || this.CurMatchState == ERacingBetsLegMatchState.EndOfBetting)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Dango_MainPage_MatchNotStart", Array.Empty<object>());
			return;
		}
		if (this.CurMatchState == ERacingBetsLegMatchState.BettingPeriod)
		{
			this.MarkCurrentOverlapAsEnteredBetting();
			UiModelBase model = this.BettingDangoActorList[0].Model;
			UiDangoDataComponent uiDangoDataComponent = (model != null) ? model.CheckGetComponent<UiDangoDataComponent>() : null;
			RacingBetsBettingViewData param = new RacingBetsBettingViewData
			{
				SelectDangoId = uiDangoDataComponent.DangoId,
				LegMatchData = this.ShowLegMatchData,
				DangoActorList = this.BettingDangoActorList
			};
			UiManager.Instance.OpenView(EUiViewName.RacingBetsBettingView, param, null);
			return;
		}
		RacingBetsController.Instance.RacingBetMatchActionRequest(this.SeasonData.Id, this.ShowLegMatchData.Id);
		LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.RacingBetsWatchGameRecord, this.ShowLegMatchData.Id);
	}

	// Token: 0x06014983 RID: 84355 RVA: 0x00535EA4 File Offset: 0x005340A4
	private unsafe void OnClickViewPreviousResultButton()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RacingBets;
		ELogAuthor author = ELogAuthor.LRC;
		string message = "[OnClickViewPreviousResult]";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IsViewingPrev", this.IsViewingPreviousResult);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item = "ShowLegId";
		RacingBetsLegMatchData showLegMatchData = this.ShowLegMatchData;
		ptr = new ValueTuple<string, object>(item, (showLegMatchData != null) ? showLegMatchData.Id : -1);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (!this.IsViewingPreviousResult)
		{
			this.SwitchToViewPreviousResult().Forget();
		}
	}

	// Token: 0x06014984 RID: 84356 RVA: 0x00535F3C File Offset: 0x0053413C
	private unsafe void OnClickToBetButton()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RacingBets;
		ELogAuthor author = ELogAuthor.LRC;
		string message = "[OnClickToBet] enter";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IsViewingPrev", this.IsViewingPreviousResult);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item = "ShowLegId";
		RacingBetsLegMatchData showLegMatchData = this.ShowLegMatchData;
		ptr = new ValueTuple<string, object>(item, (showLegMatchData != null) ? showLegMatchData.Id : -1);
		ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
		string item2 = "ActualLegId";
		RacingBetsLegMatchData actualLegMatchData = this.ActualLegMatchData;
		ptr2 = new ValueTuple<string, object>(item2, (actualLegMatchData != null) ? actualLegMatchData.Id : -1);
		ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
		string item3 = "ActualLegState";
		RacingBetsLegMatchData actualLegMatchData2 = this.ActualLegMatchData;
		ptr3 = new ValueTuple<string, object>(item3, (actualLegMatchData2 != null) ? actualLegMatchData2.GetLegMatchState() : ((ERacingBetsLegMatchState)(-1)));
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		if (this.IsViewingPreviousResult)
		{
			RacingBetsLegMatchData actualLegMatchData3 = this.ActualLegMatchData;
			ERacingBetsLegMatchState eracingBetsLegMatchState = (actualLegMatchData3 != null) ? actualLegMatchData3.GetLegMatchState() : ((ERacingBetsLegMatchState)(-1));
			int num = (actualLegMatchData3 != null) ? actualLegMatchData3.GetAllDangoActorDataList().Count : 0;
			if (actualLegMatchData3 == null || eracingBetsLegMatchState != ERacingBetsLegMatchState.BettingPeriod || num <= 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RacingBets;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "[OnClickToBet] block: data not ready";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("ActualLegState", eracingBetsLegMatchState);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("DangoCount", num);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				ScrollingTipsController.Instance.ShowTipsByTextId("Dango_MainPage_MatchNotOpen", Array.Empty<object>());
				return;
			}
			Log.Instance.Info(ELogModule.RacingBets, ELogAuthor.LRC, "[OnClickToBet] proceed switch back", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.MarkCurrentOverlapAsEnteredBetting();
			this.SwitchBackToBettingMode().Forget();
		}
	}

	// Token: 0x06014985 RID: 84357 RVA: 0x00536104 File Offset: 0x00534304
	private void MarkCurrentOverlapAsEnteredBetting()
	{
		RacingBetsLegMatchData endOfMatchLegMatchData = this.SeasonData.GetEndOfMatchLegMatchData();
		if (endOfMatchLegMatchData == null)
		{
			return;
		}
		RacingBetsModel.Instance.MarkBettingMainViewEntered(this.SeasonData.Id, endOfMatchLegMatchData.Id);
	}

	// Token: 0x04009AA8 RID: 39592
	private bool IsFirstShow = true;

	// Token: 0x04009AA9 RID: 39593
	private string CameraHandleName = "";

	// Token: 0x04009AAA RID: 39594
	private ERacingBetsMainViewShowType ActorShowType = ERacingBetsMainViewShowType.SixDango;

	// Token: 0x04009AAB RID: 39595
	private ERacingBetsLegMatchState CurMatchState;

	// Token: 0x04009AAC RID: 39596
	private RacingBetsSeasonData SeasonData;

	// Token: 0x04009AAD RID: 39597
	private RacingBetsLegMatchData ShowLegMatchData;

	// Token: 0x04009AAE RID: 39598
	[Nullable(2)]
	private RacingBetsLegMatchData NextLegMatchData;

	// Token: 0x04009AAF RID: 39599
	private bool IsViewingPreviousResult;

	// Token: 0x04009AB0 RID: 39600
	private RacingBetsLegMatchData ActualLegMatchData;

	// Token: 0x04009AB1 RID: 39601
	private bool IsMatchStateChangePending;

	// Token: 0x04009AB2 RID: 39602
	[Nullable(2)]
	private TimerHandle MatchStateChangeDelayTimer;

	// Token: 0x04009AB3 RID: 39603
	private RacingBetsLegMatchTabItem FirstLegMatchItem;

	// Token: 0x04009AB4 RID: 39604
	private RacingBetsLegMatchTabItem SecondLegMatchItem;

	// Token: 0x04009AB5 RID: 39605
	private CommonCurrencyItem CommonCurrencyItem;

	// Token: 0x04009AB6 RID: 39606
	private RacingBetsCostItem BetsCostItem;

	// Token: 0x04009AB7 RID: 39607
	private RacingBetsCostItem BetRewardItem;

	// Token: 0x04009AB8 RID: 39608
	private RacingBetsChampionRewardItem ChampionRewardItem;

	// Token: 0x04009AB9 RID: 39609
	private RacingBetsDangoBroadcastItem BroadcastItem;

	// Token: 0x04009ABA RID: 39610
	private GenericLayout<RacingBetsLegMatchResultItem, IRacingBetsLegMatchResultData> MatchResultLayout;

	// Token: 0x04009ABB RID: 39611
	private List<TsUiSceneDangoActor> BettingDangoActorList = new List<TsUiSceneDangoActor>();

	// Token: 0x04009ABC RID: 39612
	private List<IRacingBetsDangoActorData> BettingDangoActorDataList = new List<IRacingBetsDangoActorData>();

	// Token: 0x04009ABD RID: 39613
	private List<TsUiSceneDangoActor> WinnerDangoActorList = new List<TsUiSceneDangoActor>();

	// Token: 0x04009ABE RID: 39614
	private RacingBetsButtonItem ReplayButton;

	// Token: 0x04009ABF RID: 39615
	private RacingBetsButtonItem ReplayChampionButton;

	// Token: 0x04009AC0 RID: 39616
	private RacingBetsButtonItem BetButton;

	// Token: 0x04009AC1 RID: 39617
	private RacingBetsButtonItem RankButton;

	// Token: 0x04009AC2 RID: 39618
	private RacingBetsButtonItem HistoryButton;

	// Token: 0x04009AC3 RID: 39619
	private RacingBetsButtonItem ScheduleButton;

	// Token: 0x04009AC4 RID: 39620
	private RacingBetsButtonItem ActivityInternalRewardButton;

	// Token: 0x04009AC5 RID: 39621
	private RacingBetsButtonItem ActivityRewardButton;

	// Token: 0x04009AC6 RID: 39622
	private RacingBetsButtonItem ToBetButton;

	// Token: 0x04009AC7 RID: 39623
	[Nullable(2)]
	private TsUiSceneDangoActor HoverDango;

	// Token: 0x02008D9D RID: 36253
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402DF71 RID: 188273
		public const int RaycastButton = 0;

		// Token: 0x0402DF72 RID: 188274
		public const int CloseButton = 1;

		// Token: 0x0402DF73 RID: 188275
		public const int CurrencyItem = 2;

		// Token: 0x0402DF74 RID: 188276
		public const int TimeDescText = 3;

		// Token: 0x0402DF75 RID: 188277
		public const int RemainTimeText = 4;

		// Token: 0x0402DF76 RID: 188278
		public const int ActivityInternalRewardButton = 5;

		// Token: 0x0402DF77 RID: 188279
		public const int ActivityRewardButton = 6;

		// Token: 0x0402DF78 RID: 188280
		public const int BettingHistoryButton = 7;

		// Token: 0x0402DF79 RID: 188281
		public const int RankButton = 8;

		// Token: 0x0402DF7A RID: 188282
		public const int FirstLegMatchItem = 9;

		// Token: 0x0402DF7B RID: 188283
		public const int SecondLegMatchItem = 10;

		// Token: 0x0402DF7C RID: 188284
		public const int ScheduleButton = 11;

		// Token: 0x0402DF7D RID: 188285
		public const int ResultPanel = 12;

		// Token: 0x0402DF7E RID: 188286
		public const int TimeText = 13;

		// Token: 0x0402DF7F RID: 188287
		public const int ResultTitle = 14;

		// Token: 0x0402DF80 RID: 188288
		public const int ResultLayout = 15;

		// Token: 0x0402DF81 RID: 188289
		public const int ReplayButton = 16;

		// Token: 0x0402DF82 RID: 188290
		public const int BroadcastItem = 17;

		// Token: 0x0402DF83 RID: 188291
		public const int TipsText = 18;

		// Token: 0x0402DF84 RID: 188292
		public const int BetPanel = 19;

		// Token: 0x0402DF85 RID: 188293
		public const int BetInfoItem = 20;

		// Token: 0x0402DF86 RID: 188294
		public const int BetDangoNameText = 21;

		// Token: 0x0402DF87 RID: 188295
		public const int DangoTexture = 22;

		// Token: 0x0402DF88 RID: 188296
		public const int BetCostItem = 23;

		// Token: 0x0402DF89 RID: 188297
		public const int BetOddsText = 24;

		// Token: 0x0402DF8A RID: 188298
		public const int BetEmptyItem = 25;

		// Token: 0x0402DF8B RID: 188299
		public const int BetButton = 26;

		// Token: 0x0402DF8C RID: 188300
		public const int NormalResultPanel = 27;

		// Token: 0x0402DF8D RID: 188301
		public const int ChampionResultPanel = 28;

		// Token: 0x0402DF8E RID: 188302
		public const int ChampionRewardItem = 29;

		// Token: 0x0402DF8F RID: 188303
		public const int ChampionDetailPanel = 30;

		// Token: 0x0402DF90 RID: 188304
		public const int ChampionDangoName = 31;

		// Token: 0x0402DF91 RID: 188305
		public const int MatchResultDetailButton = 32;

		// Token: 0x0402DF92 RID: 188306
		public const int BetRewardItem = 33;

		// Token: 0x0402DF93 RID: 188307
		public const int ViewPreviousResultButton = 34;

		// Token: 0x0402DF94 RID: 188308
		public const int ToBetButton = 35;

		// Token: 0x0402DF95 RID: 188309
		public const int ReplayChampionButton = 36;
	}
}
