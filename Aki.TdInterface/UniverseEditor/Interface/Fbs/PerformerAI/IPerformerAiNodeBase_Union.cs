using System;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047D1 RID: 18385
	public enum IPerformerAiNodeBase_Union : byte
	{
		// Token: 0x0400CB8A RID: 52106
		NONE,
		// Token: 0x0400CB8B RID: 52107
		IPerformerAiNodeBase,
		// Token: 0x0400CB8C RID: 52108
		IPerformerAiStart,
		// Token: 0x0400CB8D RID: 52109
		IPerformerAiSequence,
		// Token: 0x0400CB8E RID: 52110
		IPerformerAiSelector,
		// Token: 0x0400CB8F RID: 52111
		IPerformerAiTask,
		// Token: 0x0400CB90 RID: 52112
		IPerformerAiProbability
	}
}
