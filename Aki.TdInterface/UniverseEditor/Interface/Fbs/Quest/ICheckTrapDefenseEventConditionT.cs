using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004197 RID: 16791
	public class ICheckTrapDefenseEventConditionT
	{
		// Token: 0x170071C4 RID: 29124
		// (get) Token: 0x06017207 RID: 94727 RVA: 0x0034BB09 File Offset: 0x00349D09
		// (set) Token: 0x06017208 RID: 94728 RVA: 0x0034BB11 File Offset: 0x00349D11
		public EChildQuest Type { get; set; }

		// Token: 0x170071C5 RID: 29125
		// (get) Token: 0x06017209 RID: 94729 RVA: 0x0034BB1A File Offset: 0x00349D1A
		// (set) Token: 0x0601720A RID: 94730 RVA: 0x0034BB22 File Offset: 0x00349D22
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170071C6 RID: 29126
		// (get) Token: 0x0601720B RID: 94731 RVA: 0x0034BB2B File Offset: 0x00349D2B
		// (set) Token: 0x0601720C RID: 94732 RVA: 0x0034BB33 File Offset: 0x00349D33
		public TCheckTrapDefenseEventUnion Config { get; set; }

		// Token: 0x0601720D RID: 94733 RVA: 0x0034BB3C File Offset: 0x00349D3C
		public ICheckTrapDefenseEventConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Config = null;
		}
	}
}
