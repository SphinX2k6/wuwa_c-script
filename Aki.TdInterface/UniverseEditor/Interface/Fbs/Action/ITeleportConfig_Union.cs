using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007379 RID: 29561
	public enum ITeleportConfig_Union : byte
	{
		// Token: 0x04012188 RID: 74120
		NONE,
		// Token: 0x04012189 RID: 74121
		ITeleportConfig,
		// Token: 0x0401218A RID: 74122
		IFixedPos,
		// Token: 0x0401218B RID: 74123
		INearestEntity,
		// Token: 0x0401218C RID: 74124
		IGravityFlipFixedPos,
		// Token: 0x0401218D RID: 74125
		ISafePos
	}
}
