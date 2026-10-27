using System;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DC1 RID: 19905
	public class BossChallengeStateVisibility : IBossChallengeStateVisibility
	{
		// Token: 0x17007EB6 RID: 32438
		// (get) Token: 0x06033629 RID: 210473 RVA: 0x00BFF3E6 File Offset: 0x00BFD5E6
		// (set) Token: 0x0603362A RID: 210474 RVA: 0x00BFF3EE File Offset: 0x00BFD5EE
		public bool ShowUnlock { get; set; }

		// Token: 0x17007EB7 RID: 32439
		// (get) Token: 0x0603362B RID: 210475 RVA: 0x00BFF3F7 File Offset: 0x00BFD5F7
		// (set) Token: 0x0603362C RID: 210476 RVA: 0x00BFF3FF File Offset: 0x00BFD5FF
		public bool ShowEmptyIcon { get; set; }

		// Token: 0x17007EB8 RID: 32440
		// (get) Token: 0x0603362D RID: 210477 RVA: 0x00BFF408 File Offset: 0x00BFD608
		// (set) Token: 0x0603362E RID: 210478 RVA: 0x00BFF410 File Offset: 0x00BFD610
		public bool ShowFinished { get; set; }
	}
}
