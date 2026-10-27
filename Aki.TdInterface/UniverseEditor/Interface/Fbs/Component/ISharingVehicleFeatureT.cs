using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005909 RID: 22793
	public class ISharingVehicleFeatureT
	{
		// Token: 0x1700AADA RID: 43738
		// (get) Token: 0x06026858 RID: 157784 RVA: 0x0054E9CA File Offset: 0x0054CBCA
		// (set) Token: 0x06026859 RID: 157785 RVA: 0x0054E9D2 File Offset: 0x0054CBD2
		public EVehicleFeatureFlag Type { get; set; }

		// Token: 0x1700AADB RID: 43739
		// (get) Token: 0x0602685A RID: 157786 RVA: 0x0054E9DB File Offset: 0x0054CBDB
		// (set) Token: 0x0602685B RID: 157787 RVA: 0x0054E9E3 File Offset: 0x0054CBE3
		public EAffectionDegreeSourceType AffectionDegreeSourceType { get; set; }

		// Token: 0x1700AADC RID: 43740
		// (get) Token: 0x0602685C RID: 157788 RVA: 0x0054E9EC File Offset: 0x0054CBEC
		// (set) Token: 0x0602685D RID: 157789 RVA: 0x0054E9F4 File Offset: 0x0054CBF4
		public byte NullMask { get; set; }

		// Token: 0x0602685E RID: 157790 RVA: 0x0054E9FD File Offset: 0x0054CBFD
		public ISharingVehicleFeatureT()
		{
			this.Type = EVehicleFeatureFlag.None;
			this.AffectionDegreeSourceType = EAffectionDegreeSourceType.CyberpunkCollaboration;
			this.NullMask = 0;
		}
	}
}
