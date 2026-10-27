using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001753 RID: 5971
[NullableContext(1)]
[Nullable(0)]
public class CalabashRootView : UiViewBase
{
	// Token: 0x0600ACAE RID: 44206 RVA: 0x0026CCD0 File Offset: 0x0026AED0
	public CalabashRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600ACAF RID: 44207 RVA: 0x0026CD70 File Offset: 0x0026AF70
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnSimplyToggleChange)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickedShared))
		};
	}

	// Token: 0x0600ACB0 RID: 44208 RVA: 0x0026CE47 File Offset: 0x0026B047
	private void CloseClick()
	{
		if (this.CheckTabViewCloseToRoot())
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x0600ACB1 RID: 44209 RVA: 0x0026CE59 File Offset: 0x0026B059
	private void OnHelpBtnClick()
	{
		HelpController.Instance.OpenHelpById(this.HelpId);
	}

	// Token: 0x0600ACB2 RID: 44210 RVA: 0x0026CE6C File Offset: 0x0026B06C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.JumpToCalabashCollect, new Action<int>(this.JumpToCalabashCollect));
		EventSystem.Instance.Add(EEventName.JumpToPhantomBattleFettersTabView, new Action<int>(this.JumpPhantomBattleFettersTabView));
		EventSystem.Instance.Add(EEventName.CalabashEnterInternalView, new Action(this.OnEnterInternalView));
		EventSystem.Instance.Add(EEventName.CalabashQuitInternalView, new Action(this.OnQuitInternalView));
		EventSystem.Instance.Add(EEventName.OnRefreshCalabashTabShowState, new Action<bool>(this.OnRefreshTabShowState));
	}

	// Token: 0x0600ACB3 RID: 44211 RVA: 0x0026CF08 File Offset: 0x0026B108
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.JumpToCalabashCollect, new Action<int>(this.JumpToCalabashCollect));
		EventSystem.Instance.Remove(EEventName.JumpToPhantomBattleFettersTabView, new Action<int>(this.JumpPhantomBattleFettersTabView));
		EventSystem.Instance.Remove(EEventName.CalabashEnterInternalView, new Action(this.OnEnterInternalView));
		EventSystem.Instance.Remove(EEventName.CalabashQuitInternalView, new Action(this.OnQuitInternalView));
		EventSystem.Instance.Remove(EEventName.OnRefreshCalabashTabShowState, new Action<bool>(this.OnRefreshTabShowState));
	}

	// Token: 0x0600ACB4 RID: 44212 RVA: 0x0026CFA4 File Offset: 0x0026B1A4
	private void JumpToCalabashCollect(int monsterId)
	{
		int index = -1;
		for (int i = 0; i < this.TabDataList.Length; i++)
		{
			if (this.TabDataList[i].ChildViewName == EUiTabViewName.CalabashCollectTabView.ToString())
			{
				index = i;
				break;
			}
		}
		CalabashCollectViewData param = new CalabashCollectViewData
		{
			MonsterId = monsterId
		};
		if (this.CalabashCollectParams == null)
		{
			this.CalabashCollectParams = new CalabashRootViewData
			{
				TabViewName = EUiTabViewName.CalabashCollectTabView,
				Param = param
			};
		}
		else
		{
			this.CalabashCollectParams.TabViewName = EUiTabViewName.CalabashCollectTabView;
			this.CalabashCollectParams.Param = param;
		}
		this.TabComponent.SelectToggleByIndex(index, false);
	}

	// Token: 0x0600ACB5 RID: 44213 RVA: 0x0026D050 File Offset: 0x0026B250
	private void JumpPhantomBattleFettersTabView(int id)
	{
		int index = -1;
		for (int i = 0; i < this.TabDataList.Length; i++)
		{
			if (this.TabDataList[i].ChildViewName == EUiTabViewName.PhantomBattleFettersTabView.ToString())
			{
				index = i;
				break;
			}
		}
		if (this.CalabashCollectParams == null)
		{
			this.CalabashCollectParams = new CalabashRootViewData
			{
				TabViewName = EUiTabViewName.PhantomBattleFettersTabView,
				Param = id
			};
		}
		else
		{
			this.CalabashCollectParams.TabViewName = EUiTabViewName.PhantomBattleFettersTabView;
			this.CalabashCollectParams.Param = id;
		}
		this.TabComponent.SelectToggleByIndex(index, false);
	}

	// Token: 0x0600ACB6 RID: 44214 RVA: 0x0026D0F8 File Offset: 0x0026B2F8
	protected override UniTask OnBeforeStartAsync()
	{
		CalabashRootView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CalabashRootView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600ACB7 RID: 44215 RVA: 0x0026D13C File Offset: 0x0026B33C
	protected override void OnStart()
	{
		EventSystem.Instance.Emit(EEventName.OnVisionRefineSubNeedAck);
		ICalabashRootViewData calabashCollectParams = this.CalabashCollectParams;
		EUiTabViewName? euiTabViewName = (calabashCollectParams != null) ? new EUiTabViewName?(calabashCollectParams.TabViewName) : null;
		ICalabashRootViewData calabashCollectParams2 = this.CalabashCollectParams;
		ICalabashCollectViewData calabashCollectViewData = ((calabashCollectParams2 != null) ? calabashCollectParams2.Param : null) as ICalabashCollectViewData;
		if (euiTabViewName == EUiTabViewName.CalabashCollectTabView && calabashCollectViewData != null && calabashCollectViewData.OnlyShow.GetValueOrDefault())
		{
			BlackScreenController.Instance.AddBlackScreen("None", "CalabashCollectOnlyShow", "Black", "Default");
		}
	}

	// Token: 0x0600ACB8 RID: 44216 RVA: 0x0026D1E3 File Offset: 0x0026B3E3
	private void InitTabDataList()
	{
		this.TabDataList = CalabashModel.Instance.GetViewTabList();
	}

	// Token: 0x0600ACB9 RID: 44217 RVA: 0x0026D1F8 File Offset: 0x0026B3F8
	private UniTask InitTabComponent()
	{
		CalabashRootView.<InitTabComponent>d__23 <InitTabComponent>d__;
		<InitTabComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTabComponent>d__.<>4__this = this;
		<InitTabComponent>d__.<>1__state = -1;
		<InitTabComponent>d__.<>t__builder.Start<CalabashRootView.<InitTabComponent>d__23>(ref <InitTabComponent>d__);
		return <InitTabComponent>d__.<>t__builder.Task;
	}

	// Token: 0x0600ACBA RID: 44218 RVA: 0x0026D23B File Offset: 0x0026B43B
	private CalabashTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CalabashTabItem();
	}

	// Token: 0x0600ACBB RID: 44219 RVA: 0x0026D244 File Offset: 0x0026B444
	private void ToggleCallBack(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		EUiTabViewName euiTabViewName = (EUiTabViewName)uiDynamicTab.ChildViewName;
		CalabashTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
		EUiTabViewName left = euiTabViewName;
		ICalabashRootViewData calabashCollectParams = this.CalabashCollectParams;
		object obj;
		if (!(left == ((calabashCollectParams != null) ? new EUiTabViewName?(calabashCollectParams.TabViewName) : null)))
		{
			obj = null;
		}
		else
		{
			ICalabashRootViewData calabashCollectParams2 = this.CalabashCollectParams;
			obj = ((calabashCollectParams2 != null) ? calabashCollectParams2.Param : null);
		}
		object extraParams = obj;
		this.TabViewComponent.ToggleCallBackNew(uiDynamicTab, euiTabViewName, tabItemByIndex, extraParams, null);
		if (this.CalabashCollectParams != null)
		{
			this.CalabashCollectParams.Param = null;
		}
		int num;
		this.viewHelpId.TryGetValue(euiTabViewName.ToString(), out num);
		this.HelpId = ((num > 0) ? num : -1);
		this.TabComponent.SetHelpButtonShowState(this.HelpId > 0);
		this.UpdateDetailItem(euiTabViewName);
		this.ShowCostItemCaption(Array.Empty<int>());
	}

	// Token: 0x0600ACBC RID: 44220 RVA: 0x0026D354 File Offset: 0x0026B554
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x0600ACBD RID: 44221 RVA: 0x0026D38C File Offset: 0x0026B58C
	private void InitTabViewComponent()
	{
		this.TabViewComponent = new TabViewComponent<object>(base.GetItem(1), EKeyMode.Default);
	}

	// Token: 0x0600ACBE RID: 44222 RVA: 0x0026D3A4 File Offset: 0x0026B5A4
	private void UpdateDetailItem(EUiTabViewName viewName)
	{
		bool flag = viewName == EUiTabViewName.CalabashCollectTabView || viewName == EUiTabViewName.PhantomManageConfigNewView;
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (!flag)
		{
			return;
		}
		bool uiactive = viewName == EUiTabViewName.CalabashCollectTabView;
		UUIExtendToggle extendToggle = base.GetExtendToggle(2);
		if (extendToggle != null)
		{
			UUIItem uuiitem = extendToggle.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(uiactive);
			}
		}
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.SetUIActive(uiactive);
		}
		UUIButtonComponent button = base.GetButton(4);
		if (button == null)
		{
			return;
		}
		UUIItem uuiitem2 = button.RootUIComp.Get();
		if (uuiitem2 == null)
		{
			return;
		}
		uuiitem2.SetUIActive(viewName == EUiTabViewName.PhantomManageConfigNewView);
	}

	// Token: 0x0600ACBF RID: 44223 RVA: 0x0026D458 File Offset: 0x0026B658
	private void InitSelectedIndex()
	{
		ICalabashRootViewData calabashCollectParams = this.CalabashCollectParams;
		EUiTabViewName? euiTabViewName = (calabashCollectParams != null) ? new EUiTabViewName?(calabashCollectParams.TabViewName) : null;
		int index = 0;
		if (euiTabViewName == null)
		{
			int selectedIndex = this.TabComponent.GetSelectedIndex();
			index = ((selectedIndex != -1) ? selectedIndex : 0);
		}
		else
		{
			for (int i = 0; i < this.TabDataList.Length; i++)
			{
				if (this.TabDataList[i].ChildViewName == euiTabViewName.ToString())
				{
					index = i;
					break;
				}
			}
		}
		this.TabComponent.SelectToggleByIndex(index, false);
	}

	// Token: 0x0600ACC0 RID: 44224 RVA: 0x0026D4F6 File Offset: 0x0026B6F6
	private void BindRedDot()
	{
		this.BindRedDotByName(EUiTabViewName.CalabashLevelUpTabView, ERedDotName.CalabashTab, true);
		this.BindRedDotByName(EUiTabViewName.VisionRecoveryTabView, ERedDotName.VisionRecovery, true);
		this.BindRedDotByName(EUiTabViewName.VisionRefineTabView, ERedDotName.VisionRefine, true);
	}

	// Token: 0x0600ACC1 RID: 44225 RVA: 0x0026D524 File Offset: 0x0026B724
	private void BindRedDotByName(EUiTabViewName viewName, ERedDotName redDotName, bool bIsBind)
	{
		int num = -1;
		for (int i = 0; i < this.TabDataList.Length; i++)
		{
			if (this.TabDataList[i].ChildViewName == viewName.ToString())
			{
				num = i;
				break;
			}
		}
		if (num >= 0)
		{
			CalabashTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(num);
			if (bIsBind)
			{
				if (tabItemByIndex != null)
				{
					tabItemByIndex.BindRedDot(redDotName, new int?(0));
					return;
				}
			}
			else if (tabItemByIndex != null)
			{
				tabItemByIndex.UnBindRedDot();
			}
		}
	}

	// Token: 0x0600ACC2 RID: 44226 RVA: 0x0026D59D File Offset: 0x0026B79D
	private void OnSimplyToggleChange(EToggleState toggleState)
	{
		CalabashModel.Instance.SaveIfSimpleState(toggleState != EToggleState.ETT_Checked);
	}

	// Token: 0x0600ACC3 RID: 44227 RVA: 0x0026D5B0 File Offset: 0x0026B7B0
	private void OnClickedShared()
	{
		UiManager.Instance.OpenView(EUiViewName.PhantomManagerConfigSharePopItem, null, null);
	}

	// Token: 0x0600ACC4 RID: 44228 RVA: 0x0026D5C3 File Offset: 0x0026B7C3
	protected override void OnBeforeShow()
	{
		if (this.IsViewFirstShow)
		{
			this.InitSelectedIndex();
		}
		else
		{
			this.TabViewComponent.SetCurrentTabViewState(true);
		}
		this.IsViewFirstShow = false;
		this.BindRedDot();
	}

	// Token: 0x0600ACC5 RID: 44229 RVA: 0x0026D5EE File Offset: 0x0026B7EE
	protected override void OnBeforeHide()
	{
		this.UnBindRedDot();
		this.TabViewComponent.SetCurrentTabViewState(false);
	}

	// Token: 0x0600ACC6 RID: 44230 RVA: 0x0026D604 File Offset: 0x0026B804
	protected override void OnAfterHide()
	{
		VisionRecoveryTabView visionRecoveryTabView = this.TabViewComponent.GetTabViewByTabKey(EUiTabViewName.VisionRecoveryTabView, null) as VisionRecoveryTabView;
		if (visionRecoveryTabView == null)
		{
			return;
		}
		visionRecoveryTabView.RemoveAllVisionItemOutside();
	}

	// Token: 0x0600ACC7 RID: 44231 RVA: 0x0026D63A File Offset: 0x0026B83A
	private void UnBindRedDot()
	{
		this.BindRedDotByName(EUiTabViewName.CalabashLevelUpTabView, ERedDotName.CalabashTab, false);
		this.BindRedDotByName(EUiTabViewName.VisionRecoveryTabView, ERedDotName.VisionRecovery, false);
		this.BindRedDotByName(EUiTabViewName.VisionRefineTabView, ERedDotName.VisionRefine, false);
	}

	// Token: 0x0600ACC8 RID: 44232 RVA: 0x0026D666 File Offset: 0x0026B866
	protected override void OnBeforeDestroy()
	{
		this.TabComponent.Destroy(null);
		this.TabViewComponent.DestroyTabViewComponent();
	}

	// Token: 0x0600ACC9 RID: 44233 RVA: 0x0026D680 File Offset: 0x0026B880
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams[0] == "Tab")
		{
			UiTabViewBase currentTabView = this.TabViewComponent.GetCurrentTabView();
			if (currentTabView == null)
			{
				return null;
			}
			return currentTabView.GetGuideUiItemAndUiItemForShowEx(RuntimeHelpers.GetSubArray<string>(configParams, Range.StartAt(1)));
		}
		else
		{
			int num = int.Parse(configParams[0]);
			int index = -1;
			for (int i = 0; i < this.TabDataList.Length; i++)
			{
				if (this.TabDataList[i].Id == num)
				{
					index = i;
					break;
				}
			}
			CalabashTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			UUIItem uuiitem = (tabItemByIndex != null) ? tabItemByIndex.GetRootItem() : null;
			if (uuiitem != null)
			{
				return new UUIItem[]
				{
					uuiitem,
					uuiitem
				};
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.JT;
			string message = "聚焦引导extraParam项配置有误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
	}

	// Token: 0x0600ACCA RID: 44234 RVA: 0x0026D754 File Offset: 0x0026B954
	private bool CheckTabViewCloseToRoot()
	{
		if (this.TabViewComponent != null && this.TabViewComponent.GetCurrentTabViewName(null) == EUiTabViewName.VisionRefineTabView)
		{
			VisionRefineTabView visionRefineTabView = this.TabViewComponent.GetCurrentTabView() as VisionRefineTabView;
			return visionRefineTabView != null && visionRefineTabView.OnClickCloseRoot();
		}
		return false;
	}

	// Token: 0x0600ACCB RID: 44235 RVA: 0x0026D7BC File Offset: 0x0026B9BC
	private void OnEnterInternalView()
	{
		TabComponentWithCaptionItem<CalabashTabItem> tabComponent = this.TabComponent;
		if (tabComponent == null)
		{
			return;
		}
		tabComponent.HideItem();
	}

	// Token: 0x0600ACCC RID: 44236 RVA: 0x0026D7CE File Offset: 0x0026B9CE
	private void OnQuitInternalView()
	{
		TabComponentWithCaptionItem<CalabashTabItem> tabComponent = this.TabComponent;
		if (tabComponent == null)
		{
			return;
		}
		tabComponent.ShowItem();
	}

	// Token: 0x0600ACCD RID: 44237 RVA: 0x0026D7E0 File Offset: 0x0026B9E0
	private void OnRefreshTabShowState(bool isShow)
	{
		if (isShow)
		{
			this.UiViewSequence.PlaySequence("SwitchA", false, null);
			return;
		}
		this.UiViewSequence.PlaySequence("SwitchB", false, null);
	}

	// Token: 0x0600ACCE RID: 44238 RVA: 0x0026D828 File Offset: 0x0026BA28
	public bool GetIsVisionRecoveryTabViewOpen()
	{
		VisionRecoveryTabView visionRecoveryTabView = this.TabViewComponent.GetTabViewByTabKey(EUiTabViewName.VisionRecoveryTabView, null) as VisionRecoveryTabView;
		return visionRecoveryTabView != null && visionRecoveryTabView.GetRootItem().IsUIActiveSelf();
	}

	// Token: 0x0600ACCF RID: 44239 RVA: 0x0026D864 File Offset: 0x0026BA64
	public void ShowCostItemCaption(int[] itemIdList)
	{
		TabComponentWithCaptionItem<CalabashTabItem> tabComponent = this.TabComponent;
		if (tabComponent == null)
		{
			return;
		}
		tabComponent.SetCurrencyItemList(new List<int>(itemIdList));
	}

	// Token: 0x04004E94 RID: 20116
	private const int CALABASH_LEVEL_UP_HELP_ID = 48;

	// Token: 0x04004E95 RID: 20117
	private const int CALABASH_COLLECT_HELP_ID = 47;

	// Token: 0x04004E96 RID: 20118
	private const int VISION_RECOVERY_HELP_ID = 70;

	// Token: 0x04004E97 RID: 20119
	private const int VISION_REFINE_HELP_ID = 512;

	// Token: 0x04004E98 RID: 20120
	private Dictionary<string, int> viewHelpId = new Dictionary<string, int>
	{
		{
			EUiTabViewName.CalabashLevelUpTabView.ToString(),
			48
		},
		{
			EUiTabViewName.CalabashCollectTabView.ToString(),
			47
		},
		{
			EUiTabViewName.VisionRecoveryTabView.ToString(),
			70
		},
		{
			EUiTabViewName.PhantomManageConfigNewView.ToString(),
			356
		},
		{
			EUiTabViewName.VisionRefineTabView.ToString(),
			512
		}
	};

	// Token: 0x04004E99 RID: 20121
	[Nullable(2)]
	private UiDynamicTab[] TabDataList;

	// Token: 0x04004E9A RID: 20122
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<CalabashTabItem> TabComponent;

	// Token: 0x04004E9B RID: 20123
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabViewComponent<object> TabViewComponent;

	// Token: 0x04004E9C RID: 20124
	[Nullable(2)]
	private ICalabashRootViewData CalabashCollectParams;

	// Token: 0x04004E9D RID: 20125
	private bool IsViewFirstShow;

	// Token: 0x04004E9E RID: 20126
	private int HelpId;

	// Token: 0x02007D35 RID: 32053
	[NullableContext(0)]
	private enum ECompDefine
	{
		// Token: 0x04028FFF RID: 167935
		TabItem,
		// Token: 0x04029000 RID: 167936
		TabViewMountItem,
		// Token: 0x04029001 RID: 167937
		DetailToggle,
		// Token: 0x04029002 RID: 167938
		DetailItem,
		// Token: 0x04029003 RID: 167939
		BtnShared,
		// Token: 0x04029004 RID: 167940
		DetailToggleTxt
	}
}
