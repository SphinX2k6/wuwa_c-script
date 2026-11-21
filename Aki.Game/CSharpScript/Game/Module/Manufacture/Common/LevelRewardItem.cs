using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x0200466B RID: 18027
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LevelRewardItem : LoopScrollSmallItemGrid<IRewardData>
	{
		// Token: 0x0602D557 RID: 185687 RVA: 0x00CB12D8 File Offset: 0x00CAF4D8
		protected override void OnRefresh(IRewardData data, bool isSelected, int gridIndex)
		{
			PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
			propSmallItemGrid.Data = data;
			propSmallItemGrid.ItemConfigId = new int?(data.RewardId);
			string bottomText;
			if (data.Count <= 0)
			{
				bottomText = "";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count);
				bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			propSmallItemGrid.BottomText = bottomText;
			propSmallItemGrid.IsReceivedVisible = new bool?(data.IsGet);
			PropSmallItemGrid parameters = propSmallItemGrid;
			base.Apply<PropSmallItemGrid>(parameters);
		}

		// Token: 0x0602D558 RID: 185688 RVA: 0x00CB134E File Offset: 0x00CAF54E
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x0602D559 RID: 185689 RVA: 0x00CB1354 File Offset: 0x00CAF554
		protected override void OnExtendToggleClicked()
		{
			IRewardData rewardData = this.Data as IRewardData;
			if (rewardData == null)
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(rewardData.RewardId, true, null, false);
		}
	}
}
