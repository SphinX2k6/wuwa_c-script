using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F1E RID: 16158
	public class ILowMemorySceneSwitchT
	{
		// Token: 0x1700705E RID: 28766
		// (get) Token: 0x06016F18 RID: 93976 RVA: 0x0034FA0F File Offset: 0x0034DC0F
		// (set) Token: 0x06016F19 RID: 93977 RVA: 0x0034FA17 File Offset: 0x0034DC17
		public ESpecialProcess Type { get; set; }

		// Token: 0x1700705F RID: 28767
		// (get) Token: 0x06016F1A RID: 93978 RVA: 0x0034FA20 File Offset: 0x0034DC20
		// (set) Token: 0x06016F1B RID: 93979 RVA: 0x0034FA28 File Offset: 0x0034DC28
		public List<TOperationUnion> Operations { get; set; }

		// Token: 0x06016F1C RID: 93980 RVA: 0x0034FA31 File Offset: 0x0034DC31
		public ILowMemorySceneSwitchT()
		{
			this.Type = ESpecialProcess.LowMemorySceneSwitch;
			this.Operations = null;
		}
	}
}
