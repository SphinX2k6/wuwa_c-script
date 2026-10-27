using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047B5 RID: 18357
	public class IEntityModelConfigT
	{
		// Token: 0x170083DB RID: 33755
		// (get) Token: 0x0601C567 RID: 116071 RVA: 0x00402CC9 File Offset: 0x00400EC9
		// (set) Token: 0x0601C568 RID: 116072 RVA: 0x00402CD1 File Offset: 0x00400ED1
		public List<IEntityModelT> Models { get; set; }

		// Token: 0x0601C569 RID: 116073 RVA: 0x00402CDA File Offset: 0x00400EDA
		public IEntityModelConfigT()
		{
			this.Models = null;
		}
	}
}
