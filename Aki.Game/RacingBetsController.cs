using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Module.RacingBets.Data;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02001BCC RID: 7116
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RacingBetsController : ActivityControllerBase
{
	// Token: 0x06011BA5 RID: 72613 RVA: 0x00539911 File Offset: 0x00537B11
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06011BA6 RID: 72614 RVA: 0x00539913 File Offset: 0x00537B13
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_RaceHorseGuide";
	}

	// Token: 0x06011BA7 RID: 72615 RVA: 0x0053991A File Offset: 0x00537B1A
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new RacingBetsActivityView();
	}

	// Token: 0x06011BA8 RID: 72616 RVA: 0x00539924 File Offset: 0x00537B24
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		RacingBetsSeasonData racingBetsSeasonData = new RacingBetsSeasonData();
		RacingBetsModel.Instance.SetRacingBetsSeasonData(racingBetsSeasonData);
		return racingBetsSeasonData;
	}

	// Token: 0x06011BA9 RID: 72617 RVA: 0x00539943 File Offset: 0x00537B43
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06011BAA RID: 72618 RVA: 0x00539946 File Offset: 0x00537B46
	protected override bool OnInit()
	{
		this.IsShowDangoFrameTipView = false;
		return true;
	}

	// Token: 0x06011BAB RID: 72619 RVA: 0x00539950 File Offset: 0x00537B50
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<RacingBetsSeasonData>(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.OnRacingBetsDataInit));
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDoneAndCloseLoading));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.HandleRacingBetsFrameViewShow));
		EventSystem.Instance.Add(EEventName.LeaveInstanceDungeon, new Action(this.OnLeaveDungeon));
	}

	// Token: 0x06011BAC RID: 72620 RVA: 0x005399D0 File Offset: 0x00537BD0
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.OnRacingBetsDataInit));
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDoneAndCloseLoading));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.HandleRacingBetsFrameViewShow));
		EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeon, new Action(this.OnLeaveDungeon));
	}

	// Token: 0x06011BAD RID: 72621 RVA: 0x00539A50 File Offset: 0x00537C50
	protected override bool OnClear()
	{
		this.IsShowDangoFrameTipView = false;
		if (this.RefreshOddsTimeTimers != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.RefreshOddsTimeTimers);
			this.RefreshOddsTimeTimers = null;
		}
		if (this.LegMatchStateChangeTimer != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.LegMatchStateChangeTimer);
			this.LegMatchStateChangeTimer = null;
		}
		return true;
	}

	// Token: 0x06011BAE RID: 72622 RVA: 0x00539AA5 File Offset: 0x00537CA5
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.RacingBetsDangoActivityOpenTips, null, null);
	}

	// Token: 0x06011BAF RID: 72623 RVA: 0x00539AB8 File Offset: 0x00537CB8
	private void WorldDoneAndCloseLoading()
	{
		if (!GameModeController.Instance.IsInInstance())
		{
			return;
		}
		int instanceId = CreatureModel.Instance.GetInstanceId();
		InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
		InstanceDungeon? instanceDungeon = (instance != null) ? instance.GetConfig(instanceId) : null;
		if (instanceDungeon == null || instanceDungeon.Value.InstSubType != 31)
		{
			return;
		}
		int consoleVariableIntValue = UKismetSystemLibrary.GetConsoleVariableIntValue("r.RayTracing.Shadows");
		int consoleVariableIntValue2 = UKismetSystemLibrary.GetConsoleVariableIntValue("r.NGX.DLSS.Enable");
		RacingBetsModel.Instance.SetVisionValue(consoleVariableIntValue, consoleVariableIntValue2);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.RayTracing.Shadows 0", null);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.NGX.DLSS.Enable 0", null);
	}

	// Token: 0x06011BB0 RID: 72624 RVA: 0x00539B5C File Offset: 0x00537D5C
	private void HandleRacingBetsFrameViewShow()
	{
		if (!GameModeController.Instance.IsInInstance())
		{
			if (this.IsShowDangoFrameTipView)
			{
				UiManager.Instance.CloseView(EUiViewName.RacingBetsDangoFrameTipView, null);
				this.IsShowDangoFrameTipView = false;
			}
			return;
		}
		int instanceId = CreatureModel.Instance.GetInstanceId();
		InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
		InstanceDungeon? instanceDungeon = (instance != null) ? instance.GetConfig(instanceId) : null;
		if (instanceDungeon == null || instanceDungeon.Value.InstSubType != 31)
		{
			if (this.IsShowDangoFrameTipView)
			{
				UiManager.Instance.CloseView(EUiViewName.RacingBetsDangoFrameTipView, null);
				this.IsShowDangoFrameTipView = false;
			}
			return;
		}
		BP_DiceOL_C bp_DiceOL_C = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("DiceBp").Value, ECollectActorType.UI) as BP_DiceOL_C;
		if (bp_DiceOL_C != null)
		{
			bp_DiceOL_C.SetActorHiddenInGame(true);
		}
		if (!this.IsShowDangoFrameTipView)
		{
			UiManager.Instance.OpenView(EUiViewName.RacingBetsDangoFrameTipView, null, null);
			this.IsShowDangoFrameTipView = true;
		}
	}

	// Token: 0x06011BB1 RID: 72625 RVA: 0x00539C44 File Offset: 0x00537E44
	private void OnLeaveDungeon()
	{
		if (RacingBetsModel.Instance.CheckInRacingBetsDungeon())
		{
			int rayTracingShadowsValue = RacingBetsModel.Instance.RayTracingShadowsValue;
			int dlssValue = RacingBetsModel.Instance.DlssValue;
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.RayTracing.Shadows ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(rayTracingShadowsValue);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			UObject world2 = GlobalData.World;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.NGX.DLSS.Enable ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(dlssValue);
			UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
		}
	}

	// Token: 0x06011BB2 RID: 72626 RVA: 0x00539CD3 File Offset: 0x00537ED3
	private void OnRacingBetsDataInit(RacingBetsSeasonData seasonData)
	{
		this.TryRegisterNextDangoOddsUpdateRequest(seasonData);
		this.TryRegisterLegMatchStateChange(seasonData);
	}

	// Token: 0x06011BB3 RID: 72627 RVA: 0x00539CE4 File Offset: 0x00537EE4
	public void TryRegisterNextDangoOddsUpdateRequest(RacingBetsSeasonData seasonData)
	{
		RacingBetsLegMatchData curLegMatchData = seasonData.GetCurLegMatchData();
		if (curLegMatchData == null)
		{
			return;
		}
		double num = curLegMatchData.NextOddsRateRefreshTime - TimeUtil.Instance.GetServerTimeStamp();
		if (num < 0.0)
		{
			return;
		}
		if (this.RefreshOddsTimeTimers != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.RefreshOddsTimeTimers);
			this.RefreshOddsTimeTimers = null;
		}
		this.RefreshOddsTimeTimers = TimerSystem.RealTimeInstance.Delay(new TTimerAction(this.RacingBetsUpdateOddsRequest), (float)num, null, null, false, 1f);
	}

	// Token: 0x06011BB4 RID: 72628 RVA: 0x00539D64 File Offset: 0x00537F64
	public void TryRegisterLegMatchStateChange(RacingBetsSeasonData seasonData)
	{
		if (seasonData == null)
		{
			return;
		}
		RacingBetsLegMatchData curLegMatchData = seasonData.GetCurLegMatchData();
		if (curLegMatchData == null)
		{
			return;
		}
		double num = TimeUtil.Instance.SetTimeMillisecond(curLegMatchData.GetLegRemindTime());
		if (num <= 0.0)
		{
			return;
		}
		if (this.LegMatchStateChangeTimer != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.LegMatchStateChangeTimer);
			this.LegMatchStateChangeTimer = null;
		}
		this.LegMatchStateChangeTimer = TimerSystem.RealTimeInstance.Delay(new TTimerAction(this.OnLegMatchStateChange), (float)num, null, null, false, 1f);
	}

	// Token: 0x06011BB5 RID: 72629 RVA: 0x00539DE4 File Offset: 0x00537FE4
	public void TryStartRacingBetsGaming(int legMatchId)
	{
		if (ConfirmBoxController.Instance.CheckIsConfirmBoxOpen())
		{
			return;
		}
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		RacingBetsLegMatchData racingBetsLegMatchData = RacingBetsModel.Instance.GetRacingBetsLegMatchData(legMatchId);
		if (racingBetsLegMatchData == null || racingBetsSeasonData == null)
		{
			return;
		}
		ERacingBetsLegMatchState legMatchState = racingBetsLegMatchData.GetLegMatchState();
		if (RacingBetsModel.Instance.GetIsFromActivityOpenDungeon() && legMatchState == ERacingBetsLegMatchState.MatchPeriod)
		{
			this.RacingBetMatchActionRequest(racingBetsSeasonData.Id, racingBetsLegMatchData.Id);
			LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.RacingBetsWatchGameRecord, racingBetsLegMatchData.Id);
		}
	}

	// Token: 0x06011BB6 RID: 72630 RVA: 0x00539E58 File Offset: 0x00538058
	private void OnLegMatchStateChange(float _)
	{
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		if (racingBetsSeasonData == null)
		{
			return;
		}
		this.TryRegisterLegMatchStateChange(racingBetsSeasonData);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, racingBetsSeasonData.Id);
	}

	// Token: 0x06011BB7 RID: 72631 RVA: 0x00539E94 File Offset: 0x00538094
	public bool TryOpenRacingBetsLegMatchResultView()
	{
		RacingBetLegMatchResultNotify legMatchResultData = RacingBetsModel.Instance.GetLegMatchResultData();
		if (legMatchResultData == null)
		{
			return false;
		}
		if (legMatchResultData.BetDangoRank == 1)
		{
			UiManager.Instance.OpenView(EUiViewName.RacingBetsSuccessTip, legMatchResultData, null);
		}
		else
		{
			UiManager.Instance.OpenView(EUiViewName.RacingBetsFailTip, legMatchResultData, null);
		}
		RacingBetsModel.Instance.SetLegMatchResultData(null);
		return true;
	}

	// Token: 0x06011BB8 RID: 72632 RVA: 0x00539EEC File Offset: 0x005380EC
	public void TryLeaveRacingBetsDungeon()
	{
		if (!RacingBetsModel.Instance.CheckInRacingBetsDungeon())
		{
			return;
		}
		if (RacingBetsModel.Instance.IsDungeonPlaying)
		{
			RacingBetsModel.Instance.LeaveDungeonOnEnd = true;
			RacingBetsModel.Instance.RacingBetsAbortDungeon();
			return;
		}
		InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default).Forget<bool>();
	}

	// Token: 0x06011BB9 RID: 72633 RVA: 0x00539F38 File Offset: 0x00538138
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.RacingBetsPlayerInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRacingBetsPlayerInfoUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.RacingBetsTaskNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRacingBetsTaskNotify));
		Net.Instance.Register(ENotifyMessageId.RacingBetLegMatchResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRacingBetLegMatchResultNotify));
		Net.Instance.Register(ENotifyMessageId.RacingBetLegMatchSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRacingBetLegMatchSettleNotify));
	}

	// Token: 0x06011BBA RID: 72634 RVA: 0x00539FB8 File Offset: 0x005381B8
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.RacingBetsPlayerInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RacingBetsTaskNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RacingBetLegMatchResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RacingBetLegMatchSettleNotify);
	}

	// Token: 0x06011BBB RID: 72635 RVA: 0x0053A008 File Offset: 0x00538208
	public void RacingBetsGearRequest(int activityId, RacingBetsLegMatchData legMatchData, int dangoId, int gearId, int costCount)
	{
		RacingBetsGearRequest racingBetsGearRequest = Aki.Protocol.RacingBetsGearRequest.Create();
		racingBetsGearRequest.ActivityId = activityId;
		racingBetsGearRequest.LegMatchId = legMatchData.Id;
		racingBetsGearRequest.DangoId = dangoId;
		racingBetsGearRequest.GearId = gearId;
		racingBetsGearRequest.Cash = costCount;
		racingBetsGearRequest.OddsVersion = legMatchData.OddsVersion;
		Net.Instance.Call(ERequestMessageId.RacingBetsGearRequest, racingBetsGearRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RacingBetsGearResponse racingBetsGearResponse = (RacingBetsGearResponse)msg;
			if (racingBetsGearResponse == null)
			{
				return;
			}
			if (racingBetsGearResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetsGearResponse.ErrorCode, 29611, null, true, true);
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("Dango_BetPage_BetSuccess", Array.Empty<object>());
			RacingBetsModel.Instance.OnPlayerInfoUpdate(racingBetsGearResponse.PlayerInfo);
			EventSystem.Instance.Emit<int, bool>(EEventName.OnRacingBetsBettingInfoUpdate, dangoId, true);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}, 0);
	}

	// Token: 0x06011BBC RID: 72636 RVA: 0x0053A08C File Offset: 0x0053828C
	public void RacingBetsGearRefundRequest(int activityId, RacingBetsLegMatchData legMatchData, int dangoId)
	{
		RacingBetsGearRefundRequest racingBetsGearRefundRequest = Aki.Protocol.RacingBetsGearRefundRequest.Create();
		racingBetsGearRefundRequest.ActivityId = activityId;
		racingBetsGearRefundRequest.LegMatchId = legMatchData.Id;
		racingBetsGearRefundRequest.DangoId = dangoId;
		Net.Instance.Call(ERequestMessageId.RacingBetsGearRefundRequest, racingBetsGearRefundRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RacingBetsGearRefundResponse racingBetsGearRefundResponse = (RacingBetsGearRefundResponse)msg;
			if (racingBetsGearRefundResponse == null)
			{
				return;
			}
			if (racingBetsGearRefundResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetsGearRefundResponse.ErrorCode, 17259, null, true, true);
				return;
			}
			RacingBetsModel.Instance.OnPlayerInfoUpdate(racingBetsGearRefundResponse.PlayerInfo);
			ScrollingTipsController.Instance.ShowTipsByTextId("Dango_BetPage_CancelSuccess", Array.Empty<object>());
			EventSystem.Instance.Emit<int, bool>(EEventName.OnRacingBetsBettingInfoUpdate, dangoId, false);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}, 0);
	}

	// Token: 0x06011BBD RID: 72637 RVA: 0x0053A0F4 File Offset: 0x005382F4
	[NullableContext(2)]
	public void RacingBetsRankRequest(int activityId, Action callback = null)
	{
		RacingBetsRankRequest racingBetsRankRequest = Aki.Protocol.RacingBetsRankRequest.Create();
		racingBetsRankRequest.ActivityId = activityId;
		Net.Instance.Call(ERequestMessageId.RacingBetsRankRequest, racingBetsRankRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RacingBetsRankResponse racingBetsRankResponse = (RacingBetsRankResponse)msg;
			if (racingBetsRankResponse == null)
			{
				return;
			}
			if (racingBetsRankResponse.ErrorCode == Aki.Protocol.ErrorCode.RacingBetsBulletNotFundOpenRankCurTime)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Dango_RankPage_EmptyInfo", Array.Empty<object>());
				return;
			}
			if (racingBetsRankResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetsRankResponse.ErrorCode, 21901, null, true, true);
				return;
			}
			RacingBetsModel.Instance.RacingBetsRankRefresh(racingBetsRankResponse);
			Action callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2();
		}, 0);
	}

	// Token: 0x06011BBE RID: 72638 RVA: 0x0053A138 File Offset: 0x00538338
	public void RacingBetsTaskRewardRequest(int taskId)
	{
		RacingBetsTaskRewardRequest racingBetsTaskRewardRequest = Aki.Protocol.RacingBetsTaskRewardRequest.Create();
		racingBetsTaskRewardRequest.TaskId = taskId;
		Net.Instance.Call(ERequestMessageId.RacingBetsTaskRewardRequest, racingBetsTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RacingBetsTaskRewardResponse racingBetsTaskRewardResponse = (RacingBetsTaskRewardResponse)msg;
			if (racingBetsTaskRewardResponse == null)
			{
				return;
			}
			if (racingBetsTaskRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetsTaskRewardResponse.ErrorCode, 20940, null, true, true);
			}
			int id = RacingBetsModel.Instance.GetRacingBetsSeasonData().Id;
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, id);
		}, 0);
	}

	// Token: 0x06011BBF RID: 72639 RVA: 0x0053A184 File Offset: 0x00538384
	public void RacingBetsUpdateOddsRequest(float _)
	{
		RacingBetsUpdateOddsRequest racingBetsUpdateOddsRequest = Aki.Protocol.RacingBetsUpdateOddsRequest.Create();
		RacingBetsSeasonData seasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		RacingBetsLegMatchData curLegMatchData = seasonData.GetCurLegMatchData();
		racingBetsUpdateOddsRequest.ActivityId = seasonData.Id;
		racingBetsUpdateOddsRequest.LegMatchId = curLegMatchData.Id;
		Net.Instance.Call(ERequestMessageId.RacingBetsUpdateOddsRequest, racingBetsUpdateOddsRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RacingBetsUpdateOddsResponse racingBetsUpdateOddsResponse = (RacingBetsUpdateOddsResponse)msg;
			if (racingBetsUpdateOddsResponse == null)
			{
				return;
			}
			if (racingBetsUpdateOddsResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetsUpdateOddsResponse.ErrorCode, 19078, null, true, true);
				return;
			}
			RacingBetsModel.Instance.OnRacingBetsOddsUpdate(racingBetsUpdateOddsResponse);
			this.TryRegisterNextDangoOddsUpdateRequest(seasonData);
			EventSystem.Instance.Emit(EEventName.OnRacingBetsDangoOddsUpdate);
		}, 0);
	}

	// Token: 0x06011BC0 RID: 72640 RVA: 0x0053A1FC File Offset: 0x005383FC
	[NullableContext(2)]
	private void OnRacingBetsPlayerInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RacingBetsPlayerInfoUpdateNotify racingBetsPlayerInfoUpdateNotify = (RacingBetsPlayerInfoUpdateNotify)msg;
		RacingBetsModel.Instance.OnPlayerInfoUpdate(racingBetsPlayerInfoUpdateNotify.PlayerInfo);
		EventSystem.Instance.Emit(EEventName.OnRacingBetsPlayerInfoUpdate);
	}

	// Token: 0x06011BC1 RID: 72641 RVA: 0x0053A230 File Offset: 0x00538430
	[NullableContext(2)]
	private void OnRacingBetsTaskNotify(IMessage msg, Net.CallbackStatus status)
	{
		RacingBetsTaskNotify message = (RacingBetsTaskNotify)msg;
		RacingBetsModel.Instance.OnRacingBetsTaskNotify(message);
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		if (racingBetsSeasonData == null)
		{
			return;
		}
		EventSystem.Instance.Emit(EEventName.OnRacingBetsRewardRefresh);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, racingBetsSeasonData.Id);
	}

	// Token: 0x06011BC2 RID: 72642 RVA: 0x0053A284 File Offset: 0x00538484
	[NullableContext(2)]
	private void OnRacingBetLegMatchResultNotify(IMessage msg, Net.CallbackStatus status)
	{
		RacingBetLegMatchResultNotify message = (RacingBetLegMatchResultNotify)msg;
		RacingBetsModel.Instance.OnRacingBetsMatchResultNotify(message);
	}

	// Token: 0x06011BC3 RID: 72643 RVA: 0x0053A2A4 File Offset: 0x005384A4
	[NullableContext(2)]
	private void OnRacingBetLegMatchSettleNotify(IMessage msg, Net.CallbackStatus status)
	{
		RacingBetLegMatchSettleNotify racingBetLegMatchSettleNotify = (RacingBetLegMatchSettleNotify)msg;
		RacingBetsModel.Instance.RefreshLegMatchResult(racingBetLegMatchSettleNotify.Result);
		EventSystem.Instance.Emit<int>(EEventName.OnRacingBetsLegMatchEnd, racingBetLegMatchSettleNotify.Result.LegMatchId);
	}

	// Token: 0x06011BC4 RID: 72644 RVA: 0x0053A2E4 File Offset: 0x005384E4
	public void RacingBetMatchActionRequest(int activityId, int legMatchId)
	{
		RacingBetMatchActionRequest racingBetMatchActionRequest = Aki.Protocol.RacingBetMatchActionRequest.Create();
		racingBetMatchActionRequest.ActivityId = activityId;
		racingBetMatchActionRequest.LegMatchId = legMatchId;
		Net.Instance.Call(ERequestMessageId.RacingBetMatchActionRequest, racingBetMatchActionRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RacingBetMatchActionResponse racingBetMatchActionResponse = (RacingBetMatchActionResponse)msg;
			if (racingBetMatchActionResponse == null)
			{
				return;
			}
			if (racingBetMatchActionResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetMatchActionResponse.ErrorCode, 23348, null, true, true);
				return;
			}
			RacingBetsModel.Instance.RacingBetsMatchStart(legMatchId, racingBetMatchActionResponse);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}, 0);
	}

	// Token: 0x06011BC5 RID: 72645 RVA: 0x0053A340 File Offset: 0x00538540
	[NullableContext(0)]
	public UniTask<bool> RacingBetsMatchRoundActionRequestAsync(int activityId, int legMatchId, int roundId)
	{
		RacingBetsController.<RacingBetsMatchRoundActionRequestAsync>d__35 <RacingBetsMatchRoundActionRequestAsync>d__;
		<RacingBetsMatchRoundActionRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RacingBetsMatchRoundActionRequestAsync>d__.activityId = activityId;
		<RacingBetsMatchRoundActionRequestAsync>d__.legMatchId = legMatchId;
		<RacingBetsMatchRoundActionRequestAsync>d__.roundId = roundId;
		<RacingBetsMatchRoundActionRequestAsync>d__.<>1__state = -1;
		<RacingBetsMatchRoundActionRequestAsync>d__.<>t__builder.Start<RacingBetsController.<RacingBetsMatchRoundActionRequestAsync>d__35>(ref <RacingBetsMatchRoundActionRequestAsync>d__);
		return <RacingBetsMatchRoundActionRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011BC6 RID: 72646 RVA: 0x0053A394 File Offset: 0x00538594
	public void RacingBetsMatchInfoRequest(int activityId, int legMatchId)
	{
		RacingBetMatchInfoRequest racingBetMatchInfoRequest = RacingBetMatchInfoRequest.Create();
		racingBetMatchInfoRequest.ActivityId = activityId;
		racingBetMatchInfoRequest.LegMatchId = legMatchId;
		Net.Instance.Call(ERequestMessageId.RacingBetMatchInfoRequest, racingBetMatchInfoRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RacingBetMatchInfoResponse racingBetMatchInfoResponse = (RacingBetMatchInfoResponse)msg;
			if (racingBetMatchInfoResponse == null)
			{
				return;
			}
			if (racingBetMatchInfoResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetMatchInfoResponse.ErrorCode, 23023, null, true, true);
				return;
			}
			RacingBetsModel.Instance.RacingBetsMatchPreview(legMatchId, racingBetMatchInfoResponse);
		}, 0);
	}

	// Token: 0x06011BC7 RID: 72647 RVA: 0x0053A3E4 File Offset: 0x005385E4
	public void RacingBetsRepeatedTaskRewardRequest(List<int> taskId)
	{
		RacingBetsRepeatedTaskRewardRequest racingBetsRepeatedTaskRewardRequest = Aki.Protocol.RacingBetsRepeatedTaskRewardRequest.Create();
		racingBetsRepeatedTaskRewardRequest.TaskId.AddRange(taskId);
		Net.Instance.Call(ERequestMessageId.RacingBetsRepeatedTaskRewardRequest, racingBetsRepeatedTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RacingBetsRepeatedTaskRewardResponse racingBetsRepeatedTaskRewardResponse = (RacingBetsRepeatedTaskRewardResponse)msg;
			if (racingBetsRepeatedTaskRewardResponse == null)
			{
				return;
			}
			if (racingBetsRepeatedTaskRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetsRepeatedTaskRewardResponse.ErrorCode, 22994, null, true, true);
			}
			int id = RacingBetsModel.Instance.GetRacingBetsSeasonData().Id;
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, id);
		}, 0);
	}

	// Token: 0x06011BC8 RID: 72648 RVA: 0x0053A434 File Offset: 0x00538634
	public void RacingBetsCloseSettleMenuRequest(int legMatchId)
	{
		RacingBetsCloseSettleMenuRequest racingBetsCloseSettleMenuRequest = Aki.Protocol.RacingBetsCloseSettleMenuRequest.Create();
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		racingBetsCloseSettleMenuRequest.ActivityId = racingBetsSeasonData.Id;
		racingBetsCloseSettleMenuRequest.LegMatchId = legMatchId;
		Net.Instance.Call(ERequestMessageId.RacingBetsCloseSettleMenuRequest, racingBetsCloseSettleMenuRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RacingBetsCloseSettleMenuResponse racingBetsCloseSettleMenuResponse = (RacingBetsCloseSettleMenuResponse)msg;
			if (racingBetsCloseSettleMenuResponse == null)
			{
				return;
			}
			if (racingBetsCloseSettleMenuResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetsCloseSettleMenuResponse.ErrorCode, 23836, null, true, true);
				return;
			}
			RacingBetsModel.Instance.OnRacingBetsCloseSettleMenu(legMatchId);
		}, 0);
	}

	// Token: 0x06011BC9 RID: 72649 RVA: 0x0053A494 File Offset: 0x00538694
	public UniTask RacingBetsMatchInfoRequestAsync(int activityId)
	{
		RacingBetsController.<RacingBetsMatchInfoRequestAsync>d__39 <RacingBetsMatchInfoRequestAsync>d__;
		<RacingBetsMatchInfoRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RacingBetsMatchInfoRequestAsync>d__.activityId = activityId;
		<RacingBetsMatchInfoRequestAsync>d__.<>1__state = -1;
		<RacingBetsMatchInfoRequestAsync>d__.<>t__builder.Start<RacingBetsController.<RacingBetsMatchInfoRequestAsync>d__39>(ref <RacingBetsMatchInfoRequestAsync>d__);
		return <RacingBetsMatchInfoRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011BCA RID: 72650 RVA: 0x0053A4D8 File Offset: 0x005386D8
	public void RacingBetsBulletScreenRequest(int bulletScreenId)
	{
		RacingBetsBulletScreenRequest racingBetsBulletScreenRequest = Aki.Protocol.RacingBetsBulletScreenRequest.Create();
		RacingBetsSeasonData racingBetsSeasonData = RacingBetsModel.Instance.GetRacingBetsSeasonData();
		racingBetsBulletScreenRequest.ActivityId = racingBetsSeasonData.Id;
		racingBetsBulletScreenRequest.LegMatchId = RacingBetsModel.Instance.DungeonMatchId;
		racingBetsBulletScreenRequest.BulletScreenId = bulletScreenId;
		racingBetsBulletScreenRequest.ActionIndex = RacingBetsModel.Instance.GetCommandActionIndex();
		Net.Instance.Call(ERequestMessageId.RacingBetsBulletScreenRequest, racingBetsBulletScreenRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RacingBetsBulletScreenResponse racingBetsBulletScreenResponse = (RacingBetsBulletScreenResponse)msg;
			if (racingBetsBulletScreenResponse == null)
			{
				return;
			}
			if (racingBetsBulletScreenResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetsBulletScreenResponse.ErrorCode, 19809, null, true, true);
				return;
			}
			EventSystem.Instance.Emit<IReadOnlyList<int>, bool>(EEventName.OnRacingBetsPushBulletScreen, new List<int>
			{
				bulletScreenId
			}, true);
		}, 0);
	}

	// Token: 0x17001AC9 RID: 6857
	// (get) Token: 0x06011BCB RID: 72651 RVA: 0x0053A558 File Offset: 0x00538758
	public static RacingBetsController Instance
	{
		get
		{
			return RacingBetsController._Instance;
		}
	}

	// Token: 0x06011BCC RID: 72652 RVA: 0x0053A55F File Offset: 0x0053875F
	public static RacingBetsController GetOrCreateInstance()
	{
		if (RacingBetsController._Instance == null)
		{
			RacingBetsController.CreateInstance();
		}
		return RacingBetsController._Instance;
	}

	// Token: 0x06011BCD RID: 72653 RVA: 0x0053A573 File Offset: 0x00538773
	public static bool CreateInstance()
	{
		if (RacingBetsController._Instance != null)
		{
			return true;
		}
		RacingBetsController._Instance = new RacingBetsController();
		return true;
	}

	// Token: 0x06011BCE RID: 72654 RVA: 0x0053A589 File Offset: 0x00538789
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011BCF RID: 72655 RVA: 0x0053A58B File Offset: 0x0053878B
	public static void ResetStaticDefaultValue()
	{
		RacingBetsController._Instance = null;
	}

	// Token: 0x06011BD0 RID: 72656 RVA: 0x0053A593 File Offset: 0x00538793
	static RacingBetsController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RacingBetsController.CreateStaticDefaultValue), new Action(RacingBetsController.ResetStaticDefaultValue));
	}

	// Token: 0x04009ABE RID: 39614
	private bool IsShowDangoFrameTipView;

	// Token: 0x04009ABF RID: 39615
	[Nullable(2)]
	private TimerHandle RefreshOddsTimeTimers;

	// Token: 0x04009AC0 RID: 39616
	[Nullable(2)]
	private TimerHandle LegMatchStateChangeTimer;

	// Token: 0x04009AC1 RID: 39617
	[Nullable(2)]
	private static RacingBetsController _Instance;
}
