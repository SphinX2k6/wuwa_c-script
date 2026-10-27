using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F77 RID: 20343
	public class IChangeTemplateInstanceStateConfigT
	{
		// Token: 0x17009305 RID: 37637
		// (get) Token: 0x060204AB RID: 132267 RVA: 0x0047E3CF File Offset: 0x0047C5CF
		// (set) Token: 0x060204AC RID: 132268 RVA: 0x0047E3D7 File Offset: 0x0047C5D7
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009306 RID: 37638
		// (get) Token: 0x060204AD RID: 132269 RVA: 0x0047E3E0 File Offset: 0x0047C5E0
		// (set) Token: 0x060204AE RID: 132270 RVA: 0x0047E3E8 File Offset: 0x0047C5E8
		public string State { get; set; }

		// Token: 0x060204AF RID: 132271 RVA: 0x0047E3F1 File Offset: 0x0047C5F1
		public IChangeTemplateInstanceStateConfigT()
		{
			this.Condition = null;
			this.State = null;
		}
	}
}
