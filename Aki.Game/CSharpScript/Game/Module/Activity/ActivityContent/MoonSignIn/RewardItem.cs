using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x020053EB RID: 21483
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class RewardItem : LoopScrollSmallItemGrid<IRewardItemData>
	{
		// Token: 0x0603566B RID: 218731 RVA: 0x00EEA800 File Offset: 0x00EE8A00
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

		// Token: 0x0603566C RID: 218732 RVA: 0x00EEA890 File Offset: 0x00EE8A90
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x0603566D RID: 218733 RVA: 0x00EEA893 File Offset: 0x00EE8A93
		protected override void OnExtendToggleClicked()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null, false);
		}

		// Token: 0x0401C28E RID: 115342
		private int ConfigId = -1;
	}
}
