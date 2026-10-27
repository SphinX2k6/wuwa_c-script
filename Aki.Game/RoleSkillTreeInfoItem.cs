using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Manufacture.Compose;
using CSharpScript.Game.Module.Manufacture.Compose.QuicklyPopup;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.RoleUi.RoleBreach;
using CSharpScript.Game.Module.RoleUi.RoleSkill;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020028C2 RID: 10434
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillTreeInfoItem : UiPanelBase
{
	// Token: 0x0601583C RID: 88124 RVA: 0x0056D0A8 File Offset: 0x0056B2A8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 48;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(34, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(35, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(36, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(37, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(38, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(39, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(40, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(41, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(42, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(43, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(44, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(45, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(46, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(47, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 9;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnIntroductionToggleClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnAttrDetailToggleClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(19, new Action<EToggleState>(this.OnRightPanelToggleClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(24, new Action(this.OnBtnCloseClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(25, new Action(this.OnNextLevelMaskBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(26, new Action(this.OnLockTipBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(29, new Action(this.OnRoleSkillMaskBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(30, new Action<EToggleState>(this.SkillModeToggleClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(37, new Action(this.ClickBranchDetailBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601583D RID: 88125 RVA: 0x0056D884 File Offset: 0x0056BA84
	protected override UniTask OnBeforeStartAsync()
	{
		RoleSkillTreeInfoItem.<OnBeforeStartAsync>d__40 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkillTreeInfoItem.<OnBeforeStartAsync>d__40>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601583E RID: 88126 RVA: 0x0056D8C8 File Offset: 0x0056BAC8
	protected override void OnStart()
	{
		this.ConsumeItemScroll = new GenericScrollViewNew<CostMediumItemGrid, ISelectedData>(base.GetScrollViewWithScrollbar(11), new Func<CostMediumItemGrid>(this.InitCostItem), null, false, null);
		this.CurrentLevelAttrScrollView = new GenericScrollView<RoleSkillTreeAttributeItem>(base.GetScrollViewWithScrollbar(8), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<RoleSkillTreeAttributeItem>(this.InitAttrItem), null);
		this.CaptionItem = new PopupCaptionItem(base.GetItem(21));
		this.CaptionItem.SetCurrencyItemList(new int[]
		{
			2
		});
		this.CaptionItem.SetCurrencyItemVisible(true);
		this.ConfirmButtonItem = new ButtonItem(base.GetItem(14));
		this.ConfirmButtonItem.SetFunction(new Action<int>(this.OnLevelUpClick));
		base.GetItem(20).SetUIActive(false);
		base.SetItemIcon(base.GetTexture(12), 2, null, null);
		this.RefreshSkillModeToggle();
		RoleSkillTreeInfoViewData roleSkillTreeInfoViewData = this.OpenParam as RoleSkillTreeInfoViewData;
		if (roleSkillTreeInfoViewData != null)
		{
			this.RoleSkillTreeInfoItemData = new RoleSkillTreeInfoItemData
			{
				RoleId = roleSkillTreeInfoViewData.RoleId,
				SkillNodeId = roleSkillTreeInfoViewData.SkillNodeId
			};
		}
		this.CurSkillTabShowType = ESkillTabShowType.Introduction;
		TermExplanationController.Instance.RegisterTextHyperlink(base.GetText(10), ETermExplanationViewType.Side, ETermExplanationReportType.RoleSkill, ETermExplanationViewAttachDirection.Right, null, null, null, ETermExplanationGroup.Default, 0, ETermExplanationViewStyle.Default);
		UUIItem item = base.GetItem(42);
		if (item == null)
		{
			return;
		}
		this.NumberSelectComponent = new NumberSelectComponent(item);
		this.NumberSelectComponent.EnableUseCustomMinValue(true);
		this.NumberSelectComponent.SetMaxBtnShowState(false);
		UUIItem item2 = base.GetItem(40);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x0601583F RID: 88127 RVA: 0x0056DA43 File Offset: 0x0056BC43
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(10));
	}

	// Token: 0x06015840 RID: 88128 RVA: 0x0056DA58 File Offset: 0x0056BC58
	private void RefreshSkillModeToggle()
	{
		this.SkillDescType = RoleModel.Instance.GetRoleSkillDescType();
		if (this.SkillDescType == ERoleSkillDescType.MultiDesc)
		{
			EToggleState state = RoleModel.Instance.IsShowMultiSkillDesc ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(30).SetToggleState(state, false, false, false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(33), "MultiplayerSkillDescription_text", Array.Empty<object>());
			return;
		}
		EToggleState state2 = RoleModel.Instance.IsShowSkillResume ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(30).SetToggleState(state2, false, false, false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(33), "SkillBriefDescription_text", Array.Empty<object>());
	}

	// Token: 0x06015841 RID: 88129 RVA: 0x0056DAFD File Offset: 0x0056BCFD
	public void OnCommonItemCountAnyChange()
	{
		if (this.IsLevelUpPending)
		{
			return;
		}
		this.Refresh();
	}

	// Token: 0x06015842 RID: 88130 RVA: 0x0056DB0E File Offset: 0x0056BD0E
	public void OnSkillTreeNodeLevelUp()
	{
		this.IsLevelUpPending = false;
		this.Refresh();
	}

	// Token: 0x06015843 RID: 88131 RVA: 0x0056DB1D File Offset: 0x0056BD1D
	private void OnBtnCloseClick()
	{
		Action onBackBtnCallBack = this.OnBackBtnCallBack;
		if (onBackBtnCallBack == null)
		{
			return;
		}
		onBackBtnCallBack();
	}

	// Token: 0x06015844 RID: 88132 RVA: 0x0056DB30 File Offset: 0x0056BD30
	private void OnRightPanelToggleClick(EToggleState toggleState)
	{
		this.IsShowRightPanel = (toggleState == EToggleState.ETT_Checked);
		EventSystem.Instance.Emit<bool>(EEventName.OnRoleSkillInputPanelVisible, this.IsShowRightPanel);
		if (toggleState == EToggleState.ETT_Checked)
		{
			this.CurSkillTabShowType = ESkillTabShowType.Detail;
			this.ShowLeftPanelByTabType(this.CurSkillTabShowType);
		}
		else
		{
			this.ShowRightPanel(this.CurSkillTabShowType, false);
		}
		this.PlayRightPanelSequence(toggleState == EToggleState.ETT_Checked);
	}

	// Token: 0x06015845 RID: 88133 RVA: 0x0056DB8D File Offset: 0x0056BD8D
	private void SkillModeToggleClick(EToggleState toggleState)
	{
		if (this.SkillDescType == ERoleSkillDescType.MultiDesc)
		{
			RoleModel.Instance.IsShowMultiSkillDesc = (toggleState == EToggleState.ETT_Checked);
		}
		else
		{
			RoleModel.Instance.IsShowSkillResume = (toggleState == EToggleState.ETT_Checked);
		}
		this.Update(this.RoleSkillTreeInfoItemData);
	}

	// Token: 0x06015846 RID: 88134 RVA: 0x0056DBC2 File Offset: 0x0056BDC2
	private void OnNextLevelMaskBtnClick()
	{
		this.IsShowRightPanel = false;
		EventSystem.Instance.Emit<bool>(EEventName.OnRoleSkillInputPanelVisible, this.IsShowRightPanel);
		base.GetExtendToggle(19).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.HideNextLevelItem();
		this.PlayRightPanelSequence(false);
	}

	// Token: 0x06015847 RID: 88135 RVA: 0x0056DC00 File Offset: 0x0056BE00
	private void OnRoleSkillMaskBtnClick()
	{
		this.IsShowRightPanel = false;
		EventSystem.Instance.Emit<bool>(EEventName.OnRoleSkillInputPanelVisible, this.IsShowRightPanel);
		base.GetExtendToggle(19).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.HideRoleSkillInputPanel();
		this.PlayRightPanelSequence(false);
	}

	// Token: 0x06015848 RID: 88136 RVA: 0x0056DC3E File Offset: 0x0056BE3E
	private void OnIntroductionToggleClick(EToggleState toggleState)
	{
		this.CurSkillTabShowType = ESkillTabShowType.Introduction;
		this.ShowLeftPanelByTabType(this.CurSkillTabShowType);
	}

	// Token: 0x06015849 RID: 88137 RVA: 0x0056DC53 File Offset: 0x0056BE53
	private void OnAttrDetailToggleClick(EToggleState toggleState)
	{
		this.CurSkillTabShowType = ESkillTabShowType.Detail;
		this.ShowLeftPanelByTabType(this.CurSkillTabShowType);
	}

	// Token: 0x0601584A RID: 88138 RVA: 0x0056DC68 File Offset: 0x0056BE68
	private void OnLevelUpClick(int _)
	{
		int? num = (this.SkillTreeConfig != null) ? new int?(this.SkillTreeConfig.GetValueOrDefault().NodeType) : null;
		if ((num.GetValueOrDefault() == 2 || num.GetValueOrDefault() == 1) && this.TargetLevel > this.CurrentSkillLevel + 1)
		{
			this.OnQuickLevelUpClick();
			return;
		}
		this.OnNormalLevelUpClick();
	}

	// Token: 0x0601584B RID: 88139 RVA: 0x0056DCE0 File Offset: 0x0056BEE0
	private void OnNormalLevelUpClick()
	{
		int skillNodeLevel = this.SkillData.GetSkillNodeLevel(this.SkillTreeConfig.Value);
		IEnumerable<DicIntInt?> roleSkillTreeConsume = RoleSkillConfig.Instance.GetRoleSkillTreeConsume(this.RoleSkillTreeInfoItemData.SkillNodeId, skillNodeLevel + 1);
		if (roleSkillTreeConsume != null)
		{
			foreach (DicIntInt? dicIntInt in roleSkillTreeConsume)
			{
				int key = dicIntInt.Value.Key;
				int value = dicIntInt.Value.Value;
				if (InventoryModel.Instance.GetItemCountByConfigId(key, 0) < value)
				{
					List<ISelectedData> selectedDataList = this.GetSelectedDataList();
					ComposePopupViewData param = new ComposePopupViewData
					{
						SelectedItemList = selectedDataList,
						BeforeCompose = delegate
						{
							this.IsLevelUpPending = true;
						},
						ClickConfirm = new Action(this.LevelUpRequest),
						BelongView = new EUiViewName?(EUiViewName.RoleSkillTreeInfoView)
					};
					UiManager.Instance.OpenView(EUiViewName.SynthesisTipsInfoView, param, delegate(bool isSuccess, int viewId)
					{
						if (isSuccess)
						{
							if (this.ParentView == null)
							{
								return;
							}
							this.ParentView.AddChildViewById(viewId);
						}
					});
					return;
				}
			}
		}
		this.LevelUpRequest();
	}

	// Token: 0x0601584C RID: 88140 RVA: 0x0056DE04 File Offset: 0x0056C004
	private void OnQuickLevelUpClick()
	{
		int targetLevel = this.TargetLevel;
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = this.CurrentSkillLevel + 1; i <= targetLevel; i++)
		{
			IEnumerable<DicIntInt?> roleSkillTreeConsume = RoleSkillConfig.Instance.GetRoleSkillTreeConsume(this.RoleSkillTreeInfoItemData.SkillNodeId, i);
			if (roleSkillTreeConsume != null)
			{
				foreach (DicIntInt? dicIntInt in roleSkillTreeConsume)
				{
					int key = dicIntInt.Value.Key;
					int value = dicIntInt.Value.Value;
					int num;
					if (!dictionary.TryGetValue(key, out num))
					{
						num = 0;
					}
					dictionary[key] = num + value;
				}
			}
		}
		Action <>9__1;
		Action <>9__2;
		TOpenViewCallBack <>9__0;
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			int key2 = keyValuePair.Key;
			int value2 = keyValuePair.Value;
			if (InventoryModel.Instance.GetItemCountByConfigId(key2, 0) < value2)
			{
				List<ISelectedData> selectedDataList = this.GetSelectedDataList();
				ComposePopupViewData composePopupViewData = new ComposePopupViewData();
				composePopupViewData.SelectedItemList = selectedDataList;
				Action beforeCompose;
				if ((beforeCompose = <>9__1) == null)
				{
					beforeCompose = (<>9__1 = delegate()
					{
						this.IsLevelUpPending = true;
					});
				}
				composePopupViewData.BeforeCompose = beforeCompose;
				Action clickConfirm;
				if ((clickConfirm = <>9__2) == null)
				{
					clickConfirm = (<>9__2 = delegate()
					{
						this.QuickLevelUpRequest(targetLevel);
					});
				}
				composePopupViewData.ClickConfirm = clickConfirm;
				composePopupViewData.BelongView = new EUiViewName?(EUiViewName.RoleSkillTreeInfoView);
				ComposePopupViewData composePopupViewData2 = composePopupViewData;
				UiManager instance = UiManager.Instance;
				EUiViewName synthesisTipsInfoView = EUiViewName.SynthesisTipsInfoView;
				object param = composePopupViewData2;
				TOpenViewCallBack finishCallback;
				if ((finishCallback = <>9__0) == null)
				{
					finishCallback = (<>9__0 = delegate(bool isSuccess, int viewId)
					{
						if (isSuccess)
						{
							if (this.ParentView == null)
							{
								return;
							}
							this.ParentView.AddChildViewById(viewId);
						}
					});
				}
				instance.OpenView(synthesisTipsInfoView, param, finishCallback);
				return;
			}
		}
		this.QuickLevelUpRequest(targetLevel);
	}

	// Token: 0x0601584D RID: 88141 RVA: 0x0056DFFC File Offset: 0x0056C1FC
	private void LevelUpRequest()
	{
		this.IsLevelUpPending = true;
		int nodeType = this.SkillTreeConfig.Value.NodeType;
		if (nodeType == 1 || nodeType == 2)
		{
			RoleController.Instance.SendPbUpLevelSkillRequest(this.RoleSkillTreeInfoItemData.RoleId, this.RoleSkillTreeInfoItemData.SkillNodeId);
			return;
		}
		RoleController.Instance.SendRoleActivateSkillRequest(this.RoleSkillTreeInfoItemData.RoleId, this.RoleSkillTreeInfoItemData.SkillNodeId);
	}

	// Token: 0x0601584E RID: 88142 RVA: 0x0056E06D File Offset: 0x0056C26D
	private void QuickLevelUpRequest(int targetLevel)
	{
		this.IsLevelUpPending = true;
		RoleController.SendRoleSkillQuickLevelUpRequest(this.RoleSkillTreeInfoItemData.RoleId, this.RoleSkillTreeInfoItemData.SkillNodeId, targetLevel);
	}

	// Token: 0x0601584F RID: 88143 RVA: 0x0056E092 File Offset: 0x0056C292
	[NullableContext(1)]
	private List<ISelectedData> GetSelectedDataList()
	{
		return this.SortConsumeList(this.CachedConsumeList ?? new List<ISelectedData>());
	}

	// Token: 0x06015850 RID: 88144 RVA: 0x0056E0AC File Offset: 0x0056C2AC
	private void OnLockTipBtnClick()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleSkillLevelUpTip);
		int roleId = this.RoleSkillTreeInfoItemData.RoleId;
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			UiViewBase parentView = this.ParentView;
			EUiViewName? euiViewName = (parentView != null) ? new EUiViewName?(parentView.ViewInfo.Name) : null;
			if (euiViewName != null)
			{
				UiManager.Instance.CloseView(euiViewName.Value, null);
			}
			if (UiManager.Instance.GetViewByName(EUiViewName.RoleRootView) != null)
			{
				UiManager.Instance.NormalResetToView(EUiViewName.RoleRootView, null, true);
				EventSystem.Instance.Emit<EUiTabViewName, int>(EEventName.SelectRoleTabOutside, EUiTabViewName.RoleAttributeTabView, roleId);
				return;
			}
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Normal, roleId, new List<int>(), new EUiTabViewName?(EUiTabViewName.RoleAttributeTabView), null);
		});
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06015851 RID: 88145 RVA: 0x0056E110 File Offset: 0x0056C310
	[NullableContext(1)]
	private CostMediumItemGrid InitCostItem()
	{
		CostMediumItemGrid costMediumItemGrid = new CostMediumItemGrid();
		costMediumItemGrid.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback callbackParameter)
		{
			ISelectedData selectedData = callbackParameter.Data as ISelectedData;
			ItemController.Instance.OpenItemTipsByItemId(selectedData.ItemId, true, null);
			ComposeModel.Instance.ComposeSelectItem = selectedData;
			ComposeModel.Instance.ComposeSkipSourceView = new EUiViewName?(EUiViewName.RoleSkillTreeInfoView);
			InventoryModel.Instance.SetItemNeedCount(new int?(selectedData.Count - selectedData.SelectedCount));
		});
		costMediumItemGrid.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
		return costMediumItemGrid;
	}

	// Token: 0x06015852 RID: 88146 RVA: 0x0056E16C File Offset: 0x0056C36C
	[NullableContext(1)]
	private ILayoutItem<RoleSkillTreeAttributeItem> InitAttrItem(object data, UUIItem uiItem, int index)
	{
		RoleSkillTreeAttributeItem roleSkillTreeAttributeItem = new RoleSkillTreeAttributeItem(uiItem);
		CommonAttributeData curData = this.CurAttributeDataList[index];
		CommonAttributeData nextData = (index < this.NextAttributeDataList.Count) ? this.NextAttributeDataList[index] : null;
		roleSkillTreeAttributeItem.Refresh(curData, nextData);
		roleSkillTreeAttributeItem.SetNextLevelItem(this.IsShowRightPanel);
		return new LayoutItem<RoleSkillTreeAttributeItem>
		{
			Key = index,
			Value = roleSkillTreeAttributeItem
		};
	}

	// Token: 0x06015853 RID: 88147 RVA: 0x0056E1D8 File Offset: 0x0056C3D8
	[NullableContext(1)]
	public void Update(IRoleSkillTreeInfoItemData data)
	{
		this.IsLevelUpPending = false;
		this.RoleSkillTreeInfoItemData = data;
		this.SkillTreeConfig = RoleSkillConfig.Instance.GetSkillTreeNode(this.RoleSkillTreeInfoItemData.SkillNodeId);
		this.SkillId = this.SkillTreeConfig.Value.SkillId;
		this.UpgradeSkillId = RoleModel.Instance.GetUpgradeSkillIdIfUpgraded(this.SkillId, this.RoleSkillTreeInfoItemData.RoleId);
		this.ShowSkillId = ((this.UpgradeSkillId > 0) ? this.UpgradeSkillId : this.SkillId);
		this.SkillConfig = ((this.SkillId > 0) ? RoleSkillConfig.Instance.GetSkillConfigById(this.SkillId) : null);
		this.ShowSkillConfig = ((this.ShowSkillId > 0) ? RoleSkillConfig.Instance.GetSkillConfigById(this.ShowSkillId) : null);
		RoleDataBase roleDataBase = RoleModel.Instance.GetRoleInstanceById(this.RoleSkillTreeInfoItemData.RoleId);
		if (roleDataBase == null)
		{
			roleDataBase = RoleModel.Instance.GetRoleDataById(this.RoleSkillTreeInfoItemData.RoleId, true);
		}
		this.SkillData = roleDataBase.GetSkillData();
		RoleSkillInputPanel roleSkillInputPanel = this.RoleSkillInputPanel;
		if (roleSkillInputPanel != null)
		{
			roleSkillInputPanel.Refresh(roleDataBase.GetRoleId(), roleDataBase.IsTrialRole(), true);
		}
		this.Refresh();
		if (roleDataBase.IsTrialRole())
		{
			this.RefreshTrial();
		}
		this.RefreshSkillBranch();
	}

	// Token: 0x06015854 RID: 88148 RVA: 0x0056E330 File Offset: 0x0056C530
	public void Refresh()
	{
		switch (RoleSkillConfig.Instance.GetSkillTreeNode(this.RoleSkillTreeInfoItemData.SkillNodeId).Value.NodeType)
		{
		case 1:
			this.RefreshByInnerPassiveSkill();
			break;
		case 2:
			this.RefreshByInnerSkill();
			break;
		case 3:
			this.RefreshByOuterPassiveSkill();
			break;
		case 4:
			this.RefreshByOuterAttribute();
			break;
		}
		this.RefreshRoleBackgroundMusicSwitchItem();
	}

	// Token: 0x06015855 RID: 88149 RVA: 0x0056E3A4 File Offset: 0x0056C5A4
	private void RefreshTrial()
	{
		base.GetItem(22).SetUIActive(false);
		base.GetItem(17).SetUIActive(false);
		base.GetItem(15).SetUIActive(false);
		this.ConfirmButtonItem.SetActive(false);
		base.GetExtendToggle(19).RootUIComp.Get().SetUIActive(false);
		this.CaptionItem.SetCurrencyItemVisible(false);
	}

	// Token: 0x06015856 RID: 88150 RVA: 0x0056E410 File Offset: 0x0056C610
	private void RefreshByOuterAttribute()
	{
		this.UseTexture = true;
		this.CurSkillTabShowType = ESkillTabShowType.Introduction;
		base.GetText(3).SetUIActive(false);
		base.GetItem(6).SetUIActive(false);
		base.GetExtendToggle(19).RootUIComp.Get().SetUIActive(false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "SkillType_AttributeNode_TypeName", Array.Empty<object>());
		SkillTree value = RoleSkillConfig.Instance.GetSkillTreeNode(this.RoleSkillTreeInfoItemData.SkillNodeId).Value;
		object[] array = new object[value.PropertyNodeParamLength];
		for (int i = 0; i < value.PropertyNodeParamLength; i++)
		{
			array[i] = value.PropertyNodeParam(i);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), value.PropertyNodeTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(10), value.PropertyNodeDescribe, array);
		base.GetText(10).bBestFit = false;
		this.RefreshNoLevelNodeState();
		this.RefreshSkillIcon();
	}

	// Token: 0x06015857 RID: 88151 RVA: 0x0056E51C File Offset: 0x0056C71C
	private void RefreshByOuterPassiveSkill()
	{
		this.UseTexture = false;
		this.CurSkillTabShowType = ESkillTabShowType.Introduction;
		base.GetText(3).SetUIActive(false);
		base.GetItem(6).SetUIActive(false);
		base.GetExtendToggle(19).RootUIComp.Get().SetUIActive(false);
		this.RefreshSkillInfo();
		this.RefreshNoLevelNodeState();
		this.RefreshSkillIcon();
	}

	// Token: 0x06015858 RID: 88152 RVA: 0x0056E57E File Offset: 0x0056C77E
	private void RefreshByInnerPassiveSkill()
	{
		this.UseTexture = false;
		this.RefreshByCanLevelUpSkill();
		this.RefreshSkillIcon();
	}

	// Token: 0x06015859 RID: 88153 RVA: 0x0056E593 File Offset: 0x0056C793
	private void RefreshByInnerSkill()
	{
		this.UseTexture = false;
		this.RefreshByCanLevelUpSkill();
		this.RefreshSkillIcon();
	}

	// Token: 0x0601585A RID: 88154 RVA: 0x0056E5A8 File Offset: 0x0056C7A8
	private void RefreshByCanLevelUpSkill()
	{
		base.GetText(3).SetUIActive(true);
		base.GetItem(6).SetUIActive(true);
		int roleSkillTreeNodeLevel = RoleModel.Instance.GetRoleSkillTreeNodeLevel(this.RoleSkillTreeInfoItemData.RoleId, this.RoleSkillTreeInfoItemData.SkillNodeId);
		int maxSkillLevel = this.SkillConfig.Value.MaxSkillLevel;
		this.CurrentSkillLevel = roleSkillTreeNodeLevel;
		this.MaxSkillLevel = maxSkillLevel;
		LguiUtil.Instance.SetLocalText(base.GetText(3), "RoleResonanceLevel", new <>z__ReadOnlySingleElementList<object>(roleSkillTreeNodeLevel));
		this.RefreshSkillInfo();
		this.RefreshHasLevelNodeState();
		this.RefreshNextLevelText();
	}

	// Token: 0x0601585B RID: 88155 RVA: 0x0056E648 File Offset: 0x0056C848
	private void RefreshSkillInfo()
	{
		if (this.ShowSkillConfig != null)
		{
			Aki.Config.Skill value = this.ShowSkillConfig.Value;
			string skillTypeNameLocalText = RoleSkillConfig.Instance.GetSkillTypeNameLocalText(value.SkillType);
			if (!string.IsNullOrEmpty(skillTypeNameLocalText))
			{
				base.GetText(2).SetText(skillTypeNameLocalText, true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), value.SkillName, Array.Empty<object>());
			UUIText text = base.GetText(10);
			if (this.SkillDescType == ERoleSkillDescType.MultiDesc)
			{
				if (RoleModel.Instance.IsShowMultiSkillDesc)
				{
					object[] array = new object[value.MultiSkillDetailNumLength];
					for (int i = 0; i < value.MultiSkillDetailNumLength; i++)
					{
						array[i] = value.MultiSkillDetailNum(i);
					}
					LguiUtil.Instance.SetLocalTextNew(text, value.MultiSkillDescribe, array);
				}
				else
				{
					object[] array2 = new object[value.SkillDetailNumLength];
					for (int j = 0; j < value.SkillDetailNumLength; j++)
					{
						array2[j] = value.SkillDetailNum(j);
					}
					LguiUtil.Instance.SetLocalTextNew(text, value.SkillDescribe, array2);
				}
			}
			else if (RoleModel.Instance.IsShowSkillResume)
			{
				object[] array3 = new object[value.SkillResumeNumLength];
				for (int k = 0; k < value.SkillResumeNumLength; k++)
				{
					array3[k] = value.SkillResumeNum(k);
				}
				LguiUtil.Instance.SetLocalTextNew(text, value.SkillResume, array3);
			}
			else
			{
				object[] array4 = new object[value.SkillDetailNumLength];
				for (int l = 0; l < value.SkillDetailNumLength; l++)
				{
					array4[l] = value.SkillDetailNum(l);
				}
				LguiUtil.Instance.SetLocalTextNew(text, value.SkillDescribe, array4);
			}
			text.bBestFit = false;
		}
	}

	// Token: 0x0601585C RID: 88156 RVA: 0x0056E80C File Offset: 0x0056CA0C
	private void RefreshSkillIcon()
	{
		string path;
		if (this.ShowSkillConfig != null)
		{
			path = this.ShowSkillConfig.Value.Icon;
		}
		else
		{
			path = this.SkillTreeConfig.Value.PropertyNodeIcon;
		}
		UUITexture texture = base.GetTexture(1);
		UUISprite sprite = base.GetSprite(0);
		if (this.UseTexture)
		{
			texture.SetUIActive(true);
			sprite.SetUIActive(false);
			base.SetTextureByPath(path, texture, null, null);
			return;
		}
		texture.SetUIActive(false);
		sprite.SetUIActive(true);
		this.SetSpriteByPath(path, sprite, false, null, null);
	}

	// Token: 0x0601585D RID: 88157 RVA: 0x0056E8B0 File Offset: 0x0056CAB0
	private void RefreshConsume(int nextLevel = 1)
	{
		IEnumerable<DicIntInt?> roleSkillTreeConsume = RoleSkillConfig.Instance.GetRoleSkillTreeConsume(this.RoleSkillTreeInfoItemData.SkillNodeId, nextLevel);
		if (roleSkillTreeConsume == null || roleSkillTreeConsume.Count<DicIntInt?>() == 0)
		{
			base.GetItem(22).SetUIActive(false);
			base.GetItem(23).SetUIActive(false);
			return;
		}
		base.GetItem(22).SetUIActive(true);
		base.GetItem(23).SetUIActive(true);
		List<ISelectedData> list = new List<ISelectedData>();
		int num = 0;
		foreach (DicIntInt? dicIntInt in roleSkillTreeConsume)
		{
			int key = dicIntInt.Value.Key;
			int value = dicIntInt.Value.Value;
			if (key == 2)
			{
				num = value;
			}
			else
			{
				SelectedData item2 = new SelectedData
				{
					ItemId = key,
					IncId = 0,
					Count = value,
					SelectedCount = InventoryModel.Instance.GetCommonItemCount(key, 0)
				};
				list.Add(item2);
			}
		}
		this.CachedConsumeList = (from item in list
		select new SelectedData
		{
			ItemId = item.ItemId,
			IncId = item.IncId,
			Count = item.Count,
			SelectedCount = item.SelectedCount
		}).ToList<ISelectedData>();
		this.ItemListLength = list.Count;
		if (num > 0)
		{
			this.CachedConsumeList.Add(new SelectedData
			{
				ItemId = 2,
				IncId = 0,
				Count = num,
				SelectedCount = InventoryModel.Instance.GetItemCountByConfigId(2, 0)
			});
		}
		UUIText text = base.GetText(13);
		text.SetText(num.ToString(), true);
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(2, 0);
		UUIItem uuiitem = text;
		bool bUseChangeColor = itemCountByConfigId < num;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		this.ConsumeItemScroll.RefreshByData(this.SortConsumeList(list), null, false);
	}

	// Token: 0x0601585E RID: 88158 RVA: 0x0056EA8C File Offset: 0x0056CC8C
	[NullableContext(1)]
	private List<ISelectedData> SortConsumeList(List<ISelectedData> consumeList)
	{
		return (from a in consumeList
		orderby (a.SelectedCount >= a.Count) ? 1 : 0
		select a).ThenByDescending(delegate(ISelectedData a)
		{
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(a.ItemId);
			if (itemConfigData == null)
			{
				return 0;
			}
			return itemConfigData.QualityId;
		}).ToList<ISelectedData>();
	}

	// Token: 0x0601585F RID: 88159 RVA: 0x0056EAE8 File Offset: 0x0056CCE8
	[NullableContext(1)]
	private void RefreshCostItemButton(string passButtonTextId)
	{
		int skillNodeLevel = this.SkillData.GetSkillNodeLevel(this.SkillTreeConfig.Value);
		IEnumerable<DicIntInt?> roleSkillTreeConsume = RoleSkillConfig.Instance.GetRoleSkillTreeConsume(this.RoleSkillTreeInfoItemData.SkillNodeId, skillNodeLevel + 1);
		if (roleSkillTreeConsume != null)
		{
			foreach (DicIntInt? dicIntInt in roleSkillTreeConsume)
			{
				int key = dicIntInt.Value.Key;
				int value = dicIntInt.Value.Value;
				if (InventoryModel.Instance.GetItemCountByConfigId(key, 0) < value)
				{
					bool flag = ComposePopupModel.Instance.CheckOpenResult(this.GetSelectedDataList());
					if (flag)
					{
						ButtonItem confirmButtonItem = this.ConfirmButtonItem;
						if (confirmButtonItem != null)
						{
							confirmButtonItem.SetShowText("AutoSynthesis_MaterialReplenishBtn_Text");
						}
					}
					else
					{
						ButtonItem confirmButtonItem2 = this.ConfirmButtonItem;
						if (confirmButtonItem2 != null)
						{
							confirmButtonItem2.SetShowText("AutoSynthesis_MaterialMissingBtn_Text");
						}
					}
					ButtonItem confirmButtonItem3 = this.ConfirmButtonItem;
					if (confirmButtonItem3 == null)
					{
						return;
					}
					confirmButtonItem3.SetEnableClick(flag);
					return;
				}
			}
		}
		ButtonItem confirmButtonItem4 = this.ConfirmButtonItem;
		if (confirmButtonItem4 != null)
		{
			confirmButtonItem4.SetLocalText(passButtonTextId, Array.Empty<object>());
		}
		ButtonItem confirmButtonItem5 = this.ConfirmButtonItem;
		if (confirmButtonItem5 == null)
		{
			return;
		}
		confirmButtonItem5.SetEnableClick(true);
	}

	// Token: 0x06015860 RID: 88160 RVA: 0x0056EC1C File Offset: 0x0056CE1C
	private void RefreshNoLevelNodeState()
	{
		ESkillTreeNodeState skillTreeNodeState = this.SkillData.GetSkillTreeNodeState(this.SkillTreeConfig.Value, this.RoleSkillTreeInfoItemData.RoleId);
		this.ConfirmButtonItem.SetActive(skillTreeNodeState == ESkillTreeNodeState.Inactive);
		base.GetItem(22).SetUIActive(skillTreeNodeState == ESkillTreeNodeState.Inactive);
		base.GetItem(23).SetUIActive(skillTreeNodeState == ESkillTreeNodeState.Inactive);
		base.GetItem(17).SetUIActive(skillTreeNodeState == ESkillTreeNodeState.Lock);
		base.GetItem(15).SetUIActive(skillTreeNodeState == ESkillTreeNodeState.Active);
		if (skillTreeNodeState == ESkillTreeNodeState.Active)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(16), "Actived", Array.Empty<object>());
		}
		else
		{
			this.RefreshConsume(1);
			if (skillTreeNodeState == ESkillTreeNodeState.Inactive)
			{
				this.RefreshCostItemButton("RoleResonActive");
			}
			else if (skillTreeNodeState == ESkillTreeNodeState.Lock)
			{
				string unlockConditionTextId = this.SkillData.GetUnlockConditionTextId(this.SkillTreeConfig.Value);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(18), unlockConditionTextId, Array.Empty<object>());
			}
			SkillCondition? skillTreeUnsatisfiedCondition = this.SkillData.GetSkillTreeUnsatisfiedCondition(this.SkillTreeConfig.Value);
			base.GetButton(26).RootUIComp.Get().SetUIActive(skillTreeUnsatisfiedCondition == null || skillTreeUnsatisfiedCondition.GetValueOrDefault().ConditionType != 2);
		}
		UUIItem item = base.GetItem(40);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.TargetLevel = 0;
		this.CurrentSkillLevel = 0;
		this.MaxSkillLevel = 0;
		this.LastInitSnapshotSkillNodeId = 0;
		this.LastInitSnapshotCurrentLevel = -1;
		this.LastInitSnapshotItemCounts = null;
		this.SetBoxPanelVisibility(false);
	}

	// Token: 0x06015861 RID: 88161 RVA: 0x0056EDA8 File Offset: 0x0056CFA8
	private void RefreshHasLevelNodeState()
	{
		ESkillTreeNodeState skillTreeNodeState = this.SkillData.GetSkillTreeNodeState(this.SkillTreeConfig.Value, this.RoleSkillTreeInfoItemData.RoleId);
		this.ConfirmButtonItem.SetActive(skillTreeNodeState == ESkillTreeNodeState.Inactive);
		base.GetItem(22).SetUIActive(skillTreeNodeState != ESkillTreeNodeState.Active);
		base.GetItem(23).SetUIActive(skillTreeNodeState != ESkillTreeNodeState.Active);
		base.GetItem(17).SetUIActive(skillTreeNodeState == ESkillTreeNodeState.Lock);
		base.GetItem(15).SetUIActive(skillTreeNodeState == ESkillTreeNodeState.Active);
		base.GetExtendToggle(19).RootUIComp.Get().SetUIActive(true);
		this.RefreshCurrentLevelAttribute();
		if (skillTreeNodeState == ESkillTreeNodeState.Active)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(16), "RoleAlreadyMax", Array.Empty<object>());
		}
		else
		{
			int skillNodeLevel = this.SkillData.GetSkillNodeLevel(this.SkillTreeConfig.Value);
			this.RefreshConsume(skillNodeLevel + 1);
			if (skillTreeNodeState == ESkillTreeNodeState.Inactive)
			{
				this.RefreshCostItemButton("RoleLevelUp");
			}
			else if (skillTreeNodeState == ESkillTreeNodeState.Lock)
			{
				string unlockConditionTextId = this.SkillData.GetUnlockConditionTextId(this.SkillTreeConfig.Value);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(18), unlockConditionTextId, Array.Empty<object>());
			}
			SkillCondition? skillTreeUnsatisfiedCondition = this.SkillData.GetSkillTreeUnsatisfiedCondition(this.SkillTreeConfig.Value);
			base.GetButton(26).RootUIComp.Get().SetUIActive(skillTreeUnsatisfiedCondition == null || skillTreeUnsatisfiedCondition.GetValueOrDefault().ConditionType != 2);
		}
		this.InitQuickLevelUpPanel(skillTreeNodeState);
		this.RefreshBoxPanelVisibility();
	}

	// Token: 0x06015862 RID: 88162 RVA: 0x0056EF40 File Offset: 0x0056D140
	[NullableContext(1)]
	private CommonAttributeData CreateAttributeData(OneSkillEffect effect)
	{
		CommonAttributeData commonAttributeData = new CommonAttributeData();
		string skillAttributeNameByOneSkillEffect = RoleModel.Instance.GetSkillAttributeNameByOneSkillEffect(effect);
		commonAttributeData.AttrNameText = (ConfigMultiTextLang.GetLocalTextNew(skillAttributeNameByOneSkillEffect, null) ?? "");
		commonAttributeData.AttrBaseValue = RoleModel.Instance.GetSkillAttributeDescriptionByOneSkillEffect(effect);
		return commonAttributeData;
	}

	// Token: 0x06015863 RID: 88163 RVA: 0x0056EF88 File Offset: 0x0056D188
	private void RefreshNextLevelText()
	{
		UUIText text = base.GetText(32);
		UUIItem item = base.GetItem(43);
		if (text == null)
		{
			return;
		}
		if (this.CurrentSkillLevel >= this.MaxSkillLevel)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "PrefabTextItem_3463157315_Text", Array.Empty<object>());
			if (item != null)
			{
				item.SetUIActive(true);
			}
			return;
		}
		if (this.MaxTargetLevel <= this.CurrentSkillLevel)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "PrefabTextItem_SkillNext_Text", Array.Empty<object>());
			if (item != null)
			{
				item.SetUIActive(false);
			}
			return;
		}
		int num = (this.TargetLevel > 0) ? this.TargetLevel : (this.CurrentSkillLevel + 1);
		LguiUtil.Instance.SetLocalTextNew(text, "Text_LevelText_Text", new object[]
		{
			num
		});
		if (item != null)
		{
			item.SetUIActive(num >= this.MaxSkillLevel);
		}
	}

	// Token: 0x06015864 RID: 88164 RVA: 0x0056F058 File Offset: 0x0056D258
	private void InitQuickLevelUpPanel(ESkillTreeNodeState state)
	{
		UUIItem item = base.GetItem(40);
		if (item == null)
		{
			return;
		}
		if (state == ESkillTreeNodeState.Lock || state == ESkillTreeNodeState.Active)
		{
			item.SetUIActive(false);
			this.LastInitSnapshotSkillNodeId = 0;
			this.LastInitSnapshotCurrentLevel = -1;
			this.LastInitSnapshotItemCounts = null;
			return;
		}
		this.CalcMaxTargetLevel();
		bool flag = this.MaxTargetLevel > this.CurrentSkillLevel;
		item.SetUIActive(true);
		int num = flag ? (this.CurrentSkillLevel + 1) : this.CurrentSkillLevel;
		int num2 = flag ? this.MaxTargetLevel : (this.CurrentSkillLevel + 1);
		Dictionary<int, int> dictionary = this.CalcQuickLevelUpItemCountSnapshot();
		bool flag2 = flag && this.LastInitSnapshotSkillNodeId == this.RoleSkillTreeInfoItemData.SkillNodeId && this.LastInitSnapshotCurrentLevel == this.CurrentSkillLevel && this.IsItemCountSnapshotEqual(this.LastInitSnapshotItemCounts, dictionary);
		int targetLevel = this.TargetLevel;
		INumberSelectData data = new INumberSelectData
		{
			MaxNumber = num2,
			ValueChangeFunction = new Action<int>(this.OnTargetLevelChange)
		};
		int minValue = (flag && num != num2) ? num : (num - 1);
		NumberSelectComponent numberSelectComponent = this.NumberSelectComponent;
		if (numberSelectComponent != null)
		{
			numberSelectComponent.Init(data);
		}
		NumberSelectComponent numberSelectComponent2 = this.NumberSelectComponent;
		if (numberSelectComponent2 != null)
		{
			numberSelectComponent2.SetMinValue(minValue);
		}
		NumberSelectComponent numberSelectComponent3 = this.NumberSelectComponent;
		if (numberSelectComponent3 != null)
		{
			numberSelectComponent3.Refresh(num2);
		}
		if (flag)
		{
			bool flag3 = num == num2;
			NumberSelectComponent numberSelectComponent4 = this.NumberSelectComponent;
			if (numberSelectComponent4 != null)
			{
				numberSelectComponent4.SetMinTextShowState(!flag3);
			}
			int num3 = flag2 ? Math.Min(Math.Max(targetLevel, num), num2) : num;
			this.TargetLevel = num3;
			NumberSelectComponent numberSelectComponent5 = this.NumberSelectComponent;
			if (numberSelectComponent5 != null)
			{
				numberSelectComponent5.ChangeValue(num3, false);
			}
			if (flag3)
			{
				NumberSelectComponent numberSelectComponent6 = this.NumberSelectComponent;
				if (numberSelectComponent6 != null)
				{
					numberSelectComponent6.SelectMax();
				}
				NumberSelectComponent numberSelectComponent7 = this.NumberSelectComponent;
				if (numberSelectComponent7 != null)
				{
					numberSelectComponent7.SetSliderAndButtonInteractive(false);
				}
			}
			this.RefreshConsumeForTargetLevel();
		}
		else
		{
			NumberSelectComponent numberSelectComponent8 = this.NumberSelectComponent;
			if (numberSelectComponent8 != null)
			{
				numberSelectComponent8.SetMinTextShowState(false);
			}
			NumberSelectComponent numberSelectComponent9 = this.NumberSelectComponent;
			if (numberSelectComponent9 != null)
			{
				numberSelectComponent9.SelectMax();
			}
			NumberSelectComponent numberSelectComponent10 = this.NumberSelectComponent;
			if (numberSelectComponent10 != null)
			{
				numberSelectComponent10.SetSliderAndButtonInteractive(false);
			}
			this.TargetLevel = num;
		}
		this.RefreshNextLevelText();
		this.LastInitSnapshotSkillNodeId = this.RoleSkillTreeInfoItemData.SkillNodeId;
		this.LastInitSnapshotCurrentLevel = this.CurrentSkillLevel;
		this.LastInitSnapshotItemCounts = dictionary;
	}

	// Token: 0x06015865 RID: 88165 RVA: 0x0056F26C File Offset: 0x0056D46C
	[NullableContext(1)]
	private Dictionary<int, int> CalcQuickLevelUpItemCountSnapshot()
	{
		HashSet<int> hashSet = new HashSet<int>();
		for (int i = this.CurrentSkillLevel + 1; i <= this.MaxSkillLevel; i++)
		{
			IEnumerable<DicIntInt?> roleSkillTreeConsume = RoleSkillConfig.Instance.GetRoleSkillTreeConsume(this.RoleSkillTreeInfoItemData.SkillNodeId, i);
			if (roleSkillTreeConsume != null)
			{
				foreach (DicIntInt? dicIntInt in roleSkillTreeConsume)
				{
					hashSet.Add(dicIntInt.Value.Key);
				}
			}
		}
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (int num in hashSet)
		{
			dictionary[num] = InventoryModel.Instance.GetItemCountByConfigId(num, 0);
		}
		return dictionary;
	}

	// Token: 0x06015866 RID: 88166 RVA: 0x0056F358 File Offset: 0x0056D558
	private bool IsItemCountSnapshotEqual(Dictionary<int, int> a, Dictionary<int, int> b)
	{
		if (a == null || b == null)
		{
			return false;
		}
		if (a.Count != b.Count)
		{
			return false;
		}
		foreach (KeyValuePair<int, int> keyValuePair in a)
		{
			int num;
			if (!b.TryGetValue(keyValuePair.Key, out num) || num != keyValuePair.Value)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06015867 RID: 88167 RVA: 0x0056F3DC File Offset: 0x0056D5DC
	private void CalcMaxTargetLevel()
	{
		int maxSkillLevel = this.MaxSkillLevel;
		int maxTargetLevel = this.CurrentSkillLevel;
		int num = this.CurrentSkillLevel + 1;
		while (num <= maxSkillLevel && this.CanLevelUpToTarget(num))
		{
			maxTargetLevel = num;
			num++;
		}
		this.MaxTargetLevel = maxTargetLevel;
	}

	// Token: 0x06015868 RID: 88168 RVA: 0x0056F41C File Offset: 0x0056D61C
	private bool CanUpgradeToLevel(int targetLevel)
	{
		int skillId = this.SkillTreeConfig.Value.SkillId;
		if (skillId == 0)
		{
			return false;
		}
		Aki.Config.Skill? skillConfigById = RoleSkillConfig.Instance.GetSkillConfigById(skillId);
		if (skillConfigById == null)
		{
			return false;
		}
		SkillLevel? skillLevelConfigByGroupIdAndLevel = RoleSkillConfig.Instance.GetSkillLevelConfigByGroupIdAndLevel(skillConfigById.Value.SkillLevelGroupId, targetLevel);
		if (skillLevelConfigByGroupIdAndLevel == null)
		{
			return false;
		}
		int condition = skillLevelConfigByGroupIdAndLevel.Value.Condition;
		return condition <= 0 || LevelGeneralController.Instance.CheckCondition(condition.ToString(), null, true, new object[]
		{
			this.RoleSkillTreeInfoItemData.RoleId
		});
	}

	// Token: 0x06015869 RID: 88169 RVA: 0x0056F4C8 File Offset: 0x0056D6C8
	private bool CanLevelUpToTarget(int targetLevel)
	{
		if (!this.CanUpgradeToLevel(targetLevel))
		{
			return false;
		}
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = this.CurrentSkillLevel + 1; i <= targetLevel; i++)
		{
			IEnumerable<DicIntInt?> roleSkillTreeConsume = RoleSkillConfig.Instance.GetRoleSkillTreeConsume(this.RoleSkillTreeInfoItemData.SkillNodeId, i);
			if (roleSkillTreeConsume != null)
			{
				foreach (DicIntInt? dicIntInt in roleSkillTreeConsume)
				{
					int key = dicIntInt.Value.Key;
					int value = dicIntInt.Value.Value;
					int num;
					if (!dictionary.TryGetValue(key, out num))
					{
						num = 0;
					}
					dictionary[key] = num + value;
				}
			}
		}
		List<ISelectedData> list = new List<ISelectedData>();
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			int key2 = keyValuePair.Key;
			int value2 = keyValuePair.Value;
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(key2, 0);
			SelectedData item = new SelectedData
			{
				ItemId = key2,
				IncId = 0,
				Count = value2,
				SelectedCount = itemCountByConfigId
			};
			list.Add(item);
		}
		list.Sort(delegate(ISelectedData a, ISelectedData b)
		{
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(a.ItemId);
			int num2 = (itemConfigData != null) ? itemConfigData.QualityId : 0;
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData2 = InventoryConfig.Instance.GetItemConfigData(b.ItemId);
			int num3 = (itemConfigData2 != null) ? itemConfigData2.QualityId : 0;
			return num2 - num3;
		});
		using (List<IComposePopupGridItemData>.Enumerator enumerator3 = ComposePopupModel.Instance.CheckComposeResult(list, true, false).Item2.GetEnumerator())
		{
			while (enumerator3.MoveNext())
			{
				if (enumerator3.Current.State == EGridState.NotEnough)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0601586A RID: 88170 RVA: 0x0056F6A0 File Offset: 0x0056D8A0
	private void OnTargetLevelChange(int value)
	{
		this.TargetLevel = value;
		this.RefreshConsumeForTargetLevel();
		this.RefreshCostItemButtonForQuickLevelUp();
		this.RefreshBoxPanelVisibility();
		this.RefreshCurrentLevelAttributeForTargetLevel();
		this.RefreshNextLevelText();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(41), "QuickUpgrade_TargetLevel", new object[]
		{
			value
		});
	}

	// Token: 0x0601586B RID: 88171 RVA: 0x0056F6F8 File Offset: 0x0056D8F8
	private void RefreshConsumeForTargetLevel()
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = this.CurrentSkillLevel + 1; i <= this.TargetLevel; i++)
		{
			IEnumerable<DicIntInt?> roleSkillTreeConsume = RoleSkillConfig.Instance.GetRoleSkillTreeConsume(this.RoleSkillTreeInfoItemData.SkillNodeId, i);
			if (roleSkillTreeConsume != null)
			{
				foreach (DicIntInt? dicIntInt in roleSkillTreeConsume)
				{
					int key = dicIntInt.Value.Key;
					int value = dicIntInt.Value.Value;
					int num;
					if (!dictionary.TryGetValue(key, out num))
					{
						num = 0;
					}
					dictionary[key] = num + value;
				}
			}
		}
		if (dictionary.Count == 0)
		{
			base.GetItem(22).SetUIActive(false);
			base.GetItem(23).SetUIActive(false);
			return;
		}
		base.GetItem(22).SetUIActive(true);
		base.GetItem(23).SetUIActive(true);
		List<ISelectedData> list = new List<ISelectedData>();
		int num2 = 0;
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			int key2 = keyValuePair.Key;
			int value2 = keyValuePair.Value;
			if (key2 == 2)
			{
				num2 = value2;
			}
			else
			{
				SelectedData item2 = new SelectedData
				{
					ItemId = key2,
					IncId = 0,
					Count = value2,
					SelectedCount = InventoryModel.Instance.GetCommonItemCount(key2, 0)
				};
				list.Add(item2);
			}
		}
		this.CachedConsumeList = (from item in list
		select new SelectedData
		{
			ItemId = item.ItemId,
			IncId = item.IncId,
			Count = item.Count,
			SelectedCount = item.SelectedCount
		}).ToList<ISelectedData>();
		this.ItemListLength = list.Count;
		if (num2 > 0)
		{
			this.CachedConsumeList.Add(new SelectedData
			{
				ItemId = 2,
				IncId = 0,
				Count = num2,
				SelectedCount = InventoryModel.Instance.GetItemCountByConfigId(2, 0)
			});
		}
		UUIText text = base.GetText(13);
		text.SetText(num2.ToString(), true);
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(2, 0);
		UUIItem uuiitem = text;
		bool bUseChangeColor = itemCountByConfigId < num2;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		this.ConsumeItemScroll.RefreshByData(this.SortConsumeList(list), null, false);
	}

	// Token: 0x0601586C RID: 88172 RVA: 0x0056F968 File Offset: 0x0056DB68
	private void RefreshCostItemButtonForQuickLevelUp()
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = this.CurrentSkillLevel + 1; i <= this.TargetLevel; i++)
		{
			IEnumerable<DicIntInt?> roleSkillTreeConsume = RoleSkillConfig.Instance.GetRoleSkillTreeConsume(this.RoleSkillTreeInfoItemData.SkillNodeId, i);
			if (roleSkillTreeConsume != null)
			{
				foreach (DicIntInt? dicIntInt in roleSkillTreeConsume)
				{
					int key = dicIntInt.Value.Key;
					int value = dicIntInt.Value.Value;
					int num;
					if (!dictionary.TryGetValue(key, out num))
					{
						num = 0;
					}
					dictionary[key] = num + value;
				}
			}
		}
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			int key2 = keyValuePair.Key;
			int value2 = keyValuePair.Value;
			if (InventoryModel.Instance.GetItemCountByConfigId(key2, 0) < value2)
			{
				List<ISelectedData> selectedDataList = this.GetSelectedDataList();
				bool flag = ComposePopupModel.Instance.CheckOpenResult(selectedDataList);
				if (flag)
				{
					ButtonItem confirmButtonItem = this.ConfirmButtonItem;
					if (confirmButtonItem != null)
					{
						confirmButtonItem.SetShowText("AutoSynthesis_MaterialReplenishBtn_Text");
					}
				}
				else
				{
					ButtonItem confirmButtonItem2 = this.ConfirmButtonItem;
					if (confirmButtonItem2 != null)
					{
						confirmButtonItem2.SetShowText("AutoSynthesis_MaterialMissingBtn_Text");
					}
				}
				ButtonItem confirmButtonItem3 = this.ConfirmButtonItem;
				if (confirmButtonItem3 == null)
				{
					return;
				}
				confirmButtonItem3.SetEnableClick(flag);
				return;
			}
		}
		ButtonItem confirmButtonItem4 = this.ConfirmButtonItem;
		if (confirmButtonItem4 != null)
		{
			confirmButtonItem4.SetLocalText("RoleLevelUp", Array.Empty<object>());
		}
		ButtonItem confirmButtonItem5 = this.ConfirmButtonItem;
		if (confirmButtonItem5 == null)
		{
			return;
		}
		confirmButtonItem5.SetEnableClick(true);
	}

	// Token: 0x0601586D RID: 88173 RVA: 0x0056FB14 File Offset: 0x0056DD14
	private void RefreshBoxPanelVisibility()
	{
		if (base.GetItem(39) == null)
		{
			return;
		}
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = this.CurrentSkillLevel + 1; i <= this.TargetLevel; i++)
		{
			IEnumerable<DicIntInt?> roleSkillTreeConsume = RoleSkillConfig.Instance.GetRoleSkillTreeConsume(this.RoleSkillTreeInfoItemData.SkillNodeId, i);
			if (roleSkillTreeConsume != null)
			{
				foreach (DicIntInt? dicIntInt in roleSkillTreeConsume)
				{
					int key = dicIntInt.Value.Key;
					int value = dicIntInt.Value.Value;
					int num;
					dictionary[key] = (dictionary.TryGetValue(key, out num) ? num : 0) + value;
				}
			}
		}
		List<ISelectedData> list = new List<ISelectedData>();
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			int key2 = keyValuePair.Key;
			int value2 = keyValuePair.Value;
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(key2, 0);
			list.Add(new SelectedData
			{
				ItemId = key2,
				IncId = 0,
				Count = value2,
				SelectedCount = Math.Min(itemCountByConfigId, value2)
			});
		}
		bool boxPanelVisibility = list.Count > 0 && ComposePopupModel.Instance.IsComposeGiftShouldShow(list);
		this.SetBoxPanelVisibility(boxPanelVisibility);
	}

	// Token: 0x0601586E RID: 88174 RVA: 0x0056FC98 File Offset: 0x0056DE98
	private void SetBoxPanelVisibility(bool visible)
	{
		UUIItem item = base.GetItem(39);
		if (item == null)
		{
			return;
		}
		bool flag = item.IsUIActiveSelf();
		item.SetUIActive(visible);
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(11);
		UUIItem item2 = base.GetItem(45);
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(44);
		float num;
		if (visible)
		{
			num = base.GetItem(22).GetWidth() - item.GetWidth();
		}
		else
		{
			num = base.GetItem(22).GetWidth();
		}
		float spacing = horizontalLayout.GetSpacing();
		float num2 = horizontalLayout.GetPadding().Left + horizontalLayout.GetPadding().Right;
		float x = item2.D_GetRelativeTransform().GetScale3D().X;
		float num3 = (item2.GetWidth() * x + spacing) * (float)this.ItemListLength - spacing + num2;
		if (num3 < num)
		{
			num = num3;
		}
		if (scrollViewWithScrollbar != null)
		{
			UUIItem uuiitem = scrollViewWithScrollbar.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetWidth(num);
			}
		}
		LevelSequencePlayer consumeLevelSequencePlayer = this.ConsumeLevelSequencePlayer;
		if (consumeLevelSequencePlayer != null)
		{
			consumeLevelSequencePlayer.StopCurrentSequence(false, false);
		}
		if (visible)
		{
			if (flag == visible)
			{
				LevelSequencePlayer consumeLevelSequencePlayer2 = this.ConsumeLevelSequencePlayer;
				if (consumeLevelSequencePlayer2 == null)
				{
					return;
				}
				consumeLevelSequencePlayer2.PlayLevelSequenceByName("BoxStart", false, null, true);
				return;
			}
			else
			{
				LevelSequencePlayer consumeLevelSequencePlayer3 = this.ConsumeLevelSequencePlayer;
				if (consumeLevelSequencePlayer3 == null)
				{
					return;
				}
				consumeLevelSequencePlayer3.PlayLevelSequenceByName("BoxStart", false, null, false);
			}
		}
	}

	// Token: 0x0601586F RID: 88175 RVA: 0x0056FDE0 File Offset: 0x0056DFE0
	private void RefreshCurrentLevelAttributeForTargetLevel()
	{
		this.CurAttributeDataList.Clear();
		this.NextAttributeDataList.Clear();
		SkillEffect skillEffectByLevel = this.GetSkillEffectByLevel(this.CurrentSkillLevel);
		List<OneSkillEffect> list = ((skillEffectByLevel != null) ? skillEffectByLevel.EffectDescList : null) ?? new List<OneSkillEffect>();
		SkillEffect skillEffectByLevel2 = this.GetSkillEffectByLevel(this.TargetLevel);
		List<OneSkillEffect> list2 = ((skillEffectByLevel2 != null) ? skillEffectByLevel2.EffectDescList : null) ?? new List<OneSkillEffect>();
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			this.CurAttributeDataList.Add(this.CreateAttributeData(list[i]));
			if (i < list2.Count)
			{
				this.NextAttributeDataList.Add(this.CreateAttributeData(list2[i]));
			}
		}
		this.CurrentLevelAttrScrollView.RefreshByData<CommonAttributeData>(this.CurAttributeDataList, null);
	}

	// Token: 0x06015870 RID: 88176 RVA: 0x0056FEB0 File Offset: 0x0056E0B0
	private SkillEffect GetSkillEffectByLevel(int level)
	{
		int skillId = this.SkillTreeConfig.Value.SkillId;
		if (skillId == 0)
		{
			return null;
		}
		return RoleModel.Instance.GetRoleSkillEffect(skillId, level);
	}

	// Token: 0x06015871 RID: 88177 RVA: 0x0056FEE4 File Offset: 0x0056E0E4
	private void RefreshCurrentLevelAttribute()
	{
		this.CurAttributeDataList.Clear();
		this.NextAttributeDataList.Clear();
		List<OneSkillEffect> effectDescList = RoleModel.Instance.RoleSkillResponseData.GetSkillEffect().EffectDescList;
		int count = effectDescList.Count;
		SkillEffect nextLevelSkillEffect = RoleModel.Instance.RoleSkillResponseData.GetNextLevelSkillEffect();
		List<OneSkillEffect> list = (nextLevelSkillEffect != null) ? nextLevelSkillEffect.EffectDescList : null;
		for (int i = 0; i < count; i++)
		{
			this.CurAttributeDataList.Add(this.CreateAttributeData(effectDescList[i]));
			if (list != null)
			{
				this.NextAttributeDataList.Add(this.CreateAttributeData(list[i]));
			}
		}
		this.CurrentLevelAttrScrollView.RefreshByData<CommonAttributeData>(this.CurAttributeDataList, null);
	}

	// Token: 0x06015872 RID: 88178 RVA: 0x0056FF99 File Offset: 0x0056E199
	public void ShowLeftPanelByTabType(ESkillTabShowType tabShowType)
	{
		if (tabShowType == ESkillTabShowType.Introduction)
		{
			this.ShowToIntroductionItem(true);
			return;
		}
		this.ShowToAttrDetailItem();
	}

	// Token: 0x06015873 RID: 88179 RVA: 0x0056FFB0 File Offset: 0x0056E1B0
	private void ShowToIntroductionItem(bool isPlaySequence = true)
	{
		base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		base.GetItem(7).SetUIActive(true);
		base.GetScrollViewWithScrollbar(8).GetRootComponent().SetUIActive(false);
		this.HideNextLevelItem();
		this.ShowRightPanel(this.CurSkillTabShowType, this.IsShowRightPanel);
		this.ShowSkillBranchItem(true);
	}

	// Token: 0x06015874 RID: 88180 RVA: 0x00570020 File Offset: 0x0056E220
	private void ShowToAttrDetailItem()
	{
		base.GetExtendToggle(4).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		base.GetItem(7).SetUIActive(false);
		base.GetScrollViewWithScrollbar(8).GetRootComponent().SetUIActive(true);
		this.HideRoleSkillInputPanel();
		this.ShowRightPanel(this.CurSkillTabShowType, this.IsShowRightPanel);
		this.ShowSkillBranchItem(false);
	}

	// Token: 0x06015875 RID: 88181 RVA: 0x0057008D File Offset: 0x0056E28D
	private void ShowRightPanel(ESkillTabShowType showType, bool isActive)
	{
		EventSystem.Instance.Emit<bool>(EEventName.OnRoleSkillInputPanelVisible, isActive);
		if (this.CurSkillTabShowType == ESkillTabShowType.Detail)
		{
			if (isActive)
			{
				this.ShowNextLevelItem();
				return;
			}
			this.HideNextLevelItem();
			return;
		}
		else
		{
			if (isActive)
			{
				this.ShowRoleSkillInputPanel();
				return;
			}
			this.HideRoleSkillInputPanel();
			return;
		}
	}

	// Token: 0x06015876 RID: 88182 RVA: 0x005700CA File Offset: 0x0056E2CA
	private void ShowRoleSkillInputPanel()
	{
		base.GetItem(27).SetUIActive(true);
	}

	// Token: 0x06015877 RID: 88183 RVA: 0x005700DA File Offset: 0x0056E2DA
	private void HideRoleSkillInputPanel()
	{
		base.GetItem(27).SetUIActive(false);
	}

	// Token: 0x06015878 RID: 88184 RVA: 0x005700EC File Offset: 0x0056E2EC
	private void ShowNextLevelItem()
	{
		base.GetItem(20).SetUIActive(true);
		foreach (RoleSkillTreeAttributeItem roleSkillTreeAttributeItem in this.CurrentLevelAttrScrollView.GetScrollItemList())
		{
			roleSkillTreeAttributeItem.SetNextLevelItem(true);
		}
	}

	// Token: 0x06015879 RID: 88185 RVA: 0x00570150 File Offset: 0x0056E350
	private void HideNextLevelItem()
	{
		base.GetItem(20).SetUIActive(false);
		foreach (RoleSkillTreeAttributeItem roleSkillTreeAttributeItem in this.CurrentLevelAttrScrollView.GetScrollItemList())
		{
			roleSkillTreeAttributeItem.SetNextLevelItem(false);
		}
	}

	// Token: 0x0601587A RID: 88186 RVA: 0x005701B4 File Offset: 0x0056E3B4
	private void PlayRightPanelSequence(bool showState)
	{
		if (showState)
		{
			this.LevelSequencePlayer.PlayOrReplaySequenceByName("ViewShow", false, null);
			return;
		}
		this.LevelSequencePlayer.PlayOrReplaySequenceByName("ViewHide", false, null);
	}

	// Token: 0x0601587B RID: 88187 RVA: 0x005701FC File Offset: 0x0056E3FC
	[NullableContext(1)]
	public void PlayItemSequence(string seq)
	{
		this.LevelSequencePlayer.PlayOrReplaySequenceByName(seq, false, null);
	}

	// Token: 0x0601587C RID: 88188 RVA: 0x00570220 File Offset: 0x0056E420
	[NullableContext(1)]
	public UniTask PlayItemSequenceAsync(string seq)
	{
		RoleSkillTreeInfoItem.<PlayItemSequenceAsync>d__103 <PlayItemSequenceAsync>d__;
		<PlayItemSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayItemSequenceAsync>d__.<>4__this = this;
		<PlayItemSequenceAsync>d__.seq = seq;
		<PlayItemSequenceAsync>d__.<>1__state = -1;
		<PlayItemSequenceAsync>d__.<>t__builder.Start<RoleSkillTreeInfoItem.<PlayItemSequenceAsync>d__103>(ref <PlayItemSequenceAsync>d__);
		return <PlayItemSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601587D RID: 88189 RVA: 0x0057026C File Offset: 0x0056E46C
	public void RefreshRoleBackgroundMusicSwitchItem()
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleSkillTreeInfoItemData.RoleId);
		if (roleInstanceById == null || roleInstanceById.IsTrialRole() || !roleInstanceById.GetRoleConfig().EnableOperateSelfBgm)
		{
			base.GetItem(34).SetUIActive(false);
			return;
		}
		base.GetItem(34).SetUIActive(true);
		RoleBackgroundMusicSwitchItem roleBackgroundMusicSwitchItem = this.RoleBackgroundMusicSwitchItem;
		if (roleBackgroundMusicSwitchItem == null)
		{
			return;
		}
		roleBackgroundMusicSwitchItem.RefreshByRoleData(roleInstanceById);
	}

	// Token: 0x0601587E RID: 88190 RVA: 0x005702D8 File Offset: 0x0056E4D8
	protected override void OnHide()
	{
		this.IsShowRightPanel = false;
		this.CurSkillTabShowType = ESkillTabShowType.Introduction;
		this.ShowLeftPanelByTabType(this.CurSkillTabShowType);
	}

	// Token: 0x0601587F RID: 88191 RVA: 0x005702F4 File Offset: 0x0056E4F4
	public ESkillTabShowType GetCurSkillTabShowType()
	{
		return this.CurSkillTabShowType;
	}

	// Token: 0x06015880 RID: 88192 RVA: 0x005702FC File Offset: 0x0056E4FC
	private void RefreshSkillBranch()
	{
		int skillNodeId = this.RoleSkillTreeInfoItemData.SkillNodeId;
		if (!RoleModel.Instance.IsSkillNodeHasBranch(skillNodeId))
		{
			this.IsShowSkillBranch = false;
			return;
		}
		this.IsShowSkillBranch = true;
		int roleId = this.RoleSkillTreeInfoItemData.RoleId;
		int skillNodeCurrentBranchId = RoleModel.Instance.GetSkillNodeCurrentBranchId(roleId, skillNodeId);
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(RoleConfig.Instance.GetSkillBranchConfigById(skillNodeCurrentBranchId).Value.Name, null);
		string skillBranchActivatedDescKey = RoleConfig.Instance.GetSkillBranchActivatedDescKey();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(36), skillBranchActivatedDescKey, new <>z__ReadOnlySingleElementList<object>(localTextNew));
		SkillTree? skillTreeNode = RoleSkillConfig.Instance.GetSkillTreeNode(skillNodeId);
		bool flag = ((skillTreeNode != null) ? skillTreeNode.GetValueOrDefault().SkillBranchDescListLength : 0) > 0;
		base.GetButton(37).RootUIComp.Get().SetUIActive(flag);
		if (flag)
		{
			int roleCurrentBranchIndex = RoleModel.Instance.GetRoleCurrentBranchIndex(roleId);
			int num = (skillTreeNode != null) ? skillTreeNode.GetValueOrDefault().SkillBranchDescListLength : 0;
			if (roleCurrentBranchIndex >= num)
			{
				return;
			}
			string text = (skillTreeNode != null) ? skillTreeNode.GetValueOrDefault().SkillBranchDescList(RoleModel.Instance.GetRoleCurrentBranchIndex(roleId)) : null;
			RoleSkillTreeInfoItem.RoleSkillBranchDetailItem branchDetailItem = this.BranchDetailItem;
			if (branchDetailItem == null)
			{
				return;
			}
			branchDetailItem.Refresh(text ?? "");
		}
	}

	// Token: 0x06015881 RID: 88193 RVA: 0x00570456 File Offset: 0x0056E656
	private void ClickBranchDetailBtn()
	{
		if (this.BranchDetailItem == null)
		{
			return;
		}
		if (this.BranchDetailItem.IsShowOrShowing)
		{
			this.BranchDetailItem.Hide(null);
			return;
		}
		this.BranchDetailItem.Show(null);
	}

	// Token: 0x06015882 RID: 88194 RVA: 0x00570487 File Offset: 0x0056E687
	private void ShowSkillBranchItem(bool isActive)
	{
		base.GetItem(35).SetUIActive(this.IsSkillBranchEnable && this.IsShowSkillBranch && isActive);
	}

	// Token: 0x06015883 RID: 88195 RVA: 0x005704A9 File Offset: 0x0056E6A9
	public void OnRoleSkillBranchChanged()
	{
		this.RefreshSkillBranch();
		this.Refresh();
	}

	// Token: 0x06015884 RID: 88196 RVA: 0x005704B7 File Offset: 0x0056E6B7
	public void SetSkillBranchEnable(bool isEnable)
	{
		this.IsSkillBranchEnable = isEnable;
	}

	// Token: 0x06015885 RID: 88197 RVA: 0x005704C0 File Offset: 0x0056E6C0
	public void SetParentView(UiViewBase view)
	{
		this.ParentView = view;
	}

	// Token: 0x0400A050 RID: 41040
	[Nullable(1)]
	private IRoleSkillTreeInfoItemData RoleSkillTreeInfoItemData = new RoleSkillTreeInfoItemData();

	// Token: 0x0400A051 RID: 41041
	private RoleSkillData SkillData;

	// Token: 0x0400A052 RID: 41042
	private SkillTree? SkillTreeConfig;

	// Token: 0x0400A053 RID: 41043
	private int SkillId;

	// Token: 0x0400A054 RID: 41044
	private int UpgradeSkillId;

	// Token: 0x0400A055 RID: 41045
	private int ShowSkillId;

	// Token: 0x0400A056 RID: 41046
	private Aki.Config.Skill? SkillConfig;

	// Token: 0x0400A057 RID: 41047
	private Aki.Config.Skill? ShowSkillConfig;

	// Token: 0x0400A058 RID: 41048
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<CostMediumItemGrid, ISelectedData> ConsumeItemScroll;

	// Token: 0x0400A059 RID: 41049
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<RoleSkillTreeAttributeItem> CurrentLevelAttrScrollView;

	// Token: 0x0400A05A RID: 41050
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A05B RID: 41051
	private ButtonItem ConfirmButtonItem;

	// Token: 0x0400A05C RID: 41052
	private bool IsLevelUpPending;

	// Token: 0x0400A05D RID: 41053
	private RoleSkillInputPanel RoleSkillInputPanel;

	// Token: 0x0400A05E RID: 41054
	protected RoleBackgroundMusicSwitchItem RoleBackgroundMusicSwitchItem;

	// Token: 0x0400A05F RID: 41055
	private bool UseTexture;

	// Token: 0x0400A060 RID: 41056
	private bool IsShowRightPanel;

	// Token: 0x0400A061 RID: 41057
	private ESkillTabShowType CurSkillTabShowType = ESkillTabShowType.Introduction;

	// Token: 0x0400A062 RID: 41058
	[Nullable(1)]
	private readonly List<CommonAttributeData> CurAttributeDataList = new List<CommonAttributeData>();

	// Token: 0x0400A063 RID: 41059
	[Nullable(1)]
	private readonly List<CommonAttributeData> NextAttributeDataList = new List<CommonAttributeData>();

	// Token: 0x0400A064 RID: 41060
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400A065 RID: 41061
	private LevelSequencePlayer ConsumeLevelSequencePlayer;

	// Token: 0x0400A066 RID: 41062
	public Action OnBackBtnCallBack;

	// Token: 0x0400A067 RID: 41063
	private ERoleSkillDescType SkillDescType;

	// Token: 0x0400A068 RID: 41064
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ISelectedData> CachedConsumeList;

	// Token: 0x0400A069 RID: 41065
	private int ItemListLength;

	// Token: 0x0400A06A RID: 41066
	private bool IsShowSkillBranch;

	// Token: 0x0400A06B RID: 41067
	private bool IsSkillBranchEnable;

	// Token: 0x0400A06C RID: 41068
	private UiViewBase ParentView;

	// Token: 0x0400A06D RID: 41069
	private RoleSkillTreeInfoItem.RoleSkillBranchDetailItem BranchDetailItem;

	// Token: 0x0400A06E RID: 41070
	private NumberSelectComponent NumberSelectComponent;

	// Token: 0x0400A06F RID: 41071
	private int TargetLevel;

	// Token: 0x0400A070 RID: 41072
	private int MaxTargetLevel;

	// Token: 0x0400A071 RID: 41073
	private int CurrentSkillLevel;

	// Token: 0x0400A072 RID: 41074
	private int MaxSkillLevel;

	// Token: 0x0400A073 RID: 41075
	private int LastInitSnapshotSkillNodeId;

	// Token: 0x0400A074 RID: 41076
	private int LastInitSnapshotCurrentLevel = -1;

	// Token: 0x0400A075 RID: 41077
	private Dictionary<int, int> LastInitSnapshotItemCounts;

	// Token: 0x02008EC7 RID: 36551
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E4C6 RID: 189638
		IconSprite,
		// Token: 0x0402E4C7 RID: 189639
		IconTexture,
		// Token: 0x0402E4C8 RID: 189640
		SkillTypeText,
		// Token: 0x0402E4C9 RID: 189641
		LevelText,
		// Token: 0x0402E4CA RID: 189642
		IntroductionToggle,
		// Token: 0x0402E4CB RID: 189643
		AttrDetailToggle,
		// Token: 0x0402E4CC RID: 189644
		TogglesItem,
		// Token: 0x0402E4CD RID: 189645
		IntroductionItem,
		// Token: 0x0402E4CE RID: 189646
		AttrDetailScrollView,
		// Token: 0x0402E4CF RID: 189647
		SkillNameText,
		// Token: 0x0402E4D0 RID: 189648
		SkillDescText,
		// Token: 0x0402E4D1 RID: 189649
		ConsumeItemScroll,
		// Token: 0x0402E4D2 RID: 189650
		MoneyTexture,
		// Token: 0x0402E4D3 RID: 189651
		MoneyText,
		// Token: 0x0402E4D4 RID: 189652
		ConfirmButtonItem,
		// Token: 0x0402E4D5 RID: 189653
		ActivatedItem,
		// Token: 0x0402E4D6 RID: 189654
		ActivatedText,
		// Token: 0x0402E4D7 RID: 189655
		LockItem,
		// Token: 0x0402E4D8 RID: 189656
		ConditionText,
		// Token: 0x0402E4D9 RID: 189657
		RightPanelToggle,
		// Token: 0x0402E4DA RID: 189658
		NextLevelItem,
		// Token: 0x0402E4DB RID: 189659
		CaptionItem,
		// Token: 0x0402E4DC RID: 189660
		ConsumeItem,
		// Token: 0x0402E4DD RID: 189661
		ConsumeTextItem,
		// Token: 0x0402E4DE RID: 189662
		BackButton,
		// Token: 0x0402E4DF RID: 189663
		NextLevelMaskButton,
		// Token: 0x0402E4E0 RID: 189664
		LockTipBtn,
		// Token: 0x0402E4E1 RID: 189665
		RoleSkillInputRoot,
		// Token: 0x0402E4E2 RID: 189666
		RoleSkillInputPanel,
		// Token: 0x0402E4E3 RID: 189667
		RoleSkillMaskButton,
		// Token: 0x0402E4E4 RID: 189668
		SkillModeToggle,
		// Token: 0x0402E4E5 RID: 189669
		SkillModeItem,
		// Token: 0x0402E4E6 RID: 189670
		NextLevelText,
		// Token: 0x0402E4E7 RID: 189671
		SkillModeText,
		// Token: 0x0402E4E8 RID: 189672
		RoleBGMSwitchItem,
		// Token: 0x0402E4E9 RID: 189673
		BranchItem,
		// Token: 0x0402E4EA RID: 189674
		BranchText,
		// Token: 0x0402E4EB RID: 189675
		BtnBranchDetail,
		// Token: 0x0402E4EC RID: 189676
		ItemBranchDetailRoot,
		// Token: 0x0402E4ED RID: 189677
		BoxPanel,
		// Token: 0x0402E4EE RID: 189678
		FullLevelPanel,
		// Token: 0x0402E4EF RID: 189679
		SlideAmountText,
		// Token: 0x0402E4F0 RID: 189680
		NumControlItem,
		// Token: 0x0402E4F1 RID: 189681
		NextLevelMaxSprite,
		// Token: 0x0402E4F2 RID: 189682
		ConsumeItemContent,
		// Token: 0x0402E4F3 RID: 189683
		ConsumeItemGrid,
		// Token: 0x0402E4F4 RID: 189684
		BoxText,
		// Token: 0x0402E4F5 RID: 189685
		ConsumePanelItem
	}

	// Token: 0x02008EC8 RID: 36552
	[NullableContext(0)]
	public class RoleSkillBranchDetailItem : UiPanelBase
	{
		// Token: 0x0604B86E RID: 309358 RVA: 0x013DB98C File Offset: 0x013D9B8C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnCloseBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604B86F RID: 309359 RVA: 0x013DBA74 File Offset: 0x013D9C74
		[NullableContext(1)]
		public void Refresh(string desc)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), desc, Array.Empty<object>());
		}

		// Token: 0x0604B870 RID: 309360 RVA: 0x013DBA8D File Offset: 0x013D9C8D
		private void OnCloseBtnClick()
		{
			base.Hide(null);
		}

		// Token: 0x0200D05B RID: 53339
		private enum EComponent
		{
			// Token: 0x0403E95C RID: 256348
			ItemSelf,
			// Token: 0x0403E95D RID: 256349
			TextTitle,
			// Token: 0x0403E95E RID: 256350
			TextDesc,
			// Token: 0x0403E95F RID: 256351
			BtnClose
		}
	}
}
