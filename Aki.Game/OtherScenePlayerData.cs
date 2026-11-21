using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020017C7 RID: 6087
[NullableContext(2)]
[Nullable(0)]
public class OtherScenePlayerData
{
	// Token: 0x0600EDF3 RID: 60915 RVA: 0x0045C37E File Offset: 0x0045A57E
	public OtherScenePlayerData(int playerId, int mapId, Aki.Protocol.Vector location, int areaId)
	{
		this.PlayerId = playerId;
		this.MapId = mapId;
		this.Location = global::Vector.Create(location);
		this.Area = areaId;
	}

	// Token: 0x0600EDF4 RID: 60916 RVA: 0x0045C3A8 File Offset: 0x0045A5A8
	public void SetLocation(global::Vector location)
	{
		global::Vector location2 = this.Location;
		if (location2 == null)
		{
			return;
		}
		location2.Set((location != null) ? location.X : 0.0, (location != null) ? location.Y : 0.0, (location != null) ? location.Z : 0.0);
	}

	// Token: 0x040086BC RID: 34492
	public int PlayerId;

	// Token: 0x040086BD RID: 34493
	public int MapId;

	// Token: 0x040086BE RID: 34494
	public int Area;

	// Token: 0x040086BF RID: 34495
	public global::Vector Location;
}
