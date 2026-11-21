using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C5F RID: 3167
[NullableContext(1)]
[Nullable(0)]
public class ChatOptionButton : UiPanelBase
{
	// Token: 0x0600845A RID: 33882 RVA: 0x002884EA File Offset: 0x002866EA
	public ChatOptionButton(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600845B RID: 33883 RVA: 0x00288500 File Offset: 0x00286700
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

	// Token: 0x0600845C RID: 33884 RVA: 0x002885A6 File Offset: 0x002867A6
	private void OnClickButton()
	{
		Action clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack();
	}

	// Token: 0x0600845D RID: 33885 RVA: 0x002885B8 File Offset: 0x002867B8
	public void RefreshButtonText(string str)
	{
		base.GetText(1).SetText(str, true);
	}

	// Token: 0x0600845E RID: 33886 RVA: 0x002885C8 File Offset: 0x002867C8
	public void SetClickCallBack(Action call)
	{
		this.ClickCallBack = call;
	}

	// Token: 0x040050CD RID: 20685
	[Nullable(2)]
	private Action ClickCallBack;

	// Token: 0x02006F3D RID: 28477
	[NullableContext(0)]
	private class EChatOptionButtonType
	{
		// Token: 0x040245AC RID: 148908
		public const int Button = 0;

		// Token: 0x040245AD RID: 148909
		public const int Text = 1;
	}
}
