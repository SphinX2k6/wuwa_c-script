using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FB4 RID: 28596
	public class IHideSpecifyEntityT
	{
		// Token: 0x1700D16C RID: 53612
		// (get) Token: 0x06031835 RID: 202805 RVA: 0x006B5EC3 File Offset: 0x006B40C3
		// (set) Token: 0x06031836 RID: 202806 RVA: 0x006B5ECB File Offset: 0x006B40CB
		public EHideType Type { get; set; }

		// Token: 0x1700D16D RID: 53613
		// (get) Token: 0x06031837 RID: 202807 RVA: 0x006B5ED4 File Offset: 0x006B40D4
		// (set) Token: 0x06031838 RID: 202808 RVA: 0x006B5EDC File Offset: 0x006B40DC
		public List<int> EntityIds { get; set; }

		// Token: 0x06031839 RID: 202809 RVA: 0x006B5EE5 File Offset: 0x006B40E5
		public IHideSpecifyEntityT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
			this.EntityIds = null;
		}
	}
}
