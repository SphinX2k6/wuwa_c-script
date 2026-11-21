using System;

// Token: 0x02000C68 RID: 3176
public class WorldChatRoom : TeamChatRoomBase
{
	// Token: 0x060084DE RID: 34014 RVA: 0x0028B9DA File Offset: 0x00289BDA
	public WorldChatRoom(int configId) : base(EChatRoomType.World, configId)
	{
	}

	// Token: 0x060084DF RID: 34015 RVA: 0x0028B9E4 File Offset: 0x00289BE4
	public override int GetUniqueId()
	{
		return 3;
	}
}
