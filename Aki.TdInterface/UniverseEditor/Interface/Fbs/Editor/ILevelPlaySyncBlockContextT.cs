using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CEC RID: 19692
	public class ILevelPlaySyncBlockContextT
	{
		// Token: 0x17008CEF RID: 36079
		// (get) Token: 0x0601E759 RID: 124761 RVA: 0x00444383 File Offset: 0x00442583
		// (set) Token: 0x0601E75A RID: 124762 RVA: 0x0044438B File Offset: 0x0044258B
		public ESyncBlockContext Type { get; set; }

		// Token: 0x17008CF0 RID: 36080
		// (get) Token: 0x0601E75B RID: 124763 RVA: 0x00444394 File Offset: 0x00442594
		// (set) Token: 0x0601E75C RID: 124764 RVA: 0x0044439C File Offset: 0x0044259C
		public List<ISyncBlockGroupT> SyncBlockGroups { get; set; }

		// Token: 0x0601E75D RID: 124765 RVA: 0x004443A5 File Offset: 0x004425A5
		public ILevelPlaySyncBlockContextT()
		{
			this.Type = ESyncBlockContext.Quest;
			this.SyncBlockGroups = null;
		}
	}
}
