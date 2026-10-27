using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017EB RID: 6123
public class CommonDynamicBtnItem : UiPanelBase
{
	// Token: 0x0600B330 RID: 45872 RVA: 0x00287D8C File Offset: 0x00285F8C
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

	// Token: 0x0600B331 RID: 45873 RVA: 0x00287E11 File Offset: 0x00286011
	[NullableContext(1)]
	public void SetFunction(Action callback)
	{
		this._callBack = callback;
	}

	// Token: 0x0600B332 RID: 45874 RVA: 0x00287E1A File Offset: 0x0028601A
	private void OnButtonClick()
	{
		if (this._callBack != null)
		{
			this._callBack();
		}
	}

	// Token: 0x0400511D RID: 20765
	[Nullable(2)]
	private Action _callBack;

	// Token: 0x02007DD9 RID: 32217
	private class EComponent
	{
		// Token: 0x04029317 RID: 168727
		public const int Btn = 0;
	}
}
