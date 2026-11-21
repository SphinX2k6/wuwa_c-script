using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EBE RID: 20158
	public class ICheckEntityDistanceConditionT
	{
		// Token: 0x17008FD9 RID: 36825
		// (get) Token: 0x0601F439 RID: 128057 RVA: 0x0045BA21 File Offset: 0x00459C21
		// (set) Token: 0x0601F43A RID: 128058 RVA: 0x0045BA29 File Offset: 0x00459C29
		public ECondition Type { get; set; }

		// Token: 0x17008FDA RID: 36826
		// (get) Token: 0x0601F43B RID: 128059 RVA: 0x0045BA32 File Offset: 0x00459C32
		// (set) Token: 0x0601F43C RID: 128060 RVA: 0x0045BA3A File Offset: 0x00459C3A
		public TTargetEntityUnion TargetA { get; set; }

		// Token: 0x17008FDB RID: 36827
		// (get) Token: 0x0601F43D RID: 128061 RVA: 0x0045BA43 File Offset: 0x00459C43
		// (set) Token: 0x0601F43E RID: 128062 RVA: 0x0045BA4B File Offset: 0x00459C4B
		public TTargetEntityUnion TargetB { get; set; }

		// Token: 0x17008FDC RID: 36828
		// (get) Token: 0x0601F43F RID: 128063 RVA: 0x0045BA54 File Offset: 0x00459C54
		// (set) Token: 0x0601F440 RID: 128064 RVA: 0x0045BA5C File Offset: 0x00459C5C
		public ECompare Compare { get; set; }

		// Token: 0x17008FDD RID: 36829
		// (get) Token: 0x0601F441 RID: 128065 RVA: 0x0045BA65 File Offset: 0x00459C65
		// (set) Token: 0x0601F442 RID: 128066 RVA: 0x0045BA6D File Offset: 0x00459C6D
		public int Distance { get; set; }

		// Token: 0x0601F443 RID: 128067 RVA: 0x0045BA76 File Offset: 0x00459C76
		public ICheckEntityDistanceConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.TargetA = null;
			this.TargetB = null;
			this.Compare = ECompare.Eq;
			this.Distance = 0;
		}
	}
}
