using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006345 RID: 25413
	public class IAllEntityGravityDirectionConfigT
	{
		// Token: 0x1700BBE5 RID: 48101
		// (get) Token: 0x0602B18D RID: 176525 RVA: 0x005DFC51 File Offset: 0x005DDE51
		// (set) Token: 0x0602B18E RID: 176526 RVA: 0x005DFC59 File Offset: 0x005DDE59
		public List<IEntityDirectionConfigT> AllConfig { get; set; }

		// Token: 0x0602B18F RID: 176527 RVA: 0x005DFC62 File Offset: 0x005DDE62
		public IAllEntityGravityDirectionConfigT()
		{
			this.AllConfig = null;
		}
	}
}
