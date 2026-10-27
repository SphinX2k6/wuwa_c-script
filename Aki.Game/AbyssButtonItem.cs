using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A1F RID: 6687
[NullableContext(1)]
[Nullable(0)]
public class AbyssButtonItem : UiPanelBase
{
	// Token: 0x0600C4CD RID: 50381 RVA: 0x002CA020 File Offset: 0x002C8220
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonCallBackInternal));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C4CE RID: 50382 RVA: 0x002CA108 File Offset: 0x002C8308
	public void RefreshRedDotVisible(bool visible)
	{
		base.GetItem(2).SetUIActive(visible);
	}

	// Token: 0x0600C4CF RID: 50383 RVA: 0x002CA117 File Offset: 0x002C8317
	public void SetNumText(string text)
	{
		base.GetText(1).SetText(text, true);
	}

	// Token: 0x0600C4D0 RID: 50384 RVA: 0x002CA127 File Offset: 0x002C8327
	public void SetNameText(string text)
	{
		base.GetText(3).SetText(text, true);
	}

	// Token: 0x0600C4D1 RID: 50385 RVA: 0x002CA137 File Offset: 0x002C8337
	private void ButtonCallBackInternal()
	{
		Action buttonCallBack = this.ButtonCallBack;
		if (buttonCallBack == null)
		{
			return;
		}
		buttonCallBack();
	}

	// Token: 0x0600C4D2 RID: 50386 RVA: 0x002CA149 File Offset: 0x002C8349
	public void SetSelfInteractive(bool interactive)
	{
		base.GetButton(0).SetSelfInteractive(interactive);
	}

	// Token: 0x0600C4D3 RID: 50387 RVA: 0x002CA158 File Offset: 0x002C8358
	public void BindClickCallBack(Action callBack)
	{
		this.ButtonCallBack = callBack;
	}

	// Token: 0x0600C4D4 RID: 50388 RVA: 0x002CA161 File Offset: 0x002C8361
	public void SetRedDotVisible(bool visible)
	{
		base.GetItem(2).SetUIActive(visible);
	}

	// Token: 0x0600C4D5 RID: 50389 RVA: 0x002CA170 File Offset: 0x002C8370
	public void BindRedDot(ERedDotName redDotName, int? uId = null)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		this.UnBindRedDot();
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, item, null, uId.GetValueOrDefault());
		}
	}

	// Token: 0x0600C4D6 RID: 50390 RVA: 0x002CA1BC File Offset: 0x002C83BC
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			UUIItem item = base.GetItem(2);
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, item, 0);
			this.RedDotName = null;
		}
	}

	// Token: 0x04005ABA RID: 23226
	private ERedDotName? RedDotName;

	// Token: 0x04005ABB RID: 23227
	[Nullable(2)]
	public Action ButtonCallBack;

	// Token: 0x02007F65 RID: 32613
	[NullableContext(0)]
	private enum EButtonComponent
	{
		// Token: 0x04029971 RID: 170353
		Button,
		// Token: 0x04029972 RID: 170354
		NumText,
		// Token: 0x04029973 RID: 170355
		RedDot,
		// Token: 0x04029974 RID: 170356
		NameText
	}
}
