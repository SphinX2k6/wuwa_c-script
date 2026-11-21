using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02000DE4 RID: 3556
[NullableContext(2)]
[Nullable(0)]
public class MediumItemGridReduceButtonComponent : MediumItemGridComponent
{
	// Token: 0x06009078 RID: 36984 RVA: 0x002B5404 File Offset: 0x002B3604
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
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedReduceButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009079 RID: 36985 RVA: 0x002B5489 File Offset: 0x002B3689
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBtnReduce";
	}

	// Token: 0x0600907A RID: 36986 RVA: 0x002B5490 File Offset: 0x002B3690
	protected override void OnInitialize()
	{
		this.LongPressButton = new LongPressButtonItem(null, null, null);
	}

	// Token: 0x0600907B RID: 36987 RVA: 0x002B54BC File Offset: 0x002B36BC
	protected override void OnStart()
	{
		UUIButtonComponent button = base.GetButton(0);
		LongPressButtonItem longPressButton = this.LongPressButton;
		if (longPressButton == null)
		{
			return;
		}
		longPressButton.Initialize(button, new Action<bool>(this.OnLongPressActive), null, null, null);
	}

	// Token: 0x0600907C RID: 36988 RVA: 0x002B54F8 File Offset: 0x002B36F8
	protected override void OnDeactivate()
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.OnPointDownCallBack.Unbind();
		}
		if (button != null)
		{
			button.OnPointUpCallBack.Unbind();
		}
		LongPressButtonItem longPressButton = this.LongPressButton;
		if (longPressButton != null)
		{
			longPressButton.Clear();
		}
		this.LongPressButton = null;
		this.LongPressConfigId = null;
		this.OnClickedCallback = null;
	}

	// Token: 0x0600907D RID: 36989 RVA: 0x002B5558 File Offset: 0x002B3758
	protected override void OnRefresh(object data)
	{
		LongPressButton longPressButton = data as LongPressButton;
		if (longPressButton == null)
		{
			return;
		}
		bool? isVisible = longPressButton.IsVisible;
		LongPressButtonItem.ELongPressConfigId? longPressConfigId = longPressButton.LongPressConfigId;
		this.LongPressConfigId = longPressConfigId;
		this.SetActive(isVisible.GetValueOrDefault());
		if (this.LongPressConfigId != null && this.LongPressButton != null && !this.LongPressButton.IsActivate())
		{
			this.LongPressButton.Activate(this.LongPressConfigId.Value);
		}
	}

	// Token: 0x0600907E RID: 36990 RVA: 0x002B55CA File Offset: 0x002B37CA
	private void OnLongPressActive(bool isShortPress)
	{
		Action<bool> onLongPressClickCallback = this.OnLongPressClickCallback;
		if (onLongPressClickCallback == null)
		{
			return;
		}
		onLongPressClickCallback(isShortPress);
	}

	// Token: 0x0600907F RID: 36991 RVA: 0x002B55DD File Offset: 0x002B37DD
	[NullableContext(1)]
	public void BindReduceButtonCallback(Action onClickedReduceButton)
	{
		this.OnClickedCallback = onClickedReduceButton;
	}

	// Token: 0x06009080 RID: 36992 RVA: 0x002B55E6 File Offset: 0x002B37E6
	public void UnBindReduceButtonCallback()
	{
		this.OnClickedCallback = null;
	}

	// Token: 0x06009081 RID: 36993 RVA: 0x002B55EF File Offset: 0x002B37EF
	[NullableContext(1)]
	public void BindLongPressCallback(Action<bool> callback)
	{
		this.OnLongPressClickCallback = callback;
	}

	// Token: 0x06009082 RID: 36994 RVA: 0x002B55F8 File Offset: 0x002B37F8
	public void UnBindLongPressCallback()
	{
		this.OnLongPressClickCallback = null;
		LongPressButtonItem longPressButton = this.LongPressButton;
		if (longPressButton == null)
		{
			return;
		}
		longPressButton.Deactivate();
	}

	// Token: 0x06009083 RID: 36995 RVA: 0x002B5611 File Offset: 0x002B3811
	private void OnClickedReduceButton()
	{
		Action onClickedCallback = this.OnClickedCallback;
		if (onClickedCallback == null)
		{
			return;
		}
		onClickedCallback();
	}

	// Token: 0x06009084 RID: 36996 RVA: 0x002B5623 File Offset: 0x002B3823
	public UUIButtonComponent GetReduceButton()
	{
		return base.GetButton(0);
	}

	// Token: 0x040055EA RID: 21994
	private Action OnClickedCallback;

	// Token: 0x040055EB RID: 21995
	private LongPressButtonItem LongPressButton;

	// Token: 0x040055EC RID: 21996
	private Action<bool> OnLongPressClickCallback;

	// Token: 0x040055ED RID: 21997
	private LongPressButtonItem.ELongPressConfigId? LongPressConfigId;

	// Token: 0x02007018 RID: 28696
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x04024997 RID: 149911
		public const int ReduceButton = 0;
	}
}
