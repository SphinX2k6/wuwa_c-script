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

// Token: 0x0200180A RID: 6154
[NullableContext(1)]
[Nullable(0)]
public class BattlePassMainView : UiViewBase
{
	// Token: 0x0600F155 RID: 61781 RVA: 0x0046E019 File Offset: 0x0046C219
	public BattlePassMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F156 RID: 61782 RVA: 0x0046E030 File Offset: 0x0046C230
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

	// Token: 0x0600F157 RID: 61783 RVA: 0x0046E140 File Offset: 0x0046C340
	protected override UniTask OnBeforeStartAsync()
	{
		BattlePassMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BattlePassMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F158 RID: 61784 RVA: 0x0046E183 File Offset: 0x0046C383
	protected override void OnStart()
	{
		this.TabComponent.SelectToggleByIndex(0, true);
	}

	// Token: 0x0600F159 RID: 61785 RVA: 0x0046E192 File Offset: 0x0046C392
	private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x0600F15A RID: 61786 RVA: 0x0046E19C File Offset: 0x0046C39C
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

	// Token: 0x0600F15B RID: 61787 RVA: 0x0046E27C File Offset: 0x0046C47C
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

	// Token: 0x0600F15C RID: 61788 RVA: 0x0046E2E4 File Offset: 0x0046C4E4
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x0600F15D RID: 61789 RVA: 0x0046E31C File Offset: 0x0046C51C
	private void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F15E RID: 61790 RVA: 0x0046E325 File Offset: 0x0046C525
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnBattlePassLevelUpEvent, new Action(this.OnBattlePassLevelUp));
		EventSystem.Instance.Add<int>(EEventName.OnBattlePassSkip, new Action<int>(this.HandleOnBattlePassSkip));
	}

	// Token: 0x0600F15F RID: 61791 RVA: 0x0046E35F File Offset: 0x0046C55F
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnBattlePassLevelUpEvent, new Action(this.OnBattlePassLevelUp));
		EventSystem.Instance.Remove(EEventName.OnBattlePassSkip, new Action<int>(this.HandleOnBattlePassSkip));
	}

	// Token: 0x0600F160 RID: 61792 RVA: 0x0046E39C File Offset: 0x0046C59C
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

	// Token: 0x0600F161 RID: 61793 RVA: 0x0046E3EE File Offset: 0x0046C5EE
	private void HandleOnBattlePassSkip(int skipId)
	{
		this.HandleOnBattlePassSkipImpAsync(skipId).Forget();
	}

	// Token: 0x0600F162 RID: 61794 RVA: 0x0046E3FC File Offset: 0x0046C5FC
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

	// Token: 0x0600F163 RID: 61795 RVA: 0x0046E448 File Offset: 0x0046C648
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

	// Token: 0x0600F164 RID: 61796 RVA: 0x0046E4A8 File Offset: 0x0046C6A8
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

	// Token: 0x0600F165 RID: 61797 RVA: 0x0046E528 File Offset: 0x0046C728
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

	// Token: 0x0600F166 RID: 61798 RVA: 0x0046E5A4 File Offset: 0x0046C7A4
	protected override void OnBeforeShow()
	{
		this.TabViewComponent.SetCurrentTabViewState(true);
		this.BindTabViewRed(EUiTabViewName.BattlePassRewardView, ERedDotName.BattlePassReward);
		this.BindTabViewRed(EUiTabViewName.BattlePassTaskView, ERedDotName.BattlePassTask);
	}

	// Token: 0x0600F167 RID: 61799 RVA: 0x0046E5CC File Offset: 0x0046C7CC
	protected override void OnAfterHide()
	{
		EventSystem.Instance.Emit(EEventName.BattlePassMainViewHide);
		this.TabViewComponent.SetCurrentTabViewState(false);
		this.UnBindTabViewRed(EUiTabViewName.BattlePassRewardView);
		this.UnBindTabViewRed(EUiTabViewName.BattlePassTaskView);
	}

	// Token: 0x0600F168 RID: 61800 RVA: 0x0046E600 File Offset: 0x0046C800
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

	// Token: 0x0600F169 RID: 61801 RVA: 0x0046E670 File Offset: 0x0046C870
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

	// Token: 0x0600F16A RID: 61802 RVA: 0x0046E708 File Offset: 0x0046C908
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

	// Token: 0x04008826 RID: 34854
	[Nullable(2)]
	protected TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x04008827 RID: 34855
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

	// Token: 0x04008828 RID: 34856
	protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x04008829 RID: 34857
	private long PassEndTime;

	// Token: 0x0400882A RID: 34858
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x0400882B RID: 34859
	[Nullable(2)]
	private WeaponSkeletalObserverHandles WeaponObservers;

	// Token: 0x02007A29 RID: 31273
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402798D RID: 162189
		TabComponent,
		// Token: 0x0402798E RID: 162190
		TabRootItem,
		// Token: 0x0402798F RID: 162191
		Bg,
		// Token: 0x04027990 RID: 162192
		TxtCountDown,
		// Token: 0x04027991 RID: 162193
		EffectPanel1,
		// Token: 0x04027992 RID: 162194
		EffectPanel2,
		// Token: 0x04027993 RID: 162195
		EffectPanel3
	}
}
