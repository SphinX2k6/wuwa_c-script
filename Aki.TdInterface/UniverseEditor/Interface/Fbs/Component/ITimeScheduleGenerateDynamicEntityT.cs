using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060AD RID: 24749
	public class ITimeScheduleGenerateDynamicEntityT
	{
		// Token: 0x1700B805 RID: 47109
		// (get) Token: 0x06029E14 RID: 171540 RVA: 0x005B7A7A File Offset: 0x005B5C7A
		// (set) Token: 0x06029E15 RID: 171541 RVA: 0x005B7A82 File Offset: 0x005B5C82
		public ITimeScheduleFixedIntervalRefreshT GenerateParams { get; set; }

		// Token: 0x1700B806 RID: 47110
		// (get) Token: 0x06029E16 RID: 171542 RVA: 0x005B7A8B File Offset: 0x005B5C8B
		// (set) Token: 0x06029E17 RID: 171543 RVA: 0x005B7A93 File Offset: 0x005B5C93
		public ITimeScheduleEntityTemplateNpcSourceT NpcSource { get; set; }

		// Token: 0x1700B807 RID: 47111
		// (get) Token: 0x06029E18 RID: 171544 RVA: 0x005B7A9C File Offset: 0x005B5C9C
		// (set) Token: 0x06029E19 RID: 171545 RVA: 0x005B7AA4 File Offset: 0x005B5CA4
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x06029E1A RID: 171546 RVA: 0x005B7AAD File Offset: 0x005B5CAD
		public ITimeScheduleGenerateDynamicEntityT()
		{
			this.GenerateParams = null;
			this.NpcSource = null;
			this.Conditions = null;
		}
	}
}
