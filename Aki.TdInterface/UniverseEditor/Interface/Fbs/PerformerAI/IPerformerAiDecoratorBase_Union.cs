using System;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047C8 RID: 18376
	public enum IPerformerAiDecoratorBase_Union : byte
	{
		// Token: 0x0400CB77 RID: 52087
		NONE,
		// Token: 0x0400CB78 RID: 52088
		IPerformerAiDecoratorBase,
		// Token: 0x0400CB79 RID: 52089
		IPerformerAiConditionDecorator,
		// Token: 0x0400CB7A RID: 52090
		IPerformerAiAlwaysFalseDecorator,
		// Token: 0x0400CB7B RID: 52091
		IPerformerAiAlwaysTrueDecorator,
		// Token: 0x0400CB7C RID: 52092
		IPerformerAiDoOnceDecorator,
		// Token: 0x0400CB7D RID: 52093
		IPerformerAiCoolDownDecorator
	}
}
