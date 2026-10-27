using System;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x0200594A RID: 22858
	public interface IHonamiStoryTipsBuffInfo
	{
		// Token: 0x17008B12 RID: 35602
		// (get) Token: 0x0603A038 RID: 237624
		// (set) Token: 0x0603A039 RID: 237625
		int BuffId { get; set; }

		// Token: 0x17008B13 RID: 35603
		// (get) Token: 0x0603A03A RID: 237626
		// (set) Token: 0x0603A03B RID: 237627
		int? TagId { get; set; }

		// Token: 0x17008B14 RID: 35604
		// (get) Token: 0x0603A03C RID: 237628
		// (set) Token: 0x0603A03D RID: 237629
		int? RoleId { get; set; }

		// Token: 0x17008B15 RID: 35605
		// (get) Token: 0x0603A03E RID: 237630
		// (set) Token: 0x0603A03F RID: 237631
		bool FromTeamView { get; set; }
	}
}
