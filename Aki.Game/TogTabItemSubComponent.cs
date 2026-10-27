using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001183 RID: 4483
[NullableContext(2)]
[Nullable(0)]
public class TogTabItemSubComponent : UiPanelBase
{
	// Token: 0x06007690 RID: 30352 RVA: 0x0018AAA0 File Offset: 0x00188CA0
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
	}

	// Token: 0x06007691 RID: 30353 RVA: 0x0018AB0C File Offset: 0x00188D0C
	protected override void OnStart()
	{
		UUIExtendToggle tabToggle = this.GetTabToggle();
		if (tabToggle != null)
		{
			tabToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChangeHandler));
		}
		UUIText tabText = this.GetTabText();
		if (tabText != null)
		{
			LguiUtil.Instance.SetLocalTextNew(tabText, "BabelRanking_Anonymouskey", Array.Empty<object>());
		}
	}

	// Token: 0x06007692 RID: 30354 RVA: 0x0018AB59 File Offset: 0x00188D59
	private void OnToggleStateChangeHandler(EToggleState state)
	{
		Action<EToggleState> onToggleStateChange = this.OnToggleStateChange;
		if (onToggleStateChange == null)
		{
			return;
		}
		onToggleStateChange(state);
	}

	// Token: 0x06007693 RID: 30355 RVA: 0x0018AB6C File Offset: 0x00188D6C
	public UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06007694 RID: 30356 RVA: 0x0018AB75 File Offset: 0x00188D75
	public UUIText GetTabText()
	{
		return base.GetText(1);
	}

	// Token: 0x06007695 RID: 30357 RVA: 0x0018AB80 File Offset: 0x00188D80
	public void SetToggleState(EToggleState state)
	{
		UUIExtendToggle tabToggle = this.GetTabToggle();
		if (tabToggle != null)
		{
			tabToggle.SetToggleState(state, false, false, false);
		}
	}

	// Token: 0x04003669 RID: 13929
	public Action<EToggleState> OnToggleStateChange;

	// Token: 0x0200775D RID: 30557
	[NullableContext(0)]
	private class ETogTabItem
	{
		// Token: 0x040275FE RID: 161278
		public const int TogTabItem = 0;

		// Token: 0x040275FF RID: 161279
		public const int TogIText = 1;
	}
}
