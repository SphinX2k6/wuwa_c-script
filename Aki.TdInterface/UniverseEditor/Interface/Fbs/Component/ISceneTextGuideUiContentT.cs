using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058E3 RID: 22755
	public class ISceneTextGuideUiContentT
	{
		// Token: 0x1700AA72 RID: 43634
		// (get) Token: 0x060266D2 RID: 157394 RVA: 0x0054BA84 File Offset: 0x00549C84
		// (set) Token: 0x060266D3 RID: 157395 RVA: 0x0054BA8C File Offset: 0x00549C8C
		public string TidText { get; set; }

		// Token: 0x1700AA73 RID: 43635
		// (get) Token: 0x060266D4 RID: 157396 RVA: 0x0054BA95 File Offset: 0x00549C95
		// (set) Token: 0x060266D5 RID: 157397 RVA: 0x0054BA9D File Offset: 0x00549C9D
		public List<ISceneTextGuideUiActionMappingIconT> ActionMappingIconList { get; set; }

		// Token: 0x1700AA74 RID: 43636
		// (get) Token: 0x060266D6 RID: 157398 RVA: 0x0054BAA6 File Offset: 0x00549CA6
		// (set) Token: 0x060266D7 RID: 157399 RVA: 0x0054BAAE File Offset: 0x00549CAE
		public List<string> MobileIconList { get; set; }

		// Token: 0x060266D8 RID: 157400 RVA: 0x0054BAB7 File Offset: 0x00549CB7
		public ISceneTextGuideUiContentT()
		{
			this.TidText = null;
			this.ActionMappingIconList = null;
			this.MobileIconList = null;
		}
	}
}
