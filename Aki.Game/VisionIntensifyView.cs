using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020024CC RID: 9420
[NullableContext(1)]
[Nullable(0)]
public class VisionIntensifyView : UiViewBase
{
	// Token: 0x06012EC8 RID: 77512 RVA: 0x004AE27F File Offset: 0x004AC47F
	public VisionIntensifyView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012EC9 RID: 77513 RVA: 0x004AE2A0 File Offset: 0x004AC4A0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06012ECA RID: 77514 RVA: 0x004AE2FC File Offset: 0x004AC4FC
	protected override void OnStart()
	{
		CommonTabComponentData<CommonTabItem> data = new CommonTabComponentData<CommonTabItem>(new Func<UUIItem, int?, CommonTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
		this.TabComponent = new TabComponentWithCaptionItem<CommonTabItem>(base.GetItem(0), data, new Action(this.CloseClick), false);
		this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(1), EKeyMode.Default);
		this.TabComponent.SetHelpButtonShowState(true);
		this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
		base.GetItem(2).SetUIActive(false);
		EventSystem.Instance.Emit<bool>(EEventName.OnVisionIntensifyViewShow, true);
	}

	// Token: 0x06012ECB RID: 77515 RVA: 0x004AE3A8 File Offset: 0x004AC5A8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<bool>(EEventName.RefreshVisionIntensifyViewBackBtnState, new Action<bool>(this.OnRefreshVisionIntensifyViewBackBtnState));
		EventSystem.Instance.Add(EEventName.PhantomLevelUp, new Action(this.OnVisionLevelUp));
		EventSystem.Instance.Add<int, int>(EEventName.OnPhantomStackMerge, new Action<int, int>(this.OnPhantomStackMerge));
		EventSystem.Instance.Add(EEventName.OnClickVisionIntensifyItemJump, new Action(this.OnClickVisionIntensifyItemJump));
	}

	// Token: 0x06012ECC RID: 77516 RVA: 0x004AE428 File Offset: 0x004AC628
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshVisionIntensifyViewBackBtnState, new Action<bool>(this.OnRefreshVisionIntensifyViewBackBtnState));
		EventSystem.Instance.Remove(EEventName.PhantomLevelUp, new Action(this.OnVisionLevelUp));
		EventSystem.Instance.Remove(EEventName.OnPhantomStackMerge, new Action<int, int>(this.OnPhantomStackMerge));
		EventSystem.Instance.Remove(EEventName.OnClickVisionIntensifyItemJump, new Action(this.OnClickVisionIntensifyItemJump));
	}

	// Token: 0x06012ECD RID: 77517 RVA: 0x004AE4A8 File Offset: 0x004AC6A8
	private void OnPhantomStackMerge(int mergedIncrId, int representativeIncrId)
	{
		if (this.CurrentUniqueId != mergedIncrId)
		{
			return;
		}
		if (PhantomBattleModel.Instance.GetPhantomBattleData(representativeIncrId) == null)
		{
			return;
		}
		this.CurrentUniqueId = representativeIncrId;
		VisionIntensifyViewPassData visionIntensifyViewPassData = this.OpenParam as VisionIntensifyViewPassData;
		if (visionIntensifyViewPassData != null)
		{
			visionIntensifyViewPassData.UniqueId = representativeIncrId;
		}
	}

	// Token: 0x06012ECE RID: 77518 RVA: 0x004AE4EA File Offset: 0x004AC6EA
	private void OnRefreshVisionIntensifyViewBackBtnState(bool state)
	{
		this.TabComponent.SetCloseBtnShowState(state);
	}

	// Token: 0x06012ECF RID: 77519 RVA: 0x004AE4F8 File Offset: 0x004AC6F8
	private void OnClickVisionIntensifyItemJump()
	{
		this.TabComponent.SelectToggleByIndex(1, false);
	}

	// Token: 0x06012ED0 RID: 77520 RVA: 0x004AE508 File Offset: 0x004AC708
	private void OnVisionLevelUp()
	{
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(this.CurrentUniqueId);
		if (phantomBattleData == null)
		{
			return;
		}
		if (phantomBattleData.GetQuality() <= 2)
		{
			return;
		}
		this.RefreshTabUnlockState();
	}

	// Token: 0x06012ED1 RID: 77521 RVA: 0x004AE53C File Offset: 0x004AC73C
	protected bool CanToggleChange(int index, bool? _)
	{
		UiDynamicTab tabData = this.TabDataList[index];
		if (VisionDefine.tabViewWithLock != null && VisionDefine.tabViewWithLock.Contains(tabData.ChildViewName))
		{
			ValueTuple<bool, string> valueTuple = this.CheckTabIfUnlock(tabData);
			if (!valueTuple.Item1 && valueTuple.Item2 != null)
			{
				GenericPromptController.Instance.ShowPromptByCode(valueTuple.Item2, Array.Empty<object>());
			}
			return valueTuple.Item1;
		}
		return true;
	}

	// Token: 0x06012ED2 RID: 77522 RVA: 0x004AE5A5 File Offset: 0x004AC7A5
	private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new VisionTabItem();
	}

	// Token: 0x06012ED3 RID: 77523 RVA: 0x004AE5AC File Offset: 0x004AC7AC
	[return: TupleElementNames(new string[]
	{
		"IsUnlocked",
		"Message"
	})]
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	private ValueTuple<bool, string> CheckTabIfUnlock(UiDynamicTab tabData)
	{
		if (tabData.ChildViewName == EUiTabViewName.VisionIdentifyView)
		{
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(this.CurrentUniqueId);
			if (phantomBattleData == null)
			{
				return new ValueTuple<bool, string>(false, ETextKey.VisionIdentifyLock.ToString());
			}
			int subPropUnlockLevel = phantomBattleData.GetSubPropUnlockLevel(0);
			bool flag = phantomBattleData.GetPhantomLevel() >= subPropUnlockLevel;
			if (flag)
			{
				EventSystem.Instance.Emit(EEventName.VisionIntensifyTabOpen);
			}
			return new ValueTuple<bool, string>(flag, flag ? null : ETextKey.VisionIdentifyLock.ToString());
		}
		else
		{
			if (!(tabData.ChildViewName == EUiTabViewName.VisionRefineTabView))
			{
				return new ValueTuple<bool, string>(true, null);
			}
			if (!FunctionModel.Instance.IsOpen(tabData.FunctionId))
			{
				return new ValueTuple<bool, string>(false, ETextKey.VisionRefineNotOpen.ToString());
			}
			int num = 1;
			return new ValueTuple<bool, string>(num != 0, (num != 0) ? null : ETextKey.VisionRefineConditionUnfit.ToString());
		}
	}

	// Token: 0x06012ED4 RID: 77524 RVA: 0x004AE6A8 File Offset: 0x004AC8A8
	protected override void OnBeforePlayCloseSequence()
	{
		UiTabViewBase currentTabView = this.TabViewComponent.GetCurrentTabView();
		if (currentTabView != null)
		{
			new UiSequencePlayer(currentTabView.GetRootItem()).PlaySequence("Close", false, null);
		}
	}

	// Token: 0x06012ED5 RID: 77525 RVA: 0x004AE6E4 File Offset: 0x004AC8E4
	private void ToggleCallBack(int index)
	{
		UiDynamicTab data = this.TabDataList[index];
		EUiTabViewName euiTabViewName = (EUiTabViewName)data.ChildViewName;
		CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
		UiTabViewBase currentTabView = this.TabViewComponent.GetCurrentTabView();
		if (currentTabView != null)
		{
			currentTabView.HideUiTabView(false);
		}
		this.SetCurrencyItemList(euiTabViewName);
		object extraParams = this.CreateExtraParams(euiTabViewName);
		this.TabViewComponent.ToggleCallBack(data, euiTabViewName, tabItemByIndex, extraParams, null);
		this.TabComponent.SetHelpButtonCallBack(new Action(this.OnClickHelpButton));
		this.HandleVisionSkeletal(euiTabViewName);
		this.CurSelectTabIndex = index;
	}

	// Token: 0x06012ED6 RID: 77526 RVA: 0x004AE77D File Offset: 0x004AC97D
	private void HandleVisionSkeletal(EUiTabViewName viewName)
	{
		if (viewName == EUiTabViewName.VisionRefineTabView)
		{
			this.DestroyVisionSkeletal();
			return;
		}
		this.ShowVisionSkeletal();
	}

	// Token: 0x06012ED7 RID: 77527 RVA: 0x004AE79C File Offset: 0x004AC99C
	private void ShowVisionSkeletal()
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		if (!UiSceneManager.Instance.HasVisionSkeletalHandle())
		{
			UiSceneManager.Instance.InitVisionSkeletalHandle();
		}
		SkeletalObserverHandle visionSkeletalHandle = UiSceneManager.Instance.GetVisionSkeletalHandle();
		if (visionSkeletalHandle == null)
		{
			return;
		}
		PhantomBattleController.Instance.SetMeshShow(phantomItemDataByUniqueId.GetConfigId(true), null, visionSkeletalHandle, true);
	}

	// Token: 0x06012ED8 RID: 77528 RVA: 0x004AE7F7 File Offset: 0x004AC9F7
	private void DestroyVisionSkeletal()
	{
		UiSceneManager.Instance.DestroyVisionSkeletalHandle();
	}

	// Token: 0x06012ED9 RID: 77529 RVA: 0x004AE804 File Offset: 0x004ACA04
	[NullableContext(2)]
	public object CreateExtraParams(EUiTabViewName viewName)
	{
		object result;
		if (viewName == EUiTabViewName.VisionRefineTabView)
		{
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(this.CurrentUniqueId);
			EVisionRefineRefineType value = EVisionRefineRefineType.Main;
			if (phantomBattleData == null || phantomBattleData.GetVisionIfCanRefine(EVisionRefineRefineType.Sub))
			{
				value = EVisionRefineRefineType.Sub;
			}
			VisionAttrRecommendInfo roleCostAttrRecommendInfo = VisionRecommendModel.Instance.GetRoleCostAttrRecommendInfo(this.CurrentRoleId, (phantomBattleData != null) ? phantomBattleData.GetCost() : 0);
			List<AttrRecommendInfo> recommendRefineSubList = (roleCostAttrRecommendInfo != null) ? roleCostAttrRecommendInfo.GetSubAttrRecommendInfo() : null;
			result = new VisionRefineTabViewParam
			{
				ViewState = ERefineViewState.Attribute,
				RefineType = new EVisionRefineRefineType?(value),
				UniqueId = new int?(this.CurrentUniqueId),
				ActiveCaptionItem = new bool?(false),
				SlotInteractive = new bool?(false),
				ResultShowTips = new bool?(false),
				IsSingleMode = new bool?(true),
				CurrencyChangeCallback = delegate(int[] itemIdList)
				{
					List<int> currencyItemList = new List<int>(itemIdList);
					this.TabComponent.SetCurrencyItemList(currencyItemList);
				},
				RecommendRefineSubList = recommendRefineSubList
			};
		}
		else
		{
			result = this.CurrentUniqueId;
		}
		return result;
	}

	// Token: 0x06012EDA RID: 77530 RVA: 0x004AE8EF File Offset: 0x004ACAEF
	public void SetCurrencyItemList(EUiTabViewName viewName)
	{
		this.CurrencyItemList.Clear();
		if (viewName != EUiTabViewName.VisionRefineTabView)
		{
			this.CurrencyItemList.Add(2);
			this.TabComponent.SetCurrencyItemList(this.CurrencyItemList);
		}
	}

	// Token: 0x06012EDB RID: 77531 RVA: 0x004AE927 File Offset: 0x004ACB27
	private void OnClickHelpButton()
	{
		HelpController.Instance.OpenHelpById(32);
	}

	// Token: 0x06012EDC RID: 77532 RVA: 0x004AE938 File Offset: 0x004ACB38
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x06012EDD RID: 77533 RVA: 0x004AE970 File Offset: 0x004ACB70
	protected void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06012EDE RID: 77534 RVA: 0x004AE97C File Offset: 0x004ACB7C
	protected override void OnHandleLoadScene()
	{
		EUiTabViewName? currentTabViewName = this.TabViewComponent.GetCurrentTabViewName(null);
		if (currentTabViewName == null)
		{
			return;
		}
		this.HandleVisionSkeletal(currentTabViewName.Value);
	}

	// Token: 0x06012EDF RID: 77535 RVA: 0x004AE9B5 File Offset: 0x004ACBB5
	protected override void OnHandleReleaseScene()
	{
		this.DestroyVisionSkeletal();
	}

	// Token: 0x06012EE0 RID: 77536 RVA: 0x004AE9C0 File Offset: 0x004ACBC0
	protected override void OnBeforeShow()
	{
		PhantomBattleModel instance = PhantomBattleModel.Instance;
		if (instance != null)
		{
			instance.AddNeedCameraFocusMethodDisableViewCount();
		}
		List<UiDynamicTab> viewTabList = DynamicTabConfig.Instance.GetViewTabList(this.ViewInfo.Name);
		foreach (UiDynamicTab item in viewTabList)
		{
			this.TabDataList.Add(item);
		}
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(this.CurrentUniqueId);
		if (phantomBattleData == null)
		{
			return;
		}
		bool flag = FunctionModel.Instance.IsOpen(10001004);
		int num;
		if (phantomBattleData.GetQuality() <= 2 || !flag)
		{
			num = 1;
		}
		else
		{
			num = viewTabList.Count;
		}
		TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
		Dictionary<int, CommonTabItem> dictionary = (tabComponent != null) ? tabComponent.GetTabItemMap() : null;
		if (dictionary != null && num != dictionary.Count)
		{
			this.CurSelectTabIndex = 0;
		}
		TabComponentWithCaptionItem<CommonTabItem> tabComponent2 = this.TabComponent;
		if (tabComponent2 == null)
		{
			return;
		}
		tabComponent2.RefreshTabItemByLength(num, new Action(this.RefreshTabCallBack));
	}

	// Token: 0x06012EE1 RID: 77537 RVA: 0x004AEAC8 File Offset: 0x004ACCC8
	private void RefreshTabUnlockState()
	{
		TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
		Dictionary<int, CommonTabItem> dictionary = (tabComponent != null) ? tabComponent.GetTabItemMap() : null;
		if (dictionary == null)
		{
			return;
		}
		foreach (KeyValuePair<int, CommonTabItem> keyValuePair in dictionary)
		{
			int key = keyValuePair.Key;
			CommonTabItem value = keyValuePair.Value;
			UiDynamicTab tabData = this.TabDataList[key];
			if (VisionDefine.tabViewWithLock != null && VisionDefine.tabViewWithLock.Contains(tabData.ChildViewName))
			{
				ValueTuple<bool, string> state = this.CheckTabIfUnlock(tabData);
				if (state.Item1)
				{
					value.SetToggleStateForce(EToggleState.ETT_UnChecked, false);
				}
				else
				{
					value.SetToggleStateForce(EToggleState.ETT_UnDetermined, false);
					value.SetCanClickWhenDisable(true);
					value.SetOnUndeterminedClick(delegate
					{
						if (state.Item2 != null)
						{
							GenericPromptController.Instance.ShowPromptByCode(state.Item2, Array.Empty<object>());
						}
					});
				}
			}
		}
	}

	// Token: 0x06012EE2 RID: 77538 RVA: 0x004AEBB8 File Offset: 0x004ACDB8
	private void RefreshTabCallBack()
	{
		this.RefreshTabUnlockState();
		this.TabComponent.SelectToggleByIndex(this.CurSelectTabIndex, true);
		this.TabViewComponent.SetCurrentTabViewState(true);
		this.BindRedDot();
		EventSystem.Instance.Emit<int>(EEventName.RefreshVisionIdentifyRedPoint, this.CurrentUniqueId);
	}

	// Token: 0x06012EE3 RID: 77539 RVA: 0x004AEC08 File Offset: 0x004ACE08
	private void BindRedDot()
	{
		int num = -1;
		for (int i = 0; i < this.TabDataList.Count; i++)
		{
			if (this.TabDataList[i].ChildViewName == EUiTabViewName.VisionIdentifyView.ToString())
			{
				num = i;
				break;
			}
		}
		if (num > 0)
		{
			CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(num);
			if (tabItemByIndex != null)
			{
				tabItemByIndex.BindRedDot(ERedDotName.VisionIdentifyTab, new int?(this.CurrentUniqueId));
			}
		}
	}

	// Token: 0x06012EE4 RID: 77540 RVA: 0x004AEC84 File Offset: 0x004ACE84
	private void UnBindRedDot()
	{
		int num = -1;
		for (int i = 0; i < this.TabDataList.Count; i++)
		{
			if (this.TabDataList[i].ChildViewName == EUiTabViewName.VisionIdentifyView.ToString())
			{
				num = i;
				break;
			}
		}
		if (num > 0)
		{
			CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(num);
			if (tabItemByIndex != null)
			{
				tabItemByIndex.UnBindRedDot();
			}
		}
	}

	// Token: 0x06012EE5 RID: 77541 RVA: 0x004AECF2 File Offset: 0x004ACEF2
	protected override void OnBeforeHide()
	{
		this.UnBindRedDot();
		PhantomBattleModel instance = PhantomBattleModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.ReduceNeedCameraFocusMethodDisableViewCount();
	}

	// Token: 0x06012EE6 RID: 77542 RVA: 0x004AED0C File Offset: 0x004ACF0C
	protected override void OnAfterHide()
	{
		UiTabViewBase currentTabView = this.TabViewComponent.GetCurrentTabView();
		if (currentTabView != null)
		{
			currentTabView.HideUiTabView(false);
		}
	}

	// Token: 0x06012EE7 RID: 77543 RVA: 0x004AED30 File Offset: 0x004ACF30
	protected override void OnBeforeCreate()
	{
		VisionIntensifyViewPassData visionIntensifyViewPassData = this.OpenParam as VisionIntensifyViewPassData;
		if (visionIntensifyViewPassData == null)
		{
			return;
		}
		this.CurrentUniqueId = visionIntensifyViewPassData.UniqueId;
		this.CurrentRoleId = visionIntensifyViewPassData.RoleId;
	}

	// Token: 0x06012EE8 RID: 77544 RVA: 0x004AED65 File Offset: 0x004ACF65
	protected override void OnBeforeDestroy()
	{
		this.TabViewComponent.DestroyTabViewComponent();
		this.TabComponent.Destroy(null);
		EventSystem.Instance.Emit<bool>(EEventName.OnVisionIntensifyViewShow, false);
	}

	// Token: 0x06012EE9 RID: 77545 RVA: 0x004AED90 File Offset: 0x004ACF90
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		int num = int.Parse(configParams[0]);
		int index = -1;
		for (int i = 0; i < this.TabDataList.Count; i++)
		{
			if (this.TabDataList[i].Id == num)
			{
				index = i;
				break;
			}
		}
		CommonTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
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

	// Token: 0x06012EEA RID: 77546 RVA: 0x004AEE33 File Offset: 0x004AD033
	public int GetCurrentUniqueId()
	{
		return this.CurrentUniqueId;
	}

	// Token: 0x04008E97 RID: 36503
	private const int VISION_INTENSIFY_HELPID = 32;

	// Token: 0x04008E98 RID: 36504
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

	// Token: 0x04008E99 RID: 36505
	[Nullable(2)]
	protected TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x04008E9A RID: 36506
	private readonly List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x04008E9B RID: 36507
	private int CurrentUniqueId;

	// Token: 0x04008E9C RID: 36508
	private int CurrentRoleId;

	// Token: 0x04008E9D RID: 36509
	private readonly List<int> CurrencyItemList = new List<int>();

	// Token: 0x04008E9E RID: 36510
	private int CurSelectTabIndex;

	// Token: 0x02008A57 RID: 35415
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CEB8 RID: 183992
		Item,
		// Token: 0x0402CEB9 RID: 183993
		MountItem,
		// Token: 0x0402CEBA RID: 183994
		Bg
	}
}
