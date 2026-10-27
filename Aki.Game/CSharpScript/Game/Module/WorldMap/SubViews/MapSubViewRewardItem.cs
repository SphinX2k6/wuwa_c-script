using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.WorldMap.SubViews
{
	// Token: 0x020047BD RID: 18365
	[NullableContext(2)]
	[Nullable(0)]
	public class MapSubViewRewardItem : LoopScrollSmallItemGrid<TItem>
	{
		// Token: 0x060301CB RID: 197067 RVA: 0x00B26EB8 File Offset: 0x00B250B8
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

		// Token: 0x060301CC RID: 197068 RVA: 0x00B26FBB File Offset: 0x00B251BB
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x060301CD RID: 197069 RVA: 0x00B26FBE File Offset: 0x00B251BE
		protected override void OnExtendToggleClicked()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null);
		}

		// Token: 0x04019ECF RID: 106191
		public Func<int, int> GetRolePositionFunc;

		// Token: 0x04019ED0 RID: 106192
		public Func<int, bool> IsHighlightIndex;

		// Token: 0x04019ED1 RID: 106193
		private int ItemId;
	}
}
