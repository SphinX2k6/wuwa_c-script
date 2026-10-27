using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066C1 RID: 26305
	public class IEnterOrbitalCameraT
	{
		// Token: 0x1700C370 RID: 50032
		// (get) Token: 0x0602DBA0 RID: 187296 RVA: 0x006417C1 File Offset: 0x0063F9C1
		// (set) Token: 0x0602DBA1 RID: 187297 RVA: 0x006417C9 File Offset: 0x0063F9C9
		public IEnterOrbitalCameraControlByMoveT Option { get; set; }

		// Token: 0x1700C371 RID: 50033
		// (get) Token: 0x0602DBA2 RID: 187298 RVA: 0x006417D2 File Offset: 0x0063F9D2
		// (set) Token: 0x0602DBA3 RID: 187299 RVA: 0x006417DA File Offset: 0x0063F9DA
		public bool IsDisableControlCamera { get; set; }

		// Token: 0x1700C372 RID: 50034
		// (get) Token: 0x0602DBA4 RID: 187300 RVA: 0x006417E3 File Offset: 0x0063F9E3
		// (set) Token: 0x0602DBA5 RID: 187301 RVA: 0x006417EB File Offset: 0x0063F9EB
		public byte NullMask { get; set; }

		// Token: 0x0602DBA6 RID: 187302 RVA: 0x006417F4 File Offset: 0x0063F9F4
		public IEnterOrbitalCameraT()
		{
			this.Option = null;
			this.IsDisableControlCamera = false;
			this.NullMask = 0;
		}
	}
}
