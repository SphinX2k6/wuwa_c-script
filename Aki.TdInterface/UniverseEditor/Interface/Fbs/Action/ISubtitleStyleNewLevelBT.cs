using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200722D RID: 29229
	public class ISubtitleStyleNewLevelBT
	{
		// Token: 0x1700D8F1 RID: 55537
		// (get) Token: 0x06033D90 RID: 212368 RVA: 0x006F9F8E File Offset: 0x006F818E
		// (set) Token: 0x06033D91 RID: 212369 RVA: 0x006F9F96 File Offset: 0x006F8196
		public ESubtitleStyle Type { get; set; }

		// Token: 0x06033D92 RID: 212370 RVA: 0x006F9F9F File Offset: 0x006F819F
		public ISubtitleStyleNewLevelBT()
		{
			this.Type = ESubtitleStyle.LevelA;
		}
	}
}
