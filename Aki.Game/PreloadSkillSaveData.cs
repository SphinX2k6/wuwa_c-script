using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A9C RID: 10908
public class PreloadSkillSaveData : PreloadSaveData
{
	// Token: 0x0400EF76 RID: 61302
	public int SkillId;

	// Token: 0x0400EF77 RID: 61303
	[Nullable(1)]
	public string ActorBlueprint = "";

	// Token: 0x0400EF78 RID: 61304
	public int LoadType;

	// Token: 0x0400EF79 RID: 61305
	public bool IsCommon;

	// Token: 0x0400EF7A RID: 61306
	public bool HasMontagePath;
}
