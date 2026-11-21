using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FCB RID: 16331
	public class IShowTimelineJumpT
	{
		// Token: 0x17006E95 RID: 28309
		// (get) Token: 0x060164ED RID: 91373 RVA: 0x003322C2 File Offset: 0x003304C2
		// (set) Token: 0x060164EE RID: 91374 RVA: 0x003322CA File Offset: 0x003304CA
		public EShowTimelineActionType Type { get; set; }

		// Token: 0x060164EF RID: 91375 RVA: 0x003322D3 File Offset: 0x003304D3
		public IShowTimelineJumpT()
		{
			this.Type = EShowTimelineActionType.Skill;
		}
	}
}
