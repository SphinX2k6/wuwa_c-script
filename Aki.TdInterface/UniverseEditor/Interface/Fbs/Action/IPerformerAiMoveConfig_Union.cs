using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073E5 RID: 29669
	public enum IPerformerAiMoveConfig_Union : byte
	{
		// Token: 0x04012526 RID: 75046
		NONE,
		// Token: 0x04012527 RID: 75047
		IPerformerAiMoveConfig,
		// Token: 0x04012528 RID: 75048
		IPerformerAiMoveToPosition,
		// Token: 0x04012529 RID: 75049
		IPerformerAiMoveToEntity,
		// Token: 0x0401252A RID: 75050
		IPerformerAiMoveToPlayer
	}
}
