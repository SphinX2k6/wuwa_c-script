using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002329 RID: 9001
public class BattlePassBackgroundPanel : UiPanelBase
{
	// Token: 0x06011D26 RID: 72998 RVA: 0x00463B18 File Offset: 0x00461D18
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISliderComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickReceiveBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickBuyPassBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06011D27 RID: 72999 RVA: 0x00463D54 File Offset: 0x00461F54
	private void OnClickBuyLevelBtn(int _)
	{
		UiManager.Instance.OpenView(EUiViewName.BattlePassBuyLevelView, null, null);
		OnBattlePassOperationLogEvent onBattlePassOperationLogEvent = new OnBattlePassOperationLogEvent();
		onBattlePassOperationLogEvent.i_operation_type = 0;
		LogReportController.Instance.LogReport(onBattlePassOperationLogEvent);
	}

	// Token: 0x06011D28 RID: 73000 RVA: 0x00463D8C File Offset: 0x00461F8C
	private void OnClickBuyPassBtn()
	{
		BattlePassBackgroundPanelParam battlePassBackgroundPanelParam = (BattlePassBackgroundPanelParam)this.OpenParam;
		BattlePassModel.Instance.PayButtonRedDotState = false;
		UiManager.Instance.OpenView(EUiViewName.BattlePassPayView, battlePassBackgroundPanelParam.WeaponObservers, null);
		OnBattlePassOperationLogEvent onBattlePassOperationLogEvent = new OnBattlePassOperationLogEvent();
		onBattlePassOperationLogEvent.i_operation_type = 1;
		LogReportController.Instance.LogReport(onBattlePassOperationLogEvent);
	}

	// Token: 0x06011D29 RID: 73001 RVA: 0x00463DDE File Offset: 0x00461FDE
	private void OnClickReceiveBtn()
	{
		if (this.IsRewardPanel)
		{
			BattlePassController.Instance.RequestTakeAllRewardResponse();
			return;
		}
		BattlePassController.Instance.TryRequestTaskList(BattlePassModel.Instance.GetAllFinishedTask());
	}

