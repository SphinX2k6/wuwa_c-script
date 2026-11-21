using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200441F RID: 17439
	public class IQuestFailedConditionEntityDeathT
	{
		// Token: 0x170078C2 RID: 30914
		// (get) Token: 0x06018F1A RID: 102170 RVA: 0x0038ECC5 File Offset: 0x0038CEC5
		// (set) Token: 0x06018F1B RID: 102171 RVA: 0x0038ECCD File Offset: 0x0038CECD
		public List<int> EntityIds { get; set; }

		// Token: 0x06018F1C RID: 102172 RVA: 0x0038ECD6 File Offset: 0x0038CED6
		public IQuestFailedConditionEntityDeathT()
		{
			this.EntityIds = null;
		}
	}
}
