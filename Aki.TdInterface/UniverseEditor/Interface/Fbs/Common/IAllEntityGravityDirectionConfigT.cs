using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D11 RID: 23825
	public class IAllEntityGravityDirectionConfigT
	{
		// Token: 0x1700B289 RID: 45705
		// (get) Token: 0x06028B39 RID: 166713 RVA: 0x005973E1 File Offset: 0x005955E1
		// (set) Token: 0x06028B3A RID: 166714 RVA: 0x005973E9 File Offset: 0x005955E9
		public List<IEntityDirectionConfigT> AllConfig { get; set; }

		// Token: 0x06028B3B RID: 166715 RVA: 0x005973F2 File Offset: 0x005955F2
		public IAllEntityGravityDirectionConfigT()
		{
			this.AllConfig = null;
		}
	}
}
