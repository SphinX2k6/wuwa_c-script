using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002325 RID: 8997
[NullableContext(1)]
[Nullable(0)]
public class BattlePassMainView : UiViewBase
{
	// Token: 0x06011CA5 RID: 72869 RVA: 0x00460F75 File Offset: 0x0045F175
	public BattlePassMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011CA6 RID: 72870 RVA: 0x00460F8C File Offset: 0x0045F18C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06011CA7 RID: 72871 RVA: 0x0046109C File Offset: 0x0045F29C
	protected override UniTask OnBeforeStartAsync()
	{
		BattlePassMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BattlePassMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011CA8 RID: 72872 RVA: 0x004610DF File Offset: 0x0045F2DF
	protected override void OnStart()
	{
		this.TabComponent.SelectToggleByIndex(0, true);
	}

	// Token: 0x06011CA9 RID: 72873 RVA: 0x004610EE File Offset: 0x0045F2EE
	private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x06011CAA RID: 72874 RVA: 0x004610F8 File Offset: 0x0045F2F8
	private void ToggleCallBack(int index)
	{
		UiDynamicTab data = this.TabDataList[index];
		EUiTabViewName euiTabViewName = (EUiTabViewName)data.ChildViewName;
		CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
		this.TabViewComponent.ToggleCallBack(data, euiTabViewName, tabItemByIndex, this.WeaponObservers, null);
		this.RefreshTabToggleState();
		base.GetItem(2).SetUIActive(euiTabViewName != EUiTabViewName.BattlePassWeaponView);
		base.GetItem(4).SetUIActive(euiTabViewName != EUiTabViewName.BattlePassWeaponView);
		base.GetItem(5).SetUIActive(euiTabViewName != EUiTabViewName.BattlePassWeaponView);
		base.GetItem(6).SetUIActive(euiTabViewName != EUiTabViewName.BattlePassWeaponView);
		TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
		if (tabComponent != null)
		{
			tabComponent.SetPopupToggleVisible(euiTabViewName == EUiTabViewName.BattlePassWeaponView);
		}
		AdventureGuideModel.Instance.CurrentGuideTabName = new EUiTabViewName?(euiTabViewName);
	}

	// Token: 0x06011CAB RID: 72875 RVA: 0x004611D8 File Offset: 0x0045F3D8
	private void RefreshTabToggleState()
	{
		if (this.TabViewComponent.GetCurrentTabViewName(null) != EUiTabViewName.BattlePassWeaponView)
		{
			return;
		}
		BattlePassWeaponView battlePassWeaponView = this.TabViewComponent.GetCurrentTabView() as BattlePassWeaponView;
		EToggleState captionToggleState = this.TabComponent.GetCaptionToggleState();
		battlePassWeaponView.RefreshToggleState(captionToggleState);
	}

	// Token: 0x06011CAC RID: 72876 RVA: 0x00461240 File Offset: 0x0045F440
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x06011CAD RID: 72877 RVA: 0x00461278 File Offset: 0x0045F478
	private void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06011CAE RID: 72878 RVA: 0x00461281 File Offset: 0x0045F481
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnBattlePassLevelUpEvent, new Action(this.OnBattlePassLevelUp));
		EventSystem.Instance.Add<int>(EEventName.OnBattlePassSkip, new Action<int>(this.HandleOnBattlePassSkip));
	}

	// Token: 0x06011CAF RID: 72879 RVA: 0x004612BB File Offset: 0x0045F4BB
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnBattlePassLevelUpEvent, new Action(this.OnBattlePassLevelUp));
		EventSystem.Instance.Remove(EEventName.OnBattlePassSkip, new Action<int>(this.HandleOnBattlePassSkip));
	}

	// Token: 0x06011CB0 RID: 72880 RVA: 0x004612F8 File Offset: 0x0045F4F8
	private void OnBattlePassLevelUp()
	{
		UiViewBase topView = UiModel.Instance.GetTopView(ELayerType.Pop);
		if (topView == null)
		{
			topView = UiModel.Instance.GetTopView(ELayerType.Normal);
		}
		if (topView.ViewInfo.Name == this.ViewInfo.Name)
		{
			BattlePassController.Instance.TryShowUpLevelView(false);
		}
	}

	// Token: 0x06011CB1 RID: 72881 RVA: 0x0046134A File Offset: 0x0045F54A
	private void HandleOnBattlePassSkip(int skipId)
	{
		this.HandleOnBattlePassSkipImpAsync(skipId).Forget();
	}

	// Token: 0x06011CB2 RID: 72882 RVA: 0x00461358 File Offset: 0x0045F558
	private UniTask HandleOnBattlePassSkipImpAsync(int skipId)
	{
		BattlePassMainView.<HandleOnBattlePassSkipImpAsync>d__19 <HandleOnBattlePassSkipImpAsync>d__;
		<HandleOnBattlePassSkipImpAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HandleOnBattlePassSkipImpAsync>d__.<>4__this = this;
		<HandleOnBattlePassSkipImpAsync>d__.skipId = skipId;
		<HandleOnBattlePassSkipImpAsync>d__.<>1__state = -1;
		<HandleOnBattlePassSkipImpAsync>d__.<>t__builder.Start<BattlePassMainView.<HandleOnBattlePassSkipImpAsync>d__19>(ref <HandleOnBattlePassSkipImpAsync>d__);
		return <HandleOnBattlePassSkipImpAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011CB3 RID: 72883 RVA: 0x004613A4 File Offset: 0x0045F5A4
	private void OnClickPopupToggle(EToggleState state)
	{
		if (this.TabViewComponent.GetCurrentTabViewName(null) != EUiTabViewName.BattlePassWeaponView)
		{
			return;
		}
		BattlePassWeaponView battlePassWeaponView = this.TabViewComponent.GetCurrentTabView() as BattlePassWeaponView;
		if (battlePassWeaponView == null)
		{
			return;
		}
		battlePassWeaponView.OnClickFullLevelToggle(state);
	}

	// Token: 0x06011CB4 RID: 72884 RVA: 0x00461404 File Offset: 0x0045F604
	public void BindTabViewRed(EUiTabViewName tabName, ERedDotName redName)
	{
		int num = -1;
		foreach (UiDynamicTab uiDynamicTab in this.TabDataList)
		{
			num++;
			if ((EUiTabViewName)uiDynamicTab.ChildViewName == tabName)
			{
				break;
			}
		}
		this.TabComponent.GetTabItemByIndex(num).BindRedDot(redName, new int?(0));
	}

	// Token: 0x06011CB5 RID: 72885 RVA: 0x00461484 File Offset: 0x0045F684
	private void UnBindTabViewRed(EUiTabViewName tab)
	{
		int num = -1;
		foreach (UiDynamicTab uiDynamicTab in this.TabDataList)
		{
			num++;
			if ((EUiTabViewName)uiDynamicTab.ChildViewName == tab)
			{
				break;
			}
		}
		this.TabComponent.GetTabItemByIndex(num).UnBindRedDot();
	}

	// Token: 0x06011CB6 RID: 72886 RVA: 0x00461500 File Offset: 0x0045F700
	protected override void OnBeforeShow()
	{
		this.TabViewComponent.SetCurrentTabViewState(true);
		this.BindTabViewRed(EUiTabViewName.BattlePassRewardView, ERedDotName.BattlePassReward);
		this.BindTabViewRed(EUiTabViewName.BattlePassTaskView, ERedDotName.BattlePassTask);
	}

	// Token: 0x06011CB7 RID: 72887 RVA: 0x00461528 File Offset: 0x0045F728
	protected override void OnAfterHide()
	{
		EventSystem.Instance.Emit(EEventName.BattlePassMainViewHide);
		this.TabViewComponent.SetCurrentTabViewState(false);
		this.UnBindTabViewRed(EUiTabViewName.BattlePassRewardView);
		this.UnBindTabViewRed(EUiTabViewName.BattlePassTaskView);
	}

	// Token: 0x06011CB8 RID: 72888 RVA: 0x0046155C File Offset: 0x0045F75C
	public void RefreshLeftTime(float _)
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		double num = (double)this.PassEndTime - serverTime;
		if (num < 0.0)
		{
			if (!this.WaitToDestroy)
			{
				BattlePassController.Instance.ShowTimePassConfirm();
			}
			return;
		}
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat(num);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "Text_GachaRemainingTime_Text", new <>z__ReadOnlySingleElementList<object>(remainTimeDataFormat.CountDownText));
	}

	// Token: 0x06011CB9 RID: 72889 RVA: 0x004615CC File Offset: 0x0045F7CC
	protected override void OnBeforeDestroy()
	{
		TimerHandle timerHandle = this.TimerHandle;
		if (timerHandle != null)
		{
			timerHandle.Remove();
		}
		this.TimerHandle = null;
		if (this.TabComponent != null)
		{
			this.TabComponent.Destroy(null);
			this.TabComponent = null;
		}
		if (this.TabViewComponent != null)
		{
			this.TabViewComponent.DestroyTabViewComponent();
			this.TabViewComponent = null;
		}
		this.TabDataList = new List<UiDynamicTab>();
		UiSceneManager.Instance.DestroyWeaponObserver(this.WeaponObservers.WeaponObserver);
		UiSceneManager.Instance.DestroyWeaponScabbardObserver(this.WeaponObservers.WeaponScabbardObserver);
		this.WeaponObservers = null;
	}

	// Token: 0x06011CBA RID: 72890 RVA: 0x00461664 File Offset: 0x0045F864
	protected override void OnBeforeCreate()
	{
		SkeletalObserverHandle skeletalObserverHandle = UiSceneManager.Instance.InitWeaponObserver(true);
		UiModelBase model = skeletalObserverHandle.Model;
		UiModelLoadingIconComponent uiModelLoadingIconComponent = (model != null) ? model.CheckGetComponent<UiModelLoadingIconComponent>() : null;
		if (uiModelLoadingIconComponent != null)
		{
			uiModelLoadingIconComponent.SetLoadingActive(false);
		}
		SkeletalObserverHandle weaponScabbardObserver = UiSceneManager.Instance.InitWeaponScabbardObserver();
		this.WeaponObservers = new WeaponSkeletalObserverHandles(skeletalObserverHandle, weaponScabbardObserver);
	}

	// Token: 0x040086E3 RID: 34531
	[Nullable(2)]
	protected TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x040086E4 RID: 34532
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

	// Token: 0x040086E5 RID: 34533
	protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x040086E6 RID: 34534
	private long PassEndTime;

	// Token: 0x040086E7 RID: 34535
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x040086E8 RID: 34536
	[Nullable(2)]
	private WeaponSkeletalObserverHandles WeaponObservers;

	// Token: 0x020088A0 RID: 34976
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402C679 RID: 181881
		TabComponent,
		// Token: 0x0402C67A RID: 181882
		TabRootItem,
		// Token: 0x0402C67B RID: 181883
		Bg,
		// Token: 0x0402C67C RID: 181884
		TxtCountDown,
		// Token: 0x0402C67D RID: 181885
		EffectPanel1,
		// Token: 0x0402C67E RID: 181886
		EffectPanel2,
		// Token: 0x0402C67F RID: 181887
		EffectPanel3
	}
}
