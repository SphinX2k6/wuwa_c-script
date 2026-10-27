using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005130 RID: 20784
	public class IElementalMatchActionsT
	{
		// Token: 0x17009784 RID: 38788
		// (get) Token: 0x06021866 RID: 137318 RVA: 0x004A7B66 File Offset: 0x004A5D66
		// (set) Token: 0x06021867 RID: 137319 RVA: 0x004A7B6E File Offset: 0x004A5D6E
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009785 RID: 38789
		// (get) Token: 0x06021868 RID: 137320 RVA: 0x004A7B77 File Offset: 0x004A5D77
		// (set) Token: 0x06021869 RID: 137321 RVA: 0x004A7B7F File Offset: 0x004A5D7F
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x17009786 RID: 38790
		// (get) Token: 0x0602186A RID: 137322 RVA: 0x004A7B88 File Offset: 0x004A5D88
		// (set) Token: 0x0602186B RID: 137323 RVA: 0x004A7B90 File Offset: 0x004A5D90
		public byte NullMask { get; set; }

		// Token: 0x0602186C RID: 137324 RVA: 0x004A7B99 File Offset: 0x004A5D99
		public IElementalMatchActionsT()
		{
			this.Condition = null;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
