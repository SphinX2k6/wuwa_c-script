using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004887 RID: 18567
	public class ILevelPlaySyncBlockContextT
	{
		// Token: 0x170086A7 RID: 34471
		// (get) Token: 0x0601CF6C RID: 118636 RVA: 0x00417BE7 File Offset: 0x00415DE7
		// (set) Token: 0x0601CF6D RID: 118637 RVA: 0x00417BEF File Offset: 0x00415DEF
		public ESyncBlockContext Type { get; set; }

		// Token: 0x170086A8 RID: 34472
		// (get) Token: 0x0601CF6E RID: 118638 RVA: 0x00417BF8 File Offset: 0x00415DF8
		// (set) Token: 0x0601CF6F RID: 118639 RVA: 0x00417C00 File Offset: 0x00415E00
		public List<ISyncBlockGroupT> SyncBlockGroups { get; set; }

		// Token: 0x0601CF70 RID: 118640 RVA: 0x00417C09 File Offset: 0x00415E09
		public ILevelPlaySyncBlockContextT()
		{
			this.Type = ESyncBlockContext.Quest;
			this.SyncBlockGroups = null;
		}
	}
}
