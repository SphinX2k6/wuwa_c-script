using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060A1 RID: 24737
	public class ITimeScheduleConfigT
	{
		// Token: 0x1700B7EA RID: 47082
		// (get) Token: 0x06029DA2 RID: 171426 RVA: 0x005B6B4A File Offset: 0x005B4D4A
		// (set) Token: 0x06029DA3 RID: 171427 RVA: 0x005B6B52 File Offset: 0x005B4D52
		public string TimeScheduleTag { get; set; }

		// Token: 0x1700B7EB RID: 47083
		// (get) Token: 0x06029DA4 RID: 171428 RVA: 0x005B6B5B File Offset: 0x005B4D5B
		// (set) Token: 0x06029DA5 RID: 171429 RVA: 0x005B6B63 File Offset: 0x005B4D63
		public List<int> TargetEntityIds { get; set; }

		// Token: 0x1700B7EC RID: 47084
		// (get) Token: 0x06029DA6 RID: 171430 RVA: 0x005B6B6C File Offset: 0x005B4D6C
		// (set) Token: 0x06029DA7 RID: 171431 RVA: 0x005B6B74 File Offset: 0x005B4D74
		public ITimeScheduleGenerateDynamicEntityT GenerateDynamicEntity { get; set; }

		// Token: 0x1700B7ED RID: 47085
		// (get) Token: 0x06029DA8 RID: 171432 RVA: 0x005B6B7D File Offset: 0x005B4D7D
		// (set) Token: 0x06029DA9 RID: 171433 RVA: 0x005B6B85 File Offset: 0x005B4D85
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x06029DAA RID: 171434 RVA: 0x005B6B8E File Offset: 0x005B4D8E
		public ITimeScheduleConfigT()
		{
			this.TimeScheduleTag = null;
			this.TargetEntityIds = null;
			this.GenerateDynamicEntity = null;
			this.Conditions = null;
		}
	}
}
