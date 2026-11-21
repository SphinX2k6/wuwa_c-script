using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002257 RID: 8791
[NullableContext(1)]
[Nullable(0)]
public class SingleItemSelect
{
	// Token: 0x06015BDD RID: 89053 RVA: 0x0064E66C File Offset: 0x0064C86C
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

	// Token: 0x06015BDE RID: 89054 RVA: 0x0064E778 File Offset: 0x0064C978
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

	// Token: 0x06015BDF RID: 89055 RVA: 0x0064E818 File Offset: 0x0064CA18
	public void SetUseWayId(int useWayId)
	{
		this.UseWayId = useWayId;
	}

	// Token: 0x06015BE0 RID: 89056 RVA: 0x0064E821 File Offset: 0x0064CA21
	public void SetInitSortToggleState(bool bSelect)
	{
		this.InitSortToggleState = bSelect;
	}

	// Token: 0x06015BE1 RID: 89057 RVA: 0x0064E82A File Offset: 0x0064CA2A
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

	// Token: 0x06015BE2 RID: 89058 RVA: 0x0064E854 File Offset: 0x0064CA54
	private bool CheckIfCanAdd(List<ISelectedData> currentSelectedData, int uniqueId, int itemId, int count)
	{
		return this.CurrentSelectItem == null || uniqueId != this.CurrentSelectItem.IncId || itemId != this.CurrentSelectItem.ItemId || count <= 0;
	}

	// Token: 0x06015BE3 RID: 89059 RVA: 0x0064E884 File Offset: 0x0064CA84
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

	// Token: 0x06015BE4 RID: 89060 RVA: 0x0064EA4C File Offset: 0x0064CC4C
	public void ClearSelectData()
	{
		this.CurrentSelectItem = null;
		this.RefreshCurrentSelectItemGrid();
	}

	// Token: 0x06015BE5 RID: 89061 RVA: 0x0064EA5B File Offset: 0x0064CC5B
	public void SetItemSelectChangeCallBack(Action<ISelectedData> callBack)
	{
		this.OnItemSelectChange = callBack;
	}

	// Token: 0x06015BE6 RID: 89062 RVA: 0x0064EA64 File Offset: 0x0064CC64
	public void SetGetItemListFunction(Func<List<ItemDataBase>> func)
	{
		this.GetItemList = func;
	}

	// Token: 0x06015BE7 RID: 89063 RVA: 0x0064EA6D File Offset: 0x0064CC6D
	[NullableContext(2)]
	public ISelectedData GetCurrentSelectedData()
	{
		return this.CurrentSelectItem;
	}

	// Token: 0x0400B761 RID: 46945
	[Nullable(2)]
	private ISelectedData CurrentSelectItem;

	// Token: 0x0400B762 RID: 46946
	[Nullable(2)]
	private MediumItemGrid ItemGridVariantSelect;

	// Token: 0x0400B763 RID: 46947
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Func<List<ItemDataBase>> GetItemList;

	// Token: 0x0400B764 RID: 46948
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<ISelectedData> OnItemSelectChange;

	// Token: 0x0400B765 RID: 46949
	private readonly CommonItemSelectViewOpenViewData<ItemDataBase> ViewOpenData = new CommonItemSelectViewOpenViewData<ItemDataBase>();

	// Token: 0x0400B766 RID: 46950
	private readonly SelectableComponentData ViewSelectData = new SelectableComponentData();

	// Token: 0x0400B767 RID: 46951
	private ESingleItemSelectViewType OpenViewType;

	// Token: 0x0400B768 RID: 46952
	private int UseWayId;

	// Token: 0x0400B769 RID: 46953
	private bool InitSortToggleState;
}
