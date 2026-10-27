using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006F09 RID: 28425
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DollCollectSmallItemGrid : LoopScrollSmallItemGrid<IDollRewardItemData>
	{
		// Token: 0x0604530A RID: 283402 RVA: 0x0111DA88 File Offset: 0x0111BC88
		protected override void OnRefresh(IDollRewardItemData data, bool isSelected, int gridIndex)
		{
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = data,
				ItemConfigId = new int?(data.ItemInfo.Id),
				BottomText = data.Count.ToString(),
				IsReceivedVisible = new bool?(false)
			};
			base.Apply<PropSmallItemGrid>(parameters);
			base.SetUseFixedAsync(true);
		}
	}
}
