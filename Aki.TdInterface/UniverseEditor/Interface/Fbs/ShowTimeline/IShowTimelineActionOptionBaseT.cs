using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BA2 RID: 15266
	public class IShowTimelineActionOptionBaseT
	{
		// Token: 0x170068AC RID: 26796
		// (get) Token: 0x06014ED5 RID: 85717 RVA: 0x00309256 File Offset: 0x00307456
		// (set) Token: 0x06014ED6 RID: 85718 RVA: 0x0030925E File Offset: 0x0030745E
		public EShowTimelineActionType Type { get; set; }

		// Token: 0x06014ED7 RID: 85719 RVA: 0x00309267 File Offset: 0x00307467
		public IShowTimelineActionOptionBaseT()
		{
			this.Type = EShowTimelineActionType.Skill;
		}
	}
}
