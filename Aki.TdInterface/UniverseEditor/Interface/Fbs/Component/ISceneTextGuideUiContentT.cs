using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EF0 RID: 24304
	public class ISceneTextGuideUiContentT
	{
		// Token: 0x1700B3A2 RID: 45986
		// (get) Token: 0x06028C34 RID: 166964 RVA: 0x005925D0 File Offset: 0x005907D0
		// (set) Token: 0x06028C35 RID: 166965 RVA: 0x005925D8 File Offset: 0x005907D8
		public string TidText { get; set; }

		// Token: 0x1700B3A3 RID: 45987
		// (get) Token: 0x06028C36 RID: 166966 RVA: 0x005925E1 File Offset: 0x005907E1
		// (set) Token: 0x06028C37 RID: 166967 RVA: 0x005925E9 File Offset: 0x005907E9
		public List<ISceneTextGuideUiActionMappingIconT> ActionMappingIconList { get; set; }

		// Token: 0x1700B3A4 RID: 45988
		// (get) Token: 0x06028C38 RID: 166968 RVA: 0x005925F2 File Offset: 0x005907F2
		// (set) Token: 0x06028C39 RID: 166969 RVA: 0x005925FA File Offset: 0x005907FA
		public List<string> MobileIconList { get; set; }

		// Token: 0x06028C3A RID: 166970 RVA: 0x00592603 File Offset: 0x00590803
		public ISceneTextGuideUiContentT()
		{
			this.TidText = null;
			this.ActionMappingIconList = null;
			this.MobileIconList = null;
		}
	}
}
