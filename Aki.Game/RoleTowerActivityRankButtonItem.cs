using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000981 RID: 2433
public class RoleTowerActivityRankButtonItem : UiPanelBase
{
	// Token: 0x06006AE5 RID: 27365 RVA: 0x00213CB0 File Offset: 0x00211EB0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06006AE6 RID: 27366 RVA: 0x00213D56 File Offset: 0x00211F56
	[NullableContext(1)]
	public void SetFunction(Action click)
	{
		this.Click = click;
	}

	// Token: 0x06006AE7 RID: 27367 RVA: 0x00213D5F File Offset: 0x00211F5F
	public void SetRedDotVisible(bool visible)
	{
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(visible);
	}

	// Token: 0x06006AE8 RID: 27368 RVA: 0x00213D73 File Offset: 0x00211F73
	private void OnClick()
	{
		Action click = this.Click;
		if (click == null)
		{
			return;
		}
		click();
	}

	// Token: 0x04004331 RID: 17201
	[Nullable(2)]
	private Action Click;

	// Token: 0x02006C8B RID: 27787
	private enum EChildType
	{
		// Token: 0x04023A89 RID: 146057
		Button,
		// Token: 0x04023A8A RID: 146058
		RedDot
	}
}
