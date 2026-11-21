using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020019B3 RID: 6579
[NullableContext(1)]
[Nullable(0)]
public class VisionIntensifyView : UiViewBase
{
	// Token: 0x06010387 RID: 66439 RVA: 0x004BBE7F File Offset: 0x004BA07F
	public VisionIntensifyView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010388 RID: 66440 RVA: 0x004BBEA0 File Offset: 0x004BA0A0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06010389 RID: 66441 RVA: 0x004BBEFC File Offset: 0x004BA0FC
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

	// Token: 0x0601038A RID: 66442 RVA: 0x004BBFA8 File Offset: 0x004BA1A8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<bool>(EEventName.RefreshVisionIntensifyViewBackBtnState, new Action<bool>(this.OnRefreshVisionIntensifyViewBackBtnState));
		EventSystem.Instance.Add(EEventName.PhantomLevelUp, new Action(this.OnVisionLevelUp));
		EventSystem.Instance.Add<int, int>(EEventName.OnPhantomStackMerge, new Action<int, int>(this.OnPhantomStackMerge));
		EventSystem.Instance.Add(EEventName.OnClickVisionIntensifyItemJump, new Action(this.OnClickVisionIntensifyItemJump));
	}

	// Token: 0x0601038B RID: 66443 RVA: 0x004BC028 File Offset: 0x004BA228
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshVisionIntensifyViewBackBtnState, new Action<bool>(this.OnRefreshVisionIntensifyViewBackBtnState));
		EventSystem.Instance.Remove(EEventName.PhantomLevelUp, new Action(this.OnVisionLevelUp));
		EventSystem.Instance.Remove(EEventName.OnPhantomStackMerge, new Action<int, int>(this.OnPhantomStackMerge));
		EventSystem.Instance.Remove(EEventName.OnClickVisionIntensifyItemJump, new Action(this.OnClickVisionIntensifyItemJump));
	}

	// Token: 0x0601038C RID: 66444 RVA: 0x004BC0A8 File Offset: 0x004BA2A8
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

	// Token: 0x0601038D RID: 66445 RVA: 0x004BC0EA File Offset: 0x004BA2EA
	private void OnRefreshVisionIntensifyViewBackBtnState(bool state)
	{
		this.TabComponent.SetCloseBtnShowState(state);
	}

	// Token: 0x0601038E RID: 66446 RVA: 0x004BC0F8 File Offset: 0x004BA2F8
	private void OnClickVisionIntensifyItemJump()
	{
		this.TabComponent.SelectToggleByIndex(1, false);
	}

	// Token: 0x0601038F RID: 66447 RVA: 0x004BC108 File Offset: 0x004BA308
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

	// Token: 0x06010390 RID: 66448 RVA: 0x004BC13C File Offset: 0x004BA33C
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

	// Token: 0x06010391 RID: 66449 RVA: 0x004BC1A5 File Offset: 0x004BA3A5
	private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new VisionTabItem();
	}

	// Token: 0x06010392 RID: 66450 RVA: 0x004BC1AC File Offset: 0x004BA3AC
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

	// Token: 0x06010393 RID: 66451 RVA: 0x004BC2A8 File Offset: 0x004BA4A8
	protected override void OnBeforePlayCloseSequence()
	{
		UiTabViewBase currentTabView = this.TabViewComponent.GetCurrentTabView();
		if (currentTabView != null)
		{
			new UiSequencePlayer(currentTabView.GetRootItem()).PlaySequence("Close", false, null);
		}
	}

	// Token: 0x06010394 RID: 66452 RVA: 0x004BC2E4 File Offset: 0x004BA4E4
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

	// Token: 0x06010395 RID: 66453 RVA: 0x004BC37D File Offset: 0x004BA57D
	private void HandleVisionSkeletal(EUiTabViewName viewName)
	{
		if (viewName == EUiTabViewName.VisionRefineTabView)
		{
			this.DestroyVisionSkeletal();
			return;
		}
		this.ShowVisionSkeletal();
	}

	// Token: 0x06010396 RID: 66454 RVA: 0x004BC39C File Offset: 0x004BA59C
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

	// Token: 0x06010397 RID: 66455 RVA: 0x004BC3F7 File Offset: 0x004BA5F7
	private void DestroyVisionSkeletal()
	{
		UiSceneManager.Instance.DestroyVisionSkeletalHandle();
	}

	// Token: 0x06010398 RID: 66456 RVA: 0x004BC404 File Offset: 0x004BA604
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

	// Token: 0x06010399 RID: 66457 RVA: 0x004BC4EF File Offset: 0x004BA6EF
	public void SetCurrencyItemList(EUiTabViewName viewName)
	{
		this.CurrencyItemList.Clear();
		if (viewName != EUiTabViewName.VisionRefineTabView)
		{
			this.CurrencyItemList.Add(2);
			this.TabComponent.SetCurrencyItemList(this.CurrencyItemList);
		}
	}

	// Token: 0x0601039A RID: 66458 RVA: 0x004BC527 File Offset: 0x004BA727
	private void OnClickHelpButton()
	{
		HelpController.Instance.OpenHelpById(32);
	}

	// Token: 0x0601039B RID: 66459 RVA: 0x004BC538 File Offset: 0x004BA738
	private CommonTabData GetCommonData(int index)
	{
		UiDynamicTab uiDynamicTab = this.TabDataList[index];
		return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x0601039C RID: 66460 RVA: 0x004BC570 File Offset: 0x004BA770
	protected void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0601039D RID: 66461 RVA: 0x004BC57C File Offset: 0x004BA77C
	protected override void OnHandleLoadScene()
	{
		EUiTabViewName? currentTabViewName = this.TabViewComponent.GetCurrentTabViewName(null);
		if (currentTabViewName == null)
		{
			return;
		}
		this.HandleVisionSkeletal(currentTabViewName.Value);
	}

	// Token: 0x0601039E RID: 66462 RVA: 0x004BC5B5 File Offset: 0x004BA7B5
	protected override void OnHandleReleaseScene()
	{
		this.DestroyVisionSkeletal();
	}

	// Token: 0x0601039F RID: 66463 RVA: 0x004BC5C0 File Offset: 0x004BA7C0
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

	// Token: 0x060103A0 RID: 66464 RVA: 0x004BC6C8 File Offset: 0x004BA8C8
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

	// Token: 0x060103A1 RID: 66465 RVA: 0x004BC7B8 File Offset: 0x004BA9B8
	private void RefreshTabCallBack()
	{
		this.RefreshTabUnlockState();
		this.TabComponent.SelectToggleByIndex(this.CurSelectTabIndex, true);
		this.TabViewComponent.SetCurrentTabViewState(true);
		this.BindRedDot();
		EventSystem.Instance.Emit<int>(EEventName.RefreshVisionIdentifyRedPoint, this.CurrentUniqueId);
	}

	// Token: 0x060103A2 RID: 66466 RVA: 0x004BC808 File Offset: 0x004BAA08
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

	// Token: 0x060103A3 RID: 66467 RVA: 0x004BC884 File Offset: 0x004BAA84
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

	// Token: 0x060103A4 RID: 66468 RVA: 0x004BC8F2 File Offset: 0x004BAAF2
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

	// Token: 0x060103A5 RID: 66469 RVA: 0x004BC90C File Offset: 0x004BAB0C
	protected override void OnAfterHide()
	{
		UiTabViewBase currentTabView = this.TabViewComponent.GetCurrentTabView();
		if (currentTabView != null)
		{
			currentTabView.HideUiTabView(false);
		}
	}

	// Token: 0x060103A6 RID: 66470 RVA: 0x004BC930 File Offset: 0x004BAB30
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

	// Token: 0x060103A7 RID: 66471 RVA: 0x004BC965 File Offset: 0x004BAB65
	protected override void OnBeforeDestroy()
	{
		this.TabViewComponent.DestroyTabViewComponent();
		this.TabComponent.Destroy(null);
		EventSystem.Instance.Emit<bool>(EEventName.OnVisionIntensifyViewShow, false);
	}

	// Token: 0x060103A8 RID: 66472 RVA: 0x004BC990 File Offset: 0x004BAB90
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

	// Token: 0x060103A9 RID: 66473 RVA: 0x004BCA33 File Offset: 0x004BAC33
	public int GetCurrentUniqueId()
	{
		return this.CurrentUniqueId;
	}

	// Token: 0x04008FE1 RID: 36833
	private const int VISION_INTENSIFY_HELPID = 32;

	// Token: 0x04008FE2 RID: 36834
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponentWithCaptionItem<CommonTabItem> TabComponent;

	// Token: 0x04008FE3 RID: 36835
	[Nullable(2)]
	protected TabViewComponent<UiDynamicTab> TabViewComponent;

	// Token: 0x04008FE4 RID: 36836
	private readonly List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x04008FE5 RID: 36837
	private int CurrentUniqueId;

	// Token: 0x04008FE6 RID: 36838
	private int CurrentRoleId;

	// Token: 0x04008FE7 RID: 36839
	private readonly List<int> CurrencyItemList = new List<int>();

	// Token: 0x04008FE8 RID: 36840
	private int CurSelectTabIndex;

	// Token: 0x02007BE0 RID: 31712
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040281D6 RID: 164310
		Item,
		// Token: 0x040281D7 RID: 164311
		MountItem,
		// Token: 0x040281D8 RID: 164312
		Bg
	}
}
