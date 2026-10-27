using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001480 RID: 5248
[NullableContext(2)]
[Nullable(0)]
public class RegressBpMainView : ActivityRegressMainSubViewBase
{
	// Token: 0x06009470 RID: 38000 RVA: 0x001FF694 File Offset: 0x001FD894
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

	// Token: 0x06009471 RID: 38001 RVA: 0x001FF7DC File Offset: 0x001FD9DC
	protected override void OnUpdate(int subTabIndex)
	{
		this.RefreshButton();
		this.RefreshSubView();
	}

	// Token: 0x06009472 RID: 38002 RVA: 0x001FF7EC File Offset: 0x001FD9EC
	protected override UniTask OnBeforeStartAsync()
	{
		RegressBpMainView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RegressBpMainView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009473 RID: 38003 RVA: 0x001FF82F File Offset: 0x001FDA2F
	private void OnInventoryUpdate(int configId, int count)
	{
		if (configId == 20)
		{
			this.RefreshSubView();
		}
	}

	// Token: 0x06009474 RID: 38004 RVA: 0x001FF83C File Offset: 0x001FDA3C
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnInventoryUpdate));
		EventSystem.Instance.Add(EEventName.RegressBpExpAnim, new Action<int, int, float, float>(this.EventRegressBpExpAnim));
		this.RefreshView(true);
	}

	// Token: 0x06009475 RID: 38005 RVA: 0x001FF890 File Offset: 0x001FDA90
	protected override void OnBeforeHide()
	{
		base.OnBeforeHide();
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnInventoryUpdate));
		EventSystem.Instance.Remove(EEventName.RegressBpExpAnim, new Action<int, int, float, float>(this.EventRegressBpExpAnim));
		this.KillExpTween();
	}

	// Token: 0x06009476 RID: 38006 RVA: 0x001FF8E1 File Offset: 0x001FDAE1
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		this.KillExpTween();
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.OnExpTweenUpdate));
	}

	// Token: 0x06009477 RID: 38007 RVA: 0x001FF900 File Offset: 0x001FDB00
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

	// Token: 0x06009478 RID: 38008 RVA: 0x001FF9A8 File Offset: 0x001FDBA8
	private void RefreshButton()
	{
		IRegressLevelProgressData curLevelProgressData = ActivityRegressModel.Instance.ActivityData.GetCurLevelProgressData();
		base.GetButton(5).SetSelfInteractive(curLevelProgressData.Level < curLevelProgressData.MaxLevel);
		base.GetButton(8).RootUIComp.Get().SetUIActive(!ActivityRegressModel.Instance.ActivityData.IsPayRewardUnlock());
		base.GetItem(9).SetUIActive(ActivityRegressModel.Instance.ActivityData.CheckBpPayButtonRedDot());
	}

	// Token: 0x06009479 RID: 38009 RVA: 0x001FFA28 File Offset: 0x001FDC28
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

	// Token: 0x0600947A RID: 38010 RVA: 0x001FFA77 File Offset: 0x001FDC77
	private void RefreshSubView()
	{
		this.RefreshSubView(false);
	}

	// Token: 0x0600947B RID: 38011 RVA: 0x001FFA80 File Offset: 0x001FDC80
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

	// Token: 0x0600947C RID: 38012 RVA: 0x001FFB2D File Offset: 0x001FDD2D
	[NullableContext(1)]
	private RegressBpTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new RegressBpTabItem();
	}

	// Token: 0x0600947D RID: 38013 RVA: 0x001FFB34 File Offset: 0x001FDD34
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

	// Token: 0x0600947E RID: 38014 RVA: 0x001FFBE4 File Offset: 0x001FDDE4
	private void OnClickBtnBuyExp()
	{
		UiManager.Instance.OpenView(EUiViewName.RegressBpBuyLevelView, null, null);
	}

	// Token: 0x0600947F RID: 38015 RVA: 0x001FFBF7 File Offset: 0x001FDDF7
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

	// Token: 0x06009480 RID: 38016 RVA: 0x001FFC1C File Offset: 0x001FDE1C
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

	// Token: 0x06009481 RID: 38017 RVA: 0x001FFC6E File Offset: 0x001FDE6E
	private void EventRegressBpExpAnim(int prevLevel, int curLevel, float startFillAmount, float endFillAmount)
	{
		this.OnRegressBpExpAnim(prevLevel, curLevel, startFillAmount, endFillAmount);
	}

	// Token: 0x06009482 RID: 38018 RVA: 0x001FFC7C File Offset: 0x001FDE7C
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

	// Token: 0x06009483 RID: 38019 RVA: 0x001FFCE0 File Offset: 0x001FDEE0
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

	// Token: 0x06009484 RID: 38020 RVA: 0x001FFD34 File Offset: 0x001FDF34
	private void OnExpTweenUpdate(float value)
	{
		UUISprite sprite = base.GetSprite(4);
		if (sprite != null)
		{
			sprite.SetFillAmount(value);
		}
	}

	// Token: 0x06009485 RID: 38021 RVA: 0x001FFD53 File Offset: 0x001FDF53
	private void OnExpTweenComplete()
	{
		this.KillExpTween();
	}

	// Token: 0x06009486 RID: 38022 RVA: 0x001FFD5C File Offset: 0x001FDF5C
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

	// Token: 0x040041D1 RID: 16849
	private const float EXP_BAR_ANIM_DURATION = 0.4f;

	// Token: 0x040041D2 RID: 16850
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<RegressBpTabItem> TabComponent;

	// Token: 0x040041D3 RID: 16851
	private TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x040041D4 RID: 16852
	[Nullable(1)]
	private List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x040041D5 RID: 16853
	private ULTweener ExpTweener;

	// Token: 0x040041D6 RID: 16854
	private FLTweenFloatSetterDynamic ExpTweenDelegate;

	// Token: 0x040041D7 RID: 16855
	private CustomPromise BarAnimPromise;

	// Token: 0x02007AA2 RID: 31394
	[NullableContext(0)]
	private class ERegressBpComponents
	{
		// Token: 0x04028592 RID: 165266
		public const int PanelTopMenu = 0;

		// Token: 0x04028593 RID: 165267
		public const int RoleDevelopToggle = 1;

		// Token: 0x04028594 RID: 165268
		public const int TxtLevel = 2;

		// Token: 0x04028595 RID: 165269
		public const int TxtExpValue = 3;

		// Token: 0x04028596 RID: 165270
		public const int SpriteProgressFill = 4;

		// Token: 0x04028597 RID: 165271
		public const int BtnBuyExp = 5;

		// Token: 0x04028598 RID: 165272
		public const int PanelContent = 6;

		// Token: 0x04028599 RID: 165273
		public const int BtnClaimAll = 7;

		// Token: 0x0402859A RID: 165274
		public const int BtnPay = 8;

		// Token: 0x0402859B RID: 165275
		public const int RedDot = 9;
	}
}
