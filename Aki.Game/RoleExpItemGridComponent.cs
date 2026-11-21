using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DFB RID: 7675
[NullableContext(1)]
[Nullable(0)]
public class RoleExpItemGridComponent : UiPanelBase
{
	// Token: 0x06012F54 RID: 77652 RVA: 0x0058D945 File Offset: 0x0058BB45
	public RoleExpItemGridComponent(Action levelUpClickCallBack, Action autoBtnClick, Action<int> itemClickCallBack, Action<int> itemReduceCallBack, Func<int, bool> canItemLongPress, Func<int, bool> canItemReduceLongPress, EUiViewName? belongView = null)
	{
		this.LevelUpClickCallBack = levelUpClickCallBack;
		this.AutoBtnClick = autoBtnClick;
		this.ItemClickCallBack = itemClickCallBack;
		this.ItemReduceCallBack = itemReduceCallBack;
		this.CanItemLongPress = canItemLongPress;
		this.CanItemReduceLongPress = canItemReduceLongPress;
		this.BelongView = belongView;
	}

	// Token: 0x06012F55 RID: 77653 RVA: 0x0058D984 File Offset: 0x0058BB84
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(7, typeof(UUITexture)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickAutoButton))
		};
	}

	// Token: 0x06012F56 RID: 77654 RVA: 0x0058DA8C File Offset: 0x0058BC8C
	protected override void OnStart()
	{
		this.ButtonItem = new ButtonItem(base.GetItem(11));
		this.ButtonItem.SetFunction(delegate(int _)
		{
			this.LevelUpClickCallBack();
		});
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
		this.ScrollView = new GenericScrollViewNew<RoleLevelUpCostMediumItemGrid, ISelectedData>(scrollViewWithScrollbar, new Func<RoleLevelUpCostMediumItemGrid>(this.InitItem), null, false, null);
	}

	// Token: 0x06012F57 RID: 77655 RVA: 0x0058DAE8 File Offset: 0x0058BCE8
	private RoleLevelUpCostMediumItemGrid InitItem()
	{
		RoleLevelUpCostMediumItemGrid roleLevelUpCostMediumItemGrid = new RoleLevelUpCostMediumItemGrid();
		roleLevelUpCostMediumItemGrid.BindLongPress(LongPressButtonItem.ELongPressConfigId.LongPressOne, new Action<bool, ItemGridBase, object>(this.OnExtendToggleStateChanged), null);
		roleLevelUpCostMediumItemGrid.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
		roleLevelUpCostMediumItemGrid.BindReduceLongPress(new Action<bool, MediumItemGrid, object>(this.OnReduceButtonCallback));
		return roleLevelUpCostMediumItemGrid;
	}

	// Token: 0x06012F58 RID: 77656 RVA: 0x0058DB48 File Offset: 0x0058BD48
	private void OnExtendToggleStateChanged(bool isShortPress, ItemGridBase itemGrid, object data)
	{
		int itemId = ((ISelectedData)data).ItemId;
		if (!isShortPress && !this.CanItemLongPress(itemId))
		{
			return;
		}
		this.ItemClickCallBack(itemId);
	}

	// Token: 0x06012F59 RID: 77657 RVA: 0x0058DB80 File Offset: 0x0058BD80
	private void OnReduceButtonCallback(bool isShortPress, MediumItemGrid mediumItemGrid, [Nullable(2)] object data)
	{
		int itemId = ((ISelectedData)data).ItemId;
		if (!this.CanItemReduceLongPress(itemId))
		{
			return;
		}
		this.ItemReduceCallBack(itemId);
	}

	// Token: 0x06012F5A RID: 77658 RVA: 0x0058DBB4 File Offset: 0x0058BDB4
	public void Update(List<ISelectedData> dataList, int moneyId, int needMoney)
	{
		this.UpdateByDataList(dataList);
		this.UpdateMoney(moneyId, needMoney);
	}

	// Token: 0x06012F5B RID: 77659 RVA: 0x0058DBC5 File Offset: 0x0058BDC5
	public void UpdateByDataList(List<ISelectedData> dataList)
	{
		this.DataList = dataList;
		this.ScrollView.RefreshByData(this.DataList, null, false);
		this.UpdateAutoButtonState();
	}

	// Token: 0x06012F5C RID: 77660 RVA: 0x0058DBE8 File Offset: 0x0058BDE8
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

	// Token: 0x06012F5D RID: 77661 RVA: 0x0058DC7B File Offset: 0x0058BE7B
	public bool GetIsMoneyEnough()
	{
		return this.IsMoneyEnough;
	}

	// Token: 0x06012F5E RID: 77662 RVA: 0x0058DC84 File Offset: 0x0058BE84
	public void UpdateAutoButtonState()
	{
		if (this.DataList == null)
		{
			this.AutoButtonState = EAutoButtonState.AutoAdd;
			return;
		}
		using (List<ISelectedData>.Enumerator enumerator = this.DataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.SelectedCount > 0)
				{
					this.AutoButtonState = EAutoButtonState.Clear;
					return;
				}
			}
		}
		this.AutoButtonState = EAutoButtonState.AutoAdd;
	}

	// Token: 0x06012F5F RID: 77663 RVA: 0x0058DCF8 File Offset: 0x0058BEF8
	public EAutoButtonState GetAutoButtonState()
	{
		return this.AutoButtonState;
	}

	// Token: 0x06012F60 RID: 77664 RVA: 0x0058DD00 File Offset: 0x0058BF00
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ISelectedData> GetDataList()
	{
		return this.DataList;
	}

	// Token: 0x06012F61 RID: 77665 RVA: 0x0058DD08 File Offset: 0x0058BF08
	public void SetMaxItemActive(bool bActive)
	{
		base.GetItem(12).SetUIActive(bActive);
	}

	// Token: 0x06012F62 RID: 77666 RVA: 0x0058DD18 File Offset: 0x0058BF18
	public void SetLockItemActive(bool bActive)
	{
		base.GetItem(13).SetUIActive(bActive);
	}

	// Token: 0x06012F63 RID: 77667 RVA: 0x0058DD28 File Offset: 0x0058BF28
	public void SetButtonItemActive(bool bActive)
	{
		this.ButtonItem.SetActive(bActive);
	}

	// Token: 0x06012F64 RID: 77668 RVA: 0x0058DD36 File Offset: 0x0058BF36
	public void SetMaxText(string textId)
	{
	}

	// Token: 0x06012F65 RID: 77669 RVA: 0x0058DD38 File Offset: 0x0058BF38
	public void SetLockText(string textId)
	{
	}

	// Token: 0x06012F66 RID: 77670 RVA: 0x0058DD3A File Offset: 0x0058BF3A
	public void SetButtonItemText(string textId)
	{
		this.ButtonItem.SetLocalText(textId, Array.Empty<object>());
	}

	// Token: 0x06012F67 RID: 77671 RVA: 0x0058DD4D File Offset: 0x0058BF4D
	public void SetAutoButtonText(string textId)
	{
		base.GetText(15).ShowTextNew(textId);
	}

	// Token: 0x06012F68 RID: 77672 RVA: 0x0058DD5D File Offset: 0x0058BF5D
	[return: Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public GenericScrollViewNew<RoleLevelUpCostMediumItemGrid, ISelectedData> GetGenericScrollView()
	{
		return this.ScrollView;
	}

	// Token: 0x06012F69 RID: 77673 RVA: 0x0058DD65 File Offset: 0x0058BF65
	private void OnClickAutoButton()
	{
		this.AutoBtnClick();
	}

	// Token: 0x0400A360 RID: 41824
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericScrollViewNew<RoleLevelUpCostMediumItemGrid, ISelectedData> ScrollView;

	// Token: 0x0400A361 RID: 41825
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ISelectedData> DataList;

	// Token: 0x0400A362 RID: 41826
	private int MoneyId;

	// Token: 0x0400A363 RID: 41827
	private int NeedMoney;

	// Token: 0x0400A364 RID: 41828
	[Nullable(2)]
	private ButtonItem ButtonItem;

	// Token: 0x0400A365 RID: 41829
	private EAutoButtonState AutoButtonState;

	// Token: 0x0400A366 RID: 41830
	private bool IsMoneyEnough;

	// Token: 0x0400A367 RID: 41831
	private readonly Action LevelUpClickCallBack;

	// Token: 0x0400A368 RID: 41832
	private readonly Action AutoBtnClick;

	// Token: 0x0400A369 RID: 41833
	private readonly Action<int> ItemClickCallBack;

	// Token: 0x0400A36A RID: 41834
	private readonly Action<int> ItemReduceCallBack;

	// Token: 0x0400A36B RID: 41835
	private readonly Func<int, bool> CanItemLongPress;

	// Token: 0x0400A36C RID: 41836
	private readonly Func<int, bool> CanItemReduceLongPress;

	// Token: 0x0400A36D RID: 41837
	public EUiViewName? BelongView;
}
