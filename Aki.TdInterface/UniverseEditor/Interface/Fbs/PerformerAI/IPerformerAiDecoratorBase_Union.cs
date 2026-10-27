using System;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004366 RID: 17254
	public enum IPerformerAiDecoratorBase_Union : byte
	{
		// Token: 0x0400C159 RID: 49497
		NONE,
		// Token: 0x0400C15A RID: 49498
		IPerformerAiDecoratorBase,
		// Token: 0x0400C15B RID: 49499
		IPerformerAiConditionDecorator,
		// Token: 0x0400C15C RID: 49500
		IPerformerAiAlwaysFalseDecorator,
		// Token: 0x0400C15D RID: 49501
		IPerformerAiAlwaysTrueDecorator,
		// Token: 0x0400C15E RID: 49502
		IPerformerAiDoOnceDecorator,
		// Token: 0x0400C15F RID: 49503
		IPerformerAiCoolDownDecorator
	}
}
