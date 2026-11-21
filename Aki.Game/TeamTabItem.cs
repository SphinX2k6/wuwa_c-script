using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000AB0 RID: 2736
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class TeamTabItem : GridProxyAbstract<string>
{
	// Token: 0x0600728E RID: 29326 RVA: 0x002347C0 File Offset: 0x002329C0
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

	// Token: 0x0600728F RID: 29327 RVA: 0x00234887 File Offset: 0x00232A87
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06007290 RID: 29328 RVA: 0x0023489B File Offset: 0x00232A9B
	public override void Refresh(string data, bool isSelected, int gridIndex)
	{
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.ShowTextNew(data);
		}
		this.SetSelectedState(isSelected);
	}

	// Token: 0x06007291 RID: 29329 RVA: 0x002348B7 File Offset: 0x00232AB7
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelectedState(true);
	}

	// Token: 0x06007292 RID: 29330 RVA: 0x002348C0 File Offset: 0x00232AC0
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelectedState(false);
	}

	// Token: 0x06007293 RID: 29331 RVA: 0x002348C9 File Offset: 0x00232AC9
	public void SetToggleClickCallback(Action<int> callback)
	{
		this.ToggleClickCallback = callback;
	}

	// Token: 0x06007294 RID: 29332 RVA: 0x002348D2 File Offset: 0x00232AD2
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

	// Token: 0x06007295 RID: 29333 RVA: 0x002348EF File Offset: 0x00232AEF
	private void SetSelectedState(bool selected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0400479B RID: 18331
	[Nullable(2)]
	private Action<int> ToggleClickCallback;
}
