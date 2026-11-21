using System;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x0200491A RID: 18714
	public interface IHonamiStoryPollution
	{
		// Token: 0x17005ECA RID: 24266
		// (get) Token: 0x0602EF30 RID: 192304
		// (set) Token: 0x0602EF31 RID: 192305
		int PollutionLevel { get; set; }

		// Token: 0x17005ECB RID: 24267
		// (get) Token: 0x0602EF32 RID: 192306
		// (set) Token: 0x0602EF33 RID: 192307
		int PersistMilliseconds { get; set; }

		// Token: 0x17005ECC RID: 24268
		// (get) Token: 0x0602EF34 RID: 192308
		// (set) Token: 0x0602EF35 RID: 192309
		int MonsterEnhanceLevel { get; set; }
	}
}
