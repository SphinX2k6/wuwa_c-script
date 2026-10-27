using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048AB RID: 18603
	public class ISyncBlockContextT
	{
		// Token: 0x170086E5 RID: 34533
		// (get) Token: 0x0601D0AC RID: 118956 RVA: 0x00419F8B File Offset: 0x0041818B
		// (set) Token: 0x0601D0AD RID: 118957 RVA: 0x00419F93 File Offset: 0x00418193
		public ESyncBlockContext Type { get; set; }

		// Token: 0x170086E6 RID: 34534
		// (get) Token: 0x0601D0AE RID: 118958 RVA: 0x00419F9C File Offset: 0x0041819C
		// (set) Token: 0x0601D0AF RID: 118959 RVA: 0x00419FA4 File Offset: 0x004181A4
		public List<ISyncBlockGroupT> SyncBlockGroups { get; set; }

		// Token: 0x0601D0B0 RID: 118960 RVA: 0x00419FAD File Offset: 0x004181AD
		public ISyncBlockContextT()
		{
			this.Type = ESyncBlockContext.Quest;
			this.SyncBlockGroups = null;
		}
	}
}
