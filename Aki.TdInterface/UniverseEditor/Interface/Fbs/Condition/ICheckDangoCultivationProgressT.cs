using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049B9 RID: 18873
	public class ICheckDangoCultivationProgressT
	{
		// Token: 0x1700887B RID: 34939
		// (get) Token: 0x0601D778 RID: 120696 RVA: 0x00426B57 File Offset: 0x00424D57
		// (set) Token: 0x0601D779 RID: 120697 RVA: 0x00426B5F File Offset: 0x00424D5F
		public ECondition Type { get; set; }

		// Token: 0x1700887C RID: 34940
		// (get) Token: 0x0601D77A RID: 120698 RVA: 0x00426B68 File Offset: 0x00424D68
		// (set) Token: 0x0601D77B RID: 120699 RVA: 0x00426B70 File Offset: 0x00424D70
		public ICountDangoOverTargetLevelT CheckType { get; set; }

		// Token: 0x0601D77C RID: 120700 RVA: 0x00426B79 File Offset: 0x00424D79
		public ICheckDangoCultivationProgressT()
		{
			this.Type = ECondition.CompareVar;
			this.CheckType = null;
		}
	}
}
