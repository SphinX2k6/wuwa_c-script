using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000D22 RID: 3362
public class CostTabToggleGridProxy : GridProxyAbstract<int>
{
	// Token: 0x06008B3D RID: 35645 RVA: 0x002A1894 File Offset: 0x0029FA94
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

	// Token: 0x06008B3E RID: 35646 RVA: 0x002A195B File Offset: 0x0029FB5B
	private void OnToggleChanged(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked && this.ToggleFunction != null)
		{
			this.ToggleFunction(this.Cost);
		}
	}

	// Token: 0x06008B3F RID: 35647 RVA: 0x002A197C File Offset: 0x0029FB7C
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

	// Token: 0x06008B40 RID: 35648 RVA: 0x002A19CE File Offset: 0x0029FBCE
	[NullableContext(1)]
	public void SetToggleFunction(TCostTabToggleFunction func)
	{
		this.ToggleFunction = func;
	}

	// Token: 0x06008B41 RID: 35649 RVA: 0x002A19D8 File Offset: 0x0029FBD8
	public void SetSelectedState(bool isSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x06008B42 RID: 35650 RVA: 0x002A1A04 File Offset: 0x0029FC04
	public void SetMarkVisible(bool visible)
	{
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(visible);
		}
	}

	// Token: 0x04005364 RID: 21348
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

	// Token: 0x04005365 RID: 21349
	[Nullable(2)]
	private TCostTabToggleFunction ToggleFunction;

	// Token: 0x04005366 RID: 21350
	public int Cost;

	// Token: 0x02006FB3 RID: 28595
	private class ECostTabToggleDefine
	{
		// Token: 0x040247E1 RID: 149473
		public const int Toggle = 0;

		// Token: 0x040247E2 RID: 149474
		public const int TabText = 1;

		// Token: 0x040247E3 RID: 149475
		public const int ItemChecked = 2;
	}
}
