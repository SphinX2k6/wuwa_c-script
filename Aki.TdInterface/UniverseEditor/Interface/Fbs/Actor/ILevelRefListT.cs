using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x02005EFE RID: 24318
	public class ILevelRefListT
	{
		// Token: 0x1700B5CC RID: 46540
		// (get) Token: 0x06029C58 RID: 171096 RVA: 0x005BB53D File Offset: 0x005B973D
		// (set) Token: 0x06029C59 RID: 171097 RVA: 0x005BB545 File Offset: 0x005B9745
		public List<ILevelRefDataT> LevelRefList { get; set; }

		// Token: 0x06029C5A RID: 171098 RVA: 0x005BB54E File Offset: 0x005B974E
		public ILevelRefListT()
		{
			this.LevelRefList = null;
		}
	}
}
