using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.Birthday.View
{
	// Token: 0x02005C2D RID: 23597
	public class BirthdayRewardItem : CommonItemSmallItemGrid
	{
		// Token: 0x0603B9BF RID: 244159 RVA: 0x00E38FDC File Offset: 0x00E371DC
		protected override void OnRefresh(TItem data, bool isSelected, int gridIndex)
		{
			InventoryDefine.IGetItemData itemData = data.ItemData;
			int count = data.Count;
			this.ConfigId = itemData.ItemId;
			PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
			propSmallItemGrid.Data = data;
			propSmallItemGrid.ItemConfigId = new int?(this.ConfigId);
			string bottomText;
			if (count <= 0)
			{
				bottomText = "";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(count);
				bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			propSmallItemGrid.BottomText = bottomText;
			Func<TItem, bool> showReceivedCallBack = this.ShowReceivedCallBack;
			propSmallItemGrid.IsReceivedVisible = ((showReceivedCallBack != null) ? new bool?(showReceivedCallBack(data)) : null);
			propSmallItemGrid.IsBirthdayEffectVisible = new bool?(base.GridIndex == 0);
			PropSmallItemGrid parameters = propSmallItemGrid;
			base.Apply<PropSmallItemGrid>(parameters);
		}
	}
}
