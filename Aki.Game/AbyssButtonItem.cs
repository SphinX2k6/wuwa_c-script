using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000EDE RID: 3806
[NullableContext(1)]
[Nullable(0)]
public class AbyssButtonItem : UiPanelBase
{
	// Token: 0x060098DD RID: 39133 RVA: 0x002D5138 File Offset: 0x002D3338
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

	// Token: 0x060098DE RID: 39134 RVA: 0x002D5220 File Offset: 0x002D3420
	public void RefreshRedDotVisible(bool visible)
	{
		base.GetItem(2).SetUIActive(visible);
	}

	// Token: 0x060098DF RID: 39135 RVA: 0x002D522F File Offset: 0x002D342F
	public void SetNumText(string text)
	{
		base.GetText(1).SetText(text, true);
	}

	// Token: 0x060098E0 RID: 39136 RVA: 0x002D523F File Offset: 0x002D343F
	public void SetNameText(string text)
	{
		base.GetText(3).SetText(text, true);
	}

	// Token: 0x060098E1 RID: 39137 RVA: 0x002D524F File Offset: 0x002D344F
	private void ButtonCallBackInternal()
	{
		Action buttonCallBack = this.ButtonCallBack;
		if (buttonCallBack == null)
		{
			return;
		}
		buttonCallBack();
	}

	// Token: 0x060098E2 RID: 39138 RVA: 0x002D5261 File Offset: 0x002D3461
	public void SetSelfInteractive(bool interactive)
	{
		base.GetButton(0).SetSelfInteractive(interactive);
	}

	// Token: 0x060098E3 RID: 39139 RVA: 0x002D5270 File Offset: 0x002D3470
	public void BindClickCallBack(Action callBack)
	{
		this.ButtonCallBack = callBack;
	}

	// Token: 0x060098E4 RID: 39140 RVA: 0x002D5279 File Offset: 0x002D3479
	public void SetRedDotVisible(bool visible)
	{
		base.GetItem(2).SetUIActive(visible);
	}

	// Token: 0x060098E5 RID: 39141 RVA: 0x002D5288 File Offset: 0x002D3488
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

	// Token: 0x060098E6 RID: 39142 RVA: 0x002D52D4 File Offset: 0x002D34D4
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			UUIItem item = base.GetItem(2);
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, item, 0);
			this.RedDotName = null;
		}
	}

	// Token: 0x04005B89 RID: 23433
	private ERedDotName? RedDotName;

	// Token: 0x04005B8A RID: 23434
	[Nullable(2)]
	public Action ButtonCallBack;

	// Token: 0x020070F4 RID: 28916
	[NullableContext(0)]
	private enum EButtonComponent
	{
		// Token: 0x04024CAE RID: 150702
		Button,
		// Token: 0x04024CAF RID: 150703
		NumText,
		// Token: 0x04024CB0 RID: 150704
		RedDot,
		// Token: 0x04024CB1 RID: 150705
		NameText
	}
}
