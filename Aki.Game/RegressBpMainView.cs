using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000934 RID: 2356
[NullableContext(2)]
[Nullable(0)]
public class RegressBpMainView : ActivityRegressMainSubViewBase
{
	// Token: 0x06006805 RID: 26629 RVA: 0x002085F8 File Offset: 0x002067F8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickBtnBuyExp)),
			new ValueTuple<int, Delegate>(7, new Action(this.OnClickBtnClaimAll)),
			new ValueTuple<int, Delegate>(8, new Action(this.OnClickBtnPay))
		};
	}

	// Token: 0x06006806 RID: 26630 RVA: 0x00208740 File Offset: 0x00206940
	protected override void OnUpdate(int subTabIndex)
	{
		this.RefreshButton();
		this.RefreshSubView();
	}

	// Token: 0x06006807 RID: 26631 RVA: 0x00208750 File Offset: 0x00206950
	protected override UniTask OnBeforeStartAsync()
	{
		RegressBpMainView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RegressBpMainView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006808 RID: 26632 RVA: 0x00208793 File Offset: 0x00206993
	private void OnInventoryUpdate(int configId, int count)
	{
		if (configId == 20)
		{
			this.RefreshSubView();
		}
	}

	// Token: 0x06006809 RID: 26633 RVA: 0x002087A0 File Offset: 0x002069A0
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnInventoryUpdate));
		EventSystem.Instance.Add(EEventName.RegressBpExpAnim, new Action<int, int, float, float>(this.EventRegressBpExpAnim));
		this.RefreshView(true);
	}

	// Token: 0x0600680A RID: 26634 RVA: 0x002087F4 File Offset: 0x002069F4
	protected override void OnBeforeHide()
	{
		base.OnBeforeHide();
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnInventoryUpdate));
		EventSystem.Instance.Remove(EEventName.RegressBpExpAnim, new Action<int, int, float, float>(this.EventRegressBpExpAnim));
		this.KillExpTween();
	}

	// Token: 0x0600680B RID: 26635 RVA: 0x00208845 File Offset: 0x00206A45
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		this.KillExpTween();
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.OnExpTweenUpdate));
	}

	// Token: 0x0600680C RID: 26636 RVA: 0x00208864 File Offset: 0x00206A64
	private void RefreshView(bool playAnim = false)
	{
		IRegressLevelProgressData curLevelProgressData = ActivityRegressModel.Instance.ActivityData.GetCurLevelProgressData();
		base.GetText(2).SetText(curLevelProgressData.Level.ToString(), true);
		UUIText text = base.GetText(3);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(curLevelProgressData.CurScore);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(curLevelProgressData.NeedScore);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		base.GetSprite(4).SetFillAmount((float)curLevelProgressData.CurScore / (float)curLevelProgressData.NeedScore);
		this.RefreshButton();
		this.RefreshSubView(playAnim);
	}

	// Token: 0x0600680D RID: 26637 RVA: 0x0020890C File Offset: 0x00206B0C
	private void RefreshButton()
	{
		IRegressLevelProgressData curLevelProgressData = ActivityRegressModel.Instance.ActivityData.GetCurLevelProgressData();
		base.GetButton(5).SetSelfInteractive(curLevelProgressData.Level < curLevelProgressData.MaxLevel);
		base.GetButton(8).RootUIComp.Get().SetUIActive(!ActivityRegressModel.Instance.ActivityData.IsPayRewardUnlock());
		base.GetItem(9).SetUIActive(ActivityRegressModel.Instance.ActivityData.CheckBpPayButtonRedDot());
	}

	// Token: 0x0600680E RID: 26638 RVA: 0x0020898C File Offset: 0x00206B8C
	private void RefreshSubView(bool playAnim = false)
	{
		TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
		IRegressBpTabView regressBpTabView = ((tabViewComponent != null) ? tabViewComponent.GetCurrentTabView() : null) as IRegressBpTabView;
		if (regressBpTabView != null)
		{
			regressBpTabView.RefreshView(playAnim);
		}
		if (regressBpTabView == null)
		{
			return;
		}
		regressBpTabView.RefreshBtnClaimVisible(base.GetButton(7).RootUIComp.Get());
	}

	// Token: 0x0600680F RID: 26639 RVA: 0x002089DB File Offset: 0x00206BDB
	private void RefreshSubView()
	{
		this.RefreshSubView(false);
	}

	// Token: 0x06006810 RID: 26640 RVA: 0x002089E4 File Offset: 0x00206BE4
	[NullableContext(1)]
	public List<CommonTabItemData> CreateTabItemDataByLength(int length)
	{
		Dictionary<EUiTabViewName, ERedDotName> dictionary = new Dictionary<EUiTabViewName, ERedDotName>();
		dictionary[EUiTabViewName.RegressBpRewardTabView] = ERedDotName.ActivityRegressBpReward;
		dictionary[EUiTabViewName.RegressBpTaskTabView] = ERedDotName.ActivityRegressBpTask;
		List<CommonTabItemData> list = new List<CommonTabItemData>();
		for (int i = 0; i < length; i++)
		{
			CommonTabItemData commonTabItemData = new CommonTabItemData();
			commonTabItemData.Index = i;
			UiDynamicTab uiDynamicTab = this.TabDataList[i];
			commonTabItemData.Data = new CommonTabData("", new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
			ERedDotName value;
			if (dictionary.TryGetValue((EUiTabViewName)uiDynamicTab.ChildViewName, out value))
			{
				commonTabItemData.RedDotName = new ERedDotName?(value);
			}
			list.Add(commonTabItemData);
		}
		return list;
	}

	// Token: 0x06006811 RID: 26641 RVA: 0x00208A91 File Offset: 0x00206C91
	[NullableContext(1)]
	private RegressBpTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new RegressBpTabItem();
	}

	// Token: 0x06006812 RID: 26642 RVA: 0x00208A98 File Offset: 0x00206C98
	private void ToggleCallBack(int index)
	{
		UiDynamicTab data = this.TabDataList[index];
		TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
		if (tabViewComponent != null)
		{
			tabViewComponent.ToggleCallBack(data, (EUiTabViewName)data.ChildViewName, null, null, null);
		}
		TabViewComponent<UiDynamicTab> tabViewComponent2 = this.TabViewComponent;
		IRegressBpTabView regressBpTabView = ((tabViewComponent2 != null) ? tabViewComponent2.GetCurrentTabView() : null) as IRegressBpTabView;
		if (regressBpTabView != null)
		{
			regressBpTabView.RefreshBtnClaimVisible(base.GetButton(7).RootUIComp.Get());
		}
		UiSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.StopSequenceByKey("Switch", false, false);
		}
		UiSequencePlayer sequencePlayer2 = this.SequencePlayer;
		if (sequencePlayer2 == null)
		{
			return;
		}
		sequencePlayer2.PlaySequence("Switch", false, null);
	}

	// Token: 0x06006813 RID: 26643 RVA: 0x00208B48 File Offset: 0x00206D48
	private void OnClickBtnBuyExp()
	{
		UiManager.Instance.OpenView(EUiViewName.RegressBpBuyLevelView, null, null);
	}

	// Token: 0x06006814 RID: 26644 RVA: 0x00208B5B File Offset: 0x00206D5B
	private void OnClickBtnClaimAll()
	{
		TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
		IRegressBpTabView regressBpTabView = ((tabViewComponent != null) ? tabViewComponent.GetCurrentTabView() : null) as IRegressBpTabView;
		if (regressBpTabView == null)
		{
			return;
		}
		regressBpTabView.OnClickBtnClaimAll();
	}

	// Token: 0x06006815 RID: 26645 RVA: 0x00208B80 File Offset: 0x00206D80
	private void OnClickBtnPay()
	{
		ActivityRegressModel.Instance.ActivityData.SetBpPayButtonRedDotChecked();
		UiManager.Instance.OpenView(EUiViewName.RegressBpPayView, null, delegate(bool success, int viewId)
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.ActivityRegressMainView);
			if (viewByName == null)
			{
				return;
			}
			viewByName.AddChildViewById(viewId);
		});
		this.RefreshView(false);
	}

	// Token: 0x06006816 RID: 26646 RVA: 0x00208BD2 File Offset: 0x00206DD2
	private void EventRegressBpExpAnim(int prevLevel, int curLevel, float startFillAmount, float endFillAmount)
	{
		this.OnRegressBpExpAnim(prevLevel, curLevel, startFillAmount, endFillAmount);
	}

	// Token: 0x06006817 RID: 26647 RVA: 0x00208BE0 File Offset: 0x00206DE0
	private UniTask OnRegressBpExpAnim(int prevLevel, int curLevel, float startFillAmount, float endFillAmount)
	{
		RegressBpMainView.<OnRegressBpExpAnim>d__26 <OnRegressBpExpAnim>d__;
		<OnRegressBpExpAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnRegressBpExpAnim>d__.<>4__this = this;
		<OnRegressBpExpAnim>d__.prevLevel = prevLevel;
		<OnRegressBpExpAnim>d__.curLevel = curLevel;
		<OnRegressBpExpAnim>d__.startFillAmount = startFillAmount;
		<OnRegressBpExpAnim>d__.endFillAmount = endFillAmount;
		<OnRegressBpExpAnim>d__.<>1__state = -1;
		<OnRegressBpExpAnim>d__.<>t__builder.Start<RegressBpMainView.<OnRegressBpExpAnim>d__26>(ref <OnRegressBpExpAnim>d__);
		return <OnRegressBpExpAnim>d__.<>t__builder.Task;
	}

	// Token: 0x06006818 RID: 26648 RVA: 0x00208C44 File Offset: 0x00206E44
	private UniTask PlayExpBarAnim(float startFillAmount, float endFillAmount)
	{
		RegressBpMainView.<PlayExpBarAnim>d__27 <PlayExpBarAnim>d__;
		<PlayExpBarAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayExpBarAnim>d__.<>4__this = this;
		<PlayExpBarAnim>d__.startFillAmount = startFillAmount;
		<PlayExpBarAnim>d__.endFillAmount = endFillAmount;
		<PlayExpBarAnim>d__.<>1__state = -1;
		<PlayExpBarAnim>d__.<>t__builder.Start<RegressBpMainView.<PlayExpBarAnim>d__27>(ref <PlayExpBarAnim>d__);
		return <PlayExpBarAnim>d__.<>t__builder.Task;
	}

	// Token: 0x06006819 RID: 26649 RVA: 0x00208C98 File Offset: 0x00206E98
	private void OnExpTweenUpdate(float value)
	{
		UUISprite sprite = base.GetSprite(4);
		if (sprite != null)
		{
			sprite.SetFillAmount(value);
		}
	}

	// Token: 0x0600681A RID: 26650 RVA: 0x00208CB7 File Offset: 0x00206EB7
	private void OnExpTweenComplete()
	{
		this.KillExpTween();
	}

	// Token: 0x0600681B RID: 26651 RVA: 0x00208CC0 File Offset: 0x00206EC0
	private void KillExpTween()
	{
		if (this.BarAnimPromise != null)
		{
			this.BarAnimPromise.SetResult();
			this.BarAnimPromise = null;
		}
		if (this.ExpTweener != null && this.ExpTweener.IsValid())
		{
			this.ExpTweener.Kill(false);
		}
		this.ExpTweener = null;
	}

	// Token: 0x04004269 RID: 17001
	private const float EXP_BAR_ANIM_DURATION = 0.4f;

	// Token: 0x0400426A RID: 17002
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<RegressBpTabItem> TabComponent;

	// Token: 0x0400426B RID: 17003
	private TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x0400426C RID: 17004
	[Nullable(1)]
	private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x0400426D RID: 17005
	private ULTweener ExpTweener;

	// Token: 0x0400426E RID: 17006
	private FLTweenFloatSetterDynamic ExpTweenDelegate;

	// Token: 0x0400426F RID: 17007
	private CustomPromise BarAnimPromise;

	// Token: 0x02006C26 RID: 27686
	[NullableContext(0)]
	private class ERegressBpComponents
	{
		// Token: 0x040238AC RID: 145580
		public const int PanelTopMenu = 0;

		// Token: 0x040238AD RID: 145581
		public const int RoleDevelopToggle = 1;

		// Token: 0x040238AE RID: 145582
		public const int TxtLevel = 2;

		// Token: 0x040238AF RID: 145583
		public const int TxtExpValue = 3;

		// Token: 0x040238B0 RID: 145584
		public const int SpriteProgressFill = 4;

		// Token: 0x040238B1 RID: 145585
		public const int BtnBuyExp = 5;

		// Token: 0x040238B2 RID: 145586
		public const int PanelContent = 6;

		// Token: 0x040238B3 RID: 145587
		public const int BtnClaimAll = 7;

		// Token: 0x040238B4 RID: 145588
		public const int BtnPay = 8;

		// Token: 0x040238B5 RID: 145589
		public const int RedDot = 9;
	}
}
