using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000DCE RID: 3534
public class MediumItemGridEmptySlotComponent : MediumItemGridVisibleComponent
{
	// Token: 0x06009002 RID: 36866 RVA: 0x002B4894 File Offset: 0x002B2A94
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

	// Token: 0x06009003 RID: 36867 RVA: 0x002B4919 File Offset: 0x002B2B19
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBtnAdd";
	}

	// Token: 0x06009004 RID: 36868 RVA: 0x002B4920 File Offset: 0x002B2B20
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x06009005 RID: 36869 RVA: 0x002B4923 File Offset: 0x002B2B23
	protected override void OnDeactivate()
	{
		this.OnClickedCallback = null;
	}

	// Token: 0x06009006 RID: 36870 RVA: 0x002B492C File Offset: 0x002B2B2C
	[NullableContext(1)]
	public void BindEmptySlotButtonCallback(Action onClickedEmptySlotButton)
	{
		this.OnClickedCallback = onClickedEmptySlotButton;
	}

	// Token: 0x06009007 RID: 36871 RVA: 0x002B4935 File Offset: 0x002B2B35
	public void UnBindEmptySlotButtonCallback()
	{
		this.OnClickedCallback = null;
	}

	// Token: 0x06009008 RID: 36872 RVA: 0x002B493E File Offset: 0x002B2B3E
	private void OnClickedEmptySlotButton()
	{
		Action onClickedCallback = this.OnClickedCallback;
		if (onClickedCallback == null)
		{
			return;
		}
		onClickedCallback();
	}

	// Token: 0x040055DC RID: 21980
	[Nullable(2)]
	private Action OnClickedCallback;

	// Token: 0x0200700F RID: 28687
	private class EChildType
	{
		// Token: 0x04024981 RID: 149889
		public const int AddButton = 0;
	}
}
