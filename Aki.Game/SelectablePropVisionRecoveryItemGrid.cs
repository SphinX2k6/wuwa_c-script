using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02000E1B RID: 3611
public class SelectablePropVisionRecoveryItemGrid : SelectablePropMediumItemGrid
{
	// Token: 0x060091F1 RID: 37361 RVA: 0x002BA0CE File Offset: 0x002B82CE
	public override void RefreshCostCount()
	{
		if (this.SelectablePropData == null)
		{
			return;
		}
		this.RefreshUi(this.SelectablePropData);
	}

	// Token: 0x060091F2 RID: 37362 RVA: 0x002BA0E8 File Offset: 0x002B82E8
	[NullableContext(1)]
	public override void RefreshUi(SelectablePropData data)
	{
		this.SelectablePropData = data;
		InventoryModel instance = InventoryModel.Instance;
		int incId = data.IncId;
		int itemId = data.ItemId;
		InventoryDefine.EItemDataType itemDataType = data.ItemDataType;
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
		if (itemConfigData == null)
		{
			return;
		}
		ItemDataBase itemDataBase;
		if (incId > 0)
		{
			itemDataBase = instance.GetAttributeItemData(incId);
		}
		else
		{
			itemDataBase = instance.GetCommonItemData(itemId, 0);
		}
		if (itemDataBase == null)
		{
			return;
		}
		int selectedCount = this.SelectablePropData.SelectedCount;
		int count = this.SelectablePropData.Count;
		PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
		{
			Data = data,
			ItemConfigId = new int?(itemId),
			StarLevel = new int?(itemConfigData.QualityId),
			ReduceButtonInfo = new LongPressButton
			{
				IsVisible = new bool?(selectedCount > 0),
				LongPressConfigId = new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne)
			}
		};
		if (itemDataType == InventoryDefine.EItemDataType.PhantomItem)
		{
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(incId);
			if (phantomBattleData != null)
			{
				int phantomLevel = phantomBattleData.GetPhantomLevel();
				int exp = phantomBattleData.GetExp();
				propMediumItemGrid.ItemConfigId = new int?(phantomBattleData.GetConfigId(true));
				propMediumItemGrid.QualityId = new int?(phantomBattleData.GetQuality());
				propMediumItemGrid.Level = new int?(phantomBattleData.GetCost());
				propMediumItemGrid.IsLevelTextUseChangeColor = new bool?(true);
				propMediumItemGrid.BottomTextId = "VisionLevel";
				propMediumItemGrid.IsDisable = new bool?(phantomLevel > 1 || exp > 0 || (this.SelectablePropData.OnlyGold && phantomBattleData.GetQuality() < 5));
				propMediumItemGrid.BottomTextParameter = new object[]
				{
					phantomBattleData.GetPhantomLevel()
				};
				propMediumItemGrid.VisionFetterGroupId = new int?(phantomBattleData.GetFetterGroupId());
				propMediumItemGrid.IsOmitBottomText = new bool?(true);
				propMediumItemGrid.IsLockVisible = new bool?(phantomBattleData.GetIsLock());
				propMediumItemGrid.IsDeprecate = new bool?(phantomBattleData.GetIsDeprecated());
				PhantomItemData phantomItemData = itemDataBase as PhantomItemData;
				if (phantomItemData != null)
				{
					propMediumItemGrid.StackDisplayInfo = new PhantomStackDisplay
					{
						StackCount = phantomItemData.GetStackCount(),
						SelectedCount = selectedCount,
						CanStack = PhantomStackUtil.CanStackWithSameSpec(phantomBattleData)
					};
				}
			}
		}
		else if (selectedCount > 0)
		{
			propMediumItemGrid.BottomTextId = "Text_ItemEnoughText_Text";
			propMediumItemGrid.BottomTextParameter = new object[]
			{
				selectedCount,
				count
			};
		}
		else
		{
			propMediumItemGrid.BottomText = count.ToString();
		}
		base.Apply<PropMediumItemGrid>(propMediumItemGrid);
	}
}
