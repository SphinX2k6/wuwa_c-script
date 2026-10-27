using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C38 RID: 7224
[NullableContext(1)]
[Nullable(0)]
public class FriendBlackListView : UiViewBase
{
	// Token: 0x0600D981 RID: 55681 RVA: 0x003268E5 File Offset: 0x00324AE5
	public FriendBlackListView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D982 RID: 55682 RVA: 0x003268FC File Offset: 0x00324AFC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600D983 RID: 55683 RVA: 0x003269A7 File Offset: 0x00324BA7
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.UpdateBlackListShow, new Action(this.CallBackRefreshBlackListShow));
	}

	// Token: 0x0600D984 RID: 55684 RVA: 0x003269C5 File Offset: 0x00324BC5
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.UpdateBlackListShow, new Action(this.CallBackRefreshBlackListShow));
	}

	// Token: 0x0600D985 RID: 55685 RVA: 0x003269E3 File Offset: 0x00324BE3
	protected override void OnStart()
	{
		this.ShowBlackListCount();
		this.BlackListLayout = new GenericScrollViewNew<FriendItem, FriendItemSt>(base.GetScrollViewWithScrollbar(2), new Func<FriendItem>(this.InitItem), null, false, null);
		FriendController.Instance.RequestBlackList();
	}

	// Token: 0x0600D986 RID: 55686 RVA: 0x00326A16 File Offset: 0x00324C16
	private FriendItem InitItem()
	{
		FriendItem friendItem = new FriendItem(this.ViewInfo.Name, null);
		friendItem.SetIsInBlackList(true);
		return friendItem;
	}

	// Token: 0x0600D987 RID: 55687 RVA: 0x00326A30 File Offset: 0x00324C30
	private void RefreshShow()
	{
		this.BlackList = FriendController.Instance.CreateFriendItemSt(FriendModel.Instance.GetBlackListIds(), EFriendItemOperation.Default);
		this.BlackListLayout.RefreshByData(this.BlackList, null, false);
		this.ShowBlackListCount();
	}

	// Token: 0x0600D988 RID: 55688 RVA: 0x00326A68 File Offset: 0x00324C68
	private void ShowBlackListCount()
	{
		UUIText text = base.GetText(0);
		int? intConfig = ConfigCommonParamById.GetIntConfig("blocklist_limit");
		int count = this.BlackList.Count;
		LguiUtil.Instance.SetLocalText(text, "FriendBlackListCount", new <>z__ReadOnlyArray<object>(new object[]
		{
			count,
			intConfig
		}));
		base.GetItem(3).SetUIActive(this.BlackList.Count <= 0);
	}

	// Token: 0x0600D989 RID: 55689 RVA: 0x00326ADE File Offset: 0x00324CDE
	private void CallBackRefreshBlackListShow()
	{
		this.RefreshShow();
	}

	// Token: 0x0600D98A RID: 55690 RVA: 0x00326AE6 File Offset: 0x00324CE6
	protected override void OnBeforeDestroy()
	{
		this.BlackList.Clear();
		FriendModel.Instance.ResetShowingView();
	}

	// Token: 0x04006321 RID: 25377
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<FriendItem, FriendItemSt> BlackListLayout;

	// Token: 0x04006322 RID: 25378
	private List<FriendItemSt> BlackList = new List<FriendItemSt>();

	// Token: 0x020081FD RID: 33277
	[NullableContext(0)]
	private class EFriendBlackListViewComponents
	{
		// Token: 0x0402A6AE RID: 173742
		public const int BlackListVolume = 0;

		// Token: 0x0402A6AF RID: 173743
		public const int BlackListItemModel = 1;

		// Token: 0x0402A6B0 RID: 173744
		public const int BlackListScrollView = 2;

		// Token: 0x0402A6B1 RID: 173745
		public const int BlackListEmptyItem = 3;
	}
}
