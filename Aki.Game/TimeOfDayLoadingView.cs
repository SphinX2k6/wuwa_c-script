using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002BB6 RID: 11190
public class TimeOfDayLoadingView : UiViewBase
{
	// Token: 0x06017326 RID: 95014 RVA: 0x005E165C File Offset: 0x005DF85C
	[NullableContext(1)]
	public TimeOfDayLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06017327 RID: 95015 RVA: 0x005E1668 File Offset: 0x005DF868
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

	// Token: 0x06017328 RID: 95016 RVA: 0x005E16B0 File Offset: 0x005DF8B0
	protected override void OnAfterShow()
	{
		UiManager.Instance.CloseView(EUiViewName.TimeOfDayLoadingView, null);
	}
}
