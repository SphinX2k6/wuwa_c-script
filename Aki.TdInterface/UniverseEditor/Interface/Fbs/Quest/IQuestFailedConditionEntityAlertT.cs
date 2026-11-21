using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200441C RID: 17436
	public class IQuestFailedConditionEntityAlertT
	{
		// Token: 0x170078BF RID: 30911
		// (get) Token: 0x06018F00 RID: 102144 RVA: 0x0038EA21 File Offset: 0x0038CC21
		// (set) Token: 0x06018F01 RID: 102145 RVA: 0x0038EA29 File Offset: 0x0038CC29
		public List<int> EntityIds { get; set; }

		// Token: 0x06018F02 RID: 102146 RVA: 0x0038EA32 File Offset: 0x0038CC32
		public IQuestFailedConditionEntityAlertT()
		{
			this.EntityIds = null;
		}
	}
}
