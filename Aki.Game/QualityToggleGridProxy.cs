using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001861 RID: 6241
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class QualityToggleGridProxy : GridProxyAbstract<FilterItemData>
{
	// Token: 0x0600B701 RID: 46849 RVA: 0x00295A34 File Offset: 0x00293C34
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

	// Token: 0x0600B702 RID: 46850 RVA: 0x00295ADC File Offset: 0x00293CDC
	private void OnToggleChanged(EToggleState state)
	{
		bool isChecked = state == EToggleState.ETT_Checked;
		if (base.ScrollViewDelegate != null && this.ToggleFunction != null)
		{
			ScrollViewDelegate<QualityToggleGridProxy, FilterItemData> scrollViewDelegate = base.ScrollViewDelegate as ScrollViewDelegate<QualityToggleGridProxy, FilterItemData>;
			FilterItemData filterItemData = (scrollViewDelegate != null) ? scrollViewDelegate.TryGetCachedData(base.GridIndex) : null;
			if (filterItemData != null)
			{
				this.ToggleFunction(isChecked, filterItemData.FilterId, filterItemData.Content ?? "");
			}
		}
	}

	// Token: 0x0600B703 RID: 46851 RVA: 0x00295B40 File Offset: 0x00293D40
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

	// Token: 0x0600B704 RID: 46852 RVA: 0x00295B91 File Offset: 0x00293D91
	public void SetToggleFunction(TQualityToggleFunction func)
	{
		this.ToggleFunction = func;
	}

	// Token: 0x0600B705 RID: 46853 RVA: 0x00295B9C File Offset: 0x00293D9C
	public void SetSelectedState(bool isSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x040052A1 RID: 21153
	[Nullable(2)]
	private TQualityToggleFunction ToggleFunction;

	// Token: 0x040052A2 RID: 21154
	[Nullable(2)]
	public FilterItemData Data;

	// Token: 0x02007E20 RID: 32288
	[NullableContext(0)]
	private class EQualityToggleDefine
	{
		// Token: 0x04029482 RID: 169090
		public const int Toggle = 0;

		// Token: 0x04029483 RID: 169091
		public const int QualityText = 1;
	}
}
