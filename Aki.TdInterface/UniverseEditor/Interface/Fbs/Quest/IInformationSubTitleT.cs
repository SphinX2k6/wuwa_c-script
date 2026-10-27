using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EA3 RID: 16035
	public class IInformationSubTitleT
	{
		// Token: 0x17006F52 RID: 28498
		// (get) Token: 0x06016A46 RID: 92742 RVA: 0x00345286 File Offset: 0x00343486
		// (set) Token: 0x06016A47 RID: 92743 RVA: 0x0034528E File Offset: 0x0034348E
		public string TidTitle { get; set; }

		// Token: 0x17006F53 RID: 28499
		// (get) Token: 0x06016A48 RID: 92744 RVA: 0x00345297 File Offset: 0x00343497
		// (set) Token: 0x06016A49 RID: 92745 RVA: 0x0034529F File Offset: 0x0034349F
		public string TidContent { get; set; }

		// Token: 0x06016A4A RID: 92746 RVA: 0x003452A8 File Offset: 0x003434A8
		public IInformationSubTitleT()
		{
			this.TidTitle = null;
			this.TidContent = null;
		}
	}
}
