using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BCC RID: 15308
	public class IShowTimelineSwitchRoleT
	{
		// Token: 0x17006912 RID: 26898
		// (get) Token: 0x060150BB RID: 86203 RVA: 0x0030D124 File Offset: 0x0030B324
		// (set) Token: 0x060150BC RID: 86204 RVA: 0x0030D12C File Offset: 0x0030B32C
		public EShowTimelineActionType Type { get; set; }

		// Token: 0x17006913 RID: 26899
		// (get) Token: 0x060150BD RID: 86205 RVA: 0x0030D135 File Offset: 0x0030B335
		// (set) Token: 0x060150BE RID: 86206 RVA: 0x0030D13D File Offset: 0x0030B33D
		public int RoleId { get; set; }

		// Token: 0x060150BF RID: 86207 RVA: 0x0030D146 File Offset: 0x0030B346
		public IShowTimelineSwitchRoleT()
		{
			this.Type = EShowTimelineActionType.Skill;
			this.RoleId = 0;
		}
	}
}
