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

// Token: 0x02001752 RID: 5970
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleRootView : UiViewBase
{
	// Token: 0x0600E7DF RID: 59359 RVA: 0x0043E79C File Offset: 0x0043C99C
	public MotorcycleRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E7E0 RID: 59360 RVA: 0x0043E7B0 File Offset: 0x0043C9B0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600E7E1 RID: 59361 RVA: 0x0043E7EC File Offset: 0x0043C9EC
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

	// Token: 0x0600E7E2 RID: 59362 RVA: 0x0043E83C File Offset: 0x0043CA3C
	protected override void OnHandleLoadScene()
	{
		MotorcycleUiModelUtil.Instance.CreateMotor(EUiModelUseWay.MotorInMotorView);
		MotorcycleUiModelUtil.Instance.LoadEquippedMotor(null);
	}

	// Token: 0x0600E7E3 RID: 59363 RVA: 0x0043E855 File Offset: 0x0043CA55
	protected override void OnBeforeShow()
	{
		this.RefreshTabListAsync();
		MotorcycleUiModelUtil.Instance.ShowMotor(true);
	}

	// Token: 0x0600E7E4 RID: 59364 RVA: 0x0043E869 File Offset: 0x0043CA69
	protected override void OnAfterHide()
	{
		TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
		if (tabViewComponent == null)
		{
			return;
		}
		tabViewComponent.SetCurrentTabViewState(false);
	}

	// Token: 0x0600E7E5 RID: 59365 RVA: 0x0043E87C File Offset: 0x0043CA7C
	protected override void OnHandleReleaseScene()
	{
		MotorcycleUiModelUtil.Instance.DestroyMotor();
	}

	// Token: 0x0600E7E6 RID: 59366 RVA: 0x0043E888 File Offset: 0x0043CA88
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

	// Token: 0x0600E7E7 RID: 59367 RVA: 0x0043E8D5 File Offset: 0x0043CAD5
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<MotorDevelopRootData>(EEventName.MotorDevelopRootUpdate, new Action<MotorDevelopRootData>(this.OnRootUpdate));
		EventSystem.Instance.Add<EUiTabViewName>(EEventName.SelectMotorDevelopTab, new Action<EUiTabViewName>(this.OnSelectDevelopTab));
	}

	// Token: 0x0600E7E8 RID: 59368 RVA: 0x0043E90F File Offset: 0x0043CB0F
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDevelopRootUpdate, new Action<MotorDevelopRootData>(this.OnRootUpdate));
		EventSystem.Instance.Remove(EEventName.SelectMotorDevelopTab, new Action<EUiTabViewName>(this.OnSelectDevelopTab));
	}

	// Token: 0x0600E7E9 RID: 59369 RVA: 0x0043E94C File Offset: 0x0043CB4C
	protected void InitTabComponent()
	{
		CommonTabComponentData<MotorcycleTabItem> data = new CommonTabComponentData<MotorcycleTabItem>(new Func<UUIItem, int?, MotorcycleTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
		this.TabComponent = new TabComponentWithCaptionItem<MotorcycleTabItem>(base.GetItem(1), data, new Action(this.CloseClick), false);
		this.LastClickTime = null;
		this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
		this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(0), EKeyMode.Default);
	}

	// Token: 0x0600E7EA RID: 59370 RVA: 0x0043E9DC File Offset: 0x0043CBDC
	protected UniTask RefreshTabListAsync()
	{
		MotorcycleRootView.<RefreshTabListAsync>d__17 <RefreshTabListAsync>d__;
		<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabListAsync>d__.<>4__this = this;
		<RefreshTabListAsync>d__.<>1__state = -1;
		<RefreshTabListAsync>d__.<>t__builder.Start<MotorcycleRootView.<RefreshTabListAsync>d__17>(ref <RefreshTabListAsync>d__);
		return <RefreshTabListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E7EB RID: 59371 RVA: 0x0043EA20 File Offset: 0x0043CC20
	protected bool CanToggleChange(int index, bool? _)
	{
		if (Info.Instance.IsInGamepad())
		{
			return true;
		}
		int? intConfig = ConfigCommonParamById.GetIntConfig("panel_interval_time");
		return this.LastClickTime == null || Time.Instance.Now - this.LastClickTime.Value >= (double)intConfig.Value;
	}

	// Token: 0x0600E7EC RID: 59372 RVA: 0x0043EA76 File Offset: 0x0043CC76
	private MotorcycleTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleTabItem();
	}

	// Token: 0x0600E7ED RID: 59373 RVA: 0x0043EA80 File Offset: 0x0043CC80
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

	// Token: 0x0600E7EE RID: 59374 RVA: 0x0043EB3C File Offset: 0x0043CD3C
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x0600E7EF RID: 59375 RVA: 0x0043EB74 File Offset: 0x0043CD74
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

	// Token: 0x0600E7F0 RID: 59376 RVA: 0x0043EBEC File Offset: 0x0043CDEC
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

	// Token: 0x0600E7F1 RID: 59377 RVA: 0x0043EC4C File Offset: 0x0043CE4C
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

	// Token: 0x0600E7F2 RID: 59378 RVA: 0x0043ED08 File Offset: 0x0043CF08
	private void OnSelectDevelopTab(EUiTabViewName tabViewName)
	{
		int index = this.TabDataList.FindIndex((UiDynamicTab tabData) => (EUiTabViewName)tabData.ChildViewName == tabViewName);
		this.TabComponent.SelectToggleByIndex(index, false);
	}

	// Token: 0x0600E7F3 RID: 59379 RVA: 0x0043ED47 File Offset: 0x0043CF47
	protected void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04008434 RID: 33844
	protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x04008435 RID: 33845
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponentWithCaptionItem<MotorcycleTabItem> TabComponent;

	// Token: 0x04008436 RID: 33846
	[Nullable(2)]
	protected TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x04008437 RID: 33847
	private EUiTabViewName? CurSelectTabView;

	// Token: 0x04008438 RID: 33848
	private double? LastClickTime;

	// Token: 0x02007923 RID: 31011
	[NullableContext(0)]
	private class EMotorRootComponent
	{
		// Token: 0x04027445 RID: 160837
		public const int TabRootItem = 0;

		// Token: 0x04027446 RID: 160838
		public const int TabComponent = 1;
	}
}
