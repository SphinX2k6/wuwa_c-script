using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DA4 RID: 15780
	public class ICompareVarConditionInQuestFailedT
	{
		// Token: 0x17006C92 RID: 27794
		// (get) Token: 0x06015EFE RID: 89854 RVA: 0x0032AF07 File Offset: 0x00329107
		// (set) Token: 0x06015EFF RID: 89855 RVA: 0x0032AF0F File Offset: 0x0032910F
		public EConditionCount Count { get; set; }

		// Token: 0x17006C93 RID: 27795
		// (get) Token: 0x06015F00 RID: 89856 RVA: 0x0032AF18 File Offset: 0x00329118
		// (set) Token: 0x06015F01 RID: 89857 RVA: 0x0032AF20 File Offset: 0x00329120
		public List<ICompareVarInChildQuestT> Conditions { get; set; }

		// Token: 0x06015F02 RID: 89858 RVA: 0x0032AF29 File Offset: 0x00329129
		public ICompareVarConditionInQuestFailedT()
		{
			this.Count = EConditionCount.All;
			this.Conditions = null;
		}
	}
}
