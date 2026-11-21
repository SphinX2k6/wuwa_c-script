using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000C62 RID: 3170
[NullableContext(1)]
[Nullable(0)]
public class ChatView : UiTickViewBase
{
	// Token: 0x06008466 RID: 33894 RVA: 0x00288A1B File Offset: 0x00286C1B
	public ChatView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008467 RID: 33895 RVA: 0x00288A5C File Offset: 0x00286C5C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 27;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITextInputComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIDynScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 7;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickAddPrivateChatButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickExpressionButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickQuickChatButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickSendButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickFriendDetailButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickCloseButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.OnClickCloseButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008468 RID: 33896 RVA: 0x00288F22 File Offset: 0x00287122
	protected override void OnBeforeCreate()
	{
		UiInteractLogReport.RecordChatOpen();
	}

	// Token: 0x06008469 RID: 33897 RVA: 0x00288F2C File Offset: 0x0028712C
	protected override UniTask OnBeforeStartAsync()
	{
		ChatView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ChatView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600846A RID: 33898 RVA: 0x00288F6F File Offset: 0x0028716F
	private ChatContentItem CreateNodeGrid(IChatContentDynamicData data, UUIItem uiItem, int index)
	{
		return new ChatContentItem();
	}

	// Token: 0x0600846B RID: 33899 RVA: 0x00288F78 File Offset: 0x00287178
	protected override void OnStart()
	{
		this.IsInTouch = Info.Instance.IsInTouch();
		this.ChatInputMaxNum = ConfigCommonParamById.GetIntConfig("chat_character").Value;
		base.GetInputText(2).MaxInput = (uint)this.ChatInputMaxNum;
		base.GetItem(10).SetUIActive(false);
		AUIBaseActor gridActor = base.GetItem(10).GetOwner() as AUIBaseActor;
		this.ChatRoomItemLoopScrollView = new LoopScrollView<ChatRoomItem, ChatRoom>(base.GetLoopScrollViewComponent(15), gridActor, new Func<ChatRoomItem>(this.OnGridProxyCreate), false);
		ChatModel instance = ChatModel.Instance;
		List<ChatRoom> allSortedChatRoom = instance.GetAllSortedChatRoom();
		this.RefreshChatRoomItem(allSortedChatRoom);
		ChatRoom chatRoom = instance.GetJoinedChatRoom();
		if (chatRoom == null)
		{
			chatRoom = this.JoinFirstChatRoom(allSortedChatRoom);
		}
		if (chatRoom is PrivateChatRoom)
		{
			this.RefreshPrivateChatRoom((PrivateChatRoom)chatRoom);
		}
		else if (chatRoom != null)
		{
			this.RefreshTeamChatRoom(chatRoom);
		}
		this.SetHasChat(chatRoom != null);
		this.TryActivateRefreshPlayInfoTimeDown();
		this.RefreshTextInputDefaultText();
		this.AddEvents();
		this.RefreshBlurItem();
	}

	// Token: 0x0600846C RID: 33900 RVA: 0x00289068 File Offset: 0x00287268
	private void RefreshBlurItem()
	{
		bool flag = UiManager.Instance.IsViewShow(EUiViewName.BattleView);
		UUIItem item = base.GetItem(23);
		UUIItem item2 = base.GetItem(24);
		if (flag)
		{
			item.SetUIActive(true);
			item2.SetUIActive(false);
			return;
		}
		item.SetUIActive(false);
		item2.SetUIActive(true);
	}

	// Token: 0x0600846D RID: 33901 RVA: 0x002890B8 File Offset: 0x002872B8
	protected override void OnBeforeDestroy()
	{
		this.ClearChatContent();
		this.RemoveRefreshPlayInfoTimeDown();
		this.ClearScrollToBottomTimers();
		ChatModel.Instance.LeaveCurrentChatRoom();
		this.RemoveEvents();
		LoopScrollView<ChatRoomItem, ChatRoom> chatRoomItemLoopScrollView = this.ChatRoomItemLoopScrollView;
		if (chatRoomItemLoopScrollView != null)
		{
			chatRoomItemLoopScrollView.ClearGridProxies();
		}
		this.ChatRoomItemLoopScrollView = null;
		this.CurrentChatRoomList.Clear();
		this.IsTryScroll = false;
	}

	// Token: 0x0600846E RID: 33902 RVA: 0x00289111 File Offset: 0x00287311
	protected override void OnAfterDestroy()
	{
		UiInteractLogReport.RecordChatClose();
	}

	// Token: 0x0600846F RID: 33903 RVA: 0x00289118 File Offset: 0x00287318
	protected override void OnTick(float delta)
	{
		bool isTryScroll = this.IsTryScroll;
	}

	// Token: 0x06008470 RID: 33904 RVA: 0x00289124 File Offset: 0x00287324
	private void AddEvents()
	{
		UUITextInputComponent inputText = base.GetInputText(2);
		inputText.OnTextChange.Bind(new Action<string>(this.OnChatInputChanged));
		inputText.OnTextSubmit.Bind(new Action<string>(this.OnChatInputSubmit));
		inputText.OnInputActivateDelegate.Bind(new Action<bool>(this.OnInputActivate));
		inputText.OnCheckTextInputDelegate.Bind(new Func<string, bool>(this.OnCheckTextInput));
		inputText.OnTextClip.Bind(new Action<string>(this.OnCheckTextClip));
		base.GetUIDynScrollViewComponent(11).OnScrollValueChange.Bind(new Action<FVector2D>(this.OnChatScrollValueChange));
		InputDistributeController.Instance.BindAction("激活聊天", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputChat));
		EventSystem.Instance.Add<int>(EEventName.OnCreatePrivateChatRoom, new Action<int>(this.OnCreatePrivateChatRoom));
		EventSystem.Instance.Add<ChatRoom>(EEventName.OnJoinChatRoom, new Action<ChatRoom>(this.OnJoinChatRoom));
		EventSystem.Instance.Add<ChatRoom, ChatContentData>(EEventName.OnAddChatContent, new Action<ChatRoom, ChatContentData>(this.OnAddChatContent));
		EventSystem.Instance.Add<ChatRoom>(EEventName.OnAddHistoryChatContentCompleted, new Action<ChatRoom>(this.OnAddHistoryChatContentCompleted));
		EventSystem.Instance.Add<ChatRoom>(EEventName.OnOpenChatRoom, new Action<ChatRoom>(this.OnOpenChatRoom));
		EventSystem.Instance.Add<int>(EEventName.OnRemovePrivateChatRoom, new Action<int>(this.OnRemoveOrClosePrivateChatRoom));
		EventSystem.Instance.Add<int>(EEventName.OnClosePrivateChatRoom, new Action<int>(this.OnRemoveOrClosePrivateChatRoom));
		EventSystem.Instance.Add<int>(EEventName.OnSelectExpression, new Action<int>(this.OnSelectExpression));
		EventSystem.Instance.Add<int>(EEventName.SearchPlayerInfo, new Action<int>(this.OnRefreshPrivateFriendInfo));
		EventSystem.Instance.Add<int>(EEventName.OnAddMutePlayer, new Action<int>(this.OnRefreshMutePlayer));
		EventSystem.Instance.Add<int>(EEventName.OnRemoveMutePlayer, new Action<int>(this.OnRefreshMutePlayer));
		EventSystem.Instance.Add<int>(EEventName.OnChatPlayerInfoChanged, new Action<int>(this.OnChatPlayerInfoChanged));
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
	}

