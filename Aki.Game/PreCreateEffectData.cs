using System;
using System.Runtime.CompilerServices;

// Token: 0x0200026A RID: 618
[NullableContext(1)]
[Nullable(0)]
public class PreCreateEffectData
{
	// Token: 0x060025B8 RID: 9656 RVA: 0x000E277A File Offset: 0x000E097A
	public PreCreateEffectData(int entityId, string path)
	{
		this.EntityId = entityId;
		this.Path = path;
	}

	// Token: 0x0400245D RID: 9309
	public int EntityId;

	// Token: 0x0400245E RID: 9310
	public string Path;
}
