using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C1D RID: 19485
	public class IEntityModelConfigT
	{
		// Token: 0x17008A1C RID: 35356
		// (get) Token: 0x0601DD3C RID: 122172 RVA: 0x0042EF65 File Offset: 0x0042D165
		// (set) Token: 0x0601DD3D RID: 122173 RVA: 0x0042EF6D File Offset: 0x0042D16D
		public List<IEntityModelT> Models { get; set; }

		// Token: 0x0601DD3E RID: 122174 RVA: 0x0042EF76 File Offset: 0x0042D176
		public IEntityModelConfigT()
		{
			this.Models = null;
		}
	}
}
