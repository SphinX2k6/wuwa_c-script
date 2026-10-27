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

// Token: 0x02000F38 RID: 3896
[NullableContext(2)]
[Nullable(0)]
public class AcquireView : UiViewBase
{
	// Token: 0x060062F1 RID: 25329 RVA: 0x00135C3C File Offset: 0x00133E3C
	[NullableContext(1)]
	public AcquireView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060062F2 RID: 25330 RVA: 0x00135C48 File Offset: 0x00133E48
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

	// Token: 0x060062F3 RID: 25331 RVA: 0x00135DC0 File Offset: 0x00133FC0
	[NullableContext(1)]
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		return new TableTextArgNew(TextConfig.Instance.GetTextContentIdById("UseCount"), new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x060062F4 RID: 25332 RVA: 0x00135DE1 File Offset: 0x00133FE1
	private void ValueChangeFunction(int selectValue)
	{
		if (this.AcquireData.GetRemainItemCount() > 0)
		{
			this.AcquireData.SetAmount(selectValue);
			return;
		}
		this.AcquireData.SetAmount(0);
	}

	// Token: 0x060062F5 RID: 25333 RVA: 0x00135E0C File Offset: 0x0013400C
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

	// Token: 0x060062F6 RID: 25334 RVA: 0x00135E94 File Offset: 0x00134094
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

	// Token: 0x060062F7 RID: 25335 RVA: 0x00135ED8 File Offset: 0x001340D8
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

	// Token: 0x060062F8 RID: 25336 RVA: 0x00135F78 File Offset: 0x00134178
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<AcquireData>(EEventName.RefreshAcquireView, new Action<AcquireData>(this.Refresh));
		EventSystem.Instance.Add(EEventName.OnShowRewardView, new Action(this.OnShowRewardView));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x060062F9 RID: 25337 RVA: 0x00135FD8 File Offset: 0x001341D8
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshAcquireView, new Action<AcquireData>(this.Refresh));
		EventSystem.Instance.Remove(EEventName.OnShowRewardView, new Action(this.OnShowRewardView));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x060062FA RID: 25338 RVA: 0x00136036 File Offset: 0x00134236
	private void OnShowRewardView()
	{
		IUiPopFrameInterface childPopView = this.ChildPopView;
		if (childPopView == null)
		{
			return;
		}
		childPopView.HidePopView();
	}

	// Token: 0x060062FB RID: 25339 RVA: 0x00136048 File Offset: 0x00134248
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

	// Token: 0x060062FC RID: 25340 RVA: 0x00136084 File Offset: 0x00134284
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

	// Token: 0x060062FD RID: 25341 RVA: 0x001360EC File Offset: 0x001342EC
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

	// Token: 0x060062FE RID: 25342 RVA: 0x00136270 File Offset: 0x00134470
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

	// Token: 0x060062FF RID: 25343 RVA: 0x001362B4 File Offset: 0x001344B4
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

	// Token: 0x06006300 RID: 25344 RVA: 0x0013632C File Offset: 0x0013452C
	private void RefreshButton()
	{
		string leftButtonTextTableId = this.AcquireData.GetLeftButtonTextTableId();
		LguiUtil.Instance.SetLocalText(this.LeftButtonText, leftButtonTextTableId ?? "AcquireCancel", Array.Empty<object>());
		string rightButtonTextTableId = this.AcquireData.GetRightButtonTextTableId();
		LguiUtil.Instance.SetLocalText(this.RightButtonText, rightButtonTextTableId ?? "AcquireConfirm", Array.Empty<object>());
	}

	// Token: 0x06006301 RID: 25345 RVA: 0x0013638F File Offset: 0x0013458F
	private void RefreshByAcquireData()
	{
		this.RefreshAmount();
		this.RefreshButton();
	}

	// Token: 0x06006302 RID: 25346 RVA: 0x001363A0 File Offset: 0x001345A0
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

	// Token: 0x06006303 RID: 25347 RVA: 0x00136407 File Offset: 0x00134607
	private void ClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06006304 RID: 25348 RVA: 0x00136410 File Offset: 0x00134610
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

	// Token: 0x06006305 RID: 25349 RVA: 0x00136440 File Offset: 0x00134640
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

	// Token: 0x06006306 RID: 25350 RVA: 0x0013646E File Offset: 0x0013466E
	private void OnClickMidButton()
	{
		this.ClickClose();
	}

	// Token: 0x04002CE1 RID: 11489
	private UUIText ItemNameText;

	// Token: 0x04002CE2 RID: 11490
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<CommonItemSmallItemGrid> GenericScrollView;

	// Token: 0x04002CE3 RID: 11491
	private UUIText LeftButtonText;

	// Token: 0x04002CE4 RID: 11492
	private UUIText RightButtonText;

	// Token: 0x04002CE5 RID: 11493
	private UUIText TitleText;

	// Token: 0x04002CE6 RID: 11494
	private AcquireData AcquireData;

	// Token: 0x04002CE7 RID: 11495
	private NumberSelectComponent NumberSelect;

	// Token: 0x02007583 RID: 30083
	[NullableContext(0)]
	public enum EAcquireViewDefine
	{
		// Token: 0x04026D93 RID: 159123
		GenericScrollView,
		// Token: 0x04026D94 RID: 159124
		LoopScrollItem,
		// Token: 0x04026D95 RID: 159125
		TitleText,
		// Token: 0x04026D96 RID: 159126
		LeftButton,
		// Token: 0x04026D97 RID: 159127
		RightButton,
		// Token: 0x04026D98 RID: 159128
		ItemNameText,
		// Token: 0x04026D99 RID: 159129
		LeftButtonText,
		// Token: 0x04026D9A RID: 159130
		RightButtonText,
		// Token: 0x04026D9B RID: 159131
		MidButton,
		// Token: 0x04026D9C RID: 159132
		OpenNextButton,
		// Token: 0x04026D9D RID: 159133
		NumberSelect
	}
}
