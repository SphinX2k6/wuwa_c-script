using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002BF9 RID: 11257
[Nullable(new byte[]
{
	0,
	1
})]
public class TowerFormationTeamTabItem : GridProxyAbstract<string>
{
	// Token: 0x0601761F RID: 95775 RVA: 0x005F3268 File Offset: 0x005F1468
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

	// Token: 0x06017620 RID: 95776 RVA: 0x005F332F File Offset: 0x005F152F
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06017621 RID: 95777 RVA: 0x005F3343 File Offset: 0x005F1543
	[NullableContext(1)]
	public override void Refresh(string data, bool isSelected, int gridIndex)
	{
		base.GetText(1).ShowTextNew(data);
		this.SetToggleState(isSelected);
	}

	// Token: 0x06017622 RID: 95778 RVA: 0x005F3359 File Offset: 0x005F1559
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

	// Token: 0x06017623 RID: 95779 RVA: 0x005F3378 File Offset: 0x005F1578
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x06017624 RID: 95780 RVA: 0x005F3381 File Offset: 0x005F1581
	private void SetToggleState(bool isOn)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06017625 RID: 95781 RVA: 0x005F339E File Offset: 0x005F159E
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

	// Token: 0x0400AEF6 RID: 44790
	[Nullable(2)]
	public Action<int> OnSelectCallback;

	// Token: 0x020091BD RID: 37309
	private enum EChildType
	{
		// Token: 0x0402F26A RID: 193130
		Toggle,
		// Token: 0x0402F26B RID: 193131
		Text,
		// Token: 0x0402F26C RID: 193132
		RedDotItem
	}
}
