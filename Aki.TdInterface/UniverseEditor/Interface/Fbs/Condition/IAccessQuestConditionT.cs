using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E1C RID: 19996
	public class IAccessQuestConditionT
	{
		// Token: 0x17008E7B RID: 36475
		// (get) Token: 0x0601EEAD RID: 126637 RVA: 0x00451F5D File Offset: 0x0045015D
		// (set) Token: 0x0601EEAE RID: 126638 RVA: 0x00451F65 File Offset: 0x00450165
		public EConditionCount Type { get; set; }

		// Token: 0x17008E7C RID: 36476
		// (get) Token: 0x0601EEAF RID: 126639 RVA: 0x00451F6E File Offset: 0x0045016E
		// (set) Token: 0x0601EEB0 RID: 126640 RVA: 0x00451F76 File Offset: 0x00450176
		public List<TAccessQuestConditionUnion> Conditions { get; set; }

		// Token: 0x17008E7D RID: 36477
		// (get) Token: 0x0601EEB1 RID: 126641 RVA: 0x00451F7F File Offset: 0x0045017F
		// (set) Token: 0x0601EEB2 RID: 126642 RVA: 0x00451F87 File Offset: 0x00450187
		public byte NullMask { get; set; }

		// Token: 0x0601EEB3 RID: 126643 RVA: 0x00451F90 File Offset: 0x00450190
		public IAccessQuestConditionT()
		{
			this.Type = EConditionCount.All;
			this.Conditions = null;
			this.NullMask = 0;
		}
	}
}
