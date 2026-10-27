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

// Token: 0x020027A6 RID: 10150
[NullableContext(1)]
[Nullable(0)]
public class CostItemGridComponent : UiPanelBase
{
	// Token: 0x06014D9A RID: 85402 RVA: 0x0054A6FE File Offset: 0x005488FE
	public CostItemGridComponent(UUIItem uiItem, Action<int> levelUpClickCallBack, [Nullable(2)] Action lockTipClickCallBack = null, EUiViewName? belongView = null)
	{
		this.LevelUpClickCallBack = levelUpClickCallBack;
		this.LockTipClickCallBack = lockTipClickCallBack;
		this.BelongView = belongView;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06014D9B RID: 85403 RVA: 0x0054A72C File Offset: 0x0054892C
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

	// Token: 0x06014D9C RID: 85404 RVA: 0x0054A908 File Offset: 0x00548B08
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

	// Token: 0x06014D9D RID: 85405 RVA: 0x0054A988 File Offset: 0x00548B88
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

	// Token: 0x06014D9E RID: 85406 RVA: 0x0054AA04 File Offset: 0x00548C04
	private void OnExtendToggleStateChanged(MediumItemGridExtendCallback callbackParameter)
	{
		ISelectedData selectedData = (ISelectedData)callbackParameter.Data;
		ItemController.Instance.OpenItemTipsByItemId(selectedData.ItemId, true, null);
		ComposeModel.Instance.ComposeSelectItem = selectedData;
		ComposeModel.Instance.ComposeSkipSourceView = this.BelongView;
		InventoryModel.Instance.SetItemNeedCount(new int?(selectedData.Count - selectedData.SelectedCount));
	}

	// Token: 0x06014D9F RID: 85407 RVA: 0x0054AA66 File Offset: 0x00548C66
	public void Update(List<ISelectedData> dataList, int moneyId, int needMoney)
	{
		this.UpdateByDataList(dataList);
		this.UpdateMoney(moneyId, needMoney);
	}

	// Token: 0x06014DA0 RID: 85408 RVA: 0x0054AA78 File Offset: 0x00548C78
	public void UpdateByDataList(List<ISelectedData> dataList)
	{
		this.DataList = dataList;
		this.ScrollView.RefreshByData<ISelectedData>(dataList, null);
	}

	// Token: 0x06014DA1 RID: 85409 RVA: 0x0054AAA4 File Offset: 0x00548CA4
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

	// Token: 0x06014DA2 RID: 85410 RVA: 0x0054AB37 File Offset: 0x00548D37
	public bool GetIsMoneyEnough()
	{
		return this.IsMoneyEnough;
	}

	// Token: 0x06014DA3 RID: 85411 RVA: 0x0054AB3F File Offset: 0x00548D3F
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ISelectedData> GetDataList()
	{
		return this.DataList;
	}

	// Token: 0x06014DA4 RID: 85412 RVA: 0x0054AB47 File Offset: 0x00548D47
	public void SetMaxItemActive(bool active)
	{
		base.GetItem(12).SetUIActive(active);
	}

	// Token: 0x06014DA5 RID: 85413 RVA: 0x0054AB57 File Offset: 0x00548D57
	public void SetLockItemActive(bool active)
	{
		base.GetItem(13).SetUIActive(active);
	}

	// Token: 0x06014DA6 RID: 85414 RVA: 0x0054AB67 File Offset: 0x00548D67
	public void SetButtonItemActive(bool active)
	{
		this.ButtonItem.SetActive(active);
	}

	// Token: 0x06014DA7 RID: 85415 RVA: 0x0054AB75 File Offset: 0x00548D75
	public void SetLockLocalText(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(16), textId, args);
	}

	// Token: 0x06014DA8 RID: 85416 RVA: 0x0054AB8B File Offset: 0x00548D8B
	public void SetButtonItemLocalText(string textId)
	{
		this.ButtonItem.SetLocalText(textId, Array.Empty<object>());
	}

	// Token: 0x06014DA9 RID: 85417 RVA: 0x0054AB9E File Offset: 0x00548D9E
	public void SetButtonItemLocalTextNew(string textId)
	{
		this.ButtonItem.SetLocalTextNew(textId, Array.Empty<object>());
	}

	// Token: 0x06014DAA RID: 85418 RVA: 0x0054ABB1 File Offset: 0x00548DB1
	public void SetButtonItemText(string text)
	{
		this.ButtonItem.SetText(text);
	}

	// Token: 0x06014DAB RID: 85419 RVA: 0x0054ABBF File Offset: 0x00548DBF
	public void SetButtonItemInteractive(bool interactive)
	{
		UUIButtonComponent btn = this.ButtonItem.GetBtn();
		if (btn == null)
		{
			return;
		}
		btn.SetSelfInteractive(interactive);
	}

	// Token: 0x04009CD8 RID: 40152
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollView<CostMediumItemGrid> ScrollView;

	// Token: 0x04009CD9 RID: 40153
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ISelectedData> DataList;

	// Token: 0x04009CDA RID: 40154
	private int MoneyId;

	// Token: 0x04009CDB RID: 40155
	private int NeedMoney;

	// Token: 0x04009CDC RID: 40156
	[Nullable(2)]
	private ButtonItem ButtonItem;

	// Token: 0x04009CDD RID: 40157
	private bool IsMoneyEnough;

	// Token: 0x04009CDE RID: 40158
	private readonly Action<int> LevelUpClickCallBack;

	// Token: 0x04009CDF RID: 40159
	[Nullable(2)]
	private readonly Action LockTipClickCallBack;

	// Token: 0x04009CE0 RID: 40160
	public readonly EUiViewName? BelongView;

	// Token: 0x02008E1F RID: 36383
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E1CC RID: 188876
		AddMaterialText,
		// Token: 0x0402E1CD RID: 188877
		PanelButton,
		// Token: 0x0402E1CE RID: 188878
		ConditionButton,
		// Token: 0x0402E1CF RID: 188879
		AutoButton,
		// Token: 0x0402E1D0 RID: 188880
		LoopItem,
		// Token: 0x0402E1D1 RID: 188881
		ScrollView,
		// Token: 0x0402E1D2 RID: 188882
		CostRootItem,
		// Token: 0x0402E1D3 RID: 188883
		ConsumeTexture,
		// Token: 0x0402E1D4 RID: 188884
		ConsumeText,
		// Token: 0x0402E1D5 RID: 188885
		ConditionText,
		// Token: 0x0402E1D6 RID: 188886
		MaterialRootItem,
		// Token: 0x0402E1D7 RID: 188887
		StrengthItem,
		// Token: 0x0402E1D8 RID: 188888
		MaxItem,
		// Token: 0x0402E1D9 RID: 188889
		LockItem,
		// Token: 0x0402E1DA RID: 188890
		TopButtons,
		// Token: 0x0402E1DB RID: 188891
		AutoButtonText,
		// Token: 0x0402E1DC RID: 188892
		LockText,
		// Token: 0x0402E1DD RID: 188893
		LockTipButton
	}
}
