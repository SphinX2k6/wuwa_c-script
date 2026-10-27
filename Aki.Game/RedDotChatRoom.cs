using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003371 RID: 13169
public class RedDotChatRoom : RedDotBase
{
	// Token: 0x0601CA4B RID: 117323 RVA: 0x00805E48 File Offset: 0x00804048
	protected override bool OnCheck(int uId = 0)
	{
		ChatRoom chatRoom;
		if (uId == 2)
		{
			chatRoom = ChatModel.Instance.GetTeamChatRoom();
		}
		else if (uId == 3)
		{
			chatRoom = ChatModel.Instance.GetWorldChatRoom();
		}
		else
		{
			chatRoom = ChatModel.Instance.GetPrivateChatRoom(uId);
		}
		return chatRoom != null && chatRoom.GetIsShowRedDot();
	}

	// Token: 0x0601CA4C RID: 117324 RVA: 0x00805E90 File Offset: 0x00804090
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnRefreshChatRoomRedDot, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.OnRemoveFriend, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CA4D RID: 117325 RVA: 0x00805ECA File Offset: 0x008040CA
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnRefreshChatRoomRedDot, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.OnRemoveFriend, new Action<int>(base.EventCheckWithUid));
	}
}
