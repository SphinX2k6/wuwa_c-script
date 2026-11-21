using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000D1B RID: 3355
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class StateToggleGridProxy : GridProxyAbstract<FilterItemData>
{
	// Token: 0x06008AF0 RID: 35568 RVA: 0x002A02F4 File Offset: 0x0029E4F4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleChanged));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008AF1 RID: 35569 RVA: 0x002A039C File Offset: 0x0029E59C
	private void OnToggleChanged(EToggleState state)
	{
		bool isChecked = state == EToggleState.ETT_Checked;
		if (this.ToggleFunction != null)
		{
			this.ToggleFunction(isChecked, this.Data.FilterId, this.Data.Content ?? "");
		}
	}

	// Token: 0x06008AF2 RID: 35570 RVA: 0x002A03E4 File Offset: 0x0029E5E4
	public override void Refresh(FilterItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetText(data.Content ?? "", true);
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x06008AF3 RID: 35571 RVA: 0x002A0435 File Offset: 0x0029E635
	public void SetToggleFunction(TQualityToggleFunction func)
	{
		this.ToggleFunction = func;
	}

	// Token: 0x06008AF4 RID: 35572 RVA: 0x002A0440 File Offset: 0x0029E640
	public void SetSelectedState(bool isSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x0400534E RID: 21326
	[Nullable(2)]
	private TQualityToggleFunction ToggleFunction;

	// Token: 0x0400534F RID: 21327
	[Nullable(2)]
	public FilterItemData Data;

	// Token: 0x02006FA8 RID: 28584
	[NullableContext(0)]
	private class EStateToggleDefine
	{
		// Token: 0x040247B1 RID: 149425
		public const int Toggle = 0;

		// Token: 0x040247B2 RID: 149426
		public const int StateText = 1;
	}
}
