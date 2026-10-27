using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005ABE RID: 23230
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DreamLinkRewardSmallGrid : LoopScrollSmallItemGrid<IDreamLinkRewardGridData>
	{
		// Token: 0x0603AD63 RID: 240995 RVA: 0x00E055C4 File Offset: 0x00E037C4
		protected override void OnRefresh(IDreamLinkRewardGridData data, bool isSelected, int gridIndex)
		{
			this.RewardData = data;
			TItem item = data.Item;
			int count = item.Count;
			this.ConfigId = item.ItemData.ItemId;
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
			propSmallItemGrid.IsReceivedVisible = new bool?(data.Status == EActivityTaskState.FinishedAndClaimed);
			PropSmallItemGrid parameters = propSmallItemGrid;
			base.Apply<PropSmallItemGrid>(parameters);
			base.SetReceivableVisible(data.Status == EActivityTaskState.FinishedAndUnclaimed);
		}

		// Token: 0x0603AD64 RID: 240996 RVA: 0x00E05668 File Offset: 0x00E03868
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x0603AD65 RID: 240997 RVA: 0x00E0566B File Offset: 0x00E0386B
		protected override void OnExtendToggleClicked()
		{
			if (this.RewardData.Status == EActivityTaskState.FinishedAndUnclaimed)
			{
				this.RewardData.ReceiveDelegate();
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null);
		}

		// Token: 0x0401EB3B RID: 125755
		[Nullable(2)]
		private IDreamLinkRewardGridData RewardData;

		// Token: 0x0401EB3C RID: 125756
		private int ConfigId;
	}
}
