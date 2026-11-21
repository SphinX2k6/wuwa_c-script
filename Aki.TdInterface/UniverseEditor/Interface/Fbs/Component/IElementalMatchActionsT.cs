using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005695 RID: 22165
	public class IElementalMatchActionsT
	{
		// Token: 0x17009F71 RID: 40817
		// (get) Token: 0x060237BA RID: 145338 RVA: 0x004E1AF2 File Offset: 0x004DFCF2
		// (set) Token: 0x060237BB RID: 145339 RVA: 0x004E1AFA File Offset: 0x004DFCFA
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009F72 RID: 40818
		// (get) Token: 0x060237BC RID: 145340 RVA: 0x004E1B03 File Offset: 0x004DFD03
		// (set) Token: 0x060237BD RID: 145341 RVA: 0x004E1B0B File Offset: 0x004DFD0B
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x17009F73 RID: 40819
		// (get) Token: 0x060237BE RID: 145342 RVA: 0x004E1B14 File Offset: 0x004DFD14
		// (set) Token: 0x060237BF RID: 145343 RVA: 0x004E1B1C File Offset: 0x004DFD1C
		public byte NullMask { get; set; }

		// Token: 0x060237C0 RID: 145344 RVA: 0x004E1B25 File Offset: 0x004DFD25
		public IElementalMatchActionsT()
		{
			this.Condition = null;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
