using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003B9F RID: 15263
	public class IShowTimelineActionDisplayConfigT
	{
		// Token: 0x170068A5 RID: 26789
		// (get) Token: 0x06014EBB RID: 85691 RVA: 0x00309042 File Offset: 0x00307242
		// (set) Token: 0x06014EBC RID: 85692 RVA: 0x0030904A File Offset: 0x0030724A
		public string ShortName { get; set; }

		// Token: 0x170068A6 RID: 26790
		// (get) Token: 0x06014EBD RID: 85693 RVA: 0x00309053 File Offset: 0x00307253
		// (set) Token: 0x06014EBE RID: 85694 RVA: 0x0030905B File Offset: 0x0030725B
		public int IconSkillId { get; set; }

		// Token: 0x170068A7 RID: 26791
		// (get) Token: 0x06014EBF RID: 85695 RVA: 0x00309064 File Offset: 0x00307264
		// (set) Token: 0x06014EC0 RID: 85696 RVA: 0x0030906C File Offset: 0x0030726C
		public string Superscript { get; set; }

		// Token: 0x170068A8 RID: 26792
		// (get) Token: 0x06014EC1 RID: 85697 RVA: 0x00309075 File Offset: 0x00307275
		// (set) Token: 0x06014EC2 RID: 85698 RVA: 0x0030907D File Offset: 0x0030727D
		public string DebugText { get; set; }

		// Token: 0x170068A9 RID: 26793
		// (get) Token: 0x06014EC3 RID: 85699 RVA: 0x00309086 File Offset: 0x00307286
		// (set) Token: 0x06014EC4 RID: 85700 RVA: 0x0030908E File Offset: 0x0030728E
		public int SkillGroupId { get; set; }

		// Token: 0x06014EC5 RID: 85701 RVA: 0x00309097 File Offset: 0x00307297
		public IShowTimelineActionDisplayConfigT()
		{
			this.ShortName = null;
			this.IconSkillId = 0;
			this.Superscript = null;
			this.DebugText = null;
			this.SkillGroupId = 0;
		}
	}
}
