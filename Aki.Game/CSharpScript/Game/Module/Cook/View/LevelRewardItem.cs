using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02005B16 RID: 23318
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LevelRewardItem : LoopScrollSmallItemGrid<IRewardData>
	{
		// Token: 0x0603B074 RID: 241780 RVA: 0x00E126B0 File Offset: 0x00E108B0
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

		// Token: 0x0603B075 RID: 241781 RVA: 0x00E12717 File Offset: 0x00E10917
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x0603B076 RID: 241782 RVA: 0x00E1271C File Offset: 0x00E1091C
		protected override void OnExtendToggleClicked()
		{
			IRewardData rewardData = this.Data as IRewardData;
			ItemController.Instance.OpenItemTipsByItemId(rewardData.RewardId, true, null);
		}
	}
}
