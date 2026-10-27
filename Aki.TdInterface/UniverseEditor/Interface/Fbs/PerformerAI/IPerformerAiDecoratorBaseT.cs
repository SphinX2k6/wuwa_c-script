using System;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004364 RID: 17252
	public class IPerformerAiDecoratorBaseT
	{
		// Token: 0x170079C4 RID: 31172
		// (get) Token: 0x0601996A RID: 104810 RVA: 0x003A9922 File Offset: 0x003A7B22
		// (set) Token: 0x0601996B RID: 104811 RVA: 0x003A992A File Offset: 0x003A7B2A
		public EPerformerAiDecoratorType Type { get; set; }

		// Token: 0x0601996C RID: 104812 RVA: 0x003A9933 File Offset: 0x003A7B33
		public IPerformerAiDecoratorBaseT()
		{
			this.Type = EPerformerAiDecoratorType.Condition;
		}
	}
}
