using System;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047C6 RID: 18374
	public class IPerformerAiDecoratorBaseT
	{
		// Token: 0x17007FF9 RID: 32761
		// (get) Token: 0x0601B0F8 RID: 110840 RVA: 0x003D534A File Offset: 0x003D354A
		// (set) Token: 0x0601B0F9 RID: 110841 RVA: 0x003D5352 File Offset: 0x003D3552
		public EPerformerAiDecoratorType Type { get; set; }

		// Token: 0x0601B0FA RID: 110842 RVA: 0x003D535B File Offset: 0x003D355B
		public IPerformerAiDecoratorBaseT()
		{
			this.Type = EPerformerAiDecoratorType.Condition;
		}
	}
}
