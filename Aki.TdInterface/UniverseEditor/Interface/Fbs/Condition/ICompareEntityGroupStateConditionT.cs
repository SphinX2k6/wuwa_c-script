using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B96 RID: 19350
	public class ICompareEntityGroupStateConditionT
	{
		// Token: 0x17008C6B RID: 35947
		// (get) Token: 0x0601E80C RID: 124940 RVA: 0x00444EFF File Offset: 0x004430FF
		// (set) Token: 0x0601E80D RID: 124941 RVA: 0x00444F07 File Offset: 0x00443107
		public ECondition Type { get; set; }

		// Token: 0x17008C6C RID: 35948
		// (get) Token: 0x0601E80E RID: 124942 RVA: 0x00444F10 File Offset: 0x00443110
		// (set) Token: 0x0601E80F RID: 124943 RVA: 0x00444F18 File Offset: 0x00443118
		public IEntityGroupConditionT GroupCondition { get; set; }

		// Token: 0x0601E810 RID: 124944 RVA: 0x00444F21 File Offset: 0x00443121
		public ICompareEntityGroupStateConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.GroupCondition = null;
		}
	}
}
