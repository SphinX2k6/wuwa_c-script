using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002880 RID: 10368
[NullableContext(1)]
[Nullable(0)]
public class RoleExpItemGridComponent : UiPanelBase
{
	// Token: 0x06015556 RID: 87382 RVA: 0x00562BE9 File Offset: 0x00560DE9
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

	// Token: 0x06015557 RID: 87383 RVA: 0x00562C28 File Offset: 0x00560E28
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

	// Token: 0x06015558 RID: 87384 RVA: 0x00562D30 File Offset: 0x00560F30
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

	// Token: 0x06015559 RID: 87385 RVA: 0x00562D8C File Offset: 0x00560F8C
	private RoleLevelUpCostMediumItemGrid InitItem()
	{
		RoleLevelUpCostMediumItemGrid roleLevelUpCostMediumItemGrid = new RoleLevelUpCostMediumItemGrid();
		roleLevelUpCostMediumItemGrid.BindLongPress(LongPressButtonItem.ELongPressConfigId.LongPressOne, new Action<bool, ItemGridBase, object>(this.OnExtendToggleStateChanged), null);
		roleLevelUpCostMediumItemGrid.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
		roleLevelUpCostMediumItemGrid.BindReduceLongPress(new Action<bool, MediumItemGrid, object>(this.OnReduceButtonCallback));
		return roleLevelUpCostMediumItemGrid;
	}

	// Token: 0x0601555A RID: 87386 RVA: 0x00562DEC File Offset: 0x00560FEC
	private void OnExtendToggleStateChanged(bool isShortPress, ItemGridBase itemGrid, object data)
	{
		int itemId = ((ISelectedData)data).ItemId;
		if (!isShortPress && !this.CanItemLongPress(itemId))
		{
			return;
		}
		this.ItemClickCallBack(itemId);
	}

	// Token: 0x0601555B RID: 87387 RVA: 0x00562E24 File Offset: 0x00561024
	private void OnReduceButtonCallback(bool isShortPress, MediumItemGrid mediumItemGrid, [Nullable(2)] object data)
	{
		int itemId = ((ISelectedData)data).ItemId;
		if (!this.CanItemReduceLongPress(itemId))
		{
			return;
		}
		this.ItemReduceCallBack(itemId);
	}

	// Token: 0x0601555C RID: 87388 RVA: 0x00562E58 File Offset: 0x00561058
	public void Update(List<ISelectedData> dataList, int moneyId, int needMoney)
	{
		this.UpdateByDataList(dataList);
		this.UpdateMoney(moneyId, needMoney);
	}

	// Token: 0x0601555D RID: 87389 RVA: 0x00562E69 File Offset: 0x00561069
	public void UpdateByDataList(List<ISelectedData> dataList)
	{
		this.DataList = dataList;
		this.ScrollView.RefreshByData(this.DataList, null, false);
		this.UpdateAutoButtonState();
	}

	// Token: 0x0601555E RID: 87390 RVA: 0x00562E8C File Offset: 0x0056108C
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

	// Token: 0x0601555F RID: 87391 RVA: 0x00562F1F File Offset: 0x0056111F
	public bool GetIsMoneyEnough()
	{
		return this.IsMoneyEnough;
	}

	// Token: 0x06015560 RID: 87392 RVA: 0x00562F28 File Offset: 0x00561128
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

	// Token: 0x06015561 RID: 87393 RVA: 0x00562F9C File Offset: 0x0056119C
	public EAutoButtonState GetAutoButtonState()
	{
		return this.AutoButtonState;
	}

	// Token: 0x06015562 RID: 87394 RVA: 0x00562FA4 File Offset: 0x005611A4
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ISelectedData> GetDataList()
	{
		return this.DataList;
	}

	// Token: 0x06015563 RID: 87395 RVA: 0x00562FAC File Offset: 0x005611AC
	public void SetMaxItemActive(bool bActive)
	{
		base.GetItem(12).SetUIActive(bActive);
	}

	// Token: 0x06015564 RID: 87396 RVA: 0x00562FBC File Offset: 0x005611BC
	public void SetLockItemActive(bool bActive)
	{
		base.GetItem(13).SetUIActive(bActive);
	}

	// Token: 0x06015565 RID: 87397 RVA: 0x00562FCC File Offset: 0x005611CC
	public void SetButtonItemActive(bool bActive)
	{
		this.ButtonItem.SetActive(bActive);
	}

	// Token: 0x06015566 RID: 87398 RVA: 0x00562FDA File Offset: 0x005611DA
	public void SetMaxText(string textId)
	{
	}

	// Token: 0x06015567 RID: 87399 RVA: 0x00562FDC File Offset: 0x005611DC
	public void SetLockText(string textId)
	{
	}

	// Token: 0x06015568 RID: 87400 RVA: 0x00562FDE File Offset: 0x005611DE
	public void SetButtonItemText(string textId)
	{
		this.ButtonItem.SetLocalText(textId, Array.Empty<object>());
	}

	// Token: 0x06015569 RID: 87401 RVA: 0x00562FF1 File Offset: 0x005611F1
	public void SetAutoButtonText(string textId)
	{
		base.GetText(15).ShowTextNew(textId);
	}

	// Token: 0x0601556A RID: 87402 RVA: 0x00563001 File Offset: 0x00561201
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

	// Token: 0x0601556B RID: 87403 RVA: 0x00563009 File Offset: 0x00561209
	private void OnClickAutoButton()
	{
		this.AutoBtnClick();
	}

	// Token: 0x04009F77 RID: 40823
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericScrollViewNew<RoleLevelUpCostMediumItemGrid, ISelectedData> ScrollView;

	// Token: 0x04009F78 RID: 40824
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ISelectedData> DataList;

	// Token: 0x04009F79 RID: 40825
	private int MoneyId;

	// Token: 0x04009F7A RID: 40826
	private int NeedMoney;

	// Token: 0x04009F7B RID: 40827
	[Nullable(2)]
	private ButtonItem ButtonItem;

	// Token: 0x04009F7C RID: 40828
	private EAutoButtonState AutoButtonState;

	// Token: 0x04009F7D RID: 40829
	private bool IsMoneyEnough;

	// Token: 0x04009F7E RID: 40830
	private readonly Action LevelUpClickCallBack;

	// Token: 0x04009F7F RID: 40831
	private readonly Action AutoBtnClick;

	// Token: 0x04009F80 RID: 40832
	private readonly Action<int> ItemClickCallBack;

	// Token: 0x04009F81 RID: 40833
	private readonly Action<int> ItemReduceCallBack;

	// Token: 0x04009F82 RID: 40834
	private readonly Func<int, bool> CanItemLongPress;

	// Token: 0x04009F83 RID: 40835
	private readonly Func<int, bool> CanItemReduceLongPress;

	// Token: 0x04009F84 RID: 40836
	public EUiViewName? BelongView;
}
