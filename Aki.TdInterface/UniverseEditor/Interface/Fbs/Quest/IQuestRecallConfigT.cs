using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200444C RID: 17484
	public class IQuestRecallConfigT
	{
		// Token: 0x17007936 RID: 31030
		// (get) Token: 0x06019131 RID: 102705 RVA: 0x00393A3F File Offset: 0x00391C3F
		// (set) Token: 0x06019132 RID: 102706 RVA: 0x00393A47 File Offset: 0x00391C47
		public int RecallId { get; set; }

		// Token: 0x17007937 RID: 31031
		// (get) Token: 0x06019133 RID: 102707 RVA: 0x00393A50 File Offset: 0x00391C50
		// (set) Token: 0x06019134 RID: 102708 RVA: 0x00393A58 File Offset: 0x00391C58
		public List<IRecallEntityListT> RecallEntityList { get; set; }

		// Token: 0x06019135 RID: 102709 RVA: 0x00393A61 File Offset: 0x00391C61
		public IQuestRecallConfigT()
		{
			this.RecallId = 0;
			this.RecallEntityList = null;
		}
	}
}
