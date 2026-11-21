using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001334 RID: 4916
public class HonamiStoryPickupBoxData : HonamiStoryBackpackData
{
	// Token: 0x0600C199 RID: 49561 RVA: 0x0039495C File Offset: 0x00392B5C
	public void ShaveCapacity()
	{
		int num = 0;
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in this.ItemList)
		{
			num = Math.Max(num, (int)Math.Floor((double)honamiStoryItemDataBase.GetPosition() / (double)this.Width) + honamiStoryItemDataBase.GetGridHeight());
		}
		int capacity = HonamiStoryModel.Instance.GetBackPackData(2, false).GetCapacity();
		int num2 = (num + 3) * this.Width + capacity;
		int capacity2 = base.GetCapacity();
		if (num2 < capacity2)
		{
			for (int i = num2; i < capacity2; i++)
			{
				this.EmptyGridSet.Remove(i);
			}
		}
		else
		{
			for (int j = capacity2; j < num2; j++)
			{
				this.EmptyGridSet.Add(j);
			}
		}
		base.SetCapacity((num + 3) * this.Width + capacity);
	}

	// Token: 0x0600C19A RID: 49562 RVA: 0x00394A4C File Offset: 0x00392C4C
	[NullableContext(1)]
	public override bool PushItemData(HonamiStoryItemDataBase itemData)
	{
		itemData.SetBackpackWidth(this.Width);
		IHonamiStoryAvailablePosInfo honamiStoryAvailablePosInfo = HonamiStoryUtil.FindFirstAvailablePosition(this.EmptyGridSet, itemData, this.Width, null);
		if (honamiStoryAvailablePosInfo.Position == -1)
		{
			int num = itemData.GetGridHeight() + 1;
			int capacity = base.GetCapacity();
			base.SetCapacity(capacity + num * base.GetWidthCount());
			for (int i = capacity; i < base.GetCapacity(); i++)
			{
				this.EmptyGridSet.Add(i);
			}
			honamiStoryAvailablePosInfo = HonamiStoryUtil.FindFirstAvailablePosition(this.EmptyGridSet, itemData, this.Width, null);
		}
		HonamiStoryPosInfo honamiStoryPosInfo = HonamiStoryPosInfo.Create();
		honamiStoryPosInfo.Position = honamiStoryAvailablePosInfo.Position;
		honamiStoryPosInfo.IsCross = honamiStoryAvailablePosInfo.IsCross;
		itemData.UpdatePositionInfo(honamiStoryPosInfo);
		base.RefreshItemMapByAddItem(itemData);
		return true;
	}

	// Token: 0x04006F1C RID: 28444
	private const int PICKUP_EXTRA_ROW = 3;
}
