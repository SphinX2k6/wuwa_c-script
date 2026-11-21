using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020055A7 RID: 21927
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FishingTechLevelUpItem : LoopScrollMediumItemGrid<IFishingTechLevelUpItem>
	{
		// Token: 0x060365CA RID: 222666 RVA: 0x00F2D990 File Offset: 0x00F2BB90
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

		// Token: 0x060365CB RID: 222667 RVA: 0x00F2DAAF File Offset: 0x00F2BCAF
		protected override void OnExtendToggleClicked()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null, false);
		}

		// Token: 0x0401CAFA RID: 117498
		private int ItemId;
	}
}
