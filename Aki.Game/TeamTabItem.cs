using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020015F8 RID: 5624
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class TeamTabItem : GridProxyAbstract<string>
{
	// Token: 0x06009EB0 RID: 40624 RVA: 0x0022A9E8 File Offset: 0x00228BE8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009EB1 RID: 40625 RVA: 0x0022AAAF File Offset: 0x00228CAF
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06009EB2 RID: 40626 RVA: 0x0022AAC3 File Offset: 0x00228CC3
	public override void Refresh(string data, bool isSelected, int gridIndex)
	{
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.ShowTextNew(data);
		}
		this.SetSelectedState(isSelected);
	}

	// Token: 0x06009EB3 RID: 40627 RVA: 0x0022AADF File Offset: 0x00228CDF
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelectedState(true);
	}

	// Token: 0x06009EB4 RID: 40628 RVA: 0x0022AAE8 File Offset: 0x00228CE8
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelectedState(false);
	}

	// Token: 0x06009EB5 RID: 40629 RVA: 0x0022AAF1 File Offset: 0x00228CF1
	public void SetToggleClickCallback(Action<int> callback)
	{
		this.ToggleClickCallback = callback;
	}

	// Token: 0x06009EB6 RID: 40630 RVA: 0x0022AAFA File Offset: 0x00228CFA
	private void ToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		Action<int> toggleClickCallback = this.ToggleClickCallback;
		if (toggleClickCallback == null)
		{
			return;
		}
		toggleClickCallback(base.GridIndex);
	}

	// Token: 0x06009EB7 RID: 40631 RVA: 0x0022AB17 File Offset: 0x00228D17
	private void SetSelectedState(bool selected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x040046F5 RID: 18165
	[Nullable(2)]
	private Action<int> ToggleClickCallback;
}
