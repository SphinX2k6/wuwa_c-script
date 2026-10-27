using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C7B RID: 7291
public class ButtonFunctionComponent : UiPanelBase
{
	// Token: 0x0600DBE8 RID: 56296 RVA: 0x00332C98 File Offset: 0x00330E98
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
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600DBE9 RID: 56297 RVA: 0x00332D1D File Offset: 0x00330F1D
	[NullableContext(1)]
	public void SetFunction(Action callback)
	{
		this.CallBack = callback;
	}

	// Token: 0x0600DBEA RID: 56298 RVA: 0x00332D26 File Offset: 0x00330F26
	private void OnButtonClick()
	{
		this.CallBack();
	}

	// Token: 0x040064E8 RID: 25832
	[Nullable(1)]
	private Action CallBack = delegate()
	{
	};

	// Token: 0x02008239 RID: 33337
	private enum EComponent
	{
		// Token: 0x0402A7D0 RID: 174032
		JumpBtn
	}
}
