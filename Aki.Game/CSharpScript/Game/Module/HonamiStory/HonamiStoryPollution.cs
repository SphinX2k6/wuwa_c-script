using System;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x0200491B RID: 18715
	public class HonamiStoryPollution : IHonamiStoryPollution
	{
		// Token: 0x17005ECD RID: 24269
		// (get) Token: 0x0602EF36 RID: 192310 RVA: 0x00D19830 File Offset: 0x00D17A30
		// (set) Token: 0x0602EF37 RID: 192311 RVA: 0x00D19838 File Offset: 0x00D17A38
		public int PollutionLevel { get; set; }

		// Token: 0x17005ECE RID: 24270
		// (get) Token: 0x0602EF38 RID: 192312 RVA: 0x00D19841 File Offset: 0x00D17A41
		// (set) Token: 0x0602EF39 RID: 192313 RVA: 0x00D19849 File Offset: 0x00D17A49
		public int PersistMilliseconds { get; set; }

		// Token: 0x17005ECF RID: 24271
		// (get) Token: 0x0602EF3A RID: 192314 RVA: 0x00D19852 File Offset: 0x00D17A52
		// (set) Token: 0x0602EF3B RID: 192315 RVA: 0x00D1985A File Offset: 0x00D17A5A
		public int MonsterEnhanceLevel { get; set; }
	}
}
