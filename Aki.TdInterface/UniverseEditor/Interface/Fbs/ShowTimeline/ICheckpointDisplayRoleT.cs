using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003B93 RID: 15251
	public class ICheckpointDisplayRoleT
	{
		// Token: 0x17006885 RID: 26757
		// (get) Token: 0x06014E44 RID: 85572 RVA: 0x0030817C File Offset: 0x0030637C
		// (set) Token: 0x06014E45 RID: 85573 RVA: 0x00308184 File Offset: 0x00306384
		public ECheckpointDisplayType Type { get; set; }

		// Token: 0x17006886 RID: 26758
		// (get) Token: 0x06014E46 RID: 85574 RVA: 0x0030818D File Offset: 0x0030638D
		// (set) Token: 0x06014E47 RID: 85575 RVA: 0x00308195 File Offset: 0x00306395
		public int RoleId { get; set; }

		// Token: 0x06014E48 RID: 85576 RVA: 0x0030819E File Offset: 0x0030639E
		public ICheckpointDisplayRoleT()
		{
			this.Type = ECheckpointDisplayType.Role;
			this.RoleId = 0;
		}
	}
}
