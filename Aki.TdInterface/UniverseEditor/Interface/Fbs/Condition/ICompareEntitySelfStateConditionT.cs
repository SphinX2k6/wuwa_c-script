using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005083 RID: 20611
	public class ICompareEntitySelfStateConditionT
	{
		// Token: 0x1700938A RID: 37770
		// (get) Token: 0x060203D2 RID: 132050 RVA: 0x00477D19 File Offset: 0x00475F19
		// (set) Token: 0x060203D3 RID: 132051 RVA: 0x00477D21 File Offset: 0x00475F21
		public ECondition Type { get; set; }

		// Token: 0x1700938B RID: 37771
		// (get) Token: 0x060203D4 RID: 132052 RVA: 0x00477D2A File Offset: 0x00475F2A
		// (set) Token: 0x060203D5 RID: 132053 RVA: 0x00477D32 File Offset: 0x00475F32
		public string State { get; set; }

		// Token: 0x1700938C RID: 37772
		// (get) Token: 0x060203D6 RID: 132054 RVA: 0x00477D3B File Offset: 0x00475F3B
		// (set) Token: 0x060203D7 RID: 132055 RVA: 0x00477D43 File Offset: 0x00475F43
		public ECompare Compare { get; set; }

		// Token: 0x060203D8 RID: 132056 RVA: 0x00477D4C File Offset: 0x00475F4C
		public ICompareEntitySelfStateConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.State = null;
			this.Compare = ECompare.Eq;
		}
	}
}
