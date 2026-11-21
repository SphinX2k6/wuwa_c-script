using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EF1 RID: 20209
	public class ICheckFollowShooterActiveT
	{
		// Token: 0x1700904D RID: 36941
		// (get) Token: 0x0601F60E RID: 128526 RVA: 0x0045EFB6 File Offset: 0x0045D1B6
		// (set) Token: 0x0601F60F RID: 128527 RVA: 0x0045EFBE File Offset: 0x0045D1BE
		public ECondition Type { get; set; }

		// Token: 0x1700904E RID: 36942
		// (get) Token: 0x0601F610 RID: 128528 RVA: 0x0045EFC7 File Offset: 0x0045D1C7
		// (set) Token: 0x0601F611 RID: 128529 RVA: 0x0045EFCF File Offset: 0x0045D1CF
		public bool Active { get; set; }

		// Token: 0x1700904F RID: 36943
		// (get) Token: 0x0601F612 RID: 128530 RVA: 0x0045EFD8 File Offset: 0x0045D1D8
		// (set) Token: 0x0601F613 RID: 128531 RVA: 0x0045EFE0 File Offset: 0x0045D1E0
		public int Id { get; set; }

		// Token: 0x0601F614 RID: 128532 RVA: 0x0045EFE9 File Offset: 0x0045D1E9
		public ICheckFollowShooterActiveT()
		{
			this.Type = ECondition.CompareVar;
			this.Active = false;
			this.Id = 0;
		}
	}
}
