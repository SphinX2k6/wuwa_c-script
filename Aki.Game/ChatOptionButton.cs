using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017A6 RID: 6054
[NullableContext(1)]
[Nullable(0)]
public class ChatOptionButton : UiPanelBase
{
	// Token: 0x0600B072 RID: 45170 RVA: 0x0027DF52 File Offset: 0x0027C152
	public ChatOptionButton(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600B073 RID: 45171 RVA: 0x0027DF68 File Offset: 0x0027C168
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B074 RID: 45172 RVA: 0x0027E00E File Offset: 0x0027C20E
	private void OnClickButton()
	{
		Action clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack();
	}

	// Token: 0x0600B075 RID: 45173 RVA: 0x0027E020 File Offset: 0x0027C220
	public void RefreshButtonText(string str)
	{
		base.GetText(1).SetText(str, true);
	}

	// Token: 0x0600B076 RID: 45174 RVA: 0x0027E030 File Offset: 0x0027C230
	public void SetClickCallBack(Action call)
	{
		this.ClickCallBack = call;
	}

	// Token: 0x04005023 RID: 20515
	[Nullable(2)]
	private Action ClickCallBack;

	// Token: 0x02007DB7 RID: 32183
	[NullableContext(0)]
	private class EChatOptionButtonType
	{
		// Token: 0x04029281 RID: 168577
		public const int Button = 0;

		// Token: 0x04029282 RID: 168578
		public const int Text = 1;
	}
}
