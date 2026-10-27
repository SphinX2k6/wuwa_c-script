using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EA6 RID: 16038
	public class IInformationViewT
	{
		// Token: 0x17006F57 RID: 28503
		// (get) Token: 0x06016A5C RID: 92764 RVA: 0x0034547C File Offset: 0x0034367C
		// (set) Token: 0x06016A5D RID: 92765 RVA: 0x00345484 File Offset: 0x00343684
		public EShowUiType Type { get; set; }

		// Token: 0x17006F58 RID: 28504
		// (get) Token: 0x06016A5E RID: 92766 RVA: 0x0034548D File Offset: 0x0034368D
		// (set) Token: 0x06016A5F RID: 92767 RVA: 0x00345495 File Offset: 0x00343695
		public int InformationViewId { get; set; }

		// Token: 0x06016A60 RID: 92768 RVA: 0x0034549E File Offset: 0x0034369E
		public IInformationViewT()
		{
			this.Type = EShowUiType.All;
			this.InformationViewId = 0;
		}
	}
}
