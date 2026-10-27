using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007146 RID: 28998
	public class ISlideRailEndT
	{
		// Token: 0x1700D777 RID: 55159
		// (get) Token: 0x0603368E RID: 210574 RVA: 0x006ED87D File Offset: 0x006EBA7D
		// (set) Token: 0x0603368F RID: 210575 RVA: 0x006ED885 File Offset: 0x006EBA85
		public TSlideRailEndUnion EndTarget { get; set; }

		// Token: 0x06033690 RID: 210576 RVA: 0x006ED88E File Offset: 0x006EBA8E
		public ISlideRailEndT()
		{
			this.EndTarget = null;
		}
	}
}
