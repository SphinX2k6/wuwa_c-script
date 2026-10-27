using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Calabash.New.VisionRefine;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200177A RID: 6010
[NullableContext(1)]
[Nullable(0)]
public class VisionRefineTabView : UiTabViewBase
{
	// Token: 0x17000E7A RID: 3706
	// (get) Token: 0x0600AE48 RID: 44616 RVA: 0x002744AC File Offset: 0x002726AC
	// (set) Token: 0x0600AE49 RID: 44617 RVA: 0x0027451C File Offset: 0x0027271C
	[Nullable(2)]
	private IRefineAttrItemData SelectMainAttribute
	{
		[NullableContext(2)]
		get
		{
			if (this.ExtraParamsExactly != null && this.ExtraParamsExactly.IsSingleMode.GetValueOrDefault())
			{
				return this.SelectMainAttributeInternalSingle;
			}
			VisionRefineChoosePanel choosePanel = this.ChoosePanel;
			EVisionRefineCostType? evisionRefineCostType = (choosePanel != null) ? choosePanel.CurrentCostType : null;
			if (evisionRefineCostType == null)
			{
				return null;
			}
			IRefineAttrItemData result;
			if (this.SelectMainAttributeInternalMulti.TryGetValue(evisionRefineCostType.Value, out result))
			{
				return result;
			}
			return null;
		}
		[NullableContext(2)]
		set
		{
			if (this.ExtraParamsExactly != null && this.ExtraParamsExactly.IsSingleMode.GetValueOrDefault())
			{
				this.SelectMainAttributeInternalSingle = value;
				return;
			}
			VisionRefineChoosePanel choosePanel = this.ChoosePanel;
			EVisionRefineCostType? evisionRefineCostType = (choosePanel != null) ? choosePanel.CurrentCostType : null;
			if (evisionRefineCostType == null)
			{
				return;
			}
			if (value == null)
			{
				this.SelectMainAttributeInternalMulti.Remove(evisionRefineCostType.Value);
				return;
			}
			this.SelectMainAttributeInternalMulti[evisionRefineCostType.Value] = value;
		}
	}

	// Token: 0x17000E7B RID: 3707
	// (get) Token: 0x0600AE4A RID: 44618 RVA: 0x0027459D File Offset: 0x0027279D
	[Nullable(2)]
	private PhantomItemData SelectedVision
	{
		[NullableContext(2)]
		get
		{
			if (this.CurrentRefineType == EVisionRefineRefineType.Main)
			{
				return null;
			}
			VisionRefineChoosePanel choosePanel = this.ChoosePanel;
			if (choosePanel == null)
			{
				return null;
			}
			return choosePanel.GetSelection();
		}
	}

