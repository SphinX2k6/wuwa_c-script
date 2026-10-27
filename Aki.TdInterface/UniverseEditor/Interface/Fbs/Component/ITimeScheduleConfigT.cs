using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A94 RID: 23188
	public class ITimeScheduleConfigT
	{
		// Token: 0x1700AEB2 RID: 44722
		// (get) Token: 0x0602782A RID: 161834 RVA: 0x0056FB3E File Offset: 0x0056DD3E
		// (set) Token: 0x0602782B RID: 161835 RVA: 0x0056FB46 File Offset: 0x0056DD46
		public string TimeScheduleTag { get; set; }

		// Token: 0x1700AEB3 RID: 44723
		// (get) Token: 0x0602782C RID: 161836 RVA: 0x0056FB4F File Offset: 0x0056DD4F
		// (set) Token: 0x0602782D RID: 161837 RVA: 0x0056FB57 File Offset: 0x0056DD57
		public List<int> TargetEntityIds { get; set; }

		// Token: 0x1700AEB4 RID: 44724
		// (get) Token: 0x0602782E RID: 161838 RVA: 0x0056FB60 File Offset: 0x0056DD60
		// (set) Token: 0x0602782F RID: 161839 RVA: 0x0056FB68 File Offset: 0x0056DD68
		public ITimeScheduleGenerateDynamicEntityT GenerateDynamicEntity { get; set; }

		// Token: 0x1700AEB5 RID: 44725
		// (get) Token: 0x06027830 RID: 161840 RVA: 0x0056FB71 File Offset: 0x0056DD71
		// (set) Token: 0x06027831 RID: 161841 RVA: 0x0056FB79 File Offset: 0x0056DD79
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x06027832 RID: 161842 RVA: 0x0056FB82 File Offset: 0x0056DD82
		public ITimeScheduleConfigT()
		{
			this.TimeScheduleTag = null;
			this.TargetEntityIds = null;
			this.GenerateDynamicEntity = null;
			this.Conditions = null;
		}
	}
}
