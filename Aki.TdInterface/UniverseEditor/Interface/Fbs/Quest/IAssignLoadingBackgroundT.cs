using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200412B RID: 16683
	public class IAssignLoadingBackgroundT
	{
		// Token: 0x170070FF RID: 28927
		// (get) Token: 0x06016E6D RID: 93805 RVA: 0x00344DE7 File Offset: 0x00342FE7
		// (set) Token: 0x06016E6E RID: 93806 RVA: 0x00344DEF File Offset: 0x00342FEF
		public EOperation Type { get; set; }

		// Token: 0x17007100 RID: 28928
		// (get) Token: 0x06016E6F RID: 93807 RVA: 0x00344DF8 File Offset: 0x00342FF8
		// (set) Token: 0x06016E70 RID: 93808 RVA: 0x00344E00 File Offset: 0x00343000
		public string ImagePath { get; set; }

		// Token: 0x06016E71 RID: 93809 RVA: 0x00344E09 File Offset: 0x00343009
		public IAssignLoadingBackgroundT()
		{
			this.Type = EOperation.DisableHLOD;
			this.ImagePath = null;
		}
	}
}
