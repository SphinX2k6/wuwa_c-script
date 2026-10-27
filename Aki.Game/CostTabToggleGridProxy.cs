using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001869 RID: 6249
public class CostTabToggleGridProxy : GridProxyAbstract<int>
{
	// Token: 0x0600B754 RID: 46932 RVA: 0x00297170 File Offset: 0x00295370
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
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleChanged));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B755 RID: 46933 RVA: 0x00297237 File Offset: 0x00295437
	private void OnToggleChanged(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked && this.ToggleFunction != null)
		{
			this.ToggleFunction(this.Cost);
		}
	}

	// Token: 0x0600B756 RID: 46934 RVA: 0x00297258 File Offset: 0x00295458
	public override void Refresh(int cost, bool isSelected, int gridIndex)
	{
		this.Cost = cost;
		UUIText text = base.GetText(1);
		string key;
		if (text != null && this.visionRefineCostTextIdRecord.TryGetValue(cost, out key))
		{
			text.ShowTextNew(key);
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x0600B757 RID: 46935 RVA: 0x002972AA File Offset: 0x002954AA
	[NullableContext(1)]
	public void SetToggleFunction(TCostTabToggleFunction func)
	{
		this.ToggleFunction = func;
	}

	// Token: 0x0600B758 RID: 46936 RVA: 0x002972B4 File Offset: 0x002954B4
	public void SetSelectedState(bool isSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x0600B759 RID: 46937 RVA: 0x002972E0 File Offset: 0x002954E0
	public void SetMarkVisible(bool visible)
	{
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(visible);
		}
	}

	// Token: 0x040052B9 RID: 21177
	[Nullable(1)]
	public Dictionary<int, string> visionRefineCostTextIdRecord = new Dictionary<int, string>
	{
		{
			1,
			"Cost1"
		},
		{
			3,
			"Cost3"
		},
		{
			4,
			"Cost4"
		}
	};

	// Token: 0x040052BA RID: 21178
	[Nullable(2)]
	private TCostTabToggleFunction ToggleFunction;

	// Token: 0x040052BB RID: 21179
	public int Cost;

	// Token: 0x02007E2C RID: 32300
	private class ECostTabToggleDefine
	{
		// Token: 0x040294B4 RID: 169140
		public const int Toggle = 0;

		// Token: 0x040294B5 RID: 169141
		public const int TabText = 1;

		// Token: 0x040294B6 RID: 169142
		public const int ItemChecked = 2;
	}
}
