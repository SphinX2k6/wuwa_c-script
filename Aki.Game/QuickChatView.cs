using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C65 RID: 3173
[NullableContext(1)]
[Nullable(0)]
public class QuickChatView : UiViewBase
{
	// Token: 0x060084C1 RID: 33985 RVA: 0x0028AF13 File Offset: 0x00289113
	public QuickChatView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060084C2 RID: 33986 RVA: 0x0028AF28 File Offset: 0x00289128
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

	// Token: 0x060084C3 RID: 33987 RVA: 0x0028B010 File Offset: 0x00289210
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

	// Token: 0x060084C4 RID: 33988 RVA: 0x0028B05C File Offset: 0x0028925C
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

	// Token: 0x060084C5 RID: 33989 RVA: 0x0028B124 File Offset: 0x00289324
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

	// Token: 0x060084C6 RID: 33990 RVA: 0x0028B1B4 File Offset: 0x002893B4
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

	// Token: 0x060084C7 RID: 33991 RVA: 0x0028B31D File Offset: 0x0028951D
	private void OnClickCloseQuickChatButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x060084C8 RID: 33992 RVA: 0x0028B326 File Offset: 0x00289526
	protected override void OnBeforeDestroy()
	{
		this.DestroyAllQuackChatText();
	}

	// Token: 0x060084C9 RID: 33993 RVA: 0x0028B330 File Offset: 0x00289530
	private void DestroyAllQuackChatText()
	{
		foreach (QuickChatText quickChatText in this.QuickChatTextList)
		{
			quickChatText.Destroy(null);
		}
	}

	// Token: 0x040050E4 RID: 20708
	public int ChatInputMaxNum;

	// Token: 0x040050E5 RID: 20709
	private readonly List<QuickChatText> QuickChatTextList = new List<QuickChatText>();

	// Token: 0x02006F4A RID: 28490
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x040245F4 RID: 148980
		public const int QuickChatPanelItem = 0;

		// Token: 0x040245F5 RID: 148981
		public const int CloseQuickChatButton = 1;

		// Token: 0x040245F6 RID: 148982
		public const int QuickChatContentItem = 2;

		// Token: 0x040245F7 RID: 148983
		public const int SourceQuickChatItem = 3;
	}
}
