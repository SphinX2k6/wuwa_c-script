using System;
using System.Collections.Generic;
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

// Token: 0x02001E3D RID: 7741
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillTreeInfoItem : UiPanelBase
{
	// Token: 0x0601323C RID: 78396 RVA: 0x00597EF0 File Offset: 0x005960F0
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

	// Token: 0x0601323D RID: 78397 RVA: 0x005986CC File Offset: 0x005968CC
	protected override UniTask OnBeforeStartAsync()
	{
		RoleSkillTreeInfoItem.<OnBeforeStartAsync>d__40 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkillTreeInfoItem.<OnBeforeStartAsync>d__40>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601323E RID: 78398 RVA: 0x00598710 File Offset: 0x00596910
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

	// Token: 0x0601323F RID: 78399 RVA: 0x0059888B File Offset: 0x00596A8B
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(10));
	}

	// Token: 0x06013240 RID: 78400 RVA: 0x005988A0 File Offset: 0x00596AA0
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

	// Token: 0x06013241 RID: 78401 RVA: 0x00598945 File Offset: 0x00596B45
	public void OnCommonItemCountAnyChange()
	{
		if (this.IsLevelUpPending)
		{
			return;
		}
		this.Refresh();
	}

	// Token: 0x06013242 RID: 78402 RVA: 0x00598956 File Offset: 0x00596B56
	public void OnSkillTreeNodeLevelUp()
	{
		this.IsLevelUpPending = false;
		this.Refresh();
	}

	// Token: 0x06013243 RID: 78403 RVA: 0x00598965 File Offset: 0x00596B65
	private void OnBtnCloseClick()
	{
		Action onBackBtnCallBack = this.OnBackBtnCallBack;
		if (onBackBtnCallBack == null)
		{
			return;
		}
		onBackBtnCallBack();
	}

	// Token: 0x06013244 RID: 78404 RVA: 0x00598978 File Offset: 0x00596B78
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

	// Token: 0x06013245 RID: 78405 RVA: 0x005989D5 File Offset: 0x00596BD5
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

	// Token: 0x06013246 RID: 78406 RVA: 0x00598A0A File Offset: 0x00596C0A
	private void OnNextLevelMaskBtnClick()
	{
		this.IsShowRightPanel = false;
		EventSystem.Instance.Emit<bool>(EEventName.OnRoleSkillInputPanelVisible, this.IsShowRightPanel);
		base.GetExtendToggle(19).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.HideNextLevelItem();
		this.PlayRightPanelSequence(false);
	}

	// Token: 0x06013247 RID: 78407 RVA: 0x00598A48 File Offset: 0x00596C48
	private void OnRoleSkillMaskBtnClick()
	{
		this.IsShowRightPanel = false;
		EventSystem.Instance.Emit<bool>(EEventName.OnRoleSkillInputPanelVisible, this.IsShowRightPanel);
		base.GetExtendToggle(19).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.HideRoleSkillInputPanel();
		this.PlayRightPanelSequence(false);
	}

	// Token: 0x06013248 RID: 78408 RVA: 0x00598A86 File Offset: 0x00596C86
	private void OnIntroductionToggleClick(EToggleState toggleState)
	{
		this.CurSkillTabShowType = ESkillTabShowType.Introduction;
		this.ShowLeftPanelByTabType(this.CurSkillTabShowType);
	}

	// Token: 0x06013249 RID: 78409 RVA: 0x00598A9B File Offset: 0x00596C9B
	private void OnAttrDetailToggleClick(EToggleState toggleState)
	{
		this.CurSkillTabShowType = ESkillTabShowType.Detail;
		this.ShowLeftPanelByTabType(this.CurSkillTabShowType);
	}

	// Token: 0x0601324A RID: 78410 RVA: 0x00598AB0 File Offset: 0x00596CB0
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

	// Token: 0x0601324B RID: 78411 RVA: 0x00598B28 File Offset: 0x00596D28
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

	// Token: 0x0601324C RID: 78412 RVA: 0x00598C4C File Offset: 0x00596E4C
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

	// Token: 0x0601324D RID: 78413 RVA: 0x00598E44 File Offset: 0x00597044
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

	// Token: 0x0601324E RID: 78414 RVA: 0x00598EB5 File Offset: 0x005970B5
	private void QuickLevelUpRequest(int targetLevel)
	{
		this.IsLevelUpPending = true;
		RoleController.SendRoleSkillQuickLevelUpRequest(this.RoleSkillTreeInfoItemData.RoleId, this.RoleSkillTreeInfoItemData.SkillNodeId, targetLevel);
	}

	// Token: 0x0601324F RID: 78415 RVA: 0x00598EDA File Offset: 0x005970DA
	[NullableContext(1)]
	private List<ISelectedData> GetSelectedDataList()
	{
		return this.SortConsumeList(this.CachedConsumeList ?? new List<ISelectedData>());
	}

	// Token: 0x06013250 RID: 78416 RVA: 0x00598EF4 File Offset: 0x005970F4
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

	// Token: 0x06013251 RID: 78417 RVA: 0x00598F58 File Offset: 0x00597158
	[NullableContext(1)]
	private CostMediumItemGrid InitCostItem()
	{
		CostMediumItemGrid costMediumItemGrid = new CostMediumItemGrid();
		costMediumItemGrid.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback callbackParameter)
		{
			ISelectedData selectedData = callbackParameter.Data as ISelectedData;
			ItemController.Instance.OpenItemTipsByItemId(selectedData.ItemId, true, null, false);
			ComposeModel.Instance.ComposeSelectItem = selectedData;
			ComposeModel.Instance.ComposeSkipSourceView = new EUiViewName?(EUiViewName.RoleSkillTreeInfoView);
			InventoryModel.Instance.SetItemNeedCount(new int?(selectedData.Count - selectedData.SelectedCount));
		});
		costMediumItemGrid.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
		return costMediumItemGrid;
	}

	// Token: 0x06013252 RID: 78418 RVA: 0x00598FB4 File Offset: 0x005971B4
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

	// Token: 0x06013253 RID: 78419 RVA: 0x00599020 File Offset: 0x00597220
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

	// Token: 0x06013254 RID: 78420 RVA: 0x00599178 File Offset: 0x00597378
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

	// Token: 0x06013255 RID: 78421 RVA: 0x005991EC File Offset: 0x005973EC
	private void RefreshTrial()
	{
		base.GetItem(22).SetUIActive(false);
		base.GetItem(17).SetUIActive(false);
		base.GetItem(15).SetUIActive(false);
		this.ConfirmButtonItem.SetActive(false);
		base.GetExtendToggle(19).RootUIComp.Get().SetUIActive(false);
		this.CaptionItem.SetCurrencyItemVisible(false);
	}

	// Token: 0x06013256 RID: 78422 RVA: 0x00599258 File Offset: 0x00597458
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

	// Token: 0x06013257 RID: 78423 RVA: 0x00599364 File Offset: 0x00597564
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

	// Token: 0x06013258 RID: 78424 RVA: 0x005993C6 File Offset: 0x005975C6
	private void RefreshByInnerPassiveSkill()
	{
		this.UseTexture = false;
		this.RefreshByCanLevelUpSkill();
		this.RefreshSkillIcon();
	}

	// Token: 0x06013259 RID: 78425 RVA: 0x005993DB File Offset: 0x005975DB
	private void RefreshByInnerSkill()
	{
		this.UseTexture = false;
		this.RefreshByCanLevelUpSkill();
		this.RefreshSkillIcon();
	}

	// Token: 0x0601325A RID: 78426 RVA: 0x005993F0 File Offset: 0x005975F0
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

	// Token: 0x0601325B RID: 78427 RVA: 0x00599490 File Offset: 0x00597690
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

	// Token: 0x0601325C RID: 78428 RVA: 0x00599654 File Offset: 0x00597854
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

	// Token: 0x0601325D RID: 78429 RVA: 0x005996F8 File Offset: 0x005978F8
	private void RefreshConsume(int nextLevel = 1)
	{
		IEnumerable<DicIntInt?> roleSkillTreeConsume = RoleSkillConfig.Instance.GetRoleSkillTreeConsume(this.RoleSkillTreeInfoItemData.SkillNodeId, nextLevel);
		if (roleSkillTreeConsume == null || !NoLinq.Any<DicIntInt?>(roleSkillTreeConsume))
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
				SelectedData item = new SelectedData
				{
					ItemId = key,
					IncId = 0,
					Count = value,
					SelectedCount = InventoryModel.Instance.GetCommonItemCount(key, 0)
				};
				list.Add(item);
			}
		}
		this.CachedConsumeList = new List<ISelectedData>(list.Count);
		for (int i = 0; i < list.Count; i++)
		{
			ISelectedData selectedData = list[i];
			this.CachedConsumeList.Add(new SelectedData
			{
				ItemId = selectedData.ItemId,
				IncId = selectedData.IncId,
				Count = selectedData.Count,
				SelectedCount = selectedData.SelectedCount
			});
		}
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

	// Token: 0x0601325E RID: 78430 RVA: 0x00599918 File Offset: 0x00597B18
	[NullableContext(1)]
	private List<ISelectedData> SortConsumeList(List<ISelectedData> consumeList)
	{
		InventoryConfig inventoryConfig = InventoryConfig.Instance;
		return NoLinq.OrderByThenByDescendingToList<ISelectedData, int, int>(consumeList, (ISelectedData item) => (item.SelectedCount >= item.Count) ? 1 : 0, delegate(ISelectedData item)
		{
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = inventoryConfig.GetItemConfigData(item.ItemId);
			if (itemConfigData == null)
			{
				return 0;
			}
			return itemConfigData.QualityId;
		});
	}

	// Token: 0x0601325F RID: 78431 RVA: 0x00599968 File Offset: 0x00597B68
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

	// Token: 0x06013260 RID: 78432 RVA: 0x00599A9C File Offset: 0x00597C9C
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

	// Token: 0x06013261 RID: 78433 RVA: 0x00599C28 File Offset: 0x00597E28
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

	// Token: 0x06013262 RID: 78434 RVA: 0x00599DC0 File Offset: 0x00597FC0
	[NullableContext(1)]
	private CommonAttributeData CreateAttributeData(OneSkillEffect effect)
	{
		CommonAttributeData commonAttributeData = new CommonAttributeData();
		string skillAttributeNameByOneSkillEffect = RoleModel.Instance.GetSkillAttributeNameByOneSkillEffect(effect);
		commonAttributeData.AttrNameText = (ConfigMultiTextLang.GetLocalTextNew(skillAttributeNameByOneSkillEffect, null) ?? "");
		commonAttributeData.AttrBaseValue = RoleModel.Instance.GetSkillAttributeDescriptionByOneSkillEffect(effect);
		return commonAttributeData;
	}

	// Token: 0x06013263 RID: 78435 RVA: 0x00599E08 File Offset: 0x00598008
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

	// Token: 0x06013264 RID: 78436 RVA: 0x00599ED8 File Offset: 0x005980D8
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

	// Token: 0x06013265 RID: 78437 RVA: 0x0059A0EC File Offset: 0x005982EC
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

	// Token: 0x06013266 RID: 78438 RVA: 0x0059A1D8 File Offset: 0x005983D8
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

	// Token: 0x06013267 RID: 78439 RVA: 0x0059A25C File Offset: 0x0059845C
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

	// Token: 0x06013268 RID: 78440 RVA: 0x0059A29C File Offset: 0x0059849C
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

	// Token: 0x06013269 RID: 78441 RVA: 0x0059A348 File Offset: 0x00598548
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

	// Token: 0x0601326A RID: 78442 RVA: 0x0059A520 File Offset: 0x00598720
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

	// Token: 0x0601326B RID: 78443 RVA: 0x0059A578 File Offset: 0x00598778
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
				SelectedData item = new SelectedData
				{
					ItemId = key2,
					IncId = 0,
					Count = value2,
					SelectedCount = InventoryModel.Instance.GetCommonItemCount(key2, 0)
				};
				list.Add(item);
			}
		}
		this.CachedConsumeList = new List<ISelectedData>(list.Count);
		for (int j = 0; j < list.Count; j++)
		{
			ISelectedData selectedData = list[j];
			this.CachedConsumeList.Add(new SelectedData
			{
				ItemId = selectedData.ItemId,
				IncId = selectedData.IncId,
				Count = selectedData.Count,
				SelectedCount = selectedData.SelectedCount
			});
		}
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

	// Token: 0x0601326C RID: 78444 RVA: 0x0059A82C File Offset: 0x00598A2C
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

	// Token: 0x0601326D RID: 78445 RVA: 0x0059A9D8 File Offset: 0x00598BD8
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

	// Token: 0x0601326E RID: 78446 RVA: 0x0059AB5C File Offset: 0x00598D5C
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

	// Token: 0x0601326F RID: 78447 RVA: 0x0059ACA4 File Offset: 0x00598EA4
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

	// Token: 0x06013270 RID: 78448 RVA: 0x0059AD74 File Offset: 0x00598F74
	private SkillEffect GetSkillEffectByLevel(int level)
	{
		int skillId = this.SkillTreeConfig.Value.SkillId;
		if (skillId == 0)
		{
			return null;
		}
		return RoleModel.Instance.GetRoleSkillEffect(skillId, level);
	}

	// Token: 0x06013271 RID: 78449 RVA: 0x0059ADA8 File Offset: 0x00598FA8
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

	// Token: 0x06013272 RID: 78450 RVA: 0x0059AE5D File Offset: 0x0059905D
	public void ShowLeftPanelByTabType(ESkillTabShowType tabShowType)
	{
		if (tabShowType == ESkillTabShowType.Introduction)
		{
			this.ShowToIntroductionItem(true);
			return;
		}
		this.ShowToAttrDetailItem();
	}

	// Token: 0x06013273 RID: 78451 RVA: 0x0059AE74 File Offset: 0x00599074
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

	// Token: 0x06013274 RID: 78452 RVA: 0x0059AEE4 File Offset: 0x005990E4
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

	// Token: 0x06013275 RID: 78453 RVA: 0x0059AF51 File Offset: 0x00599151
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

	// Token: 0x06013276 RID: 78454 RVA: 0x0059AF8E File Offset: 0x0059918E
	private void ShowRoleSkillInputPanel()
	{
		base.GetItem(27).SetUIActive(true);
	}

	// Token: 0x06013277 RID: 78455 RVA: 0x0059AF9E File Offset: 0x0059919E
	private void HideRoleSkillInputPanel()
	{
		base.GetItem(27).SetUIActive(false);
	}

	// Token: 0x06013278 RID: 78456 RVA: 0x0059AFB0 File Offset: 0x005991B0
	private void ShowNextLevelItem()
	{
		base.GetItem(20).SetUIActive(true);
		foreach (RoleSkillTreeAttributeItem roleSkillTreeAttributeItem in this.CurrentLevelAttrScrollView.GetScrollItemList())
		{
			roleSkillTreeAttributeItem.SetNextLevelItem(true);
		}
	}

	// Token: 0x06013279 RID: 78457 RVA: 0x0059B014 File Offset: 0x00599214
	private void HideNextLevelItem()
	{
		base.GetItem(20).SetUIActive(false);
		foreach (RoleSkillTreeAttributeItem roleSkillTreeAttributeItem in this.CurrentLevelAttrScrollView.GetScrollItemList())
		{
			roleSkillTreeAttributeItem.SetNextLevelItem(false);
		}
	}

	// Token: 0x0601327A RID: 78458 RVA: 0x0059B078 File Offset: 0x00599278
	private void PlayRightPanelSequence(bool showState)
	{
		if (showState)
		{
			this.LevelSequencePlayer.PlayOrReplaySequenceByName("ViewShow", false, null);
			return;
		}
		this.LevelSequencePlayer.PlayOrReplaySequenceByName("ViewHide", false, null);
	}

	// Token: 0x0601327B RID: 78459 RVA: 0x0059B0C0 File Offset: 0x005992C0
	[NullableContext(1)]
	public void PlayItemSequence(string seq)
	{
		this.LevelSequencePlayer.PlayOrReplaySequenceByName(seq, false, null);
	}

	// Token: 0x0601327C RID: 78460 RVA: 0x0059B0E4 File Offset: 0x005992E4
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

	// Token: 0x0601327D RID: 78461 RVA: 0x0059B130 File Offset: 0x00599330
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

	// Token: 0x0601327E RID: 78462 RVA: 0x0059B19C File Offset: 0x0059939C
	protected override void OnHide()
	{
		this.IsShowRightPanel = false;
		this.CurSkillTabShowType = ESkillTabShowType.Introduction;
		this.ShowLeftPanelByTabType(this.CurSkillTabShowType);
	}

	// Token: 0x0601327F RID: 78463 RVA: 0x0059B1B8 File Offset: 0x005993B8
	public ESkillTabShowType GetCurSkillTabShowType()
	{
		return this.CurSkillTabShowType;
	}

	// Token: 0x06013280 RID: 78464 RVA: 0x0059B1C0 File Offset: 0x005993C0
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

	// Token: 0x06013281 RID: 78465 RVA: 0x0059B31A File Offset: 0x0059951A
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

	// Token: 0x06013282 RID: 78466 RVA: 0x0059B34B File Offset: 0x0059954B
	private void ShowSkillBranchItem(bool isActive)
	{
		base.GetItem(35).SetUIActive(this.IsSkillBranchEnable && this.IsShowSkillBranch && isActive);
	}

	// Token: 0x06013283 RID: 78467 RVA: 0x0059B36D File Offset: 0x0059956D
	public void OnRoleSkillBranchChanged()
	{
		this.RefreshSkillBranch();
		this.Refresh();
	}

	// Token: 0x06013284 RID: 78468 RVA: 0x0059B37B File Offset: 0x0059957B
	public void SetSkillBranchEnable(bool isEnable)
	{
		this.IsSkillBranchEnable = isEnable;
	}

	// Token: 0x06013285 RID: 78469 RVA: 0x0059B384 File Offset: 0x00599584
	public void SetParentView(UiViewBase view)
	{
		this.ParentView = view;
	}

	// Token: 0x0400A439 RID: 42041
	[Nullable(1)]
	private IRoleSkillTreeInfoItemData RoleSkillTreeInfoItemData = new RoleSkillTreeInfoItemData();

	// Token: 0x0400A43A RID: 42042
	private RoleSkillData SkillData;

	// Token: 0x0400A43B RID: 42043
	private SkillTree? SkillTreeConfig;

	// Token: 0x0400A43C RID: 42044
	private int SkillId;

	// Token: 0x0400A43D RID: 42045
	private int UpgradeSkillId;

	// Token: 0x0400A43E RID: 42046
	private int ShowSkillId;

	// Token: 0x0400A43F RID: 42047
	private Aki.Config.Skill? SkillConfig;

	// Token: 0x0400A440 RID: 42048
	private Aki.Config.Skill? ShowSkillConfig;

	// Token: 0x0400A441 RID: 42049
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<CostMediumItemGrid, ISelectedData> ConsumeItemScroll;

	// Token: 0x0400A442 RID: 42050
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<RoleSkillTreeAttributeItem> CurrentLevelAttrScrollView;

	// Token: 0x0400A443 RID: 42051
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A444 RID: 42052
	private ButtonItem ConfirmButtonItem;

	// Token: 0x0400A445 RID: 42053
	private bool IsLevelUpPending;

	// Token: 0x0400A446 RID: 42054
	private RoleSkillInputPanel RoleSkillInputPanel;

	// Token: 0x0400A447 RID: 42055
	protected RoleBackgroundMusicSwitchItem RoleBackgroundMusicSwitchItem;

	// Token: 0x0400A448 RID: 42056
	private bool UseTexture;

	// Token: 0x0400A449 RID: 42057
	private bool IsShowRightPanel;

	// Token: 0x0400A44A RID: 42058
	private ESkillTabShowType CurSkillTabShowType = ESkillTabShowType.Introduction;

	// Token: 0x0400A44B RID: 42059
	[Nullable(1)]
	private readonly List<CommonAttributeData> CurAttributeDataList = new List<CommonAttributeData>();

	// Token: 0x0400A44C RID: 42060
	[Nullable(1)]
	private readonly List<CommonAttributeData> NextAttributeDataList = new List<CommonAttributeData>();

	// Token: 0x0400A44D RID: 42061
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400A44E RID: 42062
	private LevelSequencePlayer ConsumeLevelSequencePlayer;

	// Token: 0x0400A44F RID: 42063
	public Action OnBackBtnCallBack;

	// Token: 0x0400A450 RID: 42064
	private ERoleSkillDescType SkillDescType;

	// Token: 0x0400A451 RID: 42065
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ISelectedData> CachedConsumeList;

	// Token: 0x0400A452 RID: 42066
	private int ItemListLength;

	// Token: 0x0400A453 RID: 42067
	private bool IsShowSkillBranch;

	// Token: 0x0400A454 RID: 42068
	private bool IsSkillBranchEnable;

	// Token: 0x0400A455 RID: 42069
	private UiViewBase ParentView;

	// Token: 0x0400A456 RID: 42070
	private RoleSkillTreeInfoItem.RoleSkillBranchDetailItem BranchDetailItem;

	// Token: 0x0400A457 RID: 42071
	private NumberSelectComponent NumberSelectComponent;

	// Token: 0x0400A458 RID: 42072
	private int TargetLevel;

	// Token: 0x0400A459 RID: 42073
	private int MaxTargetLevel;

	// Token: 0x0400A45A RID: 42074
	private int CurrentSkillLevel;

	// Token: 0x0400A45B RID: 42075
	private int MaxSkillLevel;

	// Token: 0x0400A45C RID: 42076
	private int LastInitSnapshotSkillNodeId;

	// Token: 0x0400A45D RID: 42077
	private int LastInitSnapshotCurrentLevel = -1;

	// Token: 0x0400A45E RID: 42078
	private Dictionary<int, int> LastInitSnapshotItemCounts;

	// Token: 0x0200810E RID: 33038
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029BC3 RID: 170947
		IconSprite,
		// Token: 0x04029BC4 RID: 170948
		IconTexture,
		// Token: 0x04029BC5 RID: 170949
		SkillTypeText,
		// Token: 0x04029BC6 RID: 170950
		LevelText,
		// Token: 0x04029BC7 RID: 170951
		IntroductionToggle,
		// Token: 0x04029BC8 RID: 170952
		AttrDetailToggle,
		// Token: 0x04029BC9 RID: 170953
		TogglesItem,
		// Token: 0x04029BCA RID: 170954
		IntroductionItem,
		// Token: 0x04029BCB RID: 170955
		AttrDetailScrollView,
		// Token: 0x04029BCC RID: 170956
		SkillNameText,
		// Token: 0x04029BCD RID: 170957
		SkillDescText,
		// Token: 0x04029BCE RID: 170958
		ConsumeItemScroll,
		// Token: 0x04029BCF RID: 170959
		MoneyTexture,
		// Token: 0x04029BD0 RID: 170960
		MoneyText,
		// Token: 0x04029BD1 RID: 170961
		ConfirmButtonItem,
		// Token: 0x04029BD2 RID: 170962
		ActivatedItem,
		// Token: 0x04029BD3 RID: 170963
		ActivatedText,
		// Token: 0x04029BD4 RID: 170964
		LockItem,
		// Token: 0x04029BD5 RID: 170965
		ConditionText,
		// Token: 0x04029BD6 RID: 170966
		RightPanelToggle,
		// Token: 0x04029BD7 RID: 170967
		NextLevelItem,
		// Token: 0x04029BD8 RID: 170968
		CaptionItem,
		// Token: 0x04029BD9 RID: 170969
		ConsumeItem,
		// Token: 0x04029BDA RID: 170970
		ConsumeTextItem,
		// Token: 0x04029BDB RID: 170971
		BackButton,
		// Token: 0x04029BDC RID: 170972
		NextLevelMaskButton,
		// Token: 0x04029BDD RID: 170973
		LockTipBtn,
		// Token: 0x04029BDE RID: 170974
		RoleSkillInputRoot,
		// Token: 0x04029BDF RID: 170975
		RoleSkillInputPanel,
		// Token: 0x04029BE0 RID: 170976
		RoleSkillMaskButton,
		// Token: 0x04029BE1 RID: 170977
		SkillModeToggle,
		// Token: 0x04029BE2 RID: 170978
		SkillModeItem,
		// Token: 0x04029BE3 RID: 170979
		NextLevelText,
		// Token: 0x04029BE4 RID: 170980
		SkillModeText,
		// Token: 0x04029BE5 RID: 170981
		RoleBGMSwitchItem,
		// Token: 0x04029BE6 RID: 170982
		BranchItem,
		// Token: 0x04029BE7 RID: 170983
		BranchText,
		// Token: 0x04029BE8 RID: 170984
		BtnBranchDetail,
		// Token: 0x04029BE9 RID: 170985
		ItemBranchDetailRoot,
		// Token: 0x04029BEA RID: 170986
		BoxPanel,
		// Token: 0x04029BEB RID: 170987
		FullLevelPanel,
		// Token: 0x04029BEC RID: 170988
		SlideAmountText,
		// Token: 0x04029BED RID: 170989
		NumControlItem,
		// Token: 0x04029BEE RID: 170990
		NextLevelMaxSprite,
		// Token: 0x04029BEF RID: 170991
		ConsumeItemContent,
		// Token: 0x04029BF0 RID: 170992
		ConsumeItemGrid,
		// Token: 0x04029BF1 RID: 170993
		BoxText,
		// Token: 0x04029BF2 RID: 170994
		ConsumePanelItem
	}

	// Token: 0x0200810F RID: 33039
	[NullableContext(0)]
	public class RoleSkillBranchDetailItem : UiPanelBase
	{
		// Token: 0x06041D6F RID: 269679 RVA: 0x01386C00 File Offset: 0x01384E00
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

		// Token: 0x06041D70 RID: 269680 RVA: 0x01386CE8 File Offset: 0x01384EE8
		[NullableContext(1)]
		public void Refresh(string desc)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), desc, Array.Empty<object>());
		}

		// Token: 0x06041D71 RID: 269681 RVA: 0x01386D01 File Offset: 0x01384F01
		private void OnCloseBtnClick()
		{
			base.Hide(null);
		}

		// Token: 0x0200BC39 RID: 48185
		private enum EComponent
		{
			// Token: 0x04039DA4 RID: 236964
			ItemSelf,
			// Token: 0x04039DA5 RID: 236965
			TextTitle,
			// Token: 0x04039DA6 RID: 236966
			TextDesc,
			// Token: 0x04039DA7 RID: 236967
			BtnClose
		}
	}
}
