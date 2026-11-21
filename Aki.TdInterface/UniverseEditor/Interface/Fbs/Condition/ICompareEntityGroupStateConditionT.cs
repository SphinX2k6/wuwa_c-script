using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005080 RID: 20608
	public class ICompareEntityGroupStateConditionT
	{
		// Token: 0x17009384 RID: 37764
		// (get) Token: 0x060203B8 RID: 132024 RVA: 0x00477A63 File Offset: 0x00475C63
		// (set) Token: 0x060203B9 RID: 132025 RVA: 0x00477A6B File Offset: 0x00475C6B
		public ECondition Type { get; set; }

		// Token: 0x17009385 RID: 37765
		// (get) Token: 0x060203BA RID: 132026 RVA: 0x00477A74 File Offset: 0x00475C74
		// (set) Token: 0x060203BB RID: 132027 RVA: 0x00477A7C File Offset: 0x00475C7C
		public IEntityGroupConditionT GroupCondition { get; set; }

		// Token: 0x060203BC RID: 132028 RVA: 0x00477A85 File Offset: 0x00475C85
		public ICompareEntityGroupStateConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.GroupCondition = null;
		}
	}
}
