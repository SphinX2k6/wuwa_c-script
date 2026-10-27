using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FFE RID: 20478
	public class ICondtionListenerT
	{
		// Token: 0x17009465 RID: 37989
		// (get) Token: 0x06020BF1 RID: 134129 RVA: 0x0048DC70 File Offset: 0x0048BE70
		// (set) Token: 0x06020BF2 RID: 134130 RVA: 0x0048DC78 File Offset: 0x0048BE78
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009466 RID: 37990
		// (get) Token: 0x06020BF3 RID: 134131 RVA: 0x0048DC81 File Offset: 0x0048BE81
		// (set) Token: 0x06020BF4 RID: 134132 RVA: 0x0048DC89 File Offset: 0x0048BE89
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x17009467 RID: 37991
		// (get) Token: 0x06020BF5 RID: 134133 RVA: 0x0048DC92 File Offset: 0x0048BE92
		// (set) Token: 0x06020BF6 RID: 134134 RVA: 0x0048DC9A File Offset: 0x0048BE9A
		public bool PendingConditionAvailable { get; set; }

		// Token: 0x17009468 RID: 37992
		// (get) Token: 0x06020BF7 RID: 134135 RVA: 0x0048DCA3 File Offset: 0x0048BEA3
		// (set) Token: 0x06020BF8 RID: 134136 RVA: 0x0048DCAB File Offset: 0x0048BEAB
		public List<IConditionActionT> ConditionAction { get; set; }

		// Token: 0x17009469 RID: 37993
		// (get) Token: 0x06020BF9 RID: 134137 RVA: 0x0048DCB4 File Offset: 0x0048BEB4
		// (set) Token: 0x06020BFA RID: 134138 RVA: 0x0048DCBC File Offset: 0x0048BEBC
		public byte NullMask { get; set; }

		// Token: 0x06020BFB RID: 134139 RVA: 0x0048DCC5 File Offset: 0x0048BEC5
		public ICondtionListenerT()
		{
			this.Condition = null;
			this.Actions = null;
			this.PendingConditionAvailable = false;
			this.ConditionAction = null;
			this.NullMask = 0;
		}
	}
}
