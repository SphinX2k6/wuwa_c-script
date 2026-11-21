using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C5A RID: 15450
	public class RoleDevPropsConfig : IRoleDevPropsConfig
	{
		// Token: 0x170050BA RID: 20666
		// (get) Token: 0x0602790C RID: 162060 RVA: 0x00B19D36 File Offset: 0x00B17F36
		// (set) Token: 0x0602790D RID: 162061 RVA: 0x00B19D3E File Offset: 0x00B17F3E
		public int Id { get; set; }

		// Token: 0x170050BB RID: 20667
		// (get) Token: 0x0602790E RID: 162062 RVA: 0x00B19D47 File Offset: 0x00B17F47
		// (set) Token: 0x0602790F RID: 162063 RVA: 0x00B19D4F File Offset: 0x00B17F4F
		public long ProspectBeginTime { get; set; }

		// Token: 0x170050BC RID: 20668
		// (get) Token: 0x06027910 RID: 162064 RVA: 0x00B19D58 File Offset: 0x00B17F58
		// (set) Token: 0x06027911 RID: 162065 RVA: 0x00B19D60 File Offset: 0x00B17F60
		public long ProspectEndTime { get; set; }
	}
}
