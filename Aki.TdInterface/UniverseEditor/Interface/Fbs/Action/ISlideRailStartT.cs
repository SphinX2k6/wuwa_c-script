using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007155 RID: 29013
	public class ISlideRailStartT
	{
		// Token: 0x1700D78A RID: 55178
		// (get) Token: 0x060336F4 RID: 210676 RVA: 0x006EE2F8 File Offset: 0x006EC4F8
		// (set) Token: 0x060336F5 RID: 210677 RVA: 0x006EE300 File Offset: 0x006EC500
		public int RailEntityId { get; set; }

		// Token: 0x1700D78B RID: 55179
		// (get) Token: 0x060336F6 RID: 210678 RVA: 0x006EE309 File Offset: 0x006EC509
		// (set) Token: 0x060336F7 RID: 210679 RVA: 0x006EE311 File Offset: 0x006EC511
		public string SlidePerformDaPath { get; set; }

		// Token: 0x1700D78C RID: 55180
		// (get) Token: 0x060336F8 RID: 210680 RVA: 0x006EE31A File Offset: 0x006EC51A
		// (set) Token: 0x060336F9 RID: 210681 RVA: 0x006EE322 File Offset: 0x006EC522
		public ISlideRailFollowConfigT SlideRailFollowConfig { get; set; }

		// Token: 0x1700D78D RID: 55181
		// (get) Token: 0x060336FA RID: 210682 RVA: 0x006EE32B File Offset: 0x006EC52B
		// (set) Token: 0x060336FB RID: 210683 RVA: 0x006EE333 File Offset: 0x006EC533
		public ISlideRailRTPCParamsT RTPCParams { get; set; }

		// Token: 0x060336FC RID: 210684 RVA: 0x006EE33C File Offset: 0x006EC53C
		public ISlideRailStartT()
		{
			this.RailEntityId = 0;
			this.SlidePerformDaPath = null;
			this.SlideRailFollowConfig = null;
			this.RTPCParams = null;
		}
	}
}