	// Token: 0x06011D2A RID: 73002 RVA: 0x00463E08 File Offset: 0x00462008
	protected override UniTask OnCreateAsync()
	{
		BattlePassBackgroundPanel.<OnCreateAsync>d__10 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<BattlePassBackgroundPanel.<OnCreateAsync>d__10>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011D2B RID: 73003 RVA: 0x00463E4C File Offset: 0x0046204C
	private UniTask LoadRedSprite()
	{
		BattlePassBackgroundPanel.<LoadRedSprite>d__11 <LoadRedSprite>d__;
		<LoadRedSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadRedSprite>d__.<>4__this = this;
		<LoadRedSprite>d__.<>1__state = -1;
		<LoadRedSprite>d__.<>t__builder.Start<BattlePassBackgroundPanel.<LoadRedSprite>d__11>(ref <LoadRedSprite>d__);
		return <LoadRedSprite>d__.<>t__builder.Task;
	}

	// Token: 0x06011D2C RID: 73004 RVA: 0x00463E90 File Offset: 0x00462090
	private UniTask LoadGreenSprite()
	{
		BattlePassBackgroundPanel.<LoadGreenSprite>d__12 <LoadGreenSprite>d__;
		<LoadGreenSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadGreenSprite>d__.<>4__this = this;
		<LoadGreenSprite>d__.<>1__state = -1;
		<LoadGreenSprite>d__.<>t__builder.Start<BattlePassBackgroundPanel.<LoadGreenSprite>d__12>(ref <LoadGreenSprite>d__);
		return <LoadGreenSprite>d__.<>t__builder.Task;
	}

	// Token: 0x06011D2D RID: 73005 RVA: 0x00463ED4 File Offset: 0x004620D4
	protected void AddEventListener()
	{
		EventSystem.Instance.Add<int?>(EEventName.GetBattlePassRewardEvent, new Action<int?>(this.OnGetBattlePassRewardEvent));
		EventSystem.Instance.Add(EEventName.UpdateBattlePassTaskEvent, new Action(this.RefreshButton));
		EventSystem.Instance.Add(EEventName.ReceiveBattlePassDataEvent, new Action(this.RefreshMainView));
		EventSystem.Instance.Add(EEventName.NotifyBattlePassToBuyEvent, new Action(this.OnClickBuyPassBtn));
	}

	// Token: 0x06011D2E RID: 73006 RVA: 0x00463F54 File Offset: 0x00462154
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GetBattlePassRewardEvent, new Action<int?>(this.OnGetBattlePassRewardEvent));
		EventSystem.Instance.Remove(EEventName.UpdateBattlePassTaskEvent, new Action(this.RefreshButton));
		EventSystem.Instance.Remove(EEventName.ReceiveBattlePassDataEvent, new Action(this.RefreshMainView));
		EventSystem.Instance.Remove(EEventName.NotifyBattlePassToBuyEvent, new Action(this.OnClickBuyPassBtn));
	}

	// Token: 0x06011D2F RID: 73007 RVA: 0x00463FD4 File Offset: 0x004621D4
	protected override void OnStart()
	{
		this.BuyLevelBtn = new ButtonItem(base.GetItem(6));
		this.BuyLevelBtn.SetFunction(new Action<int>(this.OnClickBuyLevelBtn));
		BattlePassBackgroundPanelParam battlePassBackgroundPanelParam = (BattlePassBackgroundPanelParam)this.OpenParam;
		this.IsRewardPanel = battlePassBackgroundPanelParam.IsRewardPanel;
		this.RefreshMainView();
		this.AddEventListener();
	}

	// Token: 0x06011D30 RID: 73008 RVA: 0x0046402E File Offset: 0x0046222E
	protected override void OnBeforeShow()
	{
		base.GetItem(10).SetUIActive(false);
		base.GetItem(11).SetUIActive(false);
		RedDotController.Instance.BindRedDot(ERedDotName.BattlePassPayButton, base.GetItem(12), null, 0);
	}

	// Token: 0x06011D31 RID: 73009 RVA: 0x00464065 File Offset: 0x00462265
	protected override void OnBeforeHide()
	{
		RedDotController.Instance.UnBindRedDot(ERedDotName.BattlePassPayButton);
	}

	// Token: 0x06011D32 RID: 73010 RVA: 0x00464076 File Offset: 0x00462276
	protected override void OnAfterShow()
	{
		base.AddChild(this.BuyLevelBtn);
	}

	// Token: 0x06011D33 RID: 73011 RVA: 0x00464084 File Offset: 0x00462284
	private void OnGetBattlePassRewardEvent(int? _)
	{
		this.RefreshButton();
	}

	// Token: 0x06011D34 RID: 73012 RVA: 0x0046408C File Offset: 0x0046228C
	private void RefreshButton()
	{
		if (this.IsRewardPanel)
		{
			base.GetButton(7).RootUIComp.Get().SetUIActive(BattlePassModel.Instance.CheckHasRewardWaitTake());
			return;
		}
		base.GetButton(7).RootUIComp.Get().SetUIActive(BattlePassModel.Instance.CheckHasTaskWaitTake());
	}

	// Token: 0x06011D35 RID: 73013 RVA: 0x004640E8 File Offset: 0x004622E8
	private void RefreshMainView()
	{
		int battlePassLevel = BattlePassModel.Instance.BattlePassLevel;
		int maxLevel = BattlePassModel.Instance.GetMaxLevel();
		base.GetText(1).SetText(battlePassLevel.ToString(), true);
		base.GetSprite(3).SetSprite((maxLevel == battlePassLevel) ? this.RedSprite : this.GreenSprite, true);
		this.BuyLevelBtn.SetEnableClick(maxLevel > battlePassLevel);
		this.BuyLevelBtn.SetLocalTextNew((maxLevel > battlePassLevel) ? "Text_BattlePassLevelBuy_Text" : "Text_BattlePassLevelBuyMax_Text", Array.Empty<object>());
		UUIItem item = base.GetItem((maxLevel == battlePassLevel) ? 11 : 10);
		item.SetUIActive(false);
		item.SetUIActive(true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "Text_BattlePassWeekExp_Text", new <>z__ReadOnlyArray<object>(new object[]
		{
			BattlePassModel.Instance.WeekExp,
			BattlePassModel.Instance.GetMaxWeekExp()
		}));
		base.GetText(5).SetUIActive(maxLevel > battlePassLevel);
		int maxLevelExp = BattlePassModel.Instance.GetMaxLevelExp();
		int num = (battlePassLevel != maxLevel) ? BattlePassModel.Instance.LevelExp : maxLevelExp;
		base.GetText(4).SetText(num.ToString() + "/" + maxLevelExp.ToString(), true);
		base.GetSlider(2).SetValue((float)num / (float)maxLevelExp, true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), BattlePassModel.Instance.GetPassPayBtnKey(), Array.Empty<object>());
		this.RefreshButton();
	}

	// Token: 0x06011D36 RID: 73014 RVA: 0x0046425A File Offset: 0x0046245A
	protected override void OnBeforeDestroy()
	{
		this.BuyLevelBtn = null;
		this.RemoveEventListener();
		this.RedSprite = null;
		this.GreenSprite = null;
	}

	// Token: 0x0400870E RID: 34574
	[Nullable(2)]
	private ButtonItem BuyLevelBtn;

	// Token: 0x0400870F RID: 34575
	private bool IsRewardPanel;

	// Token: 0x04008710 RID: 34576
	[Nullable(2)]
	private ULGUISpriteData_BaseObject RedSprite;

	// Token: 0x04008711 RID: 34577
	[Nullable(2)]
	private ULGUISpriteData_BaseObject GreenSprite;

	// Token: 0x020088A9 RID: 34985
	private enum EReportOperation
	{
		// Token: 0x0402C6AA RID: 181930
		BuyLevelBtn,
		// Token: 0x0402C6AB RID: 181931
		BuyPassBtn
	}

	// Token: 0x020088AA RID: 34986
	private enum EComponents
	{
		// Token: 0x0402C6AD RID: 181933
		Panel,
		// Token: 0x0402C6AE RID: 181934
		TxtLevel,
		// Token: 0x0402C6AF RID: 181935
		ExpSlider,
		// Token: 0x0402C6B0 RID: 181936
		PicFull,
		// Token: 0x0402C6B1 RID: 181937
		TxtExp,
		// Token: 0x0402C6B2 RID: 181938
		TxtLimit,
		// Token: 0x0402C6B3 RID: 181939
		BtnBuyLevel,
		// Token: 0x0402C6B4 RID: 181940
		BtnReceive,
		// Token: 0x0402C6B5 RID: 181941
		BtnBuyPass,
		// Token: 0x0402C6B6 RID: 181942
		TxtBtnBuyPass,
		// Token: 0x0402C6B7 RID: 181943
		EffectGreen,
		// Token: 0x0402C6B8 RID: 181944
		EffectRed,
		// Token: 0x0402C6B9 RID: 181945
		PayButtonRedDotItem
	}
}
