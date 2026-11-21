using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FB9 RID: 16313
	public class IShowTimelineCastSkillT
	{
		// Token: 0x17006E5F RID: 28255
		// (get) Token: 0x06016415 RID: 91157 RVA: 0x003304CC File Offset: 0x0032E6CC
		// (set) Token: 0x06016416 RID: 91158 RVA: 0x003304D4 File Offset: 0x0032E6D4
		public EShowTimelineActionType Type { get; set; }

		// Token: 0x17006E60 RID: 28256
		// (get) Token: 0x06016417 RID: 91159 RVA: 0x003304DD File Offset: 0x0032E6DD
		// (set) Token: 0x06016418 RID: 91160 RVA: 0x003304E5 File Offset: 0x0032E6E5
		public int SkillId { get; set; }

		// Token: 0x06016419 RID: 91161 RVA: 0x003304EE File Offset: 0x0032E6EE
		public IShowTimelineCastSkillT()
		{
			this.Type = EShowTimelineActionType.Skill;
			this.SkillId = 0;
		}
	}
}
