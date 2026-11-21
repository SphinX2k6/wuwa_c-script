using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200113A RID: 4410
public class ButtonFunctionComponent : UiPanelBase
{
	// Token: 0x0600AFFE RID: 45054 RVA: 0x0033E0F8 File Offset: 0x0033C2F8
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

	// Token: 0x0600AFFF RID: 45055 RVA: 0x0033E17D File Offset: 0x0033C37D
	[NullableContext(1)]
	public void SetFunction(Action callback)
	{
		this.CallBack = callback;
	}

	// Token: 0x0600B000 RID: 45056 RVA: 0x0033E186 File Offset: 0x0033C386
	private void OnButtonClick()
	{
		this.CallBack();
	}

	// Token: 0x040065BA RID: 26042
	[Nullable(1)]
	private Action CallBack = delegate()
	{
	};

	// Token: 0x020073C2 RID: 29634
	private enum EComponent
	{
		// Token: 0x04025AF6 RID: 154358
		JumpBtn
	}
}
