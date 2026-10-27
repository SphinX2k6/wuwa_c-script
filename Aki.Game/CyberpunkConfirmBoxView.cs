using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019DE RID: 6622
[NullableContext(1)]
[Nullable(0)]
public class CyberpunkConfirmBoxView : UiViewBase
{
	// Token: 0x0600C16E RID: 49518 RVA: 0x002BA665 File Offset: 0x002B8865
	public CyberpunkConfirmBoxView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C16F RID: 49519 RVA: 0x002BA68C File Offset: 0x002B888C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickCloseButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickMaskButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C170 RID: 49520 RVA: 0x002BA7DC File Offset: 0x002B89DC
	protected override UniTask OnBeforeStartAsync()
	{
		CyberpunkConfirmBoxView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CyberpunkConfirmBoxView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C171 RID: 49521 RVA: 0x002BA820 File Offset: 0x002B8A20
	protected override void OnBeforeShow()
	{
		IUiPopFrameInterface childPopView = this.ChildPopView;
		if (childPopView != null)
		{
			childPopView.SetBackBtnShowState(this.Config.Value.NeedClose);
		}
		IUiPopFrameInterface childPopView2 = this.ChildPopView;
		if (childPopView2 != null)
		{
			childPopView2.PopItem.SetMaskResponsibleState(this.Config.Value.NeedMaskClose);
		}
		IUiPopFrameInterface childPopView3 = this.ChildPopView;
		if (childPopView3 == null)
		{
			return;
		}
		childPopView3.PopItem.OverrideBackBtnCallBack(new Action(this.OnClose));
	}

	// Token: 0x0600C172 RID: 49522 RVA: 0x002BA89B File Offset: 0x002B8A9B
	protected override void OnAfterShow()
	{
		Action afterShowFunction = this.ConfirmBoxData.GetAfterShowFunction();
		if (afterShowFunction == null)
		{
			return;
		}
		afterShowFunction();
	}

	// Token: 0x0600C173 RID: 49523 RVA: 0x002BA8B2 File Offset: 0x002B8AB2
	protected override void OnBeforeHide()
	{
		if (this.LastHide)
		{
			ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
			if (confirmBoxData == null)
			{
				return;
			}
			Action beforePlayCloseFunction = confirmBoxData.BeforePlayCloseFunction;
			if (beforePlayCloseFunction == null)
			{
				return;
			}
			beforePlayCloseFunction();
		}
	}

	// Token: 0x0600C174 RID: 49524 RVA: 0x002BA8D8 File Offset: 0x002B8AD8
	protected override void OnBeforeDestroy()
	{
		this.ResetButtonList();
		this.HandleSelectedIndexWhenClose();
		Action action;
		if (this.ConfirmBoxData != null && this.ConfirmBoxData.FunctionMap.TryGetValue(this.SelectedIndex, out action) && action != null)
		{
			action();
		}
		ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
		if (confirmBoxData == null)
		{
			return;
		}
		Action destroyFunction = confirmBoxData.DestroyFunction;
		if (destroyFunction == null)
		{
			return;
		}
		destroyFunction();
	}

	// Token: 0x0600C175 RID: 49525 RVA: 0x002BA936 File Offset: 0x002B8B36
	protected void OnClose()
	{
		this.SelectedIndex = -1;
		this.ConfirmBoxButtonClick();
	}

	// Token: 0x0600C176 RID: 49526 RVA: 0x002BA948 File Offset: 0x002B8B48
	protected void ConfirmBoxButtonClick()
	{
		ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
		Func<int, bool> func = (confirmBoxData != null) ? confirmBoxData.CanExecuteCloseFunc : null;
		if (func != null && !func(this.SelectedIndex))
		{
			Action action;
			if (this.ConfirmBoxData != null && this.ConfirmBoxData.FunctionMap.TryGetValue(this.SelectedIndex, out action) && action != null)
			{
				action();
				return;
			}
		}
		else
		{
			base.CloseMe(delegate(bool _)
			{
				Action closeFunction = this.ConfirmBoxData.GetCloseFunction();
				if (closeFunction == null)
				{
					return;
				}
				closeFunction();
			});
		}
	}

	// Token: 0x0600C177 RID: 49527 RVA: 0x002BA9B7 File Offset: 0x002B8BB7
	private void HandleSelectedIndexWhenClose()
	{
		if (this.SelectedIndex == -1)
		{
			this.SelectedIndex = 0;
		}
	}

	// Token: 0x0600C178 RID: 49528 RVA: 0x002BA9CC File Offset: 0x002B8BCC
	protected UniTask InitButton()
	{
		CyberpunkConfirmBoxView.<InitButton>d__16 <InitButton>d__;
		<InitButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitButton>d__.<>4__this = this;
		<InitButton>d__.<>1__state = -1;
		<InitButton>d__.<>t__builder.Start<CyberpunkConfirmBoxView.<InitButton>d__16>(ref <InitButton>d__);
		return <InitButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600C179 RID: 49529 RVA: 0x002BAA10 File Offset: 0x002B8C10
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<ConfirmBoxButton> CreateButton(UUIItem uiItem, int index, Action clickFunction)
	{
		CyberpunkConfirmBoxView.<CreateButton>d__17 <CreateButton>d__;
		<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder<ConfirmBoxButton>.Create();
		<CreateButton>d__.<>4__this = this;
		<CreateButton>d__.uiItem = uiItem;
		<CreateButton>d__.index = index;
		<CreateButton>d__.clickFunction = clickFunction;
		<CreateButton>d__.<>1__state = -1;
		<CreateButton>d__.<>t__builder.Start<CyberpunkConfirmBoxView.<CreateButton>d__17>(ref <CreateButton>d__);
		return <CreateButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600C17A RID: 49530 RVA: 0x002BAA6C File Offset: 0x002B8C6C
	private void ResetButtonList()
	{
		int i = 0;
		int num = this.ButtonList.Length;
		while (i < num)
		{
			this.ButtonList[i].Destroy(null);
			i++;
		}
		this.ButtonList = Array.Empty<ConfirmBoxButton>();
	}

	// Token: 0x0600C17B RID: 49531 RVA: 0x002BAAA7 File Offset: 0x002B8CA7
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600C17C RID: 49532 RVA: 0x002BAAB0 File Offset: 0x002B8CB0
	private void OnClickMaskButton()
	{
		if (!this.Config.Value.NeedMaskClose)
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x04005924 RID: 22820
	protected ConfirmBoxButton[] ButtonList = Array.Empty<ConfirmBoxButton>();

	// Token: 0x04005925 RID: 22821
	protected ConfirmBox? Config;

	// Token: 0x04005926 RID: 22822
	[Nullable(2)]
	protected ConfirmBoxDataNew ConfirmBoxData;

	// Token: 0x04005927 RID: 22823
	protected int SelectedIndex = -1;

	// Token: 0x04005928 RID: 22824
	protected readonly List<UUIButtonComponent> ButtonComponentList = new List<UUIButtonComponent>();

	// Token: 0x02007F04 RID: 32516
	[NullableContext(0)]
	private class ECyberpunkConfirmBoxDefine
	{
		// Token: 0x040297EA RID: 169962
		public const int TxtPrompt = 0;

		// Token: 0x040297EB RID: 169963
		public const int BtnCancel = 1;

		// Token: 0x040297EC RID: 169964
		public const int BtnConfirm = 2;

		// Token: 0x040297ED RID: 169965
		public const int UiItemBackBtn = 3;

		// Token: 0x040297EE RID: 169966
		public const int TitleTxt = 4;

		// Token: 0x040297EF RID: 169967
		public const int BtnMask = 5;
	}
}
