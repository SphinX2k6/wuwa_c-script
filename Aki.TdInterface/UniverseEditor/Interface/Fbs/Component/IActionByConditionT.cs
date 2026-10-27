using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E42 RID: 20034
	public class IActionByConditionT
	{
		// Token: 0x17008F60 RID: 36704
		// (get) Token: 0x0601F6FA RID: 128762 RVA: 0x004611BC File Offset: 0x0045F3BC
		// (set) Token: 0x0601F6FB RID: 128763 RVA: 0x004611C4 File Offset: 0x0045F3C4
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17008F61 RID: 36705
		// (get) Token: 0x0601F6FC RID: 128764 RVA: 0x004611CD File Offset: 0x0045F3CD
		// (set) Token: 0x0601F6FD RID: 128765 RVA: 0x004611D5 File Offset: 0x0045F3D5
		public List<IActionInfoT> ActiveActions { get; set; }

		// Token: 0x0601F6FE RID: 128766 RVA: 0x004611DE File Offset: 0x0045F3DE
		public IActionByConditionT()
		{
			this.Condition = null;
			this.ActiveActions = null;
		}
	}
}
