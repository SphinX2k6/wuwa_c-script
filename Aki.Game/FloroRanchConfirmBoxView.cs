using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000E9F RID: 3743
[NullableContext(2)]
[Nullable(0)]
public class FloroRanchConfirmBoxView : UiViewBase
{
	// Token: 0x0600959A RID: 38298 RVA: 0x002C6082 File Offset: 0x002C4282
	[NullableContext(1)]
	public FloroRanchConfirmBoxView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600959B RID: 38299 RVA: 0x002C608C File Offset: 0x002C428C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnCloseClicked));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnCloseClicked));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600959C RID: 38300 RVA: 0x002C61B8 File Offset: 0x002C43B8
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchConfirmBoxView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchConfirmBoxView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600959D RID: 38301 RVA: 0x002C61FC File Offset: 0x002C43FC
	protected override void OnStart()
	{
		UiViewBase attachView = (this.OpenParam as ConfirmBoxDataNew).AttachView;
		UUIItem uuiitem = (attachView != null) ? attachView.GetRootItem() : null;
		if (uuiitem != null)
		{
			(this.ChildPopView.GetPopViewOriginalActor().GetComponentByClass(UUIItem.StaticClass()) as UUIItem).SetUIParent(uuiitem, false);
		}
	}

	// Token: 0x0600959E RID: 38302 RVA: 0x002C6250 File Offset: 0x002C4450
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
		childPopView3.PopItem.OverrideBackBtnCallBack(new Action(this.ContentPanel.OnClose));
	}

	// Token: 0x0600959F RID: 38303 RVA: 0x002C62D0 File Offset: 0x002C44D0
	protected override void OnAfterShow()
	{
		Action afterShowFunction = this.ConfirmBoxData.GetAfterShowFunction();
		if (afterShowFunction == null)
		{
			return;
		}
		afterShowFunction();
	}

	// Token: 0x060095A0 RID: 38304 RVA: 0x002C62E7 File Offset: 0x002C44E7
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

	// Token: 0x060095A1 RID: 38305 RVA: 0x002C630C File Offset: 0x002C450C
	protected override float OnGetTimeDilation()
	{
		ConfirmBoxDataNew confirmBoxDataNew = this.OpenParam as ConfirmBoxDataNew;
		return (float)ConfirmBoxConfig.Instance.GetConfirmBoxConfig((int)confirmBoxDataNew.ConfigId).Value.TimeDilation;
	}

	// Token: 0x060095A2 RID: 38306 RVA: 0x002C6346 File Offset: 0x002C4546
	private void OnBtnCloseClicked()
	{
		base.CloseMe(null);
	}

	// Token: 0x060095A3 RID: 38307 RVA: 0x002C634F File Offset: 0x002C454F
	private void CloseFunc(Action<bool> callback = null)
	{
		base.CloseMe(callback);
	}

	// Token: 0x04005A01 RID: 23041
	private ConfirmBoxDataNew ConfirmBoxData;

	// Token: 0x04005A02 RID: 23042
	private ConfirmBox? Config;

	// Token: 0x04005A03 RID: 23043
	private FloroRanchConfirmBoxContentPanel ContentPanel;

	// Token: 0x0200709E RID: 28830
	[NullableContext(0)]
	private class EConfirmBoxViewDefine
	{
		// Token: 0x04024B5B RID: 150363
		public const int BtnMask = 0;

		// Token: 0x04024B5C RID: 150364
		public const int ItemContentRoot = 1;

		// Token: 0x04024B5D RID: 150365
		public const int BtnClose = 2;

		// Token: 0x04024B5E RID: 150366
		public const int ItemCost = 3;

		// Token: 0x04024B5F RID: 150367
		public const int TextTitle = 4;
	}
}
