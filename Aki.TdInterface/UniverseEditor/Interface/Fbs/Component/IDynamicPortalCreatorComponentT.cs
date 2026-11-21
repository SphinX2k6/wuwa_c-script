using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200565C RID: 22108
	public class IDynamicPortalCreatorComponentT
	{
		// Token: 0x17009EE2 RID: 40674
		// (get) Token: 0x06023565 RID: 144741 RVA: 0x004DC941 File Offset: 0x004DAB41
		// (set) Token: 0x06023566 RID: 144742 RVA: 0x004DC949 File Offset: 0x004DAB49
		public bool Disabled { get; set; }

		// Token: 0x17009EE3 RID: 40675
		// (get) Token: 0x06023567 RID: 144743 RVA: 0x004DC952 File Offset: 0x004DAB52
		// (set) Token: 0x06023568 RID: 144744 RVA: 0x004DC95A File Offset: 0x004DAB5A
		public IDynamicPortalByBulletT Model { get; set; }

		// Token: 0x17009EE4 RID: 40676
		// (get) Token: 0x06023569 RID: 144745 RVA: 0x004DC963 File Offset: 0x004DAB63
		// (set) Token: 0x0602356A RID: 144746 RVA: 0x004DC96B File Offset: 0x004DAB6B
		public byte NullMask { get; set; }

		// Token: 0x0602356B RID: 144747 RVA: 0x004DC974 File Offset: 0x004DAB74
		public IDynamicPortalCreatorComponentT()
		{
			this.Disabled = false;
			this.Model = null;
			this.NullMask = 0;
		}
	}
}
