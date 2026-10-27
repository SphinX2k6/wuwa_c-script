using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BE1 RID: 19425
	public class IConditionDebugDataT
	{
		// Token: 0x17008D1C RID: 36124
		// (get) Token: 0x0601EBE5 RID: 125925 RVA: 0x0044C6F6 File Offset: 0x0044A8F6
		// (set) Token: 0x0601EBE6 RID: 125926 RVA: 0x0044C6FE File Offset: 0x0044A8FE
		public EConditionLogicType Type { get; set; }

		// Token: 0x0601EBE7 RID: 125927 RVA: 0x0044C707 File Offset: 0x0044A907
		public IConditionDebugDataT()
		{
			this.Type = EConditionLogicType.BaseAccessQuest;
		}
	}
}
