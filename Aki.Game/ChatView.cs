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

// Token: 0x020017A9 RID: 6057
[NullableContext(1)]
[Nullable(0)]
public class ChatView : UiTickViewBase
{
	// Token: 0x0600B07E RID: 45182 RVA: 0x0027E483 File Offset: 0x0027C683
	public ChatView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B07F RID: 45183 RVA: 0x0027E4C4 File Offset: 0x0027C6C4
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

	// Token: 0x0600B080 RID: 45184 RVA: 0x0027E98A File Offset: 0x0027CB8A
	protected override void OnBeforeCreate()
	{
		UiInteractLogReport.RecordChatOpen();
	}

	// Token: 0x0600B081 RID: 45185 RVA: 0x0027E994 File Offset: 0x0027CB94
	protected override UniTask OnBeforeStartAsync()
	{
		ChatView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ChatView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B082 RID: 45186 RVA: 0x0027E9D7 File Offset: 0x0027CBD7
	private ChatContentItem CreateNodeGrid(IChatContentDynamicData data, UUIItem uiItem, int index)
	{
		return new ChatContentItem();
	}

	// Token: 0x0600B083 RID: 45187 RVA: 0x0027E9E0 File Offset: 0x0027CBE0
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

	// Token: 0x0600B084 RID: 45188 RVA: 0x0027EAD0 File Offset: 0x0027CCD0
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

	// Token: 0x0600B085 RID: 45189 RVA: 0x0027EB20 File Offset: 0x0027CD20
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

	// Token: 0x0600B086 RID: 45190 RVA: 0x0027EB79 File Offset: 0x0027CD79
	protected override void OnAfterDestroy()
	{
		UiInteractLogReport.RecordChatClose();
	}

	// Token: 0x0600B087 RID: 45191 RVA: 0x0027EB80 File Offset: 0x0027CD80
	protected override void OnTick(float delta)
	{
		bool isTryScroll = this.IsTryScroll;
	}

	// Token: 0x0600B088 RID: 45192 RVA: 0x0027EB8C File Offset: 0x0027CD8C
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

	// Token: 0x0600B089 RID: 45193 RVA: 0x0027EDB8 File Offset: 0x0027CFB8
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

	// Token: 0x0600B08A RID: 45194 RVA: 0x0027EF9B File Offset: 0x0027D19B
	private ChatRoomItem OnGridProxyCreate()
	{
		return this.NewPrivateChatFriendItem();
	}

	// Token: 0x0600B08B RID: 45195 RVA: 0x0027EFA3 File Offset: 0x0027D1A3
	private void OnChatInputChanged(string content)
	{
	}

	// Token: 0x0600B08C RID: 45196 RVA: 0x0027EFA8 File Offset: 0x0027D1A8
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

	// Token: 0x0600B08D RID: 45197 RVA: 0x0027EFE6 File Offset: 0x0027D1E6
	private void OnInputActivate(bool state)
	{
	}

	// Token: 0x0600B08E RID: 45198 RVA: 0x0027EFE8 File Offset: 0x0027D1E8
	private bool OnCheckTextInput(string inString)
	{
		return true;
	}

	// Token: 0x0600B08F RID: 45199 RVA: 0x0027EFEB File Offset: 0x0027D1EB
	private void OnCheckTextClip(string str)
	{
		ScrollingTipsController.Instance.ShowTipsById("ReachInputMaxNum", new object[]
		{
			this.ChatInputMaxNum
		});
	}

	// Token: 0x0600B090 RID: 45200 RVA: 0x0027F010 File Offset: 0x0027D210
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

	// Token: 0x0600B091 RID: 45201 RVA: 0x0027F071 File Offset: 0x0027D271
	private void OnCreatePrivateChatRoom(int targetPlayerId)
	{
	}

	// Token: 0x0600B092 RID: 45202 RVA: 0x0027F074 File Offset: 0x0027D274
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

	// Token: 0x0600B093 RID: 45203 RVA: 0x0027F0A4 File Offset: 0x0027D2A4
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

	// Token: 0x0600B094 RID: 45204 RVA: 0x0027F110 File Offset: 0x0027D310
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

	// Token: 0x0600B095 RID: 45205 RVA: 0x0027F160 File Offset: 0x0027D360
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

	// Token: 0x0600B096 RID: 45206 RVA: 0x0027F1AC File Offset: 0x0027D3AC
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

	// Token: 0x0600B097 RID: 45207 RVA: 0x0027F220 File Offset: 0x0027D420
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

	// Token: 0x0600B098 RID: 45208 RVA: 0x0027F28C File Offset: 0x0027D48C
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

	// Token: 0x0600B099 RID: 45209 RVA: 0x0027F2D8 File Offset: 0x0027D4D8
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

	// Token: 0x0600B09A RID: 45210 RVA: 0x0027F366 File Offset: 0x0027D566
	private void OnClickAddPrivateChatButton()
	{
		UiManager.Instance.OpenView(EUiViewName.SelectedFriendChatView, null, null);
	}

	// Token: 0x0600B09B RID: 45211 RVA: 0x0027F379 File Offset: 0x0027D579
	private void OnClickExpressionButton()
	{
		UiManager.Instance.OpenView(EUiViewName.ChatExpressionView, null, null);
	}

	// Token: 0x0600B09C RID: 45212 RVA: 0x0027F38C File Offset: 0x0027D58C
	private void OnClickQuickChatButton()
	{
		UiManager.Instance.OpenView(EUiViewName.QuickChatView, null, null);
	}

	// Token: 0x0600B09D RID: 45213 RVA: 0x0027F3A0 File Offset: 0x0027D5A0
	private void OnClickSendButton()
	{
		string text = base.GetInputText(2).GetText();
		this.PrivateChatRequest(text, ChatContentType.Text);
	}

	// Token: 0x0600B09E RID: 45214 RVA: 0x0027F3C4 File Offset: 0x0027D5C4
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

	// Token: 0x0600B09F RID: 45215 RVA: 0x0027F43E File Offset: 0x0027D63E
	private void OnClickCloseButton()
	{
		UiManager.Instance.CloseView(EUiViewName.ChatView, null);
	}

	// Token: 0x0600B0A0 RID: 45216 RVA: 0x0027F450 File Offset: 0x0027D650
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

	// Token: 0x0600B0A1 RID: 45217 RVA: 0x0027F510 File Offset: 0x0027D710
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

	// Token: 0x0600B0A2 RID: 45218 RVA: 0x0027F690 File Offset: 0x0027D890
	private void SetHasChat(bool bHasChat)
	{
		UUIItem item = base.GetItem(12);
		UUIItem item2 = base.GetItem(13);
		item.SetUIActive(bHasChat);
		item2.SetUIActive(!bHasChat);
		this.HasChat = bHasChat;
	}

	// Token: 0x0600B0A3 RID: 45219 RVA: 0x0027F6C5 File Offset: 0x0027D8C5
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

	// Token: 0x0600B0A4 RID: 45220 RVA: 0x0027F6F0 File Offset: 0x0027D8F0
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

	// Token: 0x0600B0A5 RID: 45221 RVA: 0x0027F758 File Offset: 0x0027D958
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

	// Token: 0x0600B0A6 RID: 45222 RVA: 0x0027F7B8 File Offset: 0x0027D9B8
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

	// Token: 0x0600B0A7 RID: 45223 RVA: 0x0027F804 File Offset: 0x0027DA04
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

	// Token: 0x0600B0A8 RID: 45224 RVA: 0x0027F868 File Offset: 0x0027DA68
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

	// Token: 0x0600B0A9 RID: 45225 RVA: 0x0027F9B8 File Offset: 0x0027DBB8
	private void ClearChatContent()
	{
		foreach (ChatContentBase chatContentBase in this.ChatContentList)
		{
			chatContentBase.Destroy(null);
		}
		this.ChatContentList.Clear();
	}

	// Token: 0x0600B0AA RID: 45226 RVA: 0x0027FA14 File Offset: 0x0027DC14
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

	// Token: 0x0600B0AB RID: 45227 RVA: 0x0027FA40 File Offset: 0x0027DC40
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

	// Token: 0x0600B0AC RID: 45228 RVA: 0x0027FAAC File Offset: 0x0027DCAC
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

	// Token: 0x0600B0AD RID: 45229 RVA: 0x0027FB3C File Offset: 0x0027DD3C
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

	// Token: 0x0600B0AE RID: 45230 RVA: 0x0027FB90 File Offset: 0x0027DD90
	private void RemoveRefreshPlayInfoTimeDown()
	{
		if (!TimerSystem.GameplayTimeInstance.Has(this.RefreshPlayInfoTimerId))
		{
			return;
		}
		TimerSystem.GameplayTimeInstance.Remove(this.RefreshPlayInfoTimerId);
		this.RefreshPlayInfoTimerId = null;
	}

	// Token: 0x0600B0AF RID: 45231 RVA: 0x0027FBC0 File Offset: 0x0027DDC0
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

	// Token: 0x0600B0B0 RID: 45232 RVA: 0x0027FC28 File Offset: 0x0027DE28
	private void ClearScrollToBottomTimers()
	{
		foreach (TimerHandle handle in this.ScrollToBottomTimerIds)
		{
			TimerSystem.GameplayTimeInstance.Remove(handle);
		}
		this.ScrollToBottomTimerIds.Clear();
	}

	// Token: 0x0600B0B1 RID: 45233 RVA: 0x0027FC8C File Offset: 0x0027DE8C
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

	// Token: 0x0600B0B2 RID: 45234 RVA: 0x0027FCD0 File Offset: 0x0027DED0
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

	// Token: 0x0600B0B3 RID: 45235 RVA: 0x0027FD00 File Offset: 0x0027DF00
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

	// Token: 0x0600B0B4 RID: 45236 RVA: 0x0027FD48 File Offset: 0x0027DF48
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

	// Token: 0x0600B0B5 RID: 45237 RVA: 0x0027FD8E File Offset: 0x0027DF8E
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

	// Token: 0x0600B0B6 RID: 45238 RVA: 0x0027FDC2 File Offset: 0x0027DFC2
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

	// Token: 0x0600B0B7 RID: 45239 RVA: 0x0027FDDF File Offset: 0x0027DFDF
	private ChatRoomItem NewPrivateChatFriendItem()
	{
		ChatRoomItem chatRoomItem = new ChatRoomItem();
		chatRoomItem.BindOnClicked(new Action<EChatRoomType, int>(this.OnChatRoomClicked));
		return chatRoomItem;
	}

	// Token: 0x0600B0B8 RID: 45240 RVA: 0x0027FDF8 File Offset: 0x0027DFF8
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

	// Token: 0x0600B0B9 RID: 45241 RVA: 0x0027FE7C File Offset: 0x0027E07C
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

	// Token: 0x0600B0BA RID: 45242 RVA: 0x0027FEC4 File Offset: 0x0027E0C4
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

	// Token: 0x0600B0BB RID: 45243 RVA: 0x0027FF08 File Offset: 0x0027E108
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

	// Token: 0x0600B0BC RID: 45244 RVA: 0x0027FF4C File Offset: 0x0027E14C
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

	// Token: 0x0600B0BD RID: 45245 RVA: 0x0027FFD8 File Offset: 0x0027E1D8
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

	// Token: 0x0600B0BE RID: 45246 RVA: 0x002800DC File Offset: 0x0027E2DC
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

	// Token: 0x0600B0BF RID: 45247 RVA: 0x00280151 File Offset: 0x0027E351
	protected override void OnBeforeShow()
	{
		GameSettingsDeviceRender.Instance.TemporaryDisableFrameGeneration("ChatView");
	}

	// Token: 0x0600B0C0 RID: 45248 RVA: 0x00280162 File Offset: 0x0027E362
	protected override void OnAfterHide()
	{
		GameSettingsDeviceRender.Instance.CancelTemporaryDisableFrameGeneration("ChatView");
	}

	// Token: 0x04005025 RID: 20517
	private List<ChatContentData> ChatContentDataList = new List<ChatContentData>();

	// Token: 0x04005026 RID: 20518
	private readonly List<ChatContentBase> ChatContentList = new List<ChatContentBase>();

	// Token: 0x04005027 RID: 20519
	private bool CanRequestHistory;

	// Token: 0x04005028 RID: 20520
	[Nullable(2)]
	private TimerHandle RefreshPlayInfoTimerId;

	// Token: 0x04005029 RID: 20521
	private readonly HashSet<TimerHandle> ScrollToBottomTimerIds = new HashSet<TimerHandle>();

	// Token: 0x0400502A RID: 20522
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ChatRoomItem, ChatRoom> ChatRoomItemLoopScrollView;

	// Token: 0x0400502B RID: 20523
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<ChatContentItem, ChatContentDynamicItem, IChatContentDynamicData> ChatLoopScrollView;

	// Token: 0x0400502C RID: 20524
	[Nullable(2)]
	private ChatContentDynamicItem ChatBaseItem;

	// Token: 0x0400502D RID: 20525
	private List<ChatRoom> CurrentChatRoomList = new List<ChatRoom>();

	// Token: 0x0400502E RID: 20526
	public int ChatInputMaxNum;

	// Token: 0x0400502F RID: 20527
	private bool HasChat;

	// Token: 0x04005030 RID: 20528
	private bool IsTryScroll;

	// Token: 0x04005031 RID: 20529
	private readonly InputKeyDisplayData InputKeyDisplayDataRef = new InputKeyDisplayData();

	// Token: 0x04005032 RID: 20530
	private bool IsInTouch;

	// Token: 0x02007DBA RID: 32186
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x04029289 RID: 168585
		public const int AddPrivateChatButton = 0;

		// Token: 0x0402928A RID: 168586
		public const int ExpressionButton = 1;

		// Token: 0x0402928B RID: 168587
		public const int ChatInputText = 2;

		// Token: 0x0402928C RID: 168588
		public const int QuickChatButton = 3;

		// Token: 0x0402928D RID: 168589
		public const int SendButton = 4;

		// Token: 0x0402928E RID: 168590
		public const int OnlineState = 5;

		// Token: 0x0402928F RID: 168591
		public const int FriendRemarks = 6;

		// Token: 0x04029290 RID: 168592
		public const int FriendNameText = 7;

		// Token: 0x04029291 RID: 168593
		public const int FriendDetailButton = 8;

		// Token: 0x04029292 RID: 168594
		public const int CloseButton = 9;

		// Token: 0x04029293 RID: 168595
		public const int ChatFriendSourceItem = 10;

		// Token: 0x04029294 RID: 168596
		public const int ChatScrollView = 11;

		// Token: 0x04029295 RID: 168597
		public const int ChatItem = 12;

		// Token: 0x04029296 RID: 168598
		public const int NoneItem = 13;

		// Token: 0x04029297 RID: 168599
		public const int ChatScrollContent = 14;

		// Token: 0x04029298 RID: 168600
		public const int ChatRoomItemLoopScrollView = 15;

		// Token: 0x04029299 RID: 168601
		public const int MastButton = 16;

		// Token: 0x0402929A RID: 168602
		public const int OfflineState = 17;

		// Token: 0x0402929B RID: 168603
		public const int TextInputDefaultText = 18;

		// Token: 0x0402929C RID: 168604
		public const int InputItem = 19;

		// Token: 0x0402929D RID: 168605
		public const int MuteItem = 20;

		// Token: 0x0402929E RID: 168606
		public const int ThirdPartyTexture = 21;

		// Token: 0x0402929F RID: 168607
		public const int ThirdPartyText = 22;

		// Token: 0x040292A0 RID: 168608
		public const int FullBlur = 23;

		// Token: 0x040292A1 RID: 168609
		public const int PartialBlur = 24;

		// Token: 0x040292A2 RID: 168610
		public const int PcItem = 25;

		// Token: 0x040292A3 RID: 168611
		public const int ChatScrollItem = 26;
	}
}
