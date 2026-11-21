using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Manufacture.Compose;
using CSharpScript.Game.Module.RoleUi.RoleBreach;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D21 RID: 7457
[NullableContext(1)]
[Nullable(0)]
public class CostItemGridComponent : UiPanelBase
{
	// Token: 0x06012794 RID: 75668 RVA: 0x00575287 File Offset: 0x00573487
	public CostItemGridComponent(UUIItem uiItem, Action<int> levelUpClickCallBack, [Nullable(2)] Action lockTipClickCallBack = null, EUiViewName? belongView = null)
	{
		this.LevelUpClickCallBack = levelUpClickCallBack;
		this.LockTipClickCallBack = lockTipClickCallBack;
		this.BelongView = belongView;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06012795 RID: 75669 RVA: 0x005752B4 File Offset: 0x005734B4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		if (this.LockTipClickCallBack != null)
		{
			this.BtnBindInfo.Add(new ValueTuple<int, Delegate>(17, this.LockTipClickCallBack));
		}
	}

	// Token: 0x06012796 RID: 75670 RVA: 0x00575490 File Offset: 0x00573690
	protected override void OnStart()
	{
		this.ButtonItem = new ButtonItem(base.GetItem(11));
		this.ButtonItem.SetFunction(this.LevelUpClickCallBack);
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
		this.ScrollView = new GenericScrollView<CostMediumItemGrid>(scrollViewWithScrollbar, new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CostMediumItemGrid>(this.InitItem), base.GetItem(4));
		UUIButtonComponent button = base.GetButton(17);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(this.LockTipClickCallBack != null);
	}

	// Token: 0x06012797 RID: 75671 RVA: 0x00575510 File Offset: 0x00573710
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private ILayoutItem<CostMediumItemGrid> InitItem(object data, UUIItem uiItem, int index)
	{
		CostMediumItemGrid costMediumItemGrid = new CostMediumItemGrid();
		costMediumItemGrid.Initialize(uiItem.GetOwner());
		costMediumItemGrid.Refresh((ISelectedData)data, false, index);
		costMediumItemGrid.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
		costMediumItemGrid.BindOnExtendToggleRelease(new Action<MediumItemGridExtendCallback>(this.OnExtendToggleStateChanged));
		return new LayoutItem<CostMediumItemGrid>
		{
			Key = index,
			Value = costMediumItemGrid
		};
	}

	// Token: 0x06012798 RID: 75672 RVA: 0x0057558C File Offset: 0x0057378C
	private void OnExtendToggleStateChanged(MediumItemGridExtendCallback callbackParameter)
	{
		ISelectedData selectedData = (ISelectedData)callbackParameter.Data;
		ItemController.Instance.OpenItemTipsByItemId(selectedData.ItemId, true, null, false);
		ComposeModel.Instance.ComposeSelectItem = selectedData;
		ComposeModel.Instance.ComposeSkipSourceView = this.BelongView;
		InventoryModel.Instance.SetItemNeedCount(new int?(selectedData.Count - selectedData.SelectedCount));
	}

	// Token: 0x06012799 RID: 75673 RVA: 0x005755EF File Offset: 0x005737EF
	public void Update(List<ISelectedData> dataList, int moneyId, int needMoney)
	{
		this.UpdateByDataList(dataList);
		this.UpdateMoney(moneyId, needMoney);
	}

	// Token: 0x0601279A RID: 75674 RVA: 0x00575600 File Offset: 0x00573800
	public void UpdateByDataList(List<ISelectedData> dataList)
	{
		this.DataList = dataList;
		this.ScrollView.RefreshByData<ISelectedData>(dataList, null);
	}

	// Token: 0x0601279B RID: 75675 RVA: 0x0057562C File Offset: 0x0057382C
	public void UpdateMoney(int moneyId, int needMoney)
	{
		this.MoneyId = moneyId;
		this.NeedMoney = needMoney;
		base.SetItemIcon(base.GetTexture(7), this.MoneyId, null, null);
		UUIText text = base.GetText(8);
		text.SetText(this.NeedMoney.ToString(), true);
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.MoneyId, 0);
		this.IsMoneyEnough = (itemCountByConfigId >= this.NeedMoney);
		UUIItem uuiitem = text;
		bool bUseChangeColor = !this.IsMoneyEnough;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x0601279C RID: 75676 RVA: 0x005756BF File Offset: 0x005738BF
	public bool GetIsMoneyEnough()
	{
		return this.IsMoneyEnough;
	}

