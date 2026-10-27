using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020017EE RID: 6126
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class LayoutButtonItem : GridProxyAbstract<ButtonItemData>
{
	// Token: 0x0600B339 RID: 45881 RVA: 0x00287EFC File Offset: 0x002860FC
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

	// Token: 0x0600B33A RID: 45882 RVA: 0x00287FC3 File Offset: 0x002861C3
	private void ButtonClick()
	{
		if (this.CurrentData != null)
		{
			this.CurrentData.OnClickCallback(this.CurrentData.Index);
		}
	}

	// Token: 0x0600B33B RID: 45883 RVA: 0x00287FE8 File Offset: 0x002861E8
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

	// Token: 0x0600B33C RID: 45884 RVA: 0x0028806D File Offset: 0x0028626D
	protected override void OnBeforeDestroy()
	{
		if (this.CurrentData != null && this.CurrentData.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.CurrentData.RedDotName.Value, base.GetItem(2), 0);
		}
	}

	// Token: 0x0600B33D RID: 45885 RVA: 0x002880AB File Offset: 0x002862AB
	public void SetEnableClick(bool state)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(state);
	}

	// Token: 0x0600B33E RID: 45886 RVA: 0x002880BF File Offset: 0x002862BF
	public void SetShowText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.ShowTextNew(text);
	}

	// Token: 0x0600B33F RID: 45887 RVA: 0x002880D3 File Offset: 0x002862D3
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

	// Token: 0x0600B340 RID: 45888 RVA: 0x00288103 File Offset: 0x00286303
	public void SetRedDotVisible(bool bVisible)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x04005122 RID: 20770
	[Nullable(2)]
	private ButtonItemData CurrentData;

	// Token: 0x02007DDC RID: 32220
	[NullableContext(0)]
	private class EButtonItemDefine
	{
		// Token: 0x0402931B RID: 168731
		public const int Button = 0;

		// Token: 0x0402931C RID: 168732
		public const int ButtonText = 1;

		// Token: 0x0402931D RID: 168733
		public const int RedDot = 2;
	}
}
