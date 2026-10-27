using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017E8 RID: 6120
[NullableContext(1)]
[Nullable(0)]
public class ButtonAndTextItem : UiPanelBase
{
	// Token: 0x0600B305 RID: 45829 RVA: 0x002876F9 File Offset: 0x002858F9
	public ButtonAndTextItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600B306 RID: 45830 RVA: 0x00287710 File Offset: 0x00285910
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
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B307 RID: 45831 RVA: 0x002877B6 File Offset: 0x002859B6
	public void RefreshText(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(1), textId, args);
	}

	// Token: 0x0600B308 RID: 45832 RVA: 0x002877CB File Offset: 0x002859CB
	public void RefreshTextNew(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x0600B309 RID: 45833 RVA: 0x002877E0 File Offset: 0x002859E0
	public void SetText(string content)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(content, true);
	}

	// Token: 0x0600B30A RID: 45834 RVA: 0x002877F5 File Offset: 0x002859F5
	public void SetTextColor(FColor newColor)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetColor(newColor);
	}

	// Token: 0x0600B30B RID: 45835 RVA: 0x00287809 File Offset: 0x00285A09
	public void RefreshEnable(bool isEnable)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(isEnable);
	}

	// Token: 0x0600B30C RID: 45836 RVA: 0x0028781D File Offset: 0x00285A1D
	public void BindCallback(Action onCallback)
	{
		if (this.OnCallback != null)
		{
			return;
		}
		this.OnCallback = onCallback;
	}

	// Token: 0x0600B30D RID: 45837 RVA: 0x0028782F File Offset: 0x00285A2F
	private void OnClick()
	{
		if (this.OnCallback != null)
		{
			this.OnCallback();
		}
	}

	// Token: 0x04005116 RID: 20758
	[Nullable(2)]
	private Action OnCallback;

	// Token: 0x02007DD5 RID: 32213
	[NullableContext(0)]
	private class EButtonItemDefine
	{
		// Token: 0x0402930E RID: 168718
		public const int Button = 0;

		// Token: 0x0402930F RID: 168719
		public const int Text = 1;
	}
}
