using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050D7 RID: 20695
	public class IConditionGroupsT
	{
		// Token: 0x1700944C RID: 37964
		// (get) Token: 0x06020819 RID: 133145 RVA: 0x00482BAB File Offset: 0x00480DAB
		// (set) Token: 0x0602081A RID: 133146 RVA: 0x00482BB3 File Offset: 0x00480DB3
		public EConditionCount Type { get; set; }

		// Token: 0x1700944D RID: 37965
		// (get) Token: 0x0602081B RID: 133147 RVA: 0x00482BBC File Offset: 0x00480DBC
		// (set) Token: 0x0602081C RID: 133148 RVA: 0x00482BC4 File Offset: 0x00480DC4
		public List<IConditionGroupT> Conditions { get; set; }

		// Token: 0x0602081D RID: 133149 RVA: 0x00482BCD File Offset: 0x00480DCD
		public IConditionGroupsT()
		{
			this.Type = EConditionCount.All;
			this.Conditions = null;
		}
	}
}
