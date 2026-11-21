using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001049 RID: 4169
public class FloroRanchDebugInfoPanel : UiPanelBase
{
	// Token: 0x0600A5F1 RID: 42481 RVA: 0x0030D0B8 File Offset: 0x0030B2B8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickCloseButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A5F2 RID: 42482 RVA: 0x0030D17F File Offset: 0x0030B37F
	protected override void OnStart()
	{
		this.LoopScrollView = new LoopScrollView<FloroRanchDebugInfoItem, string>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<FloroRanchDebugInfoItem>(this.InitItem), false);
	}

	// Token: 0x0600A5F3 RID: 42483 RVA: 0x0030D1B4 File Offset: 0x0030B3B4
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		FloroRanchDebugInfoPanel.<OnBeforeShowAsyncImplement>d__4 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<FloroRanchDebugInfoPanel.<OnBeforeShowAsyncImplement>d__4>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x0600A5F4 RID: 42484 RVA: 0x0030D1F7 File Offset: 0x0030B3F7
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnFloroRanchDebugInfoRefresh, new Action(this.OnDebugInfoRefresh));
	}

	// Token: 0x0600A5F5 RID: 42485 RVA: 0x0030D215 File Offset: 0x0030B415
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnFloroRanchDebugInfoRefresh, new Action(this.OnDebugInfoRefresh));
	}

	// Token: 0x0600A5F6 RID: 42486 RVA: 0x0030D233 File Offset: 0x0030B433
	protected void OnClickCloseButton()
	{
		base.Hide(null);
	}

	// Token: 0x0600A5F7 RID: 42487 RVA: 0x0030D23C File Offset: 0x0030B43C
	[NullableContext(1)]
	protected FloroRanchDebugInfoItem InitItem()
	{
		return new FloroRanchDebugInfoItem();
	}

	// Token: 0x0600A5F8 RID: 42488 RVA: 0x0030D244 File Offset: 0x0030B444
	protected void OnDebugInfoRefresh()
	{
		List<string> actionInfoList = FloroRanchGamePlayModel.Instance.ActionInfoList;
		this.LoopScrollView.RefreshByData(actionInfoList, false, null, false);
		this.LoopScrollView.ScrollToGridIndex(actionInfoList.Count - 1, true);
	}

	// Token: 0x0400610E RID: 24846
	[Nullable(1)]
	protected LoopScrollView<FloroRanchDebugInfoItem, string> LoopScrollView;

	// Token: 0x0200729B RID: 29339
	private class EComponent
	{
		// Token: 0x04025520 RID: 152864
		public const int CloseButton = 0;

		// Token: 0x04025521 RID: 152865
		public const int LoopScrollView = 1;

		// Token: 0x04025522 RID: 152866
		public const int TemplateActor = 2;
	}
}
