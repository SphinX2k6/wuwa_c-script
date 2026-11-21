using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CA4 RID: 3236
public class CommonDynamicBtnItem : UiPanelBase
{
	// Token: 0x0600871A RID: 34586 RVA: 0x00292460 File Offset: 0x00290660
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

	// Token: 0x0600871B RID: 34587 RVA: 0x002924E5 File Offset: 0x002906E5
	[NullableContext(1)]
	public void SetFunction(Action callback)
	{
		this._callBack = callback;
	}

	// Token: 0x0600871C RID: 34588 RVA: 0x002924EE File Offset: 0x002906EE
	private void OnButtonClick()
	{
		if (this._callBack != null)
		{
			this._callBack();
		}
	}

	// Token: 0x040051C8 RID: 20936
	[Nullable(2)]
	private Action _callBack;

	// Token: 0x02006F5F RID: 28511
	private class EComponent
	{
		// Token: 0x04024642 RID: 149058
		public const int Btn = 0;
	}
}
