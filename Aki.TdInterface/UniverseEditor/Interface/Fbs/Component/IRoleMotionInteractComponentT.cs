using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E87 RID: 24199
	public class IRoleMotionInteractComponentT
	{
		// Token: 0x1700B29A RID: 45722
		// (get) Token: 0x0602880C RID: 165900 RVA: 0x00589D55 File Offset: 0x00587F55
		// (set) Token: 0x0602880D RID: 165901 RVA: 0x00589D5D File Offset: 0x00587F5D
		public bool Disabled { get; set; }

		// Token: 0x1700B29B RID: 45723
		// (get) Token: 0x0602880E RID: 165902 RVA: 0x00589D66 File Offset: 0x00587F66
		// (set) Token: 0x0602880F RID: 165903 RVA: 0x00589D6E File Offset: 0x00587F6E
		public IPetalGrabRoleMotionInteractT MotionInteractConfig { get; set; }

		// Token: 0x1700B29C RID: 45724
		// (get) Token: 0x06028810 RID: 165904 RVA: 0x00589D77 File Offset: 0x00587F77
		// (set) Token: 0x06028811 RID: 165905 RVA: 0x00589D7F File Offset: 0x00587F7F
		public byte NullMask { get; set; }

		// Token: 0x06028812 RID: 165906 RVA: 0x00589D88 File Offset: 0x00587F88
		public IRoleMotionInteractComponentT()
		{
			this.Disabled = false;
			this.MotionInteractConfig = null;
			this.NullMask = 0;
		}
	}
}
