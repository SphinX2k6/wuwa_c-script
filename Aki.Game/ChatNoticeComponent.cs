using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x02001BD5 RID: 7125
[NullableContext(1)]
[Nullable(0)]
public class ChatNoticeComponent
{
	// Token: 0x0600D46D RID: 54381 RVA: 0x0030E12A File Offset: 0x0030C32A
	public ChatNoticeComponent(UUIItem rootItem, UUIItem infoItem, UUIText infoText)
	{
		this.InfoItem = infoItem;
		this.InfoText = infoText;
		this.SequencePlayer = new LevelSequencePlayer(rootItem);
	}

	// Token: 0x0600D46E RID: 54382 RVA: 0x0030E14C File Offset: 0x0030C34C
	public void HandlePushChatRowData(ChatRowData chatRowData)
	{
		int value = chatRowData.TargetPlayerId.Value;
		if (FriendModel.Instance.HasBlockedPlayer(value))
		{
			return;
		}
		if (!chatRowData.IsVisible)
		{
			return;
		}
		bool flag = chatRowData.ContentChatRoomType == EChatRoomType.Private;
		string text = chatRowData.SenderPlayerName;
		if (flag)
		{
			FriendData friendById = FriendModel.Instance.GetFriendById(value);
			if (friendById != null)
			{
				text = friendById.PlayerName;
			}
		}
		if (!this.IsShown)
		{
			this.InfoItem.SetUIActive(true);
			this.SequencePlayer.PlayLevelSequenceByName("NoticeIn", false, null, false);
			this.IsShown = true;
		}
		this.SequencePlayer.PlayLevelSequenceByName("NewMassageIn", false, null, false);
		UUIText infoText = this.InfoText;
		int? id = PlayerInfoModel.Instance.GetId();
		int senderPlayerId = chatRowData.SenderPlayerId;
		bool flag2 = id.GetValueOrDefault() == senderPlayerId & id != null;
		string textStringId = null;
		string text2 = chatRowData.Content;
		if (chatRowData.ContentType == ChatContentType.Text)
		{
			if (flag)
			{
				textStringId = (flag2 ? "Text_TalkToFriend_Text" : "Text_FriendTalkToMe_Text");
			}
			else
			{
				textStringId = "Text_TeamTalk_Text";
			}
		}
		else if (chatRowData.ContentType == ChatContentType.Emoji)
		{
			int num = int.Parse(chatRowData.Content);
			ChatExpression? expressionConfig = ChatConfig.Instance.GetExpressionConfig(num);
			if (expressionConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Formation;
				ELogAuthor author = ELogAuthor.SYB;
				string message = "[ChatNoticeComponent] 表情缺少配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("表情Id", num);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(infoText, expressionConfig.Value.Name, Array.Empty<object>());
			text2 = infoText.GetText();
			if (flag)
			{
				textStringId = (flag2 ? "Text_TalkToFriend_Text_Match" : "Text_FriendTalkToMe_Text_Match");
			}
			else
			{
				textStringId = "Text_TeamTalk_Text_Match";
			}
		}
		LguiUtil.Instance.SetLocalTextNew(infoText, textStringId, new <>z__ReadOnlyArray<object>(new object[]
		{
			text,
			text2
		}));
	}

	// Token: 0x0600D46F RID: 54383 RVA: 0x0030E32A File Offset: 0x0030C52A
	public void Destroy()
	{
		this.SequencePlayer.Clear();
	}

	// Token: 0x0400610F RID: 24847
	private bool IsShown;

	// Token: 0x04006110 RID: 24848
	[Nullable(2)]
	private readonly LevelSequencePlayer SequencePlayer;

	// Token: 0x04006111 RID: 24849
	private readonly UUIItem InfoItem;

	// Token: 0x04006112 RID: 24850
	private readonly UUIText InfoText;
}
