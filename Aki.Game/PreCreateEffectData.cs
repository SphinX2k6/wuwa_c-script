using System;
using System.Runtime.CompilerServices;

// Token: 0x0200026E RID: 622
[NullableContext(1)]
[Nullable(0)]
public class PreCreateEffectData
{
	// Token: 0x06002672 RID: 9842 RVA: 0x000E8D61 File Offset: 0x000E6F61
	public PreCreateEffectData(int entityId, string path)
	{
		this.EntityId = entityId;
		this.Path = path;
	}

	// Token: 0x040024DE RID: 9438
	public int EntityId;

	// Token: 0x040024DF RID: 9439
	public string Path;
}
