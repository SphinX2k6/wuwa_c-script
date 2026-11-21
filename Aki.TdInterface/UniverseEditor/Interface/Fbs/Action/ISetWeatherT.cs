using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200787C RID: 30844
	public class ISetWeatherT
	{
		// Token: 0x1700E22F RID: 57903
		// (get) Token: 0x06036409 RID: 222217 RVA: 0x00744475 File Offset: 0x00742675
		// (set) Token: 0x0603640A RID: 222218 RVA: 0x0074447D File Offset: 0x0074267D
		public int WeatherId { get; set; }

		// Token: 0x1700E230 RID: 57904
		// (get) Token: 0x0603640B RID: 222219 RVA: 0x00744486 File Offset: 0x00742686
		// (set) Token: 0x0603640C RID: 222220 RVA: 0x0074448E File Offset: 0x0074268E
		public List<int> AreaIds { get; set; }

		// Token: 0x1700E231 RID: 57905
		// (get) Token: 0x0603640D RID: 222221 RVA: 0x00744497 File Offset: 0x00742697
		// (set) Token: 0x0603640E RID: 222222 RVA: 0x0074449F File Offset: 0x0074269F
		public byte NullMask { get; set; }

		// Token: 0x0603640F RID: 222223 RVA: 0x007444A8 File Offset: 0x007426A8
		public ISetWeatherT()
		{
			this.WeatherId = 0;
			this.AreaIds = null;
			this.NullMask = 0;
		}
	}
}
