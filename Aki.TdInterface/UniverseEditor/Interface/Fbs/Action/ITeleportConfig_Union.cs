using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B60 RID: 31584
	public enum ITeleportConfig_Union : byte
	{
		// Token: 0x040131A1 RID: 78241
		NONE,
		// Token: 0x040131A2 RID: 78242
		ITeleportConfig,
		// Token: 0x040131A3 RID: 78243
		IFixedPos,
		// Token: 0x040131A4 RID: 78244
		INearestEntity,
		// Token: 0x040131A5 RID: 78245
		IGravityFlipFixedPos,
		// Token: 0x040131A6 RID: 78246
		ISafePos
	}
}
