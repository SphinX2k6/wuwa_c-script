using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002174 RID: 8564
[Nullable(new byte[]
{
	0,
	1
})]
public class TowerFormationTeamTabItem : GridProxyAbstract<string>
{
	// Token: 0x06015050 RID: 86096 RVA: 0x0061FDA4 File Offset: 0x0061DFA4
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
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06015051 RID: 86097 RVA: 0x0061FE6B File Offset: 0x0061E06B
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06015052 RID: 86098 RVA: 0x0061FE7F File Offset: 0x0061E07F
	[NullableContext(1)]
	public override void Refresh(string data, bool isSelected, int gridIndex)
	{
		base.GetText(1).ShowTextNew(data);
		this.SetToggleState(isSelected);
	}

	// Token: 0x06015053 RID: 86099 RVA: 0x0061FE95 File Offset: 0x0061E095
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
		Action<int> onSelectCallback = this.OnSelectCallback;
		if (onSelectCallback == null)
		{
			return;
		}
		onSelectCallback(base.GridIndex);
	}

	// Token: 0x06015054 RID: 86100 RVA: 0x0061FEB4 File Offset: 0x0061E0B4
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x06015055 RID: 86101 RVA: 0x0061FEBD File Offset: 0x0061E0BD
	private void SetToggleState(bool isOn)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06015056 RID: 86102 RVA: 0x0061FEDA File Offset: 0x0061E0DA
	private void OnToggle(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		IScrollViewDelegate<IGridProxy<string>, string> scrollViewDelegate = base.ScrollViewDelegate;
		if (scrollViewDelegate == null)
		{
			return;
		}
		scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, true);
	}

	// Token: 0x0400B2FB RID: 45819
	[Nullable(2)]
	public Action<int> OnSelectCallback;

	// Token: 0x02008400 RID: 33792
	private enum EChildType
	{
		// Token: 0x0402A96B RID: 174443
		Toggle,
		// Token: 0x0402A96C RID: 174444
		Text,
		// Token: 0x0402A96D RID: 174445
		RedDotItem
	}
}
