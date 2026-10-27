using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x0200123D RID: 4669
[NullableContext(2)]
[Nullable(0)]
public class DangoMonopolyMainView : DangoMonopolyViewBase
{
	// Token: 0x17000ABC RID: 2748
	// (get) Token: 0x06007E57 RID: 32343 RVA: 0x001ABC14 File Offset: 0x001A9E14
	public new DangoMonopolyMainViewParam OpenParam
	{
		get
		{
			return this.OpenParam as DangoMonopolyMainViewParam;
		}
	}

	// Token: 0x06007E58 RID: 32344 RVA: 0x001ABC21 File Offset: 0x001A9E21
	[NullableContext(1)]
	public DangoMonopolyMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007E59 RID: 32345 RVA: 0x001ABC2C File Offset: 0x001A9E2C
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

	// Token: 0x06007E5A RID: 32346 RVA: 0x001ABEE9 File Offset: 0x001AA0E9
	private void InitDataParam()
	{
	}

	// Token: 0x06007E5B RID: 32347 RVA: 0x001ABEEC File Offset: 0x001AA0EC
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyMainView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyMainView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007E5C RID: 32348 RVA: 0x001ABF30 File Offset: 0x001AA130
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

	// Token: 0x06007E5D RID: 32349 RVA: 0x001ABF9C File Offset: 0x001AA19C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.DangoMonopolyBoardRewardUpdate, new Action(this.EventDangoMonopolyBoardRewardUpdate));
		EventSystem.Instance.Add(EEventName.OnCloseRewardView, new Action(this.EventOnCloseRewardView));
		EventSystem.Instance.Add(EEventName.DangoMonopolyStartShowProcess, new Action(this.EventDangoMonopolyStartShowProcess));
		EventSystem.Instance.Add(EEventName.DangoMonopolyEndShowProcess, new Action(this.EventDangoMonopolyEndShowProcess));
		RedDotController.Instance.BindRedDot(ERedDotName.DangoMonopolyTask, base.GetItem(19), null, 0);
		RedDotController.Instance.BindRedDot(ERedDotName.DangoMonopolyDiceNum, base.GetItem(20), new Action<bool, int>(this.UpdateDiceUseState), 0);
	}

	// Token: 0x06007E5E RID: 32350 RVA: 0x001AC058 File Offset: 0x001AA258
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.DangoMonopolyBoardRewardUpdate, new Action(this.EventDangoMonopolyBoardRewardUpdate));
		EventSystem.Instance.Remove(EEventName.OnCloseRewardView, new Action(this.EventOnCloseRewardView));
		EventSystem.Instance.Remove(EEventName.DangoMonopolyStartShowProcess, new Action(this.EventDangoMonopolyStartShowProcess));
		EventSystem.Instance.Remove(EEventName.DangoMonopolyEndShowProcess, new Action(this.EventDangoMonopolyEndShowProcess));
		RedDotController.Instance.UnBindRedDot(ERedDotName.DangoMonopolyTask);
		RedDotController.Instance.UnBindRedDot(ERedDotName.DangoMonopolyDiceNum);
	}

	// Token: 0x06007E5F RID: 32351 RVA: 0x001AC0F4 File Offset: 0x001AA2F4
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

	// Token: 0x06007E60 RID: 32352 RVA: 0x001AC177 File Offset: 0x001AA377
	public void OnTimerRefresh(float _)
	{
		this.CheckBoardUnlockTime();
	}

	// Token: 0x06007E61 RID: 32353 RVA: 0x001AC17F File Offset: 0x001AA37F
	public void CheckBoardUnlockTime()
	{
		if (this.ActivityData.IsRunningBoardLock() != this.IsBoardLock)
		{
			this.UpdateData();
		}
		this.UpdateBoardRemainTime();
	}

	// Token: 0x06007E62 RID: 32354 RVA: 0x001AC1A0 File Offset: 0x001AA3A0
	public bool CheckActivityClose()
	{
		if (!this.ActivityData.CheckIfClose())
		{
			return false;
		}
		ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
		return true;
	}

	// Token: 0x06007E63 RID: 32355 RVA: 0x001AC1BC File Offset: 0x001AA3BC
	public void ClearTimer()
	{
		if (this.RefreshTimerHandle != null && TimerSystem.RealTimeInstance.Has(this.RefreshTimerHandle))
		{
			TimerSystem.RealTimeInstance.Remove(this.RefreshTimerHandle);
			this.RefreshTimerHandle = null;
		}
	}

	// Token: 0x06007E64 RID: 32356 RVA: 0x001AC1F0 File Offset: 0x001AA3F0
	protected override void OnBeforeHide()
	{
		this.ClearTimer();
		this.SetBattleFloatVisible(false).Forget();
	}

	// Token: 0x06007E65 RID: 32357 RVA: 0x001AC204 File Offset: 0x001AA404
	protected override void OnAfterShow()
	{
		this.SetBattleFloatVisible(true).Forget();
	}

	// Token: 0x06007E66 RID: 32358 RVA: 0x001AC214 File Offset: 0x001AA414
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

	// Token: 0x06007E67 RID: 32359 RVA: 0x001AC260 File Offset: 0x001AA460
	public UniTask CheckShowProcess()
	{
		DangoMonopolyMainView.<CheckShowProcess>d__32 <CheckShowProcess>d__;
		<CheckShowProcess>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckShowProcess>d__.<>4__this = this;
		<CheckShowProcess>d__.<>1__state = -1;
		<CheckShowProcess>d__.<>t__builder.Start<DangoMonopolyMainView.<CheckShowProcess>d__32>(ref <CheckShowProcess>d__);
		return <CheckShowProcess>d__.<>t__builder.Task;
	}

	// Token: 0x06007E68 RID: 32360 RVA: 0x001AC2A4 File Offset: 0x001AA4A4
	public UniTask CheckUpdateDangoPosition()
	{
		DangoMonopolyMainView.<CheckUpdateDangoPosition>d__33 <CheckUpdateDangoPosition>d__;
		<CheckUpdateDangoPosition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckUpdateDangoPosition>d__.<>4__this = this;
		<CheckUpdateDangoPosition>d__.<>1__state = -1;
		<CheckUpdateDangoPosition>d__.<>t__builder.Start<DangoMonopolyMainView.<CheckUpdateDangoPosition>d__33>(ref <CheckUpdateDangoPosition>d__);
		return <CheckUpdateDangoPosition>d__.<>t__builder.Task;
	}

	// Token: 0x06007E69 RID: 32361 RVA: 0x001AC2E8 File Offset: 0x001AA4E8
	public UniTask CheckShowInfo()
	{
		DangoMonopolyMainView.<CheckShowInfo>d__34 <CheckShowInfo>d__;
		<CheckShowInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckShowInfo>d__.<>4__this = this;
		<CheckShowInfo>d__.<>1__state = -1;
		<CheckShowInfo>d__.<>t__builder.Start<DangoMonopolyMainView.<CheckShowInfo>d__34>(ref <CheckShowInfo>d__);
		return <CheckShowInfo>d__.<>t__builder.Task;
	}

	// Token: 0x06007E6A RID: 32362 RVA: 0x001AC32C File Offset: 0x001AA52C
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

	// Token: 0x06007E6B RID: 32363 RVA: 0x001AC378 File Offset: 0x001AA578
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

	// Token: 0x06007E6C RID: 32364 RVA: 0x001AC40D File Offset: 0x001AA60D
	public void UpdateShowBoardData(DangoMonopolyBoardData boardData)
	{
		this.ShowBoardData = (boardData ?? this.ActivityData.BoardList[0]);
	}

	// Token: 0x06007E6D RID: 32365 RVA: 0x001AC42C File Offset: 0x001AA62C
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

	// Token: 0x06007E6E RID: 32366 RVA: 0x001AC4DC File Offset: 0x001AA6DC
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

	// Token: 0x06007E6F RID: 32367 RVA: 0x001AC55B File Offset: 0x001AA75B
	private void HelpCallback()
	{
		HelpController.Instance.OpenHelpById(290);
	}

	// Token: 0x06007E70 RID: 32368 RVA: 0x001AC56C File Offset: 0x001AA76C
	private void OnClickBtnSpeed()
	{
		this.ActivityData.SetActivitySpeed(null);
		this.UpdateSpeed();
	}

	// Token: 0x06007E71 RID: 32369 RVA: 0x001AC593 File Offset: 0x001AA793
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

	// Token: 0x06007E72 RID: 32370 RVA: 0x001AC5AC File Offset: 0x001AA7AC
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

	// Token: 0x06007E73 RID: 32371 RVA: 0x001AC5E7 File Offset: 0x001AA7E7
	private void OnClickBtnDiceTask()
	{
		if (this.CheckActivityClose())
		{
			return;
		}
		this.ActivityData.OpenViewDiceTask();
	}

	// Token: 0x06007E74 RID: 32372 RVA: 0x001AC600 File Offset: 0x001AA800
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

	// Token: 0x06007E75 RID: 32373 RVA: 0x001AC661 File Offset: 0x001AA861
	[NullableContext(1)]
	private DangoMonopolyBuffStateItem CreateBuffItem()
	{
		return new DangoMonopolyBuffStateItem();
	}

	// Token: 0x06007E76 RID: 32374 RVA: 0x001AC668 File Offset: 0x001AA868
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
			buffLayoutView.RefreshByData(buffItemData.ToList<IDangoMonopolyRoundBuffData>(), null, true);
		}
		this.UpdateReward(false);
		this.UpdateProgress();
		this.UpdateSpeed();
		this.UpdateBtnRoundRecord();
		this.UpdateDiceUseState(false, 0);
		this.UpdateBoardLockTips();
	}

	// Token: 0x06007E77 RID: 32375 RVA: 0x001AC77C File Offset: 0x001AA97C
	[NullableContext(1)]
	public List<IDangoMonopolyRoundBuffData> GetBuffItemData()
	{
		DangoMonopolyBoardData showBoardData = this.ShowBoardData;
		return ((showBoardData != null) ? showBoardData.GetDangoBuffShowList() : null) ?? new List<IDangoMonopolyRoundBuffData>();
	}

	// Token: 0x06007E78 RID: 32376 RVA: 0x001AC79C File Offset: 0x001AA99C
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

	// Token: 0x06007E79 RID: 32377 RVA: 0x001AC82D File Offset: 0x001AAA2D
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

	// Token: 0x06007E7A RID: 32378 RVA: 0x001AC858 File Offset: 0x001AAA58
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

	// Token: 0x06007E7B RID: 32379 RVA: 0x001AC8CC File Offset: 0x001AAACC
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

	// Token: 0x06007E7C RID: 32380 RVA: 0x001ACA10 File Offset: 0x001AAC10
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

	// Token: 0x06007E7D RID: 32381 RVA: 0x001ACA80 File Offset: 0x001AAC80
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

	// Token: 0x06007E7E RID: 32382 RVA: 0x001ACAEE File Offset: 0x001AACEE
	[NullableContext(1)]
	private DangoMonopolyRoundRewardItem CreateRewardItemGrid()
	{
		return new DangoMonopolyRoundRewardItem
		{
			ClickCallBack = new Action<IDangoMonopolyRoundRewardItemData>(this.OnClickReward)
		};
	}

	// Token: 0x06007E7F RID: 32383 RVA: 0x001ACB07 File Offset: 0x001AAD07
	public void UpdateProgress()
	{
	}

	// Token: 0x06007E80 RID: 32384 RVA: 0x001ACB09 File Offset: 0x001AAD09
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
		ItemController.Instance.OpenItemTipsByItemId(data.ItemId, true, null);
	}

	// Token: 0x06007E81 RID: 32385 RVA: 0x001ACB44 File Offset: 0x001AAD44
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

	// Token: 0x06007E82 RID: 32386 RVA: 0x001ACB70 File Offset: 0x001AAD70
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

	// Token: 0x06007E83 RID: 32387 RVA: 0x001ACC07 File Offset: 0x001AAE07
	private void EventDangoMonopolyMoveStart()
	{
		this.UpdateSpeed();
		this.UpdateDiceUseState(false, 0);
		this.ResetAngleOfView();
		this.SetMoveDangoUiState(false);
		this.MoveDangoOneStepAsync(true).Forget();
	}

	// Token: 0x06007E84 RID: 32388 RVA: 0x001ACC30 File Offset: 0x001AAE30
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

	// Token: 0x06007E85 RID: 32389 RVA: 0x001ACC7C File Offset: 0x001AAE7C
	public UniTask CheckTriggerBuffAsync()
	{
		DangoMonopolyMainView.<CheckTriggerBuffAsync>d__62 <CheckTriggerBuffAsync>d__;
		<CheckTriggerBuffAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckTriggerBuffAsync>d__.<>4__this = this;
		<CheckTriggerBuffAsync>d__.<>1__state = -1;
		<CheckTriggerBuffAsync>d__.<>t__builder.Start<DangoMonopolyMainView.<CheckTriggerBuffAsync>d__62>(ref <CheckTriggerBuffAsync>d__);
		return <CheckTriggerBuffAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007E86 RID: 32390 RVA: 0x001ACCBF File Offset: 0x001AAEBF
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

	// Token: 0x06007E87 RID: 32391 RVA: 0x001ACCF0 File Offset: 0x001AAEF0
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

	// Token: 0x06007E88 RID: 32392 RVA: 0x001ACD3C File Offset: 0x001AAF3C
	public UniTask DangoMonopolyMoveEnd()
	{
		DangoMonopolyMainView.<DangoMonopolyMoveEnd>d__65 <DangoMonopolyMoveEnd>d__;
		<DangoMonopolyMoveEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<DangoMonopolyMoveEnd>d__.<>4__this = this;
		<DangoMonopolyMoveEnd>d__.<>1__state = -1;
		<DangoMonopolyMoveEnd>d__.<>t__builder.Start<DangoMonopolyMainView.<DangoMonopolyMoveEnd>d__65>(ref <DangoMonopolyMoveEnd>d__);
		return <DangoMonopolyMoveEnd>d__.<>t__builder.Task;
	}

	// Token: 0x06007E89 RID: 32393 RVA: 0x001ACD80 File Offset: 0x001AAF80
	public UniTask CheckEnterNextRound()
	{
		DangoMonopolyMainView.<CheckEnterNextRound>d__66 <CheckEnterNextRound>d__;
		<CheckEnterNextRound>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckEnterNextRound>d__.<>4__this = this;
		<CheckEnterNextRound>d__.<>1__state = -1;
		<CheckEnterNextRound>d__.<>t__builder.Start<DangoMonopolyMainView.<CheckEnterNextRound>d__66>(ref <CheckEnterNextRound>d__);
		return <CheckEnterNextRound>d__.<>t__builder.Task;
	}

	// Token: 0x06007E8A RID: 32394 RVA: 0x001ACDC3 File Offset: 0x001AAFC3
	private void EventDangoMonopolyBoardRewardUpdate()
	{
		this.UpdateReward(true);
	}

	// Token: 0x06007E8B RID: 32395 RVA: 0x001ACDCC File Offset: 0x001AAFCC
	public UniTask AwaitRewardShowClose()
	{
		DangoMonopolyMainView.<AwaitRewardShowClose>d__68 <AwaitRewardShowClose>d__;
		<AwaitRewardShowClose>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AwaitRewardShowClose>d__.<>4__this = this;
		<AwaitRewardShowClose>d__.<>1__state = -1;
		<AwaitRewardShowClose>d__.<>t__builder.Start<DangoMonopolyMainView.<AwaitRewardShowClose>d__68>(ref <AwaitRewardShowClose>d__);
		return <AwaitRewardShowClose>d__.<>t__builder.Task;
	}

	// Token: 0x06007E8C RID: 32396 RVA: 0x001ACE0F File Offset: 0x001AB00F
	private void EventOnCloseRewardView()
	{
		CustomPromise rewardViewClosePromise = this.RewardViewClosePromise;
		if (rewardViewClosePromise == null)
		{
			return;
		}
		rewardViewClosePromise.SetResult();
	}

	// Token: 0x06007E8D RID: 32397 RVA: 0x001ACE24 File Offset: 0x001AB024
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

	// Token: 0x06007E8E RID: 32398 RVA: 0x001ACE70 File Offset: 0x001AB070
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

	// Token: 0x06007E8F RID: 32399 RVA: 0x001ACF44 File Offset: 0x001AB144
	private void EventDangoMonopolyStartShowProcess()
	{
		DangoMonopolyPosition dangoPosition = this.DangoPosition;
		if (dangoPosition == null)
		{
			return;
		}
		dangoPosition.SetActive(false);
	}

	// Token: 0x06007E90 RID: 32400 RVA: 0x001ACF57 File Offset: 0x001AB157
	private void EventDangoMonopolyEndShowProcess()
	{
		this.UpdateDangoPosition(true).Forget();
	}

	// Token: 0x06007E91 RID: 32401 RVA: 0x001ACF65 File Offset: 0x001AB165
	private void OnClickAngleOfView(EToggleState toggleState)
	{
		this.UpdateAngleOfView().Forget();
	}

	// Token: 0x06007E92 RID: 32402 RVA: 0x001ACF74 File Offset: 0x001AB174
	public UniTask UpdateAngleOfView()
	{
		DangoMonopolyMainView.<UpdateAngleOfView>d__75 <UpdateAngleOfView>d__;
		<UpdateAngleOfView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateAngleOfView>d__.<>4__this = this;
		<UpdateAngleOfView>d__.<>1__state = -1;
		<UpdateAngleOfView>d__.<>t__builder.Start<DangoMonopolyMainView.<UpdateAngleOfView>d__75>(ref <UpdateAngleOfView>d__);
		return <UpdateAngleOfView>d__.<>t__builder.Task;
	}

	// Token: 0x06007E93 RID: 32403 RVA: 0x001ACFB8 File Offset: 0x001AB1B8
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

	// Token: 0x06007E94 RID: 32404 RVA: 0x001ACFE8 File Offset: 0x001AB1E8
	public void ResetAngleOfView()
	{
		if (!this.IsOverView)
		{
			return;
		}
		this.IsOverView = false;
		this.UpdateAngleOfViewBtnState();
	}

	// Token: 0x04003994 RID: 14740
	private DangoMonopolyMainCaption PopupCaption;

	// Token: 0x04003995 RID: 14741
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<DangoMonopolyBuffStateItem, IDangoMonopolyRoundBuffData> BuffLayoutView;

	// Token: 0x04003996 RID: 14742
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<DangoMonopolyRoundRewardItem, IDangoMonopolyRoundRewardItemData> RewardLayout;

	// Token: 0x04003997 RID: 14743
	private DangoMonopolyRoundRewardItem EndRoundReward;

	// Token: 0x04003998 RID: 14744
	public DangoMonopolyBoardData ShowBoardData;

	// Token: 0x04003999 RID: 14745
	public bool IsCheckShow;

	// Token: 0x0400399A RID: 14746
	public const int WaitTimeActiveClose = 500;

	// Token: 0x0400399B RID: 14747
	public CustomPromise RewardViewClosePromise;

	// Token: 0x0400399C RID: 14748
	public CustomPromise ResultClosePromise;

	// Token: 0x0400399D RID: 14749
	public CustomPromise ResultShowPromise;

	// Token: 0x0400399E RID: 14750
	public TimerHandle RefreshTimerHandle;

	// Token: 0x0400399F RID: 14751
	public bool IsBoardLock;

	// Token: 0x040039A0 RID: 14752
	public DangoMonopolyPosition DangoPosition;

	// Token: 0x040039A1 RID: 14753
	public bool IsOverView;

	// Token: 0x0200782F RID: 30767
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040279B8 RID: 162232
		ItemCaption,
		// Token: 0x040279B9 RID: 162233
		BtnSpeed,
		// Token: 0x040279BA RID: 162234
		TxtSpeedTitle,
		// Token: 0x040279BB RID: 162235
		TxtCurrentRound,
		// Token: 0x040279BC RID: 162236
		TxtTotalRound,
		// Token: 0x040279BD RID: 162237
		VLayoutProperty,
		// Token: 0x040279BE RID: 162238
		ItemProperty,
		// Token: 0x040279BF RID: 162239
		ItemAllBoardFinish,
		// Token: 0x040279C0 RID: 162240
		BtnRoundRecord,
		// Token: 0x040279C1 RID: 162241
		BtnDiceTask,
		// Token: 0x040279C2 RID: 162242
		BtnUseDice,
		// Token: 0x040279C3 RID: 162243
		SpriteDiceMask,
		// Token: 0x040279C4 RID: 162244
		TxtFinishedRound,
		// Token: 0x040279C5 RID: 162245
		TxtTotalRound2,
		// Token: 0x040279C6 RID: 162246
		LoopViewRoundReward,
		// Token: 0x040279C7 RID: 162247
		ItemRoundReward,
		// Token: 0x040279C8 RID: 162248
		ItemFinalReward,
		// Token: 0x040279C9 RID: 162249
		ItemLeftTopRoot,
		// Token: 0x040279CA RID: 162250
		ItemBottomRoot,
		// Token: 0x040279CB RID: 162251
		ItemDiceTaskRedDot,
		// Token: 0x040279CC RID: 162252
		ItemRollDiceRedDot,
		// Token: 0x040279CD RID: 162253
		ItemBoardLockTipsRoot,
		// Token: 0x040279CE RID: 162254
		TxtBoardLockTips,
		// Token: 0x040279CF RID: 162255
		ToggleAngleOfView
	}
}
