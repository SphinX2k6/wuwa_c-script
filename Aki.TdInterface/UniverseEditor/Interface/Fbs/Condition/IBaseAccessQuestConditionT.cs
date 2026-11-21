using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E25 RID: 20005
	public class IBaseAccessQuestConditionT
	{
		// Token: 0x17008E88 RID: 36488
		// (get) Token: 0x0601EEEB RID: 126699 RVA: 0x004524BA File Offset: 0x004506BA
		// (set) Token: 0x0601EEEC RID: 126700 RVA: 0x004524C2 File Offset: 0x004506C2
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x0601EEED RID: 126701 RVA: 0x004524CB File Offset: 0x004506CB
		public IBaseAccessQuestConditionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
		}
	}
}
