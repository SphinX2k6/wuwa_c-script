using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FAA RID: 16298
	public class IShowTimelineActionOptionBaseT
	{
		// Token: 0x17006E4B RID: 28235
		// (get) Token: 0x0601639F RID: 91039 RVA: 0x0032F7EE File Offset: 0x0032D9EE
		// (set) Token: 0x060163A0 RID: 91040 RVA: 0x0032F7F6 File Offset: 0x0032D9F6
		public EShowTimelineActionType Type { get; set; }

		// Token: 0x060163A1 RID: 91041 RVA: 0x0032F7FF File Offset: 0x0032D9FF
		public IShowTimelineActionOptionBaseT()
		{
			this.Type = EShowTimelineActionType.Skill;
		}
	}
}
