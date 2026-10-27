using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001863 RID: 6243
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MainPropertyItem : GridProxyAbstract<FilterItemData>
{
	// Token: 0x0600B70D RID: 46861 RVA: 0x00295D50 File Offset: 0x00293F50
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickDelete));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B70E RID: 46862 RVA: 0x00295E17 File Offset: 0x00294017
	private void OnClickDelete()
	{
		if (this.Data != null && this.OnDeleteCallback != null)
		{
			this.OnDeleteCallback(this.Data.FilterId);
		}
	}

	// Token: 0x0600B70F RID: 46863 RVA: 0x00295E40 File Offset: 0x00294040
	public override void Refresh(FilterItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetText(data.Content ?? "", true);
		}
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			IReadOnlyList<int> costByMainMainProp = FilterConfig.Instance.GetCostByMainMainProp(data.FilterId);
			if (costByMainMainProp.Count > 1)
			{
				text2.SetText("-", true);
				return;
			}
			switch (costByMainMainProp[0])
			{
			case 1:
				text2.ShowTextNew("Cost1");
				return;
			case 2:
				break;
			case 3:
				text2.ShowTextNew("Cost3");
				return;
			case 4:
				text2.ShowTextNew("Cost4");
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x0600B710 RID: 46864 RVA: 0x00295EEB File Offset: 0x002940EB
	public void SetDeleteCallback(Action<int> callback)
	{
		this.OnDeleteCallback = callback;
	}

	// Token: 0x040052A5 RID: 21157
	[Nullable(2)]
	public FilterItemData Data;

	// Token: 0x040052A6 RID: 21158
	[Nullable(2)]
	public Action<int> OnDeleteCallback;

	// Token: 0x02007E22 RID: 32290
	[NullableContext(0)]
	private class EMainPropertyItemDefine
	{
		// Token: 0x04029486 RID: 169094
		public const int Item = 0;

		// Token: 0x04029487 RID: 169095
		public const int TxtCost = 1;

		// Token: 0x04029488 RID: 169096
		public const int TxtPropertyName = 2;

		// Token: 0x04029489 RID: 169097
		public const int BtnDelete = 3;
	}
}
