using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006423 RID: 25635
	public class IGiantTriggerEnterAreaT
	{
		// Token: 0x1700BD54 RID: 48468
		// (get) Token: 0x0602B8EC RID: 178412 RVA: 0x005EE748 File Offset: 0x005EC948
		// (set) Token: 0x0602B8ED RID: 178413 RVA: 0x005EE750 File Offset: 0x005EC950
		public EGiantTriggerType Type { get; set; }

		// Token: 0x1700BD55 RID: 48469
		// (get) Token: 0x0602B8EE RID: 178414 RVA: 0x005EE759 File Offset: 0x005EC959
		// (set) Token: 0x0602B8EF RID: 178415 RVA: 0x005EE761 File Offset: 0x005EC961
		public int AreaId { get; set; }

		// Token: 0x0602B8F0 RID: 178416 RVA: 0x005EE76A File Offset: 0x005EC96A
		public IGiantTriggerEnterAreaT()
		{
			this.Type = EGiantTriggerType.RoleState;
			this.AreaId = 0;
		}
	}
}
