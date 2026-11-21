using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000637 RID: 1591
[NullableContext(2)]
[Nullable(0)]
public class TogTabItemSubComponent : UiPanelBase
{
	// Token: 0x06004A27 RID: 18983 RVA: 0x00193650 File Offset: 0x00191850
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

	// Token: 0x06004A28 RID: 18984 RVA: 0x001936BC File Offset: 0x001918BC
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

	// Token: 0x06004A29 RID: 18985 RVA: 0x00193709 File Offset: 0x00191909
	private void OnToggleStateChangeHandler(EToggleState state)
	{
		Action<EToggleState> onToggleStateChange = this.OnToggleStateChange;
		if (onToggleStateChange == null)
		{
			return;
		}
		onToggleStateChange(state);
	}

	// Token: 0x06004A2A RID: 18986 RVA: 0x0019371C File Offset: 0x0019191C
	public UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06004A2B RID: 18987 RVA: 0x00193725 File Offset: 0x00191925
	public UUIText GetTabText()
	{
		return base.GetText(1);
	}

	// Token: 0x06004A2C RID: 18988 RVA: 0x00193730 File Offset: 0x00191930
	public void SetToggleState(EToggleState state)
	{
		UUIExtendToggle tabToggle = this.GetTabToggle();
		if (tabToggle != null)
		{
			tabToggle.SetToggleState(state, false, false, false);
		}
	}

	// Token: 0x04003702 RID: 14082
	public Action<EToggleState> OnToggleStateChange;

	// Token: 0x020068EA RID: 26858
	[NullableContext(0)]
	private class ETogTabItem
	{
		// Token: 0x04022937 RID: 141623
		public const int TogTabItem = 0;

		// Token: 0x04022938 RID: 141624
		public const int TogIText = 1;
	}
}
