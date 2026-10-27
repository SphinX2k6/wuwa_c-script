using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017AD RID: 6061
public class SelectedFriendChatView : UiViewBase
{
	// Token: 0x0600B0E2 RID: 45282 RVA: 0x00280DEC File Offset: 0x0027EFEC
	[NullableContext(1)]
	public SelectedFriendChatView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B0E3 RID: 45283 RVA: 0x00280DF8 File Offset: 0x0027EFF8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600B0E4 RID: 45284 RVA: 0x00280E84 File Offset: 0x0027F084
	protected override void OnStart()
	{
		AUIBaseActor gridActor = base.GetItem(1).GetOwner() as AUIBaseActor;
		this.FriendLoopScrollView = new LoopScrollView<SelectedFriendItem, int>(base.GetLoopScrollViewComponent(0), gridActor, new Func<SelectedFriendItem>(this.OnGridProxyCreate), true);
		this.Refresh();
	}

	// Token: 0x0600B0E5 RID: 45285 RVA: 0x00280EC9 File Offset: 0x0027F0C9
	protected override void OnBeforeDestroy()
	{
		this.FriendLoopScrollView = null;
	}

	// Token: 0x0600B0E6 RID: 45286 RVA: 0x00280ED4 File Offset: 0x0027F0D4
	private void Refresh()
	{
		FriendModel instance = FriendModel.Instance;
		ChatModel instance2 = ChatModel.Instance;
		List<int> friendSortedListIds = instance.GetFriendSortedListIds();
		List<int> list = new List<int>();
		foreach (int num in friendSortedListIds)
		{
			if (!instance2.IsInPrivateChatRoom(num) && !instance.HasBlockedPlayer(num))
			{
				list.Add(num);
			}
		}
		this.FriendLoopScrollView.ReloadData(list, false);
		base.GetItem(2).SetUIActive(list.Count <= 0);
	}

	// Token: 0x0600B0E7 RID: 45287 RVA: 0x00280F74 File Offset: 0x0027F174
	[NullableContext(1)]
	private SelectedFriendItem OnGridProxyCreate()
	{
		SelectedFriendItem selectedFriendItem = new SelectedFriendItem();
		selectedFriendItem.BindOnClicked(new Action<int>(this.OnClickedFriendItem));
		return selectedFriendItem;
	}

	// Token: 0x0600B0E8 RID: 45288 RVA: 0x00280F90 File Offset: 0x0027F190
	private void OnClickedFriendItem(int playerId)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "选择玩家";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("playerId", playerId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (!FriendModel.Instance.IsMyFriend(playerId))
		{
			ScrollingTipsController.Instance.ShowTipsById("SelectChatNoFriendText", Array.Empty<object>());
			this.Refresh();
			return;
		}
		EventSystem.Instance.Emit<int>(EEventName.OnSelectChatFriend, playerId);
		UiManager.Instance.CloseView(EUiViewName.SelectedFriendChatView, null);
	}

	// Token: 0x0400503C RID: 20540
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<SelectedFriendItem, int> FriendLoopScrollView;

	// Token: 0x02007DC5 RID: 32197
	private class EChildType
	{
		// Token: 0x040292CD RID: 168653
		public const int FriendLoopScrollView = 0;

		// Token: 0x040292CE RID: 168654
		public const int SourceFriendItem = 1;

		// Token: 0x040292CF RID: 168655
		public const int NoFriendItem = 2;
	}
}
