using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02005695 RID: 22165
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LevelRewardItem : LoopScrollSmallItemGrid<IRewardData>
	{
		// Token: 0x0603865A RID: 231002 RVA: 0x00D63188 File Offset: 0x00D61388
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

		// Token: 0x0603865B RID: 231003 RVA: 0x00D631FE File Offset: 0x00D613FE
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x0603865C RID: 231004 RVA: 0x00D63204 File Offset: 0x00D61404
		protected override void OnExtendToggleClicked()
		{
			IRewardData rewardData = this.Data as IRewardData;
			if (rewardData == null)
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(rewardData.RewardId, true, null);
		}
	}
}
