using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001862 RID: 6242
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class StateToggleGridProxy : GridProxyAbstract<FilterItemData>
{
	// Token: 0x0600B707 RID: 46855 RVA: 0x00295BD0 File Offset: 0x00293DD0
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

	// Token: 0x0600B708 RID: 46856 RVA: 0x00295C78 File Offset: 0x00293E78
	private void OnToggleChanged(EToggleState state)
	{
		bool isChecked = state == EToggleState.ETT_Checked;
		if (this.ToggleFunction != null)
		{
			this.ToggleFunction(isChecked, this.Data.FilterId, this.Data.Content ?? "");
		}
	}

	// Token: 0x0600B709 RID: 46857 RVA: 0x00295CC0 File Offset: 0x00293EC0
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

	// Token: 0x0600B70A RID: 46858 RVA: 0x00295D11 File Offset: 0x00293F11
	public void SetToggleFunction(TQualityToggleFunction func)
	{
		this.ToggleFunction = func;
	}

	// Token: 0x0600B70B RID: 46859 RVA: 0x00295D1C File Offset: 0x00293F1C
	public void SetSelectedState(bool isSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x040052A3 RID: 21155
	[Nullable(2)]
	private TQualityToggleFunction ToggleFunction;

	// Token: 0x040052A4 RID: 21156
	[Nullable(2)]
	public FilterItemData Data;

	// Token: 0x02007E21 RID: 32289
	[NullableContext(0)]
	private class EStateToggleDefine
	{
		// Token: 0x04029484 RID: 169092
		public const int Toggle = 0;

		// Token: 0x04029485 RID: 169093
		public const int StateText = 1;
	}
}
