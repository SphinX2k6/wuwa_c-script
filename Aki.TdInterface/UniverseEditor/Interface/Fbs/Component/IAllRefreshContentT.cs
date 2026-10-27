using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E99 RID: 20121
	public class IAllRefreshContentT
	{
		// Token: 0x1700904B RID: 36939
		// (get) Token: 0x0601FAA8 RID: 129704 RVA: 0x00468D8F File Offset: 0x00466F8F
		// (set) Token: 0x0601FAA9 RID: 129705 RVA: 0x00468D97 File Offset: 0x00466F97
		public ERefreshContent Type { get; set; }

		// Token: 0x1700904C RID: 36940
		// (get) Token: 0x0601FAAA RID: 129706 RVA: 0x00468DA0 File Offset: 0x00466FA0
		// (set) Token: 0x0601FAAB RID: 129707 RVA: 0x00468DA8 File Offset: 0x00466FA8
		public List<int> EntityIds { get; set; }

		// Token: 0x0601FAAC RID: 129708 RVA: 0x00468DB1 File Offset: 0x00466FB1
		public IAllRefreshContentT()
		{
			this.Type = ERefreshContent.All;
			this.EntityIds = null;
		}
	}
}
