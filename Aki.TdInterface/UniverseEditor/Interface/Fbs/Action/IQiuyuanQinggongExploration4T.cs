using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007565 RID: 30053
	public class IQiuyuanQinggongExploration4T
	{
		// Token: 0x1700DD01 RID: 56577
		// (get) Token: 0x06034B2F RID: 215855 RVA: 0x0071667A File Offset: 0x0071487A
		// (set) Token: 0x06034B30 RID: 215856 RVA: 0x00716682 File Offset: 0x00714882
		public ELeisureInteract Type { get; set; }

		// Token: 0x06034B31 RID: 215857 RVA: 0x0071668B File Offset: 0x0071488B
		public IQiuyuanQinggongExploration4T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
