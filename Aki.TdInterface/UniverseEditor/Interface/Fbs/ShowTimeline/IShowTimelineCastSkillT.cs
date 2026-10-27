using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BB1 RID: 15281
	public class IShowTimelineCastSkillT
	{
		// Token: 0x170068BC RID: 26812
		// (get) Token: 0x06014F3D RID: 85821 RVA: 0x00309C70 File Offset: 0x00307E70
		// (set) Token: 0x06014F3E RID: 85822 RVA: 0x00309C78 File Offset: 0x00307E78
		public EShowTimelineActionType Type { get; set; }

		// Token: 0x170068BD RID: 26813
		// (get) Token: 0x06014F3F RID: 85823 RVA: 0x00309C81 File Offset: 0x00307E81
		// (set) Token: 0x06014F40 RID: 85824 RVA: 0x00309C89 File Offset: 0x00307E89
		public int SkillId { get; set; }

		// Token: 0x06014F41 RID: 85825 RVA: 0x00309C92 File Offset: 0x00307E92
		public IShowTimelineCastSkillT()
		{
			this.Type = EShowTimelineActionType.Skill;
			this.SkillId = 0;
		}
	}
}
