using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200237F RID: 9087
[NullableContext(2)]
[Nullable(0)]
public class PayShopCheckBtnItem : UiPanelBase
{
	// Token: 0x1700179D RID: 6045
	// (get) Token: 0x06012293 RID: 74387 RVA: 0x004775D5 File Offset: 0x004757D5
	// (set) Token: 0x06012294 RID: 74388 RVA: 0x004775DD File Offset: 0x004757DD
	public Action Callback { get; set; }

	// Token: 0x06012295 RID: 74389 RVA: 0x004775E6 File Offset: 0x004757E6
	[NullableContext(1)]
	public void SetCallback(Action callback)
	{
		this.Callback = callback;
	}

	// Token: 0x06012296 RID: 74390 RVA: 0x004775F0 File Offset: 0x004757F0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickCheck));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06012297 RID: 74391 RVA: 0x00477675 File Offset: 0x00475875
	private void OnClickCheck()
	{
		Action callback = this.Callback;
		if (callback == null)
		{
			return;
		}
		callback();
	}

	// Token: 0x02008922 RID: 35106
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402C92E RID: 182574
		BtnCheck
	}
}
