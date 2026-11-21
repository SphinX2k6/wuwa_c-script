using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A02 RID: 31234
	public class ISubtitleStyleNewLevelBT
	{
		// Token: 0x1700E4EA RID: 58602
		// (get) Token: 0x06037092 RID: 225426 RVA: 0x0075B2EE File Offset: 0x007594EE
		// (set) Token: 0x06037093 RID: 225427 RVA: 0x0075B2F6 File Offset: 0x007594F6
		public ESubtitleStyle Type { get; set; }

		// Token: 0x06037094 RID: 225428 RVA: 0x0075B2FF File Offset: 0x007594FF
		public ISubtitleStyleNewLevelBT()
		{
			this.Type = ESubtitleStyle.LevelA;
		}
	}
}
