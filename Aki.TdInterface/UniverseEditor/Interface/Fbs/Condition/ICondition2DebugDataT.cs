using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BDB RID: 19419
	public class ICondition2DebugDataT
	{
		// Token: 0x17008D16 RID: 36118
		// (get) Token: 0x0601EAA7 RID: 125607 RVA: 0x00449D8F File Offset: 0x00447F8F
		// (set) Token: 0x0601EAA8 RID: 125608 RVA: 0x00449D97 File Offset: 0x00447F97
		public EConditionLogicType Type { get; set; }

		// Token: 0x17008D17 RID: 36119
		// (get) Token: 0x0601EAA9 RID: 125609 RVA: 0x00449DA0 File Offset: 0x00447FA0
		// (set) Token: 0x0601EAAA RID: 125610 RVA: 0x00449DA8 File Offset: 0x00447FA8
		public IConditionGroupT Condition2Group { get; set; }

		// Token: 0x0601EAAB RID: 125611 RVA: 0x00449DB1 File Offset: 0x00447FB1
		public ICondition2DebugDataT()
		{
			this.Type = EConditionLogicType.BaseAccessQuest;
			this.Condition2Group = null;
		}
	}
}
