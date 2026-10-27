using System;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x0200594B RID: 22859
	public class HonamiStoryTipsBuffInfo : IHonamiStoryTipsBuffInfo
	{
		// Token: 0x17008B16 RID: 35606
		// (get) Token: 0x0603A040 RID: 237632 RVA: 0x00DCA654 File Offset: 0x00DC8854
		// (set) Token: 0x0603A041 RID: 237633 RVA: 0x00DCA65C File Offset: 0x00DC885C
		public int BuffId { get; set; }

		// Token: 0x17008B17 RID: 35607
		// (get) Token: 0x0603A042 RID: 237634 RVA: 0x00DCA665 File Offset: 0x00DC8865
		// (set) Token: 0x0603A043 RID: 237635 RVA: 0x00DCA66D File Offset: 0x00DC886D
		public int? TagId { get; set; }

		// Token: 0x17008B18 RID: 35608
		// (get) Token: 0x0603A044 RID: 237636 RVA: 0x00DCA676 File Offset: 0x00DC8876
		// (set) Token: 0x0603A045 RID: 237637 RVA: 0x00DCA67E File Offset: 0x00DC887E
		public int? RoleId { get; set; }

		// Token: 0x17008B19 RID: 35609
		// (get) Token: 0x0603A046 RID: 237638 RVA: 0x00DCA687 File Offset: 0x00DC8887
		// (set) Token: 0x0603A047 RID: 237639 RVA: 0x00DCA68F File Offset: 0x00DC888F
		public bool FromTeamView { get; set; }
	}
}
