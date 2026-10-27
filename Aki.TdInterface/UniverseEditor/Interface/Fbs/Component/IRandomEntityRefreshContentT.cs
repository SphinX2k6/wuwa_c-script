using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057E5 RID: 22501
	public class IRandomEntityRefreshContentT
	{
		// Token: 0x1700A812 RID: 43026
		// (get) Token: 0x06025CF8 RID: 154872 RVA: 0x00537027 File Offset: 0x00535227
		// (set) Token: 0x06025CF9 RID: 154873 RVA: 0x0053702F File Offset: 0x0053522F
		public ERefreshContent Type { get; set; }

		// Token: 0x1700A813 RID: 43027
		// (get) Token: 0x06025CFA RID: 154874 RVA: 0x00537038 File Offset: 0x00535238
		// (set) Token: 0x06025CFB RID: 154875 RVA: 0x00537040 File Offset: 0x00535240
		public List<int> EntityIds { get; set; }

		// Token: 0x06025CFC RID: 154876 RVA: 0x00537049 File Offset: 0x00535249
		public IRandomEntityRefreshContentT()
		{
			this.Type = ERefreshContent.All;
			this.EntityIds = null;
		}
	}
}
