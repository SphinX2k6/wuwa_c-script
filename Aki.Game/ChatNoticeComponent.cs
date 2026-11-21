using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x02001094 RID: 4244
[NullableContext(1)]
[Nullable(0)]
public class ChatNoticeComponent
{
	// Token: 0x0600A87F RID: 43135 RVA: 0x0031929E File Offset: 0x0031749E
	public ChatNoticeComponent(UUIItem rootItem, UUIItem infoItem, UUIText infoText)
	{
		this.InfoItem = infoItem;
		this.InfoText = infoText;
		this.SequencePlayer = new LevelSequencePlayer(rootItem);
	}

	// Token: 0x0600A880 RID: 43136 RVA: 0x003192C0 File Offset: 0x003174C0
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

	// Token: 0x0600A881 RID: 43137 RVA: 0x0031949E File Offset: 0x0031769E
	public void Destroy()
	{
		this.SequencePlayer.Clear();
	}

	// Token: 0x040061DE RID: 25054
	private bool IsShown;

	// Token: 0x040061DF RID: 25055
	[Nullable(2)]
	private readonly LevelSequencePlayer SequencePlayer;

	// Token: 0x040061E0 RID: 25056
	private readonly UUIItem InfoItem;

	// Token: 0x040061E1 RID: 25057
	private readonly UUIText InfoText;
}
