using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017AC RID: 6060
[NullableContext(1)]
[Nullable(0)]
public class QuickChatView : UiViewBase
{
	// Token: 0x0600B0D9 RID: 45273 RVA: 0x0028097B File Offset: 0x0027EB7B
	public QuickChatView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B0DA RID: 45274 RVA: 0x00280990 File Offset: 0x0027EB90
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickCloseQuickChatButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B0DB RID: 45275 RVA: 0x00280A78 File Offset: 0x0027EC78
	protected override void OnStart()
	{
		this.ChatInputMaxNum = ConfigCommonParamById.GetIntConfig("chat_character").Value;
		UUIButtonComponent button = base.GetButton(1);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(true);
		}
		this.CreateAllQuackChatText();
	}

	// Token: 0x0600B0DC RID: 45276 RVA: 0x00280AC4 File Offset: 0x0027ECC4
	private void CreateAllQuackChatText()
	{
		IReadOnlyList<QuickChat> allQuickChatConfigList = ChatConfig.Instance.GetAllQuickChatConfigList();
		if (allQuickChatConfigList == null)
		{
			return;
		}
		UUIItem item = base.GetItem(3);
		UUIItem item2 = base.GetItem(2);
		AActor owner = item.GetOwner();
		foreach (QuickChat quickChat in allQuickChatConfigList)
		{
			QuickChatText quickChatText = new QuickChatText(LguiUtil.Instance.DuplicateActor(owner, item2));
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(quickChat.QuickChatContent, null);
			quickChatText.Refresh(localTextNew);
			quickChatText.BindOnClicked(new Action<string>(this.OnQuickChatTextClicked));
			quickChatText.SetActive(true);
			this.QuickChatTextList.Add(quickChatText);
		}
		item.SetUIActive(false);
	}

	// Token: 0x0600B0DD RID: 45277 RVA: 0x00280B8C File Offset: 0x0027ED8C
	private void OnQuickChatTextClicked(string quickChatString)
	{
		ChatRoom joinedChatRoom = ChatModel.Instance.GetJoinedChatRoom();
		if (joinedChatRoom == null)
		{
			Log.Instance.Warn(ELogModule.Chat, ELogAuthor.LJQ, "当前没有加入任何一个聊天室", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		PrivateChatRoom privateChatRoom = joinedChatRoom as PrivateChatRoom;
		if (privateChatRoom != null)
		{
			int targetPlayerId = privateChatRoom.GetTargetPlayerId();
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
		this.PrivateChatRequest(quickChatString, ChatContentType.Text);
		base.CloseMe(null);
	}

	// Token: 0x0600B0DE RID: 45278 RVA: 0x00280C1C File Offset: 0x0027EE1C
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
		PrivateChatRoom privateChatRoom = joinedChatRoom as PrivateChatRoom;
		if (privateChatRoom != null)
		{
			int targetPlayerId = privateChatRoom.GetTargetPlayerId();
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
			return;
		}
		else
		{
			if (joinedChatRoom is TeamChatRoom)
			{
				ChatController.Instance.ChannelChatRequest(chatContentType, text, SubChatChannelType.MatchTeam);
				return;
			}
			if (joinedChatRoom is WorldChatRoom)
			{
				ChatController.Instance.ChannelChatRequest(chatContentType, text, SubChatChannelType.WorldTeam);
			}
			return;
		}
	}

	// Token: 0x0600B0DF RID: 45279 RVA: 0x00280D85 File Offset: 0x0027EF85
	private void OnClickCloseQuickChatButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600B0E0 RID: 45280 RVA: 0x00280D8E File Offset: 0x0027EF8E
	protected override void OnBeforeDestroy()
	{
		this.DestroyAllQuackChatText();
	}

	// Token: 0x0600B0E1 RID: 45281 RVA: 0x00280D98 File Offset: 0x0027EF98
	private void DestroyAllQuackChatText()
	{
		foreach (QuickChatText quickChatText in this.QuickChatTextList)
		{
			quickChatText.Destroy(null);
		}
	}

	// Token: 0x0400503A RID: 20538
	public int ChatInputMaxNum;

	// Token: 0x0400503B RID: 20539
	private readonly List<QuickChatText> QuickChatTextList = new List<QuickChatText>();

	// Token: 0x02007DC4 RID: 32196
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x040292C9 RID: 168649
		public const int QuickChatPanelItem = 0;

		// Token: 0x040292CA RID: 168650
		public const int CloseQuickChatButton = 1;

		// Token: 0x040292CB RID: 168651
		public const int QuickChatContentItem = 2;

		// Token: 0x040292CC RID: 168652
		public const int SourceQuickChatItem = 3;
	}
}
