using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000E9D RID: 3741
[NullableContext(1)]
[Nullable(0)]
public class CyberpunkConfirmBoxView : UiViewBase
{
	// Token: 0x0600957B RID: 38267 RVA: 0x002C563D File Offset: 0x002C383D
	public CyberpunkConfirmBoxView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600957C RID: 38268 RVA: 0x002C5664 File Offset: 0x002C3864
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

	// Token: 0x0600957D RID: 38269 RVA: 0x002C57B4 File Offset: 0x002C39B4
	protected override UniTask OnBeforeStartAsync()
	{
		CyberpunkConfirmBoxView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CyberpunkConfirmBoxView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600957E RID: 38270 RVA: 0x002C57F8 File Offset: 0x002C39F8
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

	// Token: 0x0600957F RID: 38271 RVA: 0x002C5873 File Offset: 0x002C3A73
	protected override void OnAfterShow()
	{
		Action afterShowFunction = this.ConfirmBoxData.GetAfterShowFunction();
		if (afterShowFunction == null)
		{
			return;
		}
		afterShowFunction();
	}

	// Token: 0x06009580 RID: 38272 RVA: 0x002C588A File Offset: 0x002C3A8A
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

	// Token: 0x06009581 RID: 38273 RVA: 0x002C58B0 File Offset: 0x002C3AB0
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

	// Token: 0x06009582 RID: 38274 RVA: 0x002C590E File Offset: 0x002C3B0E
	protected void OnClose()
	{
		this.SelectedIndex = -1;
		this.ConfirmBoxButtonClick();
	}

	// Token: 0x06009583 RID: 38275 RVA: 0x002C5920 File Offset: 0x002C3B20
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

	// Token: 0x06009584 RID: 38276 RVA: 0x002C598F File Offset: 0x002C3B8F
	private void HandleSelectedIndexWhenClose()
	{
		if (this.SelectedIndex == -1)
		{
			this.SelectedIndex = 0;
		}
	}

	// Token: 0x06009585 RID: 38277 RVA: 0x002C59A4 File Offset: 0x002C3BA4
	protected UniTask InitButton()
	{
		CyberpunkConfirmBoxView.<InitButton>d__16 <InitButton>d__;
		<InitButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitButton>d__.<>4__this = this;
		<InitButton>d__.<>1__state = -1;
		<InitButton>d__.<>t__builder.Start<CyberpunkConfirmBoxView.<InitButton>d__16>(ref <InitButton>d__);
		return <InitButton>d__.<>t__builder.Task;
	}

	// Token: 0x06009586 RID: 38278 RVA: 0x002C59E8 File Offset: 0x002C3BE8
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

	// Token: 0x06009587 RID: 38279 RVA: 0x002C5A44 File Offset: 0x002C3C44
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

	// Token: 0x06009588 RID: 38280 RVA: 0x002C5A7F File Offset: 0x002C3C7F
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x06009589 RID: 38281 RVA: 0x002C5A88 File Offset: 0x002C3C88
	private void OnClickMaskButton()
	{
		if (!this.Config.Value.NeedMaskClose)
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x040059F3 RID: 23027
	protected ConfirmBoxButton[] ButtonList = Array.Empty<ConfirmBoxButton>();

	// Token: 0x040059F4 RID: 23028
	protected ConfirmBox? Config;

	// Token: 0x040059F5 RID: 23029
	[Nullable(2)]
	protected ConfirmBoxDataNew ConfirmBoxData;

	// Token: 0x040059F6 RID: 23030
	protected int SelectedIndex = -1;

	// Token: 0x040059F7 RID: 23031
	protected readonly List<UUIButtonComponent> ButtonComponentList = new List<UUIButtonComponent>();

	// Token: 0x02007093 RID: 28819
	[NullableContext(0)]
	private class ECyberpunkConfirmBoxDefine
	{
		// Token: 0x04024B27 RID: 150311
		public const int TxtPrompt = 0;

		// Token: 0x04024B28 RID: 150312
		public const int BtnCancel = 1;

		// Token: 0x04024B29 RID: 150313
		public const int BtnConfirm = 2;

		// Token: 0x04024B2A RID: 150314
		public const int UiItemBackBtn = 3;

		// Token: 0x04024B2B RID: 150315
		public const int TitleTxt = 4;

		// Token: 0x04024B2C RID: 150316
		public const int BtnMask = 5;
	}
}
