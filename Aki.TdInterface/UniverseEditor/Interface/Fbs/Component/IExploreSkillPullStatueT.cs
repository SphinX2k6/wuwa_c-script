using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005764 RID: 22372
	public class IExploreSkillPullStatueT
	{
		// Token: 0x1700A1BB RID: 41403
		// (get) Token: 0x0602412C RID: 147756 RVA: 0x004F6375 File Offset: 0x004F4575
		// (set) Token: 0x0602412D RID: 147757 RVA: 0x004F637D File Offset: 0x004F457D
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x1700A1BC RID: 41404
		// (get) Token: 0x0602412E RID: 147758 RVA: 0x004F6386 File Offset: 0x004F4586
		// (set) Token: 0x0602412F RID: 147759 RVA: 0x004F638E File Offset: 0x004F458E
		public ICategoryMatchingConditionT Condition { get; set; }

		// Token: 0x1700A1BD RID: 41405
		// (get) Token: 0x06024130 RID: 147760 RVA: 0x004F6397 File Offset: 0x004F4597
		// (set) Token: 0x06024131 RID: 147761 RVA: 0x004F639F File Offset: 0x004F459F
		public int StatueInteractPointId { get; set; }

		// Token: 0x06024132 RID: 147762 RVA: 0x004F63A8 File Offset: 0x004F45A8
		public IExploreSkillPullStatueT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.Condition = null;
			this.StatueInteractPointId = 0;
		}
	}
}
