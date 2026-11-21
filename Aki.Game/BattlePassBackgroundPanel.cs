using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200180E RID: 6158
public class BattlePassBackgroundPanel : UiPanelBase
{
	// Token: 0x0600F1D6 RID: 61910 RVA: 0x00470BDC File Offset: 0x0046EDDC
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

	// Token: 0x0600F1D7 RID: 61911 RVA: 0x00470E18 File Offset: 0x0046F018
	private void OnClickBuyLevelBtn(int _)
	{
		UiManager.Instance.OpenView(EUiViewName.BattlePassBuyLevelView, null, null);
		OnBattlePassOperationLogEvent onBattlePassOperationLogEvent = new OnBattlePassOperationLogEvent();
		onBattlePassOperationLogEvent.i_operation_type = 0;
		LogReportController.Instance.LogReport(onBattlePassOperationLogEvent);
	}

	// Token: 0x0600F1D8 RID: 61912 RVA: 0x00470E50 File Offset: 0x0046F050
	private void OnClickBuyPassBtn()
	{
		BattlePassBackgroundPanelParam battlePassBackgroundPanelParam = (BattlePassBackgroundPanelParam)this.OpenParam;
		BattlePassModel.Instance.PayButtonRedDotState = false;
		UiManager.Instance.OpenView(EUiViewName.BattlePassPayView, battlePassBackgroundPanelParam.WeaponObservers, null);
		OnBattlePassOperationLogEvent onBattlePassOperationLogEvent = new OnBattlePassOperationLogEvent();
		onBattlePassOperationLogEvent.i_operation_type = 1;
		LogReportController.Instance.LogReport(onBattlePassOperationLogEvent);
	}

	// Token: 0x0600F1D9 RID: 61913 RVA: 0x00470EA2 File Offset: 0x0046F0A2
	private void OnClickReceiveBtn()
	{
		if (this.IsRewardPanel)
		{
			BattlePassController.Instance.RequestTakeAllRewardResponse();
			return;
		}
		BattlePassController.Instance.TryRequestTaskList(BattlePassModel.Instance.GetAllFinishedTask());
	}

