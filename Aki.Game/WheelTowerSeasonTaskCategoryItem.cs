using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001648 RID: 5704
public class WheelTowerSeasonTaskCategoryItem : SyncGridProxyAbstract<ETaskCategory>
{
	// Token: 0x0600A031 RID: 41009 RVA: 0x00234280 File Offset: 0x00232480
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A032 RID: 41010 RVA: 0x0023430C File Offset: 0x0023250C
	public override void Refresh(ETaskCategory data)
	{
		this.Category = data;
		string textStringId = (data == ETaskCategory.Cycle) ? "NewTower_LoopTask" : "NewTower_ChallengeTask";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textStringId, Array.Empty<object>());
		bool flag = data == ETaskCategory.Cycle;
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (flag)
		{
			this.RefreshCycleTime();
		}
	}

	// Token: 0x0600A033 RID: 41011 RVA: 0x00234368 File Offset: 0x00232568
	public void OnTick()
	{
		if (this.Category != ETaskCategory.Cycle)
		{
			return;
		}
		this.RefreshCycleTime();
	}

	// Token: 0x0600A034 RID: 41012 RVA: 0x0023437C File Offset: 0x0023257C
	private void RefreshCycleTime()
	{
		string cycleEndRemainTime = WheelTowerModel.Instance.GetCycleEndRemainTime();
		if (string.IsNullOrEmpty(cycleEndRemainTime))
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "WheelTower_SeasonTask_Doing", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "WheelTower_SeasonTask_ResetTime", new <>z__ReadOnlySingleElementList<object>(cycleEndRemainTime));
	}

	// Token: 0x040048FD RID: 18685
	private ETaskCategory Category;
}
