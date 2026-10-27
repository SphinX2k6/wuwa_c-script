using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002CFD RID: 11517
[NullableContext(1)]
[Nullable(0)]
public class SingleItemSelect
{
	// Token: 0x0601833C RID: 99132 RVA: 0x006286A4 File Offset: 0x006268A4
	public void Init(UUIItem uiItem, ESingleItemSelectViewType openViewType = ESingleItemSelectViewType.Right)
	{
		this.ItemGridVariantSelect = new MediumItemGrid();
		this.ItemGridVariantSelect.Initialize(uiItem.GetOwner());
		EmptyItemGrid parameters = new EmptyItemGrid();
		this.ItemGridVariantSelect.Apply<EmptyItemGrid>(parameters);
		this.OpenViewType = openViewType;
		this.ItemGridVariantSelect.BindEmptySlotButtonCallback(delegate(MediumItemGridButtonCallback _)
		{
			this.OpenItemSelectView();
		});
		this.ItemGridVariantSelect.BindReduceButtonCallback(delegate(MediumItemGridButtonCallback _)
		{
			this.OpenItemSelectView();
		}, null);
		this.ItemGridVariantSelect.BindOnExtendToggleRelease(delegate(MediumItemGridExtendCallback _)
		{
			this.OpenItemSelectView();
		});
		this.ItemGridVariantSelect.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
		this.ItemGridVariantSelect.SetReduceButton(null);
		this.ViewSelectData.IsSingleSelected = true;
		this.ViewSelectData.OnChangeSelectedFunction = new Action<List<ISelectedData>, SelectableExpData>(this.OnChangeSameMonsterSelectedFunction);
		this.ViewSelectData.CheckIfCanAddFunction = new Func<List<ISelectedData>, int, int, int, bool>(this.CheckIfCanAdd);
		this.ViewOpenData.SelectableComponentData = this.ViewSelectData;
	}

	// Token: 0x0601833D RID: 99133 RVA: 0x006287B0 File Offset: 0x006269B0
	public void OpenItemSelectView()
	{
		List<ISelectedData> list = new List<ISelectedData>();
		if (this.CurrentSelectItem != null)
		{
			list.Add(this.CurrentSelectItem);
		}
		this.ViewOpenData.ItemDataBaseList = this.GetItemList();
		this.ViewOpenData.SelectedDataList = list;
		this.ViewOpenData.UseWayId = (EFilterSortGroupId)this.UseWayId;
		this.ViewOpenData.InitSortToggleState = this.InitSortToggleState;
		if (this.OpenViewType == ESingleItemSelectViewType.Right)
		{
			UiManager.Instance.OpenView(EUiViewName.CommonItemSelectViewRight, this.ViewOpenData, null);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.CommonItemSelectViewLeft, this.ViewOpenData, null);
	}

	// Token: 0x0601833E RID: 99134 RVA: 0x00628850 File Offset: 0x00626A50
	public void SetUseWayId(int useWayId)
	{
		this.UseWayId = useWayId;
	}

	// Token: 0x0601833F RID: 99135 RVA: 0x00628859 File Offset: 0x00626A59
	public void SetInitSortToggleState(bool bSelect)
	{
		this.InitSortToggleState = bSelect;
	}

	// Token: 0x06018340 RID: 99136 RVA: 0x00628862 File Offset: 0x00626A62
	private void OnChangeSameMonsterSelectedFunction(List<ISelectedData> currentSelectedData, SelectableExpData expData)
	{
		if (currentSelectedData != null && currentSelectedData.Count > 0)
		{
			this.CurrentSelectItem = currentSelectedData[0];
		}
		else
		{
			this.CurrentSelectItem = null;
		}
		this.RefreshCurrentSelectItemGrid();
	}

	// Token: 0x06018341 RID: 99137 RVA: 0x0062888C File Offset: 0x00626A8C
	private bool CheckIfCanAdd(List<ISelectedData> currentSelectedData, int uniqueId, int itemId, int count)
	{
		return this.CurrentSelectItem == null || uniqueId != this.CurrentSelectItem.IncId || itemId != this.CurrentSelectItem.ItemId || count <= 0;
	}

