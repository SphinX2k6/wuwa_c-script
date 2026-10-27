using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001151 RID: 4433
public class DeTermDailyQuestItem : UiPanelBase
{
	// Token: 0x0600745F RID: 29791 RVA: 0x0017C71C File Offset: 0x0017A91C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007460 RID: 29792 RVA: 0x0017C785 File Offset: 0x0017A985
	protected override void OnStart()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "ScratchCard_TaskType_01", Array.Empty<object>());
	}

	// Token: 0x02007704 RID: 30468
	private class EDeTermDailyQuestItem
	{
		// Token: 0x04027431 RID: 160817
		public const int BgSprite = 0;

		// Token: 0x04027432 RID: 160818
		public const int Text = 1;
	}
}
