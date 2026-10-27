using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200534B RID: 21323
	public class IGroupDestroyListenConfigT
	{
		// Token: 0x17009CAF RID: 40111
		// (get) Token: 0x06022E1E RID: 142878 RVA: 0x004D50FF File Offset: 0x004D32FF
		// (set) Token: 0x06022E1F RID: 142879 RVA: 0x004D5107 File Offset: 0x004D3307
		public ETemplateEntityGroupType GroupType { get; set; }

		// Token: 0x17009CB0 RID: 40112
		// (get) Token: 0x06022E20 RID: 142880 RVA: 0x004D5110 File Offset: 0x004D3310
		// (set) Token: 0x06022E21 RID: 142881 RVA: 0x004D5118 File Offset: 0x004D3318
		public List<IActionInfoT> OnTriggerActions { get; set; }

		// Token: 0x17009CB1 RID: 40113
		// (get) Token: 0x06022E22 RID: 142882 RVA: 0x004D5121 File Offset: 0x004D3321
		// (set) Token: 0x06022E23 RID: 142883 RVA: 0x004D5129 File Offset: 0x004D3329
		public IChangeTemplateInstanceStateConfigT ChangeInstanceStateConfig { get; set; }

		// Token: 0x06022E24 RID: 142884 RVA: 0x004D5132 File Offset: 0x004D3332
		public IGroupDestroyListenConfigT()
		{
			this.GroupType = ETemplateEntityGroupType.None;
			this.OnTriggerActions = null;
			this.ChangeInstanceStateConfig = null;
		}
	}
}
