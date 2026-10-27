using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001543 RID: 5443
[NullableContext(1)]
[Nullable(0)]
public class ActivityTurntableDailyPanel : UiPanelBase
{
	// Token: 0x06009B9D RID: 39837 RVA: 0x0021B008 File Offset: 0x00219208
	public ActivityTurntableDailyPanel(ActivityTurntableData activityBaseData)
	{
		this.ActivityBaseData = activityBaseData;
	}

	// Token: 0x06009B9E RID: 39838 RVA: 0x0021B018 File Offset: 0x00219218
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

	// Token: 0x06009B9F RID: 39839 RVA: 0x0021B081 File Offset: 0x00219281
	protected override void OnStart()
	{
		this.DailyItemLayout = new GenericLayout<ActivityTurntableDailyItem, ActivityTaskData>(base.GetVerticalLayout(0), new Func<ActivityTurntableDailyItem>(this.CreateDailyItem), null, false, true);
	}

	// Token: 0x06009BA0 RID: 39840 RVA: 0x0021B0A4 File Offset: 0x002192A4
	public void Refresh()
	{
		this.DailyItemLayout.RefreshByData(this.ActivityBaseData.GetAllTurntableDailyQuestData(), null, false);
	}

	// Token: 0x06009BA1 RID: 39841 RVA: 0x0021B0BE File Offset: 0x002192BE
	private ActivityTurntableDailyItem CreateDailyItem()
	{
		return new ActivityTurntableDailyItem();
	}

	// Token: 0x04004460 RID: 17504
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ActivityTurntableDailyItem, ActivityTaskData> DailyItemLayout;

	// Token: 0x04004461 RID: 17505
	protected ActivityTurntableData ActivityBaseData;

	// Token: 0x02007B79 RID: 31609
	[NullableContext(0)]
	private class EDailyComponents
	{
		// Token: 0x04028990 RID: 166288
		public const int Layout = 0;

		// Token: 0x04028991 RID: 166289
		public const int Item = 1;
	}
}
