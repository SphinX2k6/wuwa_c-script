using System;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02005941 RID: 22849
	public interface IHonamiStoryPollution
	{
		// Token: 0x17008AFE RID: 35582
		// (get) Token: 0x0603A00D RID: 237581
		// (set) Token: 0x0603A00E RID: 237582
		int PollutionLevel { get; set; }

		// Token: 0x17008AFF RID: 35583
		// (get) Token: 0x0603A00F RID: 237583
		// (set) Token: 0x0603A010 RID: 237584
		int PersistMilliseconds { get; set; }

		// Token: 0x17008B00 RID: 35584
		// (get) Token: 0x0603A011 RID: 237585
		// (set) Token: 0x0603A012 RID: 237586
		int MonsterEnhanceLevel { get; set; }
	}
}
