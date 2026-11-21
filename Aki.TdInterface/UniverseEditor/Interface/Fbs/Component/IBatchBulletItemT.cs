using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200542E RID: 21550
	public class IBatchBulletItemT
	{
		// Token: 0x17009902 RID: 39170
		// (get) Token: 0x06021C8A RID: 138378 RVA: 0x004A8677 File Offset: 0x004A6877
		// (set) Token: 0x06021C8B RID: 138379 RVA: 0x004A867F File Offset: 0x004A687F
		public int Time { get; set; }

		// Token: 0x17009903 RID: 39171
		// (get) Token: 0x06021C8C RID: 138380 RVA: 0x004A8688 File Offset: 0x004A6888
		// (set) Token: 0x06021C8D RID: 138381 RVA: 0x004A8690 File Offset: 0x004A6890
		public List<IBatchBulletCasterT> CasterList { get; set; }

		// Token: 0x06021C8E RID: 138382 RVA: 0x004A8699 File Offset: 0x004A6899
		public IBatchBulletItemT()
		{
			this.Time = 0;
			this.CasterList = null;
		}
	}
}
