using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001915 RID: 6421
public class MediumItemGridEmptySlotComponent : MediumItemGridVisibleComponent
{
	// Token: 0x0600BC18 RID: 48152 RVA: 0x002AA138 File Offset: 0x002A8338
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

	// Token: 0x0600BC19 RID: 48153 RVA: 0x002AA1BD File Offset: 0x002A83BD
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBtnAdd";
	}

	// Token: 0x0600BC1A RID: 48154 RVA: 0x002AA1C4 File Offset: 0x002A83C4
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x0600BC1B RID: 48155 RVA: 0x002AA1C7 File Offset: 0x002A83C7
	protected override void OnDeactivate()
	{
		this.OnClickedCallback = null;
	}

	// Token: 0x0600BC1C RID: 48156 RVA: 0x002AA1D0 File Offset: 0x002A83D0
	[NullableContext(1)]
	public void BindEmptySlotButtonCallback(Action onClickedEmptySlotButton)
	{
		this.OnClickedCallback = onClickedEmptySlotButton;
	}

	// Token: 0x0600BC1D RID: 48157 RVA: 0x002AA1D9 File Offset: 0x002A83D9
	public void UnBindEmptySlotButtonCallback()
	{
		this.OnClickedCallback = null;
	}

	// Token: 0x0600BC1E RID: 48158 RVA: 0x002AA1E2 File Offset: 0x002A83E2
	private void OnClickedEmptySlotButton()
	{
		Action onClickedCallback = this.OnClickedCallback;
		if (onClickedCallback == null)
		{
			return;
		}
		onClickedCallback();
	}

	// Token: 0x04005531 RID: 21809
	[Nullable(2)]
	private Action OnClickedCallback;

	// Token: 0x02007E88 RID: 32392
	private class EChildType
	{
		// Token: 0x04029655 RID: 169557
		public const int AddButton = 0;
	}
}
