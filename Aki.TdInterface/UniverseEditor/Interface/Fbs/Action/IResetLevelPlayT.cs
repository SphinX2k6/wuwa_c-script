using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007610 RID: 30224
	public class IResetLevelPlayT
	{
		// Token: 0x1700DE12 RID: 56850
		// (get) Token: 0x06035087 RID: 217223 RVA: 0x0071FBAD File Offset: 0x0071DDAD
		// (set) Token: 0x06035088 RID: 217224 RVA: 0x0071FBB5 File Offset: 0x0071DDB5
		public List<int> ResetLevelPlayList { get; set; }

		// Token: 0x06035089 RID: 217225 RVA: 0x0071FBBE File Offset: 0x0071DDBE
		public IResetLevelPlayT()
		{
			this.ResetLevelPlayList = null;
		}
	}
}
