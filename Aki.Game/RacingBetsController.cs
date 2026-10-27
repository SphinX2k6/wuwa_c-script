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

// Token: 0x020026E1 RID: 9953
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RacingBetsController : ActivityControllerBase
{
	// Token: 0x060146C3 RID: 83651 RVA: 0x0052ABF5 File Offset: 0x00528DF5
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060146C4 RID: 83652 RVA: 0x0052ABF7 File Offset: 0x00528DF7
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_RaceHorseGuide";
	}

	// Token: 0x060146C5 RID: 83653 RVA: 0x0052ABFE File Offset: 0x00528DFE
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new RacingBetsActivityView();
	}

	// Token: 0x060146C6 RID: 83654 RVA: 0x0052AC08 File Offset: 0x00528E08
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		RacingBetsSeasonData racingBetsSeasonData = new RacingBetsSeasonData();
		RacingBetsModel.Instance.SetRacingBetsSeasonData(racingBetsSeasonData);
		return racingBetsSeasonData;
	}

	// Token: 0x060146C7 RID: 83655 RVA: 0x0052AC27 File Offset: 0x00528E27
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x060146C8 RID: 83656 RVA: 0x0052AC2A File Offset: 0x00528E2A
	protected override bool OnInit()
	{
		this.IsShowDangoFrameTipView = false;
		return true;
	}

	// Token: 0x060146C9 RID: 83657 RVA: 0x0052AC34 File Offset: 0x00528E34
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<RacingBetsSeasonData>(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.OnRacingBetsDataInit));
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDoneAndCloseLoading));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.HandleRacingBetsFrameViewShow));
		EventSystem.Instance.Add(EEventName.LeaveInstanceDungeon, new Action(this.OnLeaveDungeon));
	}

	// Token: 0x060146CA RID: 83658 RVA: 0x0052ACB4 File Offset: 0x00528EB4
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDataRefresh, new Action<RacingBetsSeasonData>(this.OnRacingBetsDataInit));
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.WorldDoneAndCloseLoading));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.HandleRacingBetsFrameViewShow));
		EventSystem.Instance.Remove(EEventName.LeaveInstanceDungeon, new Action(this.OnLeaveDungeon));
	}

	// Token: 0x060146CB RID: 83659 RVA: 0x0052AD34 File Offset: 0x00528F34
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

	// Token: 0x060146CC RID: 83660 RVA: 0x0052AD89 File Offset: 0x00528F89
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.RacingBetsDangoActivityOpenTips, null, null);
	}

	// Token: 0x060146CD RID: 83661 RVA: 0x0052AD9C File Offset: 0x00528F9C
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

	// Token: 0x060146CE RID: 83662 RVA: 0x0052AE40 File Offset: 0x00529040
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

	// Token: 0x060146CF RID: 83663 RVA: 0x0052AF28 File Offset: 0x00529128
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

	// Token: 0x060146D0 RID: 83664 RVA: 0x0052AFB7 File Offset: 0x005291B7
	private void OnRacingBetsDataInit(RacingBetsSeasonData seasonData)
	{
		this.TryRegisterNextDangoOddsUpdateRequest(seasonData);
		this.TryRegisterLegMatchStateChange(seasonData);
	}

	// Token: 0x060146D1 RID: 83665 RVA: 0x0052AFC8 File Offset: 0x005291C8
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

	// Token: 0x060146D2 RID: 83666 RVA: 0x0052B048 File Offset: 0x00529248
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

	// Token: 0x060146D3 RID: 83667 RVA: 0x0052B0C8 File Offset: 0x005292C8
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

	// Token: 0x060146D4 RID: 83668 RVA: 0x0052B13C File Offset: 0x0052933C
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

	// Token: 0x060146D5 RID: 83669 RVA: 0x0052B178 File Offset: 0x00529378
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

	// Token: 0x060146D6 RID: 83670 RVA: 0x0052B1D0 File Offset: 0x005293D0
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

	// Token: 0x060146D7 RID: 83671 RVA: 0x0052B21C File Offset: 0x0052941C
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.RacingBetsPlayerInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRacingBetsPlayerInfoUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.RacingBetsTaskNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRacingBetsTaskNotify));
		Net.Instance.Register(ENotifyMessageId.RacingBetLegMatchResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRacingBetLegMatchResultNotify));
		Net.Instance.Register(ENotifyMessageId.RacingBetLegMatchSettleNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRacingBetLegMatchSettleNotify));
	}

	// Token: 0x060146D8 RID: 83672 RVA: 0x0052B29C File Offset: 0x0052949C
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.RacingBetsPlayerInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RacingBetsTaskNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RacingBetLegMatchResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RacingBetLegMatchSettleNotify);
	}

	// Token: 0x060146D9 RID: 83673 RVA: 0x0052B2EC File Offset: 0x005294EC
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetsGearResponse.ErrorCode, 26722, null, true, true);
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("Dango_BetPage_BetSuccess", Array.Empty<object>());
			RacingBetsModel.Instance.OnPlayerInfoUpdate(racingBetsGearResponse.PlayerInfo);
			EventSystem.Instance.Emit<int, bool>(EEventName.OnRacingBetsBettingInfoUpdate, dangoId, true);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}, 0);
	}

	// Token: 0x060146DA RID: 83674 RVA: 0x0052B370 File Offset: 0x00529570
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetsGearRefundResponse.ErrorCode, 16117, null, true, true);
				return;
			}
			RacingBetsModel.Instance.OnPlayerInfoUpdate(racingBetsGearRefundResponse.PlayerInfo);
			ScrollingTipsController.Instance.ShowTipsByTextId("Dango_BetPage_CancelSuccess", Array.Empty<object>());
			EventSystem.Instance.Emit<int, bool>(EEventName.OnRacingBetsBettingInfoUpdate, dangoId, false);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}, 0);
	}

	// Token: 0x060146DB RID: 83675 RVA: 0x0052B3D8 File Offset: 0x005295D8
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetsRankResponse.ErrorCode, 28404, null, true, true);
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

	// Token: 0x060146DC RID: 83676 RVA: 0x0052B41C File Offset: 0x0052961C
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetsTaskRewardResponse.ErrorCode, 18798, null, true, true);
			}
			int id = RacingBetsModel.Instance.GetRacingBetsSeasonData().Id;
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, id);
		}, 0);
	}

	// Token: 0x060146DD RID: 83677 RVA: 0x0052B468 File Offset: 0x00529668
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetsUpdateOddsResponse.ErrorCode, 16685, null, true, true);
				return;
			}
			RacingBetsModel.Instance.OnRacingBetsOddsUpdate(racingBetsUpdateOddsResponse);
			this.TryRegisterNextDangoOddsUpdateRequest(seasonData);
			EventSystem.Instance.Emit(EEventName.OnRacingBetsDangoOddsUpdate);
		}, 0);
	}

	// Token: 0x060146DE RID: 83678 RVA: 0x0052B4E0 File Offset: 0x005296E0
	[NullableContext(2)]
	private void OnRacingBetsPlayerInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RacingBetsPlayerInfoUpdateNotify racingBetsPlayerInfoUpdateNotify = (RacingBetsPlayerInfoUpdateNotify)msg;
		RacingBetsModel.Instance.OnPlayerInfoUpdate(racingBetsPlayerInfoUpdateNotify.PlayerInfo);
		EventSystem.Instance.Emit(EEventName.OnRacingBetsPlayerInfoUpdate);
	}

	// Token: 0x060146DF RID: 83679 RVA: 0x0052B514 File Offset: 0x00529714
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

	// Token: 0x060146E0 RID: 83680 RVA: 0x0052B568 File Offset: 0x00529768
	[NullableContext(2)]
	private void OnRacingBetLegMatchResultNotify(IMessage msg, Net.CallbackStatus status)
	{
		RacingBetLegMatchResultNotify message = (RacingBetLegMatchResultNotify)msg;
		RacingBetsModel.Instance.OnRacingBetsMatchResultNotify(message);
	}

	// Token: 0x060146E1 RID: 83681 RVA: 0x0052B588 File Offset: 0x00529788
	[NullableContext(2)]
	private void OnRacingBetLegMatchSettleNotify(IMessage msg, Net.CallbackStatus status)
	{
		RacingBetLegMatchSettleNotify racingBetLegMatchSettleNotify = (RacingBetLegMatchSettleNotify)msg;
		RacingBetsModel.Instance.RefreshLegMatchResult(racingBetLegMatchSettleNotify.Result);
		EventSystem.Instance.Emit<int>(EEventName.OnRacingBetsLegMatchEnd, racingBetLegMatchSettleNotify.Result.LegMatchId);
	}

	// Token: 0x060146E2 RID: 83682 RVA: 0x0052B5C8 File Offset: 0x005297C8
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetMatchActionResponse.ErrorCode, 25269, null, true, true);
				return;
			}
			RacingBetsModel.Instance.RacingBetsMatchStart(legMatchId, racingBetMatchActionResponse);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}, 0);
	}

	// Token: 0x060146E3 RID: 83683 RVA: 0x0052B624 File Offset: 0x00529824
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

	// Token: 0x060146E4 RID: 83684 RVA: 0x0052B678 File Offset: 0x00529878
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetMatchInfoResponse.ErrorCode, 22985, null, true, true);
				return;
			}
			RacingBetsModel.Instance.RacingBetsMatchPreview(legMatchId, racingBetMatchInfoResponse);
		}, 0);
	}

	// Token: 0x060146E5 RID: 83685 RVA: 0x0052B6C8 File Offset: 0x005298C8
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetsRepeatedTaskRewardResponse.ErrorCode, 15170, null, true, true);
			}
			int id = RacingBetsModel.Instance.GetRacingBetsSeasonData().Id;
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, id);
		}, 0);
	}

	// Token: 0x060146E6 RID: 83686 RVA: 0x0052B718 File Offset: 0x00529918
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetsCloseSettleMenuResponse.ErrorCode, 22872, null, true, true);
				return;
			}
			RacingBetsModel.Instance.OnRacingBetsCloseSettleMenu(legMatchId);
		}, 0);
	}

	// Token: 0x060146E7 RID: 83687 RVA: 0x0052B778 File Offset: 0x00529978
	public UniTask RacingBetsMatchInfoRequestAsync(int activityId)
	{
		RacingBetsController.<RacingBetsMatchInfoRequestAsync>d__39 <RacingBetsMatchInfoRequestAsync>d__;
		<RacingBetsMatchInfoRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RacingBetsMatchInfoRequestAsync>d__.activityId = activityId;
		<RacingBetsMatchInfoRequestAsync>d__.<>1__state = -1;
		<RacingBetsMatchInfoRequestAsync>d__.<>t__builder.Start<RacingBetsController.<RacingBetsMatchInfoRequestAsync>d__39>(ref <RacingBetsMatchInfoRequestAsync>d__);
		return <RacingBetsMatchInfoRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060146E8 RID: 83688 RVA: 0x0052B7BC File Offset: 0x005299BC
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(racingBetsBulletScreenResponse.ErrorCode, 26542, null, true, true);
				return;
			}
			EventSystem.Instance.Emit<IReadOnlyList<int>, bool>(EEventName.OnRacingBetsPushBulletScreen, new List<int>
			{
				bulletScreenId
			}, true);
		}, 0);
	}

	// Token: 0x17001A91 RID: 6801
	// (get) Token: 0x060146E9 RID: 83689 RVA: 0x0052B83C File Offset: 0x00529A3C
	public static RacingBetsController Instance
	{
		get
		{
			return RacingBetsController._Instance;
		}
	}

	// Token: 0x060146EA RID: 83690 RVA: 0x0052B843 File Offset: 0x00529A43
	public static RacingBetsController GetOrCreateInstance()
	{
		if (RacingBetsController._Instance == null)
		{
			RacingBetsController.CreateInstance();
		}
		return RacingBetsController._Instance;
	}

	// Token: 0x060146EB RID: 83691 RVA: 0x0052B857 File Offset: 0x00529A57
	public static bool CreateInstance()
	{
		if (RacingBetsController._Instance != null)
		{
			return true;
		}
		RacingBetsController._Instance = new RacingBetsController();
		return true;
	}

	// Token: 0x060146EC RID: 83692 RVA: 0x0052B86D File Offset: 0x00529A6D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060146ED RID: 83693 RVA: 0x0052B86F File Offset: 0x00529A6F
	public static void ResetStaticDefaultValue()
	{
		RacingBetsController._Instance = null;
	}

	// Token: 0x060146EE RID: 83694 RVA: 0x0052B877 File Offset: 0x00529A77
	static RacingBetsController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RacingBetsController.CreateStaticDefaultValue), new Action(RacingBetsController.ResetStaticDefaultValue));
	}

	// Token: 0x04009966 RID: 39270
	private bool IsShowDangoFrameTipView;

	// Token: 0x04009967 RID: 39271
	[Nullable(2)]
	private TimerHandle RefreshOddsTimeTimers;

	// Token: 0x04009968 RID: 39272
	[Nullable(2)]
	private TimerHandle LegMatchStateChangeTimer;

	// Token: 0x04009969 RID: 39273
	[Nullable(2)]
	private static RacingBetsController _Instance;
}
