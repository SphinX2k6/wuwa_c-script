using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DEF RID: 24047
	public class IGiantTriggerTypeT
	{
		// Token: 0x1700B3FC RID: 46076
		// (get) Token: 0x060292A6 RID: 168614 RVA: 0x005A6132 File Offset: 0x005A4332
		// (set) Token: 0x060292A7 RID: 168615 RVA: 0x005A613A File Offset: 0x005A433A
		public EGiantTriggerType Type { get; set; }

		// Token: 0x060292A8 RID: 168616 RVA: 0x005A6143 File Offset: 0x005A4343
		public IGiantTriggerTypeT()
		{
			this.Type = EGiantTriggerType.RoleState;
		}
	}
}
