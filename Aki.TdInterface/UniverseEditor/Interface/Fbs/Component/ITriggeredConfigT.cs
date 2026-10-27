using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AE5 RID: 23269
	public class ITriggeredConfigT
	{
		// Token: 0x1700AF78 RID: 44920
		// (get) Token: 0x06027B54 RID: 162644 RVA: 0x005765DA File Offset: 0x005747DA
		// (set) Token: 0x06027B55 RID: 162645 RVA: 0x005765E2 File Offset: 0x005747E2
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700AF79 RID: 44921
		// (get) Token: 0x06027B56 RID: 162646 RVA: 0x005765EB File Offset: 0x005747EB
		// (set) Token: 0x06027B57 RID: 162647 RVA: 0x005765F3 File Offset: 0x005747F3
		public int MaxTriggerTimes { get; set; }

		// Token: 0x1700AF7A RID: 44922
		// (get) Token: 0x06027B58 RID: 162648 RVA: 0x005765FC File Offset: 0x005747FC
		// (set) Token: 0x06027B59 RID: 162649 RVA: 0x00576604 File Offset: 0x00574804
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700AF7B RID: 44923
		// (get) Token: 0x06027B5A RID: 162650 RVA: 0x0057660D File Offset: 0x0057480D
		// (set) Token: 0x06027B5B RID: 162651 RVA: 0x00576615 File Offset: 0x00574815
		public bool OnlineDisableTip { get; set; }

		// Token: 0x1700AF7C RID: 44924
		// (get) Token: 0x06027B5C RID: 162652 RVA: 0x0057661E File Offset: 0x0057481E
		// (set) Token: 0x06027B5D RID: 162653 RVA: 0x00576626 File Offset: 0x00574826
		public byte NullMask { get; set; }

		// Token: 0x06027B5E RID: 162654 RVA: 0x0057662F File Offset: 0x0057482F
		public ITriggeredConfigT()
		{
			this.Condition = null;
			this.MaxTriggerTimes = 0;
			this.Actions = null;
			this.OnlineDisableTip = false;
			this.NullMask = 0;
		}
	}
}
