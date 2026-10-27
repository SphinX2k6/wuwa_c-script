using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x0200100C RID: 4108
public class GolemHackingLevelDetailToggleHard : GolemHackingLevelDetailToggle
{
	// Token: 0x06006959 RID: 26969 RVA: 0x001501F2 File Offset: 0x0014E3F2
	public GolemHackingLevelDetailToggleHard(int levelId) : base(levelId)
	{
		this.IsHard = true;
	}

	// Token: 0x0600695A RID: 26970 RVA: 0x00150204 File Offset: 0x0014E404
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600695B RID: 26971 RVA: 0x001502B0 File Offset: 0x0014E4B0
	public override bool RefreshState(bool needAnim = false)
	{
		GolemHackingActivityData activityData = GolemHackingController.Instance.GetActivityData();
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(activityData.CheckLevelRedDot(this.LevelId));
		}
		GolemHackingLevelInfo levelInfo = activityData.GetLevelInfo(this.LevelId);
		bool flag = levelInfo.State == GolemCrackState.GolemCrackFinished;
		bool uiactive = levelInfo.State == GolemCrackState.GolemCrackLocked;
		UUIItem item2 = base.GetItem(1);
		if (item2 != null)
		{
			item2.SetUIActive(flag);
		}
		UUIItem item3 = base.GetItem(2);
		if (item3 != null)
		{
			item3.SetUIActive(uiactive);
		}
		return flag;
	}
}
