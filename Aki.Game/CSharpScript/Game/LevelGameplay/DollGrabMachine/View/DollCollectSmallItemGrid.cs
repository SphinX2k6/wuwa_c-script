using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x0200608A RID: 24714
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DollCollectSmallItemGrid : LoopScrollSmallItemGrid<IDollRewardItemData>
	{
		// Token: 0x0603B4B8 RID: 242872 RVA: 0x010C7A28 File Offset: 0x010C5C28
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
