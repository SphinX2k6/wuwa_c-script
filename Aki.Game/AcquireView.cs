using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020003ED RID: 1005
[NullableContext(2)]
[Nullable(0)]
public class AcquireView : UiViewBase
{
	// Token: 0x06003689 RID: 13961 RVA: 0x0013E564 File Offset: 0x0013C764
	[NullableContext(1)]
	public AcquireView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600368A RID: 13962 RVA: 0x0013E570 File Offset: 0x0013C770
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickRightButton)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickLeftButton)),
			new ValueTuple<int, Delegate>(8, new Action(this.OnClickMidButton)),
			new ValueTuple<int, Delegate>(9, new Action(this.OnClickLeftButton))
		};
	}

	// Token: 0x0600368B RID: 13963 RVA: 0x0013E6E8 File Offset: 0x0013C8E8
	[NullableContext(1)]
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		return new TableTextArgNew(TextConfig.Instance.GetTextContentIdById("UseCount"), new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x0600368C RID: 13964 RVA: 0x0013E709 File Offset: 0x0013C909
	private void ValueChangeFunction(int selectValue)
	{
		if (this.AcquireData.GetRemainItemCount() > 0)
		{
			this.AcquireData.SetAmount(selectValue);
			return;
		}
		this.AcquireData.SetAmount(0);
	}

	// Token: 0x0600368D RID: 13965 RVA: 0x0013E734 File Offset: 0x0013C934
	private void InitNumberSelect()
	{
		this.NumberSelect = new NumberSelectComponent(base.GetItem(10));
		int maxAmount = this.AcquireData.GetMaxAmount();
		INumberSelectData data = new INumberSelectData
		{
			MaxNumber = maxAmount,
			GetExchangeTableText = new Func<int, TableTextArgNew>(this.GetExchangeTableText),
			ValueChangeFunction = new Action<int>(this.ValueChangeFunction)
		};
		if (this.CheckIfGiftItem())
		{
			this.NumberSelect.SetLimitMaxValue(CommonConfig.Instance.GetGiftMaxNineNineNine());
		}
		this.NumberSelect.Init(data);
	}

	// Token: 0x0600368E RID: 13966 RVA: 0x0013E7BC File Offset: 0x0013C9BC
	private bool CheckIfGiftItem()
	{
		int configId = this.AcquireData.GetConfigId();
		if (configId == 0)
		{
			return false;
		}
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(configId);
		if (itemConfigData == null)
		{
			return false;
		}
		InventoryDefine.EItemType? itemType = itemConfigData.ItemType;
		return itemType.GetValueOrDefault() == InventoryDefine.EItemType.Gift;
	}

	// Token: 0x0600368F RID: 13967 RVA: 0x0013E800 File Offset: 0x0013CA00
	protected override void OnStart()
	{
		this.AcquireData = (this.OpenParam as AcquireData);
		this.ItemNameText = base.GetText(5);
		this.RightButtonText = base.GetText(7);
		this.TitleText = base.GetText(2);
		this.InitNumberSelect();
		this.GenericScrollView = new GenericScrollView<CommonItemSmallItemGrid>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CommonItemSmallItemGrid>(this.CreatePropItem), base.GetItem(1));
		List<TItem> itemData = this.AcquireData.GetItemData();
		this.GenericScrollView.RefreshByData<TItem>(itemData, null);
		this.RefreshButtonState();
		this.RefreshByAcquireData();
	}

	// Token: 0x06003690 RID: 13968 RVA: 0x0013E8A0 File Offset: 0x0013CAA0
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<AcquireData>(EEventName.RefreshAcquireView, new Action<AcquireData>(this.Refresh));
		EventSystem.Instance.Add(EEventName.OnShowRewardView, new Action(this.OnShowRewardView));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x06003691 RID: 13969 RVA: 0x0013E900 File Offset: 0x0013CB00
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshAcquireView, new Action<AcquireData>(this.Refresh));
		EventSystem.Instance.Remove(EEventName.OnShowRewardView, new Action(this.OnShowRewardView));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x06003692 RID: 13970 RVA: 0x0013E95E File Offset: 0x0013CB5E
	private void OnShowRewardView()
	{
		IUiPopFrameInterface childPopView = this.ChildPopView;
		if (childPopView == null)
		{
			return;
		}
		childPopView.HidePopView();
	}

	// Token: 0x06003693 RID: 13971 RVA: 0x0013E970 File Offset: 0x0013CB70
	private void OnCloseView(EUiViewName viewName, int i)
	{
		if (viewName == EUiViewName.CommonRewardView || viewName == EUiViewName.CompositeRewardView || viewName == EUiViewName.ExploreRewardView)
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView == null)
			{
				return;
			}
			childPopView.ShowPopView();
		}
	}

	// Token: 0x06003694 RID: 13972 RVA: 0x0013E9AC File Offset: 0x0013CBAC
	[NullableContext(1)]
	private void Refresh(AcquireData acquireData)
	{
		if (acquireData.GetRemainItemCount() <= 0)
		{
			base.CloseMe(null);
			return;
		}
		this.AcquireData = acquireData;
		List<TItem> itemData = this.AcquireData.GetItemData();
		this.GenericScrollView.RefreshByData<TItem>(itemData, null);
		this.RefreshButtonState();
		this.RefreshByAcquireData();
		this.NumberSelect.Refresh(this.AcquireData.GetRemainItemCount());
	}

	// Token: 0x06003695 RID: 13973 RVA: 0x0013EA14 File Offset: 0x0013CC14
	protected void RefreshButtonState()
	{
		bool leftButtonFunction = this.AcquireData.GetLeftButtonFunction() != null;
		Func<UniTask> rightButtonFunction = this.AcquireData.GetRightButtonFunction();
		UUIButtonComponent button = base.GetButton(3);
		UUIButtonComponent button2 = base.GetButton(4);
		UUIButtonComponent button3 = base.GetButton(8);
		UUIButtonComponent button4 = base.GetButton(9);
		if (!leftButtonFunction && rightButtonFunction == null)
		{
			button.RootUIComp.Get().SetUIActive(false);
			button2.RootUIComp.Get().SetUIActive(false);
			button4.RootUIComp.Get().SetUIActive(false);
			button3.RootUIComp.Get().SetUIActive(true);
			return;
		}
		int acquireViewType = (int)this.AcquireData.GetAcquireViewType();
		button2.RootUIComp.Get().SetUIActive(true);
		button3.RootUIComp.Get().SetUIActive(false);
		if (acquireViewType == 2)
		{
			button4.RootUIComp.Get().SetUIActive(true);
			button.RootUIComp.Get().SetUIActive(false);
			button2.RootUIComp.Get().SetUIActive(true);
			button3.RootUIComp.Get().SetUIActive(false);
			return;
		}
		button4.RootUIComp.Get().SetUIActive(false);
		button.RootUIComp.Get().SetUIActive(true);
		button2.RootUIComp.Get().SetUIActive(true);
		button3.RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06003696 RID: 13974 RVA: 0x0013EB98 File Offset: 0x0013CD98
	[NullableContext(1)]
	private ILayoutItem<CommonItemSmallItemGrid> CreatePropItem(object data, UUIItem uiItem, int index)
	{
		CommonItemSmallItemGrid commonItemSmallItemGrid = new CommonItemSmallItemGrid();
		commonItemSmallItemGrid.Initialize(uiItem.GetOwner());
		commonItemSmallItemGrid.Refresh((TItem)data);
		return new LayoutItem<CommonItemSmallItemGrid>
		{
			Key = index,
			Value = commonItemSmallItemGrid
		};
	}

	// Token: 0x06003697 RID: 13975 RVA: 0x0013EBDC File Offset: 0x0013CDDC
	private void RefreshAmount()
	{
		bool flag = this.AcquireData.GetAcquireViewType() == EAcquireViewType.SelectAmount;
		this.ItemNameText.SetUIActive(flag);
		if (flag)
		{
			this.ItemNameText.SetText(this.AcquireData.GetNameText(), true);
			LguiUtil.Instance.SetLocalText(this.TitleText, "AcquireOpenCount", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalText(this.TitleText, "AcquireGetReward", Array.Empty<object>());
	}

	// Token: 0x06003698 RID: 13976 RVA: 0x0013EC54 File Offset: 0x0013CE54
	private void RefreshButton()
	{
		string leftButtonTextTableId = this.AcquireData.GetLeftButtonTextTableId();
		LguiUtil.Instance.SetLocalText(this.LeftButtonText, leftButtonTextTableId ?? "AcquireCancel", Array.Empty<object>());
		string rightButtonTextTableId = this.AcquireData.GetRightButtonTextTableId();
		LguiUtil.Instance.SetLocalText(this.RightButtonText, rightButtonTextTableId ?? "AcquireConfirm", Array.Empty<object>());
	}

	// Token: 0x06003699 RID: 13977 RVA: 0x0013ECB7 File Offset: 0x0013CEB7
	private void RefreshByAcquireData()
	{
		this.RefreshAmount();
		this.RefreshButton();
	}

	// Token: 0x0600369A RID: 13978 RVA: 0x0013ECC8 File Offset: 0x0013CEC8
	protected override void OnBeforeDestroy()
	{
		Func<UniTask> midButtonFunction = this.AcquireData.GetMidButtonFunction();
		if (midButtonFunction != null)
		{
			midButtonFunction().Forget();
		}
		InventoryModel.Instance.SetAcquireData(null);
		this.ItemNameText = null;
		this.GenericScrollView.ClearChildren();
		this.GenericScrollView = null;
		this.LeftButtonText = null;
		this.RightButtonText = null;
		this.TitleText = null;
		this.AcquireData = null;
	}

	// Token: 0x0600369B RID: 13979 RVA: 0x0013ED2F File Offset: 0x0013CF2F
	private void ClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600369C RID: 13980 RVA: 0x0013ED38 File Offset: 0x0013CF38
	private void OnClickLeftButton()
	{
		Func<UniTask> leftButtonFunction = this.AcquireData.GetLeftButtonFunction();
		if (leftButtonFunction != null)
		{
			leftButtonFunction().Forget();
			return;
		}
		this.ClickClose();
	}

	// Token: 0x0600369D RID: 13981 RVA: 0x0013ED68 File Offset: 0x0013CF68
	private void OnClickRightButton()
	{
		Func<UniTask> rightButtonFunction = this.AcquireData.GetRightButtonFunction();
		if (rightButtonFunction != null)
		{
			rightButtonFunction().Forget();
			return;
		}
		this.ClickClose();
	}

	// Token: 0x0600369E RID: 13982 RVA: 0x0013ED96 File Offset: 0x0013CF96
	private void OnClickMidButton()
	{
		this.ClickClose();
	}

	// Token: 0x04002D7A RID: 11642
	private UUIText ItemNameText;

	// Token: 0x04002D7B RID: 11643
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<CommonItemSmallItemGrid> GenericScrollView;

	// Token: 0x04002D7C RID: 11644
	private UUIText LeftButtonText;

	// Token: 0x04002D7D RID: 11645
	private UUIText RightButtonText;

	// Token: 0x04002D7E RID: 11646
	private UUIText TitleText;

	// Token: 0x04002D7F RID: 11647
	private AcquireData AcquireData;

	// Token: 0x04002D80 RID: 11648
	private NumberSelectComponent NumberSelect;

	// Token: 0x02006717 RID: 26391
	[NullableContext(0)]
	public enum EAcquireViewDefine
	{
		// Token: 0x040220DE RID: 139486
		GenericScrollView,
		// Token: 0x040220DF RID: 139487
		LoopScrollItem,
		// Token: 0x040220E0 RID: 139488
		TitleText,
		// Token: 0x040220E1 RID: 139489
		LeftButton,
		// Token: 0x040220E2 RID: 139490
		RightButton,
		// Token: 0x040220E3 RID: 139491
		ItemNameText,
		// Token: 0x040220E4 RID: 139492
		LeftButtonText,
		// Token: 0x040220E5 RID: 139493
		RightButtonText,
		// Token: 0x040220E6 RID: 139494
		MidButton,
		// Token: 0x040220E7 RID: 139495
		OpenNextButton,
		// Token: 0x040220E8 RID: 139496
		NumberSelect
	}
}
