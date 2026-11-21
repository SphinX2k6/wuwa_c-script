using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000DCD RID: 3533
public class MediumItemGridEmptyComponent : MediumItemGridVisibleComponent
{
	// Token: 0x06008FF9 RID: 36857 RVA: 0x002B47A8 File Offset: 0x002B29A8
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

	// Token: 0x06008FFA RID: 36858 RVA: 0x002B482D File Offset: 0x002B2A2D
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBtnEmpty";
	}

	// Token: 0x06008FFB RID: 36859 RVA: 0x002B4834 File Offset: 0x002B2A34
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x06008FFC RID: 36860 RVA: 0x002B4837 File Offset: 0x002B2A37
	protected override void OnDeactivate()
	{
		this.OnClickedCallback = null;
	}

	// Token: 0x06008FFD RID: 36861 RVA: 0x002B4840 File Offset: 0x002B2A40
	private void OnBtnClick()
	{
		Action onClickedCallback = this.OnClickedCallback;
		if (onClickedCallback == null)
		{
			return;
		}
		onClickedCallback();
	}

	// Token: 0x06008FFE RID: 36862 RVA: 0x002B4852 File Offset: 0x002B2A52
	public void SetClickable(bool isClickable)
	{
		this.IsClickable = isClickable;
		this.UpdateClickable();
	}

	// Token: 0x06008FFF RID: 36863 RVA: 0x002B4861 File Offset: 0x002B2A61
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		base.OnRefresh(data);
		this.UpdateClickable();
	}

	// Token: 0x06009000 RID: 36864 RVA: 0x002B4870 File Offset: 0x002B2A70
	private void UpdateClickable()
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(this.IsClickable);
	}

	// Token: 0x040055DA RID: 21978
	[Nullable(2)]
	public Action OnClickedCallback;

	// Token: 0x040055DB RID: 21979
	private bool IsClickable;

	// Token: 0x0200700E RID: 28686
	private class EChildType
	{
		// Token: 0x04024980 RID: 149888
		public const int BtnRoot = 0;
	}
}
