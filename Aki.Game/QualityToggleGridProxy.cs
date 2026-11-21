using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000D1A RID: 3354
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class QualityToggleGridProxy : GridProxyAbstract<FilterItemData>
{
	// Token: 0x06008AEA RID: 35562 RVA: 0x002A0158 File Offset: 0x0029E358
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

	// Token: 0x06008AEB RID: 35563 RVA: 0x002A0200 File Offset: 0x0029E400
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

	// Token: 0x06008AEC RID: 35564 RVA: 0x002A0264 File Offset: 0x0029E464
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

	// Token: 0x06008AED RID: 35565 RVA: 0x002A02B5 File Offset: 0x0029E4B5
	public void SetToggleFunction(TQualityToggleFunction func)
	{
		this.ToggleFunction = func;
	}

	// Token: 0x06008AEE RID: 35566 RVA: 0x002A02C0 File Offset: 0x0029E4C0
	public void SetSelectedState(bool isSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x0400534C RID: 21324
	[Nullable(2)]
	private TQualityToggleFunction ToggleFunction;

	// Token: 0x0400534D RID: 21325
	[Nullable(2)]
	public FilterItemData Data;

	// Token: 0x02006FA7 RID: 28583
	[NullableContext(0)]
	private class EQualityToggleDefine
	{
		// Token: 0x040247AF RID: 149423
		public const int Toggle = 0;

		// Token: 0x040247B0 RID: 149424
		public const int QualityText = 1;
	}
}
