using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x0200192B RID: 6443
[NullableContext(2)]
[Nullable(0)]
public class MediumItemGridReduceButtonComponent : MediumItemGridComponent
{
	// Token: 0x0600BC8E RID: 48270 RVA: 0x002AACA8 File Offset: 0x002A8EA8
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

	// Token: 0x0600BC8F RID: 48271 RVA: 0x002AAD2D File Offset: 0x002A8F2D
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBtnReduce";
	}

	// Token: 0x0600BC90 RID: 48272 RVA: 0x002AAD34 File Offset: 0x002A8F34
	protected override void OnInitialize()
	{
		this.LongPressButton = new LongPressButtonItem(null, null, null);
	}

	// Token: 0x0600BC91 RID: 48273 RVA: 0x002AAD60 File Offset: 0x002A8F60
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

	// Token: 0x0600BC92 RID: 48274 RVA: 0x002AAD9C File Offset: 0x002A8F9C
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

	// Token: 0x0600BC93 RID: 48275 RVA: 0x002AADFC File Offset: 0x002A8FFC
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

	// Token: 0x0600BC94 RID: 48276 RVA: 0x002AAE6E File Offset: 0x002A906E
	private void OnLongPressActive(bool isShortPress)
	{
		Action<bool> onLongPressClickCallback = this.OnLongPressClickCallback;
		if (onLongPressClickCallback == null)
		{
			return;
		}
		onLongPressClickCallback(isShortPress);
	}

	// Token: 0x0600BC95 RID: 48277 RVA: 0x002AAE81 File Offset: 0x002A9081
	[NullableContext(1)]
	public void BindReduceButtonCallback(Action onClickedReduceButton)
	{
		this.OnClickedCallback = onClickedReduceButton;
	}

	// Token: 0x0600BC96 RID: 48278 RVA: 0x002AAE8A File Offset: 0x002A908A
	public void UnBindReduceButtonCallback()
	{
		this.OnClickedCallback = null;
	}

	// Token: 0x0600BC97 RID: 48279 RVA: 0x002AAE93 File Offset: 0x002A9093
	[NullableContext(1)]
	public void BindLongPressCallback(Action<bool> callback)
	{
		this.OnLongPressClickCallback = callback;
	}

	// Token: 0x0600BC98 RID: 48280 RVA: 0x002AAE9C File Offset: 0x002A909C
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

	// Token: 0x0600BC99 RID: 48281 RVA: 0x002AAEB5 File Offset: 0x002A90B5
	private void OnClickedReduceButton()
	{
		Action onClickedCallback = this.OnClickedCallback;
		if (onClickedCallback == null)
		{
			return;
		}
		onClickedCallback();
	}

	// Token: 0x0600BC9A RID: 48282 RVA: 0x002AAEC7 File Offset: 0x002A90C7
	public UUIButtonComponent GetReduceButton()
	{
		return base.GetButton(0);
	}

	// Token: 0x0400553F RID: 21823
	private Action OnClickedCallback;

	// Token: 0x04005540 RID: 21824
	private LongPressButtonItem LongPressButton;

	// Token: 0x04005541 RID: 21825
	private Action<bool> OnLongPressClickCallback;

	// Token: 0x04005542 RID: 21826
	private LongPressButtonItem.ELongPressConfigId? LongPressConfigId;

	// Token: 0x02007E91 RID: 32401
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402966B RID: 169579
		public const int ReduceButton = 0;
	}
}
