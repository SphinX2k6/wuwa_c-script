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
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C20 RID: 7200
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsMainView : UiTickViewBase, IUiViewCameraBehavior
{
	// Token: 0x06011E2D RID: 73261 RVA: 0x00542EBC File Offset: 0x005410BC
	public RacingBetsMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011E2E RID: 73262 RVA: 0x00542F0C File Offset: 0x0054110C
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

	// Token: 0x06011E2F RID: 73263 RVA: 0x005434C0 File Offset: 0x005416C0
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsMainView.<OnBeforeStartAsync>d__34 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsMainView.<OnBeforeStartAsync>d__34>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011E30 RID: 73264 RVA: 0x00543504 File Offset: 0x00541704
	protected override UniTask OnBeforeShowAsyncImplementImplement()
	{
		RacingBetsMainView.<OnBeforeShowAsyncImplementImplement>d__35 <OnBeforeShowAsyncImplementImplement>d__;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<RacingBetsMainView.<OnBeforeShowAsyncImplementImplement>d__35>(ref <OnBeforeShowAsyncImplementImplement>d__);
		return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06011E31 RID: 73265 RVA: 0x00543548 File Offset: 0x00541748
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

	// Token: 0x06011E32 RID: 73266 RVA: 0x005436C8 File Offset: 0x005418C8
	private UniTask InitComponent()
	{
		RacingBetsMainView.<InitComponent>d__37 <InitComponent>d__;
		<InitComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitComponent>d__.<>4__this = this;
		<InitComponent>d__.<>1__state = -1;
		<InitComponent>d__.<>t__builder.Start<RacingBetsMainView.<InitComponent>d__37>(ref <InitComponent>d__);
		return <InitComponent>d__.<>t__builder.Task;
	}

	// Token: 0x06011E33 RID: 73267 RVA: 0x0054370C File Offset: 0x0054190C
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

	// Token: 0x06011E34 RID: 73268 RVA: 0x00543816 File Offset: 0x00541A16
	private RacingBetsLegMatchResultItem ResultItemProxyCreate()
	{
		return new RacingBetsLegMatchResultItem();
	}

	// Token: 0x06011E35 RID: 73269 RVA: 0x0054381D File Offset: 0x00541A1D
	public void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
	{
		UiCameraController.Instance.PushCameraHandleByOpenView((EUiViewName)"Camera_DangoPreview_Start", viewId, operationType);
	}

	// Token: 0x06011E36 RID: 73270 RVA: 0x00543838 File Offset: 0x00541A38
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnRacingBetsCloseLoading));
		EventSystem.Instance.Add(EEventName.OnRacingBetsDangoOddsUpdate, new Action(this.OnRacingBetsDangoOddsUpdate));
		EventSystem.Instance.Add<RacingBetsSeasonData>(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.OnRacingBetsDataRefresh));
		EventSystem.Instance.Add(EEventName.OnRacingBetsRedDotUpdate, new Action(this.OnRacingBetsRedDotUpdate));
		EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
	}

	// Token: 0x06011E37 RID: 73271 RVA: 0x005438D1 File Offset: 0x00541AD1
	protected override void OnBeforeShow()
	{
		if (RacingBetsModel.Instance.IsFinalLegMatch(this.ShowLegMatchData.Id) && this.CurMatchState == ERacingBetsLegMatchState.EndOfMatch)
		{
			base.PlaySequence("Champion", null, false);
		}
		this.RefreshUi();
	}

	// Token: 0x06011E38 RID: 73272 RVA: 0x00543908 File Offset: 0x00541B08
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

	// Token: 0x06011E39 RID: 73273 RVA: 0x0054398C File Offset: 0x00541B8C
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

	// Token: 0x06011E3A RID: 73274 RVA: 0x00543A1C File Offset: 0x00541C1C
	private void RefreshCurrencyItem(RacingBetsSeasonData seasonData)
	{
		this.CommonCurrencyItem.RefreshTemp(seasonData.GetCurrencyItemId(), seasonData.GetCurrencyCount().ToString());
		this.CommonCurrencyItem.SetButtonActive(false);
	}

	// Token: 0x06011E3B RID: 73275 RVA: 0x00543A54 File Offset: 0x00541C54
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

	// Token: 0x06011E3C RID: 73276 RVA: 0x00543AD0 File Offset: 0x00541CD0
	private void RefreshNormalResultPanel(RacingBetsLegMatchData legMatchData)
	{
		List<IRacingBetsLegMatchResultData> legMatchResultList = legMatchData.GetLegMatchResultList();
		base.GetText(14).ShowTextNew(legMatchData.Name);
		this.MatchResultLayout.RefreshByData(legMatchResultList, null, false);
		this.ReplayChampionButton.SetActive(false);
		this.ReplayButton.SetActive(true);
	}

	// Token: 0x06011E3D RID: 73277 RVA: 0x00543B20 File Offset: 0x00541D20
	private void RefreshFinalResultPanel(RacingBetsLegMatchData legMatchData)
	{
		this.ChampionRewardItem.Refresh(this.SeasonData.GetSeasonConfig().EndReward);
		int championDangoId = legMatchData.GetChampionDangoId();
		DangoData dangoData = DangoManager.Instance.GetDangoData(championDangoId);
		base.GetText(31).ShowTextNew(dangoData.NameKey);
		this.ReplayChampionButton.SetActive(true);
		this.ReplayButton.SetActive(false);
	}

	// Token: 0x06011E3E RID: 73278 RVA: 0x00543B8C File Offset: 0x00541D8C
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

	// Token: 0x06011E3F RID: 73279 RVA: 0x00543C74 File Offset: 0x00541E74
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

	// Token: 0x06011E40 RID: 73280 RVA: 0x00543D84 File Offset: 0x00541F84
	private void RefreshAudio(RacingBetsLegMatchData legMatchData)
	{
		if (this.CurMatchState == ERacingBetsLegMatchState.EndOfMatch)
		{
			AudioSystem.Instance.SetState("dungeon_2_3_race_music", ERacingBetsAudioState.RaceFinals.ToString(), true);
			return;
		}
		AudioSystem.Instance.SetState("dungeon_2_3_race_music", ERacingBetsAudioState.None.ToString(), true);
	}

	// Token: 0x06011E41 RID: 73281 RVA: 0x00543DDC File Offset: 0x00541FDC
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

	// Token: 0x06011E42 RID: 73282 RVA: 0x00543EFC File Offset: 0x005420FC
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

	// Token: 0x06011E43 RID: 73283 RVA: 0x00544044 File Offset: 0x00542244
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnRacingBetsCloseLoading));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDangoOddsUpdate, new Action(this.OnRacingBetsDangoOddsUpdate));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.OnRacingBetsDataRefresh));
		EventSystem.Instance.Remove(EEventName.OnRacingBetsRedDotUpdate, new Action(this.OnRacingBetsRedDotUpdate));
		EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
	}

	// Token: 0x06011E44 RID: 73284 RVA: 0x005440DD File Offset: 0x005422DD
	public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
	{
		UiCameraController.Instance.PopCameraHandleByCloseView((EUiViewName)"Camera_DangoPreview_Start", nextViewName, closeViewId, operationType);
	}

	// Token: 0x06011E45 RID: 73285 RVA: 0x005440F7 File Offset: 0x005422F7
	protected override void OnBeforeHide()
	{
		this.RefreshDangoListOddsVisible(this.BettingDangoActorList, false);
	}

	// Token: 0x06011E46 RID: 73286 RVA: 0x00544106 File Offset: 0x00542306
	protected override void OnAfterHide()
	{
		if (this.HoverDango != null)
		{
			UiModelUtil.Instance.SelectDangoActor(this.HoverDango, false);
			this.HoverDango = null;
		}
	}

	// Token: 0x06011E47 RID: 73287 RVA: 0x00544128 File Offset: 0x00542328
	protected override void OnBeforeDestroy()
	{
		if (this.MatchStateChangeDelayTimer != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.MatchStateChangeDelayTimer);
			this.MatchStateChangeDelayTimer = null;
		}
		this.DestroyDangoActor();
	}

	// Token: 0x06011E48 RID: 73288 RVA: 0x00544150 File Offset: 0x00542350
	private UniTask InitDangoActorList()
	{
		RacingBetsMainView.<InitDangoActorList>d__59 <InitDangoActorList>d__;
		<InitDangoActorList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDangoActorList>d__.<>4__this = this;
		<InitDangoActorList>d__.<>1__state = -1;
		<InitDangoActorList>d__.<>t__builder.Start<RacingBetsMainView.<InitDangoActorList>d__59>(ref <InitDangoActorList>d__);
		return <InitDangoActorList>d__.<>t__builder.Task;
	}

	// Token: 0x06011E49 RID: 73289 RVA: 0x00544193 File Offset: 0x00542393
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

	// Token: 0x06011E4A RID: 73290 RVA: 0x005441D4 File Offset: 0x005423D4
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

	// Token: 0x06011E4B RID: 73291 RVA: 0x005442B0 File Offset: 0x005424B0
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

	// Token: 0x06011E4C RID: 73292 RVA: 0x0054435C File Offset: 0x0054255C
	private void DestroyDangoActor()
	{
		this.DestroyBettingDangoActor();
		this.DestroyWinnerDangoActor();
	}

	// Token: 0x06011E4D RID: 73293 RVA: 0x0054436C File Offset: 0x0054256C
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

	// Token: 0x06011E4E RID: 73294 RVA: 0x005443DC File Offset: 0x005425DC
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

	// Token: 0x06011E4F RID: 73295 RVA: 0x0054444C File Offset: 0x0054264C
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

	// Token: 0x06011E50 RID: 73296 RVA: 0x005445D8 File Offset: 0x005427D8
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

	// Token: 0x06011E51 RID: 73297 RVA: 0x005446B2 File Offset: 0x005428B2
	private void OnMatchStateChangeDelayTimerEnd(float _)
	{
		this.MatchStateChangeDelayTimer = null;
		this.MatchStateChange().Forget();
	}

	// Token: 0x06011E52 RID: 73298 RVA: 0x005446C8 File Offset: 0x005428C8
	private UniTask MatchStateChange()
	{
		RacingBetsMainView.<MatchStateChange>d__70 <MatchStateChange>d__;
		<MatchStateChange>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MatchStateChange>d__.<>4__this = this;
		<MatchStateChange>d__.<>1__state = -1;
		<MatchStateChange>d__.<>t__builder.Start<RacingBetsMainView.<MatchStateChange>d__70>(ref <MatchStateChange>d__);
		return <MatchStateChange>d__.<>t__builder.Task;
	}

	// Token: 0x06011E53 RID: 73299 RVA: 0x0054470B File Offset: 0x0054290B
	private void OnRacingBetsDangoOddsUpdate()
	{
		this.RefreshDangoActorOdds(this.BettingDangoActorList, this.ShowLegMatchData);
	}

	// Token: 0x06011E54 RID: 73300 RVA: 0x0054471F File Offset: 0x0054291F
	private void OnRacingBetsCloseLoading()
	{
		AudioSystem.Instance.PostEvent("play_ui_fx_spl_rsnt_weapon_cam_in");
	}

	// Token: 0x06011E55 RID: 73301 RVA: 0x00544731 File Offset: 0x00542931
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		if (handleData.GetHandleName() != this.CameraHandleName)
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

	// Token: 0x06011E56 RID: 73302 RVA: 0x0054476C File Offset: 0x0054296C
	private void OnRacingBetsRedDotUpdate()
	{
		this.RefreshButtonRedDot();
	}

	// Token: 0x06011E57 RID: 73303 RVA: 0x00544774 File Offset: 0x00542974
	private void OnRacingBetsDataRefresh(RacingBetsSeasonData seasonData)
	{
		if (!base.IsShowOrShowing || seasonData == null || seasonData.Id != this.SeasonData.Id)
		{
			return;
		}
		this.RefreshBySeasonData().Forget();
	}

	// Token: 0x06011E58 RID: 73304 RVA: 0x005447A0 File Offset: 0x005429A0
	private UniTask RefreshBySeasonData()
	{
		RacingBetsMainView.<RefreshBySeasonData>d__76 <RefreshBySeasonData>d__;
		<RefreshBySeasonData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshBySeasonData>d__.<>4__this = this;
		<RefreshBySeasonData>d__.<>1__state = -1;
		<RefreshBySeasonData>d__.<>t__builder.Start<RacingBetsMainView.<RefreshBySeasonData>d__76>(ref <RefreshBySeasonData>d__);
		return <RefreshBySeasonData>d__.<>t__builder.Task;
	}

	// Token: 0x06011E59 RID: 73305 RVA: 0x005447E4 File Offset: 0x005429E4
	private UniTask SwitchToViewPreviousResult()
	{
		RacingBetsMainView.<SwitchToViewPreviousResult>d__77 <SwitchToViewPreviousResult>d__;
		<SwitchToViewPreviousResult>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SwitchToViewPreviousResult>d__.<>4__this = this;
		<SwitchToViewPreviousResult>d__.<>1__state = -1;
		<SwitchToViewPreviousResult>d__.<>t__builder.Start<RacingBetsMainView.<SwitchToViewPreviousResult>d__77>(ref <SwitchToViewPreviousResult>d__);
		return <SwitchToViewPreviousResult>d__.<>t__builder.Task;
	}

	// Token: 0x06011E5A RID: 73306 RVA: 0x00544828 File Offset: 0x00542A28
	private UniTask SwitchBackToBettingMode()
	{
		RacingBetsMainView.<SwitchBackToBettingMode>d__78 <SwitchBackToBettingMode>d__;
		<SwitchBackToBettingMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SwitchBackToBettingMode>d__.<>4__this = this;
		<SwitchBackToBettingMode>d__.<>1__state = -1;
		<SwitchBackToBettingMode>d__.<>t__builder.Start<RacingBetsMainView.<SwitchBackToBettingMode>d__78>(ref <SwitchBackToBettingMode>d__);
		return <SwitchBackToBettingMode>d__.<>t__builder.Task;
	}

	// Token: 0x06011E5B RID: 73307 RVA: 0x0054486C File Offset: 0x00542A6C
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

	// Token: 0x06011E5C RID: 73308 RVA: 0x00544904 File Offset: 0x00542B04
	private void OnClickCloseButton()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RacingBetsExitDungeonBackFightConfirm);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default).Forget<bool>();
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06011E5D RID: 73309 RVA: 0x00544954 File Offset: 0x00542B54
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

	// Token: 0x06011E5E RID: 73310 RVA: 0x005449AC File Offset: 0x00542BAC
	private void OnClickActivityInternalRewardButton()
	{
		RacingBetsSeasonData seasonData = this.SeasonData;
		RacingBetsGroupRewardData item = (seasonData != null) ? seasonData.GetGroupRewardData(ERacingBetsRewardType.DailyGameEarn) : null;
		UiManager.Instance.OpenView(EUiViewName.RacingBetsRewardView, new List<RacingBetsGroupRewardData>
		{
			item
		}, null);
	}

	// Token: 0x06011E5F RID: 73311 RVA: 0x005449E9 File Offset: 0x00542BE9
	private void OnClickBettingHistoryButton()
	{
		UiManager.Instance.OpenView(EUiViewName.RacingBetsHistoryView, null, null);
	}

	// Token: 0x06011E60 RID: 73312 RVA: 0x005449FC File Offset: 0x00542BFC
	private void OnClickRankButton()
	{
		RacingBetsController.Instance.RacingBetsRankRequest(this.SeasonData.Id, delegate
		{
			UiManager.Instance.OpenView(EUiViewName.RacingBetsRankView, null, null);
		});
		RacingBetsModel.Instance.SetViewRedDotState(ELocalStoragePlayerKey.RacingBetsRankViewRecord);
	}

	// Token: 0x06011E61 RID: 73313 RVA: 0x00544A4C File Offset: 0x00542C4C
	private void OnClickScheduleButton()
	{
		RacingBetsModel.Instance.SetViewRedDotState(ELocalStoragePlayerKey.RacingBetsMatchViewRecord);
		UiManager.Instance.OpenView(EUiViewName.RacingBetsMatchView, null, null);
	}

	// Token: 0x06011E62 RID: 73314 RVA: 0x00544A6E File Offset: 0x00542C6E
	private void OnClickReplayButton()
	{
		RacingBetsController.Instance.RacingBetMatchActionRequest(this.SeasonData.Id, this.ShowLegMatchData.Id);
		LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.RacingBetsReplayGameRecord, this.ShowLegMatchData.Id);
	}

	// Token: 0x06011E63 RID: 73315 RVA: 0x00544AA8 File Offset: 0x00542CA8
	private void OnClickMatchResultDetailButton()
	{
		int id = this.SeasonData.GetCurLegMatchData().Id;
		RacingBetsController.Instance.RacingBetsMatchInfoRequest(this.SeasonData.Id, id);
	}

	// Token: 0x06011E64 RID: 73316 RVA: 0x00544ADC File Offset: 0x00542CDC
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

	// Token: 0x06011E65 RID: 73317 RVA: 0x00544BB0 File Offset: 0x00542DB0
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

	// Token: 0x06011E66 RID: 73318 RVA: 0x00544C48 File Offset: 0x00542E48
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

	// Token: 0x06011E67 RID: 73319 RVA: 0x00544E10 File Offset: 0x00543010
	private void MarkCurrentOverlapAsEnteredBetting()
	{
		RacingBetsLegMatchData endOfMatchLegMatchData = this.SeasonData.GetEndOfMatchLegMatchData();
		if (endOfMatchLegMatchData == null)
		{
			return;
		}
		RacingBetsModel.Instance.MarkBettingMainViewEntered(this.SeasonData.Id, endOfMatchLegMatchData.Id);
	}

	// Token: 0x04009C00 RID: 39936
	private bool IsFirstShow = true;

	// Token: 0x04009C01 RID: 39937
	private string CameraHandleName = "";

	// Token: 0x04009C02 RID: 39938
	private ERacingBetsMainViewShowType ActorShowType = ERacingBetsMainViewShowType.SixDango;

	// Token: 0x04009C03 RID: 39939
	private ERacingBetsLegMatchState CurMatchState;

	// Token: 0x04009C04 RID: 39940
	private RacingBetsSeasonData SeasonData;

	// Token: 0x04009C05 RID: 39941
	private RacingBetsLegMatchData ShowLegMatchData;

	// Token: 0x04009C06 RID: 39942
	[Nullable(2)]
	private RacingBetsLegMatchData NextLegMatchData;

	// Token: 0x04009C07 RID: 39943
	private bool IsViewingPreviousResult;

	// Token: 0x04009C08 RID: 39944
	private RacingBetsLegMatchData ActualLegMatchData;

	// Token: 0x04009C09 RID: 39945
	private bool IsMatchStateChangePending;

	// Token: 0x04009C0A RID: 39946
	[Nullable(2)]
	private TimerHandle MatchStateChangeDelayTimer;

	// Token: 0x04009C0B RID: 39947
	private RacingBetsLegMatchTabItem FirstLegMatchItem;

	// Token: 0x04009C0C RID: 39948
	private RacingBetsLegMatchTabItem SecondLegMatchItem;

	// Token: 0x04009C0D RID: 39949
	private CommonCurrencyItem CommonCurrencyItem;

	// Token: 0x04009C0E RID: 39950
	private RacingBetsCostItem BetsCostItem;

	// Token: 0x04009C0F RID: 39951
	private RacingBetsCostItem BetRewardItem;

	// Token: 0x04009C10 RID: 39952
	private RacingBetsChampionRewardItem ChampionRewardItem;

	// Token: 0x04009C11 RID: 39953
	private RacingBetsDangoBroadcastItem BroadcastItem;

	// Token: 0x04009C12 RID: 39954
	private GenericLayout<RacingBetsLegMatchResultItem, IRacingBetsLegMatchResultData> MatchResultLayout;

	// Token: 0x04009C13 RID: 39955
	private List<TsUiSceneDangoActor> BettingDangoActorList = new List<TsUiSceneDangoActor>();

	// Token: 0x04009C14 RID: 39956
	private List<IRacingBetsDangoActorData> BettingDangoActorDataList = new List<IRacingBetsDangoActorData>();

	// Token: 0x04009C15 RID: 39957
	private List<TsUiSceneDangoActor> WinnerDangoActorList = new List<TsUiSceneDangoActor>();

	// Token: 0x04009C16 RID: 39958
	private RacingBetsButtonItem ReplayButton;

	// Token: 0x04009C17 RID: 39959
	private RacingBetsButtonItem ReplayChampionButton;

	// Token: 0x04009C18 RID: 39960
	private RacingBetsButtonItem BetButton;

	// Token: 0x04009C19 RID: 39961
	private RacingBetsButtonItem RankButton;

	// Token: 0x04009C1A RID: 39962
	private RacingBetsButtonItem HistoryButton;

	// Token: 0x04009C1B RID: 39963
	private RacingBetsButtonItem ScheduleButton;

	// Token: 0x04009C1C RID: 39964
	private RacingBetsButtonItem ActivityInternalRewardButton;

	// Token: 0x04009C1D RID: 39965
	private RacingBetsButtonItem ActivityRewardButton;

	// Token: 0x04009C1E RID: 39966
	private RacingBetsButtonItem ToBetButton;

	// Token: 0x04009C1F RID: 39967
	[Nullable(2)]
	private TsUiSceneDangoActor HoverDango;

	// Token: 0x02007F25 RID: 32549
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04029287 RID: 168583
		public const int RaycastButton = 0;

		// Token: 0x04029288 RID: 168584
		public const int CloseButton = 1;

		// Token: 0x04029289 RID: 168585
		public const int CurrencyItem = 2;

		// Token: 0x0402928A RID: 168586
		public const int TimeDescText = 3;

		// Token: 0x0402928B RID: 168587
		public const int RemainTimeText = 4;

		// Token: 0x0402928C RID: 168588
		public const int ActivityInternalRewardButton = 5;

		// Token: 0x0402928D RID: 168589
		public const int ActivityRewardButton = 6;

		// Token: 0x0402928E RID: 168590
		public const int BettingHistoryButton = 7;

		// Token: 0x0402928F RID: 168591
		public const int RankButton = 8;

		// Token: 0x04029290 RID: 168592
		public const int FirstLegMatchItem = 9;

		// Token: 0x04029291 RID: 168593
		public const int SecondLegMatchItem = 10;

		// Token: 0x04029292 RID: 168594
		public const int ScheduleButton = 11;

		// Token: 0x04029293 RID: 168595
		public const int ResultPanel = 12;

		// Token: 0x04029294 RID: 168596
		public const int TimeText = 13;

		// Token: 0x04029295 RID: 168597
		public const int ResultTitle = 14;

		// Token: 0x04029296 RID: 168598
		public const int ResultLayout = 15;

		// Token: 0x04029297 RID: 168599
		public const int ReplayButton = 16;

		// Token: 0x04029298 RID: 168600
		public const int BroadcastItem = 17;

		// Token: 0x04029299 RID: 168601
		public const int TipsText = 18;

		// Token: 0x0402929A RID: 168602
		public const int BetPanel = 19;

		// Token: 0x0402929B RID: 168603
		public const int BetInfoItem = 20;

		// Token: 0x0402929C RID: 168604
		public const int BetDangoNameText = 21;

		// Token: 0x0402929D RID: 168605
		public const int DangoTexture = 22;

		// Token: 0x0402929E RID: 168606
		public const int BetCostItem = 23;

		// Token: 0x0402929F RID: 168607
		public const int BetOddsText = 24;

		// Token: 0x040292A0 RID: 168608
		public const int BetEmptyItem = 25;

		// Token: 0x040292A1 RID: 168609
		public const int BetButton = 26;

		// Token: 0x040292A2 RID: 168610
		public const int NormalResultPanel = 27;

		// Token: 0x040292A3 RID: 168611
		public const int ChampionResultPanel = 28;

		// Token: 0x040292A4 RID: 168612
		public const int ChampionRewardItem = 29;

		// Token: 0x040292A5 RID: 168613
		public const int ChampionDetailPanel = 30;

		// Token: 0x040292A6 RID: 168614
		public const int ChampionDangoName = 31;

		// Token: 0x040292A7 RID: 168615
		public const int MatchResultDetailButton = 32;

		// Token: 0x040292A8 RID: 168616
		public const int BetRewardItem = 33;

		// Token: 0x040292A9 RID: 168617
		public const int ViewPreviousResultButton = 34;

		// Token: 0x040292AA RID: 168618
		public const int ToBetButton = 35;

		// Token: 0x040292AB RID: 168619
		public const int ReplayChampionButton = 36;
	}
}
