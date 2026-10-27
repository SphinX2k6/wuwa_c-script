using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BC3 RID: 15299
	public class IShowTimelineJumpT
	{
		// Token: 0x170068F2 RID: 26866
		// (get) Token: 0x06015015 RID: 86037 RVA: 0x0030BA66 File Offset: 0x00309C66
		// (set) Token: 0x06015016 RID: 86038 RVA: 0x0030BA6E File Offset: 0x00309C6E
		public EShowTimelineActionType Type { get; set; }

		// Token: 0x06015017 RID: 86039 RVA: 0x0030BA77 File Offset: 0x00309C77
		public IShowTimelineJumpT()
		{
			this.Type = EShowTimelineActionType.Skill;
		}
	}
}
