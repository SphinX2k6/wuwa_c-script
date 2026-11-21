using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000D0F RID: 3343
[NullableContext(2)]
[Nullable(0)]
public class FilterToggleItem : UiPanelBase
{
	// Token: 0x06008A75 RID: 35445 RVA: 0x0029EBC4 File Offset: 0x0029CDC4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008A76 RID: 35446 RVA: 0x0029EC0C File Offset: 0x0029CE0C
	protected override void OnStart()
	{
		this.Toggle = base.GetExtendToggle(0);
		UUIExtendToggle toggle = this.Toggle;
		if (toggle == null)
		{
			return;
		}
		toggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
	}

	// Token: 0x06008A77 RID: 35447 RVA: 0x0029EC3C File Offset: 0x0029CE3C
	protected override void OnBeforeDestroy()
	{
		UUIExtendToggle toggle = this.Toggle;
		if (toggle != null)
		{
			toggle.OnStateChange.Remove(new Action<EToggleState>(this.OnToggleStateChange));
		}
		this.Toggle = null;
		this.ToggleFunction = null;
	}

	// Token: 0x06008A78 RID: 35448 RVA: 0x0029EC6E File Offset: 0x0029CE6E
	private void OnToggleStateChange(EToggleState state)
	{
		Action<EToggleState> toggleFunction = this.ToggleFunction;
		if (toggleFunction == null)
		{
			return;
		}
		toggleFunction(state);
	}

	// Token: 0x06008A79 RID: 35449 RVA: 0x0029EC81 File Offset: 0x0029CE81
	[NullableContext(1)]
	public void SetFunction(Action<EToggleState> toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x06008A7A RID: 35450 RVA: 0x0029EC8A File Offset: 0x0029CE8A
	public void SetToggleState(EToggleState state)
	{
		UUIExtendToggle toggle = this.Toggle;
		if (toggle == null)
		{
			return;
		}
		toggle.SetToggleStateForce(state, false, false, false);
	}

	// Token: 0x06008A7B RID: 35451 RVA: 0x0029ECA0 File Offset: 0x0029CEA0
	public UUIItem GetFilterToggleItem()
	{
		UUIExtendToggle toggle = this.Toggle;
		if (toggle == null)
		{
			return null;
		}
		return toggle.RootUIComp.Get();
	}

	// Token: 0x0400532C RID: 21292
	private UUIExtendToggle Toggle;

	// Token: 0x0400532D RID: 21293
	private Action<EToggleState> ToggleFunction;

	// Token: 0x02006FA0 RID: 28576
	[NullableContext(0)]
	private class EFilterToggleComp
	{
		// Token: 0x0402478C RID: 149388
		public const int Toggle = 0;
	}
}
