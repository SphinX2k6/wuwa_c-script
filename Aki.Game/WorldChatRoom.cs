using System;

// Token: 0x020017AF RID: 6063
public class WorldChatRoom : TeamChatRoomBase
{
	// Token: 0x0600B0F6 RID: 45302 RVA: 0x00281442 File Offset: 0x0027F642
	public WorldChatRoom(int configId) : base(EChatRoomType.World, configId)
	{
	}

	// Token: 0x0600B0F7 RID: 45303 RVA: 0x0028144C File Offset: 0x0027F64C
	public override int GetUniqueId()
	{
		return 3;
	}
}
