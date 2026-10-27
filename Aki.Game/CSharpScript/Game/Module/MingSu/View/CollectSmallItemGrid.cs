using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.MingSu.View
{
	// Token: 0x020053D7 RID: 21463
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CollectSmallItemGrid : LoopScrollSmallItemGrid<IRewardItemData>
	{
		// Token: 0x06036DC9 RID: 224713 RVA: 0x00CFE188 File Offset: 0x00CFC388
		protected override void OnRefresh(IRewardItemData data, bool isSelected, int gridIndex)
		{
			bool value = false;
			MingSuModel instance = MingSuModel.Instance;
			int currentDragonPoolId = instance.GetCurrentDragonPoolId();
			int currentPreviewLevel = instance.CurrentPreviewLevel;
			int targetDragonPoolLevelById = instance.GetTargetDragonPoolLevelById(currentDragonPoolId);
			int targetDragonPoolMaxLevelById = instance.GetTargetDragonPoolMaxLevelById(currentDragonPoolId);
			if (currentPreviewLevel == targetDragonPoolLevelById + 1 || (currentPreviewLevel == targetDragonPoolLevelById && currentPreviewLevel == targetDragonPoolMaxLevelById))
			{
				if (instance.GetTargetDragonPoolActiveById(currentDragonPoolId) == 2)
				{
					value = true;
				}
			}
			else if (currentPreviewLevel <= targetDragonPoolLevelById)
			{
				value = true;
			}
			ItemConfig itemInfo = data.ItemInfo;
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = data,
				ItemConfigId = new int?((itemInfo != null) ? itemInfo.Id : 0),
				BottomText = data.Count.ToString(),
				IsReceivedVisible = new bool?(value)
			};
			base.Apply<PropSmallItemGrid>(parameters);
		}
	}
}
