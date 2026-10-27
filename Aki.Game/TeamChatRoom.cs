using System;

// Token: 0x0200179B RID: 6043
public class TeamChatRoom : TeamChatRoomBase
{
	// Token: 0x0600B026 RID: 45094 RVA: 0x0027C198 File Offset: 0x0027A398
	public TeamChatRoom(int configId) : base(EChatRoomType.Team, configId)
	{
	}

	// Token: 0x0600B027 RID: 45095 RVA: 0x0027C1A2 File Offset: 0x0027A3A2
	public override int GetUniqueId()
	{
		return 2;
	}
}
