using System;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001816 RID: 6166
public class ConsumeMediumItemGrid : LoopScrollMediumItemGrid<TCommonMultipleConsumeData>
{
	// Token: 0x0600B4C3 RID: 46275 RVA: 0x0028CB60 File Offset: 0x0028AD60
	protected override void OnRefresh(TCommonMultipleConsumeData data, bool isSelected, int gridIndex)
	{
		InventoryConfig instance = InventoryConfig.Instance;
		int itemId = data.ItemData.ItemId;
		int? num = new int?(data.ItemData.IncId);
		int count = data.Count;
		if (itemId == 0)
		{
			EmptyItemGrid parameters = new EmptyItemGrid();
			base.Apply<EmptyItemGrid>(parameters);
			return;
		}
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
		if (itemConfigData == null)
		{
			return;
		}
		InventoryDefine.EItemDataType itemDataTypeByConfigId = instance.GetItemDataTypeByConfigId(new int?(itemId));
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.PhantomItem)
		{
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(num.Value);
			PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
			{
				Data = data,
				ItemConfigId = new int?(phantomBattleData.GetConfigId(true)),
				QualityId = new int?(phantomBattleData.GetQuality()),
				BottomTextId = itemConfigData.Name,
				StarLevel = new int?(itemConfigData.QualityId),
				Level = new int?(phantomBattleData.GetCost()),
				IsLevelTextUseChangeColor = new bool?(true),
				ReduceButtonInfo = new LongPressButton
				{
					IsVisible = new bool?(true),
					LongPressConfigId = new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne)
				}
			};
			propMediumItemGrid.BottomTextId = "VisionLevel";
			propMediumItemGrid.BottomTextParameter = new object[]
			{
				phantomBattleData.GetPhantomLevel()
			};
			propMediumItemGrid.VisionFetterGroupId = new int?(phantomBattleData.GetFetterGroupId());
			base.Apply<PropMediumItemGrid>(propMediumItemGrid);
			return;
		}
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.WeaponItem)
		{
			WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(num.Value);
			PropMediumItemGrid parameters2 = new PropMediumItemGrid
			{
				Data = data,
				ItemConfigId = new int?(itemId),
				BottomTextId = "Text_LevelShow_Text",
				BottomTextParameter = new object[]
				{
					weaponDataByIncId.GetLevel()
				},
				StarLevel = new int?(itemConfigData.QualityId),
				Level = new int?(weaponDataByIncId.GetResonanceLevel()),
				ReduceButtonInfo = new LongPressButton
				{
					IsVisible = new bool?(true),
					LongPressConfigId = new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne)
				}
			};
			base.Apply<PropMediumItemGrid>(parameters2);
			return;
		}
		PropMediumItemGrid propMediumItemGrid2 = new PropMediumItemGrid
		{
			Data = data,
			ItemConfigId = new int?(itemId),
			StarLevel = new int?(itemConfigData.QualityId),
			ReduceButtonInfo = new LongPressButton
			{
				IsVisible = new bool?(true),
				LongPressConfigId = new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne)
			}
		};
		if (num != null && num.Value > 0)
		{
			propMediumItemGrid2.BottomTextId = itemConfigData.Name;
		}
		else
		{
			propMediumItemGrid2.BottomText = count.ToString();
		}
		base.Apply<PropMediumItemGrid>(propMediumItemGrid2);
	}
}
