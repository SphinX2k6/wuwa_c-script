using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017E9 RID: 6121
[NullableContext(1)]
[Nullable(0)]
public class ButtonItem : UiPanelBase
{
	// Token: 0x0600B30E RID: 45838 RVA: 0x00287844 File Offset: 0x00285A44
	[NullableContext(2)]
	public ButtonItem(UUIItem uiItem = null)
	{
		if (uiItem != null)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}
	}

	// Token: 0x0600B30F RID: 45839 RVA: 0x0028785C File Offset: 0x00285A5C
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

	// Token: 0x0600B310 RID: 45840 RVA: 0x00287923 File Offset: 0x00285B23
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x0600B311 RID: 45841 RVA: 0x0028792B File Offset: 0x00285B2B
	private void ButtonClick()
	{
		if (this.ButtonFunction != null)
		{
			this.ButtonFunction(this.Data);
		}
	}

	// Token: 0x0600B312 RID: 45842 RVA: 0x00287948 File Offset: 0x00285B48
	public void SetButtonAllowEventBubbleUp(bool value)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.AllowEventBubbleUp = value;
		}
	}

	// Token: 0x0600B313 RID: 45843 RVA: 0x00287968 File Offset: 0x00285B68
	public void SetText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			text2.SetText(text, true);
		}
	}

	// Token: 0x0600B314 RID: 45844 RVA: 0x00287988 File Offset: 0x00285B88
	public void SetLocalText(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(1), textId, args);
	}

	// Token: 0x0600B315 RID: 45845 RVA: 0x0028799D File Offset: 0x00285B9D
	public void SetLocalTextNew(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x0600B316 RID: 45846 RVA: 0x002879B2 File Offset: 0x00285BB2
	public void TrySetLocalTextNew(string textId, params object[] args)
	{
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x0600B317 RID: 45847 RVA: 0x002879C7 File Offset: 0x00285BC7
	public void SetShowText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.ShowTextNew(text);
	}

	// Token: 0x0600B318 RID: 45848 RVA: 0x002879DB File Offset: 0x00285BDB
	public void SetTextShowState(bool state)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(state);
	}

	// Token: 0x0600B319 RID: 45849 RVA: 0x002879EF File Offset: 0x00285BEF
	public void SetData(int data)
	{
		this.Data = data;
	}

	// Token: 0x0600B31A RID: 45850 RVA: 0x002879F8 File Offset: 0x00285BF8
	public void SetEnableClick(bool state)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(state);
	}

	// Token: 0x0600B31B RID: 45851 RVA: 0x00287A0C File Offset: 0x00285C0C
	public void SetFunction(Action<int> buttonFunction)
	{
		this.ButtonFunction = buttonFunction;
	}

	// Token: 0x0600B31C RID: 45852 RVA: 0x00287A15 File Offset: 0x00285C15
	public void ExecuteButtonFunction()
	{
		if (this.ButtonFunction != null)
		{
			this.ButtonFunction(this.Data);
		}
	}

	// Token: 0x0600B31D RID: 45853 RVA: 0x00287A30 File Offset: 0x00285C30
	public void SetRedDotVisible(bool bVisible)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x0600B31E RID: 45854 RVA: 0x00287A44 File Offset: 0x00285C44
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
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
			RedDotController.Instance.BindRedDot(redDotName, item, null, uId);
		}
	}

	// Token: 0x0600B31F RID: 45855 RVA: 0x00287A8C File Offset: 0x00285C8C
	public void BindGivenUid(ERedDotName redDotName, int uId)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, item, null, uId);
		}
	}

	// Token: 0x0600B320 RID: 45856 RVA: 0x00287ACC File Offset: 0x00285CCC
	public void UnBindGivenUid(int uId)
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), uId);
		}
	}

	// Token: 0x0600B321 RID: 45857 RVA: 0x00287AF8 File Offset: 0x00285CF8
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x0600B322 RID: 45858 RVA: 0x00287B28 File Offset: 0x00285D28
	[NullableContext(2)]
	public UUIButtonComponent GetBtn()
	{
		return base.GetButton(0);
	}

	// Token: 0x04005117 RID: 20759
	private int Data;

	// Token: 0x04005118 RID: 20760
	private ERedDotName? RedDotName;

	// Token: 0x04005119 RID: 20761
	[Nullable(2)]
	private Action<int> ButtonFunction;

	// Token: 0x02007DD6 RID: 32214
	[NullableContext(0)]
	private class EButtonItemDefine
	{
		// Token: 0x04029310 RID: 168720
		public const int Button = 0;

		// Token: 0x04029311 RID: 168721
		public const int ButtonText = 1;

		// Token: 0x04029312 RID: 168722
		public const int RedDot = 2;
	}
}
