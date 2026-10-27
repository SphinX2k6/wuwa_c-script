using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004056 RID: 16470
	public class IQuestStatisticsTypeT
	{
		// Token: 0x170073F8 RID: 29688
		// (get) Token: 0x06017E06 RID: 97798 RVA: 0x003721BF File Offset: 0x003703BF
		// (set) Token: 0x06017E07 RID: 97799 RVA: 0x003721C7 File Offset: 0x003703C7
		public EStatisticsEventType Type { get; set; }

		// Token: 0x170073F9 RID: 29689
		// (get) Token: 0x06017E08 RID: 97800 RVA: 0x003721D0 File Offset: 0x003703D0
		// (set) Token: 0x06017E09 RID: 97801 RVA: 0x003721D8 File Offset: 0x003703D8
		public TVarRefUnion Var { get; set; }

		// Token: 0x06017E0A RID: 97802 RVA: 0x003721E1 File Offset: 0x003703E1
		public IQuestStatisticsTypeT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
		}
	}
}
