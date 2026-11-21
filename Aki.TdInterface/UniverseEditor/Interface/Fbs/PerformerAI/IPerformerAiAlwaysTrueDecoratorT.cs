using System;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047BA RID: 18362
	public class IPerformerAiAlwaysTrueDecoratorT
	{
		// Token: 0x17007FDF RID: 32735
		// (get) Token: 0x0601B08C RID: 110732 RVA: 0x003D475A File Offset: 0x003D295A
		// (set) Token: 0x0601B08D RID: 110733 RVA: 0x003D4762 File Offset: 0x003D2962
		public EPerformerAiDecoratorType Type { get; set; }

		// Token: 0x0601B08E RID: 110734 RVA: 0x003D476B File Offset: 0x003D296B
		public IPerformerAiAlwaysTrueDecoratorT()
		{
			this.Type = EPerformerAiDecoratorType.Condition;
		}
	}
}
