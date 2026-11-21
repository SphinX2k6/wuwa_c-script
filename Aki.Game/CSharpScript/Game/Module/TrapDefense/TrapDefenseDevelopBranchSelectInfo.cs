using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039FA RID: 14842
	public class TrapDefenseDevelopBranchSelectInfo : ITrapDefenseDevelopBranchSelectInfo
	{
		// Token: 0x17004E14 RID: 19988
		// (get) Token: 0x06026359 RID: 156505 RVA: 0x00AB63A1 File Offset: 0x00AB45A1
		// (set) Token: 0x0602635A RID: 156506 RVA: 0x00AB63A9 File Offset: 0x00AB45A9
		public int Id { get; set; }

		// Token: 0x17004E15 RID: 19989
		// (get) Token: 0x0602635B RID: 156507 RVA: 0x00AB63B2 File Offset: 0x00AB45B2
		// (set) Token: 0x0602635C RID: 156508 RVA: 0x00AB63BA File Offset: 0x00AB45BA
		public bool IsCurLevel { get; set; }

		// Token: 0x17004E16 RID: 19990
		// (get) Token: 0x0602635D RID: 156509 RVA: 0x00AB63C3 File Offset: 0x00AB45C3
		// (set) Token: 0x0602635E RID: 156510 RVA: 0x00AB63CB File Offset: 0x00AB45CB
		public bool IsSelected { get; set; }
	}
}
