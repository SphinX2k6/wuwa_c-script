using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200666A RID: 26218
	public class IEnableHostilityT
	{
		// Token: 0x1700C2C5 RID: 49861
		// (get) Token: 0x0602D8C3 RID: 186563 RVA: 0x0063C813 File Offset: 0x0063AA13
		// (set) Token: 0x0602D8C4 RID: 186564 RVA: 0x0063C81B File Offset: 0x0063AA1B
		public bool IsEnable { get; set; }

		// Token: 0x1700C2C6 RID: 49862
		// (get) Token: 0x0602D8C5 RID: 186565 RVA: 0x0063C824 File Offset: 0x0063AA24
		// (set) Token: 0x0602D8C6 RID: 186566 RVA: 0x0063C82C File Offset: 0x0063AA2C
		public List<int> EntityIds { get; set; }

		// Token: 0x0602D8C7 RID: 186567 RVA: 0x0063C835 File Offset: 0x0063AA35
		public IEnableHostilityT()
		{
			this.IsEnable = false;
			this.EntityIds = null;
		}
	}
}
