using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C66 RID: 3174
public class SelectedFriendChatView : UiViewBase
{
	// Token: 0x060084CA RID: 33994 RVA: 0x0028B384 File Offset: 0x00289584
	[NullableContext(1)]
	public SelectedFriendChatView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060084CB RID: 33995 RVA: 0x0028B390 File Offset: 0x00289590
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

	// Token: 0x060084CC RID: 33996 RVA: 0x0028B41C File Offset: 0x0028961C
	protected override void OnStart()
	{
		AUIBaseActor gridActor = base.GetItem(1).GetOwner() as AUIBaseActor;
		this.FriendLoopScrollView = new LoopScrollView<SelectedFriendItem, int>(base.GetLoopScrollViewComponent(0), gridActor, new Func<SelectedFriendItem>(this.OnGridProxyCreate), true);
		this.Refresh();
	}

	// Token: 0x060084CD RID: 33997 RVA: 0x0028B461 File Offset: 0x00289661
	protected override void OnBeforeDestroy()
	{
		this.FriendLoopScrollView = null;
	}

	// Token: 0x060084CE RID: 33998 RVA: 0x0028B46C File Offset: 0x0028966C
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

	// Token: 0x060084CF RID: 33999 RVA: 0x0028B50C File Offset: 0x0028970C
	[NullableContext(1)]
	private SelectedFriendItem OnGridProxyCreate()
	{
		SelectedFriendItem selectedFriendItem = new SelectedFriendItem();
		selectedFriendItem.BindOnClicked(new Action<int>(this.OnClickedFriendItem));
		return selectedFriendItem;
	}

	// Token: 0x060084D0 RID: 34000 RVA: 0x0028B528 File Offset: 0x00289728
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

	// Token: 0x040050E6 RID: 20710
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<SelectedFriendItem, int> FriendLoopScrollView;

	// Token: 0x02006F4B RID: 28491
	private class EChildType
	{
		// Token: 0x040245F8 RID: 148984
		public const int FriendLoopScrollView = 0;

		// Token: 0x040245F9 RID: 148985
		public const int SourceFriendItem = 1;

		// Token: 0x040245FA RID: 148986
		public const int NoFriendItem = 2;
	}
}
