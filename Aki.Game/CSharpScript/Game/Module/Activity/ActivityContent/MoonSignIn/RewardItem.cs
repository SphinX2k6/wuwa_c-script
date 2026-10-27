using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x0200646D RID: 25709
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class RewardItem : LoopScrollSmallItemGrid<IRewardItemData>
	{
		// Token: 0x060409AA RID: 264618 RVA: 0x00FA3884 File Offset: 0x00FA1A84
		protected override void OnRefresh(IRewardItemData data, bool isSelected, int gridIndex)
		{
			InventoryDefine.IGetItemData itemData = data.ItemData.ItemData;
			int count = data.ItemData.Count;
			this.ConfigId = itemData.ItemId;
			PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
			propSmallItemGrid.Data = data;
			propSmallItemGrid.IsReceivedVisible = new bool?(data.HaveFinish);
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
			PropSmallItemGrid parameters = propSmallItemGrid;
			base.Apply<PropSmallItemGrid>(parameters);
		}

		// Token: 0x060409AB RID: 264619 RVA: 0x00FA3914 File Offset: 0x00FA1B14
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x060409AC RID: 264620 RVA: 0x00FA3917 File Offset: 0x00FA1B17
		protected override void OnExtendToggleClicked()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null);
		}

		// Token: 0x0402195F RID: 137567
		private int ConfigId = -1;
	}
}
