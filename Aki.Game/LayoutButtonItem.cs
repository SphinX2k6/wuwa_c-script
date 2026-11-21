using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000CA7 RID: 3239
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class LayoutButtonItem : GridProxyAbstract<ButtonItemData>
{
	// Token: 0x06008723 RID: 34595 RVA: 0x002925D0 File Offset: 0x002907D0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008724 RID: 34596 RVA: 0x00292697 File Offset: 0x00290897
	private void ButtonClick()
	{
		if (this.CurrentData != null)
		{
			this.CurrentData.OnClickCallback(this.CurrentData.Index);
		}
	}

	// Token: 0x06008725 RID: 34597 RVA: 0x002926BC File Offset: 0x002908BC
	public override void Refresh(ButtonItemData data, bool isSelected, int gridIndex)
	{
		if (this.CurrentData != null && this.CurrentData.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.CurrentData.RedDotName.Value, base.GetItem(2), 0);
			RedDotController.Instance.BindRedDot(data.RedDotName.Value, base.GetItem(2), null, 0);
		}
		this.CurrentData = data;
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew(data.ButtonText);
	}

	// Token: 0x06008726 RID: 34598 RVA: 0x00292741 File Offset: 0x00290941
	protected override void OnBeforeDestroy()
	{
		if (this.CurrentData != null && this.CurrentData.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.CurrentData.RedDotName.Value, base.GetItem(2), 0);
		}
	}

	// Token: 0x06008727 RID: 34599 RVA: 0x0029277F File Offset: 0x0029097F
	public void SetEnableClick(bool state)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(state);
	}

	// Token: 0x06008728 RID: 34600 RVA: 0x00292793 File Offset: 0x00290993
	public void SetShowText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.ShowTextNew(text);
	}

	// Token: 0x06008729 RID: 34601 RVA: 0x002927A7 File Offset: 0x002909A7
	public void SetLocalText(string textId, [Nullable(new byte[]
	{
		2,
		1
	})] string[] textParams = null)
	{
		if (textParams != null)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(1), textId, textParams);
			return;
		}
		LguiUtil.Instance.SetLocalText(base.GetText(1), textId, Array.Empty<object>());
	}

	// Token: 0x0600872A RID: 34602 RVA: 0x002927D7 File Offset: 0x002909D7
	public void SetRedDotVisible(bool bVisible)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x040051CD RID: 20941
	[Nullable(2)]
	private ButtonItemData CurrentData;

	// Token: 0x02006F62 RID: 28514
	[NullableContext(0)]
	private class EButtonItemDefine
	{
		// Token: 0x04024646 RID: 149062
		public const int Button = 0;

		// Token: 0x04024647 RID: 149063
		public const int ButtonText = 1;

		// Token: 0x04024648 RID: 149064
		public const int RedDot = 2;
	}
}
