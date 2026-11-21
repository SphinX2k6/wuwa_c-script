using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FA7 RID: 16295
	public class IShowTimelineActionDisplayConfigT
	{
		// Token: 0x17006E44 RID: 28228
		// (get) Token: 0x06016385 RID: 91013 RVA: 0x0032F5DA File Offset: 0x0032D7DA
		// (set) Token: 0x06016386 RID: 91014 RVA: 0x0032F5E2 File Offset: 0x0032D7E2
		public string ShortName { get; set; }

		// Token: 0x17006E45 RID: 28229
		// (get) Token: 0x06016387 RID: 91015 RVA: 0x0032F5EB File Offset: 0x0032D7EB
		// (set) Token: 0x06016388 RID: 91016 RVA: 0x0032F5F3 File Offset: 0x0032D7F3
		public int IconSkillId { get; set; }

		// Token: 0x17006E46 RID: 28230
		// (get) Token: 0x06016389 RID: 91017 RVA: 0x0032F5FC File Offset: 0x0032D7FC
		// (set) Token: 0x0601638A RID: 91018 RVA: 0x0032F604 File Offset: 0x0032D804
		public string Superscript { get; set; }

		// Token: 0x17006E47 RID: 28231
		// (get) Token: 0x0601638B RID: 91019 RVA: 0x0032F60D File Offset: 0x0032D80D
		// (set) Token: 0x0601638C RID: 91020 RVA: 0x0032F615 File Offset: 0x0032D815
		public string DebugText { get; set; }

		// Token: 0x17006E48 RID: 28232
		// (get) Token: 0x0601638D RID: 91021 RVA: 0x0032F61E File Offset: 0x0032D81E
		// (set) Token: 0x0601638E RID: 91022 RVA: 0x0032F626 File Offset: 0x0032D826
		public int SkillGroupId { get; set; }

		// Token: 0x0601638F RID: 91023 RVA: 0x0032F62F File Offset: 0x0032D82F
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
