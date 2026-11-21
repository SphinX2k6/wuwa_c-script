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

// Token: 0x02000C0C RID: 3084
[NullableContext(1)]
[Nullable(0)]
public class CalabashRootView : UiViewBase
{
	// Token: 0x06008095 RID: 32917 RVA: 0x00277118 File Offset: 0x00275318
	public CalabashRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008096 RID: 32918 RVA: 0x002771B8 File Offset: 0x002753B8
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

	// Token: 0x06008097 RID: 32919 RVA: 0x0027728F File Offset: 0x0027548F
	private void CloseClick()
	{
		if (this.CheckTabViewCloseToRoot())
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x06008098 RID: 32920 RVA: 0x002772A1 File Offset: 0x002754A1
	private void OnHelpBtnClick()
	{
		HelpController.Instance.OpenHelpById(this.HelpId);
	}

	// Token: 0x06008099 RID: 32921 RVA: 0x002772B4 File Offset: 0x002754B4
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.JumpToCalabashCollect, new Action<int>(this.JumpToCalabashCollect));
		EventSystem.Instance.Add(EEventName.JumpToPhantomBattleFettersTabView, new Action<int>(this.JumpPhantomBattleFettersTabView));
		EventSystem.Instance.Add(EEventName.CalabashEnterInternalView, new Action(this.OnEnterInternalView));
		EventSystem.Instance.Add(EEventName.CalabashQuitInternalView, new Action(this.OnQuitInternalView));
		EventSystem.Instance.Add(EEventName.OnRefreshCalabashTabShowState, new Action<bool>(this.OnRefreshTabShowState));
	}

	// Token: 0x0600809A RID: 32922 RVA: 0x00277350 File Offset: 0x00275550
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.JumpToCalabashCollect, new Action<int>(this.JumpToCalabashCollect));
		EventSystem.Instance.Remove(EEventName.JumpToPhantomBattleFettersTabView, new Action<int>(this.JumpPhantomBattleFettersTabView));
		EventSystem.Instance.Remove(EEventName.CalabashEnterInternalView, new Action(this.OnEnterInternalView));
		EventSystem.Instance.Remove(EEventName.CalabashQuitInternalView, new Action(this.OnQuitInternalView));
		EventSystem.Instance.Remove(EEventName.OnRefreshCalabashTabShowState, new Action<bool>(this.OnRefreshTabShowState));
	}

	// Token: 0x0600809B RID: 32923 RVA: 0x002773EC File Offset: 0x002755EC
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

	// Token: 0x0600809C RID: 32924 RVA: 0x00277498 File Offset: 0x00275698
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

	// Token: 0x0600809D RID: 32925 RVA: 0x00277540 File Offset: 0x00275740
	protected override UniTask OnBeforeStartAsync()
	{
		CalabashRootView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CalabashRootView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600809E RID: 32926 RVA: 0x00277584 File Offset: 0x00275784
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

	// Token: 0x0600809F RID: 32927 RVA: 0x0027762B File Offset: 0x0027582B
	private void InitTabDataList()
	{
		this.TabDataList = CalabashModel.Instance.GetViewTabList();
	}

	// Token: 0x060080A0 RID: 32928 RVA: 0x00277640 File Offset: 0x00275840
	private UniTask InitTabComponent()
	{
		CalabashRootView.<InitTabComponent>d__23 <InitTabComponent>d__;
		<InitTabComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTabComponent>d__.<>4__this = this;
		<InitTabComponent>d__.<>1__state = -1;
		<InitTabComponent>d__.<>t__builder.Start<CalabashRootView.<InitTabComponent>d__23>(ref <InitTabComponent>d__);
		return <InitTabComponent>d__.<>t__builder.Task;
	}

	// Token: 0x060080A1 RID: 32929 RVA: 0x00277683 File Offset: 0x00275883
	private CalabashTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CalabashTabItem();
	}

	// Token: 0x060080A2 RID: 32930 RVA: 0x0027768C File Offset: 0x0027588C
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
		object obj2 = obj;
		if (euiTabViewName == EUiTabViewName.VisionRecoveryTabView)
		{
			obj2 = new VisionRecoveryTabViewParam
			{
				RecoveryMode = (obj2 as EVisionRecoveryMode?),
				OnQuitInternalView = new Action(this.OnQuitInternalView)
			};
		}
		this.TabViewComponent.ToggleCallBackNew(uiDynamicTab, euiTabViewName, tabItemByIndex, obj2, null);
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

	// Token: 0x060080A3 RID: 32931 RVA: 0x002777D0 File Offset: 0x002759D0
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x060080A4 RID: 32932 RVA: 0x00277808 File Offset: 0x00275A08
	private void InitTabViewComponent()
	{
		this.TabViewComponent = new TabViewComponent<object>(base.GetItem(1), EKeyMode.Default);
	}

	// Token: 0x060080A5 RID: 32933 RVA: 0x00277820 File Offset: 0x00275A20
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

	// Token: 0x060080A6 RID: 32934 RVA: 0x002778D4 File Offset: 0x00275AD4
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

	// Token: 0x060080A7 RID: 32935 RVA: 0x00277972 File Offset: 0x00275B72
	private void BindRedDot()
	{
		this.BindRedDotByName(EUiTabViewName.CalabashLevelUpTabView, ERedDotName.CalabashTab, true);
		this.BindRedDotByName(EUiTabViewName.VisionRecoveryTabView, ERedDotName.VisionRecovery, true);
		this.BindRedDotByName(EUiTabViewName.VisionRefineTabView, ERedDotName.VisionRefine, true);
	}

	// Token: 0x060080A8 RID: 32936 RVA: 0x002779A0 File Offset: 0x00275BA0
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

	// Token: 0x060080A9 RID: 32937 RVA: 0x00277A19 File Offset: 0x00275C19
	private void OnSimplyToggleChange(EToggleState toggleState)
	{
		CalabashModel.Instance.SaveIfSimpleState(toggleState != EToggleState.ETT_Checked);
	}

	// Token: 0x060080AA RID: 32938 RVA: 0x00277A2C File Offset: 0x00275C2C
	private void OnClickedShared()
	{
		UiManager.Instance.OpenView(EUiViewName.PhantomManagerConfigSharePopItem, null, null);
	}

	// Token: 0x060080AB RID: 32939 RVA: 0x00277A3F File Offset: 0x00275C3F
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

	// Token: 0x060080AC RID: 32940 RVA: 0x00277A6A File Offset: 0x00275C6A
	protected override void OnBeforeHide()
	{
		this.UnBindRedDot();
		this.TabViewComponent.SetCurrentTabViewState(false);
	}

	// Token: 0x060080AD RID: 32941 RVA: 0x00277A80 File Offset: 0x00275C80
	protected override void OnAfterHide()
	{
		VisionRecoveryTabView visionRecoveryTabView = this.TabViewComponent.GetTabViewByTabKey(EUiTabViewName.VisionRecoveryTabView, null) as VisionRecoveryTabView;
		if (visionRecoveryTabView == null)
		{
			return;
		}
		visionRecoveryTabView.RemoveAllVisionItemOutside();
	}

	// Token: 0x060080AE RID: 32942 RVA: 0x00277AB6 File Offset: 0x00275CB6
	private void UnBindRedDot()
	{
		this.BindRedDotByName(EUiTabViewName.CalabashLevelUpTabView, ERedDotName.CalabashTab, false);
		this.BindRedDotByName(EUiTabViewName.VisionRecoveryTabView, ERedDotName.VisionRecovery, false);
		this.BindRedDotByName(EUiTabViewName.VisionRefineTabView, ERedDotName.VisionRefine, false);
	}

	// Token: 0x060080AF RID: 32943 RVA: 0x00277AE2 File Offset: 0x00275CE2
	protected override void OnBeforeDestroy()
	{
		this.TabComponent.Destroy(null);
		this.TabViewComponent.DestroyTabViewComponent();
	}

	// Token: 0x060080B0 RID: 32944 RVA: 0x00277AFC File Offset: 0x00275CFC
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

	// Token: 0x060080B1 RID: 32945 RVA: 0x00277BD0 File Offset: 0x00275DD0
	private bool CheckTabViewCloseToRoot()
	{
		if (this.TabViewComponent != null && this.TabViewComponent.GetCurrentTabViewName(null) == EUiTabViewName.VisionRefineTabView)
		{
			VisionRefineTabView visionRefineTabView = this.TabViewComponent.GetCurrentTabView() as VisionRefineTabView;
			return visionRefineTabView != null && visionRefineTabView.OnClickCloseRoot();
		}
		return false;
	}

	// Token: 0x060080B2 RID: 32946 RVA: 0x00277C38 File Offset: 0x00275E38
	private void OnEnterInternalView()
	{
		TabComponentWithCaptionItem<CalabashTabItem> tabComponent = this.TabComponent;
		if (tabComponent == null)
		{
			return;
		}
		tabComponent.HideItem();
	}

	// Token: 0x060080B3 RID: 32947 RVA: 0x00277C4A File Offset: 0x00275E4A
	private void OnQuitInternalView()
	{
		TabComponentWithCaptionItem<CalabashTabItem> tabComponent = this.TabComponent;
		if (tabComponent == null)
		{
			return;
		}
		tabComponent.ShowItem();
	}

	// Token: 0x060080B4 RID: 32948 RVA: 0x00277C5C File Offset: 0x00275E5C
	private void OnRefreshTabShowState(bool isShow)
	{
		if (isShow)
		{
			this.UiViewSequence.PlaySequence("SwitchA", false, null);
			return;
		}
		this.UiViewSequence.PlaySequence("SwitchB", false, null);
	}

	// Token: 0x060080B5 RID: 32949 RVA: 0x00277CA4 File Offset: 0x00275EA4
	public bool GetIsVisionRecoveryTabViewOpen()
	{
		VisionRecoveryTabView visionRecoveryTabView = this.TabViewComponent.GetTabViewByTabKey(EUiTabViewName.VisionRecoveryTabView, null) as VisionRecoveryTabView;
		return visionRecoveryTabView != null && visionRecoveryTabView.GetRootItem().IsUIActiveSelf();
	}

	// Token: 0x060080B6 RID: 32950 RVA: 0x00277CE0 File Offset: 0x00275EE0
	public void ShowCostItemCaption(int[] itemIdList)
	{
		TabComponentWithCaptionItem<CalabashTabItem> tabComponent = this.TabComponent;
		if (tabComponent == null)
		{
			return;
		}
		tabComponent.SetCurrencyItemList(new List<int>(itemIdList));
	}

	// Token: 0x04004F3D RID: 20285
	private const int CALABASH_LEVEL_UP_HELP_ID = 48;

	// Token: 0x04004F3E RID: 20286
	private const int CALABASH_COLLECT_HELP_ID = 47;

	// Token: 0x04004F3F RID: 20287
	private const int VISION_RECOVERY_HELP_ID = 70;

	// Token: 0x04004F40 RID: 20288
	private const int VISION_REFINE_HELP_ID = 512;

	// Token: 0x04004F41 RID: 20289
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

	// Token: 0x04004F42 RID: 20290
	[Nullable(2)]
	private UiDynamicTab[] TabDataList;

	// Token: 0x04004F43 RID: 20291
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<CalabashTabItem> TabComponent;

	// Token: 0x04004F44 RID: 20292
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabViewComponent<object> TabViewComponent;

	// Token: 0x04004F45 RID: 20293
	[Nullable(2)]
	private ICalabashRootViewData CalabashCollectParams;

	// Token: 0x04004F46 RID: 20294
	private bool IsViewFirstShow;

	// Token: 0x04004F47 RID: 20295
	private int HelpId;

	// Token: 0x02006EBB RID: 28347
	[NullableContext(0)]
	private enum ECompDefine
	{
		// Token: 0x0402432A RID: 148266
		TabItem,
		// Token: 0x0402432B RID: 148267
		TabViewMountItem,
		// Token: 0x0402432C RID: 148268
		DetailToggle,
		// Token: 0x0402432D RID: 148269
		DetailItem,
		// Token: 0x0402432E RID: 148270
		BtnShared,
		// Token: 0x0402432F RID: 148271
		DetailToggleTxt
	}
}
