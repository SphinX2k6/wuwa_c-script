using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020009FB RID: 2555
[NullableContext(1)]
[Nullable(0)]
public class ActivityTurntableDailyPanel : UiPanelBase
{
	// Token: 0x06006F7B RID: 28539 RVA: 0x00224DB8 File Offset: 0x00222FB8
	public ActivityTurntableDailyPanel(ActivityTurntableData activityBaseData)
	{
		this.ActivityBaseData = activityBaseData;
	}

	// Token: 0x06006F7C RID: 28540 RVA: 0x00224DC8 File Offset: 0x00222FC8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006F7D RID: 28541 RVA: 0x00224E31 File Offset: 0x00223031
	protected override void OnStart()
	{
		this.DailyItemLayout = new GenericLayout<ActivityTurntableDailyItem, ActivityTaskData>(base.GetVerticalLayout(0), new Func<ActivityTurntableDailyItem>(this.CreateDailyItem), null, false, true);
	}

	// Token: 0x06006F7E RID: 28542 RVA: 0x00224E54 File Offset: 0x00223054
	public void Refresh()
	{
		this.DailyItemLayout.RefreshByData(this.ActivityBaseData.GetAllTurntableDailyQuestData(), null, false);
	}

	// Token: 0x06006F7F RID: 28543 RVA: 0x00224E6E File Offset: 0x0022306E
	private ActivityTurntableDailyItem CreateDailyItem()
	{
		return new ActivityTurntableDailyItem();
	}

	// Token: 0x04004506 RID: 17670
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ActivityTurntableDailyItem, ActivityTaskData> DailyItemLayout;

	// Token: 0x04004507 RID: 17671
	protected ActivityTurntableData ActivityBaseData;

	// Token: 0x02006D04 RID: 27908
	[NullableContext(0)]
	private class EDailyComponents
	{
		// Token: 0x04023CCB RID: 146635
		public const int Layout = 0;

		// Token: 0x04023CCC RID: 146636
		public const int Item = 1;
	}
}
