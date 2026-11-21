using System;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047CC RID: 18380
	public class IPerformerAiDoOnceDecoratorT
	{
		// Token: 0x17007FFE RID: 32766
		// (get) Token: 0x0601B11E RID: 110878 RVA: 0x003D56D2 File Offset: 0x003D38D2
		// (set) Token: 0x0601B11F RID: 110879 RVA: 0x003D56DA File Offset: 0x003D38DA
		public EPerformerAiDecoratorType Type { get; set; }

		// Token: 0x0601B120 RID: 110880 RVA: 0x003D56E3 File Offset: 0x003D38E3
		public IPerformerAiDoOnceDecoratorT()
		{
			this.Type = EPerformerAiDecoratorType.Condition;
		}
	}
}
