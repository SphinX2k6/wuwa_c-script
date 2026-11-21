using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000B00 RID: 2816
public class WheelTowerSeasonTaskCategoryItem : SyncGridProxyAbstract<ETaskCategory>
{
	// Token: 0x0600740F RID: 29711 RVA: 0x0023E0BC File Offset: 0x0023C2BC
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

	// Token: 0x06007410 RID: 29712 RVA: 0x0023E148 File Offset: 0x0023C348
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

	// Token: 0x06007411 RID: 29713 RVA: 0x0023E1A4 File Offset: 0x0023C3A4
	public void OnTick()
	{
		if (this.Category != ETaskCategory.Cycle)
		{
			return;
		}
		this.RefreshCycleTime();
	}

	// Token: 0x06007412 RID: 29714 RVA: 0x0023E1B8 File Offset: 0x0023C3B8
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

	// Token: 0x040049A3 RID: 18851
	private ETaskCategory Category;
}
