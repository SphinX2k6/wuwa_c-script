using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200575B RID: 22363
	public class IExploreSkillLonelyDollPollutantT
	{
		// Token: 0x1700A1A4 RID: 41380
		// (get) Token: 0x060240C2 RID: 147650 RVA: 0x004F5486 File Offset: 0x004F3686
		// (set) Token: 0x060240C3 RID: 147651 RVA: 0x004F548E File Offset: 0x004F368E
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x060240C4 RID: 147652 RVA: 0x004F5497 File Offset: 0x004F3697
		public IExploreSkillLonelyDollPollutantT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
		}
	}
}
