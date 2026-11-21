using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A63 RID: 23139
	public class ILevelAIStateT
	{
		// Token: 0x1700A86B RID: 43115
		// (get) Token: 0x06025DEC RID: 155116 RVA: 0x00531030 File Offset: 0x0052F230
		// (set) Token: 0x06025DED RID: 155117 RVA: 0x00531038 File Offset: 0x0052F238
		public int StateId { get; set; }

		// Token: 0x1700A86C RID: 43116
		// (get) Token: 0x06025DEE RID: 155118 RVA: 0x00531041 File Offset: 0x0052F241
		// (set) Token: 0x06025DEF RID: 155119 RVA: 0x00531049 File Offset: 0x0052F249
		public string StateName { get; set; }

		// Token: 0x1700A86D RID: 43117
		// (get) Token: 0x06025DF0 RID: 155120 RVA: 0x00531052 File Offset: 0x0052F252
		// (set) Token: 0x06025DF1 RID: 155121 RVA: 0x0053105A File Offset: 0x0052F25A
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700A86E RID: 43118
		// (get) Token: 0x06025DF2 RID: 155122 RVA: 0x00531063 File Offset: 0x0052F263
		// (set) Token: 0x06025DF3 RID: 155123 RVA: 0x0053106B File Offset: 0x0052F26B
		public TLevelAIBehaviourUnion Behaviour { get; set; }

		// Token: 0x06025DF4 RID: 155124 RVA: 0x00531074 File Offset: 0x0052F274
		public ILevelAIStateT()
		{
			this.StateId = 0;
			this.StateName = null;
			this.Condition = null;
			this.Behaviour = null;
		}
	}
}
