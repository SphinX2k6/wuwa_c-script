using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017E6 RID: 6118
[NullableContext(1)]
[Nullable(0)]
public class ButtonAndCostItem : UiPanelBase
{
	// Token: 0x0600B2E9 RID: 45801 RVA: 0x00287210 File Offset: 0x00285410
	public UniTask Init(UUIItem uiItem)
	{
		ButtonAndCostItem.<Init>d__4 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.uiItem = uiItem;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ButtonAndCostItem.<Init>d__4>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600B2EA RID: 45802 RVA: 0x0028725C File Offset: 0x0028545C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
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
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B2EB RID: 45803 RVA: 0x00287365 File Offset: 0x00285565
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x0600B2EC RID: 45804 RVA: 0x0028736D File Offset: 0x0028556D
	private void ButtonClick()
	{
		Action<int> buttonFunction = this.ButtonFunction;
		if (buttonFunction == null)
		{
			return;
		}
		buttonFunction(this.Data);
	}

	// Token: 0x0600B2ED RID: 45805 RVA: 0x00287388 File Offset: 0x00285588
	public void SetButtonAllowEventBubbleUp(bool value)
	{
		UUIButtonComponent btn = this.GetBtn();
		if (btn != null)
		{
			btn.AllowEventBubbleUp = value;
		}
	}

	// Token: 0x0600B2EE RID: 45806 RVA: 0x002873A6 File Offset: 0x002855A6
	public void SetText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x0600B2EF RID: 45807 RVA: 0x002873BB File Offset: 0x002855BB
	public void SetLocalTextNew(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x0600B2F0 RID: 45808 RVA: 0x002873D0 File Offset: 0x002855D0
	public void SetShowText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.ShowTextNew(text);
	}

	// Token: 0x0600B2F1 RID: 45809 RVA: 0x002873E4 File Offset: 0x002855E4
	public void SetData(int data)
	{
		this.Data = data;
	}

	// Token: 0x0600B2F2 RID: 45810 RVA: 0x002873ED File Offset: 0x002855ED
	public void SetEnableClick(bool state)
	{
		UUIButtonComponent btn = this.GetBtn();
		if (btn == null)
		{
			return;
		}
		btn.SetSelfInteractive(state);
	}

	// Token: 0x0600B2F3 RID: 45811 RVA: 0x00287400 File Offset: 0x00285600
	public void SetFunction(Action<int> buttonFunction)
	{
		this.ButtonFunction = buttonFunction;
	}

	// Token: 0x0600B2F4 RID: 45812 RVA: 0x00287409 File Offset: 0x00285609
	public void SetRedDotVisible(bool bVisible)
	{
		base.GetItem(2).SetUIActive(bVisible);
	}

	// Token: 0x0600B2F5 RID: 45813 RVA: 0x00287418 File Offset: 0x00285618
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		this.UnBindRedDot();
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			UUIItem item = base.GetItem(2);
			RedDotController.Instance.BindRedDot(redDotName, item, null, uId);
		}
	}

	// Token: 0x0600B2F6 RID: 45814 RVA: 0x0028745C File Offset: 0x0028565C
	public void BindGivenUid(ERedDotName redDotName, int uId)
	{
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			UUIItem item = base.GetItem(2);
			RedDotController.Instance.BindRedDot(redDotName, item, null, uId);
		}
	}

	// Token: 0x0600B2F7 RID: 45815 RVA: 0x00287498 File Offset: 0x00285698
	public void UnBindGivenUid(int uId)
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), uId);
		}
	}

	// Token: 0x0600B2F8 RID: 45816 RVA: 0x002874C4 File Offset: 0x002856C4
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x0600B2F9 RID: 45817 RVA: 0x002874F4 File Offset: 0x002856F4
	[NullableContext(2)]
	public UUIButtonComponent GetBtn()
	{
		return base.GetButton(0);
	}

	// Token: 0x0600B2FA RID: 45818 RVA: 0x00287500 File Offset: 0x00285700
	public void UpdateCostIcon(string path)
	{
		UUITexture texture = base.GetTexture(3);
		base.SetTextureByPath(path, texture, null, null);
	}

	// Token: 0x0600B2FB RID: 45819 RVA: 0x00287527 File Offset: 0x00285727
	public void UpdateCostNum(int num)
	{
		UUIText text = base.GetText(4);
		if (text == null)
		{
			return;
		}
		text.SetText(num.ToString(), true);
	}

	// Token: 0x0600B2FC RID: 45820 RVA: 0x00287544 File Offset: 0x00285744
	public void UpdateCostColor(bool useChangeColor)
	{
		UUIText text = base.GetText(4);
		if (text != null)
		{
			UUIItem uuiitem = text;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(useChangeColor, fcolor);
		}
	}

	// Token: 0x04005112 RID: 20754
	private int Data;

	// Token: 0x04005113 RID: 20755
	private ERedDotName? RedDotName;

	// Token: 0x04005114 RID: 20756
	[Nullable(2)]
	private Action<int> ButtonFunction;

	// Token: 0x02007DD2 RID: 32210
	[NullableContext(0)]
	private class EButtonItemDefine
	{
		// Token: 0x04029301 RID: 168705
		public const int Button = 0;

		// Token: 0x04029302 RID: 168706
		public const int ButtonText = 1;

		// Token: 0x04029303 RID: 168707
		public const int RedDot = 2;

		// Token: 0x04029304 RID: 168708
		public const int TextureCost = 3;

		// Token: 0x04029305 RID: 168709
		public const int TextCost = 4;
	}
}
