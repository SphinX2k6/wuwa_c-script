using System;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02004923 RID: 18723
	public interface IHonamiStoryTipsBuffInfo
	{
		// Token: 0x17005EDE RID: 24286
		// (get) Token: 0x0602EF5B RID: 192347
		// (set) Token: 0x0602EF5C RID: 192348
		int BuffId { get; set; }

		// Token: 0x17005EDF RID: 24287
		// (get) Token: 0x0602EF5D RID: 192349
		// (set) Token: 0x0602EF5E RID: 192350
		int? TagId { get; set; }

		// Token: 0x17005EE0 RID: 24288
		// (get) Token: 0x0602EF5F RID: 192351
		// (set) Token: 0x0602EF60 RID: 192352
		int? RoleId { get; set; }

		// Token: 0x17005EE1 RID: 24289
		// (get) Token: 0x0602EF61 RID: 192353
		// (set) Token: 0x0602EF62 RID: 192354
		bool FromTeamView { get; set; }
	}
}
