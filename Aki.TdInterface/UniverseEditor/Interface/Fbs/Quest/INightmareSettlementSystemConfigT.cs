using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F5D RID: 16221
	public class INightmareSettlementSystemConfigT
	{
		// Token: 0x170070CD RID: 28877
		// (get) Token: 0x06017128 RID: 94504 RVA: 0x0035372B File Offset: 0x0035192B
		// (set) Token: 0x06017129 RID: 94505 RVA: 0x00353733 File Offset: 0x00351933
		public EEnableSystemType Type { get; set; }

		// Token: 0x170070CE RID: 28878
		// (get) Token: 0x0601712A RID: 94506 RVA: 0x0035373C File Offset: 0x0035193C
		// (set) Token: 0x0601712B RID: 94507 RVA: 0x00353744 File Offset: 0x00351944
		public List<INightmareSettlementSystemVarT> SystemVars { get; set; }

		// Token: 0x0601712C RID: 94508 RVA: 0x0035374D File Offset: 0x0035194D
		public INightmareSettlementSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.SystemVars = null;
		}
	}
}
