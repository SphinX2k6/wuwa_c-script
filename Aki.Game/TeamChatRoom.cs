using System;

// Token: 0x02000C54 RID: 3156
public class TeamChatRoom : TeamChatRoomBase
{
	// Token: 0x0600840E RID: 33806 RVA: 0x002866B4 File Offset: 0x002848B4
	public TeamChatRoom(int configId) : base(EChatRoomType.Team, configId)
	{
	}

	// Token: 0x0600840F RID: 33807 RVA: 0x002866BE File Offset: 0x002848BE
	public override int GetUniqueId()
	{
		return 2;
	}
}
