using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200689E RID: 26782
	public class IGravityFlipFixedPosT
	{
		// Token: 0x1700C6D6 RID: 50902
		// (get) Token: 0x0602EB66 RID: 191334 RVA: 0x0065E4E4 File Offset: 0x0065C6E4
		// (set) Token: 0x0602EB67 RID: 191335 RVA: 0x0065E4EC File Offset: 0x0065C6EC
		public ETeleportType Type { get; set; }

		// Token: 0x1700C6D7 RID: 50903
		// (get) Token: 0x0602EB68 RID: 191336 RVA: 0x0065E4F5 File Offset: 0x0065C6F5
		// (set) Token: 0x0602EB69 RID: 191337 RVA: 0x0065E4FD File Offset: 0x0065C6FD
		public int GravityAndPosEntityId { get; set; }

		// Token: 0x0602EB6A RID: 191338 RVA: 0x0065E506 File Offset: 0x0065C706
		public IGravityFlipFixedPosT()
		{
			this.Type = ETeleportType.FixedPos;
			this.GravityAndPosEntityId = 0;
		}
	}
}
