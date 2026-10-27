using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022F3 RID: 8947
public class OnlineMultipleApplyView : UiTickViewBase
{
	// Token: 0x06011A2E RID: 72238 RVA: 0x00454543 File Offset: 0x00452743
	[NullableContext(1)]
	public OnlineMultipleApplyView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011A2F RID: 72239 RVA: 0x0045454C File Offset: 0x0045274C
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

	// Token: 0x06011A30 RID: 72240 RVA: 0x004545B5 File Offset: 0x004527B5
	protected override void OnStart()
	{
		this.InitLoopScrollView();
	}

	// Token: 0x06011A31 RID: 72241 RVA: 0x004545BD File Offset: 0x004527BD
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshApply, new Action(this.OnRefreshLoopScrollView));
	}

	// Token: 0x06011A32 RID: 72242 RVA: 0x004545DB File Offset: 0x004527DB
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshApply, new Action(this.OnRefreshLoopScrollView));
	}

	// Token: 0x06011A33 RID: 72243 RVA: 0x004545FC File Offset: 0x004527FC
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

	// Token: 0x06011A34 RID: 72244 RVA: 0x00454652 File Offset: 0x00452852
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

	// Token: 0x06011A35 RID: 72245 RVA: 0x0045468C File Offset: 0x0045288C
	public void RefreshLoopScrollView()
	{
		this.HallLoopScroll.ReloadData(OnlineModel.Instance.GetCurrentApplyList(), false);
	}

	// Token: 0x06011A36 RID: 72246 RVA: 0x004546A4 File Offset: 0x004528A4
	private void InitLoopScrollView()
	{
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(0);
		AUIBaseActor gridActor = base.GetItem(1).GetOwner() as AUIBaseActor;
		this.HallLoopScroll = new LoopScrollView<OnlineMultipleApplyItem, OnlineApplyData>(loopScrollViewComponent, gridActor, new Func<OnlineMultipleApplyItem>(this.ProxyCreateFunction), false);
		this.RefreshLoopScrollView();
	}

	// Token: 0x06011A37 RID: 72247 RVA: 0x004546EB File Offset: 0x004528EB
	[NullableContext(1)]
	private OnlineMultipleApplyItem ProxyCreateFunction()
	{
		return new OnlineMultipleApplyItem();
	}

	// Token: 0x06011A38 RID: 72248 RVA: 0x004546F4 File Offset: 0x004528F4
	private void OnRefreshLoopScrollView()
	{
		OnlineApplyData[] currentApplyList = OnlineModel.Instance.GetCurrentApplyList();
		if (currentApplyList.Length == 0)
		{
			UiManager.Instance.CloseView(EUiViewName.OnlineMultipleApplyView, null);
		}
		this.HallLoopScroll.ReloadData(currentApplyList, false);
	}

	// Token: 0x040085D4 RID: 34260
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<OnlineMultipleApplyItem, OnlineApplyData> HallLoopScroll;

	// Token: 0x02008873 RID: 34931
	private enum EOnlineMultipleApplyView
	{
		// Token: 0x0402C581 RID: 181633
		LoopScrollView,
		// Token: 0x0402C582 RID: 181634
		ScrollTemp
	}
}
