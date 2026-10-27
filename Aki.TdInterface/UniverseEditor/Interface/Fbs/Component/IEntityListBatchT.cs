using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200518A RID: 20874
	public class IEntityListBatchT
	{
		// Token: 0x17009880 RID: 39040
		// (get) Token: 0x06021C1D RID: 138269 RVA: 0x004AF06F File Offset: 0x004AD26F
		// (set) Token: 0x06021C1E RID: 138270 RVA: 0x004AF077 File Offset: 0x004AD277
		public EEntityBatchType Type { get; set; }

		// Token: 0x17009881 RID: 39041
		// (get) Token: 0x06021C1F RID: 138271 RVA: 0x004AF080 File Offset: 0x004AD280
		// (set) Token: 0x06021C20 RID: 138272 RVA: 0x004AF088 File Offset: 0x004AD288
		public List<int> EntityIds { get; set; }

		// Token: 0x06021C21 RID: 138273 RVA: 0x004AF091 File Offset: 0x004AD291
		public IEntityListBatchT()
		{
			this.Type = EEntityBatchType.EntityList;
			this.EntityIds = null;
		}
	}
}
