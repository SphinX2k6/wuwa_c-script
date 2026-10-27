using System;
using System.Runtime.CompilerServices;

// Token: 0x02003527 RID: 13607
public class PreloadSkillSaveData : PreloadSaveData
{
	// Token: 0x0400EAB9 RID: 60089
	public int SkillId;

	// Token: 0x0400EABA RID: 60090
	[Nullable(1)]
	public string ActorBlueprint = "";

	// Token: 0x0400EABB RID: 60091
	public int LoadType;

	// Token: 0x0400EABC RID: 60092
	public bool IsCommon;

	// Token: 0x0400EABD RID: 60093
	public bool HasMontagePath;
}
