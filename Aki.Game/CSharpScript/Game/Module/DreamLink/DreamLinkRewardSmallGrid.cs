using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A9A RID: 19098
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DreamLinkRewardSmallGrid : LoopScrollSmallItemGrid<IDreamLinkRewardGridData>
	{
		// Token: 0x0602FCAF RID: 195759 RVA: 0x00D55B8C File Offset: 0x00D53D8C
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

		// Token: 0x0602FCB0 RID: 195760 RVA: 0x00D55C30 File Offset: 0x00D53E30
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x0602FCB1 RID: 195761 RVA: 0x00D55C33 File Offset: 0x00D53E33
		protected override void OnExtendToggleClicked()
		{
			if (this.RewardData.Status == EActivityTaskState.FinishedAndUnclaimed)
			{
				this.RewardData.ReceiveDelegate();
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null, false);
		}

		// Token: 0x040195E2 RID: 103906
		[Nullable(2)]
		private IDreamLinkRewardGridData RewardData;

		// Token: 0x040195E3 RID: 103907
		private int ConfigId;
	}
}
