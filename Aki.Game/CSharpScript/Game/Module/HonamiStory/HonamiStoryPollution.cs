using System;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02005942 RID: 22850
	public class HonamiStoryPollution : IHonamiStoryPollution
	{
		// Token: 0x17008B01 RID: 35585
		// (get) Token: 0x0603A013 RID: 237587 RVA: 0x00DCA57C File Offset: 0x00DC877C
		// (set) Token: 0x0603A014 RID: 237588 RVA: 0x00DCA584 File Offset: 0x00DC8784
		public int PollutionLevel { get; set; }

		// Token: 0x17008B02 RID: 35586
		// (get) Token: 0x0603A015 RID: 237589 RVA: 0x00DCA58D File Offset: 0x00DC878D
		// (set) Token: 0x0603A016 RID: 237590 RVA: 0x00DCA595 File Offset: 0x00DC8795
		public int PersistMilliseconds { get; set; }

		// Token: 0x17008B03 RID: 35587
		// (get) Token: 0x0603A017 RID: 237591 RVA: 0x00DCA59E File Offset: 0x00DC879E
		// (set) Token: 0x0603A018 RID: 237592 RVA: 0x00DCA5A6 File Offset: 0x00DC87A6
		public int MonsterEnhanceLevel { get; set; }
	}
}
