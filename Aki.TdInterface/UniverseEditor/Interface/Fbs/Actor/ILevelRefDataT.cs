using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x02005EFB RID: 24315
	public class ILevelRefDataT
	{
		// Token: 0x1700B5C8 RID: 46536
		// (get) Token: 0x06029C3E RID: 171070 RVA: 0x005BB1F4 File Offset: 0x005B93F4
		// (set) Token: 0x06029C3F RID: 171071 RVA: 0x005BB1FC File Offset: 0x005B93FC
		public string LevelPath { get; set; }

		// Token: 0x1700B5C9 RID: 46537
		// (get) Token: 0x06029C40 RID: 171072 RVA: 0x005BB205 File Offset: 0x005B9405
		// (set) Token: 0x06029C41 RID: 171073 RVA: 0x005BB20D File Offset: 0x005B940D
		public List<IStreamingGroupT> StreamingGroups { get; set; }

		// Token: 0x06029C42 RID: 171074 RVA: 0x005BB216 File Offset: 0x005B9416
		public ILevelRefDataT()
		{
			this.LevelPath = null;
			this.StreamingGroups = null;
		}
	}
}
