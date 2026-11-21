using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D04 RID: 19716
	public class IQuestSyncBlockContextT
	{
		// Token: 0x17008D1B RID: 36123
		// (get) Token: 0x0601E833 RID: 124979 RVA: 0x00445C6B File Offset: 0x00443E6B
		// (set) Token: 0x0601E834 RID: 124980 RVA: 0x00445C73 File Offset: 0x00443E73
		public ESyncBlockContext Type { get; set; }

		// Token: 0x17008D1C RID: 36124
		// (get) Token: 0x0601E835 RID: 124981 RVA: 0x00445C7C File Offset: 0x00443E7C
		// (set) Token: 0x0601E836 RID: 124982 RVA: 0x00445C84 File Offset: 0x00443E84
		public List<ISyncBlockGroupT> SyncBlockGroups { get; set; }

		// Token: 0x0601E837 RID: 124983 RVA: 0x00445C8D File Offset: 0x00443E8D
		public IQuestSyncBlockContextT()
		{
			this.Type = ESyncBlockContext.Quest;
			this.SyncBlockGroups = null;
		}
	}
}
