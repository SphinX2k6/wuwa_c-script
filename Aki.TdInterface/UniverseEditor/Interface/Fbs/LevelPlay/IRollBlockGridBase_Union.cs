using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049C8 RID: 18888
	public enum IRollBlockGridBase_Union : byte
	{
		// Token: 0x0400D022 RID: 53282
		NONE,
		// Token: 0x0400D023 RID: 53283
		IRollBlockGridBase,
		// Token: 0x0400D024 RID: 53284
		IRollBlockGridEmpty,
		// Token: 0x0400D025 RID: 53285
		IRollBlockGridFloor,
		// Token: 0x0400D026 RID: 53286
		IRollBlockGridGoal,
		// Token: 0x0400D027 RID: 53287
		IRollBlockGridLinkGoal,
		// Token: 0x0400D028 RID: 53288
		IRollBlockGridJumpFloor,
		// Token: 0x0400D029 RID: 53289
		IRollBlockGridFallFloor,
		// Token: 0x0400D02A RID: 53290
		IRollBlockGridBreakTrigger,
		// Token: 0x0400D02B RID: 53291
		IRollBlockGridQuantum,
		// Token: 0x0400D02C RID: 53292
		IRollBlockGridLaser
	}
}
