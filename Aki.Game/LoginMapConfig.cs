using System;
using System.Runtime.CompilerServices;

// Token: 0x0200156C RID: 5484
[NullableContext(1)]
[Nullable(0)]
public class LoginMapConfig
{
	// Token: 0x0600DB65 RID: 56165 RVA: 0x004103DD File Offset: 0x0040E5DD
	public LoginMapConfig(int mapId, string mapName)
	{
		this.MapId = mapId;
		this.MapName = mapName;
	}

	// Token: 0x04007A65 RID: 31333
	public int MapId;

	// Token: 0x04007A66 RID: 31334
	public string MapName = string.Empty;
}
