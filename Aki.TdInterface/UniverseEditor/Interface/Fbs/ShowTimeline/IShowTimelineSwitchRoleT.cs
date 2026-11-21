using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FD7 RID: 16343
	public class IShowTimelineSwitchRoleT
	{
		// Token: 0x17006EBA RID: 28346
		// (get) Token: 0x060165B1 RID: 91569 RVA: 0x00333CAC File Offset: 0x00331EAC
		// (set) Token: 0x060165B2 RID: 91570 RVA: 0x00333CB4 File Offset: 0x00331EB4
		public EShowTimelineActionType Type { get; set; }

		// Token: 0x17006EBB RID: 28347
		// (get) Token: 0x060165B3 RID: 91571 RVA: 0x00333CBD File Offset: 0x00331EBD
		// (set) Token: 0x060165B4 RID: 91572 RVA: 0x00333CC5 File Offset: 0x00331EC5
		public int RoleId { get; set; }

		// Token: 0x060165B5 RID: 91573 RVA: 0x00333CCE File Offset: 0x00331ECE
		public IShowTimelineSwitchRoleT()
		{
			this.Type = EShowTimelineActionType.Skill;
			this.RoleId = 0;
		}
	}
}
