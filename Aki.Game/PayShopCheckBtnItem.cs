using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001864 RID: 6244
[NullableContext(2)]
[Nullable(0)]
public class PayShopCheckBtnItem : UiPanelBase
{
	// Token: 0x170017D7 RID: 6103
	// (get) Token: 0x0600F743 RID: 63299 RVA: 0x00484755 File Offset: 0x00482955
	// (set) Token: 0x0600F744 RID: 63300 RVA: 0x0048475D File Offset: 0x0048295D
	public Action Callback { get; set; }

	// Token: 0x0600F745 RID: 63301 RVA: 0x00484766 File Offset: 0x00482966
	[NullableContext(1)]
	public void SetCallback(Action callback)
	{
		this.Callback = callback;
	}

	// Token: 0x0600F746 RID: 63302 RVA: 0x00484770 File Offset: 0x00482970
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

	// Token: 0x0600F747 RID: 63303 RVA: 0x004847F5 File Offset: 0x004829F5
	private void OnClickCheck()
	{
		Action callback = this.Callback;
		if (callback == null)
		{
			return;
		}
		callback();
	}

	// Token: 0x02007AAC RID: 31404
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04027C46 RID: 162886
		BtnCheck
	}
}
