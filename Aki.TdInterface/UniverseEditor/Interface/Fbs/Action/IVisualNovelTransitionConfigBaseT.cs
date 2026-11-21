using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DEF RID: 32239
	public class IVisualNovelTransitionConfigBaseT
	{
		// Token: 0x1700F181 RID: 61825
		// (get) Token: 0x0603A431 RID: 238641 RVA: 0x007D9C4E File Offset: 0x007D7E4E
		// (set) Token: 0x0603A432 RID: 238642 RVA: 0x007D9C56 File Offset: 0x007D7E56
		public EVisualNovelTransitionType Type { get; set; }

		// Token: 0x0603A433 RID: 238643 RVA: 0x007D9C5F File Offset: 0x007D7E5F
		public IVisualNovelTransitionConfigBaseT()
		{
			this.Type = EVisualNovelTransitionType.Location;
		}
	}
}
