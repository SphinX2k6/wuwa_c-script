using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006426 RID: 25638
	public class IGiantTriggerRoleStateT
	{
		// Token: 0x1700BD59 RID: 48473
		// (get) Token: 0x0602B902 RID: 178434 RVA: 0x005EE948 File Offset: 0x005ECB48
		// (set) Token: 0x0602B903 RID: 178435 RVA: 0x005EE950 File Offset: 0x005ECB50
		public EGiantTriggerType Type { get; set; }

		// Token: 0x1700BD5A RID: 48474
		// (get) Token: 0x0602B904 RID: 178436 RVA: 0x005EE959 File Offset: 0x005ECB59
		// (set) Token: 0x0602B905 RID: 178437 RVA: 0x005EE961 File Offset: 0x005ECB61
		public EGiantRoleState RoleState { get; set; }

		// Token: 0x0602B906 RID: 178438 RVA: 0x005EE96A File Offset: 0x005ECB6A
		public IGiantTriggerRoleStateT()
		{
			this.Type = EGiantTriggerType.RoleState;
			this.RoleState = EGiantRoleState.Death;
		}
	}
}
