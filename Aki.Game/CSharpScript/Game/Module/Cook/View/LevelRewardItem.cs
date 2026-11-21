using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004AF7 RID: 19191
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LevelRewardItem : LoopScrollSmallItemGrid<IRewardData>
	{
		// Token: 0x0602FFE6 RID: 196582 RVA: 0x00D633C8 File Offset: 0x00D615C8
		protected override void OnRefresh(IRewardData data, bool isSelected, int gridIndex)
		{
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = data,
				ItemConfigId = new int?(data.RewardId),
				BottomText = ((data.Count > 0) ? data.Count.ToString() : ""),
				IsReceivedVisible = new bool?(data.IsGet)
			};
			base.Apply<PropSmallItemGrid>(parameters);
		}

		// Token: 0x0602FFE7 RID: 196583 RVA: 0x00D6342F File Offset: 0x00D6162F
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x0602FFE8 RID: 196584 RVA: 0x00D63434 File Offset: 0x00D61634
		protected override void OnExtendToggleClicked()
		{
			IRewardData rewardData = this.Data as IRewardData;
			ItemController.Instance.OpenItemTipsByItemId(rewardData.RewardId, true, null, false);
		}
	}
}
