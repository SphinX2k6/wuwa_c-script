using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007921 RID: 31009
	public class ISlideRailStartT
	{
		// Token: 0x1700E36F RID: 58223
		// (get) Token: 0x0603699E RID: 223646 RVA: 0x0074EB04 File Offset: 0x0074CD04
		// (set) Token: 0x0603699F RID: 223647 RVA: 0x0074EB0C File Offset: 0x0074CD0C
		public int RailEntityId { get; set; }

		// Token: 0x1700E370 RID: 58224
		// (get) Token: 0x060369A0 RID: 223648 RVA: 0x0074EB15 File Offset: 0x0074CD15
		// (set) Token: 0x060369A1 RID: 223649 RVA: 0x0074EB1D File Offset: 0x0074CD1D
		public string SlidePerformDaPath { get; set; }

		// Token: 0x1700E371 RID: 58225
		// (get) Token: 0x060369A2 RID: 223650 RVA: 0x0074EB26 File Offset: 0x0074CD26
		// (set) Token: 0x060369A3 RID: 223651 RVA: 0x0074EB2E File Offset: 0x0074CD2E
		public ISlideRailFollowConfigT SlideRailFollowConfig { get; set; }

		// Token: 0x1700E372 RID: 58226
		// (get) Token: 0x060369A4 RID: 223652 RVA: 0x0074EB37 File Offset: 0x0074CD37
		// (set) Token: 0x060369A5 RID: 223653 RVA: 0x0074EB3F File Offset: 0x0074CD3F
		public ISlideRailRTPCParamsT RTPCParams { get; set; }

		// Token: 0x060369A6 RID: 223654 RVA: 0x0074EB48 File Offset: 0x0074CD48
		public ISlideRailStartT()
		{
			this.RailEntityId = 0;
			this.SlidePerformDaPath = null;
			this.SlideRailFollowConfig = null;
			this.RTPCParams = null;
		}
	}
}
