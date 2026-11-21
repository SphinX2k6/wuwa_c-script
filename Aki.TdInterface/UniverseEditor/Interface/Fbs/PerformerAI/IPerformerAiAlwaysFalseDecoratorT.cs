using System;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047B7 RID: 18359
	public class IPerformerAiAlwaysFalseDecoratorT
	{
		// Token: 0x17007FDC RID: 32732
		// (get) Token: 0x0601B07A RID: 110714 RVA: 0x003D45E2 File Offset: 0x003D27E2
		// (set) Token: 0x0601B07B RID: 110715 RVA: 0x003D45EA File Offset: 0x003D27EA
		public EPerformerAiDecoratorType Type { get; set; }

		// Token: 0x0601B07C RID: 110716 RVA: 0x003D45F3 File Offset: 0x003D27F3
		public IPerformerAiAlwaysFalseDecoratorT()
		{
			this.Type = EPerformerAiDecoratorType.Condition;
		}
	}
}
