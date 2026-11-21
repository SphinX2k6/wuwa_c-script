using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058D1 RID: 22737
	public class IGroupDestroyListenConfigT
	{
		// Token: 0x1700A4E7 RID: 42215
		// (get) Token: 0x06024ED2 RID: 151250 RVA: 0x00511FD3 File Offset: 0x005101D3
		// (set) Token: 0x06024ED3 RID: 151251 RVA: 0x00511FDB File Offset: 0x005101DB
		public ETemplateEntityGroupType GroupType { get; set; }

		// Token: 0x1700A4E8 RID: 42216
		// (get) Token: 0x06024ED4 RID: 151252 RVA: 0x00511FE4 File Offset: 0x005101E4
		// (set) Token: 0x06024ED5 RID: 151253 RVA: 0x00511FEC File Offset: 0x005101EC
		public List<IActionInfoT> OnTriggerActions { get; set; }

		// Token: 0x1700A4E9 RID: 42217
		// (get) Token: 0x06024ED6 RID: 151254 RVA: 0x00511FF5 File Offset: 0x005101F5
		// (set) Token: 0x06024ED7 RID: 151255 RVA: 0x00511FFD File Offset: 0x005101FD
		public IChangeTemplateInstanceStateConfigT ChangeInstanceStateConfig { get; set; }

		// Token: 0x06024ED8 RID: 151256 RVA: 0x00512006 File Offset: 0x00510206
		public IGroupDestroyListenConfigT()
		{
			this.GroupType = ETemplateEntityGroupType.None;
			this.OnTriggerActions = null;
			this.ChangeInstanceStateConfig = null;
		}
	}
}
