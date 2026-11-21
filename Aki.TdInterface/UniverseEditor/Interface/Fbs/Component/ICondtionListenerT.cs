using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200555D RID: 21853
	public class ICondtionListenerT
	{
		// Token: 0x17009C46 RID: 40006
		// (get) Token: 0x06022B11 RID: 142097 RVA: 0x004C76C0 File Offset: 0x004C58C0
		// (set) Token: 0x06022B12 RID: 142098 RVA: 0x004C76C8 File Offset: 0x004C58C8
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009C47 RID: 40007
		// (get) Token: 0x06022B13 RID: 142099 RVA: 0x004C76D1 File Offset: 0x004C58D1
		// (set) Token: 0x06022B14 RID: 142100 RVA: 0x004C76D9 File Offset: 0x004C58D9
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x17009C48 RID: 40008
		// (get) Token: 0x06022B15 RID: 142101 RVA: 0x004C76E2 File Offset: 0x004C58E2
		// (set) Token: 0x06022B16 RID: 142102 RVA: 0x004C76EA File Offset: 0x004C58EA
		public bool PendingConditionAvailable { get; set; }

		// Token: 0x17009C49 RID: 40009
		// (get) Token: 0x06022B17 RID: 142103 RVA: 0x004C76F3 File Offset: 0x004C58F3
		// (set) Token: 0x06022B18 RID: 142104 RVA: 0x004C76FB File Offset: 0x004C58FB
		public List<IConditionActionT> ConditionAction { get; set; }

		// Token: 0x17009C4A RID: 40010
		// (get) Token: 0x06022B19 RID: 142105 RVA: 0x004C7704 File Offset: 0x004C5904
		// (set) Token: 0x06022B1A RID: 142106 RVA: 0x004C770C File Offset: 0x004C590C
		public byte NullMask { get; set; }

		// Token: 0x06022B1B RID: 142107 RVA: 0x004C7715 File Offset: 0x004C5915
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
