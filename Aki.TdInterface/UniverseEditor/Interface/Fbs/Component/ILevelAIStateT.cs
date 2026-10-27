using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054DD RID: 21725
	public class ILevelAIStateT
	{
		// Token: 0x1700A031 RID: 41009
		// (get) Token: 0x06023D34 RID: 146740 RVA: 0x004F3FBC File Offset: 0x004F21BC
		// (set) Token: 0x06023D35 RID: 146741 RVA: 0x004F3FC4 File Offset: 0x004F21C4
		public int StateId { get; set; }

		// Token: 0x1700A032 RID: 41010
		// (get) Token: 0x06023D36 RID: 146742 RVA: 0x004F3FCD File Offset: 0x004F21CD
		// (set) Token: 0x06023D37 RID: 146743 RVA: 0x004F3FD5 File Offset: 0x004F21D5
		public string StateName { get; set; }

		// Token: 0x1700A033 RID: 41011
		// (get) Token: 0x06023D38 RID: 146744 RVA: 0x004F3FDE File Offset: 0x004F21DE
		// (set) Token: 0x06023D39 RID: 146745 RVA: 0x004F3FE6 File Offset: 0x004F21E6
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700A034 RID: 41012
		// (get) Token: 0x06023D3A RID: 146746 RVA: 0x004F3FEF File Offset: 0x004F21EF
		// (set) Token: 0x06023D3B RID: 146747 RVA: 0x004F3FF7 File Offset: 0x004F21F7
		public TLevelAIBehaviourUnion Behaviour { get; set; }

		// Token: 0x06023D3C RID: 146748 RVA: 0x004F4000 File Offset: 0x004F2200
		public ILevelAIStateT()
		{
			this.StateId = 0;
			this.StateName = null;
			this.Condition = null;
			this.Behaviour = null;
		}
	}
}
