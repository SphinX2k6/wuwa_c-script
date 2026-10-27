using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200226E RID: 8814
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleRootView : UiViewBase
{
	// Token: 0x06011349 RID: 70473 RVA: 0x00431B90 File Offset: 0x0042FD90
	public MotorcycleRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601134A RID: 70474 RVA: 0x00431BA4 File Offset: 0x0042FDA4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0601134B RID: 70475 RVA: 0x00431BE0 File Offset: 0x0042FDE0
	protected override void OnStart()
	{
		MotorDevelopRootData motorDevelopRootData = this.OpenParam as MotorDevelopRootData;
		if (motorDevelopRootData != null)
		{
			this.CurSelectTabView = motorDevelopRootData.OpenTabView;
			if (motorDevelopRootData.TreeType != null)
			{
				MotorcycleDevelopModel.Instance.UpdateSelectedTreeType(motorDevelopRootData.TreeType.Value);
			}
		}
		this.InitTabComponent();
	}

	// Token: 0x0601134C RID: 70476 RVA: 0x00431C30 File Offset: 0x0042FE30
	protected override void OnHandleLoadScene()
	{
		MotorcycleUiModelUtil.Instance.CreateMotor(EUiModelUseWay.MotorInMotorView);
		MotorcycleUiModelUtil.Instance.LoadEquippedMotor(null);
	}

	// Token: 0x0601134D RID: 70477 RVA: 0x00431C49 File Offset: 0x0042FE49
	protected override void OnBeforeShow()
	{
		this.RefreshTabListAsync();
		MotorcycleUiModelUtil.Instance.ShowMotor(true);
	}

	// Token: 0x0601134E RID: 70478 RVA: 0x00431C5D File Offset: 0x0042FE5D
	protected override void OnAfterHide()
	{
		TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
		if (tabViewComponent == null)
		{
			return;
		}
		tabViewComponent.SetCurrentTabViewState(false);
	}

	// Token: 0x0601134F RID: 70479 RVA: 0x00431C70 File Offset: 0x0042FE70
	protected override void OnHandleReleaseScene()
	{
		MotorcycleUiModelUtil.Instance.DestroyMotor();
	}

	// Token: 0x06011350 RID: 70480 RVA: 0x00431C7C File Offset: 0x0042FE7C
	protected override void OnBeforeDestroy()
	{
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
		MotorcycleDevelopModel.Instance.UpdateSelectedTreeType(0);
	}

	// Token: 0x06011351 RID: 70481 RVA: 0x00431CC9 File Offset: 0x0042FEC9
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<MotorDevelopRootData>(EEventName.MotorDevelopRootUpdate, new Action<MotorDevelopRootData>(this.OnRootUpdate));
		EventSystem.Instance.Add<EUiTabViewName>(EEventName.SelectMotorDevelopTab, new Action<EUiTabViewName>(this.OnSelectDevelopTab));
	}

	// Token: 0x06011352 RID: 70482 RVA: 0x00431D03 File Offset: 0x0042FF03
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopRootUpdate, new Action<MotorDevelopRootData>(this.OnRootUpdate));
		EventSystem.Instance.Remove(EEventName.SelectMotorDevelopTab, new Action<EUiTabViewName>(this.OnSelectDevelopTab));
	}

	// Token: 0x06011353 RID: 70483 RVA: 0x00431D40 File Offset: 0x0042FF40
	protected void InitTabComponent()
	{
		CommonTabComponentData<MotorcycleTabItem> data = new CommonTabComponentData<MotorcycleTabItem>(new Func<UUIItem, int?, MotorcycleTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
		this.TabComponent = new TabComponentWithCaptionItem<MotorcycleTabItem>(base.GetItem(1), data, new Action(this.CloseClick), false);
		this.LastClickTime = null;
		this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
		this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(0), EKeyMode.Default);
	}

	// Token: 0x06011354 RID: 70484 RVA: 0x00431DD0 File Offset: 0x0042FFD0
	protected UniTask RefreshTabListAsync()
	{
		MotorcycleRootView.<RefreshTabListAsync>d__17 <RefreshTabListAsync>d__;
		<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabListAsync>d__.<>4__this = this;
		<RefreshTabListAsync>d__.<>1__state = -1;
		<RefreshTabListAsync>d__.<>t__builder.Start<MotorcycleRootView.<RefreshTabListAsync>d__17>(ref <RefreshTabListAsync>d__);
		return <RefreshTabListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011355 RID: 70485 RVA: 0x00431E14 File Offset: 0x00430014
	protected bool CanToggleChange(int index, bool? _)
	{
		if (Info.Instance.IsInGamepad())
		{
			return true;
		}
		int? intConfig = ConfigCommonParamById.GetIntConfig("panel_interval_time");
		return this.LastClickTime == null || Time.Instance.Now - this.LastClickTime.Value >= (double)intConfig.Value;
	}

	// Token: 0x06011356 RID: 70486 RVA: 0x00431E6A File Offset: 0x0043006A
	private MotorcycleTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleTabItem();
	}

	// Token: 0x06011357 RID: 70487 RVA: 0x00431E74 File Offset: 0x00430074
	private void ToggleCallBack(int index)
	{
		this.LastClickTime = new double?(Time.Instance.Now);
		UiDynamicTab data = this.TabDataList[index];
		EUiTabViewName viewName = (EUiTabViewName)data.ChildViewName;
		MotorcycleTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
		this.TabViewComponent.ToggleCallBack(data, viewName, tabItemByIndex, null, null);
		this.CurSelectTabView = new EUiTabViewName?(viewName);
		if (viewName != EUiTabViewName.MotorcycleTechTreeTabView)
		{
			this.TabComponent.SetCurrencyItemList(new List<int>());
		}
		this.TabComponent.SetHelpButtonCallBack(delegate
		{
			if (viewName == EUiTabViewName.MotorcycleDiyMainView)
			{
				HelpController.Instance.OpenHelpById(424);
				return;
			}
			HelpController.Instance.OpenHelpById(466);
		});
	}

	// Token: 0x06011358 RID: 70488 RVA: 0x00431F30 File Offset: 0x00430130
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x06011359 RID: 70489 RVA: 0x00431F68 File Offset: 0x00430168
	protected ERedDotName? GetRedDotName(EUiTabViewName tabViewName)
	{
		if (tabViewName == EUiTabViewName.MotorcycleLevelInfoTabView)
		{
			return new ERedDotName?(ERedDotName.MotorcycleLevelTab);
		}
		if (tabViewName == EUiTabViewName.MotorcycleTechTreeTabView)
		{
			return new ERedDotName?(ERedDotName.MotorcycleTechTreeTab);
		}
		if (tabViewName == EUiTabViewName.MotorcycleTaskTabView)
		{
			return new ERedDotName?(ERedDotName.MotorcycleTaskTab);
		}
		if (tabViewName == EUiTabViewName.MotorcycleDiyMainView)
		{
			return new ERedDotName?(ERedDotName.MotorcycleDiyTab);
		}
		return null;
	}

	// Token: 0x0601135A RID: 70490 RVA: 0x00431FE0 File Offset: 0x004301E0
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		if (!(configParams[0] == "Tab"))
		{
			return null;
		}
		int index = int.Parse(configParams[1]);
		TabComponentWithCaptionItem<MotorcycleTabItem> tabComponent = this.TabComponent;
		UUIItem uuiitem;
		if (tabComponent == null)
		{
			uuiitem = null;
		}
		else
		{
			MotorcycleTabItem tabItemByIndex = tabComponent.GetTabItemByIndex(index);
			uuiitem = ((tabItemByIndex != null) ? tabItemByIndex.GetRootItem() : null);
		}
		UUIItem uuiitem2 = uuiitem;
		if (uuiitem2 == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem2,
			uuiitem2
		};
	}

	// Token: 0x0601135B RID: 70491 RVA: 0x00432040 File Offset: 0x00430240
	private void OnRootUpdate(MotorDevelopRootData data)
	{
		if (data.Currency != null)
		{
			List<int> currencyItemList = new List<int>(data.Currency);
			this.TabComponent.SetCurrencyItemList(currencyItemList);
		}
		if (data.IsObserving == null)
		{
			return;
		}
		bool state = data.IsObserving.Value;
		if (!state)
		{
			this.TabComponent.SetUiActive(!state);
			base.PlaySequence("UiIn", delegate
			{
			}, true);
			return;
		}
		base.PlaySequence("UiOut", delegate
		{
			this.TabComponent.SetUiActive(!state);
		}, true);
	}

	// Token: 0x0601135C RID: 70492 RVA: 0x004320FC File Offset: 0x004302FC
	private void OnSelectDevelopTab(EUiTabViewName tabViewName)
	{
		int index = this.TabDataList.FindIndex((UiDynamicTab tabData) => (EUiTabViewName)tabData.ChildViewName == tabViewName);
		this.TabComponent.SelectToggleByIndex(index, false);
	}

	// Token: 0x0601135D RID: 70493 RVA: 0x0043213B File Offset: 0x0043033B
	protected void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x040082F6 RID: 33526
	protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x040082F7 RID: 33527
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponentWithCaptionItem<MotorcycleTabItem> TabComponent;

	// Token: 0x040082F8 RID: 33528
	[Nullable(2)]
	protected TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x040082F9 RID: 33529
	private EUiTabViewName? CurSelectTabView;

	// Token: 0x040082FA RID: 33530
	private double? LastClickTime;

	// Token: 0x0200879A RID: 34714
	[NullableContext(0)]
	private class EMotorRootComponent
	{
		// Token: 0x0402C12D RID: 180525
		public const int TabRootItem = 0;

		// Token: 0x0402C12E RID: 180526
		public const int TabComponent = 1;
	}
}
