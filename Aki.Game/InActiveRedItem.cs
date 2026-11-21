using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000D64 RID: 3428
[NullableContext(1)]
[Nullable(0)]
public class InActiveRedItem : UiPanelBase
{
	// Token: 0x06008CBD RID: 36029 RVA: 0x002A94FC File Offset: 0x002A76FC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnDetailButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008CBE RID: 36030 RVA: 0x002A95C3 File Offset: 0x002A77C3
	private void OnDetailButtonClick()
	{
		this.OnClickDetailButtonCall();
	}

	// Token: 0x06008CBF RID: 36031 RVA: 0x002A95D0 File Offset: 0x002A77D0
	public void BindDetailButtonCall(Action call)
	{
		this.OnClickDetailButtonCall = call;
	}

	// Token: 0x06008CC0 RID: 36032 RVA: 0x002A95DC File Offset: 0x002A77DC
	public void SetDetailButtonVisible(bool visible)
	{
		base.GetButton(2).RootUIComp.Get().SetUIActive(visible);
	}

	// Token: 0x06008CC1 RID: 36033 RVA: 0x002A9603 File Offset: 0x002A7803
	public void SetLockItemVisible(bool visible)
	{
		base.GetItem(0).SetUIActive(visible);
	}

	// Token: 0x06008CC2 RID: 36034 RVA: 0x002A9614 File Offset: 0x002A7814
	public void SetText([Nullable(2)] string textStringId, params object[] args)
	{
		UUIText text = base.GetText(1);
		LguiUtil.Instance.TrySetLocalTextNew(text, textStringId, args);
	}

	// Token: 0x04005469 RID: 21609
	private Action OnClickDetailButtonCall = delegate()
	{
	};

	// Token: 0x02006FC1 RID: 28609
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024826 RID: 149542
		LockItem,
		// Token: 0x04024827 RID: 149543
		TextInActive,
		// Token: 0x04024828 RID: 149544
		DetailButton
	}
}
