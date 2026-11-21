using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D71 RID: 23921
	public class IPortalComponentT
	{
		// Token: 0x1700B00D RID: 45069
		// (get) Token: 0x06027D31 RID: 163121 RVA: 0x00572A15 File Offset: 0x00570C15
		// (set) Token: 0x06027D32 RID: 163122 RVA: 0x00572A1D File Offset: 0x00570C1D
		public bool Disabled { get; set; }

		// Token: 0x1700B00E RID: 45070
		// (get) Token: 0x06027D33 RID: 163123 RVA: 0x00572A26 File Offset: 0x00570C26
		// (set) Token: 0x06027D34 RID: 163124 RVA: 0x00572A2E File Offset: 0x00570C2E
		public TPortalConfigUnion Config { get; set; }

		// Token: 0x1700B00F RID: 45071
		// (get) Token: 0x06027D35 RID: 163125 RVA: 0x00572A37 File Offset: 0x00570C37
		// (set) Token: 0x06027D36 RID: 163126 RVA: 0x00572A3F File Offset: 0x00570C3F
		public byte NullMask { get; set; }

		// Token: 0x06027D37 RID: 163127 RVA: 0x00572A48 File Offset: 0x00570C48
		public IPortalComponentT()
		{
			this.Disabled = false;
			this.Config = null;
			this.NullMask = 0;
		}
	}
}
