using System;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047E3 RID: 18403
	public enum TPerformerAiDecorator : byte
	{
		// Token: 0x0400CBBD RID: 52157
		NONE,
		// Token: 0x0400CBBE RID: 52158
		IPerformerAiAlwaysFalseDecorator,
		// Token: 0x0400CBBF RID: 52159
		IPerformerAiAlwaysTrueDecorator,
		// Token: 0x0400CBC0 RID: 52160
		IPerformerAiConditionDecorator,
		// Token: 0x0400CBC1 RID: 52161
		IPerformerAiCoolDownDecorator,
		// Token: 0x0400CBC2 RID: 52162
		IPerformerAiDoOnceDecorator
	}
}
