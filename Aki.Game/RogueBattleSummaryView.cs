using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002772 RID: 10098
[NullableContext(1)]
[Nullable(0)]
public class RogueBattleSummaryView : UiViewBase
{
	// Token: 0x06014B2D RID: 84781 RVA: 0x0053CF23 File Offset: 0x0053B123
	public RogueBattleSummaryView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014B2E RID: 84782 RVA: 0x0053CF38 File Offset: 0x0053B138
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
	}

	// Token: 0x06014B2F RID: 84783 RVA: 0x0053CFEC File Offset: 0x0053B1EC
	protected override UniTask OnBeforeStartAsync()
	{
		RogueBattleSummaryView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleSummaryView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014B30 RID: 84784 RVA: 0x0053D028 File Offset: 0x0053B228
	protected override void OnStart()
	{
		this.TsUiSceneRoleActor = UiSceneManager.Instance.InitRoleSystemRoleActor(EUiModelUseWay.RoleInRoleView);
		TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
		object obj;
		if (tsUiSceneRoleActor == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = tsUiSceneRoleActor.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiModelDataComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 != null)
		{
			obj2.SetVisible(false);
		}
		TsUiSceneRoleActor tsUiSceneRoleActor2 = this.TsUiSceneRoleActor;
		object obj3;
		if (tsUiSceneRoleActor2 == null)
		{
			obj3 = null;
		}
		else
		{
			UiModelBase model2 = tsUiSceneRoleActor2.Model;
			obj3 = ((model2 != null) ? model2.CheckGetComponent<UiModelLoadingIconComponent>() : null);
		}
		object obj4 = obj3;
		if (obj4 != null)
		{
			obj4.SetLoadingOpen(false);
		}
		this.InitTabComponent();
		this.InitExtendToggle();
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		RogueBattleModel.Instance.CurrentMapSummaryBond = 0;
	}

	// Token: 0x06014B31 RID: 84785 RVA: 0x0053D0C5 File Offset: 0x0053B2C5
	protected override void OnBeforeShow()
	{
		this.RefreshTabListAsync().Forget();
	}

	// Token: 0x06014B32 RID: 84786 RVA: 0x0053D0D2 File Offset: 0x0053B2D2
	protected override void OnBeforeDestroy()
	{
		if (this.TabComponent != null)
		{
			this.TabComponent.Destroy(null);
			this.TabComponent = null;
		}
	}

	// Token: 0x06014B33 RID: 84787 RVA: 0x0053D0EF File Offset: 0x0053B2EF
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RogueResMapSummaryTeamToBondUpdate, new Action(this.OnJumpToBondTab));
	}

	// Token: 0x06014B34 RID: 84788 RVA: 0x0053D10D File Offset: 0x0053B30D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RogueResMapSummaryTeamToBondUpdate, new Action(this.OnJumpToBondTab));
	}

	// Token: 0x06014B35 RID: 84789 RVA: 0x0053D12C File Offset: 0x0053B32C
	protected override void OnHandleLoadScene()
	{
		if (this.TsUiSceneRoleActor == null)
		{
			this.TsUiSceneRoleActor = UiSceneManager.Instance.InitRoleSystemRoleActor(EUiModelUseWay.RoleInRoleView);
		}
		UiModelBase model = this.TsUiSceneRoleActor.Model;
		UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
		if (uiModelActorComponent != null)
		{
			uiModelActorComponent.SetTransformByTag("RoleCase");
		}
		if (this.CurSelectTabView == EUiTabViewName.RogueBattleSummaryTeamTabView)
		{
			EventSystem.Instance.Emit(EEventName.RogueResMapSummaryTeamShowAgain);
		}
	}

	// Token: 0x06014B36 RID: 84790 RVA: 0x0053D1B1 File Offset: 0x0053B3B1
	protected override void OnHandleReleaseScene()
	{
		UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.TsUiSceneRoleActor);
		this.TsUiSceneRoleActor = null;
	}

	// Token: 0x06014B37 RID: 84791 RVA: 0x0053D1CB File Offset: 0x0053B3CB
	private void OnCloseClicked()
	{
		base.CloseMe(null);
	}

	// Token: 0x06014B38 RID: 84792 RVA: 0x0053D1D4 File Offset: 0x0053B3D4
	protected void InitTabComponent()
	{
		CommonTabComponentData<CommonTabItem> data = new CommonTabComponentData<CommonTabItem>(new Func<UUIItem, int?, CommonTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
		this.TabComponent = new TabComponentWithCaptionItem<CommonTabItem>(base.GetItem(0), data, new Action(this.OnCloseClicked), false);
		this.LastClickTime = null;
		this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
		this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(1), EKeyMode.Default);
	}

	// Token: 0x06014B39 RID: 84793 RVA: 0x0053D264 File Offset: 0x0053B464
	protected void InitExtendToggle()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(4);
		EToggleState state = (RogueBattleModel.Instance.DescMode == EDescModel.DETAIL) ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(state, false, false, false);
		}
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnExtendToggleStateChange));
	}

	// Token: 0x06014B3A RID: 84794 RVA: 0x0053D2B8 File Offset: 0x0053B4B8
	private UniTask RefreshTabListAsync()
	{
		RogueBattleSummaryView.<RefreshTabListAsync>d__19 <RefreshTabListAsync>d__;
		<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabListAsync>d__.<>4__this = this;
		<RefreshTabListAsync>d__.<>1__state = -1;
		<RefreshTabListAsync>d__.<>t__builder.Start<RogueBattleSummaryView.<RefreshTabListAsync>d__19>(ref <RefreshTabListAsync>d__);
		return <RefreshTabListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014B3B RID: 84795 RVA: 0x0053D2FC File Offset: 0x0053B4FC
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x06014B3C RID: 84796 RVA: 0x0053D334 File Offset: 0x0053B534
	protected bool CanToggleChange(int index, bool? _)
	{
		if (Info.Instance.IsInGamepad())
		{
			return true;
		}
		int? intConfig = ConfigCommonParamById.GetIntConfig("panel_interval_time");
		if (this.LastClickTime != null)
		{
			double num = Time.Instance.Now - this.LastClickTime.Value;
			int? num2 = intConfig;
			double? num3 = (num2 != null) ? new double?((double)num2.GetValueOrDefault()) : null;
			if (!(num >= num3.GetValueOrDefault() & num3 != null))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06014B3D RID: 84797 RVA: 0x0053D3BA File Offset: 0x0053B5BA
	private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x06014B3E RID: 84798 RVA: 0x0053D3C4 File Offset: 0x0053B5C4
	private void ToggleCallBack(int index)
	{
		this.LastClickTime = new double?(Time.Instance.Now);
		UiDynamicTab data = this.TabDataList[index];
		EUiTabViewName euiTabViewName = (EUiTabViewName)data.ChildViewName;
		this.OnTeamTabShow(euiTabViewName == EUiTabViewName.RogueBattleSummaryTeamTabView);
		this.OnTokenTabShow(euiTabViewName == EUiTabViewName.RogueBattleSummaryTokenTabView);
		CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
		this.TabViewComponent.ToggleCallBack(data, euiTabViewName, tabItemByIndex, null, null);
		this.CurSelectTabView = new EUiTabViewName?(euiTabViewName);
		this.RefreshTabHelpId(euiTabViewName);
		this.RefreshElementInfo(euiTabViewName);
	}

	// Token: 0x06014B3F RID: 84799 RVA: 0x0053D464 File Offset: 0x0053B664
	private void OnTeamTabShow(bool isVisible)
	{
		TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
		object obj;
		if (tsUiSceneRoleActor == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = tsUiSceneRoleActor.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiModelDataComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 != null)
		{
			obj2.SetVisible(isVisible);
		}
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(!isVisible);
	}

	// Token: 0x06014B40 RID: 84800 RVA: 0x0053D4B4 File Offset: 0x0053B6B4
	private void OnTokenTabShow(bool isOpen)
	{
		if (!isOpen)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
			return;
		}
		else
		{
			bool flag = RogueBattleModel.Instance.GetTokenData().Count == 0;
			UUIItem item3 = base.GetItem(2);
			if (item3 != null)
			{
				item3.SetUIActive(flag);
			}
			UUIItem item4 = base.GetItem(6);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(!flag);
			return;
		}
	}

	// Token: 0x06014B41 RID: 84801 RVA: 0x0053D525 File Offset: 0x0053B725
	private void OnExtendToggleStateChange(EToggleState newState)
	{
		RogueBattleModel.Instance.ChangeDescMode();
	}

	// Token: 0x06014B42 RID: 84802 RVA: 0x0053D534 File Offset: 0x0053B734
	private void OnJumpToBondTab()
	{
		for (int i = 0; i < this.TabDataList.Count; i++)
		{
			if ((EUiTabViewName)this.TabDataList[i].ChildViewName == EUiTabViewName.RogueBattleMapSummaryFettersTabView)
			{
				this.TabComponent.SelectToggleByIndex(i, false);
				return;
			}
		}
	}

	// Token: 0x06014B43 RID: 84803 RVA: 0x0053D58A File Offset: 0x0053B78A
	private void RefreshElementInfo(EUiTabViewName viewName)
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06014B44 RID: 84804 RVA: 0x0053D59E File Offset: 0x0053B79E
	private void RefreshTabHelpId(EUiTabViewName viewName)
	{
		this.TabComponent.SetHelpButtonShowState(false);
	}

	// Token: 0x04009BAA RID: 39850
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

	// Token: 0x04009BAB RID: 39851
	[Nullable(2)]
	protected TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x04009BAC RID: 39852
	private double? LastClickTime;

	// Token: 0x04009BAD RID: 39853
	protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x04009BAE RID: 39854
	private EUiTabViewName? CurSelectTabView;

	// Token: 0x04009BAF RID: 39855
	[Nullable(2)]
	private TsUiSceneRoleActor TsUiSceneRoleActor;
}
