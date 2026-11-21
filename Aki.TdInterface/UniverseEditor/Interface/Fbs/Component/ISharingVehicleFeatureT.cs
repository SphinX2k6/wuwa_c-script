using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F16 RID: 24342
	public class ISharingVehicleFeatureT
	{
		// Token: 0x1700B40E RID: 46094
		// (get) Token: 0x06028DC2 RID: 167362 RVA: 0x00595636 File Offset: 0x00593836
		// (set) Token: 0x06028DC3 RID: 167363 RVA: 0x0059563E File Offset: 0x0059383E
		public EVehicleFeatureFlag Type { get; set; }

		// Token: 0x1700B40F RID: 46095
		// (get) Token: 0x06028DC4 RID: 167364 RVA: 0x00595647 File Offset: 0x00593847
		// (set) Token: 0x06028DC5 RID: 167365 RVA: 0x0059564F File Offset: 0x0059384F
		public EAffectionDegreeSourceType AffectionDegreeSourceType { get; set; }

		// Token: 0x1700B410 RID: 46096
		// (get) Token: 0x06028DC6 RID: 167366 RVA: 0x00595658 File Offset: 0x00593858
		// (set) Token: 0x06028DC7 RID: 167367 RVA: 0x00595660 File Offset: 0x00593860
		public byte NullMask { get; set; }

		// Token: 0x06028DC8 RID: 167368 RVA: 0x00595669 File Offset: 0x00593869
		public ISharingVehicleFeatureT()
		{
			this.Type = EVehicleFeatureFlag.None;
			this.AffectionDegreeSourceType = EAffectionDegreeSourceType.CyberpunkCollaboration;
			this.NullMask = 0;
		}
	}
}
