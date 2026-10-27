using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001914 RID: 6420
public class MediumItemGridEmptyComponent : MediumItemGridVisibleComponent
{
	// Token: 0x0600BC0F RID: 48143 RVA: 0x002AA04C File Offset: 0x002A824C
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
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600BC10 RID: 48144 RVA: 0x002AA0D1 File Offset: 0x002A82D1
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBtnEmpty";
	}

	// Token: 0x0600BC11 RID: 48145 RVA: 0x002AA0D8 File Offset: 0x002A82D8
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x0600BC12 RID: 48146 RVA: 0x002AA0DB File Offset: 0x002A82DB
	protected override void OnDeactivate()
	{
		this.OnClickedCallback = null;
	}

	// Token: 0x0600BC13 RID: 48147 RVA: 0x002AA0E4 File Offset: 0x002A82E4
	private void OnBtnClick()
	{
		Action onClickedCallback = this.OnClickedCallback;
		if (onClickedCallback == null)
		{
			return;
		}
		onClickedCallback();
	}

	// Token: 0x0600BC14 RID: 48148 RVA: 0x002AA0F6 File Offset: 0x002A82F6
	public void SetClickable(bool isClickable)
	{
		this.IsClickable = isClickable;
		this.UpdateClickable();
	}

	// Token: 0x0600BC15 RID: 48149 RVA: 0x002AA105 File Offset: 0x002A8305
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		base.OnRefresh(data);
		this.UpdateClickable();
	}

	// Token: 0x0600BC16 RID: 48150 RVA: 0x002AA114 File Offset: 0x002A8314
	private void UpdateClickable()
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(this.IsClickable);
	}

	// Token: 0x0400552F RID: 21807
	[Nullable(2)]
	public Action OnClickedCallback;

	// Token: 0x04005530 RID: 21808
	private bool IsClickable;

	// Token: 0x02007E87 RID: 32391
	private class EChildType
	{
		// Token: 0x04029654 RID: 169556
		public const int BtnRoot = 0;
	}
}
