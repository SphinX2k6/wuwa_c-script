using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E31 RID: 15921
	public class IFinishBvbChallengeT
	{
		// Token: 0x17006E17 RID: 28183
		// (get) Token: 0x06016513 RID: 91411 RVA: 0x00338D05 File Offset: 0x00336F05
		// (set) Token: 0x06016514 RID: 91412 RVA: 0x00338D0D File Offset: 0x00336F0D
		public EChildQuest Type { get; set; }

		// Token: 0x17006E18 RID: 28184
		// (get) Token: 0x06016515 RID: 91413 RVA: 0x00338D16 File Offset: 0x00336F16
		// (set) Token: 0x06016516 RID: 91414 RVA: 0x00338D1E File Offset: 0x00336F1E
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006E19 RID: 28185
		// (get) Token: 0x06016517 RID: 91415 RVA: 0x00338D27 File Offset: 0x00336F27
		// (set) Token: 0x06016518 RID: 91416 RVA: 0x00338D2F File Offset: 0x00336F2F
		public int BvbChallengeId { get; set; }

		// Token: 0x06016519 RID: 91417 RVA: 0x00338D38 File Offset: 0x00336F38
		public IFinishBvbChallengeT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.BvbChallengeId = 0;
		}
	}
}
