using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C3D RID: 7229
public class FriendMultipleApplyView : UiTickViewBase
{
	// Token: 0x0600D9C2 RID: 55746 RVA: 0x003282AC File Offset: 0x003264AC
	[NullableContext(1)]
	public FriendMultipleApplyView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D9C3 RID: 55747 RVA: 0x003282B8 File Offset: 0x003264B8
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

	// Token: 0x0600D9C4 RID: 55748 RVA: 0x00328321 File Offset: 0x00326521
	protected override void OnStart()
	{
		this.ApplyDataList = (this.OpenParam as List<FriendApplyData>);
		this.InitLoopScrollView();
	}

	// Token: 0x0600D9C5 RID: 55749 RVA: 0x0032833A File Offset: 0x0032653A
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshFriendApplicationRedDot, new Action(this.OnRefreshLoopScrollView));
		EventSystem.Instance.Add<int>(EEventName.FriendOnMultiItemAction, new Action<int>(this.HandleFriendOnMultiItemAction));
	}

	// Token: 0x0600D9C6 RID: 55750 RVA: 0x00328374 File Offset: 0x00326574
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshFriendApplicationRedDot, new Action(this.OnRefreshLoopScrollView));
		EventSystem.Instance.Remove(EEventName.FriendOnMultiItemAction, new Action<int>(this.HandleFriendOnMultiItemAction));
	}

	// Token: 0x0600D9C7 RID: 55751 RVA: 0x003283B0 File Offset: 0x003265B0
	protected override void OnTick(float delta)
	{
		if (this.HallLoopScroll.StartGridIndex < 0)
		{
			return;
		}
		int displayGridNum = this.HallLoopScroll.GetDisplayGridNum();
		for (int i = this.HallLoopScroll.StartGridIndex; i < displayGridNum; i++)
		{
			FriendMultipleApplyItem friendMultipleApplyItem = this.HallLoopScroll.UnsafeGetGridProxy(i, false);
			if (friendMultipleApplyItem != null)
			{
				friendMultipleApplyItem.UpdateCountDownProgressBar();
			}
		}
	}

	// Token: 0x0600D9C8 RID: 55752 RVA: 0x00328406 File Offset: 0x00326606
	protected override void OnBeforeDestroy()
	{
		if (this.HallLoopScroll != null)
		{
			this.HallLoopScroll.ClearGridProxies();
		}
		this.HallLoopScroll = null;
	}

	// Token: 0x0600D9C9 RID: 55753 RVA: 0x00328422 File Offset: 0x00326622
	public void RefreshLoopScrollView()
	{
		this.HallLoopScroll.RefreshByData(this.ApplyDataList, false, null, false);
	}

	// Token: 0x0600D9CA RID: 55754 RVA: 0x00328438 File Offset: 0x00326638
	private void InitLoopScrollView()
	{
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(0);
		AUIBaseActor gridActor = base.GetItem(1).GetOwner() as AUIBaseActor;
		this.HallLoopScroll = new LoopScrollView<FriendMultipleApplyItem, FriendApplyData>(loopScrollViewComponent, gridActor, new Func<FriendMultipleApplyItem>(this.ProxyCreateFunction), false);
		this.RefreshLoopScrollView();
	}

	// Token: 0x0600D9CB RID: 55755 RVA: 0x0032847F File Offset: 0x0032667F
	[NullableContext(1)]
	private FriendMultipleApplyItem ProxyCreateFunction()
	{
		return new FriendMultipleApplyItem();
	}

	// Token: 0x0600D9CC RID: 55756 RVA: 0x00328486 File Offset: 0x00326686
	private void OnRefreshLoopScrollView()
	{
		if (this.ApplyDataList.Count <= 0)
		{
			UiManager.Instance.CloseView(EUiViewName.FriendMultipleApplyView, null);
		}
		this.HallLoopScroll.RefreshByData(this.ApplyDataList, false, null, false);
	}

	// Token: 0x0600D9CD RID: 55757 RVA: 0x003284BA File Offset: 0x003266BA
	private void HandleFriendOnMultiItemAction(int playerId)
	{
		base.CloseMe(null);
	}

	// Token: 0x04006334 RID: 25396
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<FriendMultipleApplyItem, FriendApplyData> HallLoopScroll;

	// Token: 0x04006335 RID: 25397
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FriendApplyData> ApplyDataList;

	// Token: 0x02008201 RID: 33281
	private class EFriendMultipleApplyView
	{
		// Token: 0x0402A6D1 RID: 173777
		public const int LoopScrollView = 0;

		// Token: 0x0402A6D2 RID: 173778
		public const int ScrollTemp = 1;
	}
}
