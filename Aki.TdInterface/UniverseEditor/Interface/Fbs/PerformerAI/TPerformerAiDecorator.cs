using System;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004381 RID: 17281
	public enum TPerformerAiDecorator : byte
	{
		// Token: 0x0400C19F RID: 49567
		NONE,
		// Token: 0x0400C1A0 RID: 49568
		IPerformerAiAlwaysFalseDecorator,
		// Token: 0x0400C1A1 RID: 49569
		IPerformerAiAlwaysTrueDecorator,
		// Token: 0x0400C1A2 RID: 49570
		IPerformerAiConditionDecorator,
		// Token: 0x0400C1A3 RID: 49571
		IPerformerAiCoolDownDecorator,
		// Token: 0x0400C1A4 RID: 49572
		IPerformerAiDoOnceDecorator
	}
}
