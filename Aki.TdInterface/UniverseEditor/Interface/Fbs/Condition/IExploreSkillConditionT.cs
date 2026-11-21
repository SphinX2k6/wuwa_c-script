using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005110 RID: 20752
	public class IExploreSkillConditionT
	{
		// Token: 0x170094B9 RID: 38073
		// (get) Token: 0x060209F9 RID: 133625 RVA: 0x00485D62 File Offset: 0x00483F62
		// (set) Token: 0x060209FA RID: 133626 RVA: 0x00485D6A File Offset: 0x00483F6A
		public EExploreSkillConditionType Type { get; set; }

		// Token: 0x060209FB RID: 133627 RVA: 0x00485D73 File Offset: 0x00483F73
		public IExploreSkillConditionT()
		{
			this.Type = EExploreSkillConditionType.PlayerAirBubbleEnabled;
		}
	}
}
