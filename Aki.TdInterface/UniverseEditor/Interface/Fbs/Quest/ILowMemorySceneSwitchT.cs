using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200435C RID: 17244
	public class ILowMemorySceneSwitchT
	{
		// Token: 0x1700764D RID: 30285
		// (get) Token: 0x06018570 RID: 99696 RVA: 0x00378C37 File Offset: 0x00376E37
		// (set) Token: 0x06018571 RID: 99697 RVA: 0x00378C3F File Offset: 0x00376E3F
		public ESpecialProcess Type { get; set; }

		// Token: 0x1700764E RID: 30286
		// (get) Token: 0x06018572 RID: 99698 RVA: 0x00378C48 File Offset: 0x00376E48
		// (set) Token: 0x06018573 RID: 99699 RVA: 0x00378C50 File Offset: 0x00376E50
		public List<TOperationUnion> Operations { get; set; }

		// Token: 0x06018574 RID: 99700 RVA: 0x00378C59 File Offset: 0x00376E59
		public ILowMemorySceneSwitchT()
		{
			this.Type = ESpecialProcess.LowMemorySceneSwitch;
			this.Operations = null;
		}
	}
}
