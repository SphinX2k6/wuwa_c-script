using System;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x0200436A RID: 17258
	public class IPerformerAiDoOnceDecoratorT
	{
		// Token: 0x170079C9 RID: 31177
		// (get) Token: 0x06019990 RID: 104848 RVA: 0x003A9CAA File Offset: 0x003A7EAA
		// (set) Token: 0x06019991 RID: 104849 RVA: 0x003A9CB2 File Offset: 0x003A7EB2
		public EPerformerAiDecoratorType Type { get; set; }

		// Token: 0x06019992 RID: 104850 RVA: 0x003A9CBB File Offset: 0x003A7EBB
		public IPerformerAiDoOnceDecoratorT()
		{
			this.Type = EPerformerAiDecoratorType.Condition;
		}
	}
}