	// Token: 0x06018342 RID: 99138 RVA: 0x006288BC File Offset: 0x00626ABC
	private void RefreshCurrentSelectItemGrid()
	{
		if (this.CurrentSelectItem == null)
		{
			this.ItemGridVariantSelect.SetSelected(false, false);
			EmptyItemGrid parameters = new EmptyItemGrid();
			this.ItemGridVariantSelect.Apply<EmptyItemGrid>(parameters);
		}
		else
		{
			int incId = this.CurrentSelectItem.IncId;
			int itemId = this.CurrentSelectItem.ItemId;
			InventoryModel instance = InventoryModel.Instance;
			ItemDataBase itemDataBase = instance.GetAttributeItemData(incId);
			if (itemDataBase == null)
			{
				itemDataBase = instance.GetCommonItemData(itemId, 0);
			}
			PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
			{
				ItemConfigId = new int?(itemId),
				StarLevel = new int?(itemDataBase.GetQuality())
			};
			if (itemDataBase is AttributeItemData)
			{
				propMediumItemGrid.BottomTextId = "Text_LevelShow_Text";
				if (itemDataBase is PhantomItemData)
				{
					ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
					PhantomBattleModel instance2 = PhantomBattleModel.Instance;
					PhantomBattleData phantomBattleData = instance2.GetPhantomBattleData(incId);
					int phantomLevel = instance2.GetPhantomBattleData(incId).GetPhantomLevel();
					propMediumItemGrid.BottomTextParameter = new object[]
					{
						phantomLevel
					};
					propMediumItemGrid.BottomTextId = itemConfigData.Name;
					propMediumItemGrid.StarLevel = new int?(itemConfigData.QualityId);
					propMediumItemGrid.Level = new int?(phantomBattleData.GetCost());
					propMediumItemGrid.IsLevelTextUseChangeColor = new bool?(true);
				}
				if (itemDataBase is WeaponItemData)
				{
					WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(incId);
					int level = weaponDataByIncId.GetLevel();
					propMediumItemGrid.Level = new int?(weaponDataByIncId.GetResonanceLevel());
					propMediumItemGrid.BottomTextParameter = new object[]
					{
						level
					};
				}
			}
			else
			{
				propMediumItemGrid.BottomText = this.CurrentSelectItem.SelectedCount.ToString();
			}
			this.ItemGridVariantSelect.Apply<PropMediumItemGrid>(propMediumItemGrid);
			this.ItemGridVariantSelect.SetSelected(true, false);
		}
		this.OnItemSelectChange(this.CurrentSelectItem);
	}

	// Token: 0x06018343 RID: 99139 RVA: 0x00628A84 File Offset: 0x00626C84
	public void ClearSelectData()
	{
		this.CurrentSelectItem = null;
		this.RefreshCurrentSelectItemGrid();
	}

	// Token: 0x06018344 RID: 99140 RVA: 0x00628A93 File Offset: 0x00626C93
	public void SetItemSelectChangeCallBack(Action<ISelectedData> callBack)
	{
		this.OnItemSelectChange = callBack;
	}

	// Token: 0x06018345 RID: 99141 RVA: 0x00628A9C File Offset: 0x00626C9C
	public void SetGetItemListFunction(Func<List<ItemDataBase>> func)
	{
		this.GetItemList = func;
	}

	// Token: 0x06018346 RID: 99142 RVA: 0x00628AA5 File Offset: 0x00626CA5
	[NullableContext(2)]
	public ISelectedData GetCurrentSelectedData()
	{
		return this.CurrentSelectItem;
	}

	// Token: 0x0400B3EC RID: 46060
	[Nullable(2)]
	private ISelectedData CurrentSelectItem;

	// Token: 0x0400B3ED RID: 46061
	[Nullable(2)]
	private MediumItemGrid ItemGridVariantSelect;

	// Token: 0x0400B3EE RID: 46062
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Func<List<ItemDataBase>> GetItemList;

	// Token: 0x0400B3EF RID: 46063
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<ISelectedData> OnItemSelectChange;

	// Token: 0x0400B3F0 RID: 46064
	private readonly CommonItemSelectViewOpenViewData<ItemDataBase> ViewOpenData = new CommonItemSelectViewOpenViewData<ItemDataBase>();

	// Token: 0x0400B3F1 RID: 46065
	private readonly SelectableComponentData ViewSelectData = new SelectableComponentData();

	// Token: 0x0400B3F2 RID: 46066
	private ESingleItemSelectViewType OpenViewType;

	// Token: 0x0400B3F3 RID: 46067
	private int UseWayId;

	// Token: 0x0400B3F4 RID: 46068
	private bool InitSortToggleState;
}
