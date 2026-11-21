using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006F1 RID: 1777
[NullableContext(2)]
[Nullable(0)]
public class DangoMonopolyMainView : DangoMonopolyViewBase
{
	// Token: 0x17000ADC RID: 2780
	// (get) Token: 0x060051EE RID: 20974 RVA: 0x001B48D4 File Offset: 0x001B2AD4
	public new DangoMonopolyMainViewParam OpenParam
	{
		get
		{
			return this.OpenParam as DangoMonopolyMainViewParam;
		}
	}

	// Token: 0x060051EF RID: 20975 RVA: 0x001B48E1 File Offset: 0x001B2AE1
	[NullableContext(1)]
	public DangoMonopolyMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060051F0 RID: 20976 RVA: 0x001B48EC File Offset: 0x001B2AEC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUISprite)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(14, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUIText)),
			new ValueTuple<int, Type>(23, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnSpeed)),
			new ValueTuple<int, Delegate>(8, new Action(this.OnClickBtnRoundRecord)),
			new ValueTuple<int, Delegate>(9, new Action(this.OnClickBtnDiceTask)),
			new ValueTuple<int, Delegate>(10, new Action(this.OnClickBtnUseDice)),
			new ValueTuple<int, Delegate>(23, new Action<EToggleState>(this.OnClickAngleOfView))
		};
	}

	// Token: 0x060051F1 RID: 20977 RVA: 0x001B4BA9 File Offset: 0x001B2DA9
	private void InitDataParam()
	{
	}

	// Token: 0x060051F2 RID: 20978 RVA: 0x001B4BAC File Offset: 0x001B2DAC
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyMainView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyMainView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060051F3 RID: 20979 RVA: 0x001B4BF0 File Offset: 0x001B2DF0
	protected override void OnStart()
	{
		if (this.ActivityData == null)
		{
			this.ActivityHide();
			return;
		}
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.UpdateAngleOfViewBtnState();
		EventSystem.Instance.Emit(EEventName.DangoMonopolyViewStart);
		this.CheckShowProcess().Forget();
		EventSystem.Instance.Add(EEventName.DangoMonopolyMoveStart, new Action(this.EventDangoMonopolyMoveStart));
	}

	// Token: 0x060051F4 RID: 20980 RVA: 0x001B4C5C File Offset: 0x001B2E5C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.DangoMonopolyBoardRewardUpdate, new Action(this.EventDangoMonopolyBoardRewardUpdate));
		EventSystem.Instance.Add(EEventName.OnCloseRewardView, new Action(this.EventOnCloseRewardView));
		EventSystem.Instance.Add(EEventName.DangoMonopolyStartShowProcess, new Action(this.EventDangoMonopolyStartShowProcess));
		EventSystem.Instance.Add(EEventName.DangoMonopolyEndShowProcess, new Action(this.EventDangoMonopolyEndShowProcess));
		RedDotController.Instance.BindRedDot(ERedDotName.DangoMonopolyTask, base.GetItem(19), null, 0);
		RedDotController.Instance.BindRedDot(ERedDotName.DangoMonopolyDiceNum, base.GetItem(20), new Action<bool, int>(this.UpdateDiceUseState), 0);
	}

	// Token: 0x060051F5 RID: 20981 RVA: 0x001B4D18 File Offset: 0x001B2F18
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.DangoMonopolyBoardRewardUpdate, new Action(this.EventDangoMonopolyBoardRewardUpdate));
		EventSystem.Instance.Remove(EEventName.OnCloseRewardView, new Action(this.EventOnCloseRewardView));
		EventSystem.Instance.Remove(EEventName.DangoMonopolyStartShowProcess, new Action(this.EventDangoMonopolyStartShowProcess));
		EventSystem.Instance.Remove(EEventName.DangoMonopolyEndShowProcess, new Action(this.EventDangoMonopolyEndShowProcess));
		RedDotController.Instance.UnBindRedDot(ERedDotName.DangoMonopolyTask);
		RedDotController.Instance.UnBindRedDot(ERedDotName.DangoMonopolyDiceNum);
	}

	// Token: 0x060051F6 RID: 20982 RVA: 0x001B4DB4 File Offset: 0x001B2FB4
	protected override void OnBeforeShow()
	{
		if (!base.UpdateActivityData())
		{
			this.ActivityHide();
			return;
		}
		this.PopupCaption.SetCurrencyItemList(new int[]
		{
			this.ActivityData.DiceItemId
		}).Forget();
		this.UpdateShowBoardData(this.ActivityData.CurrentBoardData);
		this.UpdateData();
		int num = 500;
		this.RefreshTimerHandle = TimerSystem.RealTimeInstance.Forever(new TTimerAction(this.OnTimerRefresh), (float)num, 1f, null, null, true);
	}

	// Token: 0x060051F7 RID: 20983 RVA: 0x001B4E37 File Offset: 0x001B3037
	public void OnTimerRefresh(float _)
	{
		this.CheckBoardUnlockTime();
	}

	// Token: 0x060051F8 RID: 20984 RVA: 0x001B4E3F File Offset: 0x001B303F
	public void CheckBoardUnlockTime()
	{
		if (this.ActivityData.IsRunningBoardLock() != this.IsBoardLock)
		{
			this.UpdateData();
		}
		this.UpdateBoardRemainTime();
	}

	// Token: 0x060051F9 RID: 20985 RVA: 0x001B4E60 File Offset: 0x001B3060
	public bool CheckActivityClose()
	{
		if (!this.ActivityData.CheckIfClose())
		{
			return false;
		}
		ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
		return true;
	}

	// Token: 0x060051FA RID: 20986 RVA: 0x001B4E7C File Offset: 0x001B307C
	public void ClearTimer()
	{
		if (this.RefreshTimerHandle != null && TimerSystem.RealTimeInstance.Has(this.RefreshTimerHandle))
		{
			TimerSystem.RealTimeInstance.Remove(this.RefreshTimerHandle);
			this.RefreshTimerHandle = null;
		}
	}

	// Token: 0x060051FB RID: 20987 RVA: 0x001B4EB0 File Offset: 0x001B30B0
	protected override void OnBeforeHide()
	{
		this.ClearTimer();
		this.SetBattleFloatVisible(false).Forget();
	}

	// Token: 0x060051FC RID: 20988 RVA: 0x001B4EC4 File Offset: 0x001B30C4
	protected override void OnAfterShow()
	{
		this.SetBattleFloatVisible(true).Forget();
	}

	// Token: 0x060051FD RID: 20989 RVA: 0x001B4ED4 File Offset: 0x001B30D4
	public UniTask SetBattleFloatVisible(bool visible)
	{
		DangoMonopolyMainView.<SetBattleFloatVisible>d__31 <SetBattleFloatVisible>d__;
		<SetBattleFloatVisible>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetBattleFloatVisible>d__.<>4__this = this;
		<SetBattleFloatVisible>d__.visible = visible;
		<SetBattleFloatVisible>d__.<>1__state = -1;
		<SetBattleFloatVisible>d__.<>t__builder.Start<DangoMonopolyMainView.<SetBattleFloatVisible>d__31>(ref <SetBattleFloatVisible>d__);
		return <SetBattleFloatVisible>d__.<>t__builder.Task;
	}

	// Token: 0x060051FE RID: 20990 RVA: 0x001B4F20 File Offset: 0x001B3120
	public UniTask CheckShowProcess()
	{
		DangoMonopolyMainView.<CheckShowProcess>d__32 <CheckShowProcess>d__;
		<CheckShowProcess>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckShowProcess>d__.<>4__this = this;
		<CheckShowProcess>d__.<>1__state = -1;
		<CheckShowProcess>d__.<>t__builder.Start<DangoMonopolyMainView.<CheckShowProcess>d__32>(ref <CheckShowProcess>d__);
		return <CheckShowProcess>d__.<>t__builder.Task;
	}

	// Token: 0x060051FF RID: 20991 RVA: 0x001B4F64 File Offset: 0x001B3164
	public UniTask CheckUpdateDangoPosition()
	{
		DangoMonopolyMainView.<CheckUpdateDangoPosition>d__33 <CheckUpdateDangoPosition>d__;
		<CheckUpdateDangoPosition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckUpdateDangoPosition>d__.<>4__this = this;
		<CheckUpdateDangoPosition>d__.<>1__state = -1;
		<CheckUpdateDangoPosition>d__.<>t__builder.Start<DangoMonopolyMainView.<CheckUpdateDangoPosition>d__33>(ref <CheckUpdateDangoPosition>d__);
		return <CheckUpdateDangoPosition>d__.<>t__builder.Task;
	}

	// Token: 0x06005200 RID: 20992 RVA: 0x001B4FA8 File Offset: 0x001B31A8
	public UniTask CheckShowInfo()
	{
		DangoMonopolyMainView.<CheckShowInfo>d__34 <CheckShowInfo>d__;
		<CheckShowInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckShowInfo>d__.<>4__this = this;
		<CheckShowInfo>d__.<>1__state = -1;
		<CheckShowInfo>d__.<>t__builder.Start<DangoMonopolyMainView.<CheckShowInfo>d__34>(ref <CheckShowInfo>d__);
		return <CheckShowInfo>d__.<>t__builder.Task;
	}

	// Token: 0x06005201 RID: 20993 RVA: 0x001B4FEC File Offset: 0x001B31EC
	public UniTask CheckWelcome(bool dangoPosShow = false)
	{
		DangoMonopolyMainView.<CheckWelcome>d__35 <CheckWelcome>d__;
		<CheckWelcome>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckWelcome>d__.<>4__this = this;
		<CheckWelcome>d__.dangoPosShow = dangoPosShow;
		<CheckWelcome>d__.<>1__state = -1;
		<CheckWelcome>d__.<>t__builder.Start<DangoMonopolyMainView.<CheckWelcome>d__35>(ref <CheckWelcome>d__);
		return <CheckWelcome>d__.<>t__builder.Task;
	}

	// Token: 0x06005202 RID: 20994 RVA: 0x001B5038 File Offset: 0x001B3238
	private void ActivityHide()
	{
		UUIButtonComponent button = base.GetButton(1);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(false);
		}
		UUIButtonComponent button2 = base.GetButton(8);
		if (button2 != null)
		{
			button2.RootUIComp.Get().SetUIActive(false);
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(23);
		if (extendToggle != null)
		{
			extendToggle.RootUIComp.Get().SetUIActive(false);
		}
		UUIItem item = base.GetItem(17);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(18);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x06005203 RID: 20995 RVA: 0x001B50CD File Offset: 0x001B32CD
	public void UpdateShowBoardData(DangoMonopolyBoardData boardData)
	{
		this.ShowBoardData = (boardData ?? this.ActivityData.BoardList[0]);
	}

	// Token: 0x06005204 RID: 20996 RVA: 0x001B50EC File Offset: 0x001B32EC
	protected override void OnBeforeDestroy()
	{
		this.ClearTimer();
		DangoMonopolyRoundRewardItem endRoundReward = this.EndRoundReward;
		if (endRoundReward != null)
		{
			endRoundReward.Destroy(null);
		}
		DangoMonopolyPosition dangoPosition = this.DangoPosition;
		if (dangoPosition != null)
		{
			dangoPosition.Destroy(null);
		}
		ActivityDangoMonopolyData activityData = this.ActivityData;
		if (activityData != null)
		{
			activityData.GameplayExit();
		}
		UiLayer.Instance.SetShowMaskLayer(EUiViewName.DangoMonopolyMainView.ToString(), false);
		InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default).Forget<bool>();
		EventSystem.Instance.Remove(EEventName.DangoMonopolyMoveStart, new Action(this.EventDangoMonopolyMoveStart));
		EventSystem.Instance.Emit(EEventName.LeaveInstanceDungeonConfirm);
		EventSystem.Instance.Emit(EEventName.LeaveInstanceExternalConfirm);
	}

	// Token: 0x06005205 RID: 20997 RVA: 0x001B519C File Offset: 0x001B339C
	private void CloseCallBack()
	{
		ActivityDangoMonopolyData activityData = this.ActivityData;
		if (activityData != null && activityData.IsDangoMoveProcess)
		{
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BattleViewLeaveInstance);
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		confirmBoxDataNew.FunctionMap.Add(1, delegate
		{
			EventSystem.Instance.Emit(EEventName.LeaveInstanceExternalCancel);
		});
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			base.CloseMe(null);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06005206 RID: 20998 RVA: 0x001B521B File Offset: 0x001B341B
	private void HelpCallback()
	{
		HelpController.Instance.OpenHelpById(290);
	}

	// Token: 0x06005207 RID: 20999 RVA: 0x001B522C File Offset: 0x001B342C
	private void OnClickBtnSpeed()
	{
		this.ActivityData.SetActivitySpeed(null);
		this.UpdateSpeed();
	}

	// Token: 0x06005208 RID: 21000 RVA: 0x001B5253 File Offset: 0x001B3453
	private void OnClickBtnRoundRecord()
	{
		this.ActivityData.OpenViewDangoMonopolyTransition(delegate
		{
			DangoMonopolyMainView.<<OnClickBtnRoundRecord>b__42_0>d <<OnClickBtnRoundRecord>b__42_0>d;
			<<OnClickBtnRoundRecord>b__42_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnClickBtnRoundRecord>b__42_0>d.<>4__this = this;
			<<OnClickBtnRoundRecord>b__42_0>d.<>1__state = -1;
			<<OnClickBtnRoundRecord>b__42_0>d.<>t__builder.Start<DangoMonopolyMainView.<<OnClickBtnRoundRecord>b__42_0>d>(ref <<OnClickBtnRoundRecord>b__42_0>d);
			return <<OnClickBtnRoundRecord>b__42_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x06005209 RID: 21001 RVA: 0x001B526C File Offset: 0x001B346C
	public void UpdateBtnRoundRecord()
	{
		bool uiactive = this.ActivityData.GetFinishedRoundNum() > 0;
		UUIButtonComponent button = base.GetButton(8);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x0600520A RID: 21002 RVA: 0x001B52A7 File Offset: 0x001B34A7
	private void OnClickBtnDiceTask()
	{
		if (this.CheckActivityClose())
		{
			return;
		}
		this.ActivityData.OpenViewDiceTask();
	}

	// Token: 0x0600520B RID: 21003 RVA: 0x001B52C0 File Offset: 0x001B34C0
	private void OnClickBtnUseDice()
	{
		if (this.CheckActivityClose())
		{
			return;
		}
		ActivityDangoMonopolyData activityData = this.ActivityData;
		if (activityData != null && activityData.IsExistGridReward())
		{
			return;
		}
		if (this.ActivityData.RequestUseDice())
		{
			return;
		}
		if (this.ActivityData.IsRunningBoardLock())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("DangoMonopoly_title_17", Array.Empty<object>());
			return;
		}
		this.OnClickBtnDiceTask();
	}

	// Token: 0x0600520C RID: 21004 RVA: 0x001B5321 File Offset: 0x001B3521
	[NullableContext(1)]
	private DangoMonopolyBuffStateItem CreateBuffItem()
	{
		return new DangoMonopolyBuffStateItem();
	}

	// Token: 0x0600520D RID: 21005 RVA: 0x001B5328 File Offset: 0x001B3528
	public void UpdateData()
	{
		ActivityDangoMonopolyData activityData = this.ActivityData;
		DangoMonopolyBoardData showBoardData = this.ShowBoardData;
		int value = (showBoardData != null) ? showBoardData.GetPosition() : 1;
		int totalRoundNum = activityData.GetTotalRoundNum();
		int finishedRoundNum = activityData.GetFinishedRoundNum();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(totalRoundNum);
		string newText = defaultInterpolatedStringHandler.ToStringAndClear();
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		string newText2 = defaultInterpolatedStringHandler.ToStringAndClear();
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetText(newText2, true);
		}
		UUIText text2 = base.GetText(12);
		if (text2 != null)
		{
			text2.SetText(finishedRoundNum.ToString(), true);
		}
		UUIText text3 = base.GetText(4);
		if (text3 != null)
		{
			text3.SetText(newText, true);
		}
		UUIText text4 = base.GetText(13);
		if (text4 != null)
		{
			text4.SetText(newText, true);
		}
		List<IDangoMonopolyRoundBuffData> buffItemData = this.GetBuffItemData();
		GenericLayout<DangoMonopolyBuffStateItem, IDangoMonopolyRoundBuffData> buffLayoutView = this.BuffLayoutView;
		if (buffLayoutView != null)
		{
			buffLayoutView.RefreshByData(buffItemData, null, true);
		}
		this.UpdateReward(false);
		this.UpdateProgress();
		this.UpdateSpeed();
		this.UpdateBtnRoundRecord();
		this.UpdateDiceUseState(false, 0);
		this.UpdateBoardLockTips();
	}

	// Token: 0x0600520E RID: 21006 RVA: 0x001B5437 File Offset: 0x001B3637
	[NullableContext(1)]
	public List<IDangoMonopolyRoundBuffData> GetBuffItemData()
	{
		DangoMonopolyBoardData showBoardData = this.ShowBoardData;
		return ((showBoardData != null) ? showBoardData.GetDangoBuffShowList() : null) ?? new List<IDangoMonopolyRoundBuffData>();
	}

	// Token: 0x0600520F RID: 21007 RVA: 0x001B5454 File Offset: 0x001B3654
	public void UpdateBoardLockTips()
	{
		this.IsBoardLock = this.ActivityData.IsRunningBoardLock();
		UUIItem item = base.GetItem(21);
		bool flag = this.ActivityData.IsFinishAllRound();
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIButtonComponent button = base.GetButton(9);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(!flag);
		}
		if (!flag)
		{
			if (item != null)
			{
				item.SetUIActive(this.IsBoardLock);
			}
			this.UpdateBoardRemainTime();
			return;
		}
		UUIText text = base.GetText(22);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew("DangoMonopoly_title_18");
	}

	// Token: 0x06005210 RID: 21008 RVA: 0x001B54E5 File Offset: 0x001B36E5
	public void UpdateBoardRemainTime()
	{
		if (!this.IsBoardLock)
		{
			return;
		}
		UUIText text = base.GetText(22);
		if (text == null)
		{
			return;
		}
		text.SetText(this.ActivityData.GetBoardRemainTimeStr(), true);
	}

	// Token: 0x06005211 RID: 21009 RVA: 0x001B5510 File Offset: 0x001B3710
	public void UpdateDiceUseState(bool _1, int _2)
	{
		UUIItem sprite = base.GetSprite(11);
		bool uiactive = !this.ActivityData.IsCanUseDice();
		sprite.SetUIActive(uiactive);
		DangoMonopolyBoardData showBoardData = this.ShowBoardData;
		bool? flag = (showBoardData != null) ? new bool?(!showBoardData.IsFinish()) : null;
		UUIButtonComponent button = base.GetButton(10);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(flag.GetValueOrDefault());
	}

	// Token: 0x06005212 RID: 21010 RVA: 0x001B5584 File Offset: 0x001B3784
	public void UpdateReward(bool resetNavigation = false)
	{
		List<DangoMonopolyBoardData> boardList = this.ActivityData.BoardList;
		List<IDangoMonopolyRoundRewardItemData> rewardList = new List<IDangoMonopolyRoundRewardItemData>();
		foreach (DangoMonopolyBoardData dangoMonopolyBoardData in boardList)
		{
			DangoMonopolyRoundRewardItemData item = new DangoMonopolyRoundRewardItemData
			{
				IsReceived = dangoMonopolyBoardData.IsRewarded,
				IsCanReceived = dangoMonopolyBoardData.IsCanReceiveReward(),
				ItemId = dangoMonopolyBoardData.RewardItemId,
				Count = dangoMonopolyBoardData.RewardItemCount,
				BoardId = dangoMonopolyBoardData.Id,
				IsCurrent = dangoMonopolyBoardData.IsRunning(),
				Position = dangoMonopolyBoardData.GetPosition()
			};
			rewardList.Add(item);
		}
		IDangoMonopolyRoundRewardItemData data = rewardList[rewardList.Count - 1];
		rewardList.RemoveAt(rewardList.Count - 1);
		LoopScrollView<DangoMonopolyRoundRewardItem, IDangoMonopolyRoundRewardItemData> rewardLayout = this.RewardLayout;
		if (rewardLayout != null)
		{
			rewardLayout.RefreshByData(rewardList, true, delegate
			{
				this.UpdateRewardPos(rewardList, resetNavigation);
			}, false);
		}
		DangoMonopolyRoundRewardItem endRoundReward = this.EndRoundReward;
		if (endRoundReward == null)
		{
			return;
		}
		endRoundReward.Refresh(data, false, 0);
	}

	// Token: 0x06005213 RID: 21011 RVA: 0x001B56C8 File Offset: 0x001B38C8
	[NullableContext(1)]
	public void UpdateRewardPos(List<IDangoMonopolyRoundRewardItemData> rewardList, bool resetNavigation = false)
	{
		int rewardPos = this.GetRewardPos(rewardList);
		LoopScrollView<DangoMonopolyRoundRewardItem, IDangoMonopolyRoundRewardItemData> rewardLayout = this.RewardLayout;
		if (rewardLayout != null)
		{
			rewardLayout.ScrollToGridIndex(rewardPos, true);
		}
		if (!resetNavigation)
		{
			return;
		}
		int gridIndex = Math.Min(rewardPos + 1, rewardList.Count - 1);
		LoopScrollView<DangoMonopolyRoundRewardItem, IDangoMonopolyRoundRewardItemData> rewardLayout2 = this.RewardLayout;
		DangoMonopolyRoundRewardItem dangoMonopolyRoundRewardItem = (rewardLayout2 != null) ? rewardLayout2.UnsafeGetGridProxy(gridIndex, false) : null;
		if (dangoMonopolyRoundRewardItem == null)
		{
			return;
		}
		UUIItem rootItem = dangoMonopolyRoundRewardItem.RewardItem.GetRootItem();
		UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirtyByItem(rootItem);
	}

	// Token: 0x06005214 RID: 21012 RVA: 0x001B5738 File Offset: 0x001B3938
	[NullableContext(1)]
	public int GetRewardPos(List<IDangoMonopolyRoundRewardItemData> rewardList)
	{
		int num = -1;
		for (int i = 0; i < rewardList.Count; i++)
		{
			if (rewardList[i].IsCanReceived)
			{
				num = i;
				break;
			}
		}
		if (num >= 0)
		{
			return Math.Max(0, num - 1);
		}
		int num2 = -1;
		for (int j = 0; j < rewardList.Count; j++)
		{
			if (rewardList[j].IsCurrent)
			{
				num2 = j;
				break;
			}
		}
		return Math.Max(0, num2 - 1);
	}

	// Token: 0x06005215 RID: 21013 RVA: 0x001B57A6 File Offset: 0x001B39A6
	[NullableContext(1)]
	private DangoMonopolyRoundRewardItem CreateRewardItemGrid()
	{
		return new DangoMonopolyRoundRewardItem
		{
			ClickCallBack = new Action<IDangoMonopolyRoundRewardItemData>(this.OnClickReward)
		};
	}

	// Token: 0x06005216 RID: 21014 RVA: 0x001B57BF File Offset: 0x001B39BF
	public void UpdateProgress()
	{
	}

	// Token: 0x06005217 RID: 21015 RVA: 0x001B57C1 File Offset: 0x001B39C1
	[NullableContext(1)]
	private void OnClickReward(IDangoMonopolyRoundRewardItemData data)
	{
		if (this.CheckActivityClose())
		{
			return;
		}
		if (data.IsCanReceived)
		{
			this.ActivityData.RequestReceiveBoard(data.BoardId, true);
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(data.ItemId, true, null, false);
	}

	// Token: 0x06005218 RID: 21016 RVA: 0x001B57FC File Offset: 0x001B39FC
	public void UpdateSpeed()
	{
		string speedStr = this.ActivityData.GetSpeedStr();
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(speedStr, true);
	}

	// Token: 0x06005219 RID: 21017 RVA: 0x001B5828 File Offset: 0x001B3A28
	public void SetMoveDangoUiState(bool visible)
	{
		UUIItem item = base.GetItem(18);
		if (item != null)
		{
			item.SetUIActive(visible);
		}
		UUIButtonComponent button = base.GetButton(8);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(visible);
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(23);
		if (extendToggle != null)
		{
			extendToggle.RootUIComp.Get().SetUIActive(visible);
		}
		DangoMonopolyMainCaption popupCaption = this.PopupCaption;
		if (popupCaption != null)
		{
			popupCaption.SetBtnCloseVisible(visible);
		}
		DangoMonopolyMainCaption popupCaption2 = this.PopupCaption;
		if (popupCaption2 != null)
		{
			popupCaption2.SetBtnHelpVisible(visible);
		}
		DangoMonopolyMainCaption popupCaption3 = this.PopupCaption;
		if (popupCaption3 == null)
		{
			return;
		}
		popupCaption3.SetCurrencyVisible(visible);
	}

	// Token: 0x0600521A RID: 21018 RVA: 0x001B58BF File Offset: 0x001B3ABF
	private void EventDangoMonopolyMoveStart()
	{
		this.UpdateSpeed();
		this.UpdateDiceUseState(false, 0);
		this.ResetAngleOfView();
		this.SetMoveDangoUiState(false);
		this.MoveDangoOneStepAsync(true).Forget();
	}

	// Token: 0x0600521B RID: 21019 RVA: 0x001B58E8 File Offset: 0x001B3AE8
	public UniTask MoveDangoOneStepAsync(bool isFirst = false)
	{
		DangoMonopolyMainView.<MoveDangoOneStepAsync>d__61 <MoveDangoOneStepAsync>d__;
		<MoveDangoOneStepAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MoveDangoOneStepAsync>d__.<>4__this = this;
		<MoveDangoOneStepAsync>d__.isFirst = isFirst;
		<MoveDangoOneStepAsync>d__.<>1__state = -1;
		<MoveDangoOneStepAsync>d__.<>t__builder.Start<DangoMonopolyMainView.<MoveDangoOneStepAsync>d__61>(ref <MoveDangoOneStepAsync>d__);
		return <MoveDangoOneStepAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600521C RID: 21020 RVA: 0x001B5934 File Offset: 0x001B3B34
	public UniTask CheckTriggerBuffAsync()
	{
		DangoMonopolyMainView.<CheckTriggerBuffAsync>d__62 <CheckTriggerBuffAsync>d__;
		<CheckTriggerBuffAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckTriggerBuffAsync>d__.<>4__this = this;
		<CheckTriggerBuffAsync>d__.<>1__state = -1;
		<CheckTriggerBuffAsync>d__.<>t__builder.Start<DangoMonopolyMainView.<CheckTriggerBuffAsync>d__62>(ref <CheckTriggerBuffAsync>d__);
		return <CheckTriggerBuffAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600521D RID: 21021 RVA: 0x001B5977 File Offset: 0x001B3B77
	public void CheckBuffIsWhenMoveFire(int id)
	{
		if (this.ActivityData.BuffIsWhenMoveFire(id))
		{
			this.ActivityData.OpenViewDangoTips(id, 0);
			DangoMonopolyBoardData showBoardData = this.ShowBoardData;
			if (showBoardData == null)
			{
				return;
			}
			showBoardData.AddRecordTriggerBuff(id);
		}
	}

	// Token: 0x0600521E RID: 21022 RVA: 0x001B59A8 File Offset: 0x001B3BA8
	[NullableContext(1)]
	public UniTask CheckGridIsActiveDouble(DangoMonopolyGridData gridData)
	{
		DangoMonopolyMainView.<CheckGridIsActiveDouble>d__64 <CheckGridIsActiveDouble>d__;
		<CheckGridIsActiveDouble>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckGridIsActiveDouble>d__.<>4__this = this;
		<CheckGridIsActiveDouble>d__.gridData = gridData;
		<CheckGridIsActiveDouble>d__.<>1__state = -1;
		<CheckGridIsActiveDouble>d__.<>t__builder.Start<DangoMonopolyMainView.<CheckGridIsActiveDouble>d__64>(ref <CheckGridIsActiveDouble>d__);
		return <CheckGridIsActiveDouble>d__.<>t__builder.Task;
	}

	// Token: 0x0600521F RID: 21023 RVA: 0x001B59F4 File Offset: 0x001B3BF4
	public UniTask DangoMonopolyMoveEnd()
	{
		DangoMonopolyMainView.<DangoMonopolyMoveEnd>d__65 <DangoMonopolyMoveEnd>d__;
		<DangoMonopolyMoveEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<DangoMonopolyMoveEnd>d__.<>4__this = this;
		<DangoMonopolyMoveEnd>d__.<>1__state = -1;
		<DangoMonopolyMoveEnd>d__.<>t__builder.Start<DangoMonopolyMainView.<DangoMonopolyMoveEnd>d__65>(ref <DangoMonopolyMoveEnd>d__);
		return <DangoMonopolyMoveEnd>d__.<>t__builder.Task;
	}

	// Token: 0x06005220 RID: 21024 RVA: 0x001B5A38 File Offset: 0x001B3C38
	public UniTask CheckEnterNextRound()
	{
		DangoMonopolyMainView.<CheckEnterNextRound>d__66 <CheckEnterNextRound>d__;
		<CheckEnterNextRound>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckEnterNextRound>d__.<>4__this = this;
		<CheckEnterNextRound>d__.<>1__state = -1;
		<CheckEnterNextRound>d__.<>t__builder.Start<DangoMonopolyMainView.<CheckEnterNextRound>d__66>(ref <CheckEnterNextRound>d__);
		return <CheckEnterNextRound>d__.<>t__builder.Task;
	}

	// Token: 0x06005221 RID: 21025 RVA: 0x001B5A7B File Offset: 0x001B3C7B
	private void EventDangoMonopolyBoardRewardUpdate()
	{
		this.UpdateReward(true);
	}

	// Token: 0x06005222 RID: 21026 RVA: 0x001B5A84 File Offset: 0x001B3C84
	public UniTask AwaitRewardShowClose()
	{
		DangoMonopolyMainView.<AwaitRewardShowClose>d__68 <AwaitRewardShowClose>d__;
		<AwaitRewardShowClose>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AwaitRewardShowClose>d__.<>4__this = this;
		<AwaitRewardShowClose>d__.<>1__state = -1;
		<AwaitRewardShowClose>d__.<>t__builder.Start<DangoMonopolyMainView.<AwaitRewardShowClose>d__68>(ref <AwaitRewardShowClose>d__);
		return <AwaitRewardShowClose>d__.<>t__builder.Task;
	}

	// Token: 0x06005223 RID: 21027 RVA: 0x001B5AC7 File Offset: 0x001B3CC7
	private void EventOnCloseRewardView()
	{
		CustomPromise rewardViewClosePromise = this.RewardViewClosePromise;
		if (rewardViewClosePromise == null)
		{
			return;
		}
		rewardViewClosePromise.SetResult();
	}

	// Token: 0x06005224 RID: 21028 RVA: 0x001B5ADC File Offset: 0x001B3CDC
	public UniTask UpdateDangoPosition(bool show = true)
	{
		DangoMonopolyMainView.<UpdateDangoPosition>d__70 <UpdateDangoPosition>d__;
		<UpdateDangoPosition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateDangoPosition>d__.<>4__this = this;
		<UpdateDangoPosition>d__.show = show;
		<UpdateDangoPosition>d__.<>1__state = -1;
		<UpdateDangoPosition>d__.<>t__builder.Start<DangoMonopolyMainView.<UpdateDangoPosition>d__70>(ref <UpdateDangoPosition>d__);
		return <UpdateDangoPosition>d__.<>t__builder.Task;
	}

	// Token: 0x06005225 RID: 21029 RVA: 0x001B5B28 File Offset: 0x001B3D28
	public FVector2D GetDangoCursorPosition()
	{
		int runningGridId = this.ActivityData.GetRunningGridId();
		DangoMonopolyGridInfoPanel dangoMonopolyGridInfoPanel;
		if (this.ActivityData.BoardGridUiInfoMap.TryGetValue(runningGridId, out dangoMonopolyGridInfoPanel))
		{
			return dangoMonopolyGridInfoPanel.GetCursorPosition();
		}
		long mainRoleDangoEntityId = this.ActivityData.MainRoleDangoEntityId;
		EntityHandle entity = CreatureModel.Instance.GetEntity(mainRoleDangoEntityId);
		if (entity != null && entity.Valid && entity.IsInit && entity.Entity != null)
		{
			BaseActorComponent component = entity.Entity.GetComponent<BaseActorComponent>();
			if (((component != null) ? component.SkeletalMesh : null) != null)
			{
				float num = component.SkeletalMesh.Bounds.BoxExtent.Z * 2f;
				return UiModelUtil.Instance.GetActorLguiPos(component.Owner, global::Vector.Create(0.0, 0.0, (double)num));
			}
		}
		return new FVector2D();
	}

	// Token: 0x06005226 RID: 21030 RVA: 0x001B5BFC File Offset: 0x001B3DFC
	private void EventDangoMonopolyStartShowProcess()
	{
		DangoMonopolyPosition dangoPosition = this.DangoPosition;
		if (dangoPosition == null)
		{
			return;
		}
		dangoPosition.SetActive(false);
	}

	// Token: 0x06005227 RID: 21031 RVA: 0x001B5C0F File Offset: 0x001B3E0F
	private void EventDangoMonopolyEndShowProcess()
	{
		this.UpdateDangoPosition(true).Forget();
	}

	// Token: 0x06005228 RID: 21032 RVA: 0x001B5C1D File Offset: 0x001B3E1D
	private void OnClickAngleOfView(EToggleState toggleState)
	{
		this.UpdateAngleOfView().Forget();
	}

	// Token: 0x06005229 RID: 21033 RVA: 0x001B5C2C File Offset: 0x001B3E2C
	public UniTask UpdateAngleOfView()
	{
		DangoMonopolyMainView.<UpdateAngleOfView>d__75 <UpdateAngleOfView>d__;
		<UpdateAngleOfView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateAngleOfView>d__.<>4__this = this;
		<UpdateAngleOfView>d__.<>1__state = -1;
		<UpdateAngleOfView>d__.<>t__builder.Start<DangoMonopolyMainView.<UpdateAngleOfView>d__75>(ref <UpdateAngleOfView>d__);
		return <UpdateAngleOfView>d__.<>t__builder.Task;
	}

	// Token: 0x0600522A RID: 21034 RVA: 0x001B5C70 File Offset: 0x001B3E70
	public void UpdateAngleOfViewBtnState()
	{
		EToggleState state = this.IsOverView ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(23);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(state, false, false, false);
	}

	// Token: 0x0600522B RID: 21035 RVA: 0x001B5CA0 File Offset: 0x001B3EA0
	public void ResetAngleOfView()
	{
		if (!this.IsOverView)
		{
			return;
		}
		this.IsOverView = false;
		this.UpdateAngleOfViewBtnState();
	}

	// Token: 0x04003A2C RID: 14892
	private DangoMonopolyMainCaption PopupCaption;

	// Token: 0x04003A2D RID: 14893
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<DangoMonopolyBuffStateItem, IDangoMonopolyRoundBuffData> BuffLayoutView;

	// Token: 0x04003A2E RID: 14894
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<DangoMonopolyRoundRewardItem, IDangoMonopolyRoundRewardItemData> RewardLayout;

	// Token: 0x04003A2F RID: 14895
	private DangoMonopolyRoundRewardItem EndRoundReward;

	// Token: 0x04003A30 RID: 14896
	public DangoMonopolyBoardData ShowBoardData;

	// Token: 0x04003A31 RID: 14897
	public bool IsCheckShow;

	// Token: 0x04003A32 RID: 14898
	public const int WaitTimeActiveClose = 500;

	// Token: 0x04003A33 RID: 14899
	public CustomPromise RewardViewClosePromise;

	// Token: 0x04003A34 RID: 14900
	public CustomPromise ResultClosePromise;

	// Token: 0x04003A35 RID: 14901
	public CustomPromise ResultShowPromise;

	// Token: 0x04003A36 RID: 14902
	public TimerHandle RefreshTimerHandle;

	// Token: 0x04003A37 RID: 14903
	public bool IsBoardLock;

	// Token: 0x04003A38 RID: 14904
	public DangoMonopolyPosition DangoPosition;

	// Token: 0x04003A39 RID: 14905
	public bool IsOverView;

	// Token: 0x020069BA RID: 27066
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04022CE9 RID: 142569
		ItemCaption,
		// Token: 0x04022CEA RID: 142570
		BtnSpeed,
		// Token: 0x04022CEB RID: 142571
		TxtSpeedTitle,
		// Token: 0x04022CEC RID: 142572
		TxtCurrentRound,
		// Token: 0x04022CED RID: 142573
		TxtTotalRound,
		// Token: 0x04022CEE RID: 142574
		VLayoutProperty,
		// Token: 0x04022CEF RID: 142575
		ItemProperty,
		// Token: 0x04022CF0 RID: 142576
		ItemAllBoardFinish,
		// Token: 0x04022CF1 RID: 142577
		BtnRoundRecord,
		// Token: 0x04022CF2 RID: 142578
		BtnDiceTask,
		// Token: 0x04022CF3 RID: 142579
		BtnUseDice,
		// Token: 0x04022CF4 RID: 142580
		SpriteDiceMask,
		// Token: 0x04022CF5 RID: 142581
		TxtFinishedRound,
		// Token: 0x04022CF6 RID: 142582
		TxtTotalRound2,
		// Token: 0x04022CF7 RID: 142583
		LoopViewRoundReward,
		// Token: 0x04022CF8 RID: 142584
		ItemRoundReward,
		// Token: 0x04022CF9 RID: 142585
		ItemFinalReward,
		// Token: 0x04022CFA RID: 142586
		ItemLeftTopRoot,
		// Token: 0x04022CFB RID: 142587
		ItemBottomRoot,
		// Token: 0x04022CFC RID: 142588
		ItemDiceTaskRedDot,
		// Token: 0x04022CFD RID: 142589
		ItemRollDiceRedDot,
		// Token: 0x04022CFE RID: 142590
		ItemBoardLockTipsRoot,
		// Token: 0x04022CFF RID: 142591
		TxtBoardLockTips,
		// Token: 0x04022D00 RID: 142592
		ToggleAngleOfView
	}
}
