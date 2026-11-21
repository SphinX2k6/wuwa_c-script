using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003F9B RID: 16283
	public class ICheckpointDisplayRoleT
	{
		// Token: 0x17006E24 RID: 28196
		// (get) Token: 0x0601630E RID: 90894 RVA: 0x0032E714 File Offset: 0x0032C914
		// (set) Token: 0x0601630F RID: 90895 RVA: 0x0032E71C File Offset: 0x0032C91C
		public ECheckpointDisplayType Type { get; set; }

		// Token: 0x17006E25 RID: 28197
		// (get) Token: 0x06016310 RID: 90896 RVA: 0x0032E725 File Offset: 0x0032C925
		// (set) Token: 0x06016311 RID: 90897 RVA: 0x0032E72D File Offset: 0x0032C92D
		public int RoleId { get; set; }

		// Token: 0x06016312 RID: 90898 RVA: 0x0032E736 File Offset: 0x0032C936
		public ICheckpointDisplayRoleT()
		{
			this.Type = ECheckpointDisplayType.Role;
			this.RoleId = 0;
		}
	}
}
