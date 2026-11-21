using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FA4 RID: 16292
	public class IShowTimelineActionT
	{
		// Token: 0x17006E39 RID: 28217
		// (get) Token: 0x0601635D RID: 90973 RVA: 0x0032F13D File Offset: 0x0032D33D
		// (set) Token: 0x0601635E RID: 90974 RVA: 0x0032F145 File Offset: 0x0032D345
		public EShowTimelineType Type { get; set; }

		// Token: 0x17006E3A RID: 28218
		// (get) Token: 0x0601635F RID: 90975 RVA: 0x0032F14E File Offset: 0x0032D34E
		// (set) Token: 0x06016360 RID: 90976 RVA: 0x0032F156 File Offset: 0x0032D356
		public EShowTimelineActionType ActionType { get; set; }

		// Token: 0x17006E3B RID: 28219
		// (get) Token: 0x06016361 RID: 90977 RVA: 0x0032F15F File Offset: 0x0032D35F
		// (set) Token: 0x06016362 RID: 90978 RVA: 0x0032F167 File Offset: 0x0032D367
		public int ActionParam { get; set; }

		// Token: 0x17006E3C RID: 28220
		// (get) Token: 0x06016363 RID: 90979 RVA: 0x0032F170 File Offset: 0x0032D370
		// (set) Token: 0x06016364 RID: 90980 RVA: 0x0032F178 File Offset: 0x0032D378
		public TShowTimelineActionOptionUnion ActionData { get; set; }

		// Token: 0x17006E3D RID: 28221
		// (get) Token: 0x06016365 RID: 90981 RVA: 0x0032F181 File Offset: 0x0032D381
		// (set) Token: 0x06016366 RID: 90982 RVA: 0x0032F189 File Offset: 0x0032D389
		public IShowTimelineActionDisplayConfigT DisplayConfig { get; set; }

		// Token: 0x06016367 RID: 90983 RVA: 0x0032F192 File Offset: 0x0032D392
		public IShowTimelineActionT()
		{
			this.Type = EShowTimelineType.Checkpoint;
			this.ActionType = EShowTimelineActionType.Skill;
			this.ActionParam = 0;
			this.ActionData = null;
			this.DisplayConfig = null;
		}
	}
}
