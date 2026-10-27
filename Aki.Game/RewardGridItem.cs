using System;
using System.Runtime.CompilerServices;

// Token: 0x020013D9 RID: 5081
public class RewardGridItem : SmallItemGrid
{
	// Token: 0x06008F73 RID: 36723 RVA: 0x001F01AF File Offset: 0x001EE3AF
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x06008F74 RID: 36724 RVA: 0x001F01B4 File Offset: 0x001EE3B4
	[NullableContext(1)]
	public void RefreshByData(IItemData data)
	{
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data.ItemId),
			BottomText = data.Count.ToString(),
			IsReceivedVisible = new bool?(false)
		};
		base.Apply<PropSmallItemGrid>(parameters);
	}
}
