using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AA2 RID: 19106
	public class ITrapDefenseStarInfo
	{
		// Token: 0x17007ADE RID: 31454
		// (get) Token: 0x0603183C RID: 202812 RVA: 0x00B7AC2D File Offset: 0x00B78E2D
		// (set) Token: 0x0603183D RID: 202813 RVA: 0x00B7AC35 File Offset: 0x00B78E35
		public bool IsAchieve { get; set; }

		// Token: 0x17007ADF RID: 31455
		// (get) Token: 0x0603183E RID: 202814 RVA: 0x00B7AC3E File Offset: 0x00B78E3E
		// (set) Token: 0x0603183F RID: 202815 RVA: 0x00B7AC46 File Offset: 0x00B78E46
		public bool IsNew { get; set; }

		// Token: 0x17007AE0 RID: 31456
		// (get) Token: 0x06031840 RID: 202816 RVA: 0x00B7AC4F File Offset: 0x00B78E4F
		// (set) Token: 0x06031841 RID: 202817 RVA: 0x00B7AC57 File Offset: 0x00B78E57
		public bool HasPlayed { get; set; }

		// Token: 0x17007AE1 RID: 31457
		// (get) Token: 0x06031842 RID: 202818 RVA: 0x00B7AC60 File Offset: 0x00B78E60
		// (set) Token: 0x06031843 RID: 202819 RVA: 0x00B7AC68 File Offset: 0x00B78E68
		public int PlayDelay { get; set; }
	}
}
