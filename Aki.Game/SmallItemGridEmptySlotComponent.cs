using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000E35 RID: 3637
public class SmallItemGridEmptySlotComponent : SmallItemGridVisibleComponent
{
	// Token: 0x060092E6 RID: 37606 RVA: 0x002BDDA8 File Offset: 0x002BBFA8
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

	// Token: 0x060092E7 RID: 37607 RVA: 0x002BDE2D File Offset: 0x002BC02D
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBStateAdd";
	}

	// Token: 0x060092E8 RID: 37608 RVA: 0x002BDE34 File Offset: 0x002BC034
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x060092E9 RID: 37609 RVA: 0x002BDE37 File Offset: 0x002BC037
	protected override void OnDeactivate()
	{
		this.OnClickedCallback = null;
	}

	// Token: 0x060092EA RID: 37610 RVA: 0x002BDE40 File Offset: 0x002BC040
	[NullableContext(1)]
	public void BindEmptySlotButtonCallback(Action onClickedEmptySlotButton)
	{
		this.OnClickedCallback = onClickedEmptySlotButton;
	}

	// Token: 0x060092EB RID: 37611 RVA: 0x002BDE49 File Offset: 0x002BC049
	public void UnBindEmptySlotButtonCallback()
	{
		this.OnClickedCallback = null;
	}

	// Token: 0x060092EC RID: 37612 RVA: 0x002BDE52 File Offset: 0x002BC052
	private void OnClickedEmptySlotButton()
	{
		if (this.OnClickedCallback != null)
		{
			this.OnClickedCallback();
		}
	}

	// Token: 0x04005675 RID: 22133
	[Nullable(2)]
	private Action OnClickedCallback;

	// Token: 0x02007053 RID: 28755
	private enum EChildType
	{
		// Token: 0x04024A3E RID: 150078
		AddButton
	}
}
