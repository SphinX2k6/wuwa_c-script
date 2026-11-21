using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054A6 RID: 21670
	public class IChangeTemplateInstanceStateConfigT
	{
		// Token: 0x17009A7E RID: 39550
		// (get) Token: 0x060221FD RID: 139773 RVA: 0x004B43BF File Offset: 0x004B25BF
		// (set) Token: 0x060221FE RID: 139774 RVA: 0x004B43C7 File Offset: 0x004B25C7
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009A7F RID: 39551
		// (get) Token: 0x060221FF RID: 139775 RVA: 0x004B43D0 File Offset: 0x004B25D0
		// (set) Token: 0x06022200 RID: 139776 RVA: 0x004B43D8 File Offset: 0x004B25D8
		public string State { get; set; }

		// Token: 0x06022201 RID: 139777 RVA: 0x004B43E1 File Offset: 0x004B25E1
		public IChangeTemplateInstanceStateConfigT()
		{
			this.Condition = null;
			this.State = null;
		}
	}
}
