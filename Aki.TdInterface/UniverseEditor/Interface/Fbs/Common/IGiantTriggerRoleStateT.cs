using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DE9 RID: 24041
	public class IGiantTriggerRoleStateT
	{
		// Token: 0x1700B3F3 RID: 46067
		// (get) Token: 0x06029278 RID: 168568 RVA: 0x005A5C18 File Offset: 0x005A3E18
		// (set) Token: 0x06029279 RID: 168569 RVA: 0x005A5C20 File Offset: 0x005A3E20
		public EGiantTriggerType Type { get; set; }

		// Token: 0x1700B3F4 RID: 46068
		// (get) Token: 0x0602927A RID: 168570 RVA: 0x005A5C29 File Offset: 0x005A3E29
		// (set) Token: 0x0602927B RID: 168571 RVA: 0x005A5C31 File Offset: 0x005A3E31
		public EGiantRoleState RoleState { get; set; }

		// Token: 0x0602927C RID: 168572 RVA: 0x005A5C3A File Offset: 0x005A3E3A
		public IGiantTriggerRoleStateT()
		{
			this.Type = EGiantTriggerType.RoleState;
			this.RoleState = EGiantRoleState.Death;
		}
	}
}
