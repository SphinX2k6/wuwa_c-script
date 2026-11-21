using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020010F7 RID: 4343
[NullableContext(1)]
[Nullable(0)]
public class FriendBlackListView : UiViewBase
{
	// Token: 0x0600AD97 RID: 44439 RVA: 0x00331CE5 File Offset: 0x0032FEE5
	public FriendBlackListView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600AD98 RID: 44440 RVA: 0x00331CFC File Offset: 0x0032FEFC
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

	// Token: 0x0600AD99 RID: 44441 RVA: 0x00331DA7 File Offset: 0x0032FFA7
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.UpdateBlackListShow, new Action(this.CallBackRefreshBlackListShow));
	}

	// Token: 0x0600AD9A RID: 44442 RVA: 0x00331DC5 File Offset: 0x0032FFC5
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.UpdateBlackListShow, new Action(this.CallBackRefreshBlackListShow));
	}

	// Token: 0x0600AD9B RID: 44443 RVA: 0x00331DE3 File Offset: 0x0032FFE3
	protected override void OnStart()
	{
		this.ShowBlackListCount();
		this.BlackListLayout = new GenericScrollViewNew<FriendItem, FriendItemSt>(base.GetScrollViewWithScrollbar(2), new Func<FriendItem>(this.InitItem), null, false, null);
		FriendController.Instance.RequestBlackList();
	}

	// Token: 0x0600AD9C RID: 44444 RVA: 0x00331E16 File Offset: 0x00330016
	private FriendItem InitItem()
	{
		FriendItem friendItem = new FriendItem(this.ViewInfo.Name, null);
		friendItem.SetIsInBlackList(true);
		return friendItem;
	}

	// Token: 0x0600AD9D RID: 44445 RVA: 0x00331E30 File Offset: 0x00330030
	private void RefreshShow()
	{
		this.BlackList = FriendController.Instance.CreateFriendItemSt(FriendModel.Instance.GetBlackListIds(), EFriendItemOperation.Default);
		this.BlackListLayout.RefreshByData(this.BlackList, null, false);
		this.ShowBlackListCount();
	}

	// Token: 0x0600AD9E RID: 44446 RVA: 0x00331E68 File Offset: 0x00330068
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

	// Token: 0x0600AD9F RID: 44447 RVA: 0x00331EDE File Offset: 0x003300DE
	private void CallBackRefreshBlackListShow()
	{
		this.RefreshShow();
	}

	// Token: 0x0600ADA0 RID: 44448 RVA: 0x00331EE6 File Offset: 0x003300E6
	protected override void OnBeforeDestroy()
	{
		this.BlackList.Clear();
		FriendModel.Instance.ResetShowingView();
	}

	// Token: 0x040063F3 RID: 25587
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<FriendItem, FriendItemSt> BlackListLayout;

	// Token: 0x040063F4 RID: 25588
	private List<FriendItemSt> BlackList = new List<FriendItemSt>();

	// Token: 0x02007386 RID: 29574
	[NullableContext(0)]
	private class EFriendBlackListViewComponents
	{
		// Token: 0x040259D5 RID: 154069
		public const int BlackListVolume = 0;

		// Token: 0x040259D6 RID: 154070
		public const int BlackListItemModel = 1;

		// Token: 0x040259D7 RID: 154071
		public const int BlackListScrollView = 2;

		// Token: 0x040259D8 RID: 154072
		public const int BlackListEmptyItem = 3;
	}
}
