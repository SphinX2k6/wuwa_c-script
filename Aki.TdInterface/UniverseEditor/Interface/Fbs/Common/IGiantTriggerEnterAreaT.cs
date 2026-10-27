using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DE6 RID: 24038
	public class IGiantTriggerEnterAreaT
	{
		// Token: 0x1700B3EE RID: 46062
		// (get) Token: 0x06029262 RID: 168546 RVA: 0x005A5A18 File Offset: 0x005A3C18
		// (set) Token: 0x06029263 RID: 168547 RVA: 0x005A5A20 File Offset: 0x005A3C20
		public EGiantTriggerType Type { get; set; }

		// Token: 0x1700B3EF RID: 46063
		// (get) Token: 0x06029264 RID: 168548 RVA: 0x005A5A29 File Offset: 0x005A3C29
		// (set) Token: 0x06029265 RID: 168549 RVA: 0x005A5A31 File Offset: 0x005A3C31
		public int AreaId { get; set; }

		// Token: 0x06029266 RID: 168550 RVA: 0x005A5A3A File Offset: 0x005A3C3A
		public IGiantTriggerEnterAreaT()
		{
			this.Type = EGiantTriggerType.RoleState;
			this.AreaId = 0;
		}
	}
}
