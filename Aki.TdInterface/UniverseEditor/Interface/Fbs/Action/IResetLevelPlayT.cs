using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E8C RID: 28300
	public class IResetLevelPlayT
	{
		// Token: 0x1700D2BB RID: 53947
		// (get) Token: 0x06032047 RID: 204871 RVA: 0x006C3E79 File Offset: 0x006C2079
		// (set) Token: 0x06032048 RID: 204872 RVA: 0x006C3E81 File Offset: 0x006C2081
		public List<int> ResetLevelPlayList { get; set; }

		// Token: 0x06032049 RID: 204873 RVA: 0x006C3E8A File Offset: 0x006C208A
		public IResetLevelPlayT()
		{
			this.ResetLevelPlayList = null;
		}
	}
}
