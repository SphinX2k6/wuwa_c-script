using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200734D RID: 29517
	public class INpcSwingGetUpT
	{
		// Token: 0x1700D863 RID: 55395
		// (get) Token: 0x060337CA RID: 210890 RVA: 0x006F08BC File Offset: 0x006EEABC
		// (set) Token: 0x060337CB RID: 210891 RVA: 0x006F08C4 File Offset: 0x006EEAC4
		public ENpcLeisureInteract Type { get; set; }

		// Token: 0x1700D864 RID: 55396
		// (get) Token: 0x060337CC RID: 210892 RVA: 0x006F08CD File Offset: 0x006EEACD
		// (set) Token: 0x060337CD RID: 210893 RVA: 0x006F08D5 File Offset: 0x006EEAD5
		public bool KeepState { get; set; }

		// Token: 0x1700D865 RID: 55397
		// (get) Token: 0x060337CE RID: 210894 RVA: 0x006F08DE File Offset: 0x006EEADE
		// (set) Token: 0x060337CF RID: 210895 RVA: 0x006F08E6 File Offset: 0x006EEAE6
		public int TargetNpcId { get; set; }

		// Token: 0x1700D866 RID: 55398
		// (get) Token: 0x060337D0 RID: 210896 RVA: 0x006F08EF File Offset: 0x006EEAEF
		// (set) Token: 0x060337D1 RID: 210897 RVA: 0x006F08F7 File Offset: 0x006EEAF7
		public byte NullMask { get; set; }

		// Token: 0x060337D2 RID: 210898 RVA: 0x006F0900 File Offset: 0x006EEB00
		public INpcSwingGetUpT()
		{
			this.Type = ENpcLeisureInteract.SitDown;
			this.KeepState = false;
			this.TargetNpcId = 0;
			this.NullMask = 0;
		}
	}
}
