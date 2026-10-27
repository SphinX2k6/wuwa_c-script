using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018AB RID: 6315
[NullableContext(1)]
[Nullable(0)]
public class InActiveRedItem : UiPanelBase
{
	// Token: 0x0600B8D4 RID: 47316 RVA: 0x0029EDDC File Offset: 0x0029CFDC
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

	// Token: 0x0600B8D5 RID: 47317 RVA: 0x0029EEA3 File Offset: 0x0029D0A3
	private void OnDetailButtonClick()
	{
		this.OnClickDetailButtonCall();
	}

	// Token: 0x0600B8D6 RID: 47318 RVA: 0x0029EEB0 File Offset: 0x0029D0B0
	public void BindDetailButtonCall(Action call)
	{
		this.OnClickDetailButtonCall = call;
	}

	// Token: 0x0600B8D7 RID: 47319 RVA: 0x0029EEBC File Offset: 0x0029D0BC
	public void SetDetailButtonVisible(bool visible)
	{
		base.GetButton(2).RootUIComp.Get().SetUIActive(visible);
	}

	// Token: 0x0600B8D8 RID: 47320 RVA: 0x0029EEE3 File Offset: 0x0029D0E3
	public void SetLockItemVisible(bool visible)
	{
		base.GetItem(0).SetUIActive(visible);
	}

	// Token: 0x0600B8D9 RID: 47321 RVA: 0x0029EEF4 File Offset: 0x0029D0F4
	public void SetText([Nullable(2)] string textStringId, params object[] args)
	{
		UUIText text = base.GetText(1);
		LguiUtil.Instance.TrySetLocalTextNew(text, textStringId, args);
	}

	// Token: 0x040053BE RID: 21438
	private Action OnClickDetailButtonCall = delegate()
	{
	};

	// Token: 0x02007E3A RID: 32314
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040294F9 RID: 169209
		LockItem,
		// Token: 0x040294FA RID: 169210
		TextInActive,
		// Token: 0x040294FB RID: 169211
		DetailButton
	}
}
