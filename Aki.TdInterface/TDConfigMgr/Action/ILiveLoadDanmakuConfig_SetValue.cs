using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D66 RID: 7526
	public class ILiveLoadDanmakuConfig_SetValue
	{
		// Token: 0x04006138 RID: 24888
		public ELiveDanmakuOperationType Type;

		// Token: 0x04006139 RID: 24889
		public List<ILiveDanmakuPool> DanmakuPools;

		// Token: 0x0400613A RID: 24890
		public float? SendInterval;

		// Token: 0x0400613B RID: 24891
		public int? TrackCount;

		// Token: 0x0400613C RID: 24892
		public ELiveDanmakuLinkType LinkType;
	}
}
