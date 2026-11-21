using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028E3 RID: 10467
public class RedDotChatRoom : RedDotBase
{
	// Token: 0x0601A743 RID: 108355 RVA: 0x0082C40C File Offset: 0x0082A60C
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

	// Token: 0x0601A744 RID: 108356 RVA: 0x0082C454 File Offset: 0x0082A654
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnRefreshChatRoomRedDot, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.OnRemoveFriend, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A745 RID: 108357 RVA: 0x0082C48E File Offset: 0x0082A68E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnRefreshChatRoomRedDot, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.OnRemoveFriend, new Action<int>(base.EventCheckWithUid));
	}
}
