using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C7E RID: 27774
	public enum IPerformerAiMoveConfig_Union : byte
	{
		// Token: 0x040115CE RID: 71118
		NONE,
		// Token: 0x040115CF RID: 71119
		IPerformerAiMoveConfig,
		// Token: 0x040115D0 RID: 71120
		IPerformerAiMoveToPosition,
		// Token: 0x040115D1 RID: 71121
		IPerformerAiMoveToEntity,
		// Token: 0x040115D2 RID: 71122
		IPerformerAiMoveToPlayer
	}
}
