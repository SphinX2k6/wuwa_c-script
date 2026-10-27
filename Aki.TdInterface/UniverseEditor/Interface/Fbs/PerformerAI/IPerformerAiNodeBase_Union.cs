using System;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x0200436F RID: 17263
	public enum IPerformerAiNodeBase_Union : byte
	{
		// Token: 0x0400C16C RID: 49516
		NONE,
		// Token: 0x0400C16D RID: 49517
		IPerformerAiNodeBase,
		// Token: 0x0400C16E RID: 49518
		IPerformerAiStart,
		// Token: 0x0400C16F RID: 49519
		IPerformerAiSequence,
		// Token: 0x0400C170 RID: 49520
		IPerformerAiSelector,
		// Token: 0x0400C171 RID: 49521
		IPerformerAiTask,
		// Token: 0x0400C172 RID: 49522
		IPerformerAiProbability
	}
}
