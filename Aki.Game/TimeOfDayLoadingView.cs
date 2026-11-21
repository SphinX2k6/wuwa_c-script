using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002131 RID: 8497
public class TimeOfDayLoadingView : UiViewBase
{
	// Token: 0x06014D57 RID: 85335 RVA: 0x0060E230 File Offset: 0x0060C430
	[NullableContext(1)]
	public TimeOfDayLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014D58 RID: 85336 RVA: 0x0060E23C File Offset: 0x0060C43C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06014D59 RID: 85337 RVA: 0x0060E284 File Offset: 0x0060C484
	protected override void OnAfterShow()
	{
		UiManager.Instance.CloseView(EUiViewName.TimeOfDayLoadingView, null);
	}

	// Token: 0x020083B2 RID: 33714
	private static class EComponents
	{
		// Token: 0x0402A835 RID: 174133
		public const int Arrow = 0;
	}
}
