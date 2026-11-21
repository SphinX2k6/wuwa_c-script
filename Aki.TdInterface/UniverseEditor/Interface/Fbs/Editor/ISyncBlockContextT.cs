using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D10 RID: 19728
	public class ISyncBlockContextT
	{
		// Token: 0x17008D2D RID: 36141
		// (get) Token: 0x0601E899 RID: 125081 RVA: 0x00446727 File Offset: 0x00444927
		// (set) Token: 0x0601E89A RID: 125082 RVA: 0x0044672F File Offset: 0x0044492F
		public ESyncBlockContext Type { get; set; }

		// Token: 0x17008D2E RID: 36142
		// (get) Token: 0x0601E89B RID: 125083 RVA: 0x00446738 File Offset: 0x00444938
		// (set) Token: 0x0601E89C RID: 125084 RVA: 0x00446740 File Offset: 0x00444940
		public List<ISyncBlockGroupT> SyncBlockGroups { get; set; }

		// Token: 0x0601E89D RID: 125085 RVA: 0x00446749 File Offset: 0x00444949
		public ISyncBlockContextT()
		{
			this.Type = ESyncBlockContext.Quest;
			this.SyncBlockGroups = null;
		}
	}
}