	// Token: 0x17000E7C RID: 3708
	// (get) Token: 0x0600AE4B RID: 44619 RVA: 0x002745BC File Offset: 0x002727BC
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ISelectedData> SelectedVisionValidList
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			VisionRefineChoosePanel choosePanel = this.ChoosePanel;
			List<ISelectedData> list = (choosePanel != null) ? choosePanel.CurrentSelectedList : null;
			if (list == null)
			{
				return null;
			}
			return list.FindAll(delegate(ISelectedData target)
			{
				if (this.SelectMainAttribute == null)
				{
					return true;
				}
				PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(target.IncId);
				return phantomDataBase != null && this.SelectMainAttribute.PropItemId != phantomDataBase.GetPhantomFirstMainProp().PhantomPropId;
			});
		}
	}

	// Token: 0x17000E7D RID: 3709
	// (get) Token: 0x0600AE4C RID: 44620 RVA: 0x002745F3 File Offset: 0x002727F3
	[Nullable(2)]
	private IVisionRefineTabViewParam ExtraParamsExactly
	{
		[NullableContext(2)]
		get
		{
			if (this.ExtraParams == null)
			{
				return null;
			}
			return this.ExtraParams as IVisionRefineTabViewParam;
		}
	}

	// Token: 0x0600AE4D RID: 44621 RVA: 0x0027460C File Offset: 0x0027280C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIText)),
			new ValueTuple<int, Type>(19, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUIItem)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUILayoutBase))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickTip)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickRefine)),
			new ValueTuple<int, Delegate>(19, new Action(this.OnClickRefineMainDelete))
		};
	}

	// Token: 0x0600AE4E RID: 44622 RVA: 0x002748B0 File Offset: 0x00272AB0
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRefineTabView.<OnBeforeStartAsync>d__30 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRefineTabView.<OnBeforeStartAsync>d__30>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE4F RID: 44623 RVA: 0x002748F4 File Offset: 0x00272AF4
	private UniTask InitMainSlotItemAsync()
	{
		VisionRefineTabView.<InitMainSlotItemAsync>d__31 <InitMainSlotItemAsync>d__;
		<InitMainSlotItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitMainSlotItemAsync>d__.<>4__this = this;
		<InitMainSlotItemAsync>d__.<>1__state = -1;
		<InitMainSlotItemAsync>d__.<>t__builder.Start<VisionRefineTabView.<InitMainSlotItemAsync>d__31>(ref <InitMainSlotItemAsync>d__);
		return <InitMainSlotItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE50 RID: 44624 RVA: 0x00274938 File Offset: 0x00272B38
	private UniTask InitSubSlotItemAsync()
	{
		VisionRefineTabView.<InitSubSlotItemAsync>d__32 <InitSubSlotItemAsync>d__;
		<InitSubSlotItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSubSlotItemAsync>d__.<>4__this = this;
		<InitSubSlotItemAsync>d__.<>1__state = -1;
		<InitSubSlotItemAsync>d__.<>t__builder.Start<VisionRefineTabView.<InitSubSlotItemAsync>d__32>(ref <InitSubSlotItemAsync>d__);
		return <InitSubSlotItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE51 RID: 44625 RVA: 0x0027497C File Offset: 0x00272B7C
	private UniTask InitChoosePanelAsync()
	{
		VisionRefineTabView.<InitChoosePanelAsync>d__33 <InitChoosePanelAsync>d__;
		<InitChoosePanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChoosePanelAsync>d__.<>4__this = this;
		<InitChoosePanelAsync>d__.<>1__state = -1;
		<InitChoosePanelAsync>d__.<>t__builder.Start<VisionRefineTabView.<InitChoosePanelAsync>d__33>(ref <InitChoosePanelAsync>d__);
		return <InitChoosePanelAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE52 RID: 44626 RVA: 0x002749C0 File Offset: 0x00272BC0
	private UniTask InitSingleAttributePanelAsync()
	{
		VisionRefineTabView.<InitSingleAttributePanelAsync>d__34 <InitSingleAttributePanelAsync>d__;
		<InitSingleAttributePanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSingleAttributePanelAsync>d__.<>4__this = this;
		<InitSingleAttributePanelAsync>d__.<>1__state = -1;
		<InitSingleAttributePanelAsync>d__.<>t__builder.Start<VisionRefineTabView.<InitSingleAttributePanelAsync>d__34>(ref <InitSingleAttributePanelAsync>d__);
		return <InitSingleAttributePanelAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE53 RID: 44627 RVA: 0x00274A04 File Offset: 0x00272C04
	private UniTask InitMultiAttributePanelAsync()
	{
		VisionRefineTabView.<InitMultiAttributePanelAsync>d__35 <InitMultiAttributePanelAsync>d__;
		<InitMultiAttributePanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitMultiAttributePanelAsync>d__.<>4__this = this;
		<InitMultiAttributePanelAsync>d__.<>1__state = -1;
		<InitMultiAttributePanelAsync>d__.<>t__builder.Start<VisionRefineTabView.<InitMultiAttributePanelAsync>d__35>(ref <InitMultiAttributePanelAsync>d__);
		return <InitMultiAttributePanelAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE54 RID: 44628 RVA: 0x00274A48 File Offset: 0x00272C48
	private UniTask InitCostItemAsync()
	{
		VisionRefineTabView.<InitCostItemAsync>d__36 <InitCostItemAsync>d__;
		<InitCostItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCostItemAsync>d__.<>4__this = this;
		<InitCostItemAsync>d__.<>1__state = -1;
		<InitCostItemAsync>d__.<>t__builder.Start<VisionRefineTabView.<InitCostItemAsync>d__36>(ref <InitCostItemAsync>d__);
		return <InitCostItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE55 RID: 44629 RVA: 0x00274A8C File Offset: 0x00272C8C
	private UniTask InitUpLeftTabAsync()
	{
		VisionRefineTabView.<InitUpLeftTabAsync>d__37 <InitUpLeftTabAsync>d__;
		<InitUpLeftTabAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitUpLeftTabAsync>d__.<>4__this = this;
		<InitUpLeftTabAsync>d__.<>1__state = -1;
		<InitUpLeftTabAsync>d__.<>t__builder.Start<VisionRefineTabView.<InitUpLeftTabAsync>d__37>(ref <InitUpLeftTabAsync>d__);
		return <InitUpLeftTabAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE56 RID: 44630 RVA: 0x00274AD0 File Offset: 0x00272CD0
	private UniTask InitSubVerticalAsync()
	{
		VisionRefineTabView.<InitSubVerticalAsync>d__38 <InitSubVerticalAsync>d__;
		<InitSubVerticalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSubVerticalAsync>d__.<>4__this = this;
		<InitSubVerticalAsync>d__.<>1__state = -1;
		<InitSubVerticalAsync>d__.<>t__builder.Start<VisionRefineTabView.<InitSubVerticalAsync>d__38>(ref <InitSubVerticalAsync>d__);
		return <InitSubVerticalAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE57 RID: 44631 RVA: 0x00274B14 File Offset: 0x00272D14
	private UniTask LoadRefineSubUpperVertAsync()
	{
		VisionRefineTabView.<LoadRefineSubUpperVertAsync>d__39 <LoadRefineSubUpperVertAsync>d__;
		<LoadRefineSubUpperVertAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadRefineSubUpperVertAsync>d__.<>4__this = this;
		<LoadRefineSubUpperVertAsync>d__.<>1__state = -1;
		<LoadRefineSubUpperVertAsync>d__.<>t__builder.Start<VisionRefineTabView.<LoadRefineSubUpperVertAsync>d__39>(ref <LoadRefineSubUpperVertAsync>d__);
		return <LoadRefineSubUpperVertAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE58 RID: 44632 RVA: 0x00274B58 File Offset: 0x00272D58
	private UniTask InitRefineMainGridAsync()
	{
		VisionRefineTabView.<InitRefineMainGridAsync>d__40 <InitRefineMainGridAsync>d__;
		<InitRefineMainGridAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRefineMainGridAsync>d__.<>4__this = this;
		<InitRefineMainGridAsync>d__.<>1__state = -1;
		<InitRefineMainGridAsync>d__.<>t__builder.Start<VisionRefineTabView.<InitRefineMainGridAsync>d__40>(ref <InitRefineMainGridAsync>d__);
		return <InitRefineMainGridAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE59 RID: 44633 RVA: 0x00274B9C File Offset: 0x00272D9C
	private UniTask InitInvalidTipsAsync()
	{
		VisionRefineTabView.<InitInvalidTipsAsync>d__41 <InitInvalidTipsAsync>d__;
		<InitInvalidTipsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitInvalidTipsAsync>d__.<>4__this = this;
		<InitInvalidTipsAsync>d__.<>1__state = -1;
		<InitInvalidTipsAsync>d__.<>t__builder.Start<VisionRefineTabView.<InitInvalidTipsAsync>d__41>(ref <InitInvalidTipsAsync>d__);
		return <InitInvalidTipsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE5A RID: 44634 RVA: 0x00274BDF File Offset: 0x00272DDF
	private VisionRefineMaterialItem InitMaterialItem()
	{
		return new VisionRefineMaterialItem();
	}

	// Token: 0x0600AE5B RID: 44635 RVA: 0x00274BE6 File Offset: 0x00272DE6
	private VisionRefineRefineTab InitUpLeftTabItem()
	{
		return new VisionRefineRefineTab();
	}

	// Token: 0x0600AE5C RID: 44636 RVA: 0x00274BED File Offset: 0x00272DED
	private VisionRefineAttributeItem InitSingleVerticalItem()
	{
		return new VisionRefineAttributeItem
		{
			OnSelectedCallback = new Func<int, bool>(this.OnClickSubAttributeSelected),
			OnDeselectedCallback = new Func<int, bool>(this.OnClickSubAttributeDeselected)
		};
	}

	// Token: 0x0600AE5D RID: 44637 RVA: 0x00274C18 File Offset: 0x00272E18
	private VisionRefineSlotItem InitRefineMainGridItem()
	{
		return new VisionRefineSlotItem(new Action<bool, int>(this.OnClickRefineMainGrid))
		{
			OnGetMainPropItemIdCallback = new Func<int?>(this.OnGetMainPropItemIdCallback),
			OnIsShouldElementItemDownCallback = new Func<bool>(this.OnIsShouldElementItemDownCallback)
		};
	}

	// Token: 0x0600AE5E RID: 44638 RVA: 0x00274C50 File Offset: 0x00272E50
	protected override void OnStart()
	{
		this.SetCaptionItem(false, null);
		UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
		LevelSequencePlayer levelSequencePlayer = (tabBehavior != null) ? tabBehavior.GetLevelSequencePlayer() : null;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.BindSequenceStartEvent(new TSequenceStartEvent(this.OnSequenceTabStart));
			levelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceTabFinish), false);
		}
		this.SetViewState(ERefineViewState.Root, false);
		this.ClearSelectMainAttribute();
	}

	// Token: 0x0600AE5F RID: 44639 RVA: 0x00274CB8 File Offset: 0x00272EB8
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<PhantomPolishResponse>(EEventName.OnVisionRefineResult, new Action<PhantomPolishResponse>(this.OnResponseVisionRefine));
		EventSystem.Instance.Add<PhantomBatchPolishResponse>(EEventName.OnVisionRefineBatchMainResult, new Action<PhantomBatchPolishResponse>(this.OnVisionRefineBatchMainResult));
		EventSystem.Instance.Add<PhantomVicePolishResponse>(EEventName.OnVisionRefineSubPreviewResult, new Action<PhantomVicePolishResponse>(this.OnVisionRefineSubPreviewResult));
		EventSystem.Instance.Add<PhantomVicePolishAckResponse, bool>(EEventName.OnVisionRefineSubResult, new Action<PhantomVicePolishAckResponse, bool>(this.OnVisionRefineSubResult));
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Add<int, int>(EEventName.OnPhantomStackMerge, new Action<int, int>(this.OnPhantomStackMerge));
	}

	// Token: 0x0600AE60 RID: 44640 RVA: 0x00274D70 File Offset: 0x00272F70
	private void OnPhantomStackMerge(int mergedIncrId, int representativeIncrId)
	{
		VisionRefineChoosePanel choosePanel = this.ChoosePanel;
		if (choosePanel != null)
		{
			choosePanel.RedirectSelectionOnStackMerge(mergedIncrId, representativeIncrId);
		}
		IVisionRefineTabViewParam extraParamsExactly = this.ExtraParamsExactly;
		if (extraParamsExactly != null)
		{
			int? uniqueId = extraParamsExactly.UniqueId;
			if (uniqueId.GetValueOrDefault() == mergedIncrId & uniqueId != null)
			{
				extraParamsExactly.UniqueId = new int?(representativeIncrId);
			}
		}
	}

	// Token: 0x0600AE61 RID: 44641 RVA: 0x00274DC4 File Offset: 0x00272FC4
	protected override void OnShowUiTabViewFromToggle()
	{
		if (this.ExtraParamsExactly == null)
		{
			return;
		}
		IVisionRefineTabViewParam extraParamsExactly = this.ExtraParamsExactly;
		if (extraParamsExactly.UniqueId != null)
		{
			PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(extraParamsExactly.UniqueId.Value);
			if (phantomItemData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Calabash;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "当前声骸没有对应背包数据";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("uid", extraParamsExactly.UniqueId.Value);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			VisionRefineChoosePanel choosePanel = this.ChoosePanel;
			if (choosePanel != null)
			{
				choosePanel.SetSelectionDummy(phantomItemData);
			}
			VisionRefineChoosePanel choosePanel2 = this.ChoosePanel;
			if (choosePanel2 != null)
			{
				choosePanel2.SetSelection(phantomItemData);
			}
		}
		if (this.ExtraParamsExactly.RefineType != null)
		{
			this.CurrentRefineType = this.ExtraParamsExactly.RefineType.Value;
			this.ChoosePanel.CurrentRefineType = this.ExtraParamsExactly.RefineType.Value;
		}
		this.SetViewState(extraParamsExactly.ViewState, true);
	}

	// Token: 0x0600AE62 RID: 44642 RVA: 0x00274ECA File Offset: 0x002730CA
	protected override void OnBeforeShow()
	{
		this.HasInitChoosePanel = false;
		if (this.CurrentRefineType != EVisionRefineRefineType.Sub)
		{
			VisionRefineChoosePanel choosePanel = this.ChoosePanel;
			if (choosePanel != null)
			{
				choosePanel.RemoveInvalidSelections();
			}
		}
		this.RefreshSlotPanel();
		this.RefreshChoosePanel();
		this.RefreshCostItemList();
	}

	// Token: 0x0600AE63 RID: 44643 RVA: 0x00274EFF File Offset: 0x002730FF
	protected override void OnAfterShow()
	{
		PhantomBattleModel.Instance.RecordVisionRefineRedDot(false);
	}

	// Token: 0x0600AE64 RID: 44644 RVA: 0x00274F0C File Offset: 0x0027310C
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove<PhantomPolishResponse>(EEventName.OnVisionRefineResult, new Action<PhantomPolishResponse>(this.OnResponseVisionRefine));
		EventSystem.Instance.Remove<PhantomBatchPolishResponse>(EEventName.OnVisionRefineBatchMainResult, new Action<PhantomBatchPolishResponse>(this.OnVisionRefineBatchMainResult));
		EventSystem.Instance.Remove<PhantomVicePolishResponse>(EEventName.OnVisionRefineSubPreviewResult, new Action<PhantomVicePolishResponse>(this.OnVisionRefineSubPreviewResult));
		EventSystem.Instance.Remove<PhantomVicePolishAckResponse, bool>(EEventName.OnVisionRefineSubResult, new Action<PhantomVicePolishAckResponse, bool>(this.OnVisionRefineSubResult));
		EventSystem.Instance.Remove<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Remove(EEventName.OnPhantomStackMerge, new Action<int, int>(this.OnPhantomStackMerge));
	}

	// Token: 0x0600AE65 RID: 44645 RVA: 0x00274FC4 File Offset: 0x002731C4
	private void RefreshChoosePanel()
	{
		if (this.ExtraParamsExactly != null && this.ExtraParamsExactly.IsSingleMode.GetValueOrDefault())
		{
			return;
		}
		this.HasInitChoosePanel = true;
		List<PhantomItemData> phantomItemDataList = InventoryModel.Instance.GetPhantomItemDataList();
		this.ChoosePanel.RefreshList(phantomItemDataList);
	}

	// Token: 0x0600AE66 RID: 44646 RVA: 0x00275010 File Offset: 0x00273210
	private void SetViewState(ERefineViewState newState, bool force = false)
	{
		ERefineViewState? stateView = this.StateView;
		if ((stateView.GetValueOrDefault() == newState & stateView != null) && !force)
		{
			return;
		}
		VisionRefineChoosePanel choosePanel = this.ChoosePanel;
		if (choosePanel != null)
		{
			choosePanel.SetActive(newState == ERefineViewState.Choose);
		}
		GenericLayout<VisionRefineMaterialItem, ISelectedData> materialLayout = this.MaterialLayout;
		if (materialLayout != null)
		{
			materialLayout.SetActive(newState != ERefineViewState.Attribute);
		}
		VisionRefineCostItem costItem = this.CostItem;
		if (costItem != null)
		{
			costItem.SetActive(newState == ERefineViewState.Attribute);
		}
		GenericLayout<VisionRefineRefineTab, VisionRefineRefineTabData> upLeftTab = this.UpLeftTab;
		if (upLeftTab != null)
		{
			upLeftTab.SetActive(newState != ERefineViewState.Choose);
		}
		if (newState != ERefineViewState.Choose)
		{
			GenericLayout<VisionRefineRefineTab, VisionRefineRefineTabData> upLeftTab2 = this.UpLeftTab;
			if (upLeftTab2 != null)
			{
				upLeftTab2.RefreshByDataAsync(this.BuildUpLeftTabData(), false, null).Forget();
			}
		}
		if (this.StateView != null)
		{
			switch (newState)
			{
			case ERefineViewState.Root:
				this.ShowRootState(this.StateView.Value);
				break;
			case ERefineViewState.Choose:
				this.ShowChooseState(this.StateView.Value);
				break;
			case ERefineViewState.Attribute:
				this.ShowAttributeState(this.StateView.Value);
				break;
			}
		}
		this.StateView = new ERefineViewState?(newState);
		this.RefreshSlotPanel();
		VisionRefineChoosePanel choosePanel2 = this.ChoosePanel;
		if (choosePanel2 != null)
		{
			choosePanel2.ShowTipsComponent(null);
		}
		if (newState == ERefineViewState.Choose)
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "VisionRefineChooseStart");
		}
	}

	// Token: 0x0600AE67 RID: 44647 RVA: 0x00275158 File Offset: 0x00273358
	private void ShowChooseState(ERefineViewState oldState)
	{
		if (!this.HasInitChoosePanel)
		{
			this.RefreshChoosePanel();
		}
		if (oldState == ERefineViewState.Root)
		{
			this.UiViewSequence.PlaySequence("SwitchA_1", false, null);
			this.ChoosePanel.UiViewSequence.PlaySequence("SwitchA", false, null);
			EventSystem.Instance.Emit(EEventName.CalabashEnterInternalView);
			return;
		}
		if (oldState == ERefineViewState.Attribute)
		{
			this.UiViewSequence.PlaySequence("SwitchB_2", false, null);
			this.ChoosePanel.UiViewSequence.PlaySequence("SwitchA", false, null);
			this.SetCaptionItem(false, null);
		}
	}

	// Token: 0x0600AE68 RID: 44648 RVA: 0x00275210 File Offset: 0x00273410
	private void ShowRootState(ERefineViewState oldState)
	{
		if (oldState == ERefineViewState.Choose)
		{
			this.UiViewSequence.PlaySequence("SwitchA_2", false, null);
			this.ChoosePanel.UiViewSequence.PlaySequence("SwitchB", false, null);
			this.ChoosePanel.UiViewSequence.AddSequenceFinishEvent("SwitchB", new Action<string>(this.OnSequenceHideFinish), false);
			EventSystem.Instance.Emit(EEventName.CalabashQuitInternalView);
			return;
		}
		if (oldState == ERefineViewState.Attribute)
		{
			this.UiViewSequence.PlaySequence("SwitchC_1", false, null);
			EventSystem.Instance.Emit(EEventName.CalabashQuitInternalView);
			this.SetCaptionItem(false, null);
		}
	}

	// Token: 0x0600AE69 RID: 44649 RVA: 0x002752CC File Offset: 0x002734CC
	private void ShowAttributeState(ERefineViewState oldState)
	{
		this.SetCaptionItem(true, new bool?(oldState == ERefineViewState.Root));
		if (oldState == ERefineViewState.Root)
		{
			this.UiViewSequence.PlaySequence("SwitchC_2", false, null);
			EventSystem.Instance.Emit(EEventName.CalabashEnterInternalView);
			return;
		}
		if (oldState == ERefineViewState.Choose)
		{
			this.UiViewSequence.AddSequenceFinishEvent("SwitchB_1", new Action<string>(this.OnSequenceConfirmFinish), false);
			this.UiViewSequence.PlaySequence("SwitchB_1", false, null);
			this.ChoosePanel.UiViewSequence.PlaySequence("SwitchB", false, null);
		}
	}

	// Token: 0x0600AE6A RID: 44650 RVA: 0x00275374 File Offset: 0x00273574
	private void RefreshSlotInteractive()
	{
		bool btnInteractive = true;
		if (this.ExtraParamsExactly != null)
		{
			IVisionRefineTabViewParam extraParamsExactly = this.ExtraParamsExactly;
			if (extraParamsExactly.SlotInteractive != null)
			{
				btnInteractive = extraParamsExactly.SlotInteractive.Value;
			}
		}
		((this.CurrentRefineType == EVisionRefineRefineType.Main) ? this.RefineMainSlotItem : this.RefineSubSlotItem).SetBtnInteractive(btnInteractive);
	}

	// Token: 0x0600AE6B RID: 44651 RVA: 0x002753CD File Offset: 0x002735CD
	private void RefreshSlotPanel()
	{
		this.RefreshSlotPanelMain();
		this.RefreshSlotPanelSub();
		this.RefreshInvalidTip();
		this.RefreshCurrency();
	}

	// Token: 0x0600AE6C RID: 44652 RVA: 0x002753E8 File Offset: 0x002735E8
	private void RefreshCurrency()
	{
		if (this.ExtraParamsExactly != null && this.ExtraParamsExactly.IsSingleMode.GetValueOrDefault())
		{
			List<int> list = this.BuildItemListForCurrency();
			Action<int[]> currencyChangeCallback = this.ExtraParamsExactly.CurrencyChangeCallback;
			if (currencyChangeCallback != null)
			{
				currencyChangeCallback(list.ToArray());
			}
			VisionRefineChoosePanel choosePanel = this.ChoosePanel;
			if (choosePanel == null)
			{
				return;
			}
			choosePanel.RefreshCurrency(null);
			return;
		}
		else
		{
			List<int> list2 = this.BuildItemListForCurrency();
			VisionRefineChoosePanel choosePanel2 = this.ChoosePanel;
			if (choosePanel2 == null)
			{
				return;
			}
			choosePanel2.RefreshCurrency(list2.ToArray());
			return;
		}
	}

	// Token: 0x0600AE6D RID: 44653 RVA: 0x00275464 File Offset: 0x00273664
	private List<int> BuildItemListForCurrency()
	{
		List<int> list = new List<int>();
		EVisionRefineRefineType currentRefineType = this.CurrentRefineType;
		if (currentRefineType != EVisionRefineRefineType.Main)
		{
			if (currentRefineType != EVisionRefineRefineType.Sub)
			{
				return list;
			}
		}
		else
		{
			Dictionary<int, int> visionRefineMaterialDefaultCost = PhantomBattleModel.Instance.GetVisionRefineMaterialDefaultCost();
			if (visionRefineMaterialDefaultCost == null)
			{
				return list;
			}
			using (Dictionary<int, int>.Enumerator enumerator = visionRefineMaterialDefaultCost.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, int> keyValuePair = enumerator.Current;
					list.Add(keyValuePair.Key);
				}
				return list;
			}
		}
		Dictionary<int, int> visionRefineSubMaterialDefaultCost = PhantomBattleModel.Instance.GetVisionRefineSubMaterialDefaultCost();
		if (visionRefineSubMaterialDefaultCost != null)
		{
			foreach (KeyValuePair<int, int> keyValuePair2 in visionRefineSubMaterialDefaultCost)
			{
				list.Add(keyValuePair2.Key);
			}
		}
		return list;
	}

	// Token: 0x0600AE6E RID: 44654 RVA: 0x0027553C File Offset: 0x0027373C
	private void RefreshInvalidTip()
	{
		if (this.CurrentRefineType == EVisionRefineRefineType.Main)
		{
			this.RefreshInvalidTipMain();
			return;
		}
		if (this.CurrentRefineType == EVisionRefineRefineType.Sub)
		{
			this.RefreshInvalidTipSub();
		}
	}

	// Token: 0x0600AE6F RID: 44655 RVA: 0x0027555C File Offset: 0x0027375C
	private void RefreshInvalidTipMain()
	{
		VisionRefineChoosePanel choosePanel = this.ChoosePanel;
		List<ISelectedData> list = (choosePanel != null) ? choosePanel.CurrentSelectedList : null;
		if (list == null || list.Count == 0)
		{
			VisionRefineInvalidTips invalidTips = this.InvalidTips;
			if (invalidTips != null)
			{
				invalidTips.SetUiActive(false);
			}
			UUIButtonComponent button = base.GetButton(2);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(true);
			return;
		}
		else
		{
			int num = 0;
			foreach (ISelectedData selectedData in list)
			{
				PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(selectedData.IncId);
				if (phantomBattleData != null && phantomBattleData.GetVisionIfCanRefine(this.CurrentRefineType))
				{
					num++;
				}
			}
			if (num == 0)
			{
				VisionRefineInvalidTips invalidTips2 = this.InvalidTips;
				if (invalidTips2 != null)
				{
					invalidTips2.SetUiActive(true);
				}
				VisionRefineInvalidTips invalidTips3 = this.InvalidTips;
				if (invalidTips3 != null)
				{
					invalidTips3.RefreshExternalByData(new VisionRefineInvalidTipsData
					{
						LockDescriptionTextId = "Text_VisionRefineMain_InvalidReason_Text"
					});
				}
				UUIButtonComponent button2 = base.GetButton(2);
				if (button2 == null)
				{
					return;
				}
				button2.RootUIComp.Get().SetUIActive(false);
				return;
			}
			else
			{
				VisionRefineInvalidTips invalidTips4 = this.InvalidTips;
				if (invalidTips4 != null)
				{
					invalidTips4.SetUiActive(false);
				}
				UUIButtonComponent button3 = base.GetButton(2);
				if (button3 == null)
				{
					return;
				}
				button3.RootUIComp.Get().SetUIActive(true);
				return;
			}
		}
	}

	// Token: 0x0600AE70 RID: 44656 RVA: 0x002756A8 File Offset: 0x002738A8
	private void RefreshInvalidTipSub()
	{
		if (this.SelectedVision != null)
		{
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(this.SelectedVision.GetUniqueId());
			bool flag = phantomBattleData == null || !phantomBattleData.GetVisionIfCanRefine(this.CurrentRefineType);
			VisionRefineInvalidTips invalidTips = this.InvalidTips;
			if (invalidTips != null)
			{
				invalidTips.SetUiActive(flag);
			}
			UUIButtonComponent button = base.GetButton(2);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(!flag);
			}
			if (flag)
			{
				VisionRefineInvalidTips invalidTips2 = this.InvalidTips;
				if (invalidTips2 == null)
				{
					return;
				}
				invalidTips2.RefreshExternalByData(new VisionRefineInvalidTipsData
				{
					LockDescriptionTextId = "Text_VisionRefineSub_InvalidReason_Text"
				});
			}
			return;
		}
		VisionRefineInvalidTips invalidTips3 = this.InvalidTips;
		if (invalidTips3 != null)
		{
			invalidTips3.SetUiActive(false);
		}
		UUIButtonComponent button2 = base.GetButton(2);
		if (button2 == null)
		{
			return;
		}
		button2.RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x0600AE71 RID: 44657 RVA: 0x00275774 File Offset: 0x00273974
	private void RefreshSlotPanelMain()
	{
		if (this.CurrentRefineType == EVisionRefineRefineType.Main)
		{
			this.RefreshMainViewStates();
			this.RefreshMainSingleAttributePanel();
			this.RefreshMainGrid();
			this.RefreshMainSlotItem();
			this.RefreshMainMaterial();
			return;
		}
		UUIItem item = base.GetItem(21);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(15);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		VisionRefineAttributePanelLite refineMainSingleAttributePanel = this.RefineMainSingleAttributePanel;
		if (refineMainSingleAttributePanel == null)
		{
			return;
		}
		refineMainSingleAttributePanel.SetActive(false);
	}

	// Token: 0x0600AE72 RID: 44658 RVA: 0x002757E4 File Offset: 0x002739E4
	private void RefreshMainViewStates()
	{
		UUIItem item = base.GetItem(21);
		if (item != null)
		{
			item.SetUIActive(this.StateView.GetValueOrDefault() != ERefineViewState.Choose);
		}
		UUIItem item2 = base.GetItem(15);
		if (item2 != null)
		{
			item2.SetUIActive(this.StateView.GetValueOrDefault() == ERefineViewState.Choose);
		}
		VisionRefineAttributePanelLite refineMainMultiAttributePanel = this.RefineMainMultiAttributePanel;
		if (refineMainMultiAttributePanel != null)
		{
			refineMainMultiAttributePanel.SetActive(this.StateView.GetValueOrDefault() == ERefineViewState.Choose);
		}
		if (this.StateView.GetValueOrDefault() == ERefineViewState.Choose)
		{
			VisionRefineAttributePanelLite refineMainMultiAttributePanel2 = this.RefineMainMultiAttributePanel;
			if (refineMainMultiAttributePanel2 == null)
			{
				return;
			}
			refineMainMultiAttributePanel2.RefreshItemSwitch(this.SelectMainAttribute);
		}
	}

	// Token: 0x0600AE73 RID: 44659 RVA: 0x0027587C File Offset: 0x00273A7C
	private void RefreshMainSingleAttributePanel()
	{
		bool flag = this.StateView.GetValueOrDefault() == ERefineViewState.Attribute && this.ExtraParamsExactly != null;
		VisionRefineAttributePanelLite refineMainSingleAttributePanel = this.RefineMainSingleAttributePanel;
		if (refineMainSingleAttributePanel != null)
		{
			refineMainSingleAttributePanel.SetActive(flag);
		}
		VisionRefineAttributePanelLite refineMainSingleAttributePanel2 = this.RefineMainSingleAttributePanel;
		if (refineMainSingleAttributePanel2 != null)
		{
			refineMainSingleAttributePanel2.RefreshInteractive(true);
		}
		if (flag)
		{
			VisionRefineAttributePanelLite refineMainSingleAttributePanel3 = this.RefineMainSingleAttributePanel;
			if (refineMainSingleAttributePanel3 != null)
			{
				refineMainSingleAttributePanel3.RefreshItemSwitch(this.SelectMainAttribute);
			}
			IVisionRefineTabViewParam extraParamsExactly = this.ExtraParamsExactly;
			int? num = (extraParamsExactly != null) ? extraParamsExactly.UniqueId : null;
			if (num != null)
			{
				PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(num.Value);
				if (phantomBattleData == null || !phantomBattleData.GetVisionIfCanRefine(this.CurrentRefineType))
				{
					VisionRefineAttributePanelLite refineMainSingleAttributePanel4 = this.RefineMainSingleAttributePanel;
					if (refineMainSingleAttributePanel4 == null)
					{
						return;
					}
					refineMainSingleAttributePanel4.RefreshInteractive(false);
				}
			}
		}
	}

	// Token: 0x0600AE74 RID: 44660 RVA: 0x0027593C File Offset: 0x00273B3C
	private void RefreshMainGrid()
	{
		GenericLayout<VisionRefineSlotItem, VisionRefineSlotItemData> refineMainGrid = this.RefineMainGrid;
		if (refineMainGrid != null)
		{
			refineMainGrid.SetActive(this.StateView.GetValueOrDefault() == ERefineViewState.Choose);
		}
		if (this.StateView.GetValueOrDefault() == ERefineViewState.Choose)
		{
			GenericLayout<VisionRefineSlotItem, VisionRefineSlotItemData> refineMainGrid2 = this.RefineMainGrid;
			List<VisionRefineSlotItem> list = (refineMainGrid2 != null) ? refineMainGrid2.GetLayoutItemList() : null;
			if (list != null)
			{
				List<int> list2 = this.BuildSelectedUnitIncIdList(this.ChoosePanel.CurrentSelectedList);
				int num = 0;
				foreach (VisionRefineSlotItem visionRefineSlotItem in list)
				{
					if (num < list2.Count)
					{
						int uniqueId = list2[num];
						PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(uniqueId);
						PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(uniqueId);
						visionRefineSlotItem.RefreshByData(phantomItemData, false, phantomDataBase.GetCost());
						visionRefineSlotItem.SetBtnInteractive(true);
					}
					else
					{
						visionRefineSlotItem.SetBtnInteractive(false);
						visionRefineSlotItem.RefreshEmpty();
					}
					num++;
				}
			}
			LguiUtil instance = LguiUtil.Instance;
			UUIText text = base.GetText(18);
			string textStringId = "Text_ItemRecycleChosenTotal_text";
			object[] array = new object[2];
			int num2 = 0;
			VisionRefineChoosePanel choosePanel = this.ChoosePanel;
			array[num2] = ((choosePanel != null) ? choosePanel.GetSelectedUnitCount() : 0);
			array[1] = 10;
			instance.SetLocalTextNew(text, textStringId, new <>z__ReadOnlyArray<object>(array));
		}
	}

	// Token: 0x0600AE75 RID: 44661 RVA: 0x00275A84 File Offset: 0x00273C84
	private void RefreshMainSlotItem()
	{
		this.RefreshSlotInteractive();
		if (this.StateView.GetValueOrDefault() == ERefineViewState.Attribute && this.ExtraParamsExactly != null)
		{
			int? uniqueId = this.ExtraParamsExactly.UniqueId;
			this.RefreshSlotItem(uniqueId, true);
			return;
		}
		this.RefreshSlotItem(null, true);
	}

	// Token: 0x0600AE76 RID: 44662 RVA: 0x00275AD4 File Offset: 0x00273CD4
	private void RefreshMainMaterial()
	{
		UUIItem item = base.GetItem(3);
		ERefineViewState? stateView;
		ERefineViewState erefineViewState;
		if (item != null)
		{
			stateView = this.StateView;
			erefineViewState = ERefineViewState.Root;
			item.SetUIActive(stateView.GetValueOrDefault() == erefineViewState & stateView != null);
		}
		UUIItem item2 = base.GetItem(8);
		if (item2 != null)
		{
			stateView = this.StateView;
			erefineViewState = ERefineViewState.Root;
			item2.SetUIActive(!(stateView.GetValueOrDefault() == erefineViewState & stateView != null));
		}
		Dictionary<int, int> visionRefineMaterialDefaultCost = PhantomBattleModel.Instance.GetVisionRefineMaterialDefaultCost();
		stateView = this.StateView;
		erefineViewState = ERefineViewState.Root;
		if (stateView.GetValueOrDefault() == erefineViewState & stateView != null)
		{
			List<ISelectedData> list = new List<ISelectedData>();
			if (visionRefineMaterialDefaultCost != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair in visionRefineMaterialDefaultCost)
				{
					SelectedData item3 = new SelectedData
					{
						ItemId = keyValuePair.Key,
						IncId = 0,
						Count = 0,
						SelectedCount = 0
					};
					list.Add(item3);
				}
			}
			this.MaterialLayout.RefreshByData(list, null, false);
			return;
		}
		List<ISelectedData> selectedVisionValidList = this.SelectedVisionValidList;
		if (selectedVisionValidList != null)
		{
			List<int> uniqueIdList = this.BuildSelectedUnitIncIdList(selectedVisionValidList);
			Dictionary<int, int> visionListRefineMainMaterialCost = PhantomBattleModel.Instance.GetVisionListRefineMainMaterialCost(uniqueIdList);
			if (visionListRefineMainMaterialCost == null)
			{
				Dictionary<int, int> dictionary = new Dictionary<int, int>();
				if (visionRefineMaterialDefaultCost != null)
				{
					foreach (KeyValuePair<int, int> keyValuePair2 in visionRefineMaterialDefaultCost)
					{
						dictionary[keyValuePair2.Key] = 0;
					}
				}
				this.RefreshCost(dictionary);
				return;
			}
			this.RefreshCost(visionListRefineMainMaterialCost);
		}
	}

	// Token: 0x0600AE77 RID: 44663 RVA: 0x00275C78 File Offset: 0x00273E78
	private void RefreshSlotPanelSub()
	{
		if (this.CurrentRefineType == EVisionRefineRefineType.Sub)
		{
			UUIItem item = base.GetItem(11);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			this.RefreshSlotInteractive();
			this.RefreshMaterialPanel();
			this.RefreshSubAttributePanel();
			this.RefreshSubSlot();
			return;
		}
		UUIItem item2 = base.GetItem(11);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x0600AE78 RID: 44664 RVA: 0x00275CD0 File Offset: 0x00273ED0
	private void RefreshMaterialPanel()
	{
		ERefineViewState? stateView = this.StateView;
		ERefineViewState erefineViewState = ERefineViewState.Root;
		bool flag = (stateView.GetValueOrDefault() == erefineViewState & stateView != null) && this.SelectedVision == null;
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(8);
		if (item2 != null)
		{
			item2.SetUIActive(!flag);
		}
		Dictionary<int, int> dictionary = PhantomBattleModel.Instance.GetVisionRefineSubMaterialDefaultCost();
		if (this.SelectedVision != null)
		{
			dictionary = PhantomBattleModel.Instance.GetVisionRefineSubMaterialCost(this.SelectLockedSubProp.Count);
		}
		if (flag)
		{
			List<ISelectedData> list = new List<ISelectedData>();
			if (dictionary != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair in dictionary)
				{
					SelectedData item3 = new SelectedData
					{
						ItemId = keyValuePair.Key,
						IncId = 0,
						Count = ((this.SelectedVision == null) ? 0 : keyValuePair.Value),
						SelectedCount = 0
					};
					list.Add(item3);
				}
			}
			this.MaterialLayout.RefreshByData(list, null, false);
			return;
		}
		if (dictionary != null)
		{
			this.RefreshCost(dictionary);
			return;
		}
		UUIItem item4 = base.GetItem(8);
		if (item4 == null)
		{
			return;
		}
		item4.SetUIActive(false);
	}

	// Token: 0x0600AE79 RID: 44665 RVA: 0x00275E18 File Offset: 0x00274018
	private void RefreshSubAttributePanel()
	{
		bool flag = this.StateView.GetValueOrDefault() == ERefineViewState.Choose || this.SelectedVision != null;
		UUIItem item = base.GetItem(12);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (this.SelectedVision == null)
		{
			this.SelectLockedSubProp.Clear();
		}
		if (flag)
		{
			GenericLayout<VisionRefineAttributeItem, VisionRefineAttributeItemData> refineSubVertical = this.RefineSubVertical;
			if (refineSubVertical != null)
			{
				refineSubVertical.RefreshByData(this.BuildRefineSubVerticalData(), null, false);
			}
			GenericLayout<VisionRefineMainAttributeItem, VisionRefineAttributeItemData> refineSubUpperVert = this.RefineSubUpperVert;
			if (refineSubUpperVert != null)
			{
				refineSubUpperVert.RefreshByData(this.BuildRefineMainVerticalData(), null, false);
			}
		}
		UUIItem item2 = base.GetItem(24);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(flag && this.StateView.GetValueOrDefault() != ERefineViewState.Attribute);
	}

	// Token: 0x0600AE7A RID: 44666 RVA: 0x00275EC8 File Offset: 0x002740C8
	private void RefreshSubSlot()
	{
		if (this.SelectedVision != null)
		{
			int uniqueId = this.SelectedVision.GetUniqueId();
			this.RefreshSlotItem(new int?(uniqueId), this.StateView.GetValueOrDefault() == ERefineViewState.Attribute);
		}
		else
		{
			this.RefineSubSlotItem.RefreshEmpty();
		}
		this.RefreshCostItemList();
	}

	// Token: 0x0600AE7B RID: 44667 RVA: 0x00275F18 File Offset: 0x00274118
	private void RefreshSlotItem(int? uid, bool isConfirm)
	{
		VisionRefineSlotItem visionRefineSlotItem = (this.CurrentRefineType == EVisionRefineRefineType.Main) ? this.RefineMainSlotItem : this.RefineSubSlotItem;
		if (uid == null)
		{
			visionRefineSlotItem.RefreshEmpty();
			return;
		}
		PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(uid.Value);
		PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(uid.Value);
		visionRefineSlotItem.RefreshByData(phantomItemData, isConfirm, phantomDataBase.GetCost());
	}

	// Token: 0x0600AE7C RID: 44668 RVA: 0x00275F80 File Offset: 0x00274180
	private void RefreshCost(Dictionary<int, int> materialCost)
	{
		if (materialCost.Count == 1)
		{
			using (Dictionary<int, int>.Enumerator enumerator = materialCost.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, int> keyValuePair = enumerator.Current;
					VisionRefineCostItem costItem = this.CostItem;
					if (costItem != null)
					{
						costItem.SetCost(keyValuePair.Key, keyValuePair.Value);
					}
				}
				return;
			}
		}
		Log.Instance.Error(ELogModule.Calabash, ELogAuthor.CB, "检查数据重构的材料消耗配置，目前只展示一个材料消耗", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600AE7D RID: 44669 RVA: 0x00276010 File Offset: 0x00274210
	private void OnSequenceTabStart(string sequenceName)
	{
		if (sequenceName == "Start".ToString() || sequenceName == "ShowView".ToString() || sequenceName == "Sle".ToString())
		{
			UiLayer.Instance.SetShowMaskLayer(EUiTabViewName.VisionRefineTabView, true);
		}
	}

	// Token: 0x0600AE7E RID: 44670 RVA: 0x00276068 File Offset: 0x00274268
	private void OnSequenceTabFinish(string sequenceName)
	{
		if (sequenceName == "Start".ToString() || sequenceName == "ShowView".ToString() || sequenceName == "Sle".ToString())
		{
			UiLayer.Instance.SetShowMaskLayer(EUiTabViewName.VisionRefineTabView, false);
		}
	}

	// Token: 0x0600AE7F RID: 44671 RVA: 0x002760C0 File Offset: 0x002742C0
	private void OnSequenceHideFinish(string _)
	{
		this.ChoosePanel.SetActive(false);
		this.ChoosePanel.UiViewSequence.RemoveSequenceFinishEvent("SwitchB", new Action<string>(this.OnSequenceHideFinish));
	}

	// Token: 0x0600AE80 RID: 44672 RVA: 0x002760EF File Offset: 0x002742EF
	private void OnSequenceConfirmFinish(string _)
	{
		this.ChoosePanel.SetActive(false);
		this.UiViewSequence.RemoveSequenceFinishEvent("SwitchB_1", new Action<string>(this.OnSequenceConfirmFinish));
	}

	// Token: 0x0600AE81 RID: 44673 RVA: 0x00276119 File Offset: 0x00274319
	[NullableContext(2)]
	private void OnChangeSelection(PhantomItemData selectedData)
	{
		this.SelectLockedSubProp.Clear();
		this.RefreshSlotPanel();
	}

	// Token: 0x0600AE82 RID: 44674 RVA: 0x0027612C File Offset: 0x0027432C
	private void OnChangeMultiSelection([Nullable(new byte[]
	{
		2,
		1
	})] List<ISelectedData> selectedDataList)
	{
		this.RefreshSlotPanel();
	}

	// Token: 0x0600AE83 RID: 44675 RVA: 0x00276134 File Offset: 0x00274334
	public bool OnClickCloseRoot()
	{
		if (this.StateView.GetValueOrDefault() == ERefineViewState.Attribute)
		{
			this.SetViewState(ERefineViewState.Choose, false);
			return true;
		}
		return false;
	}

	// Token: 0x0600AE84 RID: 44676 RVA: 0x0027614F File Offset: 0x0027434F
	[NullableContext(2)]
	private void OnClickConfirm(IRefineAttrItemData data)
	{
		this.SelectMainAttribute = data;
		this.RefreshSlotPanel();
		this.RefreshChoosePanel();
	}

	// Token: 0x0600AE85 RID: 44677 RVA: 0x00276164 File Offset: 0x00274364
	private int[] GetSelectedPropItemIdList()
	{
		List<int> list = new List<int>();
		VisionRefineChoosePanel choosePanel = this.ChoosePanel;
		foreach (int uniqueId in this.BuildSelectedUnitIncIdList((choosePanel != null) ? choosePanel.CurrentSelectedList : null))
		{
			PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(uniqueId);
			if (phantomDataBase != null)
			{
				list.Add(phantomDataBase.GetPhantomFirstMainProp().PhantomPropId);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600AE86 RID: 44678 RVA: 0x002761F0 File Offset: 0x002743F0
	private void OnCostTabChangeCallback()
	{
		this.RefineMainMultiAttributePanel.RefreshItemSwitch(null);
		this.RefreshSlotPanel();
	}

	// Token: 0x0600AE87 RID: 44679 RVA: 0x00276204 File Offset: 0x00274404
	private int? OnGetMainPropItemIdCallback()
	{
		IRefineAttrItemData selectMainAttribute = this.SelectMainAttribute;
		if (selectMainAttribute == null)
		{
			return null;
		}
		return new int?(selectMainAttribute.PropItemId);
	}

	// Token: 0x0600AE88 RID: 44680 RVA: 0x0027622F File Offset: 0x0027442F
	private bool OnIsShouldElementItemDownCallback()
	{
		return true;
	}

	// Token: 0x0600AE89 RID: 44681 RVA: 0x00276234 File Offset: 0x00274434
	private void OnClickTip()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.VisionRefineMaterialHint);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600AE8A RID: 44682 RVA: 0x00276258 File Offset: 0x00274458
	private void OnClickRefine()
	{
		VisionRefineChoosePanel choosePanel = this.ChoosePanel;
		if (choosePanel != null)
		{
			choosePanel.ShowTipsComponent(null);
		}
		if (this.CurrentRefineType == EVisionRefineRefineType.Main)
		{
			this.HandleMainRefine();
			return;
		}
		if (this.CurrentRefineType == EVisionRefineRefineType.Sub)
		{
			this.HandleSubRefine();
		}
	}

	// Token: 0x0600AE8B RID: 44683 RVA: 0x0027628C File Offset: 0x0027448C
	private void HandleMainRefine()
	{
		if (this.ExtraParamsExactly != null && this.ExtraParamsExactly.IsSingleMode.GetValueOrDefault())
		{
			if (this.StateView.GetValueOrDefault() != ERefineViewState.Attribute)
			{
				return;
			}
		}
		else if (this.StateView.GetValueOrDefault() != ERefineViewState.Choose)
		{
			this.SetViewState(ERefineViewState.Choose, false);
			return;
		}
		VisionRefineChoosePanel choosePanel = this.ChoosePanel;
		if (((choosePanel != null) ? choosePanel.CurrentSelectedList : null) == null || this.ChoosePanel.CurrentSelectedList.Count == 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("PrefabTextItem_PhantomRefineLackTip_Text", Array.Empty<object>());
			return;
		}
		List<ISelectedData> selectedVisionValidList = this.SelectedVisionValidList;
		if (selectedVisionValidList == null || selectedVisionValidList.Count == 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_VisionRefineMain_BlockedTips_Text", Array.Empty<object>());
			return;
		}
		if (!this.CheckMaterial())
		{
			return;
		}
		if (!this.CheckAttribute())
		{
			return;
		}
		if (this.ExtraParamsExactly != null && this.ExtraParamsExactly.IsSingleMode.GetValueOrDefault())
		{
			int? num = null;
			foreach (ISelectedData selectedData in selectedVisionValidList)
			{
				num = new int?(selectedData.IncId);
			}
			if (num != null)
			{
				CalabashController.Instance.RequestPhantomPolishRequest(num.Value, this.SelectMainAttribute.PropItemId);
				this.SelectMainAttribute = null;
				return;
			}
		}
		else
		{
			CalabashController.Instance.RequestPhantomBatchPolishRequest(selectedVisionValidList.ToArray(), this.SelectMainAttribute.PropItemId).Forget();
		}
	}

	// Token: 0x0600AE8C RID: 44684 RVA: 0x00276410 File Offset: 0x00274610
	private void HandleSubRefine()
	{
		if (this.SelectedVision == null)
		{
			ERefineViewState? stateView = this.StateView;
			ERefineViewState erefineViewState = ERefineViewState.Root;
			if (stateView.GetValueOrDefault() == erefineViewState & stateView != null)
			{
				this.SetViewState(ERefineViewState.Choose, false);
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("PrefabTextItem_PhantomRefineLackTip_Text", Array.Empty<object>());
			return;
		}
		else
		{
			if (!this.CheckMaterial())
			{
				return;
			}
			int? num = null;
			List<string> list = new List<string>();
			int count = this.SelectLockedSubProp.Count;
			Dictionary<int, int> visionRefineSubMaterialCost = PhantomBattleModel.Instance.GetVisionRefineSubMaterialCost(count);
			int num2 = 0;
			if (visionRefineSubMaterialCost != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair in visionRefineSubMaterialCost)
				{
					num2 = keyValuePair.Value;
				}
			}
			if (this.SelectLockedSubProp.Count <= 0)
			{
				num = new int?(447);
				list.Add(num2.ToString());
			}
			else
			{
				num = new int?(450);
				list.Add(count.ToString());
				list.Add(num2.ToString());
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew((EConfirmBoxConfigId)num.Value);
			confirmBoxDataNew.TextArgs = list.ToArray();
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				List<int> list2 = new List<int>();
				foreach (int item in this.SelectLockedSubProp)
				{
					list2.Add(item);
				}
				CalabashController.Instance.RequestPhantomVicePolishRequest(this.SelectedVision.GetUniqueId(), list2.ToArray()).Forget();
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
	}

	// Token: 0x0600AE8D RID: 44685 RVA: 0x00276570 File Offset: 0x00274770
	private void OnClickRefineMainDelete()
	{
		VisionRefineChoosePanel choosePanel = this.ChoosePanel;
		if (choosePanel != null)
		{
			choosePanel.ShowTipsComponent(null);
		}
		VisionRefineChoosePanel choosePanel2 = this.ChoosePanel;
		if (choosePanel2 != null)
		{
			choosePanel2.ClearCurrentCostMultiChoose();
		}
		this.SelectMainAttribute = null;
		this.RefreshSlotPanel();
		this.RefreshChoosePanel();
	}

	// Token: 0x0600AE8E RID: 44686 RVA: 0x002765A8 File Offset: 0x002747A8
	private void OnClickRefineSubSlot(bool isAddVision, int _1)
	{
		if (isAddVision && this.StateView.GetValueOrDefault() == ERefineViewState.Choose)
		{
			return;
		}
		if (!isAddVision)
		{
			this.ChoosePanel.ClearSelection();
		}
		if (this.StateView.GetValueOrDefault() != ERefineViewState.Choose)
		{
			this.SetViewState(ERefineViewState.Choose, false);
		}
	}

	// Token: 0x0600AE8F RID: 44687 RVA: 0x002765E0 File Offset: 0x002747E0
	private void OnClickRefineMainSlot(bool _0, int _1)
	{
		if (this.StateView.GetValueOrDefault() != ERefineViewState.Choose)
		{
			this.SetViewState(ERefineViewState.Choose, false);
		}
	}

	// Token: 0x0600AE90 RID: 44688 RVA: 0x002765F8 File Offset: 0x002747F8
	private void OnClickRefineMainGrid(bool isAddVision, int gridIndex)
	{
		VisionRefineChoosePanel choosePanel = this.ChoosePanel;
		List<int> list = this.BuildSelectedUnitIncIdList((choosePanel != null) ? choosePanel.CurrentSelectedList : null);
		if (gridIndex < 0 || gridIndex >= list.Count)
		{
			return;
		}
		PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(list[gridIndex]);
		if (isAddVision)
		{
			this.ChoosePanel.ShowTipsComponent(phantomItemData);
			return;
		}
		VisionRefineChoosePanel choosePanel2 = this.ChoosePanel;
		if (choosePanel2 != null)
		{
			choosePanel2.ReduceSelectionByIncId(list[gridIndex]);
		}
		VisionRefineChoosePanel choosePanel3 = this.ChoosePanel;
		if (choosePanel3 == null)
		{
			return;
		}
		choosePanel3.ShowTipsComponent(null);
	}

	// Token: 0x0600AE91 RID: 44689 RVA: 0x00276678 File Offset: 0x00274878
	private List<int> BuildSelectedUnitIncIdList([Nullable(new byte[]
	{
		2,
		1
	})] List<ISelectedData> selectedList)
	{
		List<int> list = new List<int>();
		if (selectedList == null)
		{
			return list;
		}
		foreach (ISelectedData selectedData in selectedList)
		{
			int unitCount = PhantomStackUtil.GetUnitCount(selectedData);
			for (int i = 0; i < unitCount; i++)
			{
				list.Add(selectedData.IncId);
			}
		}
		return list;
	}

	// Token: 0x0600AE92 RID: 44690 RVA: 0x002766F0 File Offset: 0x002748F0
	private void OnClickCloseChoosePanel()
	{
		this.SetViewState(ERefineViewState.Root, false);
	}

	// Token: 0x0600AE93 RID: 44691 RVA: 0x002766FC File Offset: 0x002748FC
	private void OnClickAttributeSelect()
	{
		if (this.ChoosePanel == null)
		{
			return;
		}
		VisionRefineChoosePanel choosePanel = this.ChoosePanel;
		if (choosePanel != null)
		{
			choosePanel.ShowTipsComponent(null);
		}
		EVisionRefineCostType? currentCostType = this.ChoosePanel.CurrentCostType;
		if (currentCostType == null)
		{
			return;
		}
		int num = 0;
		switch (currentCostType.Value)
		{
		case EVisionRefineCostType.Cost4:
			num = 4;
			break;
		case EVisionRefineCostType.Cost3:
			num = 3;
			break;
		case EVisionRefineCostType.Cost1:
			num = 1;
			break;
		}
		int? num2 = null;
		bool dataConfirmed = false;
		if (this.ExtraParamsExactly == null || !this.ExtraParamsExactly.IsSingleMode.GetValueOrDefault())
		{
			PhantomItemData phantomItemData = null;
			foreach (PhantomItemData phantomItemData2 in InventoryModel.Instance.GetPhantomItemDataList())
			{
				if (phantomItemData2.GetConfig().As<Aki.Config.PhantomItem>().Value.QualityId >= 5)
				{
					int rarity = phantomItemData2.GetConfig().As<Aki.Config.PhantomItem>().Value.Rarity;
					if (PhantomBattleConfig.Instance.GetPhantomRareConfig(rarity).Value.Cost == num)
					{
						phantomItemData = phantomItemData2;
						break;
					}
				}
			}
			if (phantomItemData != null)
			{
				num2 = new int?(phantomItemData.GetUniqueId());
			}
		}
		else
		{
			num2 = this.ExtraParamsExactly.UniqueId;
			dataConfirmed = true;
		}
		if (num2 == null)
		{
			return;
		}
		Action<IRefineAttrItemData> callback = new Action<IRefineAttrItemData>(this.OnClickConfirm);
		Func<int[]> getSelectedPropItemIdList = new Func<int[]>(this.GetSelectedPropItemIdList);
		IRefineAttrItemData selectMainAttribute = this.SelectMainAttribute;
		RefineAttrSelectViewOpenParam param = new RefineAttrSelectViewOpenParam
		{
			GetSelectedPropItemIdList = getSelectedPropItemIdList,
			Callback = callback,
			DataConfirmed = dataConfirmed,
			IncId = num2.Value,
			SelectAttribute = selectMainAttribute
		};
		UiManager.Instance.OpenView(EUiViewName.VisionRefineAttributeSelectView, param, null);
	}

	// Token: 0x0600AE94 RID: 44692 RVA: 0x002768D4 File Offset: 0x00274AD4
	private bool OnClickSubAttributeSelected(int index)
	{
		VisionRefineChoosePanel choosePanel = this.ChoosePanel;
		if (choosePanel != null)
		{
			choosePanel.ShowTipsComponent(null);
		}
		if (this.SelectLockedSubProp.Count == 4)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_VisionRefineSubLockAll_Text", Array.Empty<object>());
			return false;
		}
		this.SelectLockedSubProp.Add(index);
		Dictionary<int, int> visionRefineSubMaterialCost = PhantomBattleModel.Instance.GetVisionRefineSubMaterialCost(this.SelectLockedSubProp.Count);
		if (visionRefineSubMaterialCost != null)
		{
			this.RefreshCost(visionRefineSubMaterialCost);
		}
		return true;
	}

	// Token: 0x0600AE95 RID: 44693 RVA: 0x00276948 File Offset: 0x00274B48
	private bool OnClickSubAttributeDeselected(int index)
	{
		VisionRefineChoosePanel choosePanel = this.ChoosePanel;
		if (choosePanel != null)
		{
			choosePanel.ShowTipsComponent(null);
		}
		if (this.SelectLockedSubProp.Count == 0)
		{
			return false;
		}
		this.SelectLockedSubProp.Remove(index);
		Dictionary<int, int> visionRefineSubMaterialCost = PhantomBattleModel.Instance.GetVisionRefineSubMaterialCost(this.SelectLockedSubProp.Count);
		if (visionRefineSubMaterialCost != null)
		{
			this.RefreshCost(visionRefineSubMaterialCost);
		}
		return true;
	}

	// Token: 0x0600AE96 RID: 44694 RVA: 0x002769A4 File Offset: 0x00274BA4
	private void OnClickCancel()
	{
		if (this.StateView.GetValueOrDefault() != ERefineViewState.Choose)
		{
			this.SetViewState(ERefineViewState.Choose, false);
		}
	}

	// Token: 0x0600AE97 RID: 44695 RVA: 0x002769BC File Offset: 0x00274BBC
	private void OnItemFuncValueChange(int uniqueId)
	{
		VisionRefineChoosePanel choosePanel = this.ChoosePanel;
		if (choosePanel != null)
		{
			choosePanel.OnItemFuncValueChange(uniqueId);
		}
		this.RefreshSlotPanel();
	}

	// Token: 0x0600AE98 RID: 44696 RVA: 0x002769D8 File Offset: 0x00274BD8
	private void OnResponseVisionRefine(PhantomPolishResponse response)
	{
		VisionRefineResultViewParam visionRefineResultViewParam = new VisionRefineResultViewParam();
		visionRefineResultViewParam.Response = response;
		visionRefineResultViewParam.ResponseBatch = null;
		visionRefineResultViewParam.ShowTips = true;
		IRefineAttrItemData selectMainAttribute = this.SelectMainAttribute;
		visionRefineResultViewParam.PropIndexId = ((selectMainAttribute != null) ? new int?(selectMainAttribute.PropIndexId) : null);
		VisionRefineResultViewParam visionRefineResultViewParam2 = visionRefineResultViewParam;
		if (this.ExtraParamsExactly != null)
		{
			IVisionRefineTabViewParam extraParamsExactly = this.ExtraParamsExactly;
			if (extraParamsExactly.ResultShowTips != null)
			{
				visionRefineResultViewParam2.ShowTips = extraParamsExactly.ResultShowTips.Value;
			}
		}
		UiManager.Instance.OpenView(EUiViewName.VisionRefineResultView, visionRefineResultViewParam2, delegate(bool result, int id)
		{
			if (!result)
			{
				return;
			}
			(UiManager.Instance.GetView(id) as VisionRefineResultView).OnCloseCallback = new Action<bool>(this.OnCloseResultView);
			if (!((this.ExtraParamsExactly != null) ? this.ExtraParamsExactly.IsSingleMode : new bool?(false)).GetValueOrDefault())
			{
				VisionRefineChoosePanel choosePanel = this.ChoosePanel;
				if (choosePanel != null)
				{
					choosePanel.ClearSelection();
				}
				this.SetViewState(ERefineViewState.Root, false);
				UUIItem item = base.GetItem(3);
				if (item != null)
				{
					item.SetAlpha(1f);
				}
			}
			this.SelectMainAttribute = null;
		});
	}

	// Token: 0x0600AE99 RID: 44697 RVA: 0x00276A74 File Offset: 0x00274C74
	private void OnCloseResultView(bool result)
	{
		if (!result)
		{
			return;
		}
		if (!((this.ExtraParamsExactly != null) ? this.ExtraParamsExactly.IsSingleMode : new bool?(false)).GetValueOrDefault())
		{
			this.SetViewState(ERefineViewState.Choose, false);
		}
	}

	// Token: 0x0600AE9A RID: 44698 RVA: 0x00276AB4 File Offset: 0x00274CB4
	private void OnVisionRefineBatchMainResult(PhantomBatchPolishResponse response)
	{
		VisionRefineResultViewParam visionRefineResultViewParam = new VisionRefineResultViewParam();
		visionRefineResultViewParam.Response = null;
		visionRefineResultViewParam.ResponseBatch = response;
		visionRefineResultViewParam.ShowTips = false;
		IRefineAttrItemData selectMainAttribute = this.SelectMainAttribute;
		visionRefineResultViewParam.PropIndexId = ((selectMainAttribute != null) ? new int?(selectMainAttribute.PropIndexId) : null);
		VisionRefineResultViewParam param = visionRefineResultViewParam;
		UiManager.Instance.OpenView(EUiViewName.VisionRefineResultView, param, delegate(bool result, int id)
		{
			if (!result)
			{
				return;
			}
			this.SelectMainAttribute = null;
			VisionRefineChoosePanel choosePanel = this.ChoosePanel;
			if (choosePanel == null)
			{
				return;
			}
			choosePanel.ClearCurrentCostMultiChoose();
		});
	}

	// Token: 0x0600AE9B RID: 44699 RVA: 0x00276B20 File Offset: 0x00274D20
	private void OnVisionRefineSubPreviewResult(PhantomVicePolishResponse response)
	{
		VisionRefineTabView.<>c__DisplayClass107_0 CS$<>8__locals1 = new VisionRefineTabView.<>c__DisplayClass107_0();
		CS$<>8__locals1.selectedUid = this.SelectedVision.GetUniqueId();
		VisionRefineBatchResultViewData visionRefineBatchResultViewData = new VisionRefineBatchResultViewData();
		visionRefineBatchResultViewData.LeftAttrList = this.BuildRefineSubVerticalLeftData();
		visionRefineBatchResultViewData.RightAttrList = this.BuildRefineSubVerticalRightData(response);
		visionRefineBatchResultViewData.OnClickCancel = delegate()
		{
			VisionRefineTabView.<>c__DisplayClass107_0.<<OnVisionRefineSubPreviewResult>b__0>d <<OnVisionRefineSubPreviewResult>b__0>d;
			<<OnVisionRefineSubPreviewResult>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnVisionRefineSubPreviewResult>b__0>d.<>4__this = CS$<>8__locals1;
			<<OnVisionRefineSubPreviewResult>b__0>d.<>1__state = -1;
			<<OnVisionRefineSubPreviewResult>b__0>d.<>t__builder.Start<VisionRefineTabView.<>c__DisplayClass107_0.<<OnVisionRefineSubPreviewResult>b__0>d>(ref <<OnVisionRefineSubPreviewResult>b__0>d);
			return <<OnVisionRefineSubPreviewResult>b__0>d.<>t__builder.Task;
		};
		visionRefineBatchResultViewData.OnClickConfirm = delegate()
		{
			VisionRefineTabView.<>c__DisplayClass107_0.<<OnVisionRefineSubPreviewResult>b__1>d <<OnVisionRefineSubPreviewResult>b__1>d;
			<<OnVisionRefineSubPreviewResult>b__1>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnVisionRefineSubPreviewResult>b__1>d.<>4__this = CS$<>8__locals1;
			<<OnVisionRefineSubPreviewResult>b__1>d.<>1__state = -1;
			<<OnVisionRefineSubPreviewResult>b__1>d.<>t__builder.Start<VisionRefineTabView.<>c__DisplayClass107_0.<<OnVisionRefineSubPreviewResult>b__1>d>(ref <<OnVisionRefineSubPreviewResult>b__1>d);
			return <<OnVisionRefineSubPreviewResult>b__1>d.<>t__builder.Task;
		};
		visionRefineBatchResultViewData.UniqueId = new int?(CS$<>8__locals1.selectedUid);
		VisionRefineBatchResultViewData visionRefineBatchResultViewData2 = visionRefineBatchResultViewData;
		IVisionRefineTabViewParam extraParamsExactly = this.ExtraParamsExactly;
		int? num;
		if (extraParamsExactly == null)
		{
			num = null;
		}
		else
		{
			List<AttrRecommendInfo> recommendRefineSubList = extraParamsExactly.RecommendRefineSubList;
			num = ((recommendRefineSubList != null) ? new int?(recommendRefineSubList.Count) : null);
		}
		int? num2 = num;
		visionRefineBatchResultViewData2.HasRecommendData = (num2.GetValueOrDefault() > 0);
		UiManager.Instance.OpenView(EUiViewName.VisionRefineSubResultView, visionRefineBatchResultViewData, null);
	}

	// Token: 0x0600AE9C RID: 44700 RVA: 0x00276BED File Offset: 0x00274DED
	private void OnVisionRefineSubResult(PhantomVicePolishAckResponse response, bool ack)
	{
		if (ack)
		{
			this.SelectLockedSubProp.Clear();
		}
	}

	// Token: 0x0600AE9D RID: 44701 RVA: 0x00276C00 File Offset: 0x00274E00
	private bool CheckMaterial()
	{
		if (this.CurrentRefineType == EVisionRefineRefineType.Main)
		{
			List<ISelectedData> selectedVisionValidList = this.SelectedVisionValidList;
			if (selectedVisionValidList == null)
			{
				return false;
			}
			List<int> uniqueIdList = this.BuildSelectedUnitIncIdList(selectedVisionValidList);
			if (!PhantomBattleModel.Instance.IsVisionListRefineMainMaterialEnough(uniqueIdList))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PrefabTextItem_PhantomRefineMaterialLackTip_Text", Array.Empty<object>());
				return false;
			}
			return true;
		}
		else
		{
			if (this.CurrentRefineType != EVisionRefineRefineType.Sub)
			{
				return false;
			}
			int count = this.SelectLockedSubProp.Count;
			if (count >= 5)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Text_VisionRefineSubLockAll_Text", Array.Empty<object>());
				return false;
			}
			if (!PhantomBattleModel.Instance.IsVisionRefineSubMaterialEnough(count))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PrefabTextItem_PhantomRefineMaterialLackTip_Text", Array.Empty<object>());
				return false;
			}
			return true;
		}
	}

	// Token: 0x0600AE9E RID: 44702 RVA: 0x00276CA3 File Offset: 0x00274EA3
	private bool CheckAttribute()
	{
		if (this.SelectMainAttribute == null)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("PrefabTextItem_PhantomRefineAttributeLackTip_Text", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x0600AE9F RID: 44703 RVA: 0x00276CC4 File Offset: 0x00274EC4
	private void SetCaptionItem(bool active, bool? activeSequence = null)
	{
		if (base.GetItem(7).bIsUIActive == active)
		{
			return;
		}
		if (this.ExtraParamsExactly != null)
		{
			IVisionRefineTabViewParam extraParamsExactly = this.ExtraParamsExactly;
			if (extraParamsExactly.ActiveCaptionItem != null)
			{
				base.GetItem(7).SetUIActive(extraParamsExactly.ActiveCaptionItem.Value);
				return;
			}
		}
		if (this.CaptionItem == null)
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(7));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickCancel));
		}
		this.CaptionItem.SetUiActive(active);
		if (active && activeSequence.GetValueOrDefault())
		{
			this.UiViewSequence.PlaySequence("CaptionIn", false, null);
		}
	}

	// Token: 0x0600AEA0 RID: 44704 RVA: 0x00276D80 File Offset: 0x00274F80
	private List<VisionRefineRefineTabData> BuildUpLeftTabData()
	{
		List<VisionRefineRefineTabData> list = new List<VisionRefineRefineTabData>();
		if (CalabashDefine.visionRefineRefineMap != null)
		{
			using (Dictionary<EVisionRefineRefineType, string>.Enumerator enumerator = CalabashDefine.visionRefineRefineMap.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<EVisionRefineRefineType, string> kvp = enumerator.Current;
					list.Add(new VisionRefineRefineTabData
					{
						IsChosen = (kvp.Key == this.CurrentRefineType),
						RefineType = kvp.Key,
						TabTextId = kvp.Value,
						CanChangeExecute = ((EVisionRefineRefineType type) => type != this.CurrentRefineType),
						OnClick = delegate()
						{
							this.OnClickRefreshRefineTab(kvp.Key);
							this.CurrentRefineType = kvp.Key;
							this.ChoosePanel.CurrentRefineType = kvp.Key;
							this.RefreshSlotPanel();
							this.RefreshChoosePanel();
						}
					});
				}
			}
		}
		return list;
	}

	// Token: 0x0600AEA1 RID: 44705 RVA: 0x00276E60 File Offset: 0x00275060
	private void RefreshCostItemList()
	{
		CalabashRootView calabashRootView = UiManager.Instance.GetViewByName(EUiViewName.CalabashRootView) as CalabashRootView;
		if (calabashRootView != null)
		{
			bool flag = this.CurrentRefineType == EVisionRefineRefineType.Sub && this.SelectedVision != null;
			calabashRootView.ShowCostItemCaption(flag ? this.BuildItemListForCurrency().ToArray() : Array.Empty<int>());
		}
	}

	// Token: 0x0600AEA2 RID: 44706 RVA: 0x00276EB8 File Offset: 0x002750B8
	private void OnClickRefreshRefineTab(EVisionRefineRefineType current)
	{
		if (this.UpLeftTab == null)
		{
			return;
		}
		foreach (VisionRefineRefineTab visionRefineRefineTab in this.UpLeftTab.GetLayoutItemList())
		{
			if (visionRefineRefineTab.CheckChosen(current))
			{
				visionRefineRefineTab.OnSelected(false);
			}
			else
			{
				visionRefineRefineTab.OnDeselected(false);
			}
		}
	}

	// Token: 0x0600AEA3 RID: 44707 RVA: 0x00276F2C File Offset: 0x0027512C
	private List<VisionRefineAttributeItemData> BuildRefineSubVerticalData()
	{
		List<VisionRefineAttributeItemData> list = new List<VisionRefineAttributeItemData>();
		if (this.SelectedVision == null)
		{
			VisionRefineAttributeItemData visionRefineAttributeItemData = new VisionRefineAttributeItemData();
			for (int i = 0; i < 5; i++)
			{
				visionRefineAttributeItemData.NameTextId = "ErrorCode_200347_Text";
				visionRefineAttributeItemData.CanInteractive = false;
				visionRefineAttributeItemData.ForceCheckboxActive = new bool?(false);
				list.Add(visionRefineAttributeItemData);
			}
			return list;
		}
		int uniqueId = this.SelectedVision.GetUniqueId();
		PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(uniqueId);
		List<VisionSubPropData> list2 = (phantomDataBase != null) ? phantomDataBase.GetEquipmentViewPreviewData() : null;
		for (int j = 0; j < 5; j++)
		{
			VisionRefineAttributeItemData visionRefineAttributeItemData2 = new VisionRefineAttributeItemData();
			if (list2 != null && j < list2.Count && list2[j] != null && list2[j].PhantomSubProp != null)
			{
				visionRefineAttributeItemData2.NameTextId = list2[j].GetSubPropName();
				visionRefineAttributeItemData2.NumberText = list2[j].GetAttributeValueString();
				visionRefineAttributeItemData2.IsChosen = this.SelectLockedSubProp.Contains(j);
				int phantomPropId = list2[j].PhantomSubProp.PhantomPropId;
				PhantomSubProperty subConfig = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(phantomPropId);
				VisionRefineAttributeItemData visionRefineAttributeItemData3 = visionRefineAttributeItemData2;
				IVisionRefineTabViewParam extraParamsExactly = this.ExtraParamsExactly;
				visionRefineAttributeItemData3.IsRecommend = (((extraParamsExactly != null) ? extraParamsExactly.RecommendRefineSubList : null) != null && this.ExtraParamsExactly.RecommendRefineSubList.Find((AttrRecommendInfo value) => value.GetAttrId() == subConfig.PropId && value.GetAddType() == subConfig.AddType) != null);
				visionRefineAttributeItemData2.CanInteractive = (list2.Count == 5);
				visionRefineAttributeItemData2.ForceCheckboxActive = new bool?(true);
			}
			else
			{
				visionRefineAttributeItemData2.NameTextId = "Text_VisionRefineSubAttriLocked_Text";
				visionRefineAttributeItemData2.CanInteractive = false;
				visionRefineAttributeItemData2.ForceCheckboxActive = new bool?(false);
			}
			list.Add(visionRefineAttributeItemData2);
		}
		return list;
	}

	// Token: 0x0600AEA4 RID: 44708 RVA: 0x002770E8 File Offset: 0x002752E8
	private VisionRefineAttributeItemData[] BuildRefineSubVerticalLeftData()
	{
		CalabashController instance = CalabashController.Instance;
		PhantomItemData selectedVision = this.SelectedVision;
		int? uid = (selectedVision != null) ? new int?(selectedVision.GetUniqueId()) : null;
		HashSet<int> selectLockedSubProp = this.SelectLockedSubProp;
		IVisionRefineTabViewParam extraParamsExactly = this.ExtraParamsExactly;
		return instance.BuildRefineSubVerticalLeftDataByUid(uid, selectLockedSubProp, (extraParamsExactly != null) ? extraParamsExactly.RecommendRefineSubList : null);
	}

	// Token: 0x0600AEA5 RID: 44709 RVA: 0x00277138 File Offset: 0x00275338
	private VisionRefineAttributeItemData[] BuildRefineSubVerticalRightData(PhantomVicePolishResponse response)
	{
		List<Aki.Protocol.PhantomPropInfo> list = new List<Aki.Protocol.PhantomPropInfo>(response.PhantomSubProp);
		CalabashController instance = CalabashController.Instance;
		PhantomItemData selectedVision = this.SelectedVision;
		int? uid = (selectedVision != null) ? new int?(selectedVision.GetUniqueId()) : null;
		List<Aki.Protocol.PhantomPropInfo> unAckInfo = list;
		HashSet<int> selectLockedSubProp = this.SelectLockedSubProp;
		IVisionRefineTabViewParam extraParamsExactly = this.ExtraParamsExactly;
		return instance.BuildRefineSubVerticalRightDataByUid(uid, unAckInfo, selectLockedSubProp, (extraParamsExactly != null) ? extraParamsExactly.RecommendRefineSubList : null);
	}

	// Token: 0x0600AEA6 RID: 44710 RVA: 0x00277194 File Offset: 0x00275394
	private List<VisionRefineSlotItemData> BuildRefineMainGridData()
	{
		List<VisionRefineSlotItemData> list = new List<VisionRefineSlotItemData>();
		for (int i = 0; i < 10; i++)
		{
			list.Add(new VisionRefineSlotItemData());
		}
		return list;
	}

	// Token: 0x0600AEA7 RID: 44711 RVA: 0x002771C0 File Offset: 0x002753C0
	private List<VisionRefineAttributeItemData> BuildRefineMainVerticalData()
	{
		List<VisionRefineAttributeItemData> list = new List<VisionRefineAttributeItemData>();
		if (this.SelectedVision == null)
		{
			return list;
		}
		int uniqueId = this.SelectedVision.GetUniqueId();
		PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(uniqueId);
		List<AttrListScrollData> list2 = (phantomDataBase != null) ? phantomDataBase.GetMainPropShowAttributeList(CommonComponentDefine.EAttributeType.PhantomType, false) : null;
		if (list2 == null || list2.Count <= 0)
		{
			return list;
		}
		foreach (AttrListScrollData attrListScrollData in list2)
		{
			VisionRefineAttributeItemData visionRefineAttributeItemData = new VisionRefineAttributeItemData();
			PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(attrListScrollData.Id);
			if (propertyIndexInfo != null)
			{
				visionRefineAttributeItemData.NameTextId = propertyIndexInfo.Value.Name;
				visionRefineAttributeItemData.IconPath = propertyIndexInfo.Value.Icon;
				visionRefineAttributeItemData.NumberText = AttributeModel.Instance.GetFormatAttributeValueString(attrListScrollData.Id, attrListScrollData.BaseValue, attrListScrollData.IsRatio);
				list.Add(visionRefineAttributeItemData);
			}
		}
		return list;
	}

	// Token: 0x0600AEA8 RID: 44712 RVA: 0x002772D4 File Offset: 0x002754D4
	private void ClearSelectMainAttribute()
	{
		this.SelectMainAttributeInternalSingle = null;
		this.SelectMainAttributeInternalMulti.Clear();
	}

	// Token: 0x0600AEA9 RID: 44713 RVA: 0x002772E8 File Offset: 0x002754E8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (!(configParams[0] == "Filter"))
		{
			return null;
		}
		VisionRefineChoosePanel choosePanel = this.ChoosePanel;
		UUIItem uuiitem = (choosePanel != null) ? choosePanel.GetFilterToggleItem() : null;
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x04004F39 RID: 20281
	[Nullable(2)]
	private VisionRefineSlotItem RefineMainSlotItem;

	// Token: 0x04004F3A RID: 20282
	[Nullable(2)]
	private VisionRefineSlotItem RefineSubSlotItem;

	// Token: 0x04004F3B RID: 20283
	[Nullable(2)]
	private VisionRefineChoosePanel ChoosePanel;

	// Token: 0x04004F3C RID: 20284
	[Nullable(2)]
	private VisionRefineAttributePanelLite RefineMainSingleAttributePanel;

	// Token: 0x04004F3D RID: 20285
	[Nullable(2)]
	private VisionRefineAttributePanelLite RefineMainMultiAttributePanel;

	// Token: 0x04004F3E RID: 20286
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04004F3F RID: 20287
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRefineMaterialItem, ISelectedData> MaterialLayout;

	// Token: 0x04004F40 RID: 20288
	private ERefineViewState? StateView;

	// Token: 0x04004F41 RID: 20289
	[Nullable(2)]
	private IRefineAttrItemData SelectMainAttributeInternalSingle;

	// Token: 0x04004F42 RID: 20290
	private readonly Dictionary<EVisionRefineCostType, IRefineAttrItemData> SelectMainAttributeInternalMulti = new Dictionary<EVisionRefineCostType, IRefineAttrItemData>();

	// Token: 0x04004F43 RID: 20291
	private readonly HashSet<int> SelectLockedSubProp = new HashSet<int>();

	// Token: 0x04004F44 RID: 20292
	private bool HasInitChoosePanel;

	// Token: 0x04004F45 RID: 20293
	[Nullable(2)]
	private VisionRefineCostItem CostItem;

	// Token: 0x04004F46 RID: 20294
	private EVisionRefineRefineType CurrentRefineType;

	// Token: 0x04004F47 RID: 20295
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRefineRefineTab, VisionRefineRefineTabData> UpLeftTab;

	// Token: 0x04004F48 RID: 20296
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRefineAttributeItem, VisionRefineAttributeItemData> RefineSubVertical;

	// Token: 0x04004F49 RID: 20297
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRefineSlotItem, VisionRefineSlotItemData> RefineMainGrid;

	// Token: 0x04004F4A RID: 20298
	[Nullable(2)]
	private VisionRefineInvalidTips InvalidTips;

	// Token: 0x04004F4B RID: 20299
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRefineMainAttributeItem, VisionRefineAttributeItemData> RefineSubUpperVert;

	// Token: 0x02007D70 RID: 32112
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029140 RID: 168256
		RootChoosePanel,
		// Token: 0x04029141 RID: 168257
		ItemRefineSlot,
		// Token: 0x04029142 RID: 168258
		BtnRefine,
		// Token: 0x04029143 RID: 168259
		PanelMaterial,
		// Token: 0x04029144 RID: 168260
		PanelRefineMainMultiAttribute,
		// Token: 0x04029145 RID: 168261
		BtnTip,
		// Token: 0x04029146 RID: 168262
		LayoutMaterial,
		// Token: 0x04029147 RID: 168263
		ItemCaption,
		// Token: 0x04029148 RID: 168264
		CostItem,
		// Token: 0x04029149 RID: 168265
		UpLeftTabRoot,
		// Token: 0x0402914A RID: 168266
		UpLeftTabItem,
		// Token: 0x0402914B RID: 168267
		RefineSubRoot,
		// Token: 0x0402914C RID: 168268
		RefineSubInfo,
		// Token: 0x0402914D RID: 168269
		RefineSubVertical,
		// Token: 0x0402914E RID: 168270
		RefineSubVerticalToggle,
		// Token: 0x0402914F RID: 168271
		RefineMainRoot2,
		// Token: 0x04029150 RID: 168272
		RefineMainGrid,
		// Token: 0x04029151 RID: 168273
		RefineMainGridItem,
		// Token: 0x04029152 RID: 168274
		RefineMainInfo,
		// Token: 0x04029153 RID: 168275
		RefineMainDeleteButton,
		// Token: 0x04029154 RID: 168276
		RefineInvalidTipsItem,
		// Token: 0x04029155 RID: 168277
		RefineMainRoot1,
		// Token: 0x04029156 RID: 168278
		RefineMainSlot,
		// Token: 0x04029157 RID: 168279
		PanelRefineMainSingleAttribute,
		// Token: 0x04029158 RID: 168280
		RefineSubUpperVert
	}
}
