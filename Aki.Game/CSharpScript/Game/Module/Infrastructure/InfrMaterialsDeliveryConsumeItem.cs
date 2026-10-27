using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005917 RID: 22807
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrMaterialsDeliveryConsumeItem : LoopScrollMediumItemGrid<TItem>
	{
		// Token: 0x06039EAA RID: 237226 RVA: 0x00DC294C File Offset: 0x00DC0B4C
		protected override void OnRefresh(TItem data, bool isSelected, int gridIndex)
		{
			this.ItemId = data.ItemData.ItemId;
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.ItemId);
			if (itemConfigData == null)
			{
				return;
			}
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.ItemId, 0);
			string bottomText;
			if (itemCountByConfigId < data.Count)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
				defaultInterpolatedStringHandler.AppendLiteral("<color=#9d2437>");
				defaultInterpolatedStringHandler.AppendFormatted<int>(itemCountByConfigId);
				defaultInterpolatedStringHandler.AppendLiteral("</color>/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count);
				bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
				defaultInterpolatedStringHandler.AppendLiteral("<color=#ffd12f>");
				defaultInterpolatedStringHandler.AppendFormatted<int>(itemCountByConfigId);
				defaultInterpolatedStringHandler.AppendLiteral("</color>/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count);
				bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				Data = data,
				IsOmitBottomText = new bool?(true),
				BottomText = bottomText,
				ItemConfigId = new int?(this.ItemId),
				StarLevel = new int?(itemConfigData.QualityId)
			};
			base.Apply<PropMediumItemGrid>(parameters);
		}

		// Token: 0x06039EAB RID: 237227 RVA: 0x00DC2A6E File Offset: 0x00DC0C6E
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x06039EAC RID: 237228 RVA: 0x00DC2A71 File Offset: 0x00DC0C71
		protected override void OnExtendToggleClicked()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null);
		}

		// Token: 0x0401E336 RID: 123702
		public Func<int, int> GetRolePositionFunc;

		// Token: 0x0401E337 RID: 123703
		public Func<int, bool> IsHighlightIndex;

		// Token: 0x0401E338 RID: 123704
		private int ItemId;
	}
}
