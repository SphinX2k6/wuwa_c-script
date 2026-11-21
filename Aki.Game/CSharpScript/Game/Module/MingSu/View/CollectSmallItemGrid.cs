using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.MingSu.View
{
	// Token: 0x020043BA RID: 17338
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CollectSmallItemGrid : LoopScrollSmallItemGrid<IRewardItemData>
	{
		// Token: 0x0602BD10 RID: 179472 RVA: 0x00C4D258 File Offset: 0x00C4B458
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
