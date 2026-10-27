using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006629 RID: 26153
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FishingTechLevelUpItem : LoopScrollMediumItemGrid<IFishingTechLevelUpItem>
	{
		// Token: 0x06041905 RID: 268549 RVA: 0x00FE68DC File Offset: 0x00FE4ADC
		protected override void OnRefresh(IFishingTechLevelUpItem data, bool isSelected, int gridIndex)
		{
			this.ItemId = data.ItemId;
			base.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			int itemId = data.ItemId;
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			if (itemConfigData == null)
			{
				return;
			}
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(itemId, 0);
			string value;
			if (itemCountByConfigId < data.ItemNeedNum)
			{
				value = StringUtils.Format("<color=#c25757>{0}</color>", new string[]
				{
					itemCountByConfigId.ToString()
				});
			}
			else
			{
				value = StringUtils.Format("<color=#ffffff>{0}</color>", new string[]
				{
					itemCountByConfigId.ToString()
				});
			}
			PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid();
			propMediumItemGrid.Data = data;
			propMediumItemGrid.ItemConfigId = new int?(itemId);
			propMediumItemGrid.StarLevel = new int?(itemConfigData.QualityId);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.ItemNeedNum);
			propMediumItemGrid.BottomText = defaultInterpolatedStringHandler.ToStringAndClear();
			propMediumItemGrid.IsOmitBottomText = new bool?(false);
			PropMediumItemGrid parameters = propMediumItemGrid;
			base.Apply<PropMediumItemGrid>(parameters);
		}

		// Token: 0x06041906 RID: 268550 RVA: 0x00FE69FB File Offset: 0x00FE4BFB
		protected override void OnExtendToggleClicked()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null);
		}

		// Token: 0x040221C9 RID: 139721
		private int ItemId;
	}
}
