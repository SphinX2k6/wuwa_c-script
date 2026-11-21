using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AFB RID: 31483
	public class ITalkOptionConditionT
	{
		// Token: 0x1700EBEB RID: 60395
		// (get) Token: 0x06038B25 RID: 232229 RVA: 0x007ABABF File Offset: 0x007A9CBF
		// (set) Token: 0x06038B26 RID: 232230 RVA: 0x007ABAC7 File Offset: 0x007A9CC7
		public ETalkOptionPreConditionType Type { get; set; }

		// Token: 0x1700EBEC RID: 60396
		// (get) Token: 0x06038B27 RID: 232231 RVA: 0x007ABAD0 File Offset: 0x007A9CD0
		// (set) Token: 0x06038B28 RID: 232232 RVA: 0x007ABAD8 File Offset: 0x007A9CD8
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x06038B29 RID: 232233 RVA: 0x007ABAE1 File Offset: 0x007A9CE1
		public ITalkOptionConditionT()
		{
			this.Type = ETalkOptionPreConditionType.PreOption;
			this.Conditions = null;
		}
	}
}
