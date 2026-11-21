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

// Token: 0x02001C5D RID: 7261
[NullableContext(1)]
[Nullable(0)]
public class RogueBattleSummaryView : UiViewBase
{
	// Token: 0x06012010 RID: 73744 RVA: 0x0054BD33 File Offset: 0x00549F33
	public RogueBattleSummaryView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012011 RID: 73745 RVA: 0x0054BD48 File Offset: 0x00549F48
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

	// Token: 0x06012012 RID: 73746 RVA: 0x0054BDFC File Offset: 0x00549FFC
	protected override UniTask OnBeforeStartAsync()
	{
		RogueBattleSummaryView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleSummaryView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012013 RID: 73747 RVA: 0x0054BE38 File Offset: 0x0054A038
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

	// Token: 0x06012014 RID: 73748 RVA: 0x0054BED5 File Offset: 0x0054A0D5
	protected override void OnBeforeShow()
	{
		this.RefreshTabListAsync().Forget();
	}

	// Token: 0x06012015 RID: 73749 RVA: 0x0054BEE2 File Offset: 0x0054A0E2
	protected override void OnBeforeDestroy()
	{
		if (this.TabComponent != null)
		{
			this.TabComponent.Destroy(null);
			this.TabComponent = null;
		}
	}

	// Token: 0x06012016 RID: 73750 RVA: 0x0054BEFF File Offset: 0x0054A0FF
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RogueResMapSummaryTeamToBondUpdate, new Action(this.OnJumpToBondTab));
	}

	// Token: 0x06012017 RID: 73751 RVA: 0x0054BF1D File Offset: 0x0054A11D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RogueResMapSummaryTeamToBondUpdate, new Action(this.OnJumpToBondTab));
	}

	// Token: 0x06012018 RID: 73752 RVA: 0x0054BF3C File Offset: 0x0054A13C
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

	// Token: 0x06012019 RID: 73753 RVA: 0x0054BFC1 File Offset: 0x0054A1C1
	protected override void OnHandleReleaseScene()
	{
		UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.TsUiSceneRoleActor);
		this.TsUiSceneRoleActor = null;
	}

	// Token: 0x0601201A RID: 73754 RVA: 0x0054BFDB File Offset: 0x0054A1DB
	private void OnCloseClicked()
	{
		base.CloseMe(null);
	}

	// Token: 0x0601201B RID: 73755 RVA: 0x0054BFE4 File Offset: 0x0054A1E4
	protected void InitTabComponent()
	{
		CommonTabComponentData<CommonTabItem> data = new CommonTabComponentData<CommonTabItem>(new Func<UUIItem, int?, CommonTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
		this.TabComponent = new TabComponentWithCaptionItem<CommonTabItem>(base.GetItem(0), data, new Action(this.OnCloseClicked), false);
		this.LastClickTime = null;
		this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
		this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(1), EKeyMode.Default);
	}

	// Token: 0x0601201C RID: 73756 RVA: 0x0054C074 File Offset: 0x0054A274
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

	// Token: 0x0601201D RID: 73757 RVA: 0x0054C0C8 File Offset: 0x0054A2C8
	private UniTask RefreshTabListAsync()
	{
		RogueBattleSummaryView.<RefreshTabListAsync>d__19 <RefreshTabListAsync>d__;
		<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabListAsync>d__.<>4__this = this;
		<RefreshTabListAsync>d__.<>1__state = -1;
		<RefreshTabListAsync>d__.<>t__builder.Start<RogueBattleSummaryView.<RefreshTabListAsync>d__19>(ref <RefreshTabListAsync>d__);
		return <RefreshTabListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601201E RID: 73758 RVA: 0x0054C10C File Offset: 0x0054A30C
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x0601201F RID: 73759 RVA: 0x0054C144 File Offset: 0x0054A344
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

	// Token: 0x06012020 RID: 73760 RVA: 0x0054C1CA File Offset: 0x0054A3CA
	private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x06012021 RID: 73761 RVA: 0x0054C1D4 File Offset: 0x0054A3D4
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

	// Token: 0x06012022 RID: 73762 RVA: 0x0054C274 File Offset: 0x0054A474
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

	// Token: 0x06012023 RID: 73763 RVA: 0x0054C2C4 File Offset: 0x0054A4C4
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

	// Token: 0x06012024 RID: 73764 RVA: 0x0054C335 File Offset: 0x0054A535
	private void OnExtendToggleStateChange(EToggleState newState)
	{
		RogueBattleModel.Instance.ChangeDescMode();
	}

	// Token: 0x06012025 RID: 73765 RVA: 0x0054C344 File Offset: 0x0054A544
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

	// Token: 0x06012026 RID: 73766 RVA: 0x0054C39A File Offset: 0x0054A59A
	private void RefreshElementInfo(EUiTabViewName viewName)
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06012027 RID: 73767 RVA: 0x0054C3AE File Offset: 0x0054A5AE
	private void RefreshTabHelpId(EUiTabViewName viewName)
	{
		this.TabComponent.SetHelpButtonShowState(false);
	}

	// Token: 0x04009D02 RID: 40194
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

	// Token: 0x04009D03 RID: 40195
	[Nullable(2)]
	protected TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x04009D04 RID: 40196
	private double? LastClickTime;

	// Token: 0x04009D05 RID: 40197
	protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x04009D06 RID: 40198
	private EUiTabViewName? CurSelectTabView;

	// Token: 0x04009D07 RID: 40199
	[Nullable(2)]
	private TsUiSceneRoleActor TsUiSceneRoleActor;
}
