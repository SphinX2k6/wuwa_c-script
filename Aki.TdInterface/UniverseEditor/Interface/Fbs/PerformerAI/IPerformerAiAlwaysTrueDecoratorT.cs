using System;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004358 RID: 17240
	public class IPerformerAiAlwaysTrueDecoratorT
	{
		// Token: 0x170079AA RID: 31146
		// (get) Token: 0x060198FE RID: 104702 RVA: 0x003A8D32 File Offset: 0x003A6F32
		// (set) Token: 0x060198FF RID: 104703 RVA: 0x003A8D3A File Offset: 0x003A6F3A
		public EPerformerAiDecoratorType Type { get; set; }

		// Token: 0x06019900 RID: 104704 RVA: 0x003A8D43 File Offset: 0x003A6F43
		public IPerformerAiAlwaysTrueDecoratorT()
		{
			this.Type = EPerformerAiDecoratorType.Condition;
		}
	}
}
