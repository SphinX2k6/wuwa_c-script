using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C3D RID: 23613
	public class IOnEntityStateChangeAttachTimingT
	{
		// Token: 0x1700AD74 RID: 44404
		// (get) Token: 0x06027253 RID: 160339 RVA: 0x0055D293 File Offset: 0x0055B493
		// (set) Token: 0x06027254 RID: 160340 RVA: 0x0055D29B File Offset: 0x0055B49B
		public EAttachTimingType Type { get; set; }

		// Token: 0x1700AD75 RID: 44405
		// (get) Token: 0x06027255 RID: 160341 RVA: 0x0055D2A4 File Offset: 0x0055B4A4
		// (set) Token: 0x06027256 RID: 160342 RVA: 0x0055D2AC File Offset: 0x0055B4AC
		public List<IAttachTimingEntityStateConfigT> StateConfigs { get; set; }

		// Token: 0x06027257 RID: 160343 RVA: 0x0055D2B5 File Offset: 0x0055B4B5
		public IOnEntityStateChangeAttachTimingT()
		{
			this.Type = EAttachTimingType.Default;
			this.StateConfigs = null;
		}
	}
}
