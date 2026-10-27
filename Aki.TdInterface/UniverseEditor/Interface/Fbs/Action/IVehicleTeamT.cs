using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007536 RID: 30006
	public class IVehicleTeamT
	{
		// Token: 0x1700E3B3 RID: 58291
		// (get) Token: 0x0603698C RID: 223628 RVA: 0x0076B008 File Offset: 0x00769208
		// (set) Token: 0x0603698D RID: 223629 RVA: 0x0076B010 File Offset: 0x00769210
		public ETargetVehicle Type { get; set; }

		// Token: 0x1700E3B4 RID: 58292
		// (get) Token: 0x0603698E RID: 223630 RVA: 0x0076B019 File Offset: 0x00769219
		// (set) Token: 0x0603698F RID: 223631 RVA: 0x0076B021 File Offset: 0x00769221
		public int TeamId { get; set; }

		// Token: 0x06036990 RID: 223632 RVA: 0x0076B02A File Offset: 0x0076922A
		public IVehicleTeamT()
		{
			this.Type = ETargetVehicle.Current;
			this.TeamId = 0;
		}
	}
}
