using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200489F RID: 18591
	public class IQuestSyncBlockContextT
	{
		// Token: 0x170086D3 RID: 34515
		// (get) Token: 0x0601D046 RID: 118854 RVA: 0x004194CF File Offset: 0x004176CF
		// (set) Token: 0x0601D047 RID: 118855 RVA: 0x004194D7 File Offset: 0x004176D7
		public ESyncBlockContext Type { get; set; }

		// Token: 0x170086D4 RID: 34516
		// (get) Token: 0x0601D048 RID: 118856 RVA: 0x004194E0 File Offset: 0x004176E0
		// (set) Token: 0x0601D049 RID: 118857 RVA: 0x004194E8 File Offset: 0x004176E8
		public List<ISyncBlockGroupT> SyncBlockGroups { get; set; }

		// Token: 0x0601D04A RID: 118858 RVA: 0x004194F1 File Offset: 0x004176F1
		public IQuestSyncBlockContextT()
		{
			this.Type = ESyncBlockContext.Quest;
			this.SyncBlockGroups = null;
		}
	}
}
