using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051F3 RID: 20979
	public class IExploreSkillLonelyDollPollutantT
	{
		// Token: 0x170099A8 RID: 39336
		// (get) Token: 0x0602212C RID: 139564 RVA: 0x004BA9C2 File Offset: 0x004B8BC2
		// (set) Token: 0x0602212D RID: 139565 RVA: 0x004BA9CA File Offset: 0x004B8BCA
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x0602212E RID: 139566 RVA: 0x004BA9D3 File Offset: 0x004B8BD3
		public IExploreSkillLonelyDollPollutantT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
		}
	}
}
