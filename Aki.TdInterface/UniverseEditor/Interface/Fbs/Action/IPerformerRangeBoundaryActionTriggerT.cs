using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073F8 RID: 29688
	public class IPerformerRangeBoundaryActionTriggerT
	{
		// Token: 0x1700DA12 RID: 55826
		// (get) Token: 0x06033F00 RID: 212736 RVA: 0x0070091F File Offset: 0x006FEB1F
		// (set) Token: 0x06033F01 RID: 212737 RVA: 0x00700927 File Offset: 0x006FEB27
		public int Range { get; set; }

		// Token: 0x1700DA13 RID: 55827
		// (get) Token: 0x06033F02 RID: 212738 RVA: 0x00700930 File Offset: 0x006FEB30
		// (set) Token: 0x06033F03 RID: 212739 RVA: 0x00700938 File Offset: 0x006FEB38
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x06033F04 RID: 212740 RVA: 0x00700941 File Offset: 0x006FEB41
		public IPerformerRangeBoundaryActionTriggerT()
		{
			this.Range = 0;
			this.Actions = null;
		}
	}
}
