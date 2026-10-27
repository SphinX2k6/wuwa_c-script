using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E34 RID: 15924
	public class IFinishDungeonQuestConditionT
	{
		// Token: 0x17006E1E RID: 28190
		// (get) Token: 0x06016531 RID: 91441 RVA: 0x0033916D File Offset: 0x0033736D
		// (set) Token: 0x06016532 RID: 91442 RVA: 0x00339175 File Offset: 0x00337375
		public EChildQuest Type { get; set; }

		// Token: 0x17006E1F RID: 28191
		// (get) Token: 0x06016533 RID: 91443 RVA: 0x0033917E File Offset: 0x0033737E
		// (set) Token: 0x06016534 RID: 91444 RVA: 0x00339186 File Offset: 0x00337386
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006E20 RID: 28192
		// (get) Token: 0x06016535 RID: 91445 RVA: 0x0033918F File Offset: 0x0033738F
		// (set) Token: 0x06016536 RID: 91446 RVA: 0x00339197 File Offset: 0x00337397
		public TDungeonConditionTypeUnion Condition { get; set; }

		// Token: 0x06016537 RID: 91447 RVA: 0x003391A0 File Offset: 0x003373A0
		public IFinishDungeonQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Condition = null;
		}
	}
}
