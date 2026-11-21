using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.WorldMap.SubViews
{
	// Token: 0x020036EE RID: 14062
	[NullableContext(2)]
	[Nullable(0)]
	public class MapSubViewRewardItem : LoopScrollSmallItemGrid<TItem>
	{
		// Token: 0x0602499B RID: 149915 RVA: 0x00A56CC4 File Offset: 0x00A54EC4
		protected override void OnRefresh(TItem data, bool isSelected, int gridIndex)
		{
			this.ItemId = data.ItemData.ItemId;
			if (InventoryConfig.Instance.GetItemConfigData(this.ItemId) == null)
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
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = data,
				BottomText = bottomText,
				ItemConfigId = new int?(this.ItemId)
			};
			base.Apply<PropSmallItemGrid>(parameters);
		}

		// Token: 0x0602499C RID: 149916 RVA: 0x00A56DC7 File Offset: 0x00A54FC7
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x0602499D RID: 149917 RVA: 0x00A56DCA File Offset: 0x00A54FCA
		protected override void OnExtendToggleClicked()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null, false);
		}

		// Token: 0x04014580 RID: 83328
		public Func<int, int> GetRolePositionFunc;

		// Token: 0x04014581 RID: 83329
		public Func<int, bool> IsHighlightIndex;

		// Token: 0x04014582 RID: 83330
		private int ItemId;
	}
}
