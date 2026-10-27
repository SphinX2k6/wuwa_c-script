using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020022E3 RID: 8931
[NullableContext(2)]
[Nullable(0)]
public class OtherScenePlayerData
{
	// Token: 0x0601195B RID: 72027 RVA: 0x0044F6B2 File Offset: 0x0044D8B2
	public OtherScenePlayerData(int playerId, int mapId, Aki.Protocol.Vector location, int areaId)
	{
		this.PlayerId = playerId;
		this.MapId = mapId;
		this.Location = global::Vector.Create(location);
		this.Area = areaId;
	}

	// Token: 0x0601195C RID: 72028 RVA: 0x0044F6DC File Offset: 0x0044D8DC
	public void SetLocation(global::Vector location)
	{
		global::Vector location2 = this.Location;
		if (location2 == null)
		{
			return;
		}
		location2.Set((location != null) ? location.X : 0.0, (location != null) ? location.Y : 0.0, (location != null) ? location.Z : 0.0);
	}

	// Token: 0x0400857E RID: 34174
	public int PlayerId;

	// Token: 0x0400857F RID: 34175
	public int MapId;

	// Token: 0x04008580 RID: 34176
	public int Area;

	// Token: 0x04008581 RID: 34177
	public global::Vector Location;
}
