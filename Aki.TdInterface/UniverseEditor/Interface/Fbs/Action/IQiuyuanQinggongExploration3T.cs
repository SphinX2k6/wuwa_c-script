using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007562 RID: 30050
	public class IQiuyuanQinggongExploration3T
	{
		// Token: 0x1700DCFE RID: 56574
		// (get) Token: 0x06034B1D RID: 215837 RVA: 0x00716502 File Offset: 0x00714702
		// (set) Token: 0x06034B1E RID: 215838 RVA: 0x0071650A File Offset: 0x0071470A
		public ELeisureInteract Type { get; set; }

		// Token: 0x06034B1F RID: 215839 RVA: 0x00716513 File Offset: 0x00714713
		public IQiuyuanQinggongExploration3T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
