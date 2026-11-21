using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076D9 RID: 30425
	public class ISceneUiSubtitleLocalizationConfigT
	{
		// Token: 0x1700DF33 RID: 57139
		// (get) Token: 0x06035629 RID: 218665 RVA: 0x00729201 File Offset: 0x00727401
		// (set) Token: 0x0603562A RID: 218666 RVA: 0x00729209 File Offset: 0x00727409
		public List<ISceneUiSubtitleLanguageOverrideT> OverrideList { get; set; }

		// Token: 0x0603562B RID: 218667 RVA: 0x00729212 File Offset: 0x00727412
		public ISceneUiSubtitleLocalizationConfigT()
		{
			this.OverrideList = null;
		}
	}
}
