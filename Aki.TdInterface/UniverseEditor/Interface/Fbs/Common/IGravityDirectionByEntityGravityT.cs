using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DF5 RID: 24053
	public class IGravityDirectionByEntityGravityT
	{
		// Token: 0x1700B402 RID: 46082
		// (get) Token: 0x060292CA RID: 168650 RVA: 0x005A6498 File Offset: 0x005A4698
		// (set) Token: 0x060292CB RID: 168651 RVA: 0x005A64A0 File Offset: 0x005A46A0
		public EGravityDirectionType Type { get; set; }

		// Token: 0x1700B403 RID: 46083
		// (get) Token: 0x060292CC RID: 168652 RVA: 0x005A64A9 File Offset: 0x005A46A9
		// (set) Token: 0x060292CD RID: 168653 RVA: 0x005A64B1 File Offset: 0x005A46B1
		public int EntityId { get; set; }

		// Token: 0x060292CE RID: 168654 RVA: 0x005A64BA File Offset: 0x005A46BA
		public IGravityDirectionByEntityGravityT()
		{
			this.Type = EGravityDirectionType.SelfRotation;
			this.EntityId = 0;
		}
	}
}
