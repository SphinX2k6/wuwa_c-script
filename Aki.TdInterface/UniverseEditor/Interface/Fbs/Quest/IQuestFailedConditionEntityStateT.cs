using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004422 RID: 17442
	public class IQuestFailedConditionEntityStateT
	{
		// Token: 0x170078C5 RID: 30917
		// (get) Token: 0x06018F32 RID: 102194 RVA: 0x0038EFC9 File Offset: 0x0038D1C9
		// (set) Token: 0x06018F33 RID: 102195 RVA: 0x0038EFD1 File Offset: 0x0038D1D1
		public List<IEntityStateConditionT> Conditions { get; set; }

		// Token: 0x06018F34 RID: 102196 RVA: 0x0038EFDA File Offset: 0x0038D1DA
		public IQuestFailedConditionEntityStateT()
		{
			this.Conditions = null;
		}
	}
}
