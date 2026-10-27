using System;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004355 RID: 17237
	public class IPerformerAiAlwaysFalseDecoratorT
	{
		// Token: 0x170079A7 RID: 31143
		// (get) Token: 0x060198EC RID: 104684 RVA: 0x003A8BBA File Offset: 0x003A6DBA
		// (set) Token: 0x060198ED RID: 104685 RVA: 0x003A8BC2 File Offset: 0x003A6DC2
		public EPerformerAiDecoratorType Type { get; set; }

		// Token: 0x060198EE RID: 104686 RVA: 0x003A8BCB File Offset: 0x003A6DCB
		public IPerformerAiAlwaysFalseDecoratorT()
		{
			this.Type = EPerformerAiDecoratorType.Condition;
		}
	}
}
