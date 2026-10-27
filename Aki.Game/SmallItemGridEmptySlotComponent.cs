using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001978 RID: 6520
public class SmallItemGridEmptySlotComponent : SmallItemGridVisibleComponent
{
	// Token: 0x0600BEDE RID: 48862 RVA: 0x002B2E24 File Offset: 0x002B1024
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedEmptySlotButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600BEDF RID: 48863 RVA: 0x002B2EA9 File Offset: 0x002B10A9
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBStateAdd";
	}

	// Token: 0x0600BEE0 RID: 48864 RVA: 0x002B2EB0 File Offset: 0x002B10B0
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x0600BEE1 RID: 48865 RVA: 0x002B2EB3 File Offset: 0x002B10B3
	protected override void OnDeactivate()
	{
		this.OnClickedCallback = null;
	}

	// Token: 0x0600BEE2 RID: 48866 RVA: 0x002B2EBC File Offset: 0x002B10BC
	[NullableContext(1)]
	public void BindEmptySlotButtonCallback(Action onClickedEmptySlotButton)
	{
		this.OnClickedCallback = onClickedEmptySlotButton;
	}

	// Token: 0x0600BEE3 RID: 48867 RVA: 0x002B2EC5 File Offset: 0x002B10C5
	public void UnBindEmptySlotButtonCallback()
	{
		this.OnClickedCallback = null;
	}

	// Token: 0x0600BEE4 RID: 48868 RVA: 0x002B2ECE File Offset: 0x002B10CE
	private void OnClickedEmptySlotButton()
	{
		if (this.OnClickedCallback != null)
		{
			this.OnClickedCallback();
		}
	}

	// Token: 0x040055C8 RID: 21960
	[Nullable(2)]
	private Action OnClickedCallback;

	// Token: 0x02007EC4 RID: 32452
	private enum EChildType
	{
		// Token: 0x04029701 RID: 169729
		AddButton
	}
}
