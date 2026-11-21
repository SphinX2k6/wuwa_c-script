using System;
using System.Runtime.CompilerServices;

// Token: 0x0200088D RID: 2189
public class RewardGridItem : SmallItemGrid
{
	// Token: 0x06006308 RID: 25352 RVA: 0x001F8CE7 File Offset: 0x001F6EE7
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x06006309 RID: 25353 RVA: 0x001F8CEC File Offset: 0x001F6EEC
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