	// Token: 0x0600F1DA RID: 61914 RVA: 0x00470ECC File Offset: 0x0046F0CC
	protected override UniTask OnCreateAsync()
	{
		BattlePassBackgroundPanel.<OnCreateAsync>d__10 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<BattlePassBackgroundPanel.<OnCreateAsync>d__10>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F1DB RID: 61915 RVA: 0x00470F10 File Offset: 0x0046F110
	private UniTask LoadRedSprite()
	{
		BattlePassBackgroundPanel.<LoadRedSprite>d__11 <LoadRedSprite>d__;
		<LoadRedSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadRedSprite>d__.<>4__this = this;
		<LoadRedSprite>d__.<>1__state = -1;
		<LoadRedSprite>d__.<>t__builder.Start<BattlePassBackgroundPanel.<LoadRedSprite>d__11>(ref <LoadRedSprite>d__);
		return <LoadRedSprite>d__.<>t__builder.Task;
	}

	// Token: 0x0600F1DC RID: 61916 RVA: 0x00470F54 File Offset: 0x0046F154
	private UniTask LoadGreenSprite()
	{
		BattlePassBackgroundPanel.<LoadGreenSprite>d__12 <LoadGreenSprite>d__;
		<LoadGreenSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadGreenSprite>d__.<>4__this = this;
		<LoadGreenSprite>d__.<>1__state = -1;
		<LoadGreenSprite>d__.<>t__builder.Start<BattlePassBackgroundPanel.<LoadGreenSprite>d__12>(ref <LoadGreenSprite>d__);
		return <LoadGreenSprite>d__.<>t__builder.Task;
	}

	// Token: 0x0600F1DD RID: 61917 RVA: 0x00470F98 File Offset: 0x0046F198
	protected void AddEventListener()
	{
		EventSystem.Instance.Add<int?>(EEventName.GetBattlePassRewardEvent, new Action<int?>(this.OnGetBattlePassRewardEvent));
		EventSystem.Instance.Add(EEventName.UpdateBattlePassTaskEvent, new Action(this.RefreshButton));
		EventSystem.Instance.Add(EEventName.ReceiveBattlePassDataEvent, new Action(this.RefreshMainView));
		EventSystem.Instance.Add(EEventName.NotifyBattlePassToBuyEvent, new Action(this.OnClickBuyPassBtn));
	}

	// Token: 0x0600F1DE RID: 61918 RVA: 0x00471018 File Offset: 0x0046F218
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GetBattlePassRewardEvent, new Action<int?>(this.OnGetBattlePassRewardEvent));
		EventSystem.Instance.Remove(EEventName.UpdateBattlePassTaskEvent, new Action(this.RefreshButton));
		EventSystem.Instance.Remove(EEventName.ReceiveBattlePassDataEvent, new Action(this.RefreshMainView));
		EventSystem.Instance.Remove(EEventName.NotifyBattlePassToBuyEvent, new Action(this.OnClickBuyPassBtn));
	}

	// Token: 0x0600F1DF RID: 61919 RVA: 0x00471098 File Offset: 0x0046F298
	protected override void OnStart()
	{
		this.BuyLevelBtn = new ButtonItem(base.GetItem(6));
		this.BuyLevelBtn.SetFunction(new Action<int>(this.OnClickBuyLevelBtn));
		BattlePassBackgroundPanelParam battlePassBackgroundPanelParam = (BattlePassBackgroundPanelParam)this.OpenParam;
		this.IsRewardPanel = battlePassBackgroundPanelParam.IsRewardPanel;
		this.RefreshMainView();
		this.AddEventListener();
	}

	// Token: 0x0600F1E0 RID: 61920 RVA: 0x004710F2 File Offset: 0x0046F2F2
	protected override void OnBeforeShow()
	{
		base.GetItem(10).SetUIActive(false);
		base.GetItem(11).SetUIActive(false);
		RedDotController.Instance.BindRedDot(ERedDotName.BattlePassPayButton, base.GetItem(12), null, 0);
	}

	// Token: 0x0600F1E1 RID: 61921 RVA: 0x00471129 File Offset: 0x0046F329
	protected override void OnBeforeHide()
	{
		RedDotController.Instance.UnBindRedDot(ERedDotName.BattlePassPayButton);
	}

	// Token: 0x0600F1E2 RID: 61922 RVA: 0x0047113A File Offset: 0x0046F33A
	protected override void OnAfterShow()
	{
		base.AddChild(this.BuyLevelBtn);
	}

	// Token: 0x0600F1E3 RID: 61923 RVA: 0x00471148 File Offset: 0x0046F348
	private void OnGetBattlePassRewardEvent(int? _)
	{
		this.RefreshButton();
	}

	// Token: 0x0600F1E4 RID: 61924 RVA: 0x00471150 File Offset: 0x0046F350
	private void RefreshButton()
	{
		if (this.IsRewardPanel)
		{
			base.GetButton(7).RootUIComp.Get().SetUIActive(BattlePassModel.Instance.CheckHasRewardWaitTake());
			return;
		}
		base.GetButton(7).RootUIComp.Get().SetUIActive(BattlePassModel.Instance.CheckHasTaskWaitTake());
	}

	// Token: 0x0600F1E5 RID: 61925 RVA: 0x004711AC File Offset: 0x0046F3AC
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

	// Token: 0x0600F1E6 RID: 61926 RVA: 0x0047131E File Offset: 0x0046F51E
	protected override void OnBeforeDestroy()
	{
		this.BuyLevelBtn = null;
		this.RemoveEventListener();
		this.RedSprite = null;
		this.GreenSprite = null;
	}

	// Token: 0x04008851 RID: 34897
	[Nullable(2)]
	private ButtonItem BuyLevelBtn;

	// Token: 0x04008852 RID: 34898
	private bool IsRewardPanel;

	// Token: 0x04008853 RID: 34899
	[Nullable(2)]
	private ULGUISpriteData_BaseObject RedSprite;

	// Token: 0x04008854 RID: 34900
	[Nullable(2)]
	private ULGUISpriteData_BaseObject GreenSprite;

	// Token: 0x02007A32 RID: 31282
	private enum EReportOperation
	{
		// Token: 0x040279BE RID: 162238
		BuyLevelBtn,
		// Token: 0x040279BF RID: 162239
		BuyPassBtn
	}

	// Token: 0x02007A33 RID: 31283
	private enum EComponents
	{
		// Token: 0x040279C1 RID: 162241
		Panel,
		// Token: 0x040279C2 RID: 162242
		TxtLevel,
		// Token: 0x040279C3 RID: 162243
		ExpSlider,
		// Token: 0x040279C4 RID: 162244
		PicFull,
		// Token: 0x040279C5 RID: 162245
		TxtExp,
		// Token: 0x040279C6 RID: 162246
		TxtLimit,
		// Token: 0x040279C7 RID: 162247
		BtnBuyLevel,
		// Token: 0x040279C8 RID: 162248
		BtnReceive,
		// Token: 0x040279C9 RID: 162249
		BtnBuyPass,
		// Token: 0x040279CA RID: 162250
		TxtBtnBuyPass,
		// Token: 0x040279CB RID: 162251
		EffectGreen,
		// Token: 0x040279CC RID: 162252
		EffectRed,
		// Token: 0x040279CD RID: 162253
		PayButtonRedDotItem
	}
}
