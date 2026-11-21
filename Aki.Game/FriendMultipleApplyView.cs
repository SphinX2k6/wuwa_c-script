using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020010FC RID: 4348
public class FriendMultipleApplyView : UiTickViewBase
{
	// Token: 0x0600ADD8 RID: 44504 RVA: 0x003336AC File Offset: 0x003318AC
	[NullableContext(1)]
	public FriendMultipleApplyView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600ADD9 RID: 44505 RVA: 0x003336B8 File Offset: 0x003318B8
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

	// Token: 0x0600ADDA RID: 44506 RVA: 0x00333721 File Offset: 0x00331921
	protected override void OnStart()
	{
		this.ApplyDataList = (this.OpenParam as List<FriendApplyData>);
		this.InitLoopScrollView();
	}

	// Token: 0x0600ADDB RID: 44507 RVA: 0x0033373A File Offset: 0x0033193A
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshFriendApplicationRedDot, new Action(this.OnRefreshLoopScrollView));
		EventSystem.Instance.Add<int>(EEventName.FriendOnMultiItemAction, new Action<int>(this.HandleFriendOnMultiItemAction));
	}

	// Token: 0x0600ADDC RID: 44508 RVA: 0x00333774 File Offset: 0x00331974
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshFriendApplicationRedDot, new Action(this.OnRefreshLoopScrollView));
		EventSystem.Instance.Remove(EEventName.FriendOnMultiItemAction, new Action<int>(this.HandleFriendOnMultiItemAction));
	}

	// Token: 0x0600ADDD RID: 44509 RVA: 0x003337B0 File Offset: 0x003319B0
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

	// Token: 0x0600ADDE RID: 44510 RVA: 0x00333806 File Offset: 0x00331A06
	protected override void OnBeforeDestroy()
	{
		if (this.HallLoopScroll != null)
		{
			this.HallLoopScroll.ClearGridProxies();
		}
		this.HallLoopScroll = null;
	}

	// Token: 0x0600ADDF RID: 44511 RVA: 0x00333822 File Offset: 0x00331A22
	public void RefreshLoopScrollView()
	{
		this.HallLoopScroll.RefreshByData(this.ApplyDataList, false, null, false);
	}

	// Token: 0x0600ADE0 RID: 44512 RVA: 0x00333838 File Offset: 0x00331A38
	private void InitLoopScrollView()
	{
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(0);
		AUIBaseActor gridActor = base.GetItem(1).GetOwner() as AUIBaseActor;
		this.HallLoopScroll = new LoopScrollView<FriendMultipleApplyItem, FriendApplyData>(loopScrollViewComponent, gridActor, new Func<FriendMultipleApplyItem>(this.ProxyCreateFunction), false);
		this.RefreshLoopScrollView();
	}

	// Token: 0x0600ADE1 RID: 44513 RVA: 0x0033387F File Offset: 0x00331A7F
	[NullableContext(1)]
	private FriendMultipleApplyItem ProxyCreateFunction()
	{
		return new FriendMultipleApplyItem();
	}

	// Token: 0x0600ADE2 RID: 44514 RVA: 0x00333886 File Offset: 0x00331A86
	private void OnRefreshLoopScrollView()
	{
		if (this.ApplyDataList.Count <= 0)
		{
			UiManager.Instance.CloseView(EUiViewName.FriendMultipleApplyView, null);
		}
		this.HallLoopScroll.RefreshByData(this.ApplyDataList, false, null, false);
	}

	// Token: 0x0600ADE3 RID: 44515 RVA: 0x003338BA File Offset: 0x00331ABA
	private void HandleFriendOnMultiItemAction(int playerId)
	{
		base.CloseMe(null);
	}

	// Token: 0x04006406 RID: 25606
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<FriendMultipleApplyItem, FriendApplyData> HallLoopScroll;

	// Token: 0x04006407 RID: 25607
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FriendApplyData> ApplyDataList;

	// Token: 0x0200738A RID: 29578
	private class EFriendMultipleApplyView
	{
		// Token: 0x040259F8 RID: 154104
		public const int LoopScrollView = 0;

		// Token: 0x040259F9 RID: 154105
		public const int ScrollTemp = 1;
	}
}