	// Token: 0x0601279D RID: 75677 RVA: 0x005756C7 File Offset: 0x005738C7
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ISelectedData> GetDataList()
	{
		return this.DataList;
	}

	// Token: 0x0601279E RID: 75678 RVA: 0x005756CF File Offset: 0x005738CF
	public void SetMaxItemActive(bool active)
	{
		base.GetItem(12).SetUIActive(active);
	}

	// Token: 0x0601279F RID: 75679 RVA: 0x005756DF File Offset: 0x005738DF
	public void SetLockItemActive(bool active)
	{
		base.GetItem(13).SetUIActive(active);
	}

	// Token: 0x060127A0 RID: 75680 RVA: 0x005756EF File Offset: 0x005738EF
	public void SetButtonItemActive(bool active)
	{
		this.ButtonItem.SetActive(active);
	}

	// Token: 0x060127A1 RID: 75681 RVA: 0x005756FD File Offset: 0x005738FD
	public void SetLockLocalText(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(16), textId, args);
	}

	// Token: 0x060127A2 RID: 75682 RVA: 0x00575713 File Offset: 0x00573913
	public void SetButtonItemLocalText(string textId)
	{
		this.ButtonItem.SetLocalText(textId, Array.Empty<object>());
	}

	// Token: 0x060127A3 RID: 75683 RVA: 0x00575726 File Offset: 0x00573926
	public void SetButtonItemLocalTextNew(string textId)
	{
		this.ButtonItem.SetLocalTextNew(textId, Array.Empty<object>());
	}

	// Token: 0x060127A4 RID: 75684 RVA: 0x00575739 File Offset: 0x00573939
	public void SetButtonItemText(string text)
	{
		this.ButtonItem.SetText(text);
	}

	// Token: 0x060127A5 RID: 75685 RVA: 0x00575747 File Offset: 0x00573947
	public void SetButtonItemInteractive(bool interactive)
	{
		UUIButtonComponent btn = this.ButtonItem.GetBtn();
		if (btn == null)
		{
			return;
		}
		btn.SetSelfInteractive(interactive);
	}

	// Token: 0x0400A0BB RID: 41147
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollView<CostMediumItemGrid> ScrollView;

	// Token: 0x0400A0BC RID: 41148
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ISelectedData> DataList;

	// Token: 0x0400A0BD RID: 41149
	private int MoneyId;

	// Token: 0x0400A0BE RID: 41150
	private int NeedMoney;

	// Token: 0x0400A0BF RID: 41151
	[Nullable(2)]
	private ButtonItem ButtonItem;

	// Token: 0x0400A0C0 RID: 41152
	private bool IsMoneyEnough;

	// Token: 0x0400A0C1 RID: 41153
	private readonly Action<int> LevelUpClickCallBack;

	// Token: 0x0400A0C2 RID: 41154
	[Nullable(2)]
	private readonly Action LockTipClickCallBack;

	// Token: 0x0400A0C3 RID: 41155
	public readonly EUiViewName? BelongView;

	// Token: 0x02008068 RID: 32872
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040298C8 RID: 170184
		AddMaterialText,
		// Token: 0x040298C9 RID: 170185
		PanelButton,
		// Token: 0x040298CA RID: 170186
		ConditionButton,
		// Token: 0x040298CB RID: 170187
		AutoButton,
		// Token: 0x040298CC RID: 170188
		LoopItem,
		// Token: 0x040298CD RID: 170189
		ScrollView,
		// Token: 0x040298CE RID: 170190
		CostRootItem,
		// Token: 0x040298CF RID: 170191
		ConsumeTexture,
		// Token: 0x040298D0 RID: 170192
		ConsumeText,
		// Token: 0x040298D1 RID: 170193
		ConditionText,
		// Token: 0x040298D2 RID: 170194
		MaterialRootItem,
		// Token: 0x040298D3 RID: 170195
		StrengthItem,
		// Token: 0x040298D4 RID: 170196
		MaxItem,
		// Token: 0x040298D5 RID: 170197
		LockItem,
		// Token: 0x040298D6 RID: 170198
		TopButtons,
		// Token: 0x040298D7 RID: 170199
		AutoButtonText,
		// Token: 0x040298D8 RID: 170200
		LockText,
		// Token: 0x040298D9 RID: 170201
		LockTipButton
	}
}
