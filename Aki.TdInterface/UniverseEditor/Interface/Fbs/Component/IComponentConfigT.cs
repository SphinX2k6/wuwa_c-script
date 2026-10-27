using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FE0 RID: 20448
	public class IComponentConfigT
	{
		// Token: 0x17009426 RID: 37926
		// (get) Token: 0x06020ACB RID: 133835 RVA: 0x0048B12B File Offset: 0x0048932B
		// (set) Token: 0x06020ACC RID: 133836 RVA: 0x0048B133 File Offset: 0x00489333
		public List<EAction> BaseActions { get; set; }

		// Token: 0x17009427 RID: 37927
		// (get) Token: 0x06020ACD RID: 133837 RVA: 0x0048B13C File Offset: 0x0048933C
		// (set) Token: 0x06020ACE RID: 133838 RVA: 0x0048B144 File Offset: 0x00489344
		public string ActionsByComponent { get; set; }

		// Token: 0x06020ACF RID: 133839 RVA: 0x0048B14D File Offset: 0x0048934D
		public IComponentConfigT()
		{
			this.BaseActions = null;
			this.ActionsByComponent = null;
		}
	}
}
