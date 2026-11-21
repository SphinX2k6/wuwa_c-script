using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017D7 RID: 6103
public class OnlineMultipleApplyView : UiTickViewBase
{
	// Token: 0x0600EEC6 RID: 61126 RVA: 0x0046120F File Offset: 0x0045F40F
	[NullableContext(1)]
	public OnlineMultipleApplyView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EEC7 RID: 61127 RVA: 0x00461218 File Offset: 0x0045F418
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600EEC8 RID: 61128 RVA: 0x00461281 File Offset: 0x0045F481
	protected override void OnStart()
	{
		this.InitLoopScrollView();
	}

	// Token: 0x0600EEC9 RID: 61129 RVA: 0x00461289 File Offset: 0x0045F489
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshApply, new Action(this.OnRefreshLoopScrollView));
	}

	// Token: 0x0600EECA RID: 61130 RVA: 0x004612A7 File Offset: 0x0045F4A7
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshApply, new Action(this.OnRefreshLoopScrollView));
	}

	// Token: 0x0600EECB RID: 61131 RVA: 0x004612C8 File Offset: 0x0045F4C8
	protected override void OnTick(float delta)
	{
		if (this.HallLoopScroll.StartGridIndex < 0)
		{
			return;
		}
		int displayGridNum = this.HallLoopScroll.GetDisplayGridNum();
		for (int i = this.HallLoopScroll.StartGridIndex; i < displayGridNum; i++)
		{
			OnlineMultipleApplyItem onlineMultipleApplyItem = this.HallLoopScroll.UnsafeGetGridProxy(i, false);
			if (onlineMultipleApplyItem != null)
			{
				onlineMultipleApplyItem.UpdateCountDownProgressBar();
			}
		}
	}

	// Token: 0x0600EECC RID: 61132 RVA: 0x0046131E File Offset: 0x0045F51E
	protected override void OnBeforeDestroy()
	{
		if (this.HallLoopScroll != null)
		{
			this.HallLoopScroll.ClearGridProxies();
		}
		if (OnlineModel.Instance.GetCurrentApplyList().Length != 0)
		{
			UiManager.Instance.OpenView(EUiViewName.OnlineApplyView, null, null);
		}
		this.HallLoopScroll = null;
	}

	// Token: 0x0600EECD RID: 61133 RVA: 0x00461358 File Offset: 0x0045F558
	public void RefreshLoopScrollView()
	{
		this.HallLoopScroll.ReloadData(OnlineModel.Instance.GetCurrentApplyList(), false);
	}

	// Token: 0x0600EECE RID: 61134 RVA: 0x00461370 File Offset: 0x0045F570
	private void InitLoopScrollView()
	{
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(0);
		AUIBaseActor gridActor = base.GetItem(1).GetOwner() as AUIBaseActor;
		this.HallLoopScroll = new LoopScrollView<OnlineMultipleApplyItem, OnlineApplyData>(loopScrollViewComponent, gridActor, new Func<OnlineMultipleApplyItem>(this.ProxyCreateFunction), false);
		this.RefreshLoopScrollView();
	}

	// Token: 0x0600EECF RID: 61135 RVA: 0x004613B7 File Offset: 0x0045F5B7
	[NullableContext(1)]
	private OnlineMultipleApplyItem ProxyCreateFunction()
	{
		return new OnlineMultipleApplyItem();
	}

	// Token: 0x0600EED0 RID: 61136 RVA: 0x004613C0 File Offset: 0x0045F5C0
	private void OnRefreshLoopScrollView()
	{
		OnlineApplyData[] currentApplyList = OnlineModel.Instance.GetCurrentApplyList();
		if (currentApplyList.Length == 0)
		{
			UiManager.Instance.CloseView(EUiViewName.OnlineMultipleApplyView, null);
		}
		this.HallLoopScroll.ReloadData(currentApplyList, false);
	}

	// Token: 0x04008712 RID: 34578
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<OnlineMultipleApplyItem, OnlineApplyData> HallLoopScroll;

	// Token: 0x020079F7 RID: 31223
	private enum EOnlineMultipleApplyView
	{
		// Token: 0x04027883 RID: 161923
		LoopScrollView,
		// Token: 0x04027884 RID: 161924
		ScrollTemp
	}
}
