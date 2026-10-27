using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200613E RID: 24894
	public class IAddTrialFollowShooterT
	{
		// Token: 0x1700B7AC RID: 47020
		// (get) Token: 0x0602A989 RID: 174473 RVA: 0x005DDB1B File Offset: 0x005DBD1B
		// (set) Token: 0x0602A98A RID: 174474 RVA: 0x005DDB23 File Offset: 0x005DBD23
		public int Id { get; set; }

		// Token: 0x1700B7AD RID: 47021
		// (get) Token: 0x0602A98B RID: 174475 RVA: 0x005DDB2C File Offset: 0x005DBD2C
		// (set) Token: 0x0602A98C RID: 174476 RVA: 0x005DDB34 File Offset: 0x005DBD34
		public IActiveRangeT ActiveRange { get; set; }

		// Token: 0x0602A98D RID: 174477 RVA: 0x005DDB3D File Offset: 0x005DBD3D
		public IAddTrialFollowShooterT()
		{
			this.Id = 0;
			this.ActiveRange = null;
		}
	}
}
