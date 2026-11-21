using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000605 RID: 1541
public class DeTermDailyQuestItem : UiPanelBase
{
	// Token: 0x060047F6 RID: 18422 RVA: 0x00185268 File Offset: 0x00183468
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

	// Token: 0x060047F7 RID: 18423 RVA: 0x001852D1 File Offset: 0x001834D1
	protected override void OnStart()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "ScratchCard_TaskType_01", Array.Empty<object>());
	}

	// Token: 0x02006893 RID: 26771
	private class EDeTermDailyQuestItem
	{
		// Token: 0x04022772 RID: 141170
		public const int BgSprite = 0;

		// Token: 0x04022773 RID: 141171
		public const int Text = 1;
	}
}
