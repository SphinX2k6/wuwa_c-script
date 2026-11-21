using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EF4 RID: 20212
	public class ICheckFormationRoleInfoConditionT
	{
		// Token: 0x17009053 RID: 36947
		// (get) Token: 0x0601F62D RID: 128557 RVA: 0x0045F443 File Offset: 0x0045D643
		// (set) Token: 0x0601F62E RID: 128558 RVA: 0x0045F44B File Offset: 0x0045D64B
		public ECondition Type { get; set; }

		// Token: 0x17009054 RID: 36948
		// (get) Token: 0x0601F62F RID: 128559 RVA: 0x0045F454 File Offset: 0x0045D654
		// (set) Token: 0x0601F630 RID: 128560 RVA: 0x0045F45C File Offset: 0x0045D65C
		public TCheckFormationRoleInfoUnion Option { get; set; }

		// Token: 0x0601F631 RID: 128561 RVA: 0x0045F465 File Offset: 0x0045D665
		public ICheckFormationRoleInfoConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Option = null;
		}
	}
}
