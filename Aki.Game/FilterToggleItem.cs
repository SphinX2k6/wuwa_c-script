using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001856 RID: 6230
[NullableContext(2)]
[Nullable(0)]
public class FilterToggleItem : UiPanelBase
{
	// Token: 0x0600B68C RID: 46732 RVA: 0x00294498 File Offset: 0x00292698
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

	// Token: 0x0600B68D RID: 46733 RVA: 0x002944E0 File Offset: 0x002926E0
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

	// Token: 0x0600B68E RID: 46734 RVA: 0x00294510 File Offset: 0x00292710
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

	// Token: 0x0600B68F RID: 46735 RVA: 0x00294542 File Offset: 0x00292742
	private void OnToggleStateChange(EToggleState state)
	{
		Action<EToggleState> toggleFunction = this.ToggleFunction;
		if (toggleFunction == null)
		{
			return;
		}
		toggleFunction(state);
	}

	// Token: 0x0600B690 RID: 46736 RVA: 0x00294555 File Offset: 0x00292755
	[NullableContext(1)]
	public void SetFunction(Action<EToggleState> toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x0600B691 RID: 46737 RVA: 0x0029455E File Offset: 0x0029275E
	public void SetToggleState(EToggleState state)
	{
		UUIExtendToggle toggle = this.Toggle;
		if (toggle == null)
		{
			return;
		}
		toggle.SetToggleStateForce(state, false, false, false);
	}

	// Token: 0x0600B692 RID: 46738 RVA: 0x00294574 File Offset: 0x00292774
	public UUIItem GetFilterToggleItem()
	{
		UUIExtendToggle toggle = this.Toggle;
		if (toggle == null)
		{
			return null;
		}
		return toggle.RootUIComp.Get();
	}

	// Token: 0x04005281 RID: 21121
	private UUIExtendToggle Toggle;

	// Token: 0x04005282 RID: 21122
	private Action<EToggleState> ToggleFunction;

	// Token: 0x02007E19 RID: 32281
	[NullableContext(0)]
	private class EFilterToggleComp
	{
		// Token: 0x0402945F RID: 169055
		public const int Toggle = 0;
	}
}