	// Token: 0x06008471 RID: 33905 RVA: 0x00289350 File Offset: 0x00287550
	private void RemoveEvents()
	{
		UUITextInputComponent inputText = base.GetInputText(2);
		inputText.OnTextChange.Unbind();
		inputText.OnTextSubmit.Unbind();
		inputText.OnInputActivateDelegate.Unbind();
		inputText.OnCheckTextInputDelegate.Unbind();
		inputText.OnTextClip.Unbind();
		base.GetUIDynScrollViewComponent(11).OnScrollValueChange.Unbind();
		InputDistributeController.Instance.UnBindAction("激活聊天", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputChat));
		EventSystem.Instance.Remove(EEventName.OnCreatePrivateChatRoom, new Action<int>(this.OnCreatePrivateChatRoom));
		EventSystem.Instance.Remove(EEventName.OnJoinChatRoom, new Action<ChatRoom>(this.OnJoinChatRoom));
		EventSystem.Instance.Remove(EEventName.OnAddChatContent, new Action<ChatRoom, ChatContentData>(this.OnAddChatContent));
		EventSystem.Instance.Remove(EEventName.OnAddHistoryChatContentCompleted, new Action<ChatRoom>(this.OnAddHistoryChatContentCompleted));
		EventSystem.Instance.Remove(EEventName.OnOpenChatRoom, new Action<ChatRoom>(this.OnOpenChatRoom));
		EventSystem.Instance.Remove(EEventName.OnRemovePrivateChatRoom, new Action<int>(this.OnRemoveOrClosePrivateChatRoom));
		EventSystem.Instance.Remove(EEventName.OnClosePrivateChatRoom, new Action<int>(this.OnRemoveOrClosePrivateChatRoom));
		EventSystem.Instance.Remove(EEventName.OnSelectExpression, new Action<int>(this.OnSelectExpression));
		EventSystem.Instance.Remove(EEventName.SearchPlayerInfo, new Action<int>(this.OnRefreshPrivateFriendInfo));
		EventSystem.Instance.Remove(EEventName.OnAddMutePlayer, new Action<int>(this.OnRefreshMutePlayer));
		EventSystem.Instance.Remove(EEventName.OnRemoveMutePlayer, new Action<int>(this.OnRefreshMutePlayer));
		EventSystem.Instance.Remove(EEventName.OnChatPlayerInfoChanged, new Action<int>(this.OnChatPlayerInfoChanged));
		EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
	}

	// Token: 0x06008472 RID: 33906 RVA: 0x00289533 File Offset: 0x00287733
	private ChatRoomItem OnGridProxyCreate()
	{
		return this.NewPrivateChatFriendItem();
	}

	// Token: 0x06008473 RID: 33907 RVA: 0x0028953B File Offset: 0x0028773B
	private void OnChatInputChanged(string content)
	{
	}

	// Token: 0x06008474 RID: 33908 RVA: 0x00289540 File Offset: 0x00287740
	private void OnChatInputSubmit(string content)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Chat;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "当聊天文本提交时";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("content", content);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.PrivateChatRequest(content, ChatContentType.Text);
	}

	// Token: 0x06008475 RID: 33909 RVA: 0x0028957E File Offset: 0x0028777E
	private void OnInputActivate(bool state)
	{
	}

	// Token: 0x06008476 RID: 33910 RVA: 0x00289580 File Offset: 0x00287780
	private bool OnCheckTextInput(string inString)
	{
		return true;
	}

	// Token: 0x06008477 RID: 33911 RVA: 0x00289583 File Offset: 0x00287783
	private void OnCheckTextClip(string str)
	{
		ScrollingTipsController.Instance.ShowTipsById("ReachInputMaxNum", new object[]
		{
			this.ChatInputMaxNum
		});
	}

	// Token: 0x06008478 RID: 33912 RVA: 0x002895A8 File Offset: 0x002877A8
	private void OnChatScrollValueChange(FVector2D inVector)
	{
		if (inVector.Y >= 0f)
		{
			this.CanRequestHistory = true;
			return;
		}
		if (!this.CanRequestHistory)
		{
			return;
		}
		if (ChatController.Instance.IsInRequestHistory)
		{
			return;
		}
		this.CanRequestHistory = false;
		ChatModel instance = ChatModel.Instance;
		ChatRoom joinedChatRoom = instance.GetJoinedChatRoom();
		if (!(joinedChatRoom is PrivateChatRoom))
		{
			return;
		}
		instance.RequestPrivateRoomLocalHistory(joinedChatRoom as PrivateChatRoom);
	}

	// Token: 0x06008479 RID: 33913 RVA: 0x00289609 File Offset: 0x00287809
	private void OnCreatePrivateChatRoom(int targetPlayerId)
	{
	}

	// Token: 0x0600847A RID: 33914 RVA: 0x0028960C File Offset: 0x0028780C
	private void OnInputChat(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
	{
		if (!this.HasChat)
		{
			return;
		}
		if (actionType != InputDistributeDefine.EActionType.Press)
		{
			return;
		}
		UUITextInputComponent inputText = base.GetInputText(2);
		if (!inputText.IsInputActive())
		{
			inputText.ActivateInputText();
		}
	}

	// Token: 0x0600847B RID: 33915 RVA: 0x0028963C File Offset: 0x0028783C
	private void OnOpenChatRoom(ChatRoom chatRoom)
	{
		List<ChatRoom> allSortedChatRoom = ChatModel.Instance.GetAllSortedChatRoom();
		this.RefreshChatRoomItem(allSortedChatRoom);
		ChatRoom joinedChatRoom = ChatModel.Instance.GetJoinedChatRoom();
		if (joinedChatRoom == null)
		{
			return;
		}
		this.SelectChatRoom(joinedChatRoom, allSortedChatRoom);
		if (joinedChatRoom.GetUniqueId() != chatRoom.GetUniqueId())
		{
			return;
		}
		if (joinedChatRoom is PrivateChatRoom)
		{
			this.RefreshPrivateChatRoom((PrivateChatRoom)joinedChatRoom);
		}
		else
		{
			this.RefreshTeamChatRoom(joinedChatRoom);
		}
		this.SetHasChat(true);
	}

	// Token: 0x0600847C RID: 33916 RVA: 0x002896A8 File Offset: 0x002878A8
	private void OnAddChatContent(ChatRoom chatRoom, ChatContentData chatContentData)
	{
		ChatModel instance = ChatModel.Instance;
		ChatRoom joinedChatRoom = instance.GetJoinedChatRoom();
		if (joinedChatRoom != null)
		{
			int uniqueId = joinedChatRoom.GetUniqueId();
			int uniqueId2 = chatRoom.GetUniqueId();
			List<ChatRoom> allSortedChatRoom = instance.GetAllSortedChatRoom();
			this.RefreshChatRoomItem(allSortedChatRoom);
			this.SelectChatRoom(joinedChatRoom, allSortedChatRoom);
			if (uniqueId == uniqueId2)
			{
				this.CheckIfBlockThenAddChatContent(chatContentData).Forget();
			}
		}
	}

	// Token: 0x0600847D RID: 33917 RVA: 0x002896F8 File Offset: 0x002878F8
	private UniTask CheckIfBlockThenAddChatContent(ChatContentData chatContentData)
	{
		ChatView.<CheckIfBlockThenAddChatContent>d__38 <CheckIfBlockThenAddChatContent>d__;
		<CheckIfBlockThenAddChatContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckIfBlockThenAddChatContent>d__.<>4__this = this;
		<CheckIfBlockThenAddChatContent>d__.chatContentData = chatContentData;
		<CheckIfBlockThenAddChatContent>d__.<>1__state = -1;
		<CheckIfBlockThenAddChatContent>d__.<>t__builder.Start<ChatView.<CheckIfBlockThenAddChatContent>d__38>(ref <CheckIfBlockThenAddChatContent>d__);
		return <CheckIfBlockThenAddChatContent>d__.<>t__builder.Task;
	}

	// Token: 0x0600847E RID: 33918 RVA: 0x00289744 File Offset: 0x00287944
	private void OnJoinChatRoom(ChatRoom chatRoom)
	{
		if (ChatModel.Instance.GetJoinedChatRoom().GetUniqueId() != chatRoom.GetUniqueId())
		{
			return;
		}
		List<ChatRoom> allSortedChatRoom = ChatModel.Instance.GetAllSortedChatRoom();
		if (chatRoom is PrivateChatRoom)
		{
			this.RefreshPrivateChatRoom((PrivateChatRoom)chatRoom);
			this.SelectChatRoom(chatRoom, allSortedChatRoom);
		}
		else if (chatRoom is TeamChatRoom || chatRoom is WorldChatRoom)
		{
			this.RefreshTeamChatRoom(chatRoom);
			this.SelectChatRoom(chatRoom, allSortedChatRoom);
		}
		this.SetHasChat(true);
	}

	// Token: 0x0600847F RID: 33919 RVA: 0x002897B8 File Offset: 0x002879B8
	private void OnAddHistoryChatContentCompleted(ChatRoom chatRoom)
	{
		if (!(chatRoom is PrivateChatRoom))
		{
			return;
		}
		this.IsTryScroll = false;
		ChatRoom joinedChatRoom = ChatModel.Instance.GetJoinedChatRoom();
		if (joinedChatRoom == null)
		{
			List<ChatRoom> allSortedChatRoom = ChatModel.Instance.GetAllSortedChatRoom();
			this.RefreshChatRoomItem(allSortedChatRoom);
			this.JoinPrivateChatRoom((PrivateChatRoom)chatRoom);
			return;
		}
		if (joinedChatRoom.GetUniqueId() != chatRoom.GetUniqueId())
		{
			return;
		}
		this.RefreshChatContent(joinedChatRoom).Forget();
		this.SetHasChat(true);
	}

	// Token: 0x06008480 RID: 33920 RVA: 0x00289824 File Offset: 0x00287A24
	private void OnRemoveOrClosePrivateChatRoom(int targetPlayerId)
	{
		List<ChatRoom> allSortedChatRoom = ChatModel.Instance.GetAllSortedChatRoom();
		this.RefreshChatRoomItem(allSortedChatRoom);
		ChatRoom chatRoom = this.JoinFirstChatRoom(allSortedChatRoom);
		if (chatRoom == null)
		{
			this.SetHasChat(false);
			return;
		}
		PrivateChatRoom privateChatRoom = chatRoom as PrivateChatRoom;
		if (privateChatRoom != null)
		{
			this.RefreshPrivateChatRoom(privateChatRoom);
			return;
		}
		this.RefreshTeamChatRoom(chatRoom);
	}

	// Token: 0x06008481 RID: 33921 RVA: 0x00289870 File Offset: 0x00287A70
	private void OnSelectExpression(int expressionId)
	{
		ChatRoom joinedChatRoom = ChatModel.Instance.GetJoinedChatRoom();
		if (joinedChatRoom == null)
		{
			Log.Instance.Warn(ELogModule.Chat, ELogAuthor.LJQ, "当前没有加入任何一个聊天室", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (joinedChatRoom is PrivateChatRoom)
		{
			int targetPlayerId = ((PrivateChatRoom)joinedChatRoom).GetTargetPlayerId();
			if (targetPlayerId == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Chat;
				ELogAuthor author = ELogAuthor.LJQ;
				string message = "私聊对象玩家Id不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("targetPlayerId", targetPlayerId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
		}
		this.PrivateChatRequest(expressionId.ToString(), ChatContentType.Emoji);
	}

	// Token: 0x06008482 RID: 33922 RVA: 0x002898FE File Offset: 0x00287AFE
	private void OnClickAddPrivateChatButton()
	{
		UiManager.Instance.OpenView(EUiViewName.SelectedFriendChatView, null, null);
	}

	// Token: 0x06008483 RID: 33923 RVA: 0x00289911 File Offset: 0x00287B11
	private void OnClickExpressionButton()
	{
		UiManager.Instance.OpenView(EUiViewName.ChatExpressionView, null, null);
	}

	// Token: 0x06008484 RID: 33924 RVA: 0x00289924 File Offset: 0x00287B24
	private void OnClickQuickChatButton()
	{
		UiManager.Instance.OpenView(EUiViewName.QuickChatView, null, null);
	}

	// Token: 0x06008485 RID: 33925 RVA: 0x00289938 File Offset: 0x00287B38
	private void OnClickSendButton()
	{
		string text = base.GetInputText(2).GetText();
		this.PrivateChatRequest(text, ChatContentType.Text);
	}

	// Token: 0x06008486 RID: 33926 RVA: 0x0028995C File Offset: 0x00287B5C
	private void OnClickFriendDetailButton()
	{
		ChatRoom joinedChatRoom = ChatModel.Instance.GetJoinedChatRoom();
		if (joinedChatRoom == null)
		{
			return;
		}
		if (!(base.GetButton(8).GetOwner().GetComponentByClass(UUIItem.StaticClass()) is UUIItem))
		{
			return;
		}
		if (joinedChatRoom is PrivateChatRoom)
		{
			int playerId = ((PrivateChatRoom)joinedChatRoom).GetTargetPlayerId();
			FriendController.Instance.RequestPlayerCurrentDeactivationState(playerId, delegate(bool deactivation)
			{
				if (deactivation)
				{
					string localTextNew = ConfigMultiTextLang.GetLocalTextNew("PlayerDeleteSelf", null);
					GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FloatLinePrompt, null, null, new string[]
					{
						localTextNew
					}, null, null, null, null, null, false, null);
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.ChatOption, playerId, null);
			});
		}
	}

	// Token: 0x06008487 RID: 33927 RVA: 0x002899D6 File Offset: 0x00287BD6
	private void OnClickCloseButton()
	{
		UiManager.Instance.CloseView(EUiViewName.ChatView, null);
	}

	// Token: 0x06008488 RID: 33928 RVA: 0x002899E8 File Offset: 0x00287BE8
	private void RefreshTextInputDefaultText()
	{
		UUIText text = base.GetText(18);
		if (!InputSettingsManager.Instance.GetActionKeyDisplayData(this.InputKeyDisplayDataRef, "激活聊天"))
		{
			LguiUtil.Instance.SetLocalTextNew(text, "PrefabTextItem_1493640674_Text", Array.Empty<object>());
			return;
		}
		string[] displayKeyNameList = this.InputKeyDisplayDataRef.GetDisplayKeyNameList(0);
		if (displayKeyNameList == null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "PrefabTextItem_1493640674_Text", Array.Empty<object>());
			return;
		}
		string text2 = "";
		foreach (string keyName in displayKeyNameList)
		{
			string keyIconPath = InputSettings.Instance.GetKeyIconPath(keyName);
			text2 = text2 + "<texture=" + keyIconPath + ">";
		}
		LguiUtil.Instance.SetLocalTextNew(text, "SendChatText", new <>z__ReadOnlySingleElementList<object>(text2));
	}

	// Token: 0x06008489 RID: 33929 RVA: 0x00289AA8 File Offset: 0x00287CA8
	private void PrivateChatRequest(string text, ChatContentType chatContentType)
	{
		if (StringUtils.IsEmpty(text))
		{
			ScrollingTipsController.Instance.ShowTipsById("InputChatContent", Array.Empty<object>());
			return;
		}
		if (text.Length > this.ChatInputMaxNum)
		{
			ScrollingTipsController.Instance.ShowTipsById("ReachInputMaxNum", new object[]
			{
				this.ChatInputMaxNum
			});
			return;
		}
		ChatRoom joinedChatRoom = ChatModel.Instance.GetJoinedChatRoom();
		if (joinedChatRoom == null)
		{
			Log.Instance.Warn(ELogModule.Chat, ELogAuthor.LJQ, "当前没有加入任何一个聊天室", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		double lastTimeStamp = joinedChatRoom.GetLastTimeStamp();
		if (TimeUtil.Instance.GetServerTime() - lastTimeStamp < (double)(joinedChatRoom.ChatCd / TimeUtil.Instance.InverseMillisecond))
		{
			GenericPromptController.Instance.ShowPromptByCode("ChatCdText", Array.Empty<object>());
			return;
		}
		if (joinedChatRoom is PrivateChatRoom)
		{
			int targetPlayerId = ((PrivateChatRoom)joinedChatRoom).GetTargetPlayerId();
			if (targetPlayerId == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Chat;
				ELogAuthor author = ELogAuthor.LJQ;
				string message = "私聊对象玩家Id不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("targetPlayerId", targetPlayerId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (FriendModel.Instance.HasBlockedPlayer(targetPlayerId))
			{
				ScrollingTipsController.Instance.ShowTipsById("ChatRefuseText", Array.Empty<object>());
				return;
			}
			ChatController.Instance.PrivateChatRequest(chatContentType, text, targetPlayerId);
		}
		else if (joinedChatRoom is TeamChatRoom)
		{
			ChatController.Instance.ChannelChatRequest(chatContentType, text, SubChatChannelType.MatchTeam);
		}
		else if (joinedChatRoom is WorldChatRoom)
		{
			ChatController.Instance.ChannelChatRequest(chatContentType, text, SubChatChannelType.WorldTeam);
		}
		base.GetInputText(2).SetText("", false);
	}

	// Token: 0x0600848A RID: 33930 RVA: 0x00289C28 File Offset: 0x00287E28
	private void SetHasChat(bool bHasChat)
	{
		UUIItem item = base.GetItem(12);
		UUIItem item2 = base.GetItem(13);
		item.SetUIActive(bHasChat);
		item2.SetUIActive(!bHasChat);
		this.HasChat = bHasChat;
	}

	// Token: 0x0600848B RID: 33931 RVA: 0x00289C5D File Offset: 0x00287E5D
	private void SetFriendDetailButtonVisible(bool bVisible)
	{
		AUIBaseActor auibaseActor = base.GetButton(8).GetOwner() as AUIBaseActor;
		if (auibaseActor == null)
		{
			return;
		}
		UUIItem uiitem = auibaseActor.GetUIItem();
		if (uiitem == null)
		{
			return;
		}
		uiitem.SetUIActive(bVisible);
	}

	// Token: 0x0600848C RID: 33932 RVA: 0x00289C88 File Offset: 0x00287E88
	private void RefreshPrivateChatRoom(PrivateChatRoom privateChatRoom)
	{
		if (privateChatRoom == null)
		{
			return;
		}
		if (!privateChatRoom.CanChat())
		{
			return;
		}
		List<ChatRoom> allSortedChatRoom = ChatModel.Instance.GetAllSortedChatRoom();
		this.RefreshIsOnline(privateChatRoom, true);
		this.RefreshPlayerName(privateChatRoom, false);
		this.RefreshThirdPartyItem(privateChatRoom);
		this.RefreshPcItem(privateChatRoom, false);
		this.SelectChatRoom(privateChatRoom, allSortedChatRoom);
		this.RefreshChatContent(privateChatRoom).Forget();
		this.SetFriendDetailButtonVisible(true);
		this.SetHasChat(true);
	}

	// Token: 0x0600848D RID: 33933 RVA: 0x00289CF0 File Offset: 0x00287EF0
	private void RefreshTeamChatRoom(ChatRoom chatRoom)
	{
		if (chatRoom == null)
		{
			return;
		}
		List<ChatRoom> allSortedChatRoom = ChatModel.Instance.GetAllSortedChatRoom();
		this.SelectChatRoom(chatRoom, allSortedChatRoom);
		this.RefreshChatContent(chatRoom).Forget();
		this.RefreshThirdPartyItem(null);
		this.RefreshPcItem(null, true);
		this.RefreshIsOnline(null, false);
		this.RefreshPlayerName(null, true);
		this.SetFriendDetailButtonVisible(false);
		this.SetHasChat(true);
	}

	// Token: 0x0600848E RID: 33934 RVA: 0x00289D50 File Offset: 0x00287F50
	private UniTask RefreshChatContent(ChatRoom chatRoom)
	{
		ChatView.<RefreshChatContent>d__55 <RefreshChatContent>d__;
		<RefreshChatContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshChatContent>d__.<>4__this = this;
		<RefreshChatContent>d__.chatRoom = chatRoom;
		<RefreshChatContent>d__.<>1__state = -1;
		<RefreshChatContent>d__.<>t__builder.Start<ChatView.<RefreshChatContent>d__55>(ref <RefreshChatContent>d__);
		return <RefreshChatContent>d__.<>t__builder.Task;
	}

	// Token: 0x0600848F RID: 33935 RVA: 0x00289D9C File Offset: 0x00287F9C
	private void AddChatContents(List<ChatContentData> chatContentList)
	{
		if (chatContentList.Count <= 0)
		{
			this.AddChatContent(new List<ChatContentData>(), new bool?(false));
			return;
		}
		this.AddChatContent(chatContentList, new bool?(false));
		this.ScheduleScrollToBottom(() => chatContentList.Count - 1, 500f);
	}

	// Token: 0x06008490 RID: 33936 RVA: 0x00289E00 File Offset: 0x00288000
	private void AddChatContent(List<ChatContentData> chatContentDataList, bool? selectLastItem = false)
	{
		List<IChatContentDynamicData> dataList = new List<IChatContentDynamicData>();
		foreach (ChatContentData chatContentData in chatContentDataList)
		{
			if (chatContentData.NoticeType == ChatChannelNoticeType.EnterTeam || chatContentData.NoticeType == ChatChannelNoticeType.ExitTeam)
			{
				ChatContentDynamicData item = new ChatContentDynamicData
				{
					ChatContentData = chatContentData,
					Type = EChatContentType.Tips
				};
				dataList.Add(item);
			}
			else if (chatContentData.IsOwnSend())
			{
				ChatContentDynamicData item2 = new ChatContentDynamicData
				{
					ChatContentData = chatContentData,
					Type = EChatContentType.Right
				};
				dataList.Add(item2);
			}
			else
			{
				ChatContentDynamicData item3 = new ChatContentDynamicData
				{
					ChatContentData = chatContentData,
					Type = EChatContentType.Left
				};
				dataList.Add(item3);
			}
		}
		this.ChatContentDataList = chatContentDataList;
		DynamicScrollView<ChatContentItem, ChatContentDynamicItem, IChatContentDynamicData> chatLoopScrollView = this.ChatLoopScrollView;
		if (chatLoopScrollView != null)
		{
			chatLoopScrollView.RefreshByData(dataList.ToArray(), true, true);
		}
		bool? flag = selectLastItem;
		bool flag2 = false;
		if ((flag.GetValueOrDefault() == flag2 & flag != null) || !Info.Instance.IsInGamepad())
		{
			return;
		}
		DynamicScrollView<ChatContentItem, ChatContentDynamicItem, IChatContentDynamicData> chatLoopScrollView2 = this.ChatLoopScrollView;
		if (chatLoopScrollView2 == null)
		{
			return;
		}
		Action <>9__2;
		Action <>9__1;
		chatLoopScrollView2.BindLateUpdate(delegate(float _)
		{
			DynamicScrollView<ChatContentItem, ChatContentDynamicItem, IChatContentDynamicData> chatLoopScrollView3 = this.ChatLoopScrollView;
			if (chatLoopScrollView3 != null && !chatLoopScrollView3.CheckIfAllRefreshFinished())
			{
				return;
			}
			DynamicScrollView<ChatContentItem, ChatContentDynamicItem, IChatContentDynamicData> chatLoopScrollView4 = this.ChatLoopScrollView;
			if (chatLoopScrollView4 != null)
			{
				UniTask task = chatLoopScrollView4.ScrollToItemIndex(dataList.Count - 1, true, false);
				Action continuationFunction;
				if ((continuationFunction = <>9__1) == null)
				{
					continuationFunction = (<>9__1 = delegate()
					{
						UniTask task2 = GameUtils.WaitFrame();
						Action continuationFunction2;
						if ((continuationFunction2 = <>9__2) == null)
						{
							continuationFunction2 = (<>9__2 = delegate()
							{
								if (this.GetInputText(2).IsInputActive())
								{
									return;
								}
								DynamicScrollView<ChatContentItem, ChatContentDynamicItem, IChatContentDynamicData> chatLoopScrollView6 = this.ChatLoopScrollView;
								foreach (ChatContentItem chatContentItem in ((chatLoopScrollView6 != null) ? chatLoopScrollView6.GetScrollItemItems() : null) ?? Array.Empty<ChatContentItem>())
								{
									if (chatContentItem.Data.ChatContentData.TimeStamp == dataList[dataList.Count - 1].ChatContentData.TimeStamp)
									{
										UiNavigationNewController.Instance.SetNavigationFocusForView(chatContentItem.GetInteractItem(), true, true, false);
										return;
									}
								}
							});
						}
						task2.ContinueWith(continuationFunction2);
					});
				}
				task.ContinueWith(continuationFunction);
			}
			DynamicScrollView<ChatContentItem, ChatContentDynamicItem, IChatContentDynamicData> chatLoopScrollView5 = this.ChatLoopScrollView;
			if (chatLoopScrollView5 == null)
			{
				return;
			}
			chatLoopScrollView5.UnBindLateUpdate();
		});
	}

	// Token: 0x06008491 RID: 33937 RVA: 0x00289F50 File Offset: 0x00288150
	private void ClearChatContent()
	{
		foreach (ChatContentBase chatContentBase in this.ChatContentList)
		{
			chatContentBase.Destroy(null);
		}
		this.ChatContentList.Clear();
	}

	// Token: 0x06008492 RID: 33938 RVA: 0x00289FAC File Offset: 0x002881AC
	private void SelectChatRoom(ChatRoom selectPrivateChatRoom, List<ChatRoom> chatRoomList)
	{
		if (selectPrivateChatRoom == null)
		{
			return;
		}
		int num = chatRoomList.IndexOf(selectPrivateChatRoom);
		if (num < 0)
		{
			return;
		}
		this.ChatRoomItemLoopScrollView.SelectGridProxy(num, false);
	}

	// Token: 0x06008493 RID: 33939 RVA: 0x00289FD8 File Offset: 0x002881D8
	[NullableContext(2)]
	private void RefreshIsOnline(PrivateChatRoom privateChatRoom, bool isShow = true)
	{
		UUIItem item = base.GetItem(5);
		UUIItem item2 = base.GetItem(17);
		if (!isShow)
		{
			item.SetUIActive(false);
			item2.SetUIActive(false);
			return;
		}
		item.SetUIActive(false);
		item2.SetUIActive(false);
		if (privateChatRoom == null)
		{
			return;
		}
		int num = this.CurrentChatRoomList.IndexOf(privateChatRoom);
		if (num < 0)
		{
			return;
		}
		ChatRoomItem chatRoomItem = this.ChatRoomItemLoopScrollView.UnsafeGetGridProxy(num, false);
		if (chatRoomItem == null)
		{
			return;
		}
		chatRoomItem.RefreshIsOnline(privateChatRoom);
	}

	// Token: 0x06008494 RID: 33940 RVA: 0x0028A044 File Offset: 0x00288244
	[NullableContext(2)]
	private void RefreshPlayerName(PrivateChatRoom privateChatRoom, bool showTitle = false)
	{
		UUIText text = base.GetText(7);
		UUIText text2 = base.GetText(6);
		if (showTitle)
		{
			LguiUtil.Instance.SetLocalText(text, "CurrentTeam", Array.Empty<object>());
			text.SetColor(ChatDefine.playerRealNameColor);
			text2.SetUIActive(false);
			return;
		}
		string playerName = privateChatRoom.GetPlayerName();
		string playerRemarks = privateChatRoom.GetPlayerRemarks();
		text2.SetUIActive(false);
		if (!string.IsNullOrEmpty(playerRemarks))
		{
			text.SetText(playerRemarks, true);
			if (text != null)
			{
				text.SetColor(ChatDefine.playerMarkNameColor);
				return;
			}
		}
		else
		{
			text.SetText(playerName, true);
			text.SetColor(ChatDefine.playerRealNameColor);
		}
	}

	// Token: 0x06008495 RID: 33941 RVA: 0x0028A0D4 File Offset: 0x002882D4
	private void TryActivateRefreshPlayInfoTimeDown()
	{
		this.RemoveRefreshPlayInfoTimeDown();
		ChatRoom joinedChatRoom = ChatModel.Instance.GetJoinedChatRoom();
		if (joinedChatRoom == null)
		{
			return;
		}
		if (!(joinedChatRoom is PrivateChatRoom))
		{
			return;
		}
		this.RefreshPlayInfoTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnRefreshPlayInfoTimeDown), 10000f, 1f, null, null, true);
	}

	// Token: 0x06008496 RID: 33942 RVA: 0x0028A128 File Offset: 0x00288328
	private void RemoveRefreshPlayInfoTimeDown()
	{
		if (!TimerSystem.GameplayTimeInstance.Has(this.RefreshPlayInfoTimerId))
		{
			return;
		}
		TimerSystem.GameplayTimeInstance.Remove(this.RefreshPlayInfoTimerId);
		this.RefreshPlayInfoTimerId = null;
	}

	// Token: 0x06008497 RID: 33943 RVA: 0x0028A158 File Offset: 0x00288358
	private void ScheduleScrollToBottom(Func<int> getItemIndex, float delay)
	{
		TimerHandle handle = null;
		handle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			if (handle != null)
			{
				this.ScrollToBottomTimerIds.Remove(handle);
			}
			DynamicScrollView<ChatContentItem, ChatContentDynamicItem, IChatContentDynamicData> chatLoopScrollView = this.ChatLoopScrollView;
			if (chatLoopScrollView == null || !chatLoopScrollView.IsValid())
			{
				return;
			}
			this.ChatLoopScrollView.ScrollToItemIndex(getItemIndex(), true, false);
		}, delay, null, null, true, 1f);
		if (handle != null)
		{
			this.ScrollToBottomTimerIds.Add(handle);
		}
	}

	// Token: 0x06008498 RID: 33944 RVA: 0x0028A1C0 File Offset: 0x002883C0
	private void ClearScrollToBottomTimers()
	{
		foreach (TimerHandle handle in this.ScrollToBottomTimerIds)
		{
			TimerSystem.GameplayTimeInstance.Remove(handle);
		}
		this.ScrollToBottomTimerIds.Clear();
	}

	// Token: 0x06008499 RID: 33945 RVA: 0x0028A224 File Offset: 0x00288424
	private void OnRefreshPlayInfoTimeDown(float delta)
	{
		ChatRoom joinedChatRoom = ChatModel.Instance.GetJoinedChatRoom();
		if (joinedChatRoom == null)
		{
			return;
		}
		PrivateChatRoom privateChatRoom = joinedChatRoom as PrivateChatRoom;
		if (privateChatRoom == null)
		{
			return;
		}
		int targetPlayerId = privateChatRoom.GetTargetPlayerId();
		FriendModel.Instance.ClearFriendSearchResults();
		FriendController.Instance.RequestSearchPlayerBasicInfo(targetPlayerId, true);
	}

	// Token: 0x0600849A RID: 33946 RVA: 0x0028A268 File Offset: 0x00288468
	private void OnRefreshPrivateFriendInfo(int playerId)
	{
		PrivateChatRoom privateChatRoom = ChatModel.Instance.GetPrivateChatRoom(playerId);
		if (privateChatRoom == null)
		{
			return;
		}
		this.RefreshIsOnline(privateChatRoom, true);
		this.RefreshPlayerName(privateChatRoom, false);
	}

	// Token: 0x0600849B RID: 33947 RVA: 0x0028A298 File Offset: 0x00288498
	private void OnRefreshMutePlayer(int playerId)
	{
		PrivateChatRoom privateChatRoom = ChatModel.Instance.GetPrivateChatRoom(playerId);
		if (privateChatRoom == null)
		{
			return;
		}
		int num = this.CurrentChatRoomList.IndexOf(privateChatRoom);
		if (num < 0)
		{
			return;
		}
		ChatRoomItem chatRoomItem = this.ChatRoomItemLoopScrollView.UnsafeGetGridProxy(num, false);
		if (chatRoomItem == null)
		{
			return;
		}
		chatRoomItem.RefreshMuteItem();
	}

	// Token: 0x0600849C RID: 33948 RVA: 0x0028A2E0 File Offset: 0x002884E0
	private void OnChatPlayerInfoChanged(int playerId)
	{
		PrivateChatRoom privateChatRoom = ChatModel.Instance.GetPrivateChatRoom(playerId);
		if (privateChatRoom == null)
		{
			return;
		}
		int num = this.CurrentChatRoomList.IndexOf(privateChatRoom);
		if (num < 0)
		{
			return;
		}
		ChatRoomItem chatRoomItem = this.ChatRoomItemLoopScrollView.UnsafeGetGridProxy(num, false);
		if (chatRoomItem == null)
		{
			return;
		}
		chatRoomItem.RefreshPlayerTexture();
	}

	// Token: 0x0600849D RID: 33949 RVA: 0x0028A326 File Offset: 0x00288526
	private void InputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		if (this.IsInTouch && !Info.Instance.IsInTouch())
		{
			base.CloseMe(null);
			return;
		}
		this.IsInTouch = Info.Instance.IsInTouch();
		this.RefreshTextInputDefaultText();
	}

	// Token: 0x0600849E RID: 33950 RVA: 0x0028A35A File Offset: 0x0028855A
	private void RefreshChatRoomItem(List<ChatRoom> chatRoomList)
	{
		this.CurrentChatRoomList = chatRoomList;
		LoopScrollView<ChatRoomItem, ChatRoom> chatRoomItemLoopScrollView = this.ChatRoomItemLoopScrollView;
		if (chatRoomItemLoopScrollView == null)
		{
			return;
		}
		chatRoomItemLoopScrollView.RefreshByData(chatRoomList, false, null, false);
	}

	// Token: 0x0600849F RID: 33951 RVA: 0x0028A377 File Offset: 0x00288577
	private ChatRoomItem NewPrivateChatFriendItem()
	{
		ChatRoomItem chatRoomItem = new ChatRoomItem();
		chatRoomItem.BindOnClicked(new Action<EChatRoomType, int>(this.OnChatRoomClicked));
		return chatRoomItem;
	}

	// Token: 0x060084A0 RID: 33952 RVA: 0x0028A390 File Offset: 0x00288590
	private void OnChatRoomClicked(EChatRoomType chatType, int targetPlayerId)
	{
		ChatModel instance = ChatModel.Instance;
		ChatRoom chatRoom = null;
		switch (chatType)
		{
		case EChatRoomType.Private:
			if (FriendModel.Instance.GetFriendById(targetPlayerId) == null)
			{
				return;
			}
			chatRoom = instance.GetPrivateChatRoom(targetPlayerId);
			if (chatRoom is PrivateChatRoom)
			{
				this.JoinPrivateChatRoom((PrivateChatRoom)chatRoom);
			}
			break;
		case EChatRoomType.Team:
			chatRoom = instance.GetTeamChatRoom();
			this.JoinTeamChatRoom();
			break;
		case EChatRoomType.World:
			chatRoom = instance.GetWorldChatRoom();
			this.JoinWorldChatRoom();
			break;
		}
		if (chatRoom != null)
		{
			this.SelectChatRoom(chatRoom, this.CurrentChatRoomList);
		}
	}

	// Token: 0x060084A1 RID: 33953 RVA: 0x0028A414 File Offset: 0x00288614
	private void JoinPrivateChatRoom(PrivateChatRoom privateChatRoom)
	{
		ChatModel instance = ChatModel.Instance;
		int targetPlayerId = privateChatRoom.GetTargetPlayerId();
		if (targetPlayerId == 0)
		{
			return;
		}
		if (!privateChatRoom.CanChat())
		{
			return;
		}
		PrivateChatRoom privateChatRoom2 = instance.GetJoinedChatRoom() as PrivateChatRoom;
		if (privateChatRoom2 != null && privateChatRoom2.GetTargetPlayerId() == targetPlayerId)
		{
			return;
		}
		instance.JoinChatRoom(privateChatRoom);
	}

	// Token: 0x060084A2 RID: 33954 RVA: 0x0028A45C File Offset: 0x0028865C
	private void JoinTeamChatRoom()
	{
		ChatModel instance = ChatModel.Instance;
		TeamChatRoom teamChatRoom = instance.GetTeamChatRoom();
		if (teamChatRoom != null)
		{
			instance.JoinChatRoom(teamChatRoom);
			return;
		}
		Log.Instance.Error(ELogModule.Chat, ELogAuthor.LJQ, "加入队伍聊天室失败，聊天室未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x060084A3 RID: 33955 RVA: 0x0028A4A0 File Offset: 0x002886A0
	private void JoinWorldChatRoom()
	{
		ChatModel instance = ChatModel.Instance;
		WorldChatRoom worldChatRoom = instance.GetWorldChatRoom();
		if (worldChatRoom != null)
		{
			instance.JoinChatRoom(worldChatRoom);
			return;
		}
		Log.Instance.Error(ELogModule.Chat, ELogAuthor.LJQ, "加入世界聊天室失败，聊天室未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x060084A4 RID: 33956 RVA: 0x0028A4E4 File Offset: 0x002886E4
	[return: Nullable(2)]
	private ChatRoom JoinFirstChatRoom(List<ChatRoom> chatRoomList)
	{
		foreach (ChatRoom chatRoom in chatRoomList)
		{
			PrivateChatRoom privateChatRoom = chatRoom as PrivateChatRoom;
			if (privateChatRoom != null)
			{
				if (privateChatRoom.CanChat())
				{
					this.JoinPrivateChatRoom(privateChatRoom);
					return chatRoom;
				}
			}
			else
			{
				if (chatRoom is TeamChatRoom)
				{
					this.JoinTeamChatRoom();
					return chatRoom;
				}
				if (chatRoom is WorldChatRoom)
				{
					this.JoinWorldChatRoom();
					return chatRoom;
				}
			}
		}
		return null;
	}

	// Token: 0x060084A5 RID: 33957 RVA: 0x0028A570 File Offset: 0x00288770
	[NullableContext(2)]
	private void RefreshThirdPartyItem(PrivateChatRoom privateChatRoom)
	{
		if (KuroSdkController.Instance.NeedShowThirdPartyId())
		{
			bool flag = privateChatRoom != null && !string.IsNullOrEmpty((privateChatRoom != null) ? privateChatRoom.GetThirdPartyUserId() : null);
			UUITexture texture = base.GetTexture(21);
			if (texture != null)
			{
				texture.SetUIActive(flag);
			}
			string thirdPartyLogoTexturePath = UiResourceConfig.Instance.GetThirdPartyLogoTexturePath(ELogoSize.Medium);
			base.SetTextureByPath(thirdPartyLogoTexturePath, base.GetTexture(21), null, null);
			if (flag && privateChatRoom != null)
			{
				UUIText text = base.GetText(22);
				if (text != null)
				{
					text.SetText(privateChatRoom.GetThirdPartyOnlineId(), true);
				}
				UUIText text2 = base.GetText(22);
				if (text2 != null)
				{
					text2.SetUIActive(true);
				}
				string thirdPartyTextColor = UiResourceConfig.Instance.GetThirdPartyTextColor(EConsoleColorSet.Set1);
				UUIText text3 = base.GetText(22);
				if (text3 == null)
				{
					return;
				}
				text3.SetColor(FColor.FromHex(thirdPartyTextColor));
				return;
			}
			else
			{
				UUIText text4 = base.GetText(22);
				if (text4 == null)
				{
					return;
				}
				text4.SetUIActive(false);
				return;
			}
		}
		else
		{
			UUITexture texture2 = base.GetTexture(21);
			if (texture2 != null)
			{
				texture2.SetUIActive(false);
			}
			UUIText text5 = base.GetText(22);
			if (text5 == null)
			{
				return;
			}
			text5.SetUIActive(false);
			return;
		}
	}

	// Token: 0x060084A6 RID: 33958 RVA: 0x0028A674 File Offset: 0x00288874
	[NullableContext(2)]
	private void RefreshPcItem(PrivateChatRoom privateChatRoom, bool ifTeamRoom = false)
	{
		if (ifTeamRoom)
		{
			UUIItem item = base.GetItem(25);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
			return;
		}
		else if (KuroSdkController.Instance.NeedShowThirdPartyId())
		{
			bool flag = privateChatRoom != null && !string.IsNullOrEmpty((privateChatRoom != null) ? privateChatRoom.GetThirdPartyUserId() : null);
			UUIItem item2 = base.GetItem(25);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!flag);
			return;
		}
		else
		{
			UUIItem item3 = base.GetItem(25);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(false);
			return;
		}
	}

	// Token: 0x060084A7 RID: 33959 RVA: 0x0028A6E9 File Offset: 0x002888E9
	protected override void OnBeforeShow()
	{
		GameSettingsDeviceRender.Instance.TemporaryDisableFrameGeneration("ChatView");
	}

	// Token: 0x060084A8 RID: 33960 RVA: 0x0028A6FA File Offset: 0x002888FA
	protected override void OnAfterHide()
	{
		GameSettingsDeviceRender.Instance.CancelTemporaryDisableFrameGeneration("ChatView");
	}

	// Token: 0x040050CF RID: 20687
	private List<ChatContentData> ChatContentDataList = new List<ChatContentData>();

	// Token: 0x040050D0 RID: 20688
	private readonly List<ChatContentBase> ChatContentList = new List<ChatContentBase>();

	// Token: 0x040050D1 RID: 20689
	private bool CanRequestHistory;

	// Token: 0x040050D2 RID: 20690
	[Nullable(2)]
	private TimerHandle RefreshPlayInfoTimerId;

	// Token: 0x040050D3 RID: 20691
	private readonly HashSet<TimerHandle> ScrollToBottomTimerIds = new HashSet<TimerHandle>();

	// Token: 0x040050D4 RID: 20692
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ChatRoomItem, ChatRoom> ChatRoomItemLoopScrollView;

	// Token: 0x040050D5 RID: 20693
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<ChatContentItem, ChatContentDynamicItem, IChatContentDynamicData> ChatLoopScrollView;

	// Token: 0x040050D6 RID: 20694
	[Nullable(2)]
	private ChatContentDynamicItem ChatBaseItem;

	// Token: 0x040050D7 RID: 20695
	private List<ChatRoom> CurrentChatRoomList = new List<ChatRoom>();

	// Token: 0x040050D8 RID: 20696
	public int ChatInputMaxNum;

	// Token: 0x040050D9 RID: 20697
	private bool HasChat;

	// Token: 0x040050DA RID: 20698
	private bool IsTryScroll;

	// Token: 0x040050DB RID: 20699
	private readonly InputKeyDisplayData InputKeyDisplayDataRef = new InputKeyDisplayData();

	// Token: 0x040050DC RID: 20700
	private bool IsInTouch;

	// Token: 0x02006F40 RID: 28480
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x040245B4 RID: 148916
		public const int AddPrivateChatButton = 0;

		// Token: 0x040245B5 RID: 148917
		public const int ExpressionButton = 1;

		// Token: 0x040245B6 RID: 148918
		public const int ChatInputText = 2;

		// Token: 0x040245B7 RID: 148919
		public const int QuickChatButton = 3;

		// Token: 0x040245B8 RID: 148920
		public const int SendButton = 4;

		// Token: 0x040245B9 RID: 148921
		public const int OnlineState = 5;

		// Token: 0x040245BA RID: 148922
		public const int FriendRemarks = 6;

		// Token: 0x040245BB RID: 148923
		public const int FriendNameText = 7;

		// Token: 0x040245BC RID: 148924
		public const int FriendDetailButton = 8;

		// Token: 0x040245BD RID: 148925
		public const int CloseButton = 9;

		// Token: 0x040245BE RID: 148926
		public const int ChatFriendSourceItem = 10;

		// Token: 0x040245BF RID: 148927
		public const int ChatScrollView = 11;

		// Token: 0x040245C0 RID: 148928
		public const int ChatItem = 12;

		// Token: 0x040245C1 RID: 148929
		public const int NoneItem = 13;

		// Token: 0x040245C2 RID: 148930
		public const int ChatScrollContent = 14;

		// Token: 0x040245C3 RID: 148931
		public const int ChatRoomItemLoopScrollView = 15;

		// Token: 0x040245C4 RID: 148932
		public const int MastButton = 16;

		// Token: 0x040245C5 RID: 148933
		public const int OfflineState = 17;

		// Token: 0x040245C6 RID: 148934
		public const int TextInputDefaultText = 18;

		// Token: 0x040245C7 RID: 148935
		public const int InputItem = 19;

		// Token: 0x040245C8 RID: 148936
		public const int MuteItem = 20;

		// Token: 0x040245C9 RID: 148937
		public const int ThirdPartyTexture = 21;

		// Token: 0x040245CA RID: 148938
		public const int ThirdPartyText = 22;

		// Token: 0x040245CB RID: 148939
		public const int FullBlur = 23;

		// Token: 0x040245CC RID: 148940
		public const int PartialBlur = 24;

		// Token: 0x040245CD RID: 148941
		public const int PcItem = 25;

		// Token: 0x040245CE RID: 148942
		public const int ChatScrollItem = 26;
	}
}
