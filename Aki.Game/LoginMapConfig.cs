using System;
using System.Runtime.CompilerServices;

// Token: 0x02002096 RID: 8342
[NullableContext(1)]
[Nullable(0)]
public class LoginMapConfig
{
	// Token: 0x060106F8 RID: 67320 RVA: 0x00403E29 File Offset: 0x00402029
	public LoginMapConfig(int mapId, string mapName)
	{
		this.MapId = mapId;
		this.MapName = mapName;
	}

	// Token: 0x0400796C RID: 31084
	public int MapId;

	// Token: 0x0400796D RID: 31085
	public string MapName = string.Empty;
}
